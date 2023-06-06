Imports System.Data.SqlClient

Public Class RolesDao

    Private cStrConn As String = My.Settings.cStrDBLosArcos
    Public Function AgregarRegistro(ByVal rol As RolesEntity) As Boolean

        Dim resp As Boolean = False
        Try
            ''Dim tsql As String = "Insert into Roles(nombre) values(@nombre)''
            Dim tsql As String = "INSERT INTO Roles(nombreRol, estadoRol) VALUES (@nombreRol, @estadoRol)"
            Dim conn As New SqlConnection(cStrConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@nombreRol", rol.NombreRol)
            cmd.Parameters.AddWithValue("@estadoRol", rol.Estado)
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
            Dim tsql As String = "Select * from Roles"
            Dim conn As New SqlConnection(cStrConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception

        End Try
        Return ds
    End Function

End Class
