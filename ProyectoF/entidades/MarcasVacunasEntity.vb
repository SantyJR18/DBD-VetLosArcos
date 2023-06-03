Public Class MarcasVacunasEntity

    Private _idMarcaVac As Integer
    Private _nombreMarcaVac As String

    Public Sub New()

    End Sub
    Public Sub New(idMarcaVac As Integer, nombreMarcaVac As String)
        _idMarcaVac = idMarcaVac
        _nombreMarcaVac = nombreMarcaVac
    End Sub

    Public Property IdMarcaVac As Integer
        Get
            Return _idMarcaVac
        End Get
        Set(value As Integer)
            _idMarcaVac = value
        End Set
    End Property

    Public Property NombreMarcaVac As String
        Get
            Return _nombreMarcaVac
        End Get
        Set(value As String)
            _nombreMarcaVac = value
        End Set
    End Property
End Class