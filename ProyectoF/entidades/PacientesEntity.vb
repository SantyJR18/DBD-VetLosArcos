Public Class PacientesEntity

    Private _idPaciente As Integer
    Private _nombrePaciente As String
    Private _sexoPaciente As Boolean
    Private _fechaNac As DateTime
    Private _peso As Decimal
    Private _color As String
    Private _senPart As String
    Private _Cliente As New ClienteEntity
    Private _Especie As New EspeciesEntity
    Private _Raza As New RazasEntity

    Public Sub New()

    End Sub

    Public Sub New(idPaciente As Integer, nombrePaciente As String, sexoPaciente As Boolean, fechaNac As Date, peso As Decimal, color As String, senPart As String, cliente As ClienteEntity, especie As EspeciesEntity, raza As RazasEntity)
        _idPaciente = idPaciente
        _nombrePaciente = nombrePaciente
        _sexoPaciente = sexoPaciente
        _fechaNac = fechaNac
        _peso = peso
        _color = color
        _senPart = senPart
        _Cliente = cliente
        _Especie = especie
        _Raza = raza
    End Sub

    Public Property IdPaciente As Integer
        Get
            Return _idPaciente
        End Get
        Set(value As Integer)
            _idPaciente = value
        End Set
    End Property

    Public Property NombrePaciente As String
        Get
            Return _nombrePaciente
        End Get
        Set(value As String)
            _nombrePaciente = value
        End Set
    End Property

    Public Property SexoPaciente As Boolean
        Get
            Return _sexoPaciente
        End Get
        Set(value As Boolean)
            _sexoPaciente = value
        End Set
    End Property

    Public Property FechaNac As Date
        Get
            Return _fechaNac
        End Get
        Set(value As Date)
            _fechaNac = value
        End Set
    End Property

    Public Property Peso As Decimal
        Get
            Return _peso
        End Get
        Set(value As Decimal)
            _peso = value
        End Set
    End Property

    Public Property Color As String
        Get
            Return _color
        End Get
        Set(value As String)
            _color = value
        End Set
    End Property

    Public Property SenPart As String
        Get
            Return _senPart
        End Get
        Set(value As String)
            _senPart = value
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

    Public Property Especie As EspeciesEntity
        Get
            Return _Especie
        End Get
        Set(value As EspeciesEntity)
            _Especie = value
        End Set
    End Property

    Public Property Raza As RazasEntity
        Get
            Return _Raza
        End Get
        Set(value As RazasEntity)
            _Raza = value
        End Set
    End Property
End Class