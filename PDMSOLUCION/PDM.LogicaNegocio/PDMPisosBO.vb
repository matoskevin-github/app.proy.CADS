Imports PDM.AccesoDatos
Imports PDM.Entidades

Public Class PDMPisosBO
    Private _PDMPisosDAO As PDMPisosDAO

    Public Sub New()
        _PDMPisosDAO = New PDMPisosDAO()
    End Sub

    Public Function InsertarPisos(oPDMPisosBE As PDMPisosBE) As Boolean
        Return _PDMPisosDAO.InsertarPisos(oPDMPisosBE)
    End Function

    Public Function ActualizarPisos(oPDMPisosBE As PDMPisosBE) As Boolean
        Return _PDMPisosDAO.ActualizarPisos(oPDMPisosBE)
    End Function

    Public Function ObtenerTableXPisos(cadena As String) As DataTable
        Return _PDMPisosDAO.ObtenerTableXPisos(cadena)
    End Function

    Public Function TablePisos() As DataTable
        Return _PDMPisosDAO.TablePisos()
    End Function

End Class
