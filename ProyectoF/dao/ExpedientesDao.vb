Imports System.Data.SqlClient

Public Class ExpedientesDao
    Private strConn As String = My.Settings.cStrDBLosArcos

    Public Function AgregarRegistros(ByVal expediente As ExpedientesEntity) As Boolean
        Dim resp As String = False
        Try
            Dim tsql = "INSERT INTO Expedientes(fechaCreacionExp, idPaciente) VALUES(@fechaCreacionExp, @idPaciente)"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@fechaCreacionExp", expediente.FechaCreacionExp)
            cmd.Parameters.AddWithValue("@idPaciente", expediente.Paciente.IdPaciente)
            cmd.Connection = conn
            cmd.Connection.Open()
            If cmd.ExecuteNonQuery <> 0 Then
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
            Dim tsql As String = "SELECT * FROM Expedientes"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception
            Console.WriteLine("An error has ocurred")
        End Try
        Return ds
    End Function

    Public Function EditarRegistro(ByVal expediente As ExpedientesEntity) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "UPDATE Expedientes SET fechaCreacionExp = @fechaCreacionExp, idPaciente = @idPaciente WHERE idExp = @idExp"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@fechaCreacionExp", expediente.FechaCreacionExp)
            cmd.Parameters.AddWithValue("@idPaciente", expediente.Paciente.IdPaciente)
            cmd.Parameters.AddWithValue("@idExp", expediente.IdExp)
            cmd.Connection = conn
            cmd.Connection.Open()
            If cmd.ExecuteNonQuery <> 0 Then
                resp = True
            End If
            cmd.Connection.Close()
        Catch ex As Exception
            resp = False
        End Try
        Return resp
    End Function

    Public Function EliminarRegistro(ByVal idExp As Integer) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "DELETE FROM Expedientes WHERE idExp = @idExp"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@idExp", idExp)
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
End Class
