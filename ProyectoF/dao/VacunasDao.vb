Imports System.Data.SqlClient

Public Class VacunasDao
    Private strConn As String = My.Settings.cStrDBLosArcos

    Public Function AgregarRegistros(ByVal vacunas As VacunasEntity) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "INSERT INTO Vacunas(nombreVacuna, idMarcaVac) VALUES(@nombreVacuna, @idMarcaVac)"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@nombreVacuna", vacunas.NombreVacuna)
            cmd.Parameters.AddWithValue("@idMarcaVac", vacunas.MarcaVac.IdMarcaVac)
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


    Public Function EditarRegistro(ByVal vacuna As VacunasEntity) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "UPDATE Vacunas SET nombreVacuna = @nombreVacuna, idMarcaVac = @idMarcaVac"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@nombreVacuna", vacuna.NombreVacuna)
            cmd.Parameters.AddWithValue("@idMarcaVac", vacuna.MarcaVac.IdMarcaVac)
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

    Public Function EliminarRegistro(ByVal idVacuna As Integer) As Boolean
        Dim resp As Boolean = True
        Try
            Dim tsql As String = "DELETE FROM Vacunas WHERE idVacuna = @idVacuna"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@idVacuna", idVacuna)
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
            Dim tsql As String = "SELECT * FROM Vacunas"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception

        End Try
        Return ds
    End Function
End Class
