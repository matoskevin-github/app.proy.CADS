Imports PDM.AccesoDatos
Imports PDM.Entidades

Public Class PDMAmbientesBO
    Private _PDMAmbientesDAO As PDMAmbientesDAO

    Public Sub New()
        _PDMAmbientesDAO = New PDMAmbientesDAO()
    End Sub

    Public Function InsertarAmbiente(oPDMAmbientesBE As PDMAmbientesBE) As Boolean
        Return _PDMAmbientesDAO.InsertarAmbiente(oPDMAmbientesBE)
    End Function

    Public Function ActualizarAmbiente(oPDMAmbientesBE As PDMAmbientesBE) As Boolean
        Return _PDMAmbientesDAO.ActualizarAmbiente(oPDMAmbientesBE)
    End Function

    Public Function ObtenerTableXAmbiente(cadena As String) As DataTable
        Return _PDMAmbientesDAO.ObtenerTableXAmbiente(cadena)
    End Function

    Public Function TableAmbientes() As DataTable
        Return _PDMAmbientesDAO.TableAmbientes()
    End Function

    Public Function ObtenerPabellones() As List(Of PDMPabellonBE)
        Return _PDMAmbientesDAO.ObtenerPabellones()
    End Function

    Public Function ObtenerPisos() As List(Of PDMPisosBE)
        Return _PDMAmbientesDAO.ObtenerPisos()
    End Function

End Class
