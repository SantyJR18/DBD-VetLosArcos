Public Class FrmVacunas

    Private dVacuna As New VacunasDao
    Private dRegistroVacuna As New RegistroVacunacionesDao
    Private dPaciente As New PacientesDao
    Private dEspecie As New EspecieDao
    Private dRaza As New RazasDao
    Private dMarcasVac As New MarcasVacunasDao
    'Dim idRegVacuna As Integer = -1
    Dim regActual As New RegistroVacunacionesEntity

#Region "Botonoes de form"
    'Cierra el form
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    'Agrega color rojo al boton cerrar
    Private Sub BtnCerrar_MouseHover(sender As Object, e As EventArgs) Handles BtnCerrar.MouseHover
        BtnCerrar.BackColor = Color.Red
    End Sub

    'Devuelve el color al boton cerrar
    Private Sub BtnCerrar_MouseLeave(sender As Object, e As EventArgs) Handles BtnCerrar.MouseLeave
        BtnCerrar.BackColor = Color.DodgerBlue
    End Sub
#End Region

#Region "txtBusqueda"
    Private Sub txtBusqueda_Enter(sender As Object, e As EventArgs) Handles txtBusqueda.Enter
        If txtBusqueda.Text = "Buscar Registro de Vacunas por ID CLIENTE" Then
            txtBusqueda.Text = ""
            txtBusqueda.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub txtBusqueda_Leave(sender As Object, e As EventArgs) Handles txtBusqueda.Leave
        If txtBusqueda.Text = "" Then
            txtBusqueda.Text = "Buscar Registro de Vacunas por ID CLIENTE"
            txtBusqueda.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        If txtBusqueda.Text = "Buscar Registro de Vacunas por ID CLIENTE" Then
            Return
        End If
    End Sub
#End Region

