Imports PDM.AccesoDatos
Imports PDM.Entidades

Public Class PDMEntidadBO

    Private _PDMEntidadDAO As PDMEntidadDAO

    Public Sub New()
        _PDMEntidadDAO = New PDMEntidadDAO()
    End Sub

    Public Function InsertarEntidad(oPDMEntidadBE As PDMEntidadBE) As Boolean
        Return _PDMEntidadDAO.InsertarEntidad(oPDMEntidadBE)
    End Function

    Public Function ActualizarEntidad(oPDMEntidadBE As PDMEntidadBE) As Boolean
        Return _PDMEntidadDAO.ActualizarEntidad(oPDMEntidadBE)
    End Function

    Public Function ObtenerTableXEntidad(cadena As String) As DataTable
        Return _PDMEntidadDAO.ObtenerTableXEntidad(cadena)
    End Function

    Public Function ObtenerEntidad(cadena As String) As PDMEntidadBE
        Return _PDMEntidadDAO.ObtenerEntidad(cadena)
    End Function

    'Public Function ListaEntidades() As List(Of PDMEntidadBE)
    '    Return _PDMEntidadDAO.ListaEntidades()
    'End Function

    Public Function TableEntidades() As DataTable
        Return _PDMEntidadDAO.TableEntidades()
    End Function

End Class
