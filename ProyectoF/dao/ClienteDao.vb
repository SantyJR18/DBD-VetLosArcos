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

    Public Function EliminarRegistro(ByVal idCliente As String) As Boolean
        Dim resp As Boolean = True
        Try
            Dim tsql As String = "DELETE FROM Cliente WHERE idCliente = @idCliente"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@idCliente", idCliente)
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
            Dim tsql As String = "SELECT idCliente AS 'ID CLIENTE', primerNombre AS 'PRIMER NOMBRE', segundoNombre AS 'SEGUNDO NOMBRE', primerApellido AS 'PRIMER APELLIDO', segundoApellido AS 'SEGUNDO APELLIDO', direccionCliente AS 'DIRECCIÓN', correoCliente AS 'CORREO ELECTRÓNICO', telefonoCliente AS 'TELÉFONO' FROM Cliente"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception

        End Try
        Return ds
    End Function

    Public Function ObtenerRegistro(ByVal idCliente As String) As ClienteEntity
        Dim cliente As New ClienteEntity()
        Try
            Dim tsql As String = "SELECT * FROM Cliente WHERE idCliente = @idCliente"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@idCliente", idCliente)
            conn.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                reader.Read()
                cliente.IdCliente = reader.GetString(reader.GetOrdinal("idCliente"))
                cliente.PrimerNombre = reader.GetString(reader.GetOrdinal("primerNombre"))
                cliente.SegundoNombre = reader.GetString(reader.GetOrdinal("segundoNombre"))
                cliente.PrimerApellido = reader.GetString(reader.GetOrdinal("primerApellido"))
                cliente.SegundoApellido = reader.GetString(reader.GetOrdinal("segundoApellido"))
                cliente.DireccionCliente = reader.GetString(reader.GetOrdinal("direccionCliente"))
                cliente.CorreoCliente = reader.GetString(reader.GetOrdinal("correoCliente"))
                cliente.TelefonoCliente = reader.GetString(reader.GetOrdinal("telefonoCliente"))
                ' Asigna los demás campos del objeto ClienteEntity de manera similar
            End If
            reader.Close()
            conn.Close()
        Catch ex As Exception
            cliente = Nothing
        End Try
        Return cliente
    End Function

    Public Function BuscarRegistroPorIdCliente(ByVal idCliente As String) As DataSet
        Dim ds As New DataSet()
        Try
            Dim tsql As String = "SELECT idCliente AS 'ID CLIENTE', primerNombre AS 'PRIMER NOMBRE', segundoNombre AS 'SEGUNDO NOMBRE', primerApellido AS 'PRIMER APELLIDO', segundoApellido AS 'SEGUNDO APELLIDO', direccionCliente AS 'DIRECCIÓN', correoCliente AS 'CORREO', telefonoCliente AS 'TELÉFONO' FROM Cliente WHERE idCliente LIKE @idCliente"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@idCliente", "%" & idCliente & "%")
            conn.Open()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(ds)
        Catch ex As Exception
            ' Manejar la excepción adecuadamente
        End Try
        Return ds
    End Function


End Class
