Imports PDM.AccesoDatos
Imports PDM.Entidades

Public Class PDMPabellonBO
    Private _PDMPabellonDAO As PDMPabellonDAO

    Public Sub New()
        _PDMPabellonDAO = New PDMPabellonDAO()
    End Sub

    Public Function InsertarPabellon(oPDMPabellonBE As PDMPabellonBE) As Boolean
        Return _PDMPabellonDAO.InsertarPabellon(oPDMPabellonBE)
    End Function

    Public Function ActualizarPabellon(oPDMPabellonBE As PDMPabellonBE) As Boolean
        Return _PDMPabellonDAO.ActualizarPabellon(oPDMPabellonBE)
    End Function

    Public Function ObtenerPabellon(cadena As String) As PDMPabellonBE
        Return _PDMPabellonDAO.ObtenerPabellon(cadena)
    End Function

    Public Function ObtenerTableXPabellon(cadena As String) As DataTable
        Return _PDMPabellonDAO.ObtenerTableXPabellon(cadena)
    End Function

    Public Function TablePabellones() As DataTable
        Return _PDMPabellonDAO.TablePabellones
    End Function
End Class
