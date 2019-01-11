Imports PDM.AccesoDatos
Imports PDM.Entidades

Public Class PDMCargoBO
    Private _PDMCargoDAO As PDMCargoDAO

    Public Sub New()
        _PDMCargoDAO = New PDMCargoDAO()
    End Sub

    Public Function InsertarCargo(oPDMCargoBE As PDMCargoBE) As Boolean
        Return _PDMCargoDAO.InsertarCargo(oPDMCargoBE)
    End Function

    Public Function ActualizarCargo(oPDMCargoBE As PDMCargoBE) As Boolean
        Return _PDMCargoDAO.ActualizarCargo(oPDMCargoBE)
    End Function

    Public Function ObtenerCargo(cadena As String) As PDMCargoBE
        Return _PDMCargoDAO.ObtenerCargo(cadena)
    End Function

    Public Function ObtenerTableXCargo(cadena As String) As DataTable
        Return _PDMCargoDAO.ObtenerTableXCargo(cadena)
    End Function

    Public Function TableCargo() As DataTable
        Return _PDMCargoDAO.TableCargo()
    End Function
End Class
