Public Class ClienteEntity

    Private _idCliente As String
    Private _primerNombre As String
    Private _segundoNombre As String
    Private _primerApellido As String
    Private _segundoApellido As String
    Private _direccionCliente As String
    Private _correoCliente As String
    Private _telefonoCliente As String

    Public Sub New()

    End Sub

    Public Sub New(idCliente As String, primerNombre As String, segundoNombre As String, primerApellido As String, segundoApellido As String, direccionCliente As String, correoCliente As String, telefonoCliente As String)
        _idCliente = idCliente
        _primerNombre = primerNombre
        _segundoNombre = segundoNombre
        _primerApellido = primerApellido
        _segundoApellido = segundoApellido
        _direccionCliente = direccionCliente
        _correoCliente = correoCliente
        _telefonoCliente = telefonoCliente
    End Sub

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

    Public Property SegundoNombre As String
        Get
            Return _segundoNombre
        End Get
        Set(value As String)
            _segundoNombre = value
        End Set
    End Property

    Public Property PrimerApellido As String
        Get
            Return _primerApellido
        End Get
        Set(value As String)
            _primerApellido = value
        End Set
    End Property

    Public Property SegundoApellido As String
        Get
            Return _segundoApellido
        End Get
        Set(value As String)
            _segundoApellido = value
        End Set
    End Property

    Public Property DireccionCliente As String
        Get
            Return _direccionCliente
        End Get
        Set(value As String)
            _direccionCliente = value
        End Set
    End Property

    Public Property CorreoCliente As String
        Get
            Return _correoCliente
        End Get
        Set(value As String)
            _correoCliente = value
        End Set
    End Property

    Public Property TelefonoCliente As String
        Get
            Return _telefonoCliente
        End Get
        Set(value As String)
            _telefonoCliente = value
        End Set
    End Property
End Class