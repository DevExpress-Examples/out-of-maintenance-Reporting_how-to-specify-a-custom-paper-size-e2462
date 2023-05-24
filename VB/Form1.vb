Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Drawing.Printing
Imports DevExpress.XtraPrinting

Namespace PrintCustomPaperSize

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim link As SimpleLink = New SimpleLink(New PrintingSystem(), "Test")
            link.PaperKind = DXPaperKind.Custom
            link.CustomPaperSize = New Size(200, 200)
            link.Margins = New System.Drawing.Printing.Margins(20, 20, 20, 20)
            link.MinMargins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
            link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.PageSetup, CommandVisibility.None)
            link.ShowPreviewDialog()
        End Sub
    End Class
End Namespace
