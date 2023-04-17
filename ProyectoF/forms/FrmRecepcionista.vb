Imports System.Runtime.InteropServices

Public Class FrmRecepcionista
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Application.Exit()
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

    Private Sub FrmRecepcionista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TmrFecha.Enabled = True
        TmrTiempo.Enabled = True
    End Sub

    Private Sub TmrTiempo_Tick(sender As Object, e As EventArgs) Handles TmrTiempo.Tick
        LblTiempo.Text = Date.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub TmrFecha_Tick(sender As Object, e As EventArgs) Handles TmrFecha.Tick
        LblFecha.Text = Date.Now.ToString("dd-MM-yyyy")
    End Sub
End Class