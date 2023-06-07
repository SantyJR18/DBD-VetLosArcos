Public Class FrmVistaPrevia
    Private Sub FrmVistaPrevia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class