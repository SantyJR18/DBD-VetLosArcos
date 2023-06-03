Public Class RegistroDesparasitacionesEntity

    Private _idDesparasitacion As Integer
    Private _fechaDesparasitaciones As DateTime
    Private _idExp As Integer
    Private _idDesparasitante As Integer

    Public Sub New()

    End Sub

    Public Sub New(idDesparasitacion As Integer, fechaDesparasitaciones As Date, idExp As Integer, idDesparasitante As Integer)
        _idDesparasitacion = idDesparasitacion
        _fechaDesparasitaciones = fechaDesparasitaciones
        _idExp = idExp
        _idDesparasitante = idDesparasitante
    End Sub

    Public Property IdDesparasitacion As Integer
        Get
            Return _idDesparasitacion
        End Get
        Set(value As Integer)
            _idDesparasitacion = value
        End Set
    End Property

    Public Property FechaDesparasitaciones As Date
        Get
            Return _fechaDesparasitaciones
        End Get
        Set(value As Date)
            _fechaDesparasitaciones = value
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

    Public Property IdDesparasitante As Integer
        Get
            Return _idDesparasitante
        End Get
        Set(value As Integer)
            _idDesparasitante = value
        End Set
    End Property
End Class
