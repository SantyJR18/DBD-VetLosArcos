Public Class FrmPacientesM
    Private dPaciente As New PacientesDao
    Private dClientes As New ClienteDao
    Private dRaza As New RazasDao
    Private dEspecie As New EspecieDao
    Private pacAct As New PacientesEntity

#Region "Botones del form"
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
    Private Sub FrmPacientesM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarEspecie()
        LlenarSexo()
        LlenarRaza()
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

    Sub Limpiar()
        TxtIdPac.Clear()
        TxtNombrePac.Clear()
        TxtPeso.Clear()
        TxtSenPar.Clear()
        TxtColorPac.Clear()
        TxtIdClt.Clear()
        TxtnombreClt.Clear()
        TxtapellidoClt.Clear()
        TxtcorreoClt.Clear()
        TxttelClt.Clear()
        CmbEspeciePac.SelectedIndex = -1
        CmbSexoPac.SelectedIndex = -1
        CmbRazaPac.SelectedIndex = -1
        DtFechaNac.Value = Now
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Limpiar()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            Dim pac As New PacientesEntity
            pac.Cliente = New ClienteEntity()
            pac.Especie = New EspeciesEntity()
            pac.Raza = New RazasEntity()

            pac.IdPaciente = Integer.Parse(TCPac.Text)
            pac.NombrePaciente = TxtNombrePac.Text
            pac.SexoPaciente = CmbSexoPac.SelectedValue
            pac.FechaNac = DtFechaNac.Value
            pac.Peso = Decimal.Parse(TxtPeso.Text)
            pac.Color = TxtColorPac.Text
            pac.SenPart = TxtSenPar.Text
            pac.Cliente.IdCliente = Integer.Parse(TxtIdClt.Text)
            pac.Especie.IdEspecie = CmbEspeciePac.SelectedValue
            'pac.Especie.NombreEspecie = CmbEspeciePac.Text
            pac.Raza.IdRaza = CmbRazaPac.SelectedValue
            'pac.Raza.NombreRaza = CmbRazaPac.Text

            If (dPaciente.AgregarRegistro(pac) = True) Then
                MsgBox("Registro guardado satisfactoriamente.", MsgBoxStyle.Information, "Registro de Desparasitaciones")
            Else
                MsgBox("No se pudo guardar el registro...", MsgBoxStyle.Exclamation, "Registro de Desparasitaciones")
            End If
        Catch ex As Exception
            MsgBox("Error al guardar registro: " & ex.Message, MsgBoxStyle.Critical, "Registro de Desparasitaciones")
        End Try
        'MostrarRegistros()
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Try
            Dim selectedRow As DataGridViewRow = dgvRegistrosAlmacenados.CurrentRow
            Dim pac As New PacientesEntity
            pac.Cliente = New ClienteEntity()
            pac.Especie = New EspeciesEntity()
            pac.Raza = New RazasEntity()

            pac.IdPaciente = TCPac.Text
            pac.NombrePaciente = TxtNombrePac.Text
            pac.SexoPaciente = CmbSexoPac.SelectedValue
            pac.FechaNac = DtFechaNac.Value
            pac.Peso = Decimal.Parse(TxtPeso.Text)
            pac.Color = TxtColorPac.Text
            pac.SenPart = TxtSenPar.Text
            pac.Cliente.IdCliente = Integer.Parse(TxtIdClt.Text)
            pac.Especie.IdEspecie = CmbEspeciePac.SelectedValue
            'pac.Especie.NombreEspecie = CmbEspeciePac.Text
            pac.Raza.IdRaza = CmbRazaPac.SelectedValue
            'pac.Raza.NombreRaza = CmbRazaPac.Text
            pac.IdPaciente = Integer.Parse(selectedRow.Cells(0).Value.ToString())

            If (dPaciente.EditarRegistro(pac) = True) Then
                MsgBox("Registro modificado satisfactoriamente.", MsgBoxStyle.Information, "Registro de Desparasitaciones")
                Limpiar()
            Else
                MsgBox("No se pudo modificar el registro...", MsgBoxStyle.Exclamation, "Registro de Desparasitaciones")
            End If
        Catch ex As Exception
            MsgBox("Error al guardar registro: " & ex.Message, MsgBoxStyle.Critical, "Registro de Desparasitaciones")
        End Try
        'MostrarRegistros()
    End Sub

    Sub DiseñoGrid()
        dgvRegistrosAlmacenados.Columns(0).HeaderText = "ID del Dueño"
        dgvRegistrosAlmacenados.Columns(1).HeaderText = "ID del Paciente"
        dgvRegistrosAlmacenados.Columns(2).HeaderText = "Nombre"
        dgvRegistrosAlmacenados.Columns(3).HeaderText = "Nacimiento"
        dgvRegistrosAlmacenados.Columns(4).HeaderText = "Especie"
        dgvRegistrosAlmacenados.Columns(5).HeaderText = "Sexo"
        dgvRegistrosAlmacenados.Columns(6).HeaderText = "Raza"
        dgvRegistrosAlmacenados.Columns(7).HeaderText = "Peso"
        dgvRegistrosAlmacenados.Columns(8).HeaderText = "Color"
        dgvRegistrosAlmacenados.Columns(9).HeaderText = "Señas particulares"
        dgvRegistrosAlmacenados.Columns(10).HeaderText = "Nombre del dueño"
        dgvRegistrosAlmacenados.Columns(11).HeaderText = "Apellido del dueño"
        dgvRegistrosAlmacenados.Columns(12).HeaderText = "Correo"
        dgvRegistrosAlmacenados.Columns(13).HeaderText = "Teléfno"
        dgvRegistrosAlmacenados.Columns(14).HeaderText = "Direcciión"
    End Sub

    Sub MostrarRegistros()
        Try
            dgvRegistrosAlmacenados.DataSource = dPaciente.MostrarRegistrosPacientesM.Tables(0)
            dgvRegistrosAlmacenados.Refresh()
            DiseñoGrid()
            GbRegistros.Text = "Registros almacenados: " & dgvRegistrosAlmacenados.Rows.Count
            dgvRegistrosAlmacenados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        Catch ex As Exception
            MsgBox("Ocurrió un error..." & ex.Message, MsgBoxStyle.Critical, "Mostrar Registros")
        End Try
    End Sub

    Private Sub dgvRegistrosAlmacenados_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgvRegistrosAlmacenados.MouseDoubleClick

        Dim fila As Integer = dgvRegistrosAlmacenados.CurrentRow.Index
        pacAct.Cliente = New ClienteEntity()
        pacAct.Especie = New EspeciesEntity()
        pacAct.Raza = New RazasEntity()

        pacAct.Cliente.IdCliente = dgvRegistrosAlmacenados.Rows(fila).Cells(0).Value
        pacAct.IdPaciente = Integer.Parse(dgvRegistrosAlmacenados.Rows(fila).Cells(1).Value)
        pacAct.NombrePaciente = dgvRegistrosAlmacenados.Rows(fila).Cells(2).Value
        pacAct.FechaNac = dgvRegistrosAlmacenados.Rows(fila).Cells(3).Value
        Dim especie As Integer
        pacAct.Especie.NombreEspecie = Integer.TryParse(dgvRegistrosAlmacenados.Rows(fila).Cells(4).Value, especie)
        pacAct.SexoPaciente = dgvRegistrosAlmacenados.Rows(fila).Cells(5).Value
        Dim raza As Integer
        pacAct.Raza.NombreRaza = Integer.TryParse(dgvRegistrosAlmacenados.Rows(fila).Cells(6).Value.ToString(), raza)
        pacAct.Peso = dgvRegistrosAlmacenados.Rows(fila).Cells(7).Value
        pacAct.Color = dgvRegistrosAlmacenados.Rows(fila).Cells(8).Value
        pacAct.SenPart = dgvRegistrosAlmacenados.Rows(fila).Cells(9).Value
        pacAct.Cliente.PrimerNombre = dgvRegistrosAlmacenados.Rows(fila).Cells(10).Value
        pacAct.Cliente.PrimerApellido = dgvRegistrosAlmacenados.Rows(fila).Cells(11).Value
        pacAct.Cliente.CorreoCliente = dgvRegistrosAlmacenados.Rows(fila).Cells(12).Value
        pacAct.Cliente.TelefonoCliente = dgvRegistrosAlmacenados.Rows(fila).Cells(13).Value
        pacAct.Cliente.DireccionCliente = dgvRegistrosAlmacenados.Rows(fila).Cells(14).Value

        TxtIdClt.Text = pacAct.Cliente.IdCliente
        TCPac.Text = pacAct.IdPaciente
        TxtNombrePac.Text = pacAct.NombrePaciente
        DtFechaNac.Value = pacAct.FechaNac
        CmbEspeciePac.Text = pacAct.Especie.NombreEspecie
        CmbSexoPac.SelectedValue = pacAct.SexoPaciente
        CmbRazaPac.Text = pacAct.Raza.NombreRaza
        TxtPeso.Text = pacAct.Peso
        TxtColorPac.Text = pacAct.Color
        TxtSenPar.Text = pacAct.SenPart
        TxtnombreClt.Text = pacAct.Cliente.PrimerNombre
        TxtapellidoClt.Text = pacAct.Cliente.PrimerApellido
        TxtcorreoClt.Text = pacAct.Cliente.CorreoCliente
        TxttelClt.Text = pacAct.Cliente.TelefonoCliente
        TxttelClt.Text = pacAct.Cliente.DireccionCliente

        TCPacientesMed.SelectedIndex = 1
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Limpiar()
    End Sub
#End Region

End Class