#Region "CRUD"
    Private Sub FrmVacunas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarEspecie()
        LlenarMarcaVacuna()
        LlenarRaza()
        LlenarSexo()
        LlenarVacuna()
        MostrarRegistros()
        dgvRegistrosAlmacenados.AllowUserToAddRows = False
    End Sub

    Sub LlenarEspecie()
        Try
            CmbEspeciePac.DataSource = dEspecie.MostrarNombre.Tables(0)
            CmbEspeciePac.DisplayMember = "especie"
            CmbEspeciePac.ValueMember = "nombreEspecie"
            CmbEspeciePac.Refresh()
        Catch ex As Exception
            MsgBox("Error al mostrar ID Especie", MsgBoxStyle.Critical, "Especie")
        End Try
    End Sub

    Sub LlenarSexo()
        Try
            CmbSexoPac.DataSource = dPaciente.MostrarSexo.Tables(0)
            CmbSexoPac.DisplayMember = "sexo"
            CmbSexoPac.ValueMember = "sexoPaciente"
            CmbSexoPac.Refresh()
        Catch ex As Exception
            MsgBox("Error al mostrar el sexo del paciente", MsgBoxStyle.Critical, "Sexo")
        End Try
    End Sub

    Sub LlenarRaza()
        Try
            CmbRazaPac.DataSource = dRaza.MostrarRaza.Tables(0)
            CmbRazaPac.DisplayMember = "raza"
            CmbRazaPac.ValueMember = "nombreRaza"
            CmbRazaPac.Refresh()
        Catch ex As Exception
            MsgBox("Error al mostrar el nombre de la raza", MsgBoxStyle.Critical, "Raza")
        End Try
    End Sub

    Sub LlenarVacuna()
        Try
            CmbVacuna.DataSource = dVacuna.MostrarVacunas.Tables(0)
            CmbVacuna.DisplayMember = "nombreVacuna"
            CmbVacuna.ValueMember = "idVacuna"
            CmbVacuna.Refresh()
        Catch ex As Exception
            MsgBox("Error al mostrar el nombre de la vacuna", MsgBoxStyle.Critical, "Vacuna")
        End Try
    End Sub

    Sub LlenarMarcaVacuna()
        Try
            CmbMarcaVac.DataSource = dMarcasVac.MostrarMarcasVacunas.Tables(0)
            CmbMarcaVac.DisplayMember = "marca"
            CmbMarcaVac.ValueMember = "nombreMarcaVac"
            CmbMarcaVac.Refresh()
        Catch ex As Exception
            MsgBox("Error al mostrar el nombre de la marca de la vacuna", MsgBoxStyle.Critical, "Marca")
        End Try
    End Sub

    Sub Limpiar()
        TxtIdPac.Clear()
        TxtNombrePac.Clear()
        TxtPeso.Clear()
        CmbEspeciePac.SelectedIndex = -1
        CmbSexoPac.SelectedIndex = -1
        CmbRazaPac.SelectedIndex = -1
        CmbVacuna.SelectedIndex = -1
        CmbMarcaVac.SelectedIndex = -1
        DtPac.Value = Now
        DtApliVac.Value = Now
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Limpiar()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            Dim regVac As New RegistroVacunacionesEntity()
            regVac.Vacuna.IdVacuna = Convert.ToInt32(CmbVacuna.SelectedValue)
            regVac.Paciente.IdPaciente = TxtNombrePac.Text
            regVac.FechaVacunacion = DtApliVac.Text

            If dRegistroVacuna.AgregarRegistro(regVac) Then
                MsgBox("Registro guardado satisfactoriamente.", MsgBoxStyle.Information, "Registro de Vacunaciones")
            Else
                MsgBox("No se pudo guardar el registro...", MsgBoxStyle.Exclamation, "Registro de Vacunaciones")
            End If
        Catch ex As Exception
            MsgBox("Error al guardar registro: " & ex.Message, MsgBoxStyle.Critical, "Registro de Vacunaciones")
        End Try
        MostrarRegistros()
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Try
            regActual.Paciente.IdPaciente = TxtIdPac.Text

            If dRegistroVacuna.EditarRegistro(regActual) Then
                MsgBox("Regtro modificado satisfactoriamente.", MsgBoxStyle.Information, "Registro de Vacunaciones")
                Limpiar()
                MostrarRegistros()
            Else
                MsgBox("No se pudo modificar el registro...", MsgBoxStyle.Exclamation, "Registro de Vacunaciones")
            End If
        Catch ex As Exception
            MsgBox("Error al guardar registro: " & ex.Message, MsgBoxStyle.Critical, "Registro de Vacunaciones")
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
        dgvRegistrosAlmacenados.Columns(7).HeaderText = "Nombre de la vacuna"
        dgvRegistrosAlmacenados.Columns(8).HeaderText = "Marca"
        dgvRegistrosAlmacenados.Columns(9).HeaderText = "Fecha de vacunación"
    End Sub

    Sub MostrarRegistros()
        Try
            dgvRegistrosAlmacenados.DataSource = dRegistroVacuna.MostrarRegistrosPacientes.Tables(0)
            dgvRegistrosAlmacenados.Refresh()
            DiseñoGrid()
            GbRegistros.Text = "Registros almacenados: " & dgvRegistrosAlmacenados.Rows.Count
            dgvRegistrosAlmacenados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvRegistrosAlmacenados_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgvRegistrosAlmacenados.MouseDoubleClick
        Dim fila As Integer = dgvRegistrosAlmacenados.CurrentRow.Index
        regActual.Paciente = New PacientesEntity()
        regActual.Vacuna = New VacunasEntity()
        regActual.Vacuna.MarcaVac = New MarcasVacunasEntity()
        regActual.Paciente.Especie = New EspeciesEntity()
        regActual.Paciente.Raza = New RazasEntity()

        regActual.Paciente.IdPaciente = Integer.Parse(dgvRegistrosAlmacenados.Rows(fila).Cells(0).Value)
        regActual.Paciente.NombrePaciente = dgvRegistrosAlmacenados.Rows(fila).Cells(1).Value
        regActual.Paciente.FechaNac = dgvRegistrosAlmacenados.Rows(fila).Cells(2).Value
        regActual.Paciente.Especie.NombreEspecie = dgvRegistrosAlmacenados.Rows(fila).Cells(3).Value
        regActual.Paciente.SexoPaciente = dgvRegistrosAlmacenados.Rows(fila).Cells(4).Value
        regActual.Paciente.Raza.NombreRaza = dgvRegistrosAlmacenados.Rows(fila).Cells(5).Value
        regActual.Paciente.Peso = dgvRegistrosAlmacenados.Rows(fila).Cells(6).Value
        regActual.Vacuna.NombreVacuna = dgvRegistrosAlmacenados.Rows(fila).Cells(7).Value
        regActual.Vacuna.MarcaVac.NombreMarcaVac = dgvRegistrosAlmacenados.Rows(fila).Cells(8).Value
        regActual.FechaVacunacion = dgvRegistrosAlmacenados.Rows(fila).Cells(9).Value

        TxtIdPac.Text = regActual.Paciente.IdPaciente
        TxtNombrePac.Text = regActual.Paciente.NombrePaciente
        DtPac.Value = regActual.Paciente.FechaNac
        CmbEspeciePac.SelectedValue = regActual.Paciente.Especie.NombreEspecie
        CmbSexoPac.SelectedValue = regActual.Paciente.SexoPaciente
        CmbRazaPac.SelectedValue = regActual.Paciente.Raza.NombreRaza
        TxtPeso.Text = regActual.Paciente.Peso
        CmbVacuna.SelectedValue = regActual.Vacuna.NombreVacuna
        CmbMarcaVac.SelectedValue = regActual.Vacuna.MarcaVac.NombreMarcaVac
        DtApliVac.Value = regActual.FechaVacunacion

        TCPacientes.SelectedIndex = 1

    End Sub

#End Region

End Class