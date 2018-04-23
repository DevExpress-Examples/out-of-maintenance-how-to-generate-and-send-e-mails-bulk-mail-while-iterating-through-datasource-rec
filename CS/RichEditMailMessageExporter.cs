using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DevExpress.XtraRichEdit;
using DevExpress.Utils;
using System.IO;
using DevExpress.XtraRichEdit.Export;
using DevExpress.Office.Utils;
using System.Drawing.Imaging;
using DevExpress.Office.Services;

namespace WindowsFormsApplication1 {
    public class RichEditMailMessageExporter : IUriProvider {
        readonly RichEditControl control;
        readonly Microsoft.Office.Interop.Outlook.MailItem mailItem;
        int imageId;
        string tempFiles = Path.Combine(Directory.GetCurrentDirectory(), "TempFiles");

        public RichEditMailMessageExporter(RichEditControl control, Microsoft.Office.Interop.Outlook.MailItem mailItem) {
            Guard.ArgumentNotNull(control, "control");
            Guard.ArgumentNotNull(mailItem, "mailItem");

            this.control = control;
            this.mailItem = mailItem;
        }

        public virtual void Export() {
            if(!Directory.Exists(tempFiles))
                Directory.CreateDirectory(tempFiles);

            control.BeforeExport += OnBeforeExport;
            string htmlBody = control.Document.GetHtmlText(control.Document.Range, this);
            control.BeforeExport -= OnBeforeExport;

            mailItem.BodyFormat = Microsoft.Office.Interop.Outlook.OlBodyFormat.olFormatHTML;
            mailItem.HTMLBody = htmlBody;
        }

        private void OnBeforeExport(object sender, BeforeExportEventArgs e) {
            HtmlDocumentExporterOptions options = e.Options as HtmlDocumentExporterOptions;
            if(options != null) {
                options.Encoding = Encoding.UTF8;
            }
        }

        #region IUriProvider Members
        public string CreateCssUri(string rootUri, string styleText, string relativeUri) {
            return String.Empty;
        }

        public string CreateImageUri(string rootUri, OfficeImage image, string relativeUri) {
            string imageName = String.Format("image{0}.png", imageId);
            imageId++;

            string imagePath = Path.Combine(tempFiles, imageName);

            image.NativeImage.Save(imagePath, ImageFormat.Png);

            mailItem.Attachments.Add(imagePath, Microsoft.Office.Interop.Outlook.OlAttachmentType.olByValue, 0, Type.Missing);

            return "cid:" + imageName;
        }
        #endregion
    }

}
