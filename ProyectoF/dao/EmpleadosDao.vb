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
            Dim tsql As String = "SELECT usuario AS USUARIO, primerNombreEmp AS 'PRIMER NOMBRE', segundoNombreEmp AS 'SEGUNDO NOMBRE', primerApellidoEmp AS 'PRIMER APELLIDO', SegundoApellidoEmp AS 'SEGUNDO APELLIDO', fechaContratacion AS 'FECHA CONTRATACIÓN', idRol AS 'ID ROL' FROM Empleados"
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

    Public Function EditarRegistro(ByVal empleado As EmpleadosEntity) As Boolean
        Try
            Dim conn As New SqlConnection(cStrConn)
            Dim cmd As New SqlCommand()
            cmd.Connection = conn
            cmd.CommandText = "UPDATE Empleados SET usuario = @usuario, contrasenia = @contrasenia, primerNombreEmp = @primerNombreEmp, segundoNombreEmp = @segundoNombreEmp, primerApellidoEmp = @primerApellidoEmp, SegundoApellidoEmp = @segundoApellidoEmp, fechaContratacion = @fechaContratacion, idRol = @idRol WHERE usuario = @usuario"
            cmd.Parameters.AddWithValue("@usuario", empleado.Usuario)
            cmd.Parameters.AddWithValue("@contrasenia", empleado.Contrasenia)
            cmd.Parameters.AddWithValue("@primerNombreEmp", empleado.PrimerNombreEmp)
            cmd.Parameters.AddWithValue("@segundoNombreEmp", empleado.SegundoNombreEmp)
            cmd.Parameters.AddWithValue("@primerApellidoEmp", empleado.PrimerApellidoEmp)
            cmd.Parameters.AddWithValue("@segundoApellidoEmp", empleado.SegundoApellidoEmp)
            cmd.Parameters.AddWithValue("@fechaContratacion", empleado.FechaContratacion)
            cmd.Parameters.AddWithValue("@idRol", empleado.Rol.IdRol)

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

    Public Function EliminarRegistro(ByVal usuario As String) As Boolean
        Dim success As Boolean = False
        Try
            Dim tsql As String = "DELETE FROM Empleados WHERE usuario = @usuario"
            Using conn As New SqlConnection(cStrConn)
                Using cmd As New SqlCommand(tsql, conn)
                    cmd.Parameters.AddWithValue("@usuario", usuario)
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

    Public Function ObtenerRegistro(ByVal usuario As String) As EmpleadosEntity
        Dim empleado As New EmpleadosEntity()
        Try
            Dim tsql As String = "SELECT * FROM Empleados WHERE usuario = @usuario"
            Dim conn As New SqlConnection(cStrConn)
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@usuario", usuario)
            conn.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                reader.Read()
                empleado.Usuario = reader.GetString(reader.GetOrdinal("usuario"))
                empleado.Contrasenia = reader.GetString(reader.GetOrdinal("contrasenia"))
                empleado.PrimerNombreEmp = reader.GetString(reader.GetOrdinal("primerNombreEmp"))
                empleado.SegundoNombreEmp = reader.GetString(reader.GetOrdinal("segundoNombreEmp"))
                empleado.PrimerApellidoEmp = reader.GetString(reader.GetOrdinal("primerApellidoEmp"))
                empleado.SegundoApellidoEmp = reader.GetString(reader.GetOrdinal("SegundoApellidoEmp"))
                empleado.FechaContratacion = reader.GetDateTime(reader.GetOrdinal("fechaContratacion"))
                empleado.Rol.IdRol = reader.GetInt32(reader.GetOrdinal("idRol"))
            End If
            reader.Close()
            conn.Close()
        Catch ex As Exception
            empleado = Nothing
        End Try
        Return empleado
    End Function

End Class