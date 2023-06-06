Public Class VacunasEntity

    Private _idVacuna As Integer
    Private _nombreVacuna As String
    Private _MarcaVac As New MarcasVacunasEntity

    Public Sub New()

    End Sub

    Public Sub New(idVacuna As Integer, nombreVacuna As String, marcaVac As MarcasVacunasEntity)
        _idVacuna = idVacuna
        _nombreVacuna = nombreVacuna
        _MarcaVac = marcaVac
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

    Public Property MarcaVac As MarcasVacunasEntity
        Get
            Return _MarcaVac
        End Get
        Set(value As MarcasVacunasEntity)
            _MarcaVac = value
        End Set
    End Property
End Class