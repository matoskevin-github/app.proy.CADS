Imports PDM.AccesoDatos
Imports PDM.Entidades

Public Class PDMDocumentoBO
    Private _PDMDocumentoDAO As PDMDocumentoDAO

    Public Sub New()
        _PDMDocumentoDAO = New PDMDocumentoDAO()
    End Sub

    Public Function InsertarDocumento(oPDMDocumentoBE As PDMDocumentoBE) As Boolean
        Return _PDMDocumentoDAO.InsertarDocumento(oPDMDocumentoBE)
    End Function

    Public Function ActualizarDocumento(oPDMDocumentoBE As PDMDocumentoBE) As Boolean
        Return _PDMDocumentoDAO.ActualizarDocumento(oPDMDocumentoBE)
    End Function

    Public Function ObtenerTableXDocumento(cadena As String) As DataTable
        Return _PDMDocumentoDAO.ObtenerTableXDocumento(cadena)
    End Function

    Public Function TableDocumento() As DataTable
        Return _PDMDocumentoDAO.TableDocumento()
    End Function

End Class
