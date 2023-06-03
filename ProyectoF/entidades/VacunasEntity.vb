Public Class VacunasEntity

    Private _idVacuna As Integer
    Private _nombreVacuna As String
    Private _idMarcaVac As Integer

    Public Sub New()

    End Sub

    Public Sub New(idVacuna As Integer, nombreVacuna As String, idMarcaVac As Integer)
        _idVacuna = idVacuna
        _nombreVacuna = nombreVacuna
        _idMarcaVac = idMarcaVac
    End Sub

    Public Property IdVacuna As Integer
        Get
            Return _idVacuna
        End Get
        Set(value As Integer)
            _idVacuna = value
        End Set
    End Property

    Public Property NombreVacuna As String
        Get
            Return _nombreVacuna
        End Get
        Set(value As String)
            _nombreVacuna = value
        End Set
    End Property

    Public Property IdMarcaVac As Integer
        Get
            Return _idMarcaVac
        End Get
        Set(value As Integer)
            _idMarcaVac = value
        End Set
    End Property
End Class