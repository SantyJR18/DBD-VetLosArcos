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

    Private Sub BtnPaciente_Click(sender As Object, e As EventArgs) Handles BtnPaciente.Click
        OpenChildForm(New FrmPacientesM())
    End Sub

    Private Sub BtnCliente_Click(sender As Object, e As EventArgs) Handles BtnCliente.Click
        OpenChildForm(New FrmClientes())
    End Sub
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click, BttnCerrar.Click
        Application.Exit()
    End Sub

    Private Sub BtnCerrar_MouseHover(sender As Object, e As EventArgs) Handles BtnCerrar.MouseHover
        BtnCerrar.BackColor = Color.Red
    End Sub

    'Devuelve el color al boton cerrar
    Private Sub BtnCerrar_MouseLeave(sender As Object, e As EventArgs) Handles BtnCerrar.MouseLeave
        BtnCerrar.BackColor = Color.DodgerBlue
    End Sub

#End Region
End Class