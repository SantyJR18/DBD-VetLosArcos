Public Class FrmServicio

    Private dRegistroServicio As New RegistroServiciosDao
    Private dCliente As New ClienteDao
    Private dPaciente As New PacientesDao
    Private dServicio As New ServiciosDao
    Private dFactura As New RegistroFacturasDao

#Region "Botones del Formulario"
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    Private Sub BtnCerrar_MouseHover(sender As Object, e As EventArgs) Handles BtnCerrar.MouseHover
        BtnCerrar.BackColor = Color.Red
    End Sub

    Private Sub BtnCerrar_MouseLeave(sender As Object, e As EventArgs) Handles BtnCerrar.MouseLeave
        BtnCerrar.BackColor = Color.DodgerBlue
    End Sub

#End Region

#Region "Funciones del FrmServicio"
    Private Sub FrmServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarRegistros()
        LlenarCliente()
        LlenarPaciente()
        LlenarServicio()
        LlenarFactura()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        ' Obtener los valores de los controles
        Dim fechaConsulta As DateTime = dtFechaConsulta.Value
        Dim idCliente As String = cmbIdCliente.SelectedValue.ToString()
        Dim idPaciente As Integer = Convert.ToInt32(cmbIdPaciente.SelectedValue.ToString())
        Dim idServicio As Integer = Convert.ToInt32(cmbIdServicio.SelectedValue.ToString())
        Dim idFactura As Integer = Convert.ToInt32(cmbIdFactura.SelectedValue.ToString())

        ' Crear el objeto RegistroServiciosEntity con los valores
        Dim registroServicio As New RegistroServiciosEntity()
        registroServicio.FechaConsulta = fechaConsulta
        registroServicio.Cliente.IdCliente = idCliente
        registroServicio.Paciente.IdPaciente = idPaciente
        registroServicio.Servicio.IdServicio = idServicio
        registroServicio.Factura.IdFactura = idFactura

        ' Llamar al método AgregarRegistro del RegistroServiciosDao
        Dim resultado As Boolean = dRegistroServicio.AgregarRegistro(registroServicio)
        If resultado Then
            MessageBox.Show("Registro agregado exitosamente", "Agregar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Limpiar()
            MostrarRegistros()
        Else
            MessageBox.Show("Error al agregar el registro", "Agregar Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If dgvRegistrosAlmacenados.SelectedRows.Count > 0 Then
            ' Obtener los valores de los controles
            Dim fechaConsulta As DateTime = dtFechaConsulta.Value
            Dim idCliente As String = cmbIdCliente.SelectedValue.ToString()
            Dim idPaciente As Integer = Convert.ToInt32(cmbIdPaciente.SelectedValue.ToString())
            Dim idServicio As Integer = Convert.ToInt32(cmbIdServicio.SelectedValue.ToString())
            Dim idFactura As Integer = Convert.ToInt32(cmbIdFactura.SelectedValue.ToString())

            ' Crear el objeto RegistroServiciosEntity con los valores
            Dim registroServicio As New RegistroServiciosEntity()
            registroServicio.IdRegServicio = Convert.ToInt32(dgvRegistrosAlmacenados.SelectedRows(0).Cells("ID REGISTRO").Value.ToString())
            registroServicio.FechaConsulta = fechaConsulta
            registroServicio.Cliente.IdCliente = idCliente
            registroServicio.Paciente.IdPaciente = idPaciente
            registroServicio.Servicio.IdServicio = idServicio
            registroServicio.Factura.IdFactura = idFactura

            ' Llamar al método EditarRegistro del RegistroServiciosDao
            Dim resultado As Boolean = dRegistroServicio.EditarRegistro(registroServicio)
            If resultado Then
                MessageBox.Show("Registro editado exitosamente", "Editar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Limpiar()
                MostrarRegistros()
            Else
                MessageBox.Show("Error al editar el registro", "Editar Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MsgBox("Selecciona un registro para editar.")
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If dgvRegistrosAlmacenados.SelectedRows.Count > 0 Then
            Dim idRegServicio As Integer = Convert.ToInt32(dgvRegistrosAlmacenados.SelectedRows(0).Cells("ID REGISTRO").Value.ToString())

            If dRegistroServicio.EliminarRegistro(idRegServicio.ToString()) Then
                MsgBox("Registro eliminado exitosamente.")
                MostrarRegistros()
            Else
                MsgBox("Error al eliminar el registro.")
            End If
        Else
            MsgBox("Selecciona un registro para eliminar.")
        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Limpiar()
    End Sub

    Sub MostrarRegistros()
        Try
            dgvRegistrosAlmacenados.DataSource = dRegistroServicio.MostrarRegistros.Tables(0)
            dgvRegistrosAlmacenados.Refresh()
            GbRegistros.Text = "Registros almacenados: " & dgvRegistrosAlmacenados.Rows.Count
            dgvRegistrosAlmacenados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        Catch ex As Exception

        End Try
    End Sub

    Sub LlenarCliente()
        Try
            cmbIdCliente.DataSource = dCliente.MostrarRegistros.Tables(0)
            cmbIdCliente.DisplayMember = "idCliente"
            cmbIdCliente.ValueMember = "idCliente"
            cmbIdCliente.Refresh()
        Catch ex As Exception
            MsgBox("Error al mostrar ID Cliente", MsgBoxStyle.Critical, "Cliente")
        End Try
    End Sub

    Sub LlenarPaciente()
        Try
            cmbIdPaciente.DataSource = dPaciente.MostrarRegistros.Tables(0)
            cmbIdPaciente.DisplayMember = "nombrePaciente"
            cmbIdPaciente.ValueMember = "idPaciente"
            cmbIdPaciente.Refresh()
        Catch ex As Exception
            MsgBox("Error al mostrar ID Paciente", MsgBoxStyle.Critical, "Paciente")
        End Try
    End Sub

    Sub LlenarServicio()
        Try
            cmbIdServicio.DataSource = dServicio.MostrarRegistros.Tables(0)
            cmbIdServicio.DisplayMember = "nombreServicio"
            cmbIdServicio.ValueMember = "idServicio"
            cmbIdServicio.Refresh()
        Catch ex As Exception
            MsgBox("Error al mostrar ID Servicio", MsgBoxStyle.Critical, "Servicio")
        End Try
    End Sub

    Sub LlenarFactura()
        Try
            cmbIdFactura.DataSource = dFactura.MostrarRegistros.Tables(0)
            cmbIdFactura.DisplayMember = "idFactura"
            cmbIdFactura.ValueMember = "idFactura" ' Actualizar el ValueMember a "idFactura"
            cmbIdFactura.Refresh()
        Catch ex As Exception
            MsgBox("Error al mostrar ID Factura", MsgBoxStyle.Critical, "Factura")
        End Try
    End Sub


    Sub Limpiar()
        dtFechaConsulta.Value = DateTime.Now
        cmbIdCliente.SelectedIndex = -1
        cmbIdPaciente.SelectedIndex = -1
        cmbIdServicio.SelectedIndex = -1
        cmbIdFactura.SelectedIndex = -1
    End Sub

    Private Sub dgvRegistrosAlmacenados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRegistrosAlmacenados.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim idRegServicio As Integer = Convert.ToInt32(dgvRegistrosAlmacenados.Rows(e.RowIndex).Cells("ID REGISTRO").Value.ToString())
            Dim registroServicio As RegistroServiciosEntity = dRegistroServicio.ObtenerRegistro(idRegServicio)
            If registroServicio IsNot Nothing Then
                ' Limpiar los controles antes de asignar nuevos valores
                ' Asignar los nuevos valores del objeto RegistroServiciosEntity a los controles
                dtFechaConsulta.Value = registroServicio.FechaConsulta
                cmbIdCliente.SelectedValue = registroServicio.Cliente.IdCliente
                cmbIdPaciente.SelectedValue = registroServicio.Paciente.IdPaciente
                cmbIdServicio.SelectedValue = registroServicio.Servicio.IdServicio
                cmbIdFactura.SelectedValue = registroServicio.Factura.IdFactura

                tcServicios.SelectedIndex = 1
                ''tcServicios.TabPages(0).Enabled = False
            End If
        End If
    End Sub

    Private Sub txtBusqueda_Enter(sender As Object, e As EventArgs) Handles txtBusqueda.Enter
        If txtBusqueda.Text = "Buscar Registro de Servicio Por ID CLIENTE" Then
            txtBusqueda.Text = ""
            txtBusqueda.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub txtBusqueda_Leave(sender As Object, e As EventArgs) Handles txtBusqueda.Leave
        If txtBusqueda.Text = "" Then
            txtBusqueda.Text = "Buscar Registro de Servicio Por ID CLIENTE"
            txtBusqueda.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        If txtBusqueda.Text = "Buscar Registro de Servicio Por ID CLIENTE" Then
            Return
        End If

        Dim registroServicioDao As New RegistroServiciosDao()

        If String.IsNullOrWhiteSpace(txtBusqueda.Text) Then
            MostrarRegistros()
        Else
            Dim ds As DataSet = registroServicioDao.BuscarRegistroPorIdCliente("%" & txtBusqueda.Text.Trim() & "%")
            dgvRegistrosAlmacenados.DataSource = ds.Tables(0)
        End If
    End Sub

#End Region
End Class