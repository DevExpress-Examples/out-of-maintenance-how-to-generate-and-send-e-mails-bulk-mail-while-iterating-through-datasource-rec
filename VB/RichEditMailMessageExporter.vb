Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Imports DevExpress.XtraRichEdit
Imports DevExpress.Utils
Imports System.IO
Imports DevExpress.XtraRichEdit.Export
Imports DevExpress.Office.Utils
Imports System.Drawing.Imaging
Imports DevExpress.Office.Services

Namespace WindowsFormsApplication1
	Public Class RichEditMailMessageExporter
		Implements IUriProvider
		Private ReadOnly control As RichEditControl
		Private ReadOnly mailItem As Microsoft.Office.Interop.Outlook.MailItem
		Private imageId As Integer
		Private tempFiles As String = Path.Combine(Directory.GetCurrentDirectory(), "TempFiles")

		Public Sub New(ByVal control As RichEditControl, ByVal mailItem As Microsoft.Office.Interop.Outlook.MailItem)
			Guard.ArgumentNotNull(control, "control")
			Guard.ArgumentNotNull(mailItem, "mailItem")

			Me.control = control
			Me.mailItem = mailItem
		End Sub

		Public Overridable Sub Export()
			If (Not Directory.Exists(tempFiles)) Then
				Directory.CreateDirectory(tempFiles)
			End If

			AddHandler control.BeforeExport, AddressOf OnBeforeExport
			Dim htmlBody As String = control.Document.GetHtmlText(control.Document.Range, Me)
			RemoveHandler control.BeforeExport, AddressOf OnBeforeExport

			mailItem.BodyFormat = Microsoft.Office.Interop.Outlook.OlBodyFormat.olFormatHTML
			mailItem.HTMLBody = htmlBody
		End Sub

		Private Sub OnBeforeExport(ByVal sender As Object, ByVal e As BeforeExportEventArgs)
			Dim options As HtmlDocumentExporterOptions = TryCast(e.Options, HtmlDocumentExporterOptions)
			If options IsNot Nothing Then
				options.Encoding = Encoding.UTF8
			End If
		End Sub

		#Region "IUriProvider Members"
        Public Function CreateCssUri(ByVal rootUri As String, ByVal styleText As String, ByVal relativeUri As String) As String Implements IUriProvider.CreateCssUri
            Return String.Empty
        End Function

        Public Function CreateImageUri(ByVal rootUri As String, ByVal image As OfficeImage, ByVal relativeUri As String) As String Implements IUriProvider.CreateImageUri
            Dim imageName As String = String.Format("image{0}.png", imageId)
            imageId += 1

            Dim imagePath As String = Path.Combine(tempFiles, imageName)

            image.NativeImage.Save(imagePath, ImageFormat.Png)

            mailItem.Attachments.Add(imagePath, Microsoft.Office.Interop.Outlook.OlAttachmentType.olByValue, 0, Type.Missing)

            Return "cid:" & imageName
        End Function
		#End Region
	End Class

End Namespace
