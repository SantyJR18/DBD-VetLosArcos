Imports System.Data.SqlClient

Public Class PacientesDao
    Private strConn As String = My.Settings.cStrDBLosArcos

    Public Function AgregarRegistro(ByVal paciente As PacientesEntity) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "INSERT INTO Pacientes(nombrePaciente, sexoPaciente, fechaNac, color, senPart, idCliente, idEspecie, idRaza) VALUES(@nombrePaciente, @sexoPaciente, @fechaNac, @color, @senPart, @idCliente, @idEspecie, @idRaza)"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@nombrePaciente", paciente.NombrePaciente)
            cmd.Parameters.AddWithValue("@sexoPaciente", paciente.SexoPaciente)
            cmd.Parameters.AddWithValue("@fechaNac", paciente.FechaNac)
            cmd.Parameters.AddWithValue("@color", paciente.Color)
            cmd.Parameters.AddWithValue("@senPart", paciente.SenPart)
            cmd.Parameters.AddWithValue("@idCliente", paciente.Cliente.IdCliente)
            cmd.Parameters.AddWithValue("@idEspecie", paciente.Especie.IdEspecie)
            cmd.Parameters.AddWithValue("@idRaza", paciente.Raza.IdRaza)
            cmd.Connection = conn
            cmd.Connection.Open()
            If cmd.ExecuteNonQuery <> 0 Then
                resp = True
            End If
            cmd.Connection.Close()
        Catch ex As Exception
            resp = False
            Console.WriteLine("An error has ocurred")
        End Try
        Return resp
    End Function

    Public Function MostrarRegistros() As DataSet
        Dim ds As New DataSet
        Try
            Dim tsql As String = "SELECT * FROM Pacientes"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception

        End Try
        Return ds
    End Function

    Public Function EditarRegistro(ByVal paciente As PacientesEntity) As Boolean
        Try
            Dim tsql As String = "UPDATE Pacientes SET nombrePaciente = @nombrePaciente, sexoPaciente = @sexoPaciente, fechaNac = @fechaNac, color = @color, senPart = @senPart, idCliente = @idCliente, idEspecie = @idEspecie, idRaza = @idRaza"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.Connection = conn
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@nombrePaciente", paciente.NombrePaciente)
            cmd.Parameters.AddWithValue("@sexoPaciente", paciente.SexoPaciente)
            cmd.Parameters.AddWithValue("@fechaNac", paciente.FechaNac)
            cmd.Parameters.AddWithValue("@color", paciente.Color)
            cmd.Parameters.AddWithValue("@senPart", paciente.SenPart)
            cmd.Parameters.AddWithValue("@idCliente", paciente.Cliente.IdCliente)
            cmd.Parameters.AddWithValue("@idEspecie", paciente.Especie.IdEspecie)
            cmd.Parameters.AddWithValue("@idRaza", paciente.Raza.IdRaza)
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
            Console.WriteLine("An error has ocurred")
        End Try
    End Function
    Public Function EliminarRegistro(ByVal idPaciente As Integer) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "DELETE FROM Pacientes WHERE idPaciente = @idPaciente"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@idPaciente", idPaciente)
            cmd.Connection = conn
            cmd.Connection.Open()
            If (cmd.ExecuteNonQuery <> 0) Then
                resp = True
            End If
            cmd.Connection.Close()
        Catch ex As Exception
            resp = False
            Console.WriteLine("An error has ocurred")
        End Try
        Return resp
    End Function
End Class
