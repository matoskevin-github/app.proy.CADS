Imports PDM.LogicaNegocio
Imports PDM.Entidades

Public Class frmCondicionAltayBaja
    Private idCondicion As String
    Private encontrado As Integer = 0

#Region "Eventos de Formulario:frmCondicionPDM"

    Private Sub frmCondicionAltayBaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AcivarCajas(False, False)
        LimpiarCajas()
        ActivarBotones(True, False, False, True, False, False)
        chkActivar.Checked = True
        CargarTablaCondicion()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        AcivarCajas(True, False)
        LimpiarCajas()
        txtDetalle.Focus()
        ActivarBotones(False, True, False, False, True, False)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        GuardarCondicion()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        EditarCondicion()
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
        CargarTablaCondicion()
        chkActivar.Checked = True
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If (btnEditar.Visible) Then
            If (encontrado = 0) Then
                If txtBuscar.Text.Length >= 0 Then
                    Dim oPDMCondicionBO As New PDMCondicionBO()
                    dgvCondicionAB.DataSource = oPDMCondicionBO.ObtenerTableXCondicion(txtBuscar.Text.Trim)
                    'encontrado = dtgListarEntidad.RowCount
                End If
            Else
                If (txtBuscar.Text = String.Empty) Then
                    CargarTablaCondicion()
                    encontrado = 0
                End If
            End If
        End If
    End Sub

    Private Sub dgvCondicionAB_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCondicionAB.CellClick
        If (btnEditar.Visible) Then
            Dim index As Integer = e.RowIndex
            If index < 0 Then
                Return
            Else
                Dim selectedRow As DataGridViewRow = dgvCondicionAB.Rows(index)
                idCondicion = Convert.ToInt32(selectedRow.Cells(0).Value.ToString())
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

    Private Sub CargarTablaCondicion()
        Dim oPDMCondicionBO As New PDMCondicionBO()
        dgvCondicionAB.DataSource = oPDMCondicionBO.TableCondicion
        dgvCondicionAB.AutoResizeColumns()
    End Sub

    Public Sub GuardarCondicion()
        Dim oPDMCondicionBO As New PDMCondicionBO()
        Dim oPDMCondicionBE As New PDMCondicionBE
        oPDMCondicionBE.idLogin = SessionUsuario.idUsuario
        oPDMCondicionBE.Detalle = txtDetalle.Text.Trim
        oPDMCondicionBE.FechaIngreso = DateTime.Now
        oPDMCondicionBE.FechaModificacion = DateTime.Now
        chkActivar.Checked = True
        If (chkActivar.Checked) Then
            oPDMCondicionBE.Estado = 1
        End If

        If txtDetalle.Text = String.Empty Then
            MessageBox.Show("DEBE INGRESAR DETALLE", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtDetalle.Focus()
        Else
            If MessageBox.Show("DESEA REGISTRAR ESTA CONDICION", "INFORMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Dim boolGuardar As Boolean = oPDMCondicionBO.InsertarCondicion(oPDMCondicionBE)
                MessageBox.Show("CONDICION REGISTRADO CORRECTAMENTE", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarTablaCondicion()
                AcivarCajas(False, False)
                LimpiarCajas()
                ActivarBotones(True, False, False, True, False, False)
            Else
                Return
            End If
        End If
    End Sub

    Public Sub EditarCondicion()
        Dim oPDMCondicionBO As New PDMCondicionBO()
        Dim oPDMCondicionBE As New PDMCondicionBE
        oPDMCondicionBE.idCondicion = idCondicion
        oPDMCondicionBE.idLogin = SessionUsuario.idUsuario
        oPDMCondicionBE.Detalle = txtDetalle.Text.Trim
        oPDMCondicionBE.FechaModificacion = DateTime.Now
        If (chkActivar.Checked) Then
            oPDMCondicionBE.Estado = 1
        Else
            oPDMCondicionBE.Estado = 0
        End If

        If txtDetalle.Text = String.Empty Or idCondicion = "" Then
            MessageBox.Show("DEBE SELECCIONAR UNA CONDICION DE LA LISTA", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtDetalle.Focus()
        Else
            If MessageBox.Show("DESEA ACTUALIZAR ESTA CONDICION", "INFORMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Dim boolGuardar As Boolean = oPDMCondicionBO.ActualizarCondicion(oPDMCondicionBE)
                MessageBox.Show("CONDICION ACTUALIZADA CORRECTAMENTE", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarTablaCondicion()
                AcivarCajas(False, False)
                LimpiarCajas()
                ActivarBotones(True, False, False, True, False, False)
            Else
                Return
            End If
        End If
    End Sub

    Private Sub txtDetalle_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDetalle.KeyPress
        If (btnGuardar.Visible) Then
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                GuardarCondicion()
            End If
        ElseIf btnEditar.Visible Then
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                EditarCondicion()
            End If
        End If
    End Sub

#End Region

#Region "Metodos de Formulario:frmCondicionPDM"
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