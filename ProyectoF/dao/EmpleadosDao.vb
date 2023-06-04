Imports System.Data.SqlClient

Public Class EmpleadosDao
    Private cStrConn As String = My.Settings.cStrDBLosArcos

    Public Function AgregarRegistro(ByVal empleado As EmpleadosEntity) As Boolean
        Dim resp As Boolean = False
        Try
            ''Dim tsql As String = "Insert into Materia(nombre) values(@nombre)''
            Dim tsql As String = "INSERT INTO Empleados(usuario, contrasenia, primerNombreEmp, segundoNombreEmp, primerApellidoEmp, SegundoApellidoEmp, fechaContratacion, idRol) VALUES (@usuario, @contrasenia, @primerNombreEmp, @segundoNombreEmp, @primerApellidoEmp, @SegundoApellidoEmp, @fechaContratacion, @idRol)"
            Dim conn As New SqlConnection(cStrConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@usuario", empleado.Usuario)
            cmd.Parameters.AddWithValue("@contrasenia", empleado.Contrasenia)
            cmd.Parameters.AddWithValue("@primerNombreEmp", empleado.PrimerNombreEmp)
            cmd.Parameters.AddWithValue("@segundoNombreEmp", empleado.SegundoNombreEmp)
            cmd.Parameters.AddWithValue("@primerApellidoEmp", empleado.PrimerApellidoEmp)
            cmd.Parameters.AddWithValue("@SegundoApellidoEmp", empleado.SegundoApellidoEmp)
            cmd.Parameters.AddWithValue("@fechaContratacion", empleado.FechaContratacion)
            cmd.Parameters.AddWithValue("@idRol", empleado.Rol.IdRol)
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
            Dim tsql As String = "Select * from Empleados"
            Dim conn As New SqlConnection(cStrConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception

        End Try
        Return ds
    End Function

    Public Function ValidarCredenciales(ByVal usuario As String, ByVal contrasenia As String) As Boolean
        Dim isValid As Boolean = False
        Try
            Dim tsql As String = "SELECT COUNT(*) FROM Empleados WHERE usuario = @usuario AND contrasenia = @contrasenia"
            Dim conn As New SqlConnection(cStrConn)
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@usuario", usuario)
            cmd.Parameters.AddWithValue("@contrasenia", contrasenia)
            conn.Open()

            Dim result As Integer = CInt(cmd.ExecuteScalar())
            If result > 0 Then
                isValid = True
            End If

            conn.Close()
        Catch ex As Exception
            ' Manejar adecuadamente la excepción
            Console.WriteLine("Error al validar las credenciales: " & ex.Message)
        End Try

        Return isValid
    End Function

    Public Function ObtenerRol(ByVal usuario As String) As String
        Dim rol As String = String.Empty
        Try
            Dim tsql As String = "SELECT idRol FROM Empleados WHERE usuario = @usuario"
            Dim conn As New SqlConnection(cStrConn)
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@usuario", usuario)
            conn.Open()

            Dim result As Object = cmd.ExecuteScalar()
            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                Dim idRol As Integer = CInt(result)

                ' Obtener el nombre del rol basado en el idRol
                Dim tsqlRol As String = "SELECT nombreRol FROM Roles WHERE idRol = @idRol"
                Dim cmdRol As New SqlCommand(tsqlRol, conn)
                cmdRol.Parameters.AddWithValue("@idRol", idRol)

                rol = CStr(cmdRol.ExecuteScalar())
            End If

            conn.Close()
        Catch ex As Exception
            ' Manejar adecuadamente la excepción
            Console.WriteLine("Error al obtener el rol: " & ex.Message)
        End Try

        Return rol
    End Function

End Class
