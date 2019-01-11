Imports PDM.AccesoDatos
Imports PDM.Entidades

Public Class PDMCondicionBO
    Private _PDMCondicionDAO As PDMCondicionDAO

    Public Sub New()
        _PDMCondicionDAO = New PDMCondicionDAO()
    End Sub

    Public Function InsertarCondicion(oPDMCondicionBE As PDMCondicionBE) As Boolean
        Return _PDMCondicionDAO.InsertarCondicion(oPDMCondicionBE)
    End Function

    Public Function ActualizarCondicion(oPDMCondicionBE As PDMCondicionBE) As Boolean
        Return _PDMCondicionDAO.ActualizarCondicion(oPDMCondicionBE)
    End Function

    Public Function ObtenerTableXCondicion(cadena As String) As DataTable
        Return _PDMCondicionDAO.ObtenerTableXCondicion(cadena)
    End Function

    Public Function TableCondicion() As DataTable
        Return _PDMCondicionDAO.TableCondicion()
    End Function

End Class
