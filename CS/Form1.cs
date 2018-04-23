using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using DevExpress.XtraBars.Ribbon;
using DevExpress.Snap.Core.API;
using DevExpress.XtraRichEdit;
using System.IO;
using System.Reflection;

namespace WindowsFormsApplication1 {
    public partial class Form1 : RibbonForm {

        Stream templateStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("WindowsFormsApplication1.testMailTemplate.snx");
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            FillTestDataSource();
        }

        private void FillTestDataSource() {
            for(int i = 0; i < 6; i++) {
                DataTable mainTable = dataSet1.Tables["MainTable"];
                mainTable.Rows.Add(new object[] { i, false, "Some description for master table, row: " + i.ToString(), 0, 0, "", String.Format("someMailAddress{0}@mail.ru", i) });
                for(int j = 0; j < 5; j++) {
                    DataTable childTable = dataSet1.Tables["ChildTable"];
                    childTable.Rows.Add(new object[] { i, j * 2, "Some description for child table, row: " + j.ToString(), j * 50.8, j * 12.5, "SNS", "" });
                }
            }
        }

        List<CustomerEmailData> lettersCache = new List<CustomerEmailData>();
        int CurrentEmailIndex;

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            GenerateContenrFiles();
            SendLetters();
        }

        private void SendLetters() {
            snapControl1.DocumentLoaded += new EventHandler(snapControl1_Letter_DocumentLoaded);
            CurrentEmailIndex = 0;
            SendCurrentLetter(CurrentEmailIndex);
        }

        void snapControl1_Letter_DocumentLoaded(object sender, EventArgs e) {
            BeginInvoke(new MethodInvoker(delegate {
                memoEdit1.Text += String.Format("Letter: {0}, was sent to {1}\r\n", lettersCache[CurrentEmailIndex].ContentFileName, lettersCache[CurrentEmailIndex].CustomerEMail);

                Microsoft.Office.Interop.Outlook.Application application = new Microsoft.Office.Interop.Outlook.Application();
                Microsoft.Office.Interop.Outlook.MailItem mailItem = (Microsoft.Office.Interop.Outlook.MailItem)application.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);

                mailItem.To = lettersCache[CurrentEmailIndex].CustomerEMail;
                mailItem.Subject = lettersCache[CurrentEmailIndex].EMailSubject;

                RichEditMailMessageExporter exporter = new RichEditMailMessageExporter(snapControl1, mailItem);
                exporter.Export();

                mailItem.Save();


                CurrentEmailIndex++;
                SendCurrentLetter(CurrentEmailIndex);
            }));
        }

        private void SendCurrentLetter(int letterIndex) {
            if(letterIndex < lettersCache.Count - 1) {
                snapControl1.LoadDocument(lettersCache[letterIndex].ContentFileName, DocumentFormat.Rtf);
            }
            else {
                snapControl1.DocumentLoaded -= new EventHandler(snapControl1_Letter_DocumentLoaded);
            }
        }

        private void GenerateContenrFiles() {
            lettersCache.Clear();
            snapControl1.LoadDocument(templateStream, SnapDocumentFormat.Snap);

            DataTable mainTable = dataSet1.Tables["MainTable"];
            int masterRowIndex = 0;
            foreach(DataRow masterRow in mainTable.Rows) {

                DataView childView = new DataView(dataSet1.Tables["ChildTable"]);
                childView.RowFilter = String.Format("ParentID = {0}", masterRow["ID"]);

                snapControl1.Options.SnapMailMergeVisualOptions.DataSource = childView;
                for(int i = 0; i < childView.Count; i++) {
                    snapControl1.Options.SnapMailMergeVisualOptions.CurrentRecordIndex = i;
                    if(!System.IO.Directory.Exists("ResultMails")) {
                        System.IO.Directory.CreateDirectory("ResultMails");
                    }
                    snapControl1.SaveDocument(String.Format("ResultMails\\tempResultLetter_{0}_{1}.rtf", masterRowIndex, i), DocumentFormat.Rtf);

                    CustomerEmailData emailData = new CustomerEmailData();
                    emailData.CustomerEMail = masterRow["EMailAddress"].ToString();
                    emailData.ContentFileName = String.Format("ResultMails\\tempResultLetter_{0}_{1}.rtf", masterRowIndex, i);
                    emailData.EMailSubject = "Testing Mail Merge using the SnapControl";
                    lettersCache.Add(emailData);
                }
                masterRowIndex++;
            }
        }
    }

    public class CustomerEmailData {
        public string ContentFileName { get; set; }
        public string CustomerEMail { get; set; }
        public string EMailSubject { get; set; }

    }
}
