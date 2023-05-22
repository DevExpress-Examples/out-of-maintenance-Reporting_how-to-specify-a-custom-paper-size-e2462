Imports System
Imports System.Drawing
Imports DevExpress.XtraPrinting

Namespace PrintCustomPaperSize

    Friend Class SimpleLink
        Inherits Link

        Private textField As String

        Public Property Text As String
            Get
                Return textField
            End Get

            Set(ByVal value As String)
                textField = value
            End Set
        End Property

        Public Sub New()
        End Sub

        Public Sub New(ByVal ps As PrintingSystem, ByVal text As String)
            MyBase.New(ps)
            textField = text
        End Sub

        Protected Overrides Sub CreateDetail(ByVal graph As BrickGraphics)
            MyBase.CreateDetail(graph)
            Dim textSize As SizeF = graph.MeasureString(Text, CInt(Math.Round(graph.ClientPageSize.Width)))
            Dim rect As RectangleF = New RectangleF(0, 0, graph.ClientPageSize.Width, textSize.Height)
            graph.DrawString(textField, rect)
        End Sub
    End Class
End Namespace
