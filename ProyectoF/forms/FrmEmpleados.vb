Imports System.Runtime.InteropServices

Public Class FrmEmpleados

    Private dEmpleados As New EmpleadosDao
    Private dRoles As New RolesDao

#Region "Botones del Formulario"
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Application.Exit()
    End Sub

    Private Sub BtnClose_MouseHover(sender As Object, e As EventArgs) Handles BtnClose.MouseHover
        BtnClose.BackColor = Color.Red
    End Sub

    Private Sub BtnClose_MouseLeave(sender As Object, e As EventArgs) Handles BtnClose.MouseLeave
        BtnClose.BackColor = Color.DodgerBlue
    End Sub

    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles BtnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnMinimize_MouseHover(sender As Object, e As EventArgs) Handles BtnMinimize.MouseHover
        BtnMinimize.BackColor = Color.Red
    End Sub

    Private Sub BtnMinimize_MouseLeave(sender As Object, e As EventArgs) Handles BtnMinimize.MouseLeave
        BtnMinimize.BackColor = Color.DodgerBlue
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Limpiar()
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Me.Close()
        FrmLogin.Show()
    End Sub

#End Region

#Region "Arrastrar/Drag Form"

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub
    Private Sub titleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles TitleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

#End Region

#Region "Funciones del FrmEmpleados"
    Private Sub FrmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarRol()
        MostrarRegistros()
    End Sub

    Sub LlenarRol()
        Try
            cmbIdRol.DataSource = dRoles.MostrarRegistros.Tables(0)
            cmbIdRol.DisplayMember = "nombreRol"
            cmbIdRol.ValueMember = "idRol"
            cmbIdRol.Refresh()
        Catch ex As Exception
            MsgBox("Error al mostrar rol", MsgBoxStyle.Critical, "Roles")
        End Try
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            Dim empleados As New EmpleadosEntity
            empleados.Usuario = txtUsuario.Text
            empleados.Contrasenia = txtPwd.Text
            empleados.PrimerNombreEmp = txtPrimerNombre.Text
            empleados.SegundoNombreEmp = txtSegundoNombre.Text
            empleados.PrimerApellidoEmp = txtPrimerApe.Text
            empleados.SegundoApellidoEmp = txtSegundoApe.Text
            empleados.Rol.IdRol = cmbIdRol.SelectedValue
            empleados.FechaContratacion = dtFechaC.Value

            If (dEmpleados.AgregarRegistro(empleados) = True) Then
                MsgBox("Registro guardado satisfactoriamente.", MsgBoxStyle.Information, "Empleados")
                Limpiar()
                MostrarRegistros()
            Else
                MsgBox("No se pudo guardar el registro...", MsgBoxStyle.Exclamation, "Empleados")
            End If
        Catch ex As Exception
            MsgBox("Error al guardar registro: " & ex.Message, MsgBoxStyle.Critical, "Empleados")
        End Try
    End Sub

    Sub Limpiar()
        txtUsuario.Clear()
        txtPwd.Clear()
        txtPrimerNombre.Clear()
        txtSegundoNombre.Clear()
        txtPrimerApe.Clear()
        txtSegundoApe.Clear()
        cmbIdRol.SelectedIndex = -1
        dtFechaC.Value = Now
        txtUsuario.Focus()
    End Sub

    Sub MostrarRegistros()
        Try
            dgvRegistrosAlmacenados.DataSource = dEmpleados.MostrarRegistros.Tables(0)
            dgvRegistrosAlmacenados.Refresh()
            GbRegistros.Text = "Registros almacenados: " & dgvRegistrosAlmacenados.Rows.Count
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvRegistrosAlmacenados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRegistrosAlmacenados.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim usuario As String = dgvRegistrosAlmacenados.Rows(e.RowIndex).Cells("USUARIO").Value.ToString()
            Dim empleado As EmpleadosEntity = dEmpleados.ObtenerRegistro(usuario)
            If empleado IsNot Nothing Then
                txtUsuario.Text = empleado.Usuario
                txtPwd.Text = empleado.Contrasenia
                txtPrimerNombre.Text = empleado.PrimerNombreEmp
                txtSegundoNombre.Text = empleado.SegundoNombreEmp
                txtPrimerApe.Text = empleado.PrimerApellidoEmp
                txtSegundoApe.Text = empleado.SegundoApellidoEmp
                cmbIdRol.SelectedValue = empleado.Rol.IdRol
                dtFechaC.Value = empleado.FechaContratacion
                tcEmpleados.SelectedIndex = 0
                ''tcEmpleados.TabPages(0).Enabled = False
            End If
        End If
    End Sub


    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Try
            Dim empleado As New EmpleadosEntity()
            empleado.Usuario = txtUsuario.Text
            empleado.Contrasenia = txtPwd.Text
            empleado.PrimerNombreEmp = txtPrimerNombre.Text
            empleado.SegundoNombreEmp = txtSegundoNombre.Text
            empleado.PrimerApellidoEmp = txtPrimerApe.Text
            empleado.SegundoApellidoEmp = txtSegundoApe.Text
            empleado.FechaContratacion = dtFechaC.Value
            empleado.Rol.IdRol = cmbIdRol.SelectedValue

            If dEmpleados.EditarRegistro(empleado) Then
                MsgBox("Registro modificado satisfactoriamente.", MsgBoxStyle.Information, "Empleados")
                Limpiar()
                MostrarRegistros()
            Else
                MsgBox("No se pudo modificar el registro...", MsgBoxStyle.Exclamation, "Empleados")
            End If
        Catch ex As Exception
            MsgBox("Error al guardar registro: " & ex.Message, MsgBoxStyle.Critical, "Empleados")
        End Try

        MostrarRegistros()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim usuario As String = txtUsuario.Text

        If String.IsNullOrEmpty(usuario) Then
            MsgBox("Debe seleccionar un empleado para eliminar.", MsgBoxStyle.Information, "Empleados")
            Return
        End If

        Dim respuesta As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar este empleado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If respuesta = DialogResult.Yes Then
            Dim exito As Boolean = dEmpleados.EliminarRegistro(usuario)

            If exito Then
                MsgBox("Empleado eliminado correctamente.", MsgBoxStyle.Information, "Empleados")
                Limpiar()
                MostrarRegistros()
            Else
                MsgBox("No se pudo eliminar el empleado.", MsgBoxStyle.Exclamation, "Empleados")
            End If
        End If
    End Sub

    Private Sub txtBusqueda_Enter(sender As Object, e As EventArgs) Handles txtBusqueda.Enter
        If txtBusqueda.Text = "Buscar Empleado Por Nombre" Then
            txtBusqueda.Text = ""
            txtBusqueda.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub txtBusqueda_Leave(sender As Object, e As EventArgs) Handles txtBusqueda.Leave
        If txtBusqueda.Text = "" Then
            txtBusqueda.Text = "Buscar Empleado Por Nombre"
            txtBusqueda.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        If txtBusqueda.Text = "Buscar Empleado Por Nombre" Then
            Return
        End If

        Dim empleadoDao As New EmpleadosDao()

        If String.IsNullOrWhiteSpace(txtBusqueda.Text) Then
            MostrarRegistros()
        Else
            Dim ds As DataSet = empleadoDao.BuscarEmpleadoPorNombre(txtBusqueda.Text.Trim())
            dgvRegistrosAlmacenados.DataSource = ds.Tables(0)
        End If
    End Sub

#End Region

End Class