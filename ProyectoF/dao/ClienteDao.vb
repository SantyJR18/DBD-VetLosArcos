Imports System.Data.SqlClient

Public Class ClienteDao
    Dim strConn As String = My.Settings.cStrDBLosArcos

    Public Function AgregarRegistro(ByVal cliente As ClienteEntity) As Boolean
        Dim resp As Boolean = False

        Try
            Dim tsql As String = "INSERT INTO Cliente(idCliente, primerNombre, segundoNombre, primerApellido, 
                              segundoApellido, direccionCliente, correoCliente, telefonoCliente)
                              VALUES(@idCliente, @primerNombre, @segundoNombre, @primerApellido, 
                              @segundoApellido, @direccionCliente, @correoCliente, @telefonoCliente)"
            Dim conn As New SqlConnection(strConn)
            Dim cmb As New SqlCommand()
            cmb.CommandType = CommandType.Text
            cmb.CommandText = tsql
            cmb.Parameters.AddWithValue("@idCliente", cliente.IdCliente)
            cmb.Parameters.AddWithValue("@primerNombre", cliente.PrimerNombre)
            cmb.Parameters.AddWithValue("@segundoNombre", cliente.SegundoNombre)
            cmb.Parameters.AddWithValue("@primerApellido", cliente.PrimerApellido)
            cmb.Parameters.AddWithValue("@segundoApellido", cliente.SegundoApellido)
            cmb.Parameters.AddWithValue("@direccionCliente", cliente.DireccionCliente)
            cmb.Parameters.AddWithValue("@correoCliente", cliente.CorreoCliente)
            cmb.Parameters.AddWithValue("@telefonoCliente", cliente.TelefonoCliente)
            cmb.Connection.Open()
            If (cmb.ExecuteNonQuery <> 0) Then
                resp = False
            End If
            cmb.Connection.Close()
        Catch ex As Exception
            resp = False
        End Try
        Return resp
    End Function

    Public Function EditarRegistro(ByVal cliente As ClienteEntity) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "UPDATE Cliente SET primerNombre = @primerNombre, 
                              segundoNombre = @segundoNombre, primerApellido = @primerApellido,
                              segundoApellido = @segundoApellido, direccionCliente = @direccionClinte, 
                              correoCliente = @correoCliente, telefonoCliente = @telefonoCliente WHERE idCliente = @idCliente"
            Dim conn As New SqlConnection(strConn)
            Dim cmb As New SqlCommand()
            cmb.CommandType = CommandType.Text
            cmb.CommandText = tsql
            cmb.Parameters.AddWithValue("@idCliente", cliente.IdCliente)
            cmb.Parameters.AddWithValue("@primerNombre", cliente.PrimerNombre)
            cmb.Parameters.AddWithValue(" @segundoNombre", cliente.SegundoNombre)
            cmb.Parameters.AddWithValue(" @primerApellido", cliente.PrimerApellido)
            cmb.Parameters.AddWithValue(" @segundoApellido", cliente.SegundoApellido)
            cmb.Parameters.AddWithValue(" @direccionCliente", cliente.DireccionCliente)
            cmb.Parameters.AddWithValue(" @correoCliente", cliente.CorreoCliente)
            cmb.Parameters.AddWithValue(" @telefonoCliente", cliente.TelefonoCliente)
            cmb.Connection = conn
            cmb.Connection.Open()
            If (cmb.ExecuteNonQuery <> 0) Then
                resp = False
            End If
            cmb.Connection.Close()
        Catch ex As Exception
            resp = False
        End Try
        Return resp
    End Function

    Public Function EliminarRegistro(ByVal idCliente As Integer) As Boolean
        Dim resp As Boolean = True
        Try
            Dim tsql As String = "DELETE FROM Cliente WHERE idCliente = @idCliente"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue(" @idCliente", idCliente)
            cmd.Connection = conn
            cmd.Connection.Open()
            If (cmd.ExecuteNonQuery <> 0) Then
                resp = True
            End If
            cmd.Connection.Close()
        Catch ex As Exception
            resp = False
        End Try
        Return resp
    End Function

    Public Function MostrarRegistros() As DataSet
        Dim ds As New DataSet
        Try
            Dim tsql As String = "SELECT * FROM Cliente"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception

        End Try
        Return ds
    End Function


End Class
