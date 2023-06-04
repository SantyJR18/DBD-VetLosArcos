Public Class RegistroVacunacionesEntity

    Private _idVacunacion As Integer
    Private _fechaVacunacion As DateTime
    Private _Exp As ExpedientesEntity
    Private _Vacuna As VacunasEntity

    Public Sub New()

    End Sub

    Public Sub New(idVacunacion As Integer, fechaVacunacion As Date, exp As ExpedientesEntity, vacuna As VacunasEntity)
        _idVacunacion = idVacunacion
        _fechaVacunacion = fechaVacunacion
        _Exp = exp
        _Vacuna = vacuna
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

    Public Property Exp As ExpedientesEntity
        Get
            Return _Exp
        End Get
        Set(value As ExpedientesEntity)
            _Exp = value
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
End Class