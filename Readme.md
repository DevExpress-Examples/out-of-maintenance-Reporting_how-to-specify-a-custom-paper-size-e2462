<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2462)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
* [SimpleLink.cs](./CS/SimpleLink.cs) (VB: [SimpleLink.vb](./VB/SimpleLink.vb))
<!-- default file list end -->
# How to specify a custom paper size


<p>This example demonstrates how to specify a custom paper size for a document (the LinkBase.PaperKind and LinkBase.CustomPaperSize properties are used for this purpose). Please note that a certain printer on which you want to print a resulting document may produce an incorrect output. This problem might be caused by the fact that this printer does not support a specified custom paper size (the way the custom paper size is handled depends on a particular printer driver). At that point, it's impossible to obtain a correct printout of the document with a custom paper size using inappropriate (for this size) printer drivers. However, the technique, shown in this example, might be very useful for exporting scenarios (e. g. see the <a href="https://www.devexpress.com/Support/Center/p/Q271392">Question regarding Q265878</a>).</p>

<br/>


