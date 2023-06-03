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
            cmd.Parameters.AddWithValue("@idRol", empleado.IdRol)
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
End Class
