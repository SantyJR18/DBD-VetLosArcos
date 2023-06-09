﻿Public Class EmpleadosEntity

    Private _idEmpleado As Integer
    Private _usuario As String
    Private _contrasenia As String
    Private _primerNombreEmp As String
    Private _primerApellidoEmp As String
    Private _SegundoApellidoEmp As String
    Private _fechaContratacion As DateTime
    Private _segundoNombreEmp As String
    Private _Rol As New RolesEntity

    Public Sub New()

    End Sub

    Public Sub New(idEmpleado As Integer, usuario As String, contrasenia As String, primerNombreEmp As String, primerApellidoEmp As String, segundoApellidoEmp As String, fechaContratacion As Date, segundoNombreEmp As String, rol As RolesEntity)
        _idEmpleado = idEmpleado
        _usuario = usuario
        _contrasenia = contrasenia
        _primerNombreEmp = primerNombreEmp
        _primerApellidoEmp = primerApellidoEmp
        _SegundoApellidoEmp = segundoApellidoEmp
        _fechaContratacion = fechaContratacion
        _segundoNombreEmp = segundoNombreEmp
        _Rol = rol
    End Sub

    Public Property IdEmpleado As Integer
        Get
            Return _idEmpleado
        End Get
        Set(value As Integer)
            _idEmpleado = value
        End Set
    End Property

    Public Property Usuario As String
        Get
            Return _usuario
        End Get
        Set(value As String)
            _usuario = value
        End Set
    End Property

    Public Property Contrasenia As String
        Get
            Return _contrasenia
        End Get
        Set(value As String)
            _contrasenia = value
        End Set
    End Property

    Public Property PrimerNombreEmp As String
        Get
            Return _primerNombreEmp
        End Get
        Set(value As String)
            _primerNombreEmp = value
        End Set
    End Property

    Public Property PrimerApellidoEmp As String
        Get
            Return _primerApellidoEmp
        End Get
        Set(value As String)
            _primerApellidoEmp = value
        End Set
    End Property

    Public Property SegundoApellidoEmp As String
        Get
            Return _SegundoApellidoEmp
        End Get
        Set(value As String)
            _SegundoApellidoEmp = value
        End Set
    End Property

    Public Property FechaContratacion As Date
        Get
            Return _fechaContratacion
        End Get
        Set(value As Date)
            _fechaContratacion = value
        End Set
    End Property

    Public Property SegundoNombreEmp As String
        Get
            Return _segundoNombreEmp
        End Get
        Set(value As String)
            _segundoNombreEmp = value
        End Set
    End Property

    Public Property Rol As RolesEntity
        Get
            Return _Rol
        End Get
        Set(value As RolesEntity)
            _Rol = value
        End Set
    End Property
End Class