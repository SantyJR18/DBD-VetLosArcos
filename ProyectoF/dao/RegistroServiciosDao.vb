Imports System.Data.SqlClient

Public Class RegistroServiciosDao
    Private cStrConn As String = My.Settings.cStrDBLosArcos

    Public Function AgregarRegistro(ByVal registroServicio As RegistroServiciosEntity) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "INSERT INTO RegistroServicios(fechaConsulta, idCliente, idPaciente, idServicio, idFactura) VALUES (@fechaConsulta, @idCliente, @idPaciente, @idServicio, @idFactura)"
            Dim conn As New SqlConnection(cStrConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@fechaConsulta", registroServicio.FechaConsulta)
            cmd.Parameters.AddWithValue("@idCliente", registroServicio.Cliente.IdCliente)
            cmd.Parameters.AddWithValue("@idPaciente", registroServicio.Paciente.IdPaciente)
            cmd.Parameters.AddWithValue("@idServicio", registroServicio.Servicio.IdServicio)
            cmd.Parameters.AddWithValue("@idFactura", registroServicio.Factura.IdFactura)
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
            Dim tsql As String = "SELECT idRegServicio AS 'ID REGISTRO', fechaConsulta AS 'FECHA CONSULTA', idCliente AS 'ID CLIENTE', idPaciente AS 'ID PACIENTE', idServicio AS 'ID SERVICIO', idFactura AS 'ID FACTURA' FROM RegistroServicios"
            Dim conn As New SqlConnection(cStrConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception

        End Try
        Return ds
    End Function

    Public Function EditarRegistro(ByVal registroServicio As RegistroServiciosEntity) As Boolean
        Try
            Dim conn As New SqlConnection(cStrConn)
            Dim cmd As New SqlCommand()
            cmd.Connection = conn

            cmd.CommandText = "UPDATE RegistroServicios SET fechaConsulta = @fechaConsulta, idCliente = @idCliente, idPaciente = @idPaciente, idServicio = @idServicio, idFactura = @idFactura WHERE idRegServicio = @idRegServicio"
            cmd.Parameters.AddWithValue("@idRegServicio", registroServicio.IdRegServicio)
            cmd.Parameters.AddWithValue("@fechaConsulta", registroServicio.FechaConsulta)
            cmd.Parameters.AddWithValue("@idCliente", registroServicio.Cliente.IdCliente)
            cmd.Parameters.AddWithValue("@idPaciente", registroServicio.Paciente.IdPaciente)
            cmd.Parameters.AddWithValue("@idServicio", registroServicio.Servicio.IdServicio)
            cmd.Parameters.AddWithValue("@idFactura", registroServicio.Factura.IdFactura)
            conn.Open()
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            conn.Close()

            If rowsAffected > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function



    Public Function EliminarRegistro(ByVal idRegServicio As String) As Boolean
        Dim success As Boolean = False
        Try
            Dim tsql As String = "DELETE FROM RegistroServicios WHERE idRegServicio = @idRegServicio"
            Using conn As New SqlConnection(cStrConn)
                Using cmd As New SqlCommand(tsql, conn)
                    cmd.Parameters.AddWithValue("@idRegServicio", idRegServicio)
                    conn.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        success = True
                    End If
                End Using
            End Using
        Catch ex As Exception
            success = False
        End Try
        Return success
    End Function

    Public Function ObtenerRegistro(ByVal idRegServicio As Integer) As RegistroServiciosEntity
        Dim registroServicio As New RegistroServiciosEntity()
        Try
            'MessageBox.Show("ID de registro de servicio: " & idRegServicio)
            Dim tsql As String = "SELECT * FROM RegistroServicios WHERE idRegServicio = @idRegServicio"
            Dim conn As New SqlConnection(cStrConn)
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@idRegServicio", idRegServicio)
            conn.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                reader.Read()
                registroServicio.IdRegServicio = reader.GetInt32(reader.GetOrdinal("idRegServicio"))
                registroServicio.FechaConsulta = reader.GetDateTime(reader.GetOrdinal("fechaConsulta"))
                registroServicio.Cliente.IdCliente = reader.GetString(reader.GetOrdinal("idCliente"))
                registroServicio.Paciente.IdPaciente = reader.GetInt32(reader.GetOrdinal("idPaciente"))
                registroServicio.Servicio.IdServicio = reader.GetInt32(reader.GetOrdinal("idServicio"))
                registroServicio.Factura.IdFactura = reader.GetInt32(reader.GetOrdinal("idFactura"))
                ' Asigna los demás campos del objeto RegistroServiciosEntity de manera similar
            End If
            reader.Close()
            conn.Close()
        Catch ex As Exception
            registroServicio = Nothing
        End Try
        Return registroServicio
    End Function

    Public Function BuscarRegistroPorIdCliente(ByVal idCliente As String) As DataSet
        Dim ds As New DataSet()
        Try
            Dim tsql As String = "SELECT idRegServicio AS 'ID REGISTRO', fechaConsulta AS 'FECHA CONSULTA', idCliente AS 'ID CLIENTE', idPaciente AS 'ID PACIENTE', idServicio AS 'ID SERVICIO', idFactura AS 'ID FACTURA' FROM RegistroServicios WHERE idCliente LIKE @idCliente"
            Dim conn As New SqlConnection(cStrConn)
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