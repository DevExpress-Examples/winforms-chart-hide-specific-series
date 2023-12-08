Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

Namespace WindowsApplication1

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            ' TODO: This line of code loads data into the 'nwindDataSet.Products' table. You can move, or remove it, as needed.
            productsTableAdapter.Fill(nwindDataSet.Products)
        End Sub

        Private Sub chartControl1_BoundDataChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim cc As ChartControl = TryCast(sender, ChartControl)
            For Each s As Series In cc.Series
                If Convert.ToInt32(s.Name) > 5 Then s.Visible = False
            Next
        End Sub
    End Class
End Namespace
