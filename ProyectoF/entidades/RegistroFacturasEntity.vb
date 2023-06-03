Public Class RegistroFacturasEntity

    Private _idFactura As Integer
    Private _idCliente As String

    Public Sub New()

    End Sub

    Public Sub New(idFactura As Integer, idCliente As String)
        _idFactura = idFactura
        _idCliente = idCliente
    End Sub

    Public Property IdFactura As Integer
        Get
            Return _idFactura
        End Get
        Set(value As Integer)
            _idFactura = value
        End Set
    End Property

    Public Property IdCliente As String
        Get
            Return _idCliente
        End Get
        Set(value As String)
            _idCliente = value
        End Set
    End Property
End Class