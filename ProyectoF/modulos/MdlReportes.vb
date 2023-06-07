Imports Microsoft.Reporting.WinForms

Module MdlReportes
    Sub VerReporte(ByVal t As DataTable, ByVal ds As String, ByVal nombreRpt As String)
        Try
            Dim rpt As New ReportDataSource(ds, t)
            With New FrmVistaPrevia
                .ReportViewer1.LocalReport.DataSources.Clear()
                .ReportViewer1.LocalReport.DataSources.Add(rpt)
                .ReportViewer1.LocalReport.ReportPath = "C:\" + nombreRpt
                .Show()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al mostrar el reporte")
        End Try
    End Sub
End Module
