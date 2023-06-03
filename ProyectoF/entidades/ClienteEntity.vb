Public Class ClienteEntity

    Private _idCliente As String
    Private _primerNombre As String
    Private segundoNombre As String
    Private primerApellido As String
    Private segundoApellido As String
    Private direccionCliente As String
    Private correoCliente As String
    Private telefonoCliente As String

    Public Property IdCliente As String
        Get
            Return _idCliente
        End Get
        Set(value As String)
            _idCliente = value
        End Set
    End Property

    Public Property PrimerNombre As String
        Get
            Return _primerNombre
        End Get
        Set(value As String)
            _primerNombre = value
        End Set
    End Property

    Public Property SegundoNombre1 As String
        Get
            Return segundoNombre
        End Get
        Set(value As String)
            segundoNombre = value
        End Set
    End Property

    Public Property PrimerApellido1 As String
        Get
            Return primerApellido
        End Get
        Set(value As String)
            primerApellido = value
        End Set
    End Property

    Public Property SegundoApellido1 As String
        Get
            Return segundoApellido
        End Get
        Set(value As String)
            segundoApellido = value
        End Set
    End Property

    Public Property DireccionCliente1 As String
        Get
            Return direccionCliente
        End Get
        Set(value As String)
            direccionCliente = value
        End Set
    End Property

    Public Property CorreoCliente1 As String
        Get
            Return correoCliente
        End Get
        Set(value As String)
            correoCliente = value
        End Set
    End Property

    Public Property TelefonoCliente1 As String
        Get
            Return telefonoCliente
        End Get
        Set(value As String)
            telefonoCliente = value
        End Set
    End Property
End Class