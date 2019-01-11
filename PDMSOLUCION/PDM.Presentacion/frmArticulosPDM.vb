Public Class frmArticulosPDM

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        frmIngresoArticulosPDM.Show()
        frmIngresoArticulosPDM.btnGuardar.Visible = True
        frmIngresoArticulosPDM.btnEditar.Visible = False
        frmIngresoArticulosPDM.btnCancelar.Visible = True

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        ActivarBotones(False, False, True)
        LimpiarCajas()
        ActivarCajas(True, True)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ActivarBotones(True, True, False)
        ActivarCajas(False, False)
        LimpiarCajas()
    End Sub

    Private Sub frmArticulosPDM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActivarCajas(False, False)
        ActivarBotones(True, True, False)
    End Sub

#Region "Metodos de Formulario:frmArticulosPDM"
    Private Sub ActivarBotones(BolNuevo As Boolean, BolBuscar As Boolean, BolCancelar As Boolean)
        btnNuevo.Visible = BolNuevo
        btnBuscar.Visible = BolBuscar
        btnCancelar.Visible = BolCancelar
    End Sub

    Private Sub LimpiarCajas()
        'cboAmbiente.SelectedIndex = 0
        txtAmbiente.Text = String.Empty
    End Sub

    Private Sub ActivarCajas(BolCAmbiente As Boolean, BolAmbiente As Boolean)
        cboAmbiente.Enabled = BolCAmbiente
        txtAmbiente.Enabled = BolAmbiente
    End Sub
#End Region  
End Class