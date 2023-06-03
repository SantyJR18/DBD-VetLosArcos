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

    Private Sub EmpleadosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EmpleadosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBLosArcosDs)

    End Sub

#End Region

#Region "Funciones del FrmEmpleados"
    Private Sub FrmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarRol()
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
            ''monitor.Observaciones = TxtObservacion.Text''

            If (dEmpleados.AgregarRegistro(empleados) = True) Then
                MsgBox("Registro guardado satisfactoriamente.", MsgBoxStyle.Information, "Empleados")
            Else
                MsgBox("No se pudo guardar el registro...", MsgBoxStyle.Exclamation, "Empleados")
            End If
        Catch ex As Exception
            MsgBox("Error al guardar registro: " & ex.Message, MsgBoxStyle.Critical, "Empleados")
        End Try
    End Sub

#End Region

End Class