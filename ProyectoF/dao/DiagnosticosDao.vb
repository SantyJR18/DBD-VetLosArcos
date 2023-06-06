Imports System.Data.SqlClient

Public Class DiagnosticosDao
    Private strConn As String = My.Settings.cStrDBLosArcos

    Public Function AgregarRegistro(ByVal diagnostico As DiagnosticosEntity) As Boolean
        Dim resp As String = False
        Try
            Dim tsql As String = "INSERT INTO Diagnosticos(descripcionDiag, fechaDiag, idPaciente) VALUES(@descripcionDiag, @fechaDiag, @idPaciente)"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@descripcionDiag", diagnostico.DescripcionDiag)
            cmd.Parameters.AddWithValue("@fechaDiag", diagnostico.FechaDiag)
            cmd.Parameters.AddWithValue("@idPaciente", diagnostico.Paciente)
            cmd.Connection = conn
            cmd.Connection.Open()
            If cmd.ExecuteNonQuery > 0 Then
                resp = True
            End If
        Catch ex As Exception
            resp = False
            Console.WriteLine("Ha ocurrido un error")
        End Try
        Return resp
    End Function

    Public Function MostrarRegistros() As DataSet
        Dim ds As New DataSet
        Try
            Dim tsql As String = "SELECT d.idDiag AS 'ID DIAGNOSTICO', d.descripcionDiag AS 'DESCRIPCION DIAGNOSTICO', d.fechaDiag AS 'FECHA DIAGNOSTICO', d.idPaciente AS 'ID PACIENTE',  
            p.nombrePaciente AS 'NOMBRE PACIENTE' FROM Diagnosticos d INNER JOIN Pacientes p ON d.idPaciente = p.idPaciente" ''"SELECT * FROM Diagnosticos"

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
            Dim tsql As String = "UPDATE Diagnosticos SET descripcionDiag = @descripcionDiag, fechaDiag = @fechaDiag, idPaciente = @idPaciente WHERE idDiag = @idDiag"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@descripcionDiag", diagnostico.DescripcionDiag)
            cmd.Parameters.AddWithValue("@fechaDiag", diagnostico.FechaDiag)
            cmd.Parameters.AddWithValue("@idPaciente", diagnostico.Paciente)
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

    Public Function ObtenerRegistro(ByVal idDiag As Integer) As DiagnosticosEntity
        Dim diagnostico As New DiagnosticosEntity()
        Try
            'MessageBox.Show("ID de registro de servicio: " & idRegServicio)
            Dim tsql As String = "SELECT * FROM Diagnosticos WHERE idDiag = @idDiag"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@idDiag", idDiag)
            conn.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                reader.Read()
                diagnostico.IdDiag = reader.GetInt32(reader.GetOrdinal("idDiag"))
                diagnostico.FechaDiag = reader.GetDateTime(reader.GetOrdinal("fechaDiag"))
                diagnostico.DescripcionDiag = reader.GetString(reader.GetOrdinal("descripcionDiag"))
                diagnostico.Paciente = reader.GetInt32(reader.GetOrdinal("idPaciente"))
                ' Asigna los demás campos del objeto RegistroServiciosEntity de manera similar
            End If
            reader.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("Instance crisis" & ex.Message)
            diagnostico = Nothing
        End Try
        Return diagnostico
    End Function

    Public Function ObtenerRegistroPorIdPaciente(ByVal idPaciente As Integer) As DataSet
        Dim ds As New DataSet()

        Try
            Dim tsql As String = "SELECT d.idDiag AS 'ID DIAGNOSTICO', d.descripcionDiag AS 'DESCRIPCION DIAGNOSTICO', d.fechaDiag AS 'FECHA DIAGNOSTICO', d.idPaciente AS 'ID PACIENTE',  
            p.nombrePaciente AS 'NOMBRE PACIENTE' FROM Diagnosticos d INNER JOIN Pacientes p ON d.idPaciente = p.idPaciente WHERE d.idPaciente = @idPaciente"

            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@idPaciente", idPaciente)
            conn.Open()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(ds)
        Catch ex As Exception
            ' Manejar la excepción adecuadamente
        End Try

        Return ds
    End Function


End Class
