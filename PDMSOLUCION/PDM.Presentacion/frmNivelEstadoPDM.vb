Imports PDM.LogicaNegocio
Imports PDM.Entidades

Public Class frmNivelEstadoPDM

    Private idNivelEstado As String
    Private encontrado As Integer = 0

#Region "Eventos de Formulario:frmNivelEstadoPDM"

    Private Sub CargarTablaNivelEstado()
        Dim oPDMNivelEstadoBO As New PDMNivelEstadoBO()
        dgvNivelEstado.DataSource = oPDMNivelEstadoBO.TableNivelEstado
        dgvNivelEstado.AutoResizeColumns()
    End Sub

    Private Sub frmNivelEstadoPDM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AcivarCajas(False, False)
        LimpiarCajas()
        ActivarBotones(True, False, False, True, False, False)
        chkActivar.Checked = True
        CargarTablaNivelEstado()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        AcivarCajas(True, False)
        LimpiarCajas()
        txtDetalle.Focus()
        ActivarBotones(False, True, False, False, True, False)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        GuardarNivelEstado()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        EditarNivelEstado()
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
        CargarTablaNivelEstado()
        chkActivar.Checked = True
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If (btnEditar.Visible) Then
            If (encontrado = 0) Then
                If txtBuscar.Text.Length >= 0 Then
                    Dim oPDMNivelEstadoBO As New PDMNivelEstadoBO()
                    dgvNivelEstado.DataSource = oPDMNivelEstadoBO.ObtenerTableXNivelEstado(txtBuscar.Text.Trim)
                    'encontrado = dtgListarEntidad.RowCount
                End If
            Else
                If (txtBuscar.Text = String.Empty) Then
                    CargarTablaNivelEstado()
                    encontrado = 0
                End If
            End If
        End If
    End Sub

    Private Sub dgvNivelEstado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNivelEstado.CellClick
        If (btnEditar.Visible) Then
            Dim index As Integer = e.RowIndex
            If index < 0 Then
                Return
            Else
                Dim selectedRow As DataGridViewRow = dgvNivelEstado.Rows(index)
                idNivelEstado = Convert.ToInt32(selectedRow.Cells(0).Value.ToString())
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

    Private Sub txtDetalle_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDetalle.KeyPress
        If (btnGuardar.Visible) Then
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                GuardarNivelEstado()
            End If
        ElseIf btnEditar.Visible Then
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                EditarNivelEstado()
            End If
        End If
    End Sub

    Public Sub GuardarNivelEstado()
        Dim oPDMNivelEstadoBO As New PDMNivelEstadoBO()
        Dim oPDMNivelEstadoBE As New PDMNivelEstadoBE
        oPDMNivelEstadoBE.idLogin = SessionUsuario.idUsuario
        oPDMNivelEstadoBE.Detalle = txtDetalle.Text.Trim
        oPDMNivelEstadoBE.FechaIngreso = DateTime.Now
        oPDMNivelEstadoBE.FechaModificacion = DateTime.Now
        chkActivar.Checked = True
        If (chkActivar.Checked) Then
            oPDMNivelEstadoBE.Estado = 1
        End If

        If txtDetalle.Text = String.Empty Then
            MessageBox.Show("DEBE INGRESAR DETALLE", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtDetalle.Focus()
        Else
            If MessageBox.Show("DESEA REGISTRAR ESTE NIVEL DE ESTADO", "INFORMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Dim boolGuardar As Boolean = oPDMNivelEstadoBO.InsertarNivelEstado(oPDMNivelEstadoBE)
                MessageBox.Show("NIVEL DE ESTADO REGISTRADO CORRECTAMENTE", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarTablaNivelEstado()
                AcivarCajas(False, False)
                LimpiarCajas()
                ActivarBotones(True, False, False, True, False, False)
            Else
                Return
            End If
        End If
    End Sub

    Public Sub EditarNivelEstado()
        Dim oPDMNivelEstadoBO As New PDMNivelEstadoBO()
        Dim oPDMNivelEstadoBE As New PDMNivelEstadoBE
        oPDMNivelEstadoBE.idNivelEstado = idNivelEstado
        oPDMNivelEstadoBE.idLogin = SessionUsuario.idUsuario
        oPDMNivelEstadoBE.Detalle = txtDetalle.Text.Trim
        oPDMNivelEstadoBE.FechaModificacion = DateTime.Now
        If (chkActivar.Checked) Then
            oPDMNivelEstadoBE.Estado = 1
        Else
            oPDMNivelEstadoBE.Estado = 0
        End If

        If txtDetalle.Text = String.Empty Or idNivelEstado = "" Then
            MessageBox.Show("DEBE SELECCIONAR UN REGISTRO DE LA LISTA", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtDetalle.Focus()
        Else
            If MessageBox.Show("DESEA ACTUALIZAR ESTE NIVEL DE ESTADO", "INFORMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Dim boolGuardar As Boolean = oPDMNivelEstadoBO.ActualizarNivelEstado(oPDMNivelEstadoBE)
                MessageBox.Show("NIVEL DE ESTADO ACTUALIZADO CORRECTAMENTE", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarTablaNivelEstado()
                AcivarCajas(False, False)
                LimpiarCajas()
                ActivarBotones(True, False, False, True, False, False)
            Else
                Return
            End If
        End If
    End Sub

#End Region

#Region "Metodos de Formulario:frmNivelEstadoPDM"

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