Imports Microsoft.Reporting.WinForms

Module MdlReportes
    Sub VerReporteEmpleadoRol(ByVal t As DataTable, ByVal ds As String)
        Try
            Dim rpt As New ReportDataSource(ds, t)
            With New FrmVistaPrevia
                .ReportViewer1.LocalReport.DataSources.Clear()
                .ReportViewer1.LocalReport.DataSources.Add(rpt)
                .ReportViewer1.LocalReport.ReportPath = "C:\reportes\RptEmpleadoRol.rdlc"
                .Show()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al mostrar el reporte")
        End Try
    End Sub

    Sub VerReporteClientePaciente(ByVal t As DataTable, ByVal ds As String)
        Try
            Dim rpt As New ReportDataSource(ds, t)
            With New FrmVistaPrevia2
                .ReportViewer2.LocalReport.DataSources.Clear()
                .ReportViewer2.LocalReport.DataSources.Add(rpt)
                .ReportViewer2.LocalReport.ReportPath = "C:\reportes\RptClientePaciente.rdlc"
                .Show()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al mostrar el reporte")
        End Try
    End Sub

    Sub VerServiciosPorRaza(ByVal t As DataTable, ByVal ds As String)
        Try
            Dim rpt As New ReportDataSource(ds, t)
            With New FrmVistaPrevia3
                .ReportViewer3.LocalReport.DataSources.Clear()
                .ReportViewer3.LocalReport.DataSources.Add(rpt)
                .ReportViewer3.LocalReport.ReportPath = "C:\reportes\RptServiciosPorRaza.rdlc"
                .Show()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al mostrar el reporte")
        End Try
    End Sub

    Sub VerServiciosCosto(ByVal t As DataTable, ByVal ds As String)
        Try
            Dim rpt As New ReportDataSource(ds, t)
            With New FrmVistaPrevia4
                .ReportViewer4.LocalReport.DataSources.Clear()
                .ReportViewer4.LocalReport.DataSources.Add(rpt)
                .ReportViewer4.LocalReport.ReportPath = "C:\reportes\RptServicioCosto.rdlc"
                .Show()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al mostrar el reporte")
        End Try
    End Sub

    Sub VerVacunasRazas(ByVal t As DataTable, ByVal ds As String)
        Try
            Dim rpt As New ReportDataSource(ds, t)
            With New FrmVistaPrevia5
                .ReportViewer5.LocalReport.DataSources.Clear()
                .ReportViewer5.LocalReport.DataSources.Add(rpt)
                .ReportViewer5.LocalReport.ReportPath = "C:\reportes\RptVacunasRaza.rdlc"
                .Show()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al mostrar el reporte")
        End Try
    End Sub

    Sub VerDesparasitantesRazas(ByVal t As DataTable, ByVal ds As String)
        Try
            Dim rpt As New ReportDataSource(ds, t)
            With New FrmVistaPrevia6
                .ReportViewer6.LocalReport.DataSources.Clear()
                .ReportViewer6.LocalReport.DataSources.Add(rpt)
                .ReportViewer6.LocalReport.ReportPath = "C:\reportes\RptDesparasitantesRaza.rdlc"
                .Show()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al mostrar el reporte")
        End Try
    End Sub

    Sub VerVacunasEspecies(ByVal t As DataTable, ByVal ds As String)
        Try
            Dim rpt As New ReportDataSource(ds, t)
            With New FrmVistaPrevia7
                .ReportViewer7.LocalReport.DataSources.Clear()
                .ReportViewer7.LocalReport.DataSources.Add(rpt)
                .ReportViewer7.LocalReport.ReportPath = "C:\reportes\RptEspeciesVacunas.rdlc"
                .Show()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al mostrar el reporte")
        End Try
    End Sub

    Sub VerDesparasitantesEspecies(ByVal t As DataTable, ByVal ds As String)
        Try
            Dim rpt As New ReportDataSource(ds, t)
            With New FrmVistaPrevia8
                .ReportViewer8.LocalReport.DataSources.Clear()
                .ReportViewer8.LocalReport.DataSources.Add(rpt)
                .ReportViewer8.LocalReport.ReportPath = "C:\reportes\RptEspeciesDesparasitantes.rdlc"
                .Show()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al mostrar el reporte")
        End Try
    End Sub

    Sub VerVacunasMarcas(ByVal t As DataTable, ByVal ds As String)
        Try
            Dim rpt As New ReportDataSource(ds, t)
            With New FrmVistaPrevia9
                .ReportViewer9.LocalReport.DataSources.Clear()
                .ReportViewer9.LocalReport.DataSources.Add(rpt)
                .ReportViewer9.LocalReport.ReportPath = "C:\reportes\RptVacunasMarcas.rdlc"
                .Show()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al mostrar el reporte")
        End Try
    End Sub

    Sub VerDesparasitantesMarcas(ByVal t As DataTable, ByVal ds As String)
        Try
            Dim rpt As New ReportDataSource(ds, t)
            With New FrmVistaPrevia10
                .ReportViewer10.LocalReport.DataSources.Clear()
                .ReportViewer10.LocalReport.DataSources.Add(rpt)
                .ReportViewer10.LocalReport.ReportPath = "C:\reportes\RptDesparasitantesMarcas.rdlc"
                .Show()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al mostrar el reporte")
        End Try
    End Sub
End Module
