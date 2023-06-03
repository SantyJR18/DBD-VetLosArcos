Public Class ExpedientesEntity

    Private _idExp As Integer
    Private _fechaCreacionExp As DateTime
    Private _idPaciente As Integer

    Public Sub New()

    End Sub

    Public Sub New(idExp As Integer, fechaCreacionExp As Date, idPaciente As Integer)
        _idExp = idExp
        _fechaCreacionExp = fechaCreacionExp
        _idPaciente = idPaciente
    End Sub

    Public Property IdExp As Integer
        Get
            Return _idExp
        End Get
        Set(value As Integer)
            _idExp = value
        End Set
    End Property

    Public Property FechaCreacionExp As Date
        Get
            Return _fechaCreacionExp
        End Get
        Set(value As Date)
            _fechaCreacionExp = value
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
End Class
