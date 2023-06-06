Imports System.Runtime.InteropServices

Public Class FrmClientes

    Private dCliente As New ClienteDao

#Region "Botones del Formulario"

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

#Region "Funciones del FrmClientes"

    Private Sub FrmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarRegistros()
    End Sub

    Sub MostrarRegistros()
        Try
            dgvRegistrosAlmacenados.DataSource = dCliente.MostrarRegistros.Tables(0)
            dgvRegistrosAlmacenados.Refresh()
            GbRegistros.Text = "Registros almacenados: " & dgvRegistrosAlmacenados.Rows.Count
        Catch ex As Exception

        End Try
    End Sub


    Private Sub dgvRegistrosAlmacenados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRegistrosAlmacenados.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim idCliente As String = dgvRegistrosAlmacenados.Rows(e.RowIndex).Cells("ID CLIENTE").Value.ToString()
            Dim cliente As ClienteEntity = dCliente.ObtenerRegistro(idCliente)
            If cliente IsNot Nothing Then
                ' Mostrar los datos del cliente en los controles del formulario
                txtIdCliente.Text = cliente.IdCliente
                txtPrimerNombre.Text = cliente.PrimerNombre
                txtSegundoNombre.Text = cliente.SegundoNombre
                txtPrimerApe.Text = cliente.PrimerApellido
                txtSegundoApe.Text = cliente.SegundoApellido
                txtDireccionClt.Text = cliente.DireccionCliente
                txtCorreoClt.Text = cliente.CorreoCliente
                txtTelClt.Text = cliente.TelefonoCliente
                TCClientes.SelectedIndex = 1
            End If
        End If
    End Sub

    Private Sub Limpiar()
        txtIdCliente.Clear()
        txtPrimerNombre.Clear()
        txtSegundoNombre.Clear()
        txtPrimerApe.Clear()
        txtSegundoApe.Clear()
        txtDireccionClt.Clear()
        txtCorreoClt.Clear()
        txtTelClt.Clear()
    End Sub

    Private Sub txtBusqueda_Enter(sender As Object, e As EventArgs) Handles txtBusqueda.Enter
        If txtBusqueda.Text = "Buscar Registro de Clientes por ID" Then
            txtBusqueda.Text = ""
            txtBusqueda.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub txtBusqueda_Leave(sender As Object, e As EventArgs) Handles txtBusqueda.Leave
        If txtBusqueda.Text = "" Then
            txtBusqueda.Text = "Buscar Registro de Clientes por ID"
            txtBusqueda.ForeColor = Color.DimGray
        End If
    End Sub
    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        If txtBusqueda.Text = "Buscar Registro de Clientes por ID" Then
            Return
        End If

        Dim registroServicioDao As New RegistroServiciosDao()

        If String.IsNullOrWhiteSpace(txtBusqueda.Text) Then
            MostrarRegistros()
        Else
            Dim ds As DataSet = registroServicioDao.BuscarRegistroPorIdCliente("%" & txtBusqueda.Text.Trim() & "%")
            dgvRegistrosAlmacenados.DataSource = ds.Tables(0)
        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            Dim registroCliente As New ClienteEntity With {
                .IdCliente = txtIdCliente.Text,
                .PrimerNombre = txtPrimerNombre.Text,
                .SegundoNombre = txtSegundoNombre.Text,
                .PrimerApellido = txtPrimerApe.Text,
                .SegundoApellido = txtSegundoApe.Text,
                .DireccionCliente = txtDireccionClt.Text,
                .CorreoCliente = txtCorreoClt.Text,
                .TelefonoCliente = txtTelClt.Text
        }

            If dCliente.AgregarRegistro(registroCliente) Then
                MessageBox.Show("Registro agregado exitosamente", "Agregar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Limpiar()
                MostrarRegistros()
            Else
                MessageBox.Show("Error al agregar el registro", "Agregar Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox("Error al guardar registro: " & ex.Message, MsgBoxStyle.Critical, "Clientes")
        End Try
        MostrarRegistros()
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Try
            Dim registroCliente As New ClienteEntity With {
                .IdCliente = txtIdCliente.Text,
                .PrimerNombre = txtPrimerNombre.Text,
                .SegundoNombre = txtSegundoNombre.Text,
                .PrimerApellido = txtPrimerApe.Text,
                .SegundoApellido = txtSegundoApe.Text,
                .DireccionCliente = txtDireccionClt.Text,
                .CorreoCliente = txtCorreoClt.Text,
                .TelefonoCliente = txtTelClt.Text
            }
            If dCliente.EditarRegistro(registroCliente) Then
                MsgBox("Regtro modificado satisfactoriamente.", MsgBoxStyle.Information, "Empleados")
            Else
                MsgBox("No se pudo modificar el registro...", MsgBoxStyle.Exclamation, "Empleados")
            End If
        Catch ex As Exception
            MsgBox("Error al guardar registro: " & ex.Message, MsgBoxStyle.Critical, "Clientes")
        End Try
        MostrarRegistros()
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Limpiar()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) 
        Dim idCliente As String = txtIdCliente.Text

        ' Verificar si se ha ingresado un ID de cliente válido
        If Not String.IsNullOrEmpty(idCliente) Then
            ' Confirmar la eliminación del cliente
            Dim result As DialogResult = MessageBox.Show("¿Estás seguro de que quieres eliminar el cliente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Try
                    ' Llamar al método en el DAO para eliminar el cliente
                    Dim success As Boolean = dCliente.EliminarRegistro(idCliente)

                    If success Then
                        MessageBox.Show("Cliente eliminado correctamente", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Limpiar()  ' Limpiar los campos después de eliminar el cliente
                        MostrarRegistros()  ' Volver a cargar los registros actualizados en el DataGridView
                    Else
                        MessageBox.Show("No se pudo eliminar el cliente", "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error al eliminar el cliente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            MessageBox.Show("Por favor, ingrese un ID de cliente válido", "ID de cliente requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

#End Region
End Class