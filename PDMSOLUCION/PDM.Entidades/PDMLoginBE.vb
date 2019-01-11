Public Class PDMLoginBE
    Private _IdResponsable As Integer
    Private _Usuario As String
    Private _Contraseña As String
    Private _TipoUsuario As Integer
    Private _Estado As Integer

    Public Sub New()
        _IdResponsable = 0
        _Usuario = String.Empty
        _Contraseña = String.Empty
        _TipoUsuario = 0
        _Estado = 0
    End Sub

    Public Property idResponsable() As Integer
        Get
            Return _IdResponsable
        End Get
        Set(value As Integer)
            _IdResponsable = value
        End Set
    End Property

    Public Property Usuario() As String
        Get
            Return _Usuario
        End Get
        Set(value As String)
            _Usuario = value
        End Set
    End Property

    Public Property Contraseña() As String
        Get
            Return _Contraseña
        End Get
        Set(value As String)
            _Contraseña = value
        End Set
    End Property

    Public Property TipoUsuario() As Integer
        Get
            Return _TipoUsuario
        End Get
        Set(value As Integer)
            _TipoUsuario = value
        End Set
    End Property

    Public Property Estado() As Integer
        Get
            Return _Estado
        End Get
        Set(value As Integer)
            _Estado = value
        End Set
    End Property


End Class
