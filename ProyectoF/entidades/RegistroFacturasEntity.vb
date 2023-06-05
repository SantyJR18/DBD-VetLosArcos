Public Class RegistroFacturasEntity

    Private _idFactura As Integer
    Private _Cliente As ClienteEntity

    Public Sub New()

    End Sub

    Public Sub New(idFactura As Integer, cliente As ClienteEntity)
        _idFactura = idFactura
        _Cliente = cliente
    End Sub

    Public Property IdFactura As Integer
        Get
            Return _idFactura
        End Get
        Set(value As Integer)
            _idFactura = value
        End Set
    End Property

    Public Property Cliente As ClienteEntity
        Get
            Return _Cliente
        End Get
        Set(value As ClienteEntity)
            _Cliente = value
        End Set
    End Property
End Class