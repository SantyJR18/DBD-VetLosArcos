Imports System.Data.SqlClient

Public Class RegistroVacunacionesDao
    Private strConn As String = My.Settings.cStrDBLosArcos

    Public Function AgregarRegistro(ByVal registroVacuna As RegistroVacunacionesEntity) As Boolean
        Dim resp As String = False
        Try
            Dim tsql As String = "INSERT INTO RegistroVacunaciones(fechaVacunacion, idExp, idVacuna) VALUES(@fechaVacunacion, idExp, idVacuna)"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@fechaVacunacion", registroVacuna.FechaVacunacion)
            cmd.Parameters.AddWithValue("@idExp", registroVacuna.Exp.IdExp)
            cmd.Parameters.AddWithValue("@idVacuna", registroVacuna.Vacuna.IdVacuna)
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
            Dim tsql As String = "SELECT * FROM RegistroVacunaciones"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception
            Console.WriteLine("An error has ocurred")
        End Try
        Return ds
    End Function

    Public Function EditarRegistro(ByVal registroVacuna As RegistroVacunacionesEntity) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "UPDATE Diagnosticos SET fechaVacunacion = @fechaVacunacion, idExp = @idExp, idVacuna = @idVacuna WHERE idVacunacion = @idVacunacion"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@fechaVacunacion", registroVacuna.FechaVacunacion)
            cmd.Parameters.AddWithValue("@idExp", registroVacuna.Exp.IdExp)
            cmd.Parameters.AddWithValue("@idVacuna", registroVacuna.Vacuna.IdVacuna)
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

    Public Function EliminarRegistros(ByVal idVacunacion As Integer) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "DELETE FROM Diagnosticos WHERE idVacunacion = @idVacunacion"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@idVacunacion", idVacunacion)
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
