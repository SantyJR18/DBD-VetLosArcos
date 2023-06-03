Public Class EspeciesEntity

    Private _idEspecie As Integer
    Private _nombreEspecie As String

    Public Sub New()

    End Sub

    Public Sub New(idEspecie As Integer, nombreEspecie As String)
        _idEspecie = idEspecie
        _nombreEspecie = nombreEspecie
    End Sub

    Public Property IdEspecie As Integer
        Get
            Return _idEspecie
        End Get
        Set(value As Integer)
            _idEspecie = value
        End Set
    End Property

    Public Property NombreEspecie As String
        Get
            Return _nombreEspecie
        End Get
        Set(value As String)
            _nombreEspecie = value
        End Set
    End Property
End Class
