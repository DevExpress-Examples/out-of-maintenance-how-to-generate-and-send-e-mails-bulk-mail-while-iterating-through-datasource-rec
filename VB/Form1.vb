Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.Snap.Core.API
Imports DevExpress.XtraRichEdit
Imports System.IO
Imports System.Reflection

Namespace WindowsFormsApplication1
	Partial Public Class Form1
		Inherits RibbonForm

		Private templateStream As Stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("testMailTemplate.snx")
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			FillTestDataSource()
		End Sub

		Private Sub FillTestDataSource()
			For i As Integer = 0 To 5
				Dim mainTable As DataTable = dataSet1.Tables("MainTable")
				mainTable.Rows.Add(New Object() { i, False, "Some description for master table, row: " & i.ToString(), 0, 0, "", String.Format("someMailAddress{0}@mail.ru", i) })
				For j As Integer = 0 To 4
					Dim childTable As DataTable = dataSet1.Tables("ChildTable")
					childTable.Rows.Add(New Object() { i, j * 2, "Some description for child table, row: " & j.ToString(), j * 50.8, j * 12.5, "SNS", "" })
				Next j
			Next i
		End Sub

		Private lettersCache As New List(Of CustomerEmailData)()
		Private CurrentEmailIndex As Integer

		Private Sub barButtonItem1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem1.ItemClick
			GenerateContenrFiles()
			SendLetters()
		End Sub

		Private Sub SendLetters()
			AddHandler snapControl1.DocumentLoaded, AddressOf snapControl1_Letter_DocumentLoaded
			CurrentEmailIndex = 0
			SendCurrentLetter(CurrentEmailIndex)
		End Sub

		Private Sub snapControl1_Letter_DocumentLoaded(ByVal sender As Object, ByVal e As EventArgs)
			BeginInvoke(New MethodInvoker(Function() AnonymousMethod1()))
		End Sub
		
		Private Function AnonymousMethod1() As Boolean
			memoEdit1.Text += String.Format("Letter: {0}, was sent to {1}" & Constants.vbCrLf, lettersCache(CurrentEmailIndex).ContentFileName, lettersCache(CurrentEmailIndex).CustomerEMail)
			Dim application As New Microsoft.Office.Interop.Outlook.Application()
			Dim mailItem As Microsoft.Office.Interop.Outlook.MailItem = CType(application.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem), Microsoft.Office.Interop.Outlook.MailItem)
			mailItem.To = lettersCache(CurrentEmailIndex).CustomerEMail
			mailItem.Subject = lettersCache(CurrentEmailIndex).EMailSubject
			Dim exporter As New RichEditMailMessageExporter(snapControl1, mailItem)
			exporter.Export()
			mailItem.Save()
			CurrentEmailIndex += 1
			SendCurrentLetter(CurrentEmailIndex)
			Return True
		End Function

		Private Sub SendCurrentLetter(ByVal letterIndex As Integer)
			If letterIndex < lettersCache.Count - 1 Then
				snapControl1.LoadDocument(lettersCache(letterIndex).ContentFileName, DocumentFormat.Rtf)
			Else
				RemoveHandler snapControl1.DocumentLoaded, AddressOf snapControl1_Letter_DocumentLoaded
			End If
		End Sub

		Private Sub GenerateContenrFiles()
			lettersCache.Clear()
			snapControl1.LoadDocument(templateStream, SnapDocumentFormat.Snap)

			Dim mainTable As DataTable = dataSet1.Tables("MainTable")
			Dim masterRowIndex As Integer = 0
			For Each masterRow As DataRow In mainTable.Rows

				Dim childView As New DataView(dataSet1.Tables("ChildTable"))
				childView.RowFilter = String.Format("ParentID = {0}", masterRow("ID"))

				snapControl1.Options.SnapMailMergeVisualOptions.DataSource = childView
				For i As Integer = 0 To childView.Count - 1
					snapControl1.Options.SnapMailMergeVisualOptions.CurrentRecordIndex = i
					If (Not System.IO.Directory.Exists("ResultMails")) Then
						System.IO.Directory.CreateDirectory("ResultMails")
					End If
					snapControl1.SaveDocument(String.Format("ResultMails\tempResultLetter_{0}_{1}.rtf", masterRowIndex, i), DocumentFormat.Rtf)

					Dim emailData As New CustomerEmailData()
					emailData.CustomerEMail = masterRow("EMailAddress").ToString()
					emailData.ContentFileName = String.Format("ResultMails\tempResultLetter_{0}_{1}.rtf", masterRowIndex, i)
					emailData.EMailSubject = "Testing Mail Merge using the SnapControl"
					lettersCache.Add(emailData)
				Next i
				masterRowIndex += 1
			Next masterRow
		End Sub
	End Class

	Public Class CustomerEmailData
		Private privateContentFileName As String
		Public Property ContentFileName() As String
			Get
				Return privateContentFileName
			End Get
			Set(ByVal value As String)
				privateContentFileName = value
			End Set
		End Property
		Private privateCustomerEMail As String
		Public Property CustomerEMail() As String
			Get
				Return privateCustomerEMail
			End Get
			Set(ByVal value As String)
				privateCustomerEMail = value
			End Set
		End Property
		Private privateEMailSubject As String
		Public Property EMailSubject() As String
			Get
				Return privateEMailSubject
			End Get
			Set(ByVal value As String)
				privateEMailSubject = value
			End Set
		End Property

	End Class
End Namespace
