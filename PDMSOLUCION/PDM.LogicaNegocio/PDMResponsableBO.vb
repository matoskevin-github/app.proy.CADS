Imports PDM.AccesoDatos
Imports PDM.Entidades
Imports System.Windows.Forms

Public Class PDMResponsableBO
    Private _PDMResponsableDAO As PDMResponsableDAO

    Public Sub New()
        _PDMResponsableDAO = New PDMResponsableDAO()
    End Sub

    Public Function InsertarResonsable(oPDMResponsableBE As PDMResponsableBE) As Boolean
        Return _PDMResponsableDAO.InsertarResonsable(oPDMResponsableBE)
    End Function

    Public Function ActualizarResponsable(oPDMResponsableBE As PDMResponsableBE) As Boolean
        Return _PDMResponsableDAO.ActualizarResponsable(oPDMResponsableBE)
    End Function

    Public Function ObtenerTableXResponsable(cadena As String) As DataTable
        Return _PDMResponsableDAO.ObtenerTableXResponsable(cadena)
    End Function

    Public Function TableResponsable() As DataTable
        Return _PDMResponsableDAO.TableResponsable()
    End Function

    Public Function ObtenerCargo() As List(Of PDMCargoBE)
        Return _PDMResponsableDAO.ObtenerCargo()
    End Function

    Public Function ObtenerTableXLCargo(cadena As String) As DataTable
        Return _PDMResponsableDAO.ObtenerTableXLCargo(cadena)
    End Function

  

End Class
