Public Class DiagnosticosEntity

    Private _idDiag As Integer
    Private _descripcionDiag As String
    Private _fechaDiag As DateTime
    Private _idExp As Integer

    Public Sub New()

    End Sub

    Public Property IdDiag As Integer
        Get
            Return _idDiag
        End Get
        Set(value As Integer)
            _idDiag = value
        End Set
    End Property

    Public Property DescripcionDiag As String
        Get
            Return _descripcionDiag
        End Get
        Set(value As String)
            _descripcionDiag = value
        End Set
    End Property

    Public Property FechaDiag As Date
        Get
            Return _fechaDiag
        End Get
        Set(value As Date)
            _fechaDiag = value
        End Set
    End Property

    Public Property IdExp As Integer
        Get
            Return _idExp
        End Get
        Set(value As Integer)
            _idExp = value
        End Set
    End Property
End Class