Imports System.Data.SqlClient

Public Class RegistroDesparasitacionesDao
    Dim strConn As String = My.Settings.cStrDBLosArcos

    Public Function AgregarRegistro(ByVal registroDesparasitaciones As RegistroDesparasitacionesEntity) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "INSERT INTO RegistroDesparasitaciones(idPaciente, idDesparasitante, fechaDesparasitacion )
                                    VALUES (@idPaciente , @idDesparasitante , @fechaDesparasitacion)"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@idPaciente", registroDesparasitaciones.Paciente.IdPaciente)
            cmd.Parameters.AddWithValue("@idDesparasitante", registroDesparasitaciones.Desparasitante.IdDesparasitante)
            cmd.Parameters.AddWithValue("@fechaDesparasitacion", registroDesparasitaciones.FechaDesparasitaciones)

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

    Public Function MostrarRegistrosPacientes() As DataSet
        Dim ds As New DataSet
        Try
            Dim tsql As String = "SELECT Pacientes.idPaciente, Pacientes.nombrePaciente, Pacientes.fechaNac, Especies.nombreEspecie,
                                 Pacientes.sexoPaciente, Razas.nombreRaza, Pacientes.peso, Desparasitantes.nombreDes, MarcasDesparasitantes.nombreMarcaDes,
                                 RegistroDesparasitaciones.fechaDesparasitacion 
                                 FROM (((((RegistroDesparasitaciones
                                 INNER JOIN Pacientes ON RegistroDesparasitaciones.idPaciente = Pacientes.idPaciente)
                                 INNER JOIN Especies ON Pacientes.idEspecie = Especies.idEspecie)
                                 INNER JOIN Razas ON Pacientes.idRaza = Razas.idRaza)
                                 INNER JOIN Desparasitantes ON RegistroDesparasitaciones.idDesparasitante = Desparasitantes.idDesparasitante)
                                 INNER JOIN MarcasDesparasitantes ON Desparasitantes.idMarcaDes = MarcasDesparasitantes.idMarcaDes)"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception
            Console.WriteLine("Error...")
        End Try
        Return ds
    End Function

    Public Function EditarRegistro(ByVal registroDesparasitaciones As RegistroDesparasitacionesEntity) As Boolean
        Try
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.Connection = conn

            cmd.CommandText = "UPDATE RegistroDesparasitaciones SET idPaciente = @idPaciente, idDesparasitante = @idDesparasitante, fechaDesparasitacion = @fechaDesparasitacion WHERE  idDesparasitacion = @idDesparasitacion"
            cmd.Parameters.AddWithValue("@idPaciente", registroDesparasitaciones.Paciente.IdPaciente)
            cmd.Parameters.AddWithValue("@idDesparasitante", registroDesparasitaciones.Desparasitante.IdDesparasitante)
            cmd.Parameters.AddWithValue("@fechaDesparasitacion", registroDesparasitaciones.FechaDesparasitaciones)
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
