Public Class DesparasitantesEntity

    Private _idDesparasitante As Integer
    Private _nombreDes As String
    Private _MarcaDes As New MarcasDesparasitantesEntity

    Public Sub New()
    End Sub

    Public Sub New(idDesparasitante As Integer, nombreDes As String, marcaDes As MarcasDesparasitantesEntity)
        _idDesparasitante = idDesparasitante
        _nombreDes = nombreDes
        _MarcaDes = marcaDes
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

    Public Property MarcaDes As MarcasDesparasitantesEntity
        Get
            Return _MarcaDes
        End Get
        Set(value As MarcasDesparasitantesEntity)
            _MarcaDes = value
        End Set
    End Property
End Class