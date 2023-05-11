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


#End Region
End Class