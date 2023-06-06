Imports System.Data.SqlClient

Public Class MarcasVacunasDao
    Private strConn As String = My.Settings.cStrDBLosArcos

    Public Function AgregarRegistro(ByVal marcasVacunas As MarcasVacunasEntity) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "INSERT INTO MarcasVacunas(nombreMarcaVac) VALUES(@nombreMarcaVac)"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@nombreMarcaVac", marcasVacunas.NombreMarcaVac)
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

    Public Function EditarRegistro(ByVal marcasVacunas As MarcasVacunasEntity) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "UPDATE MarcasVacunas SET nombreMarcaVac = @nombreMarcaVac WHERE idMarcaVac = @idMarcaVac"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@nombreMarcaVac", marcasVacunas.NombreMarcaVac)
            cmd.Parameters.AddWithValue("@idMarcaVac", marcasVacunas.IdMarcaVac)
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

    Public Function EliminarRegistro(ByVal idMarcaVac As Integer) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "DELETE FROM MarcasVacunas WHERE idMarcaVac = @idMarcaVac"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@idMarcaVac", idMarcaVac)
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
            Dim tsql As String = "SELECT * FROM MarcasVacunas"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception

        End Try
        Return ds
    End Function

    Public Function MostrarMarcasVacunas() As DataSet
        Dim ds As New DataSet
        Try
            Dim tsql As String = "SELECT nombreMarcaVac FROM MarcasVacunas "
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception

        End Try
        Return ds
    End Function


End Class
