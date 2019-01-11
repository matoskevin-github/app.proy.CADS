Imports PDM.AccesoDatos
Imports PDM.Entidades

Public Class PDMFormaAdquisicionBO
    Private _PDMFormaAdquisicionDAO As PDMFormaAdquisicionDAO

    Public Sub New()
        _PDMFormaAdquisicionDAO = New PDMFormaAdquisicionDAO()
    End Sub

    Public Function InsertarFormaAdquisicion(oPDMFormaAdquisicionBE As PDMFormaAdquisicionBE) As Boolean
        Return _PDMFormaAdquisicionDAO.InsertarFormaAdquisicion(oPDMFormaAdquisicionBE)
    End Function

    Public Function ActualizarFormaAdquisicion(oPDMFormaAdquisicionBE As PDMFormaAdquisicionBE) As Boolean
        Return _PDMFormaAdquisicionDAO.ActualizarFormaAdquisicion(oPDMFormaAdquisicionBE)
    End Function

    Public Function ObtenerTableXFormaAdquisicion(cadena As String) As DataTable
        Return _PDMFormaAdquisicionDAO.ObtenerTableXFormaAdquisicion(cadena)
    End Function

    Public Function TableFormaAdquisicion() As DataTable
        Return _PDMFormaAdquisicionDAO.TableFormaAdquisicion()
    End Function

End Class
