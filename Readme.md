# How to specify a custom paper size


<p>This example demonstrates how to specify a custom paper size for a document (the LinkBase.PaperKind and LinkBase.CustomPaperSize properties are used for this purpose). Please note that a certain printer on which you want to print a resulting document may produce an incorrect output. This problem might be caused by the fact that this printer does not support a specified custom paper size (the way the custom paper size is handled depends on a particular printer driver). At that point, it's impossible to obtain a correct printout of the document with a custom paper size using inappropriate (for this size) printer drivers. However, the technique, shown in this example, might be very useful for exporting scenarios (e. g. see the <a href="https://www.devexpress.com/Support/Center/p/Q271392">Question regarding Q265878</a>).</p>

<br/>


