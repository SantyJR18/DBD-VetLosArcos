Imports System.Data.SqlClient

Public Class RegistroFacturasDao
    Private strConn As String = My.Settings.cStrDBLosArcos

    Public Function AgregarRegistro(ByVal registroFactura As RegistroFacturasEntity) As Boolean
        Dim resp As String = False
        Try
            Dim tsql As String = "INSERT INTO RegistroFacturas(idCliente) VALUES(@idCliente)"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@idCliente", registroFactura.Cliente.IdCliente)
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
            Dim tsql As String = "SELECT * FROM RegistroFacturas"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception
            Console.WriteLine("An error has ocurred")
        End Try
        Return ds
    End Function

    Public Function EditarRegistro(ByVal registroFactura As RegistroFacturasEntity) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "UPDATE RegistroFacturas SET idCliente = @idCliente WHERE idFactura = @idFactura"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@idCliente", registroFactura.Cliente.IdCliente)
            cmd.Parameters.AddWithValue("@idFactura", registroFactura.IdFactura)
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

    Public Function EliminarRegistros(ByVal idRegistroFactura As Integer) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "DELETE FROM RegistroFacturas WHERE idFactura = @idFactura"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@idFactura", idRegistroFactura)
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
