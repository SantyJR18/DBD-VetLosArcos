Public Class FrmVistaPrevia2
    Private Sub FrmVistaPrevia2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ReportViewer2.RefreshReport()
    End Sub
End Class