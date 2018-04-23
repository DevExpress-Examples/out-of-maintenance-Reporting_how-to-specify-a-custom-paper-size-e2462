Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports DevExpress.XtraPrinting

Namespace PrintCustomPaperSize
	Friend Class SimpleLink
		Inherits Link
		Private text_Renamed As String

		Public Property Text() As String
			Get
				Return text_Renamed
			End Get
			Set(ByVal value As String)
				text_Renamed = value
			End Set
		End Property

		Public Sub New()

		End Sub

		Public Sub New(ByVal ps As PrintingSystem, ByVal text As String)
			MyBase.New(ps)
			Me.text_Renamed = text
		End Sub

		Protected Overrides Sub CreateDetail(ByVal graph As BrickGraphics)
			MyBase.CreateDetail(graph)

			Dim textSize As SizeF = graph.MeasureString(Text, CInt(Fix(Math.Round(graph.ClientPageSize.Width))))

			Dim rect As New RectangleF(0, 0, graph.ClientPageSize.Width, textSize.Height)

			graph.DrawString(text_Renamed, rect)
		End Sub
	End Class
End Namespace
