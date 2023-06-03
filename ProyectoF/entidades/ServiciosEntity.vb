Public Class ServiciosEntity

    Private _idServicio As Integer
    Private _nombreServicio As String
    Private _costoServicio As Decimal

    Public Sub New()

    End Sub

    Public Sub New(idServicio As Integer, nombreServicio As String, costoServicio As Decimal)
        _idServicio = idServicio
        _nombreServicio = nombreServicio
        _costoServicio = costoServicio
    End Sub

    Public Property IdServicio As Integer
        Get
            Return _idServicio
        End Get
        Set(value As Integer)
            _idServicio = value
        End Set
    End Property

    Public Property NombreServicio As String
        Get
            Return _nombreServicio
        End Get
        Set(value As String)
            _nombreServicio = value
        End Set
    End Property

    Public Property CostoServicio As Decimal
        Get
            Return _costoServicio
        End Get
        Set(value As Decimal)
            _costoServicio = value
        End Set
    End Property
End Class