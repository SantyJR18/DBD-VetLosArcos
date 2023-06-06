Imports System.Data.SqlClient

Public Class EspecieDao
    Private strConn As String = My.Settings.cStrDBLosArcos

    Public Function AgregarRegistro(ByVal especie As EspeciesEntity) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "INSERT INTO Especies(nombreEspecie) VALUES(@nombreEspecie)"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@nombreEspecie", especie.NombreEspecie)
            cmd.Connection = conn
            cmd.Connection.Open()
            If cmd.ExecuteNonQuery <> 0 Then
                resp = True
            End If
        Catch ex As Exception
            resp = False
        End Try
        Return resp
    End Function

    Public Function EditarRegistro(ByVal especie As EspeciesEntity) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "UPDATE Especies SET nombreEspecie = @nombreEspecie WHERE idEspecie = @idEspecie"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@nombreEspecie", especie.NombreEspecie)
            cmd.Parameters.AddWithValue("@idEspecie", especie.IdEspecie)
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
            Dim tsql As String = "SELECT * FROM Especies"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception
            Console.WriteLine("An error has ocurred")
        End Try
        Return ds
    End Function


    Public Function MostrarNombre() As DataSet
        Dim ds As New DataSet
        Try
            Dim tsql As String = "SELECT nombreEspecie FROM Especies"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception
            Console.WriteLine("An error has ocurred")
        End Try
        Return ds
    End Function

    Public Function EliminarRegistro(ByVal idEspecie As Integer) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "DELETE FROM Especies WHERE idEspecie = @idEspecie"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@nombreEspecie", idEspecie)
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
