Imports System.Runtime.InteropServices

Public Class FrmRegistrarCliente
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Application.Exit()
    End Sub

    Private Sub BtnMaximizar_Click(sender As Object, e As EventArgs) Handles BtnMaximizar.Click
        WindowState = FormWindowState.Maximized
        BtnMaximizar.Visible = False
        BtnRestaurar.Visible = True
    End Sub

    Private Sub BtnRestaurar_Click(sender As Object, e As EventArgs) Handles BtnRestaurar.Click
        WindowState = FormWindowState.Normal
        BtnRestaurar.Visible = False
        BtnMaximizar.Visible = True
    End Sub

    Private Sub BtnMinimizar_Click(sender As Object, e As EventArgs) Handles BtnMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnCerrar_MouseHover(sender As Object, e As EventArgs) Handles BtnCerrar.MouseHover
        BtnCerrar.BackColor = Color.Red
    End Sub

    Private Sub BtnCerrar_MouseLeave(sender As Object, e As EventArgs) Handles BtnCerrar.MouseLeave
        BtnCerrar.BackColor = Color.DodgerBlue
    End Sub

    Private Sub BtnMaximizar_MouseHover(sender As Object, e As EventArgs) Handles BtnMaximizar.MouseHover
        BtnMaximizar.BackColor = Color.Red
    End Sub

    Private Sub BtnMaximizar_MouseLeave(sender As Object, e As EventArgs) Handles BtnMaximizar.MouseLeave
        BtnMaximizar.BackColor = Color.DodgerBlue
    End Sub

    Private Sub BtnRestaurar_MouseHover(sender As Object, e As EventArgs) Handles BtnRestaurar.MouseHover
        BtnRestaurar.BackColor = Color.Red
    End Sub

    Private Sub BtnRestaurar_MouseLeave(sender As Object, e As EventArgs) Handles BtnRestaurar.MouseLeave
        BtnRestaurar.BackColor = Color.DodgerBlue
    End Sub

    Private Sub BtnMinimizar_MouseHover(sender As Object, e As EventArgs) Handles BtnMinimizar.MouseHover
        BtnMinimizar.BackColor = Color.Red
    End Sub

    Private Sub BtnMinimizar_MouseLeave(sender As Object, e As EventArgs) Handles BtnMinimizar.MouseLeave
        BtnMinimizar.BackColor = Color.DodgerBlue
    End Sub
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub
    Private Sub titleBarRec_MouseDown(sender As Object, e As MouseEventArgs) Handles PnlTitle.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
End Class