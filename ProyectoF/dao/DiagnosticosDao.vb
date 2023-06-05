Imports System.Data.SqlClient

Public Class DiagnosticosDao
    Private strConn As String = My.Settings.cStrDBLosArcos

    Public Function AgregarRegistro(ByVal diagnostico As DiagnosticosEntity) As Boolean
        Dim resp As String = False
        Try
            Dim tsql As String = "INSERT INTO Diagnosticos(descripcionDiag, fechaDiag, idExp) VALUES(@descripcionDiag, @fechaDiag, @idExp)"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@descripcionDiag", diagnostico.DescripcionDiag)
            cmd.Parameters.AddWithValue("@fechaDiag", diagnostico.FechaDiag)
            cmd.Parameters.AddWithValue("@idExp", diagnostico.Exp.IdExp)
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
            Dim tsql As String = "SELECT * FROM Diagnosticos"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception
            Console.WriteLine("An error has ocurred")
        End Try
        Return ds
    End Function

    Public Function EditarRegistro(ByVal diagnostico As DiagnosticosEntity) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "UPDATE Diagnosticos SET descripcionDiag = @descripcionDiag, fechaDiag = @fechaDiag, idExp = @idExp WHERE idDiag = @idDiag"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@descripcionDiag", diagnostico.DescripcionDiag)
            cmd.Parameters.AddWithValue("@fechaDiag", diagnostico.FechaDiag)
            cmd.Parameters.AddWithValue("@idExp", diagnostico.Exp.IdExp)
            cmd.Parameters.AddWithValue("@idDiag", diagnostico.IdDiag)
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

    Public Function EliminarRegistros(ByVal idDiagnostico As Integer) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "DELETE FROM Diagnosticos WHERE idDiag = @idDiag"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@idDiag", idDiagnostico)
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
