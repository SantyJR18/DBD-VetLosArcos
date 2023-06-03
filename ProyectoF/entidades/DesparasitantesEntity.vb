Public Class DesparasitantesEntity

    Private _idDesparasitante As Integer
    Private _nombreDes As String
    Private _idMarcaDes As Integer

    Public Sub New()

    End Sub

    Public Property IdDesparasitante As Integer
        Get
            Return _idDesparasitante
        End Get
        Set(value As Integer)
            _idDesparasitante = value
        End Set
    End Property

    Public Property NombreDes As String
        Get
            Return _nombreDes
        End Get
        Set(value As String)
            _nombreDes = value
        End Set
    End Property

    Public Property IdMarcaDes As Integer
        Get
            Return _idMarcaDes
        End Get
        Set(value As Integer)
            _idMarcaDes = value
        End Set
    End Property
End Class