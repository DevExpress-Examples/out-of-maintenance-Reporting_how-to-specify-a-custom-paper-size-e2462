using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraPrinting;

namespace PrintCustomPaperSize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SimpleLink link = new SimpleLink(new PrintingSystem(), "Test");

            link.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            link.CustomPaperSize = new Size(200, 200);
            link.Margins = new System.Drawing.Printing.Margins(20, 20, 20, 20);
            link.MinMargins = new System.Drawing.Printing.Margins(0, 0, 0, 0);

            link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.PageSetup, CommandVisibility.None);
            
            link.ShowPreviewDialog();
        }

    }
}