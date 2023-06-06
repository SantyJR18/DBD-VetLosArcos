Public Class RegistroDesparasitacionesEntity

    Private _idDesparasitacion As Integer
    Private _fechaDesparasitaciones As DateTime
    Private _Desparasitante As New DesparasitantesEntity
    Private _Paciente As PacientesEntity

    Public Sub New()

    End Sub

    Public Sub New(idDesparasitacion As Integer, fechaDesparasitaciones As Date, desparasitante As DesparasitantesEntity, paciente As PacientesEntity)
        _idDesparasitacion = idDesparasitacion
        _fechaDesparasitaciones = fechaDesparasitaciones
        _Desparasitante = desparasitante
        _Paciente = paciente
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

    Public Property Desparasitante As DesparasitantesEntity
        Get
            Return _Desparasitante
        End Get
        Set(value As DesparasitantesEntity)
            _Desparasitante = value
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
