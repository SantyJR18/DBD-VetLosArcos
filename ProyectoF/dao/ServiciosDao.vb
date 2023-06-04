Imports System.Data.SqlClient

Public Class ServiciosDao
    Private cStrConn As String = My.Settings.cStrDBLosArcos

    Public Function AgregarRegistro(ByVal servicios As ServiciosEntity) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "INSERT INTO Servicios(nombreServicio, costoServicio) VALUES (@nombreServicio, @costoServicio)"
            Dim conn As New SqlConnection(cStrConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@nombreServicio", servicios.NombreServicio)
            cmd.Parameters.AddWithValue("@costoServicio", servicios.CostoServicio)
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
            Dim tsql As String = "SELECT * FROM Servicios"
            Dim conn As New SqlConnection(cStrConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception

        End Try
        Return ds
    End Function

    Public Function EditarRegistro(ByVal servicios As ServiciosEntity) As Boolean
        Try
            Dim conn As New SqlConnection(cStrConn)
            Dim cmd As New SqlCommand()
            cmd.Connection = conn

            cmd.CommandText = "UPDATE Servicios SET nombreServicio = @nombreServicio, costoServicio = @costoServicio WHERE nombreServicio = @nombreServicio"
            cmd.Parameters.AddWithValue("@nombreServicio", servicios.NombreServicio)
            cmd.Parameters.AddWithValue("@costoServicio", servicios.CostoServicio)

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
        End Try
    End Function

    Public Function EliminarRegistro(ByVal servicios As String) As Boolean
        Dim success As Boolean = False
        Try
            Dim tsql As String = "DELETE FROM Servicios WHERE nombreServicio = @nombreServicio"
            Using conn As New SqlConnection(cStrConn)
                Using cmd As New SqlCommand(tsql, conn)
                    cmd.Parameters.AddWithValue("@nombreEmp", servicios)
                    conn.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        success = True
                    End If
                End Using
            End Using
        Catch ex As Exception
            success = False
        End Try
        Return success
    End Function

End Class
