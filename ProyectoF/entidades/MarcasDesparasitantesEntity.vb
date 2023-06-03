Public Class MarcasDesparasitantesEntity

    Private _idMarcaDes As Integer
    Private _nombreMarcaDes As String

    Public Sub New()

    End Sub

    Public Sub New(idMarcaDes As Integer, nombreMarcaDes As String)
        _idMarcaDes = idMarcaDes
        _nombreMarcaDes = nombreMarcaDes
    End Sub

    Public Property IdMarcaDes As Integer
        Get
            Return _idMarcaDes
        End Get
        Set(value As Integer)
            _idMarcaDes = value
        End Set
    End Property

    Public Property NombreMarcaDes As String
        Get
            Return _nombreMarcaDes
        End Get
        Set(value As String)
            _nombreMarcaDes = value
        End Set
    End Property
End Class
