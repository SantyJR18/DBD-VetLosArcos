Public Class ExpedientesEntity

    Private _idExp As Integer
    Private _fechaCreacionExp As DateTime
    Private _Paciente As PacientesEntity

    Public Sub New()

    End Sub

    Public Sub New(idExp As Integer, fechaCreacionExp As Date, paciente As PacientesEntity)
        _idExp = idExp
        _fechaCreacionExp = fechaCreacionExp
        _Paciente = paciente
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

    Public Property Paciente As PacientesEntity
        Get
            Return _Paciente
        End Get
        Set(value As PacientesEntity)
            _Paciente = value
        End Set
    End Property
End Class
