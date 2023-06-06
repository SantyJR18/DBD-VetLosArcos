Imports System.Runtime.InteropServices

Public Class FrmMenu

#Region "Call Child Forms"

    Private currentForm As Form = Nothing
    Private Sub OpenChildForm(childForm As Form)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelChildForm.Controls.Add(childForm)
        PanelChildForm.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

#End Region

#Region "Botones del Formulario"

    Private Sub BtnPaciente_Click(sender As Object, e As EventArgs) Handles BtnPaciente.Click
        OpenChildForm(New FrmPacientesM())
    End Sub

    Private Sub BtnCliente_Click(sender As Object, e As EventArgs) Handles BtnCliente.Click
        OpenChildForm(New FrmClientes())
    End Sub

    Private Sub BtnServicio_Click(sender As Object, e As EventArgs) Handles BtnServicio.Click
        OpenChildForm(New FrmServicio())
    End Sub

    Private Sub BtnDesparasitacion_Click(sender As Object, e As EventArgs) Handles BtnDesparasitacion.Click
        OpenChildForm(New FrmDesparasitante())
    End Sub


    Private Sub BtnVacunas_Click(sender As Object, e As EventArgs) Handles BtnVacunas.Click
        OpenChildForm(New FrmVacunas())
    End Sub

    Private Sub BtnDiagnostico_Click(sender As Object, e As EventArgs) Handles BtnDiagnostico.Click
        OpenChildForm(New FrmDiagnostico())
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Application.Exit()
    End Sub

    Private Sub BtnClose_MouseHover(sender As Object, e As EventArgs) Handles BtnClose.MouseHover
        BtnClose.BackColor = Color.Red
    End Sub

    Private Sub BtnClose_MouseLeave(sender As Object, e As EventArgs) Handles BtnClose.MouseLeave
        BtnClose.BackColor = Color.White
    End Sub
    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles BtnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnMinimize_MouseHover(sender As Object, e As EventArgs) Handles BtnMinimize.MouseHover
        BtnMinimize.BackColor = Color.Red
    End Sub

    Private Sub BtnMinimize_MouseLeave(sender As Object, e As EventArgs) Handles BtnMinimize.MouseLeave
        BtnMinimize.BackColor = Color.White
    End Sub

    Private Sub BtnCerrarSes_Click(sender As Object, e As EventArgs) Handles BtnCerrarSes.Click
        Dim resp As DialogResult = MsgBox("¿Estás seguro que quieres salir?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Confirmación")
        If (resp = DialogResult.Yes) Then
            Me.Close()
            FrmLogin.Show()
        End If
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

End Class