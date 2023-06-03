Public Class PacientesEntity
    Private _idPaciente As Integer
    Private _nombrePaciente As String
    Private _sexoPaciente As Boolean
    Private _fechaNac As DateTime
    Private _color As String
    Private _senPart As String
    Private _idCliente As String
    Private _idEspecie As Integer
    Private _idRaza As Integer

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

    Public Property IdCliente As String
        Get
            Return _idCliente
        End Get
        Set(value As String)
            _idCliente = value
        End Set
    End Property

    Public Property IdEspecie As Integer
        Get
            Return _idEspecie
        End Get
        Set(value As Integer)
            _idEspecie = value
        End Set
    End Property

    Public Property IdRaza As Integer
        Get
            Return _idRaza
        End Get
        Set(value As Integer)
            _idRaza = value
        End Set
    End Property
End Class