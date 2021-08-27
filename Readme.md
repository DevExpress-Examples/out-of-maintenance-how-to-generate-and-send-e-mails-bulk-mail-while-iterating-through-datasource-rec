<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128608688/13.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5006)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [RichEditMailMessageExporter.cs](./CS/RichEditMailMessageExporter.cs) (VB: [RichEditMailMessageExporter.vb](./VB/RichEditMailMessageExporter.vb))
<!-- default file list end -->
# How to generate and send e-mails (bulk mail) while iterating through datasource records


<p>In some scenarios, you need to generate e-mail letters and send them while iterating through some datasource records.</p><p>Let's consider the following scenario. We have a master-detail database. A master table contains information about customers whom we need to send letters. A detail table contains information to generate letters.</p><br />
<p>To generate and send letters, we need to perform the following actions while iterating through the data source:</p><p>1. Create a filtered view from the child table based on the customer's ID.</p><p>2. Use this view as a SnapControl's mail merge data source.</p><p>3. Iterate through this view records.</p><p>4. Perform the mail-merge operation.</p><p>5. Generate an e-mail letter based on the SnapControl's document as demonstrated in the following example: <a href="https://www.devexpress.com/Support/Center/p/E4438">How to export the RichEditControl document into an Outlook mail item</a><u></u></p><p><u></u>You may notice only one issue. The content of some letters will be generated incorrectly.</p><p>This occurs since the loading of the mail template into the SnapControl is executed asynchronously and can require more time than iterating to the next datasource record.</p><p>When a document is completely loaded into the SnapControl (or RichEditControl), the DocumentLoaded event is raised.</p><br />
<p>To avoid the issue with an incorrectly generated content of a letter, you need to send letters in the DocumentLoaded event handler.</p><p>We recommend saving generated letters in a temporary folder while iterating through datasource records.</p><p>After all letters are saved, load these files and send the letters synchronously in the SnapControl.DocumentLoaded event handler.</p><p>This example demonstrates this approach in action.</p>

<br/>


