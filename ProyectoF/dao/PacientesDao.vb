Imports System.Data.SqlClient

Public Class PacientesDao
    Private strConn As String = My.Settings.cStrDBLosArcos

    Public Function AgregarRegistro(ByVal paciente As PacientesEntity) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "INSERT INTO Pacientes(nombrePaciente, sexoPaciente, fechaNac, peso, color, senPart, idCliente, idEspecie, idRaza) VALUES(@nombrePaciente, @sexoPaciente, @fechaNac, @peso, @color, @senPart, @idCliente, @idEspecie, @idRaza)"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@nombrePaciente", paciente.NombrePaciente)
            cmd.Parameters.AddWithValue("@sexoPaciente", paciente.SexoPaciente)
            cmd.Parameters.AddWithValue("@fechaNac", paciente.FechaNac)
            cmd.Parameters.AddWithValue("@peso", paciente.Peso)
            cmd.Parameters.AddWithValue("@color", paciente.Color)
            cmd.Parameters.AddWithValue("@senPart", paciente.SenPart)
            cmd.Parameters.AddWithValue("@idCliente", paciente.Cliente.IdCliente)
            cmd.Parameters.AddWithValue("@idEspecie", paciente.Especie.IdEspecie)
            cmd.Parameters.AddWithValue("@idRaza", paciente.Raza.IdRaza)
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

    Public Function MostrarRegistros() As DataSet
        Dim ds As New DataSet
        Try
            Dim tsql As String = "SELECT * FROM Pacientes"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error")
        End Try
        Return ds
    End Function

    Public Function MostrarRegistrosPacientesR() As DataSet
        Dim ds As New DataSet
        Try
            Dim tsql As String = "SELECT
                                        Pacientes.idCliente,
                                        Pacientes.idPaciente,
                                        Pacientes.nombrePaciente,
                                        Pacientes.fechaNac,
                                        Especies.nombreEspecie,
                                        Pacientes.sexoPaciente,
                                        Razas.nombreRaza,
                                        Pacientes.peso,
                                        Pacientes.color,
                                        Pacientes.senPart
                                        FROM
                                        ((Pacientes
                                        INNER JOIN Especies ON Pacientes.idEspecie = Especies.idEspecie)
                                        INNER JOIN Razas ON Pacientes.idRaza = Razas.idRaza)"

            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception
            Console.WriteLine("Error...")
        End Try
        Return ds
    End Function

    Public Function MostrarRegistrosPacientesM() As DataSet
        Dim ds As New DataSet
        Try
            Dim tsql As String = "SELECT Cliente.idCliente, Pacientes.idPaciente,Pacientes.nombrePaciente,
                                    Pacientes.fechaNac,
                                    Especies.nombreEspecie,
                                    Pacientes.sexoPaciente,
                                    Razas.nombreRaza,
                                    Pacientes.peso,
                                    Pacientes.color,
                                    Pacientes.senPart,
                                    Cliente.primerNombre,
                                    Cliente.primerApellido,
                                    Cliente.correoCliente,
                                    Cliente.telefonoCliente,
                                    Cliente.direccionCliente
                                    FROM
                                    (((Pacientes
                                    INNER JOIN Cliente ON Pacientes.idCliente = Cliente.idCliente)
                                    INNER JOIN Especies ON Pacientes.idEspecie = Especies.idEspecie)
                                    INNER JOIN Razas ON Pacientes.idRaza = Razas.idRaza)
"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception
            Console.WriteLine("Error...")
        End Try
        Return ds
    End Function

    Public Function MostrarSexo() As DataSet
        Dim ds As New DataSet
        Try
            Dim tsql As String = "SELECT sexoPaciente FROM Pacientes"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception
        End Try
        Return ds
    End Function

    'Public Function ObtenerRegistro(ByVal idPaciente As Integer) As RegistroServiciosEntity
    '    Dim paciente As New PacientesEntity()
    '    Try
    '        'MessageBox.Show("ID de registro de servicio: " & idRegServicio)
    '        Dim tsql As String = "SELECT * FROM Pacientes WHERE idPaciente = @idPaciente"
    '        Dim conn As New SqlConnection(strConn)
    '        Dim cmd As New SqlCommand(tsql, conn)
    '        cmd.Parameters.AddWithValue("@idPaciente", idPaciente)
    '        conn.Open()
    '        Dim reader As SqlDataReader = cmd.ExecuteReader()
    '        If reader.HasRows Then
    '            reader.Read()
    '            paciente.IdPaciente = reader.GetInt32(reader.GetOrdinal("idPaciente"))
    '            paciente.NombrePaciente = reader.GetDateTime(reader.GetOrdinal("fechaConsulta"))
    '            registroServicio.Cliente.IdCliente = reader.GetString(reader.GetOrdinal("idCliente"))
    '            registroServicio.Paciente.IdPaciente = reader.GetInt32(reader.GetOrdinal("idPaciente"))
    '            registroServicio.Servicio.IdServicio = reader.GetInt32(reader.GetOrdinal("idServicio"))
    '            registroServicio.Factura.IdFactura = reader.GetInt32(reader.GetOrdinal("idFactura"))
    '            ' Asigna los demás campos del objeto RegistroServiciosEntity de manera similar
    '        End If
    '        reader.Close()
    '        conn.Close()
    '    Catch ex As Exception
    '        registroServicio = Nothing
    '    End Try
    '    Return registroServicio
    'End Function

    Public Function EditarRegistro(ByVal paciente As PacientesEntity) As Boolean
        Try
            Dim tsql As String = "UPDATE Pacientes SET nombrePaciente = @nombrePaciente, sexoPaciente = @sexoPaciente, fechaNac = @fechaNac, peso = @peso, color = @color, senPart = @senPart, idCliente = @idCliente, idEspecie = @idEspecie, idRaza = @idRaza WHERE idPaciente = @idPaciente"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.Connection = conn
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@nombrePaciente", paciente.NombrePaciente)
            cmd.Parameters.AddWithValue("@sexoPaciente", paciente.SexoPaciente)
            cmd.Parameters.AddWithValue("@fechaNac", paciente.FechaNac)
            cmd.Parameters.AddWithValue("@peso", paciente.Peso)
            cmd.Parameters.AddWithValue("@color", paciente.Color)
            cmd.Parameters.AddWithValue("@senPart", paciente.SenPart)
            cmd.Parameters.AddWithValue("@idCliente", paciente.Cliente.IdCliente)
            cmd.Parameters.AddWithValue("@idEspecie", paciente.Especie.IdEspecie)
            cmd.Parameters.AddWithValue("@idRaza", paciente.Raza.IdRaza)
            cmd.Parameters.AddWithValue("@idPaciente", paciente.IdPaciente)
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
            Console.WriteLine("An error has ocurred")
        End Try
    End Function
    Public Function EliminarRegistro(ByVal idPaciente As Integer) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "DELETE FROM Pacientes WHERE idPaciente = @idPaciente"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@idPaciente", idPaciente)
            cmd.Connection = conn
            cmd.Connection.Open()
            If (cmd.ExecuteNonQuery <> 0) Then
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
