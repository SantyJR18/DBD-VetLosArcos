Public Class EmpresaEntity
    Private _idEmp As Integer
    Private _nombreEmp As String
    Private _direccionEmp As String
    Private _telEmp As String
    Private _rucEmp As String

    Public Property IdEmp As Integer
        Get
            Return _idEmp
        End Get
        Set(value As Integer)
            _idEmp = value
        End Set
    End Property

    Public Property NombreEmp As String
        Get
            Return _nombreEmp
        End Get
        Set(value As String)
            _nombreEmp = value
        End Set
    End Property

    Public Property DireccionEmp As String
        Get
            Return _direccionEmp
        End Get
        Set(value As String)
            _direccionEmp = value
        End Set
    End Property

    Public Property TelEmp As String
        Get
            Return _telEmp
        End Get
        Set(value As String)
            _telEmp = value
        End Set
    End Property

    Public Property RucEmp As String
        Get
            Return _rucEmp
        End Get
        Set(value As String)
            _rucEmp = value
        End Set
    End Property
End Class