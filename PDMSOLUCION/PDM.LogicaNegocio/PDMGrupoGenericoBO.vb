Imports PDM.AccesoDatos
Imports PDM.Entidades

Public Class PDMGrupoGenericoBO
    Private _PDMGrupoGenericoDAO As PDMGrupoGenericoDAO

    Public Sub New()
        _PDMGrupoGenericoDAO = New PDMGrupoGenericoDAO()
    End Sub

    Public Function InsertarGrupoGenerico(oPDMGrupoGenericoBE As PDMGrupoGenericoBE) As Boolean
        Return _PDMGrupoGenericoDAO.InsertarGrupoGenerico(oPDMGrupoGenericoBE)
    End Function

    Public Function ActualizarGrupoGenerico(oPDMGrupoGenericoBE As PDMGrupoGenericoBE) As Boolean
        Return _PDMGrupoGenericoDAO.ActualizarGrupoGenerico(oPDMGrupoGenericoBE)
    End Function

    Public Function ObtenerTableXGrupoGenerico(cadena As String) As DataTable
        Return _PDMGrupoGenericoDAO.ObtenerTableXGrupoGenerico(cadena)
    End Function

    Public Function TableGrupoGenerico() As DataTable
        Return _PDMGrupoGenericoDAO.TableGrupoGenerico()
    End Function

End Class
