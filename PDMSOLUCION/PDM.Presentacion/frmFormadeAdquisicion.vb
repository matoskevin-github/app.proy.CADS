Imports PDM.LogicaNegocio
Imports PDM.Entidades

Public Class frmFormadeAdquisicion

    Private idFormaAdquisicion As String
    Private encontrado As Integer = 0

#Region "Eventos de Formulario:frmFormaAdquisicionPDM"

    Private Sub CargarTablaFormaAdquisicion()
        Dim oPDMFormaAdquisicionBO As New PDMFormaAdquisicionBO()
        dgvFormaAdquisicion.DataSource = oPDMFormaAdquisicionBO.TableFormaAdquisicion
        dgvFormaAdquisicion.AutoResizeColumns()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        AcivarCajas(True, False)
        LimpiarCajas()
        txtDetalle.Focus()
        ActivarBotones(False, True, False, False, True, False)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        GuardarFormaAdquisicion()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        EditarFormaAdquisicion()
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
        CargarTablaFormaAdquisicion()
        chkActivar.Checked = True
    End Sub

    Private Sub frmFormadeAdquisicion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AcivarCajas(False, False)
        LimpiarCajas()
        ActivarBotones(True, False, False, True, False, False)
        chkActivar.Checked = True
        CargarTablaFormaAdquisicion()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If (btnEditar.Visible) Then
            If (encontrado = 0) Then
                If txtBuscar.Text.Length >= 0 Then
                    Dim oPDMFormaAdquisicionBO As New PDMFormaAdquisicionBO()
                    dgvFormaAdquisicion.DataSource = oPDMFormaAdquisicionBO.ObtenerTableXFormaAdquisicion(txtBuscar.Text.Trim)
                    'encontrado = dtgListarEntidad.RowCount
                End If
            Else
                If (txtBuscar.Text = String.Empty) Then
                    CargarTablaFormaAdquisicion()
                    encontrado = 0
                End If
            End If
        End If
    End Sub

    Private Sub dgvFormaAdquisicion_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFormaAdquisicion.CellClick
        If (btnEditar.Visible) Then
            Dim index As Integer = e.RowIndex
            If index < 0 Then
                Return
            Else
                Dim selectedRow As DataGridViewRow = dgvFormaAdquisicion.Rows(index)
                idFormaAdquisicion = Convert.ToInt32(selectedRow.Cells(0).Value.ToString())
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
                GuardarFormaAdquisicion()
            End If
        ElseIf btnEditar.Visible Then
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                EditarFormaAdquisicion()
            End If
        End If
    End Sub

    Public Sub GuardarFormaAdquisicion()
        Dim oPDMFormaAdquisicionBO As New PDMFormaAdquisicionBO()
        Dim oPDMFormaAdquisicionBE As New PDMFormaAdquisicionBE
        oPDMFormaAdquisicionBE.idLogin = SessionUsuario.idUsuario
        oPDMFormaAdquisicionBE.Detalle = txtDetalle.Text.Trim
        oPDMFormaAdquisicionBE.FechaIngreso = DateTime.Now
        oPDMFormaAdquisicionBE.FechaModificacion = DateTime.Now
        chkActivar.Checked = True
        If (chkActivar.Checked) Then
            oPDMFormaAdquisicionBE.Estado = 1
        End If

        If txtDetalle.Text = String.Empty Then
            MessageBox.Show("DEBE INGRESAR DETALLE", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtDetalle.Focus()
        Else
            If MessageBox.Show("DESEA REGISTRAR ESTA FORMA DE ADQUISICION", "INFORMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Dim boolGuardar As Boolean = oPDMFormaAdquisicionBO.InsertarFormaAdquisicion(oPDMFormaAdquisicionBE)
                MessageBox.Show("FORMA DE ADQUISICION REGISTRADA CORRECTAMENTE", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarTablaFormaAdquisicion()
                AcivarCajas(False, False)
                LimpiarCajas()
                ActivarBotones(True, False, False, True, False, False)
            Else
                Return
            End If
        End If
    End Sub

    Public Sub EditarFormaAdquisicion()
        Dim oPDMFormaAdquisicionBO As New PDMFormaAdquisicionBO()
        Dim oPDMFormaAdquisicionBE As New PDMFormaAdquisicionBE
        oPDMFormaAdquisicionBE.idFormaAdquisicion = idFormaAdquisicion
        oPDMFormaAdquisicionBE.idLogin = SessionUsuario.idUsuario
        oPDMFormaAdquisicionBE.Detalle = txtDetalle.Text.Trim
        oPDMFormaAdquisicionBE.FechaModificacion = DateTime.Now
        If (chkActivar.Checked) Then
            oPDMFormaAdquisicionBE.Estado = 1
        Else
            oPDMFormaAdquisicionBE.Estado = 0
        End If

        If txtDetalle.Text = String.Empty Or idFormaAdquisicion = "" Then
            MessageBox.Show("DEBE SELECCIONAR UN DOCUMENTO DE LA LISTA", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtDetalle.Focus()
        Else
            If MessageBox.Show("DESEA ACTUALIZAR ESTA FORMA DE ADQUISICION", "INFORMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Dim boolGuardar As Boolean = oPDMFormaAdquisicionBO.ActualizarFormaAdquisicion(oPDMFormaAdquisicionBE)
                MessageBox.Show("FORMA DE ADQUISICION ACTUALIZADA CORRECTAMENTE", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarTablaFormaAdquisicion()
                AcivarCajas(False, False)
                LimpiarCajas()
                ActivarBotones(True, False, False, True, False, False)
            Else
                Return
            End If
        End If
    End Sub

#End Region

#Region "Metodos de Formulario:frmFormaAdquisicionPDM"

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