Imports PDM.AccesoDatos
Imports PDM.Entidades
Imports System.Windows.Forms

Public Class PDMAmbiente_ResponsableBO
    Private _PDMAmbientexResponsableDAO As PDMAmbiente_ResponsableDAO

    Public Sub New()
        _PDMAmbientexResponsableDAO = New PDMAmbiente_ResponsableDAO()
    End Sub

    Public Function InsertarAmbiente_Responsable(oPDMAmbientesxResponsableBE As PDMAmbiente_ResponsableBE) As Boolean
        Return _PDMAmbientexResponsableDAO.InsertarAmbiente_Responsable(oPDMAmbientesxResponsableBE)
    End Function

    Public Function ActualizarAmbiente_Responsable(oPDMAmbientesxResponsableBE As PDMAmbiente_ResponsableBE) As Boolean
        Return _PDMAmbientexResponsableDAO.ActualizarAmbiente_Responsable(oPDMAmbientesxResponsableBE)
    End Function

    Public Function TableAmbientes() As DataTable
        Return _PDMAmbientexResponsableDAO.TableAmbientes()
    End Function

    Public Function ObtenerTableXAmbiente(cadena As String) As DataTable
        Return _PDMAmbientexResponsableDAO.ObtenerTableXAmbiente(cadena)
    End Function

    Public Sub getCollectionResponsable(ByVal autoComplete As AutoCompleteStringCollection)
        _PDMAmbientexResponsableDAO.getCollectionResponsable(autoComplete)
    End Sub

    Public Function ObtenerResponsablexAmbiente(codigo As Integer) As DataTable
        Return _PDMAmbientexResponsableDAO.ObtenerResponsablexAmbiente(codigo)
    End Function

End Class
