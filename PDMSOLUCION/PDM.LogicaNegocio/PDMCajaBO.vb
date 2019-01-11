Imports PDM.AccesoDatos
Imports PDM.Entidades

Public Class PDMCajaBO
    Private _PDMCajaDAO As PDMCajaDAO

    Public Sub New()
        _PDMCajaDAO = New PDMCajaDAO()
    End Sub

    Public Function InsertarCaja(oPDMCajaBE As PDMCajaBE) As Boolean
        Return _PDMCajaDAO.InsertarCaja(oPDMCajaBE)
    End Function

    Public Function ActualizarCaja(oPDMCajaBE As PDMCajaBE) As Boolean
        Return _PDMCajaDAO.ActualizarCaja(oPDMCajaBE)
    End Function

    Public Function ObtenerTableXCaja(cadena As String) As DataTable
        Return _PDMCajaDAO.ObtenerTableXCaja(cadena)
    End Function

    Public Function TableCaja() As DataTable
        Return _PDMCajaDAO.TableCaja()
    End Function

End Class
