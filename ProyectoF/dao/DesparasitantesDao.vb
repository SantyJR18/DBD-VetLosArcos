Imports System.Data.SqlClient

Public Class DesparasitantesDao
    Dim strConn As String = My.Settings.cStrDBLosArcos

    Public Function AgregarRegistros(ByVal desparasitante As DesparasitantesEntity) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "INSERT INTO Desparasitantes(nombreDes, idMarcaDes) VALUES (@nombreDes, @idMarcaDes)"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@nombreDes", desparasitante.NombreDes)
            cmd.Parameters.AddWithValue("@idMarcaDes", desparasitante.IdMarcaDes)
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

    Public Function EditarRegistro(ByVal desparasitante As DesparasitantesEntity) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "UPDATE Desparasitantes SET nombreDes = @nombreDes, idMarcaDes = @idMarcaDes"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@nombreDes", desparasitante.NombreDes)
            cmd.Parameters.AddWithValue("@idMarcaDes", desparasitante.IdMarcaDes)
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

    Public Function EliminarRegistro(ByVal idDesparasitante As Integer) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "DELETE FROM Desparasitantes WHERE idDesparasitante = @idDesparasitante"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@idDesparasitante", idDesparasitante)
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

    Public Function MostrarRegistro()
        Dim ds As DataSet
        Try
            Dim tsql As String = "SELECT * FROM Desparasitantes"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception

        End Try
        Return ds
    End Function
End Class
