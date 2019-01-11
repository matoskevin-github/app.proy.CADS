Public Class frmIngresoArticulosPDM

    Private Sub btnGrupoGenerico_Click(sender As Object, e As EventArgs)
        frmGrupoGenericoPDM.Show()
    End Sub

    Private Sub btnTipoCaja_Click(sender As Object, e As EventArgs)
        frmIngresoCaja.Show()
    End Sub

    Private Sub btnAmbiente_Click(sender As Object, e As EventArgs)
        frmIngresarAmbientesPDM.Show()
    End Sub

    Private Sub btnCondicion_Click(sender As Object, e As EventArgs)
        frmCondicionAltayBaja.Show()
    End Sub

    Private Sub btnConservacion_Click(sender As Object, e As EventArgs)
        frmConservacion.Show()
    End Sub

    Private Sub btnNiveldeEstado_Click(sender As Object, e As EventArgs)
        frmNivelEstadoPDM.Show()
    End Sub

    Private Sub btnDocumento_Click(sender As Object, e As EventArgs)
        frmDocumentoPDM.Show()
    End Sub

    Private Sub btnFormaAdquisicion_Click(sender As Object, e As EventArgs)
        frmFormadeAdquisicion.Show()
    End Sub

End Class