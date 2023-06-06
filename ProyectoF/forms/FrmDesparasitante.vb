Public Class FrmDesparasitante
    Private dRegistroDesparasitaciones As New RegistroDesparasitacionesDao
    Private dDesparasitantes As New DesparasitantesDao
    Private dMarcaDes As New MarcasDesparasitantesDao
    ''Private dExpedientes As New ExpedientesDao

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

    Private Sub txtBusqueda_Enter(sender As Object, e As EventArgs)
        If txtBusqueda.Text = "Buscar Paciente por Nombre" Then
            txtBusqueda.Text = ""
            txtBusqueda.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtBusqueda_Leave(sender As Object, e As EventArgs)
        If txtBusqueda.Text = "" Then
            txtBusqueda.Text = "Buscar Paciente por Nombre"
            txtBusqueda.ForeColor = Color.DimGray
        End If
    End Sub

    Sub MostrarRegistros()
        Try
            dgvRegistrosAlmacenados.DataSource = dRegistroDesparasitaciones.MostrarRegistros.Tables(0)
            dgvRegistrosAlmacenados.Refresh()
            GbRegistros.Text = "Registros almacenados: " & dgvRegistrosAlmacenados.Rows.Count
            'dgvRegistrosAlmacenados.AutoResizeColumn()
            dgvRegistrosAlmacenados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FrmDesparasitante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarRegistros()
    End Sub

    Private Sub TCPacientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TCPacientes.SelectedIndexChanged

    End Sub
End Class