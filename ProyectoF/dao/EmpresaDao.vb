Imports System.Data.SqlClient

Public Class EmpresaDao
    Private cStrConn As String = My.Settings.cStrDBLosArcos

    Public Function AgregarRegistro(ByVal empresa As EmpresaEntity) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "INSERT INTO Empresa(nombreEmp, direccionEmp, telEmp, rucEmp) VALUES (@nombreEmp, @direccionEmp, @telEmp, @rucEmp)"
            Dim conn As New SqlConnection(cStrConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@nombreEmp", empresa.NombreEmp)
            cmd.Parameters.AddWithValue("@direccionEmp", empresa.DireccionEmp)
            cmd.Parameters.AddWithValue("@telEmp", empresa.TelEmp)
            cmd.Parameters.AddWithValue("@rucEmp", empresa.RucEmp)
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
            Dim tsql As String = "SELECT * FROM Empresa"
            Dim conn As New SqlConnection(cStrConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception

        End Try
        Return ds
    End Function

    Public Function EditarRegistro(ByVal empresa As EmpresaEntity) As Boolean
        Try
            Dim conn As New SqlConnection(cStrConn)
            Dim cmd As New SqlCommand()
            cmd.Connection = conn

            cmd.CommandText = "UPDATE Empresa SET nombreEmp = @nombreEmp, direccionEmp = @direccionEmp, telEmp = @telEmp, rucEmp = @rucEmp WHERE nombreEmp = @nombreEmp"
            cmd.Parameters.AddWithValue("@nombreEmp", empresa.NombreEmp)
            cmd.Parameters.AddWithValue("@direccionEmp", empresa.DireccionEmp)
            cmd.Parameters.AddWithValue("@telEmp", empresa.TelEmp)
            cmd.Parameters.AddWithValue("@rucEmp", empresa.RucEmp)

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

    Public Function EliminarRegistro(ByVal empresa As String) As Boolean
        Dim success As Boolean = False
        Try
            Dim tsql As String = "DELETE FROM Empresa WHERE nombreEmp = @nombreEmp"
            Using conn As New SqlConnection(cStrConn)
                Using cmd As New SqlCommand(tsql, conn)
                    cmd.Parameters.AddWithValue("@nombreEmp", empresa)
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
