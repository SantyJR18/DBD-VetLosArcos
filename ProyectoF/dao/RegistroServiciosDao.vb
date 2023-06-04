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
            cmd.Parameters.AddWithValue("idCliente", registroServicio.Cliente.IdCliente)
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
            Dim tsql As String = "SELECT * FROM RegistroServicios"
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

            cmd.CommandText = "UPDATE RegistroServicios SET idRegServicio = @idRegServicio, fechaConsulta = @fechaConsulta, idCliente = @idCliente, idPaciente = @idPaciente, idServicio = @idServicio, idFactura = @idFactura WHERE idRegServicio = @idRegServicio"
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

    Public Function EliminarRegistro(ByVal registroServicio As String) As Boolean
        Dim success As Boolean = False
        Try
            Dim tsql As String = "DELETE FROM RegistroServicio WHERE idRegServicio = @idRegServicio"
            Using conn As New SqlConnection(cStrConn)
                Using cmd As New SqlCommand(tsql, conn)
                    cmd.Parameters.AddWithValue("@idRegServicio", registroServicio)
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
End Class
