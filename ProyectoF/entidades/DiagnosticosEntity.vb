Public Class DiagnosticosEntity

    Private _idDiag As Integer
    Private _descripcionDiag As String
    Private _fechaDiag As DateTime
    Private _Paciente As Integer

    Public Sub New()

    End Sub

    Public Sub New(idDiag As Integer, descripcionDiag As String, fechaDiag As Date, paciente As Integer)
        _idDiag = idDiag
        _descripcionDiag = descripcionDiag
        _fechaDiag = fechaDiag
        _Paciente = paciente
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

    Public Property Paciente As Integer
        Get
            Return _Paciente
        End Get
        Set(value As Integer)
            _Paciente = value
        End Set
    End Property
End Class