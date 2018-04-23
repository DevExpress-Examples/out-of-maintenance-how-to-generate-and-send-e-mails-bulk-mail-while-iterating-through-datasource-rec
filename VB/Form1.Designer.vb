Imports Microsoft.VisualBasic
Imports System
Namespace WindowsFormsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim serializableAppearanceObject1 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject2 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject3 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject4 As New DevExpress.Utils.SerializableAppearanceObject()
			Me.dataSet1 = New WindowsFormsApplication1.DataSet1()
			Me.snapControl1 = New DevExpress.Snap.SnapControl()
			Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
			Me.fileNewItem1 = New DevExpress.XtraRichEdit.UI.FileNewItem()
			Me.fileOpenItem1 = New DevExpress.XtraRichEdit.UI.FileOpenItem()
			Me.fileSaveItem1 = New DevExpress.XtraRichEdit.UI.FileSaveItem()
			Me.fileSaveAsItem1 = New DevExpress.XtraRichEdit.UI.FileSaveAsItem()
			Me.commandBarItem1 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
			Me.quickPrintItem1 = New DevExpress.XtraRichEdit.UI.QuickPrintItem()
			Me.printItem1 = New DevExpress.XtraRichEdit.UI.PrintItem()
			Me.printPreviewItem1 = New DevExpress.XtraRichEdit.UI.PrintPreviewItem()
			Me.undoItem1 = New DevExpress.XtraRichEdit.UI.UndoItem()
			Me.redoItem1 = New DevExpress.XtraRichEdit.UI.RedoItem()
			Me.commandBarItem2 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
			Me.commandBarCheckItem1 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
			Me.commandBarCheckItem2 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
			Me.commandBarCheckItem3 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
			Me.commandBarSubItem1 = New DevExpress.Snap.Extensions.UI.CommandBarSubItem()
			Me.commandBarCheckItem4 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
			Me.commandBarCheckItem5 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
			Me.commandBarCheckItem6 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
			Me.commandBarCheckItem7 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
			Me.commandBarCheckItem8 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
			Me.filterPopupButtonItem1 = New DevExpress.Snap.Extensions.UI.FilterPopupButtonItem()
			Me.propertiesBarButtonItem1 = New DevExpress.Snap.Extensions.UI.PropertiesBarButtonItem()
			Me.mailMergeDataSourceItem1 = New DevExpress.Snap.Extensions.UI.MailMergeDataSourceItem()
			Me.commandBarCheckItem9 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
			Me.commandBarCheckItem10 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
			Me.mailMergeCurrentRecordItem1 = New DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordItem()
			Me.repositoryItemMailMergeCurrentRecordEdit1 = New DevExpress.Snap.Extensions.UI.RepositoryItemMailMergeCurrentRecordEdit()
			Me.commandBarSubItem2 = New DevExpress.Snap.Extensions.UI.CommandBarSubItem()
			Me.commandBarItem3 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
			Me.commandBarItem4 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
			Me.commandBarItem5 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
			Me.checkSpellingItem1 = New DevExpress.XtraRichEdit.UI.CheckSpellingItem()
			Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
			Me.dataToolsRibbonPageCategory1 = New DevExpress.Snap.Extensions.UI.DataToolsRibbonPageCategory()
			Me.snMergeFieldToolsRibbonPage1 = New DevExpress.Snap.Extensions.UI.SNMergeFieldToolsRibbonPage()
			Me.dataShapingRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.DataShapingRibbonPageGroup()
			Me.snMergeFieldPropertiesRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.SNMergeFieldPropertiesRibbonPageGroup()
			Me.mailMergeRibbonPage1 = New DevExpress.Snap.Extensions.UI.MailMergeRibbonPage()
			Me.mailMergeRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.MailMergeRibbonPageGroup()
			Me.mailMergeCurrentRecordRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordRibbonPageGroup()
			Me.finishAndMergeRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.FinishAndMergeRibbonPageGroup()
			Me.fileRibbonPage1 = New DevExpress.XtraRichEdit.UI.FileRibbonPage()
			Me.commonRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup()
			Me.dataRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.DataRibbonPageGroup()
			Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.reviewRibbonPage1 = New DevExpress.XtraRichEdit.UI.ReviewRibbonPage()
			Me.documentProofingRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.DocumentProofingRibbonPageGroup()
			Me.snapDockManager1 = New DevExpress.Snap.Extensions.SnapDockManager(Me.components)
			Me.panelContainer1 = New DevExpress.XtraBars.Docking.DockPanel()
			Me.fieldListDockPanel1 = New DevExpress.Snap.Extensions.UI.FieldListDockPanel()
			Me.fieldListDockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
			Me.reportExplorerDockPanel1 = New DevExpress.Snap.Extensions.UI.ReportExplorerDockPanel()
			Me.reportExplorerDockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
			Me.dockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
			Me.dockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
			Me.memoEdit1 = New DevExpress.XtraEditors.MemoEdit()
			Me.snapDocumentManager1 = New DevExpress.Snap.Extensions.SnapDocumentManager(Me.components)
			Me.noDocumentsView1 = New DevExpress.XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView(Me.components)
			Me.snapBarController1 = New DevExpress.Snap.Extensions.SnapBarController()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemMailMergeCurrentRecordEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.snapDockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelContainer1.SuspendLayout()
			Me.fieldListDockPanel1.SuspendLayout()
			Me.reportExplorerDockPanel1.SuspendLayout()
			Me.dockPanel1.SuspendLayout()
			Me.dockPanel1_Container.SuspendLayout()
			CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.snapDocumentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.noDocumentsView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.snapBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dataSet1
			' 
			Me.dataSet1.DataSetName = "DataSet1"
			Me.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' snapControl1
			' 
			Me.snapControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.snapControl1.Location = New System.Drawing.Point(366, 144)
			Me.snapControl1.MenuManager = Me.ribbonControl1
			Me.snapControl1.Name = "snapControl1"
			Me.snapControl1.Options.Fields.UseCurrentCultureDateTimeFormat = False
			Me.snapControl1.Options.MailMerge.KeepLastParagraph = False
			Me.snapControl1.Options.SnapMailMergeVisualOptions.DataSourceName = Nothing
			Me.snapControl1.Size = New System.Drawing.Size(678, 570)
			Me.snapControl1.TabIndex = 0
			Me.snapControl1.Text = "snapControl1"
			' 
			' ribbonControl1
			' 
			Me.ribbonControl1.ExpandCollapseItem.Id = 0
			Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.fileNewItem1, Me.fileOpenItem1, Me.fileSaveItem1, Me.fileSaveAsItem1, Me.commandBarItem1, Me.quickPrintItem1, Me.printItem1, Me.printPreviewItem1, Me.undoItem1, Me.redoItem1, Me.commandBarItem2, Me.commandBarCheckItem1, Me.commandBarCheckItem2, Me.commandBarCheckItem3, Me.commandBarSubItem1, Me.commandBarCheckItem4, Me.commandBarCheckItem5, Me.commandBarCheckItem6, Me.commandBarCheckItem7, Me.commandBarCheckItem8, Me.filterPopupButtonItem1, Me.propertiesBarButtonItem1, Me.mailMergeDataSourceItem1, Me.commandBarCheckItem9, Me.commandBarCheckItem10, Me.mailMergeCurrentRecordItem1, Me.commandBarSubItem2, Me.commandBarItem3, Me.commandBarItem4, Me.commandBarItem5, Me.checkSpellingItem1, Me.barButtonItem1})
			Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
			Me.ribbonControl1.MaxItemId = 33
			Me.ribbonControl1.Name = "ribbonControl1"
			Me.ribbonControl1.PageCategories.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageCategory() { Me.dataToolsRibbonPageCategory1})
			Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.fileRibbonPage1, Me.reviewRibbonPage1})
			Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemMailMergeCurrentRecordEdit1})
			Me.ribbonControl1.Size = New System.Drawing.Size(1244, 144)
			' 
			' fileNewItem1
			' 
			Me.fileNewItem1.Id = 1
			Me.fileNewItem1.Name = "fileNewItem1"
			' 
			' fileOpenItem1
			' 
			Me.fileOpenItem1.Id = 2
			Me.fileOpenItem1.Name = "fileOpenItem1"
			' 
			' fileSaveItem1
			' 
			Me.fileSaveItem1.Id = 3
			Me.fileSaveItem1.Name = "fileSaveItem1"
			' 
			' fileSaveAsItem1
			' 
			Me.fileSaveAsItem1.Id = 4
			Me.fileSaveAsItem1.Name = "fileSaveAsItem1"
			' 
			' commandBarItem1
			' 
			Me.commandBarItem1.Id = 5
			Me.commandBarItem1.Name = "commandBarItem1"
			Me.commandBarItem1.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.ExportDocument
			' 
			' quickPrintItem1
			' 
			Me.quickPrintItem1.Id = 6
			Me.quickPrintItem1.Name = "quickPrintItem1"
			' 
			' printItem1
			' 
			Me.printItem1.Id = 7
			Me.printItem1.Name = "printItem1"
			' 
			' printPreviewItem1
			' 
			Me.printPreviewItem1.Id = 8
			Me.printPreviewItem1.Name = "printPreviewItem1"
			' 
			' undoItem1
			' 
			Me.undoItem1.Id = 9
			Me.undoItem1.Name = "undoItem1"
			' 
			' redoItem1
			' 
			Me.redoItem1.Id = 10
			Me.redoItem1.Name = "redoItem1"
			' 
			' commandBarItem2
			' 
			Me.commandBarItem2.Id = 11
			Me.commandBarItem2.Name = "commandBarItem2"
			Me.commandBarItem2.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.NewDataSource
			' 
			' commandBarCheckItem1
			' 
			Me.commandBarCheckItem1.Id = 12
			Me.commandBarCheckItem1.Name = "commandBarCheckItem1"
			Me.commandBarCheckItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			Me.commandBarCheckItem1.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.GroupByField
			' 
			' commandBarCheckItem2
			' 
			Me.commandBarCheckItem2.Id = 13
			Me.commandBarCheckItem2.Name = "commandBarCheckItem2"
			Me.commandBarCheckItem2.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SnapSortFieldAscending
			' 
			' commandBarCheckItem3
			' 
			Me.commandBarCheckItem3.Id = 14
			Me.commandBarCheckItem3.Name = "commandBarCheckItem3"
			Me.commandBarCheckItem3.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SnapSortFieldDescending
			' 
			' commandBarSubItem1
			' 
			Me.commandBarSubItem1.Id = 15
			Me.commandBarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem5), New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem6), New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem7), New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem8)})
			Me.commandBarSubItem1.Name = "commandBarSubItem1"
			Me.commandBarSubItem1.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SummaryByField
			' 
			' commandBarCheckItem4
			' 
			Me.commandBarCheckItem4.Id = 16
			Me.commandBarCheckItem4.Name = "commandBarCheckItem4"
			Me.commandBarCheckItem4.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SummaryCount
			' 
			' commandBarCheckItem5
			' 
			Me.commandBarCheckItem5.Id = 17
			Me.commandBarCheckItem5.Name = "commandBarCheckItem5"
			Me.commandBarCheckItem5.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SummarySum
			' 
			' commandBarCheckItem6
			' 
			Me.commandBarCheckItem6.Id = 18
			Me.commandBarCheckItem6.Name = "commandBarCheckItem6"
			Me.commandBarCheckItem6.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SummaryAverage
			' 
			' commandBarCheckItem7
			' 
			Me.commandBarCheckItem7.Id = 19
			Me.commandBarCheckItem7.Name = "commandBarCheckItem7"
			Me.commandBarCheckItem7.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SummaryMax
			' 
			' commandBarCheckItem8
			' 
			Me.commandBarCheckItem8.Id = 20
			Me.commandBarCheckItem8.Name = "commandBarCheckItem8"
			Me.commandBarCheckItem8.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SummaryMin
			' 
			' filterPopupButtonItem1
			' 
			Me.filterPopupButtonItem1.ActAsDropDown = True
			Me.filterPopupButtonItem1.Id = 21
			Me.filterPopupButtonItem1.Name = "filterPopupButtonItem1"
			' 
			' propertiesBarButtonItem1
			' 
			Me.propertiesBarButtonItem1.ActAsDropDown = True
			Me.propertiesBarButtonItem1.Id = 22
			Me.propertiesBarButtonItem1.Name = "propertiesBarButtonItem1"
			Me.propertiesBarButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' mailMergeDataSourceItem1
			' 
			Me.mailMergeDataSourceItem1.Id = 23
			Me.mailMergeDataSourceItem1.Name = "mailMergeDataSourceItem1"
			' 
			' commandBarCheckItem9
			' 
			Me.commandBarCheckItem9.Id = 24
			Me.commandBarCheckItem9.Name = "commandBarCheckItem9"
			Me.commandBarCheckItem9.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.MailMergeFilters
			' 
			' commandBarCheckItem10
			' 
			Me.commandBarCheckItem10.Id = 25
			Me.commandBarCheckItem10.Name = "commandBarCheckItem10"
			Me.commandBarCheckItem10.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.MailMergeSorting
			' 
			' mailMergeCurrentRecordItem1
			' 
			Me.mailMergeCurrentRecordItem1.Description = resources.GetString("mailMergeCurrentRecordItem1.Description")
			Me.mailMergeCurrentRecordItem1.Edit = Me.repositoryItemMailMergeCurrentRecordEdit1
			Me.mailMergeCurrentRecordItem1.Id = 26
			Me.mailMergeCurrentRecordItem1.Name = "mailMergeCurrentRecordItem1"
			Me.mailMergeCurrentRecordItem1.Width = 90
			' 
			' repositoryItemMailMergeCurrentRecordEdit1
			' 
			Me.repositoryItemMailMergeCurrentRecordEdit1.AutoHeight = False
			Me.repositoryItemMailMergeCurrentRecordEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 6, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleLeft, (CType(resources.GetObject("repositoryItemMailMergeCurrentRecordEdit1.Buttons"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "Previous", DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordEditorButtonTag.Prev, Nothing, True), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 6, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleRight, (CType(resources.GetObject("repositoryItemMailMergeCurrentRecordEdit1.Buttons1"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "Next", DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordEditorButtonTag.Next, Nothing, True), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 6, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleLeft, (CType(resources.GetObject("repositoryItemMailMergeCurrentRecordEdit1.Buttons2"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "First", DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordEditorButtonTag.First, Nothing, True), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 6, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleRight, (CType(resources.GetObject("repositoryItemMailMergeCurrentRecordEdit1.Buttons3"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "Last", DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordEditorButtonTag.Last, Nothing, True)})
			Me.repositoryItemMailMergeCurrentRecordEdit1.Name = "repositoryItemMailMergeCurrentRecordEdit1"
			' 
			' commandBarSubItem2
			' 
			Me.commandBarSubItem2.Id = 27
			Me.commandBarSubItem2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarItem5)})
			Me.commandBarSubItem2.Name = "commandBarSubItem2"
			Me.commandBarSubItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			Me.commandBarSubItem2.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.FinishAndMerge
			' 
			' commandBarItem3
			' 
			Me.commandBarItem3.Id = 28
			Me.commandBarItem3.Name = "commandBarItem3"
			Me.commandBarItem3.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SnapMailMergeExportDocument
			' 
			' commandBarItem4
			' 
			Me.commandBarItem4.Id = 29
			Me.commandBarItem4.Name = "commandBarItem4"
			Me.commandBarItem4.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SnapMailMergePrint
			' 
			' commandBarItem5
			' 
			Me.commandBarItem5.Id = 30
			Me.commandBarItem5.Name = "commandBarItem5"
			Me.commandBarItem5.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SnapMailMergePrintPreview
			' 
			' checkSpellingItem1
			' 
			Me.checkSpellingItem1.Id = 31
			Me.checkSpellingItem1.Name = "checkSpellingItem1"
			' 
			' barButtonItem1
			' 
			Me.barButtonItem1.Caption = "Generate and send letters"
			Me.barButtonItem1.Id = 32
			Me.barButtonItem1.Name = "barButtonItem1"
'			Me.barButtonItem1.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.barButtonItem1_ItemClick);
			' 
			' dataToolsRibbonPageCategory1
			' 
			Me.dataToolsRibbonPageCategory1.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(31))))), (CInt(Fix((CByte(166))))), (CInt(Fix((CByte(207))))))
			Me.dataToolsRibbonPageCategory1.Control = Me.snapControl1
			Me.dataToolsRibbonPageCategory1.Name = "dataToolsRibbonPageCategory1"
			Me.dataToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.snMergeFieldToolsRibbonPage1, Me.mailMergeRibbonPage1})
			' 
			' snMergeFieldToolsRibbonPage1
			' 
			Me.snMergeFieldToolsRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.dataShapingRibbonPageGroup1, Me.snMergeFieldPropertiesRibbonPageGroup1})
			Me.snMergeFieldToolsRibbonPage1.Name = "snMergeFieldToolsRibbonPage1"
			' 
			' dataShapingRibbonPageGroup1
			' 
			Me.dataShapingRibbonPageGroup1.ItemLinks.Add(Me.commandBarCheckItem1)
			Me.dataShapingRibbonPageGroup1.ItemLinks.Add(Me.commandBarCheckItem2)
			Me.dataShapingRibbonPageGroup1.ItemLinks.Add(Me.commandBarCheckItem3)
			Me.dataShapingRibbonPageGroup1.ItemLinks.Add(Me.commandBarSubItem1)
			Me.dataShapingRibbonPageGroup1.ItemLinks.Add(Me.filterPopupButtonItem1)
			Me.dataShapingRibbonPageGroup1.Name = "dataShapingRibbonPageGroup1"
			' 
			' snMergeFieldPropertiesRibbonPageGroup1
			' 
			Me.snMergeFieldPropertiesRibbonPageGroup1.ItemLinks.Add(Me.propertiesBarButtonItem1)
			Me.snMergeFieldPropertiesRibbonPageGroup1.Name = "snMergeFieldPropertiesRibbonPageGroup1"
			' 
			' mailMergeRibbonPage1
			' 
			Me.mailMergeRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.mailMergeRibbonPageGroup1, Me.mailMergeCurrentRecordRibbonPageGroup1, Me.finishAndMergeRibbonPageGroup1})
			Me.mailMergeRibbonPage1.Name = "mailMergeRibbonPage1"
			' 
			' mailMergeRibbonPageGroup1
			' 
			Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.mailMergeDataSourceItem1)
			Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.commandBarCheckItem9)
			Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.commandBarCheckItem10)
			Me.mailMergeRibbonPageGroup1.Name = "mailMergeRibbonPageGroup1"
			' 
			' mailMergeCurrentRecordRibbonPageGroup1
			' 
			Me.mailMergeCurrentRecordRibbonPageGroup1.ItemLinks.Add(Me.mailMergeCurrentRecordItem1)
			Me.mailMergeCurrentRecordRibbonPageGroup1.Name = "mailMergeCurrentRecordRibbonPageGroup1"
			' 
			' finishAndMergeRibbonPageGroup1
			' 
			Me.finishAndMergeRibbonPageGroup1.ItemLinks.Add(Me.commandBarSubItem2)
			Me.finishAndMergeRibbonPageGroup1.Name = "finishAndMergeRibbonPageGroup1"
			' 
			' fileRibbonPage1
			' 
			Me.fileRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.commonRibbonPageGroup1, Me.dataRibbonPageGroup1, Me.ribbonPageGroup1})
			Me.fileRibbonPage1.Name = "fileRibbonPage1"
			' 
			' commonRibbonPageGroup1
			' 
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileNewItem1)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileOpenItem1)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileSaveItem1)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileSaveAsItem1)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.commandBarItem1)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.quickPrintItem1)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.printItem1)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.printPreviewItem1)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.undoItem1)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.redoItem1)
			Me.commonRibbonPageGroup1.Name = "commonRibbonPageGroup1"
			' 
			' dataRibbonPageGroup1
			' 
			Me.dataRibbonPageGroup1.ItemLinks.Add(Me.commandBarItem2)
			Me.dataRibbonPageGroup1.Name = "dataRibbonPageGroup1"
			' 
			' ribbonPageGroup1
			' 
			Me.ribbonPageGroup1.ItemLinks.Add(Me.barButtonItem1)
			Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
			Me.ribbonPageGroup1.Text = "ribbonPageGroup1"
			' 
			' reviewRibbonPage1
			' 
			Me.reviewRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.documentProofingRibbonPageGroup1})
			Me.reviewRibbonPage1.Name = "reviewRibbonPage1"
			' 
			' documentProofingRibbonPageGroup1
			' 
			Me.documentProofingRibbonPageGroup1.ItemLinks.Add(Me.checkSpellingItem1)
			Me.documentProofingRibbonPageGroup1.Name = "documentProofingRibbonPageGroup1"
			' 
			' snapDockManager1
			' 
			Me.snapDockManager1.Form = Me
			Me.snapDockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() { Me.panelContainer1, Me.dockPanel1})
			Me.snapDockManager1.SnapControl = Me.snapControl1
			Me.snapDockManager1.TopZIndexControls.AddRange(New String() { "DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
			' 
			' panelContainer1
			' 
			Me.panelContainer1.Controls.Add(Me.fieldListDockPanel1)
			Me.panelContainer1.Controls.Add(Me.reportExplorerDockPanel1)
			Me.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
			Me.panelContainer1.ID = New System.Guid("7339c78d-95c5-4c32-b23f-e12e4d1804a9")
			Me.panelContainer1.Location = New System.Drawing.Point(1044, 144)
			Me.panelContainer1.Name = "panelContainer1"
			Me.panelContainer1.OriginalSize = New System.Drawing.Size(200, 200)
			Me.panelContainer1.Size = New System.Drawing.Size(200, 570)
			Me.panelContainer1.Text = "panelContainer1"
			' 
			' fieldListDockPanel1
			' 
			Me.fieldListDockPanel1.Controls.Add(Me.fieldListDockPanel1_Container)
			Me.fieldListDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
			Me.fieldListDockPanel1.ID = New System.Guid("94bc1d03-129d-44f9-9777-416dcf8b2264")
			Me.fieldListDockPanel1.Location = New System.Drawing.Point(0, 0)
			Me.fieldListDockPanel1.Name = "fieldListDockPanel1"
			Me.fieldListDockPanel1.OriginalSize = New System.Drawing.Size(200, 288)
			Me.fieldListDockPanel1.Size = New System.Drawing.Size(200, 285)
			Me.fieldListDockPanel1.SnapControl = Me.snapControl1
			Me.fieldListDockPanel1.Text = "Data Explorer"
			' 
			' fieldListDockPanel1_Container
			' 
			Me.fieldListDockPanel1_Container.Location = New System.Drawing.Point(4, 23)
			Me.fieldListDockPanel1_Container.Name = "fieldListDockPanel1_Container"
			Me.fieldListDockPanel1_Container.Size = New System.Drawing.Size(192, 258)
			Me.fieldListDockPanel1_Container.TabIndex = 0
			' 
			' reportExplorerDockPanel1
			' 
			Me.reportExplorerDockPanel1.Controls.Add(Me.reportExplorerDockPanel1_Container)
			Me.reportExplorerDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
			Me.reportExplorerDockPanel1.ID = New System.Guid("d01c1f36-5403-46e3-bba7-844d551e9eb7")
			Me.reportExplorerDockPanel1.Location = New System.Drawing.Point(0, 285)
			Me.reportExplorerDockPanel1.Name = "reportExplorerDockPanel1"
			Me.reportExplorerDockPanel1.OriginalSize = New System.Drawing.Size(200, 288)
			Me.reportExplorerDockPanel1.Size = New System.Drawing.Size(200, 285)
			Me.reportExplorerDockPanel1.SnapControl = Me.snapControl1
			Me.reportExplorerDockPanel1.Text = "Report Explorer"
			' 
			' reportExplorerDockPanel1_Container
			' 
			Me.reportExplorerDockPanel1_Container.Location = New System.Drawing.Point(4, 23)
			Me.reportExplorerDockPanel1_Container.Name = "reportExplorerDockPanel1_Container"
			Me.reportExplorerDockPanel1_Container.Size = New System.Drawing.Size(192, 258)
			Me.reportExplorerDockPanel1_Container.TabIndex = 0
			' 
			' dockPanel1
			' 
			Me.dockPanel1.Controls.Add(Me.dockPanel1_Container)
			Me.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
			Me.dockPanel1.ID = New System.Guid("a7c2acab-b97f-4e5c-bf91-6b77967de58c")
			Me.dockPanel1.Location = New System.Drawing.Point(0, 144)
			Me.dockPanel1.Name = "dockPanel1"
			Me.dockPanel1.OriginalSize = New System.Drawing.Size(366, 200)
			Me.dockPanel1.Size = New System.Drawing.Size(366, 570)
			Me.dockPanel1.Text = "E-mail results"
			' 
			' dockPanel1_Container
			' 
			Me.dockPanel1_Container.Controls.Add(Me.memoEdit1)
			Me.dockPanel1_Container.Location = New System.Drawing.Point(4, 23)
			Me.dockPanel1_Container.Name = "dockPanel1_Container"
			Me.dockPanel1_Container.Size = New System.Drawing.Size(358, 543)
			Me.dockPanel1_Container.TabIndex = 0
			' 
			' memoEdit1
			' 
			Me.memoEdit1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.memoEdit1.Location = New System.Drawing.Point(0, 0)
			Me.memoEdit1.MenuManager = Me.ribbonControl1
			Me.memoEdit1.Name = "memoEdit1"
			Me.memoEdit1.Size = New System.Drawing.Size(358, 543)
			Me.memoEdit1.TabIndex = 0
			Me.memoEdit1.UseOptimizedRendering = True
			' 
			' snapDocumentManager1
			' 
			Me.snapDocumentManager1.ClientControl = Me.snapControl1
			Me.snapDocumentManager1.View = Me.noDocumentsView1
			Me.snapDocumentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() { Me.noDocumentsView1})
			' 
			' snapBarController1
			' 
			Me.snapBarController1.BarItems.Add(Me.fileNewItem1)
			Me.snapBarController1.BarItems.Add(Me.fileOpenItem1)
			Me.snapBarController1.BarItems.Add(Me.fileSaveItem1)
			Me.snapBarController1.BarItems.Add(Me.fileSaveAsItem1)
			Me.snapBarController1.BarItems.Add(Me.commandBarItem1)
			Me.snapBarController1.BarItems.Add(Me.quickPrintItem1)
			Me.snapBarController1.BarItems.Add(Me.printItem1)
			Me.snapBarController1.BarItems.Add(Me.printPreviewItem1)
			Me.snapBarController1.BarItems.Add(Me.undoItem1)
			Me.snapBarController1.BarItems.Add(Me.redoItem1)
			Me.snapBarController1.BarItems.Add(Me.commandBarItem2)
			Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem1)
			Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem2)
			Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem3)
			Me.snapBarController1.BarItems.Add(Me.commandBarSubItem1)
			Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem4)
			Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem5)
			Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem6)
			Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem7)
			Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem8)
			Me.snapBarController1.BarItems.Add(Me.filterPopupButtonItem1)
			Me.snapBarController1.BarItems.Add(Me.propertiesBarButtonItem1)
			Me.snapBarController1.BarItems.Add(Me.mailMergeDataSourceItem1)
			Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem9)
			Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem10)
			Me.snapBarController1.BarItems.Add(Me.mailMergeCurrentRecordItem1)
			Me.snapBarController1.BarItems.Add(Me.commandBarSubItem2)
			Me.snapBarController1.BarItems.Add(Me.commandBarItem3)
			Me.snapBarController1.BarItems.Add(Me.commandBarItem4)
			Me.snapBarController1.BarItems.Add(Me.commandBarItem5)
			Me.snapBarController1.BarItems.Add(Me.checkSpellingItem1)
			Me.snapBarController1.ContextPageCategories.Add(New DevExpress.Snap.Extensions.UI.ContextRibbonPageCategoryItem(Me.dataToolsRibbonPageCategory1))
			Me.snapBarController1.Control = Me.snapControl1
			Me.snapBarController1.RibbonControl = Me.ribbonControl1
			Me.snapBarController1.SnapDockManager = Me.snapDockManager1
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1244, 714)
			Me.Controls.Add(Me.snapControl1)
			Me.Controls.Add(Me.dockPanel1)
			Me.Controls.Add(Me.panelContainer1)
			Me.Controls.Add(Me.ribbonControl1)
			Me.Name = "Form1"
			Me.Ribbon = Me.ribbonControl1
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemMailMergeCurrentRecordEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.snapDockManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelContainer1.ResumeLayout(False)
			Me.fieldListDockPanel1.ResumeLayout(False)
			Me.reportExplorerDockPanel1.ResumeLayout(False)
			Me.dockPanel1.ResumeLayout(False)
			Me.dockPanel1_Container.ResumeLayout(False)
			CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.snapDocumentManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.noDocumentsView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.snapBarController1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private dataSet1 As DataSet1
		Private snapControl1 As DevExpress.Snap.SnapControl
		Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
		Private fileNewItem1 As DevExpress.XtraRichEdit.UI.FileNewItem
		Private fileOpenItem1 As DevExpress.XtraRichEdit.UI.FileOpenItem
		Private fileSaveItem1 As DevExpress.XtraRichEdit.UI.FileSaveItem
		Private fileSaveAsItem1 As DevExpress.XtraRichEdit.UI.FileSaveAsItem
		Private commandBarItem1 As DevExpress.Snap.Extensions.UI.CommandBarItem
		Private quickPrintItem1 As DevExpress.XtraRichEdit.UI.QuickPrintItem
		Private printItem1 As DevExpress.XtraRichEdit.UI.PrintItem
		Private printPreviewItem1 As DevExpress.XtraRichEdit.UI.PrintPreviewItem
		Private undoItem1 As DevExpress.XtraRichEdit.UI.UndoItem
		Private redoItem1 As DevExpress.XtraRichEdit.UI.RedoItem
		Private commandBarItem2 As DevExpress.Snap.Extensions.UI.CommandBarItem
		Private commandBarCheckItem1 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
		Private commandBarCheckItem2 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
		Private commandBarCheckItem3 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
		Private commandBarSubItem1 As DevExpress.Snap.Extensions.UI.CommandBarSubItem
		Private commandBarCheckItem4 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
		Private commandBarCheckItem5 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
		Private commandBarCheckItem6 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
		Private commandBarCheckItem7 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
		Private commandBarCheckItem8 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
		Private filterPopupButtonItem1 As DevExpress.Snap.Extensions.UI.FilterPopupButtonItem
		Private propertiesBarButtonItem1 As DevExpress.Snap.Extensions.UI.PropertiesBarButtonItem
		Private mailMergeDataSourceItem1 As DevExpress.Snap.Extensions.UI.MailMergeDataSourceItem
		Private commandBarCheckItem9 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
		Private commandBarCheckItem10 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
		Private mailMergeCurrentRecordItem1 As DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordItem
		Private repositoryItemMailMergeCurrentRecordEdit1 As DevExpress.Snap.Extensions.UI.RepositoryItemMailMergeCurrentRecordEdit
		Private commandBarSubItem2 As DevExpress.Snap.Extensions.UI.CommandBarSubItem
		Private commandBarItem3 As DevExpress.Snap.Extensions.UI.CommandBarItem
		Private commandBarItem4 As DevExpress.Snap.Extensions.UI.CommandBarItem
		Private commandBarItem5 As DevExpress.Snap.Extensions.UI.CommandBarItem
		Private checkSpellingItem1 As DevExpress.XtraRichEdit.UI.CheckSpellingItem
		Private dataToolsRibbonPageCategory1 As DevExpress.Snap.Extensions.UI.DataToolsRibbonPageCategory
		Private snMergeFieldToolsRibbonPage1 As DevExpress.Snap.Extensions.UI.SNMergeFieldToolsRibbonPage
		Private dataShapingRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.DataShapingRibbonPageGroup
		Private snMergeFieldPropertiesRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.SNMergeFieldPropertiesRibbonPageGroup
		Private mailMergeRibbonPage1 As DevExpress.Snap.Extensions.UI.MailMergeRibbonPage
		Private mailMergeRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.MailMergeRibbonPageGroup
		Private mailMergeCurrentRecordRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordRibbonPageGroup
		Private finishAndMergeRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.FinishAndMergeRibbonPageGroup
		Private fileRibbonPage1 As DevExpress.XtraRichEdit.UI.FileRibbonPage
		Private commonRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup
		Private dataRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.DataRibbonPageGroup
		Private reviewRibbonPage1 As DevExpress.XtraRichEdit.UI.ReviewRibbonPage
		Private documentProofingRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.DocumentProofingRibbonPageGroup
		Private snapDockManager1 As DevExpress.Snap.Extensions.SnapDockManager
		Private panelContainer1 As DevExpress.XtraBars.Docking.DockPanel
		Private fieldListDockPanel1 As DevExpress.Snap.Extensions.UI.FieldListDockPanel
		Private fieldListDockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
		Private reportExplorerDockPanel1 As DevExpress.Snap.Extensions.UI.ReportExplorerDockPanel
		Private reportExplorerDockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
		Private snapDocumentManager1 As DevExpress.Snap.Extensions.SnapDocumentManager
		Private noDocumentsView1 As DevExpress.XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView
		Private snapBarController1 As DevExpress.Snap.Extensions.SnapBarController
		Private WithEvents barButtonItem1 As DevExpress.XtraBars.BarButtonItem
		Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private dockPanel1 As DevExpress.XtraBars.Docking.DockPanel
		Private dockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
		Private memoEdit1 As DevExpress.XtraEditors.MemoEdit

	End Class
End Namespace

