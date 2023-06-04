Imports System.Data.SqlClient

Public Class MarcasDesparacitantesDao
    Private strConn As String = My.Settings.cStrDBLosArcos

    Public Function AgregarRegistro(ByVal marcasDesparasitantes As MarcasDesparasitantesEntity) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "INSERT INTO MarcasDesparasitantes(nombreMarcaDes) VALUES(@nombreMarcaDes)"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@nombreMarcaDes", marcasDesparasitantes.NombreMarcaDes)
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

    Public Function EditarRegistro(ByVal marcasDesparasitantes As MarcasDesparasitantesEntity) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "UPDATE MarcasDesparasitantes SET nombreMarcaDes = @nombreMarcaDes "
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@nombreMarcaDes", marcasDesparasitantes.NombreMarcaDes)
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

    Public Function EliminarRegistro(ByVal idMarcaDes As Integer) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "DELETE FROM MarcasDesparasitantes WHERE idMarcaDes = @idMarcaDes"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@idMarcaDes", idMarcaDes)
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
            Dim tsql As String = "SELECT * FROM MarcasDesparasitantes"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception

        End Try
        Return ds
    End Function
End Class
