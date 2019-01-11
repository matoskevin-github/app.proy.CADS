Imports PDM.LogicaNegocio
Imports PDM.Entidades

Public Class frmIngresaCargo
    Private idCargo As String
    Private encontrado As Integer = 0

#Region "Eventos de Formulario:frmIngresaCargoPDM"

    Private Sub frmIngresaCargo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AcivarCajas(False, False)
        LimpiarCajas()
        ActivarBotones(True, False, False, True, False, False)
        chkActivar.Checked = True
        CargarTablaCargo()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        AcivarCajas(True, False)
        LimpiarCajas()
        ActivarBotones(False, True, False, False, True, False)
        txtCargo.Focus()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        GuardarCargo()
    End Sub

    Private Sub CargarTablaCargo()
        Dim oPDMCargoBO As New PDMCargoBO()
        dvgListarCargo.DataSource = oPDMCargoBO.TableCargo
        dvgListarCargo.AutoResizeColumns()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        ActualizarCargo()
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
        chkActivar.Checked = True
    End Sub

    Private Sub dvgListarCargo_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvgListarCargo.CellClick
        If (btnEditar.Visible) Then
            Dim index As Integer = e.RowIndex
            If index < 0 Then
                Return
            Else
                Dim selectedRow As DataGridViewRow = dvgListarCargo.Rows(index)
                idCargo = Convert.ToInt32(selectedRow.Cells(0).Value.ToString())
                txtCargo.Text = Convert.ToString(selectedRow.Cells(1).Value.ToString())
                If Convert.ToString(selectedRow.Cells(2).Value) = "ACTIVO" Then
                    chkActivar.Checked = True
                Else
                    chkActivar.Checked = False
                End If
                txtBuscar.Text = String.Empty
                AcivarCajas(True, True)
                txtCargo.Focus()
                'CargarTablaCargo()
            End If
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If (btnEditar.Visible) Then
            If (encontrado = 0) Then
                If txtBuscar.Text.Length >= 0 Then
                    Dim oPDMCargoBO As New PDMCargoBO()
                    dvgListarCargo.DataSource = oPDMCargoBO.ObtenerTableXCargo(txtBuscar.Text.Trim)
                    'encontrado = dtgListarEntidad.RowCount
                End If
            Else
                If (txtBuscar.Text = String.Empty) Then
                    CargarTablaCargo()
                    encontrado = 0
                End If
            End If
        End If
    End Sub

    Public Sub GuardarCargo()
        Dim oPDMCargoBO As New PDMCargoBO()
        Dim oPDMCargoBE As New PDMCargoBE()
        oPDMCargoBE.idLogin = SessionUsuario.idUsuario
        oPDMCargoBE.Detalle = txtCargo.Text.Trim
        oPDMCargoBE.FechaIngreso = DateTime.Now
        oPDMCargoBE.FechaModificacion = DateTime.Now
        chkActivar.Checked = True
        If (chkActivar.Checked) Then
            oPDMCargoBE.Estado = 1
        End If

        If txtCargo.Text = "" Then
            MessageBox.Show("DEBE INGRESAR DETALLE", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCargo.Focus()
        Else
            If MessageBox.Show("DESEA REGISTRAR ESTE CARGO", "INFORMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Dim boolGuardar As Boolean = oPDMCargoBO.InsertarCargo(oPDMCargoBE)
                MessageBox.Show("CARGO REGISTRADA CORRECTAMENTE", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarTablaCargo()
                AcivarCajas(False, False)
                LimpiarCajas()
                ActivarBotones(True, False, False, True, False, False)
            Else
                Return
            End If
        End If
    End Sub

    Public Sub ActualizarCargo()
        Dim oPDMCargoBO As New PDMCargoBO()
        Dim oPDMCargoBE As New PDMCargoBE()
        oPDMCargoBE.idCargo = idCargo
        oPDMCargoBE.idLogin = SessionUsuario.idUsuario
        oPDMCargoBE.Detalle = txtCargo.Text.Trim
        oPDMCargoBE.FechaModificacion = DateTime.Now
        If (chkActivar.Checked) Then
            oPDMCargoBE.Estado = 1
        Else
            oPDMCargoBE.Estado = 0
        End If

        If txtCargo.Text = "" Or idCargo = "" Then
            MessageBox.Show("DEBE SELECCIONAR UN CARGO DE LA LISTA", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCargo.Focus()
        Else
            If MessageBox.Show("DESEA ACTUALIZAR ESTE CARGO", "INFORMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Dim boolGuardar As Boolean = oPDMCargoBO.ActualizarCargo(oPDMCargoBE)
                MessageBox.Show("CARGO ACTUALIZADO CORRECTAMENTE", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarTablaCargo()
                AcivarCajas(False, False)
                LimpiarCajas()
                ActivarBotones(True, False, False, True, False, False)
            Else
                Return
            End If
        End If
    End Sub

    Private Sub txtCargo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCargo.KeyPress
        If (btnGuardar.Visible) Then
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                GuardarCargo()
            End If
        ElseIf btnEditar.Visible Then
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                ActualizarCargo()
            End If
        End If
    End Sub

#End Region

#Region "Metodos de Formulario:frmIngresaCargoPDM"
    Private Sub AcivarCajas(BolActivar As Boolean, bolEnaChk As Boolean)
        txtCargo.Enabled = BolActivar
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
        txtCargo.Text = String.Empty
    End Sub
#End Region

End Class