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

    Sub Limpiar()
        txtDesDiag.Clear()
        dtFechaDiag.Value = Now
        cmbIdPac.SelectedIndex = -1
    End Sub

    Private Sub dgvRegistrosAlmacenados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRegistrosAlmacenados.CellDoubleClick
        Dim fila As Integer
        fila = dgvRegistrosAlmacenados.CurrentRow.Index
        If e.RowIndex >= 0 Then
            tcDiagnosticos.SelectedIndex = 1
            idDiag = Integer.Parse(dgvRegistrosAlmacenados.Rows(fila).Cells(0).Value)
            Dim diagnosticoR As DiagnosticosEntity = dDiagnostico.ObtenerRegistro(idDiag)
            If diagnosticoR IsNot Nothing Then
                ' Mostrar los datos del registro en los controles del formulario
                txtIdDiag.Text = diagnosticoR.IdDiag
                txtDesDiag.Text = diagnosticoR.DescripcionDiag
                dtFechaDiag.Value = diagnosticoR.FechaDiag
                cmbIdPac.SelectedValue = diagnosticoR.Paciente
            End If
        End If
    End Sub

    Private Sub txtBusqueda_Enter(sender As Object, e As EventArgs) Handles txtBusqueda.Enter
        If txtBusqueda.Text = "Buscar Diagnósticos Por ID Paciente" Then
            txtBusqueda.Text = ""
            txtBusqueda.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub txtBusqueda_Leave(sender As Object, e As EventArgs) Handles txtBusqueda.Leave
        If txtBusqueda.Text = "" Then
            txtBusqueda.Text = "Buscar Diagnósticos Por ID Paciente"
            txtBusqueda.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        Dim idPaciente As Integer

        If Integer.TryParse(txtBusqueda.Text.Trim(), idPaciente) Then
            ' Llamar a la función ObtenerRegistroPorIdPaciente y asignar el resultado al DataGridView (dgvRegistrosAlmacenados)
            dgvRegistrosAlmacenados.DataSource = dDiagnostico.ObtenerRegistroPorIdPaciente(idPaciente).Tables(0)
        ElseIf txtBusqueda.Text.Trim() = "" Then
            ' Mostrar todos los registros nuevamente
            MostrarRegistros()
        End If

        dgvRegistrosAlmacenados.Refresh()
    End Sub


    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Limpiar()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            Dim diagnosticoAdd As New DiagnosticosEntity With {
                .DescripcionDiag = Convert.ToInt32(txtDesDiag.Text),
                .FechaDiag = dtFechaDiag.Text,
                .Paciente = cmbIdPac.SelectedValue
             }

            If dDiagnostico.AgregarRegistro(diagnosticoAdd) Then
                MessageBox.Show("Registro agregado exitosamente", "Agregar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Limpiar()
                MostrarRegistros()
            Else
                MessageBox.Show("Error al agregar el registro", "Agregar Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox("Error al guardar registro: " & ex.Message, MsgBoxStyle.Critical, "Clientes")
        End Try
        MostrarRegistros()

    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Try
            Dim diagnosticoEdit As New DiagnosticosEntity With {
                .IdDiag = txtIdDiag.Text,
                .DescripcionDiag = txtDesDiag.Text,
                .FechaDiag = dtFechaDiag.Text,
                .Paciente = cmbIdPac.SelectedValue
            }
            If dDiagnostico.EditarRegistro(diagnosticoEdit) Then
                MsgBox("Regtro modificado satisfactoriamente.", MsgBoxStyle.Information, "Empleados")
            Else
                MsgBox("No se pudo modificar el registro...", MsgBoxStyle.Exclamation, "Empleados")
            End If
        Catch ex As Exception
            MsgBox("Error al guardar registro: " & ex.Message, MsgBoxStyle.Critical, "Clientes")
        End Try
        MostrarRegistros()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

    End Sub

#End Region
End Class