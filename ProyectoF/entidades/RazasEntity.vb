Public Class RazasEntity

    Private _idRaza As Integer
    Private _nombreRaza As String

    Public Sub New()

    End Sub

    Public Sub New(idRaza As Integer, nombreRaza As String)
        _idRaza = idRaza
        _nombreRaza = nombreRaza
    End Sub

    Public Property IdRaza As Integer
        Get
            Return _idRaza
        End Get
        Set(value As Integer)
            _idRaza = value
        End Set
    End Property

    Public Property NombreRaza As String
        Get
            Return _nombreRaza
        End Get
        Set(value As String)
            _nombreRaza = value
        End Set
    End Property
End Class
