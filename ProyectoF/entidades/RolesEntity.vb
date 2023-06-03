Public Class RolesEntity

    Private _idRol As Integer
    Private _nombreRol As String
    Private _estado As Boolean

    Public Sub New()

    End Sub

    Public Property IdRol As Integer
        Get
            Return _idRol
        End Get
        Set(value As Integer)
            _idRol = value
        End Set
    End Property

    Public Property NombreRol As String
        Get
            Return _nombreRol
        End Get
        Set(value As String)
            _nombreRol = value
        End Set
    End Property

    Public Property Estado As Boolean
        Get
            Return _estado
        End Get
        Set(value As Boolean)
            _estado = value
        End Set
    End Property
End Class