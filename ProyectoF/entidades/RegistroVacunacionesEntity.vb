Public Class RegistroVacunacionesEntity

    Private _idVacunacion As Integer
    Private _fechaVacunacion As DateTime
    Private _idExp As Integer
    Private _idVacuna As Integer

    Public Sub New()

    End Sub

    Public Sub New(idVacunacion As Integer, fechaVacunacion As Date, idExp As Integer, idVacuna As Integer)
        _idVacunacion = idVacunacion
        _fechaVacunacion = fechaVacunacion
        _idExp = idExp
        _idVacuna = idVacuna
    End Sub

    Public Property IdVacunacion As Integer
        Get
            Return _idVacunacion
        End Get
        Set(value As Integer)
            _idVacunacion = value
        End Set
    End Property

    Public Property FechaVacunacion As Date
        Get
            Return _fechaVacunacion
        End Get
        Set(value As Date)
            _fechaVacunacion = value
        End Set
    End Property

    Public Property IdExp As Integer
        Get
            Return _idExp
        End Get
        Set(value As Integer)
            _idExp = value
        End Set
    End Property

    Public Property IdVacuna As Integer
        Get
            Return _idVacuna
        End Get
        Set(value As Integer)
            _idVacuna = value
        End Set
    End Property
End Class