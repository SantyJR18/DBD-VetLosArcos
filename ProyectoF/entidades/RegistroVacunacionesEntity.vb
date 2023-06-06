Public Class RegistroVacunacionesEntity

    Private _idVacunacion As Integer
    Private _fechaVacunacion As DateTime
    Private _Vacuna As VacunasEntity
    Private _Paciente As PacientesEntity

    Public Sub New()

    End Sub

    Public Sub New(idVacunacion As Integer, fechaVacunacion As Date, vacuna As VacunasEntity, paciente As PacientesEntity)
        _idVacunacion = idVacunacion
        _fechaVacunacion = fechaVacunacion
        _Vacuna = vacuna
        _Paciente = paciente
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

    Public Property Vacuna As VacunasEntity
        Get
            Return _Vacuna
        End Get
        Set(value As VacunasEntity)
            _Vacuna = value
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