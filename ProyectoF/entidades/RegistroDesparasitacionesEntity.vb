Public Class RegistroDesparasitacionesEntity

    Private _idDesparasitacion As Integer
    Private _fechaDesparasitaciones As DateTime
    Private _Exp As New ExpedientesEntity
    Private _Desparasitante As New DesparasitantesEntity

    Public Sub New()

    End Sub

    Public Sub New(idDesparasitacion As Integer, fechaDesparasitaciones As Date, exp As ExpedientesEntity, desparasitante As DesparasitantesEntity)
        _idDesparasitacion = idDesparasitacion
        _fechaDesparasitaciones = fechaDesparasitaciones
        _Exp = exp
        _Desparasitante = desparasitante
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

    Public Property Exp As ExpedientesEntity
        Get
            Return _Exp
        End Get
        Set(value As ExpedientesEntity)
            _Exp = value
        End Set
    End Property

    Public Property Desparasitante As DesparasitantesEntity
        Get
            Return _Desparasitante
        End Get
        Set(value As DesparasitantesEntity)
            _Desparasitante = value
        End Set
    End Property
End Class
