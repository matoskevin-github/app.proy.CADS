Imports PDM.AccesoDatos
Imports PDM.Entidades

Public Class PDMLoginBO
    Private _LoginDao As PDMLoginDAO

    Public Sub New()
        _LoginDao = New PDMLoginDAO()
    End Sub

    Public Function AccesoUsuario(loginBE As PDMLoginBE) As Boolean
        Return _LoginDao.AccesoUsuario(loginBE)
    End Function

    Public Function ObtenerInfoUsuario(Usuario As String) As PDMResponsableBE
        Return _LoginDao.ObtenerInfoUsuario(Usuario)
    End Function
End Class
