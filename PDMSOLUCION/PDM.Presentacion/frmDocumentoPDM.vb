Imports PDM.LogicaNegocio
Imports PDM.Entidades

Public Class frmDocumentoPDM
    Private idDocumento As String
    Private encontrado As Integer = 0

#Region "Eventos de Formulario:frmDocumentoPDM"

    Private Sub CargarTablaDocumento()
        Dim oPDMDocumentoBO As New PDMDocumentoBO()
        dgvDocumento.DataSource = oPDMDocumentoBO.TableDocumento
        dgvDocumento.AutoResizeColumns()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        AcivarCajas(True, False)
        LimpiarCajas()
        txtDetalle.Focus()
        ActivarBotones(False, True, False, False, True, False)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        GuardarDocumento()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        EditarDocumento()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        AcivarCajas(False, False)
        LimpiarCajas()
        ActivarBotones(False, False, True, False, True, True)
        txtBuscar.Focus()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        AcivarCajas(False, False)
        LimpiarCajas()
        ActivarBotones(True, False, False, True, False, False)
        CargarTablaDocumento()
        chkActivar.Checked = True
    End Sub

    Private Sub frmDocumentoPDM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AcivarCajas(False, False)
        LimpiarCajas()
        ActivarBotones(True, False, False, True, False, False)
        chkActivar.Checked = True
        CargarTablaDocumento()
    End Sub

    Private Sub dgvDocumento_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDocumento.CellClick
        If (btnEditar.Visible) Then
            Dim index As Integer = e.RowIndex
            If index < 0 Then
                Return
            Else
                Dim selectedRow As DataGridViewRow = dgvDocumento.Rows(index)
                idDocumento = Convert.ToInt32(selectedRow.Cells(0).Value.ToString())
                txtDetalle.Text = Convert.ToString(selectedRow.Cells(1).Value.ToString())

                If Convert.ToString(selectedRow.Cells(2).Value) = "ACTIVO" Then
                    chkActivar.Checked = True
                Else
                    chkActivar.Checked = False
                End If
                txtBuscar.Text = String.Empty
                AcivarCajas(True, True)
                txtDetalle.Focus()
                'CargarTablaEntidad()
            End If
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If (btnEditar.Visible) Then
            If (encontrado = 0) Then
                If txtBuscar.Text.Length >= 0 Then
                    Dim oPDMDocumentoBO As New PDMDocumentoBO()
                    dgvDocumento.DataSource = oPDMDocumentoBO.ObtenerTableXDocumento(txtBuscar.Text.Trim)
                    'encontrado = dtgListarEntidad.RowCount
                End If
            Else
                If (txtBuscar.Text = String.Empty) Then
                    CargarTablaDocumento()
                    encontrado = 0
                End If
            End If
        End If
    End Sub

    Private Sub txtDetalle_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDetalle.KeyPress
        If (btnGuardar.Visible) Then
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                GuardarDocumento()
            End If
        ElseIf btnEditar.Visible Then
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                EditarDocumento()
            End If
        End If
    End Sub

    Public Sub GuardarDocumento()
        Dim oPDMDocumentoBO As New PDMDocumentoBO()
        Dim oPDMDocumentoBE As New PDMDocumentoBE
        oPDMDocumentoBE.idLogin = SessionUsuario.idUsuario
        oPDMDocumentoBE.Detalle = txtDetalle.Text.Trim
        oPDMDocumentoBE.FechaIngreso = DateTime.Now
        oPDMDocumentoBE.FechaModificacion = DateTime.Now
        chkActivar.Checked = True
        If (chkActivar.Checked) Then
            oPDMDocumentoBE.Estado = 1
        End If

        If txtDetalle.Text = String.Empty Then
            MessageBox.Show("DEBE INGRESAR DETALLE", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtDetalle.Focus()
        Else
            If MessageBox.Show("DESEA REGISTRAR ESTE DOCUMENTO", "INFORMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Dim boolGuardar As Boolean = oPDMDocumentoBO.InsertarDocumento(oPDMDocumentoBE)
                MessageBox.Show("DOCUMENTO REGISTRADO CORRECTAMENTE", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarTablaDocumento()
                AcivarCajas(False, False)
                LimpiarCajas()
                ActivarBotones(True, False, False, True, False, False)
            Else
                Return
            End If
        End If
    End Sub

    Public Sub EditarDocumento()
        Dim oPDMDocumentoBO As New PDMDocumentoBO()
        Dim oPDMDocumentoBE As New PDMDocumentoBE
        oPDMDocumentoBE.idDocumento = idDocumento
        oPDMDocumentoBE.idLogin = SessionUsuario.idUsuario
        oPDMDocumentoBE.Detalle = txtDetalle.Text.Trim
        oPDMDocumentoBE.FechaModificacion = DateTime.Now
        If (chkActivar.Checked) Then
            oPDMDocumentoBE.Estado = 1
        Else
            oPDMDocumentoBE.Estado = 0
        End If

        If txtDetalle.Text = String.Empty Or idDocumento = "" Then
            MessageBox.Show("DEBE SELECCIONAR UN DOCUMENTO DE LA LISTA", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtDetalle.Focus()
        Else
            If MessageBox.Show("DESEA ACTUALIZAR ESTE DOCUMENTO", "INFORMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Dim boolGuardar As Boolean = oPDMDocumentoBO.ActualizarDocumento(oPDMDocumentoBE)
                MessageBox.Show("DOCUMENTO ACTUALIZADO CORRECTAMENTE", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarTablaDocumento()
                AcivarCajas(False, False)
                LimpiarCajas()
                ActivarBotones(True, False, False, True, False, False)
            Else
                Return
            End If
        End If
    End Sub

#End Region

#Region "Metodos de Formulario:frmDocumentoPDM"
    Private Sub AcivarCajas(BolActivar As Boolean, bolEnaChk As Boolean)
        txtDetalle.Enabled = BolActivar
        chkActivar.Enabled = bolEnaChk
    End Sub

    Private Sub ActivarBotones(BolNuevo As Boolean, BolGuardar As Boolean, BolEditar As Boolean, BolBuscar As Boolean, BolCancelar As Boolean, BolTBuscar As Boolean)
        btnNuevo.Visible = BolNuevo
        btnGuardar.Visible = BolGuardar
        btnEditar.Visible = BolEditar
        btnBuscar.Visible = BolBuscar
        btnCancelar.Visible = BolCancelar
        txtBuscar.Visible = BolTBuscar
        lblBuscar.Visible = BolTBuscar
    End Sub

    Private Sub LimpiarCajas()
        txtDetalle.Text = String.Empty
    End Sub
#End Region


End Class