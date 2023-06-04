Imports System.Runtime.InteropServices

Public Class FrmLogin

    Private dEmpleados As New EmpleadosDao

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

    Private Sub LblAccount_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LblAccount.LinkClicked
        Me.Hide()
        FrmEmpleados.Show()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim usuario As String = txtUsuario.Text
        Dim contrasenia As String = txtPwd.Text

        ' Validar las credenciales
        If dEmpleados.ValidarCredenciales(usuario, contrasenia) Then
            ' Obtener el rol del empleado
            Dim rol As String = dEmpleados.ObtenerRol(usuario)

            ' Mostrar el menú según el rol del empleado
            Select Case rol
                Case "Médico veterinario"
                    FrmMenu.Visible = True
                    FrmMenuR.Visible = False
                Case "Recepcionista"
                    FrmMenu.Visible = False
                    FrmMenuR.Visible = True
            End Select

            ' Mostrar el formulario principal
            Me.Hide()
            ' Código para mostrar el formulario principal o realizar otras acciones necesarias
            Limpiar()
        Else
            MsgBox("Credenciales inválidas. Por favor, verifique su usuario y contraseña.", MsgBoxStyle.Exclamation, "Login")
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Limpiar()
    End Sub

#End Region

#Region "Componentes de personalización del Form"

    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
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

#Region "Funciones"

    Sub Limpiar()
        txtUsuario.Clear()
        txtPwd.Clear()
        txtUsuario.Focus()
    End Sub

#End Region

End Class