Imports System.Data.SqlClient
Imports System.IO

Public Class RegistroVacunacionesDao
    Private strConn As String = My.Settings.cStrDBLosArcos

    Public Function AgregarRegistro(ByVal registroVacuna As RegistroVacunacionesEntity) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "INSERT INTO RegistroVacunaciones (idPaciente, idVacuna, fechaVacunacion) 
                                VALUES (@idPaciente, @idVacuna, @fechaVacunacion)"

            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@idPaciente", registroVacuna.Paciente.IdPaciente)
            cmd.Parameters.AddWithValue("@idVacuna", registroVacuna.Vacuna.IdVacuna)
            cmd.Parameters.AddWithValue("@fechaVacunacion", registroVacuna.FechaVacunacion)
            cmd.Connection = conn
            cmd.Connection.Open()
            If (cmd.ExecuteNonQuery <> 0) Then
                resp = True
            End If
        Catch ex As Exception
            resp = False
            Console.WriteLine("An error has ocurred")
        End Try
        Return resp
    End Function

    Public Function MostrarRegistros() As DataSet
        Dim ds As New DataSet
        Try
            Dim tsql As String = "SELECT * FROM RegistroVacunaciones"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception
            Console.WriteLine("An error has ocurred")
        End Try
        Return ds
    End Function

    Public Function MostrarRegistrosPacientes() As DataSet
        Dim ds As New DataSet
        Try
            Dim tsql As String = "SELECT Pacientes.idPaciente, Pacientes.nombrePaciente, Pacientes.fechaNac, Especies.nombreEspecie,
                                 Pacientes.sexoPaciente, Razas.nombreRaza, Pacientes.peso, Vacunas.nombreVacuna, MarcasVacunas.nombreMarcaVac,
                                 RegistroVacunaciones.fechaVacunacion 
                                 FROM (((((RegistroVacunaciones
                                 INNER JOIN Pacientes ON RegistroVacunaciones.idPaciente = Pacientes.idPaciente)
                                 INNER JOIN Especies ON Pacientes.idEspecie = Especies.idEspecie)
                                 INNER JOIN Razas ON Pacientes.idRaza = Razas.idRaza)
                                 INNER JOIN Vacunas ON RegistroVacunaciones.idVacuna = Vacunas.idVacuna)
                                 INNER JOIN MarcasVacunas ON Vacunas.idMarcaVac = MarcasVacunas.idMarcaVac)"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception
            Console.WriteLine("Error...")
        End Try
        Return ds
    End Function

    Public Function EditarRegistro(ByVal registroVacuna As RegistroVacunacionesEntity) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "UPDATE RegistroVacunaciones SET idPaciente = @idPaciente, idVacuna =  @idVacuna, 
                                    fechaVacunacion = @fechaVacunacion  WHERE idVacunacion = @idVacunacion"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@idPaciente", registroVacuna.Paciente.IdPaciente)
            cmd.Parameters.AddWithValue("@idVacuna", registroVacuna.Vacuna.IdVacuna)
            cmd.Parameters.AddWithValue("@fechaVacunacion", registroVacuna.FechaVacunacion)
            cmd.Parameters.AddWithValue("@idVacunacion", registroVacuna.IdVacunacion)
            cmd.Connection = conn
            cmd.Connection.Open()
            If (cmd.ExecuteNonQuery <> 0) Then
                resp = True
            End If
            cmd.Connection.Close()
        Catch ex As Exception
            resp = False
            Console.WriteLine(ex.Message)
        End Try
        Return resp
    End Function
End Class


