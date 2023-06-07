Public Class FrmReportes

#Region "Todas las funcionalidades"

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub EmpleadoRolToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadoRolToolStripMenuItem.Click
        Try
            Dim tbl As New DataTable
            Dim reporte As New DBLosArcosDsTableAdapters.EmpleadoRolTableAdapter
            tbl = reporte.GetData
            VerReporteEmpleadoRol(tbl, "DsEmpleadoRol")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al mostrar el reporte")
        End Try
    End Sub

    Private Sub ClientesYPacientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesYPacientesToolStripMenuItem.Click
        Try
            Dim tbl As New DataTable
            Dim reporte As New DBLosArcosDsTableAdapters.ClientePacienteTableAdapter
            tbl = reporte.GetData
            VerReporteClientePaciente(tbl, "DsPacienteCliente")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al mostrar el reporte")
        End Try
    End Sub

    Private Sub RazasYServiciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RazasYServiciosToolStripMenuItem.Click
        Try
            Dim tbl As New DataTable
            Dim reporte As New DBLosArcosDsTableAdapters.ServiciosPorRazaTableAdapter
            tbl = reporte.GetData
            VerServiciosPorRaza(tbl, "DsServiciosPorRaza")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al mostrar el reporte")
        End Try
    End Sub

    Private Sub ServiciosYCostrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServiciosYCostrosToolStripMenuItem.Click
        Try
            Dim tbl As New DataTable
            Dim reporte As New DBLosArcosDsTableAdapters.ServicioCostoTableAdapter
            tbl = reporte.GetData
            VerServiciosCosto(tbl, "DsServicioCosto")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al mostrar el reporte")
        End Try
    End Sub

    Private Sub VacunasYRazasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VacunasYRazasToolStripMenuItem.Click
        Try
            Dim tbl As New DataTable
            Dim reporte As New DBLosArcosDsTableAdapters.RazasVacunasTableAdapter
            tbl = reporte.GetData
            VerVacunasRazas(tbl, "DsRazasVacunas")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al mostrar el reporte")
        End Try
    End Sub

    Private Sub DesparasitantesYRazasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesparasitantesYRazasToolStripMenuItem.Click
        Try
            Dim tbl As New DataTable
            Dim reporte As New DBLosArcosDsTableAdapters.RazasDesparasitantesTableAdapter
            tbl = reporte.GetData
            VerDesparasitantesRazas(tbl, "DsRazasDesparasitantes")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al mostrar el reporte")
        End Try
    End Sub

    Private Sub VacunasYEspeciesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VacunasYEspeciesToolStripMenuItem.Click
        Try
            Dim tbl As New DataTable
            Dim reporte As New DBLosArcosDsTableAdapters.EspeciesVacunasTableAdapter
            tbl = reporte.GetData
            VerVacunasEspecies(tbl, "DsEspeciesVacunas")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al mostrar el reporte")
        End Try
    End Sub

    Private Sub DesparasitantesYEspeciesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesparasitantesYEspeciesToolStripMenuItem.Click
        Try
            Dim tbl As New DataTable
            Dim reporte As New DBLosArcosDsTableAdapters.EspeciesDesparasitantesTableAdapter
            tbl = reporte.GetData
            VerDesparasitantesEspecies(tbl, "DsEspeciesDesparasitantes")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al mostrar el reporte")
        End Try
    End Sub

    Private Sub VacunasYMarcasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VacunasYMarcasToolStripMenuItem.Click
        Try
            Dim tbl As New DataTable
            Dim reporte As New DBLosArcosDsTableAdapters.VacunaMarcasTableAdapter
            tbl = reporte.GetData
            VerVacunasMarcas(tbl, "DsVacunasMarcas")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al mostrar el reporte")
        End Try
    End Sub

    Private Sub DesparasitantesYMarcasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesparasitantesYMarcasToolStripMenuItem.Click
        Try
            Dim tbl As New DataTable
            Dim reporte As New DBLosArcosDsTableAdapters.DesparasitantesMarcasTableAdapter
            tbl = reporte.GetData
            VerDesparasitantesMarcas(tbl, "DsDesparasitantesMarcas")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al mostrar el reporte")
        End Try
    End Sub



#End Region
End Class