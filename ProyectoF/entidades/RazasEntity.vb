Public Class RazasEntity

    Private _idRaza As Integer
    Private _nombreRaza As String
    Private _verificarEsp As Boolean

    Public Sub New()

    End Sub

    Public Sub New(idRaza As Integer, nombreRaza As String, verificarEsp As Boolean)
        _idRaza = idRaza
        _nombreRaza = nombreRaza
        _verificarEsp = verificarEsp
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

    Public Property VerificarEsp As Boolean
        Get
            Return _verificarEsp
        End Get
        Set(value As Boolean)
            _verificarEsp = value
        End Set
    End Property
End Class
