Public Class RegistroServiciosEntity

    Private _idRegServicio As Integer
    Private _fechaConsulta As DateTime
    Private _Cliente As New ClienteEntity
    Private _Paciente As New PacientesEntity
    Private _Servicio As New ServiciosEntity
    Private _Factura As New RegistroFacturasEntity

    Public Sub New()

    End Sub

    Public Sub New(idRegServicio As Integer, fechaConsulta As Date, cliente As ClienteEntity, paciente As PacientesEntity, servicio As ServiciosEntity, factura As RegistroFacturasEntity)
        _idRegServicio = idRegServicio
        _fechaConsulta = fechaConsulta
        _Cliente = cliente
        _Paciente = paciente
        _Servicio = servicio
        _Factura = factura
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

    Public Property Cliente As ClienteEntity
        Get
            Return _Cliente
        End Get
        Set(value As ClienteEntity)
            _Cliente = value
        End Set
    End Property

    Public Property Paciente As PacientesEntity
        Get
            Return _Paciente
        End Get
        Set(value As PacientesEntity)
            _Paciente = value
        End Set
    End Property

    Public Property Servicio As ServiciosEntity
        Get
            Return _Servicio
        End Get
        Set(value As ServiciosEntity)
            _Servicio = value
        End Set
    End Property

    Public Property Factura As RegistroFacturasEntity
        Get
            Return _Factura
        End Get
        Set(value As RegistroFacturasEntity)
            _Factura = value
        End Set
    End Property
End Class