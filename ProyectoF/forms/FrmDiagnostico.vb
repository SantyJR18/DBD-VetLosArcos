Public Class FrmDiagnostico

    Private dDiagnostico As New DiagnosticosDao
    Private dPaciente As New PacientesDao
    Dim idDiag As Integer = -1

#Region "Botones del Formulario"
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

#End Region

#Region "Funciones del Formulario"
    Private Sub FrmDiagnostico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarRegistros()
        LlenarPaciente()
    End Sub

    Sub LlenarPaciente()
        Try
            cmbIdPac.DataSource = dPaciente.MostrarRegistros.Tables(0)
            cmbIdPac.DisplayMember = "nombrePaciente"
            cmbIdPac.ValueMember = "idPaciente" ' Actualizar el ValueMember a "idPaciente"
            cmbIdPac.Refresh()
        Catch ex As Exception
            MsgBox("Error al mostrar Nombre Paciente", MsgBoxStyle.Critical, "Paciente")
        End Try
    End Sub

    Sub MostrarRegistros()
        Try
            dgvRegistrosAlmacenados.DataSource = dDiagnostico.MostrarRegistros.Tables(0)
            dgvRegistrosAlmacenados.Refresh()
            GbRegistros.Text = "Registros almacenados: " & dgvRegistrosAlmacenados.Rows.Count
            dgvRegistrosAlmacenados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvRegistrosAlmacenados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRegistrosAlmacenados.CellDoubleClick
        Dim fila As Integer
        fila = dgvRegistrosAlmacenados.CurrentRow.Index
        If e.RowIndex >= 0 Then
            tcDiagnosticos.SelectedIndex = 1
            idDiag = Integer.Parse(dgvRegistrosAlmacenados.Rows(fila).Cells(0).Value)
            Dim diagnosticoR As DiagnosticosEntity = dDiagnostico.ObtenerRegistro(idDiag)
            If diagnosticoR IsNot Nothing Then
                MsgBox(idDiag)
                ' Mostrar los datos del registro en los controles del formulario
                txtDesDiag.Text = diagnosticoR.DescripcionDiag
                dtFechaDiag.Value = diagnosticoR.FechaDiag
                cmbIdPac.SelectedValue = diagnosticoR.Paciente.IdPaciente

            End If
        End If
    End Sub




    'Private Sub dgvRegistrosAlmacenados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRegistrosAlmacenados.CellDoubleClick
    '    If e.RowIndex >= 0 Then
    '        idDiag = Integer.Parse(dgvRegistrosAlmacenados.Rows(e.RowIndex).Cells("ID DIAGNOSTICO").Value.ToString())
    '        Dim diagnosticoR As DiagnosticosEntity = dDiagnostico.ObtenerRegistro(idDiag)
    '        If diagnosticoR IsNot Nothing Then
    '            txtDesDiag.Text = diagnosticoR.DescripcionDiag
    '            dtFechaDiag.Value = diagnosticoR.FechaDiag
    '            cmbIdPac.SelectedValue = diagnosticoR.Paciente.IdPaciente
    '            txtNombrePac.Text = diagnosticoR.Paciente.NombrePaciente
    '        End If
    '    End If
    'End Sub
#End Region
End Class