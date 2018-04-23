Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraPrinting

Namespace PrintCustomPaperSize
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim link As New SimpleLink(New PrintingSystem(), "Test")

			link.PaperKind = System.Drawing.Printing.PaperKind.Custom
			link.CustomPaperSize = New Size(200, 200)
			link.Margins = New System.Drawing.Printing.Margins(20, 20, 20, 20)
			link.MinMargins = New System.Drawing.Printing.Margins(0, 0, 0, 0)

			link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.PageSetup, CommandVisibility.None)

			link.ShowPreviewDialog()
		End Sub

	End Class
End Namespace