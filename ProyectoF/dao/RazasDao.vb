Imports System.Data.SqlClient

Public Class RazasDao
    Private strConn As String = My.Settings.cStrDBLosArcos

    Public Function AgregarRegistro(ByVal raza As RazasEntity) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "INSERT INTO Razas(nombreRaza, verificarEsp) VALUES(@nombreRaza, @verificarEsp)"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@nombreRaza", raza.NombreRaza)
            cmd.Parameters.AddWithValue("@verificarEsp", raza.VerificarEsp)
            cmd.Connection = conn
            cmd.Connection.Open()
            If cmd.ExecuteNonQuery() <> 0 Then
                resp = True
            End If
        Catch ex As Exception
            resp = False
        End Try
        Return resp
    End Function

    Public Function MostrarRegistros() As DataSet
        Dim ds As New DataSet
        Try
            Dim tsql As String = "SELECT * FROM Razas"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception
            Console.WriteLine("Ha ocurrido un error al consultar los registros")
        End Try
        Return ds
    End Function

    Public Function EliminarRegistro(ByVal idRaza As Integer) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "DELETE FROM Razas WHERE idRaza = @idRaza"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@idRaza", idRaza)
            cmd.Connection = conn
            cmd.Connection.Open()
            If cmd.ExecuteNonQuery() <> 0 Then
                resp = True
            End If
            cmd.Connection.Close()
        Catch ex As Exception
            resp = False
        End Try
        Return resp
    End Function

    Public Function EditarRegistro(ByVal raza As RazasEntity) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "UPDATE Razas SET nombreRaza = @nombreRaza, verificarEsp = @verificarEsp WHERE idRaza = @idRaza"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@nombreRaza", raza.NombreRaza)
            cmd.Parameters.AddWithValue("@verificarEsp", raza.VerificarEsp)
            cmd.Parameters.AddWithValue("@idRaza", raza.IdRaza)
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
End Class
