Imports PDM.AccesoDatos
Imports PDM.Entidades

Public Class PDMConservacionBO
    Private _PDMConservacionDAO As PDMConservacionDAO

    Public Sub New()
        _PDMConservacionDAO = New PDMConservacionDAO()
    End Sub

    Public Function InsertarConservacion(oPDMConservacionBE As PDMConservacionBE) As Boolean
        Return _PDMConservacionDAO.InsertarConservacion(oPDMConservacionBE)
    End Function

    Public Function ActualizarConservacion(oPDMConservacionBE As PDMConservacionBE) As Boolean
        Return _PDMConservacionDAO.ActualizarConservacion(oPDMConservacionBE)
    End Function

    Public Function ObtenerTableXConservacion(cadena As String) As DataTable
        Return _PDMConservacionDAO.ObtenerTableXConservacion(cadena)
    End Function

    Public Function TableConservacion() As DataTable
        Return _PDMConservacionDAO.TableConservacion()
    End Function
End Class
