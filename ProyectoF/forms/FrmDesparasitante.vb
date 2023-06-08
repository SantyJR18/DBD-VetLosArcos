Public Class FrmDesparasitante

    Private dRegistroDesparasitaciones As New RegistroDesparasitacionesDao
    Private dDesparasitantes As New DesparasitantesDao
    Private dPaciente As New PacientesDao
    Private dEspecie As New EspecieDao
    Private dRaza As New RazasDao
    Private dMarcaDes As New MarcasDesparasitantesDao
    Dim regActDesp As New RegistroDesparasitacionesEntity

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

#Region "Busqueda"
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
#End Region

#Region "CRUD"

    Private Sub FrmDesparasitante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarDesparasitante()
        LlenarEspecie()
        LlenarMarcaDesp()
        LlenarRaza()
        LlenarSexo()
        MostrarRegistros()
        dgvRegistrosAlmacenados.AllowUserToAddRows = False
    End Sub


    Sub LlenarSexo()
        Try
            CmbSexoPac.DataSource = dPaciente.MostrarSexo.Tables(0)
            CmbSexoPac.DisplayMember = "sexoPaciente"
            CmbSexoPac.ValueMember = "sexoPaciente"
            CmbSexoPac.Refresh()
        Catch ex As Exception
            MsgBox("Error al mostrar el sexo del paciente", MsgBoxStyle.Critical, "Sexo")
        End Try
    End Sub

    Sub LlenarEspecie()
        Try
            CmbEspeciePac.DataSource = dEspecie.MostrarRegistros.Tables(0)
            CmbEspeciePac.DisplayMember = "nombreEspecie"
            CmbEspeciePac.ValueMember = "idEspecie"
            CmbEspeciePac.Refresh()
        Catch ex As Exception
            MsgBox("Error al mostrar ID Especie", MsgBoxStyle.Critical, "Especie")
        End Try
    End Sub

    Sub LlenarRaza()
        Try
            CmbRazaPac.DataSource = dRaza.MostrarRegistros.Tables(0)
            CmbRazaPac.DisplayMember = "nombreRaza"
            CmbRazaPac.ValueMember = "idRaza"
            CmbRazaPac.Refresh()
        Catch ex As Exception
            MsgBox("Error al mostrar el nombre de la raza", MsgBoxStyle.Critical, "Raza")
        End Try
    End Sub

    Sub LlenarDesparasitante()
        Try
            CmbDesp.DataSource = dDesparasitantes.MostrarRegistro.Tables(0)
            CmbDesp.DisplayMember = "nombreDes"
            CmbDesp.ValueMember = "idDesparasitante"
            CmbDesp.Refresh()
        Catch ex As Exception
            MsgBox("Error al mostrar el nombre de la vacuna", MsgBoxStyle.Critical, "Desparasitante")
        End Try
    End Sub

    Sub LlenarMarcaDesp()
        Try
            CmbMarcaDesp.DataSource = dMarcaDes.MostrarRegistros.Tables(0)
            CmbMarcaDesp.DisplayMember = "nombreMarcaDes"
            CmbMarcaDesp.ValueMember = "idMarcaDes"
            CmbMarcaDesp.Refresh()
        Catch ex As Exception
            MsgBox("Error al mostrar el nombre de la marca del desparasitante", MsgBoxStyle.Critical, "Marca")
        End Try
    End Sub

    Sub Limpiar()
        TxtIdPac.Clear()
        TxtNombrePac.Clear()
        TxtPeso.Clear()
        CmbEspeciePac.SelectedIndex = -1
        CmbSexoPac.SelectedIndex = -1
        CmbRazaPac.SelectedIndex = -1
        CmbDesp.SelectedIndex = -1
        CmbMarcaDesp.SelectedIndex = -1
        DtPac.Value = Now
        DtApliDesp.Value = Now
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Limpiar()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs)
        Try
            Dim regDesp As New RegistroDesparasitacionesEntity
            regDesp.Paciente = New PacientesEntity()
            regDesp.Desparasitante = New DesparasitantesEntity()

            regDesp.Paciente.IdPaciente = Integer.Parse(TxtIdPac.Text)
            regDesp.Desparasitante.IdDesparasitante = Integer.Parse(CmbDesp.SelectedValue)
            regDesp.FechaDesparasitaciones = DtApliDesp.Value

            If (dRegistroDesparasitaciones.AgregarRegistro(regDesp) = True) Then
                MsgBox("Registro guardado satisfactoriamente.", MsgBoxStyle.Information, "Registro de Desparasitaciones")
            Else
                MsgBox("No se pudo guardar el registro...", MsgBoxStyle.Exclamation, "Registro de Desparasitaciones")
            End If
        Catch ex As Exception
            MsgBox("Error al guardar registro: " & ex.Message, MsgBoxStyle.Critical, "Registro de Desparasitaciones")
        End Try
        MostrarRegistros()
    End Sub


    Sub DiseñoGrid()
        dgvRegistrosAlmacenados.Columns(0).HeaderText = "ID del Paciente"
        dgvRegistrosAlmacenados.Columns(1).HeaderText = "Nombre"
        dgvRegistrosAlmacenados.Columns(2).HeaderText = "Nacimiento"
        dgvRegistrosAlmacenados.Columns(3).HeaderText = "Especie"
        dgvRegistrosAlmacenados.Columns(4).HeaderText = "Sexo"
        dgvRegistrosAlmacenados.Columns(5).HeaderText = "Raza"
        dgvRegistrosAlmacenados.Columns(6).HeaderText = "Peso"
        dgvRegistrosAlmacenados.Columns(7).HeaderText = "Nombre del desparasitante"
        dgvRegistrosAlmacenados.Columns(8).HeaderText = "Marca"
        dgvRegistrosAlmacenados.Columns(9).HeaderText = "Fecha de desparasitación"
    End Sub

    Sub MostrarRegistros()
        Try
            dgvRegistrosAlmacenados.DataSource = dRegistroDesparasitaciones.MostrarRegistrosPacientes.Tables(0)
            dgvRegistrosAlmacenados.Refresh()
            DiseñoGrid()
            GbRegistros.Text = "Registros almacenados: " & dgvRegistrosAlmacenados.Rows.Count
            dgvRegistrosAlmacenados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvRegistrosAlmacenados_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgvRegistrosAlmacenados.MouseDoubleClick
        Dim fila As Integer = dgvRegistrosAlmacenados.CurrentRow.Index
        regActDesp.Paciente = New PacientesEntity()
        regActDesp.Desparasitante = New DesparasitantesEntity()
        regActDesp.Desparasitante.MarcaDes = New MarcasDesparasitantesEntity()
        regActDesp.Paciente.Especie = New EspeciesEntity()
        regActDesp.Paciente.Raza = New RazasEntity()

        regActDesp.Paciente.IdPaciente = Integer.Parse(dgvRegistrosAlmacenados.Rows(fila).Cells(0).Value)
        regActDesp.Paciente.NombrePaciente = dgvRegistrosAlmacenados.Rows(fila).Cells(1).Value
        regActDesp.Paciente.FechaNac = dgvRegistrosAlmacenados.Rows(fila).Cells(2).Value
        regActDesp.Paciente.Especie.NombreEspecie = dgvRegistrosAlmacenados.Rows(fila).Cells(3).Value
        regActDesp.Paciente.SexoPaciente = dgvRegistrosAlmacenados.Rows(fila).Cells(4).Value
        regActDesp.Paciente.Raza.NombreRaza = dgvRegistrosAlmacenados.Rows(fila).Cells(5).Value
        regActDesp.Paciente.Peso = dgvRegistrosAlmacenados.Rows(fila).Cells(6).Value
        regActDesp.Desparasitante.NombreDes = dgvRegistrosAlmacenados.Rows(fila).Cells(7).Value
        regActDesp.Desparasitante.MarcaDes.NombreMarcaDes = dgvRegistrosAlmacenados.Rows(fila).Cells(8).Value
        regActDesp.FechaDesparasitaciones = dgvRegistrosAlmacenados.Rows(fila).Cells(9).Value

        TxtIdPac.Text = regActDesp.Paciente.IdPaciente
        TxtNombrePac.Text = regActDesp.Paciente.NombrePaciente
        DtPac.Value = regActDesp.Paciente.FechaNac
        CmbEspeciePac.Text = regActDesp.Paciente.Especie.NombreEspecie
        CmbSexoPac.Text = regActDesp.Paciente.SexoPaciente
        CmbRazaPac.Text = regActDesp.Paciente.Raza.NombreRaza
        TxtPeso.Text = regActDesp.Paciente.Peso
        CmbMarcaDesp.Text = regActDesp.Desparasitante.MarcaDes.NombreMarcaDes
        DtApliDesp.Value = regActDesp.FechaDesparasitaciones

        TCPacientes.SelectedIndex = 1

    End Sub
#End Region
End Class