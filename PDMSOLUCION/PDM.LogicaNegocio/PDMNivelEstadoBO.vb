Imports PDM.AccesoDatos
Imports PDM.Entidades

Public Class PDMNivelEstadoBO
    Private _PDMNivelEstadoDAO As PDMNivelEstadoDAO

    Public Sub New()
        _PDMNivelEstadoDAO = New PDMNivelEstadoDAO()
    End Sub

    Public Function InsertarNivelEstado(oPDMNivelEstadoBE As PDMNivelEstadoBE) As Boolean
        Return _PDMNivelEstadoDAO.InsertarNivelEstado(oPDMNivelEstadoBE)
    End Function

    Public Function ActualizarNivelEstado(oPDMNivelEstadoBE As PDMNivelEstadoBE) As Boolean
        Return _PDMNivelEstadoDAO.ActualizarNivelEstado(oPDMNivelEstadoBE)
    End Function

    Public Function ObtenerTableXNivelEstado(cadena As String) As DataTable
        Return _PDMNivelEstadoDAO.ObtenerTableXNivelEstado(cadena)
    End Function

    Public Function TableNivelEstado() As DataTable
        Return _PDMNivelEstadoDAO.TableNivelEstado()
    End Function

End Class
