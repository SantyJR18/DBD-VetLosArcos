Public Class RegistroServiciosEntity

    Private _idRegServicio As Integer
    Private _fechaConsulta As DateTime
    Private _idCliente As String
    Private _idPaciente As Integer
    Private _idServicio As Integer
    Private _idFactura As Integer

    Public Sub New()

    End Sub

    Public Sub New(idRegServicio As Integer, fechaConsulta As Date, idCliente As String, idPaciente As Integer, idServicio As Integer, idFactura As Integer)
        _idRegServicio = idRegServicio
        _fechaConsulta = fechaConsulta
        _idCliente = idCliente
        _idPaciente = idPaciente
        _idServicio = idServicio
        _idFactura = idFactura
    End Sub

    Public Property IdRegServicio As Integer
        Get
            Return _idRegServicio
        End Get
        Set(value As Integer)
            _idRegServicio = value
        End Set
    End Property

    Public Property FechaConsulta As Date
        Get
            Return _fechaConsulta
        End Get
        Set(value As Date)
            _fechaConsulta = value
        End Set
    End Property

    Public Property IdCliente As String
        Get
            Return _idCliente
        End Get
        Set(value As String)
            _idCliente = value
        End Set
    End Property

    Public Property IdPaciente As Integer
        Get
            Return _idPaciente
        End Get
        Set(value As Integer)
            _idPaciente = value
        End Set
    End Property

    Public Property IdServicio As Integer
        Get
            Return _idServicio
        End Get
        Set(value As Integer)
            _idServicio = value
        End Set
    End Property

    Public Property IdFactura As Integer
        Get
            Return _idFactura
        End Get
        Set(value As Integer)
            _idFactura = value
        End Set
    End Property
End Class