Imports System.Data.SqlClient

Public Class RegistroDesparasitacionesDao
    Dim strConn As String = My.Settings.cStrDBLosArcos

    Public Function AgregarRegistro(ByVal registroDesparasitaciones As RegistroDesparasitacionesEntity) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "INSERT INTO RegistroDesparasitaciones(fechaDesparasitacion, idPaciente, idDesparasitante) VALUES (@fechaDesparasitacion, @idPaciente, @idDesparasitante)"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@fechaDesparasitacion", registroDesparasitaciones.FechaDesparasitaciones)
            cmd.Parameters.AddWithValue("@idPaciente", registroDesparasitaciones.Paciente.IdPaciente)
            cmd.Parameters.AddWithValue("@idDesparasitante", registroDesparasitaciones.Desparasitante.IdDesparasitante)
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
            Dim tsql As String = "SELECT * FROM RegistroDesparasitaciones"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception

        End Try
        Return ds
    End Function

    Public Function EditarRegistro(ByVal registroDesparasitaciones As RegistroDesparasitacionesEntity) As Boolean
        Try
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.Connection = conn

            cmd.CommandText = "UPDATE RegistroDesparasitaciones SET fechaDesparasitacion = @fechaDesparasitacion, idPaciente = @idPaciente, idDesparasitante = @idDesparasitante WHERE  idDesparasitacion = @idDesparasitacion"
            cmd.Parameters.AddWithValue("@fechaDesparasitacion", registroDesparasitaciones.FechaDesparasitaciones)
            cmd.Parameters.AddWithValue("@idPaciente", registroDesparasitaciones.Paciente.IdPaciente)
            cmd.Parameters.AddWithValue("@idDesparasitante", registroDesparasitaciones.Desparasitante.IdDesparasitante)
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

    Public Function EliminarRegistro(ByVal idDesparasitacion As Integer) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "DELETE FROM Desparasitantes WHERE idDesparasitacion = @idDesparasitacion"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@idDesparasitacion", idDesparasitacion)
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
End Class
