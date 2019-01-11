Imports PDM.LogicaNegocio
Imports PDM.Entidades

Public Class frmIngresarResponsablesPDM
    Private idResponsable As String
    Private encontrado As Integer = 0

#Region "Eventos de Formulario:frmIngresarResponsablePDM"

    Private Sub CargarTablaResponsable()
        Dim oPDMResponsableBO As New PDMResponsableBO()
        dgvResponsable.DataSource = oPDMResponsableBO.TableResponsable
        dgvResponsable.AutoResizeColumns()
    End Sub

    Private Sub CargarCombosResponsable()
        Dim oPDMResponsableBO As New PDMResponsableBO()
        cboCargo.DataSource = oPDMResponsableBO.ObtenerCargo
    
        cboCargo.ValueMember = "idCargo"
        cboCargo.DisplayMember = "Detalle"
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        AcivarCajas(True)
        LimpiarCajas()
        ActivarBotones(False, True, False, False, True, False, False)
        TapCajas()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        GuardarResponsable()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        EditarResponsable()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        AcivarCajas(False)
        LimpiarCajas()
        ActivarBotones(False, False, True, False, True, True, True)
        txtBuscar.Focus()
        CargarCombosResponsable()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        AcivarCajas(False)
        LimpiarCajas()
        ActivarBotones(True, False, False, True, False, False, False)
        chkActivar.Checked = True
        CargarTablaResponsable()
        CargarCombosResponsable()
    End Sub

    Private Sub frmIngresarResponsablesPDM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chkActivar.Checked = True
        chkActivar.Enabled = False
        AcivarCajas(False)
        LimpiarCajas()
        ActivarBotones(True, False, False, True, False, False, False)
        CargarTablaResponsable()
        CargarCombosResponsable()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If (btnEditar.Visible) Then
            If (encontrado = 0) Then
                If txtBuscar.Text.Length >= 0 Then
                    Dim oPDMResponsableBO As New PDMResponsableBO()
                    dgvResponsable.DataSource = oPDMResponsableBO.ObtenerTableXResponsable(txtBuscar.Text.Trim)
                    'encontrado = dtgListarEntidad.RowCount
                End If
            Else
                If (txtBuscar.Text = String.Empty) Then
                    CargarTablaResponsable()
                    encontrado = 0
                End If
            End If
        End If
    End Sub

    Private Sub dgvResponsable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvResponsable.CellClick
        If (btnEditar.Visible) Then
            Dim index As Integer = e.RowIndex
            If index < 0 Then
                Return
            Else
                Dim selectedRow As DataGridViewRow = dgvResponsable.Rows(index)
                idResponsable = Convert.ToInt32(selectedRow.Cells(0).Value.ToString())
                txtApellidos.Text = Convert.ToString(selectedRow.Cells(1).Value.ToString())
                txtNombres.Text = Convert.ToString(selectedRow.Cells(2).Value.ToString())
                txtDNI.Text = Convert.ToString(selectedRow.Cells(3).Value.ToString())
                txtDireccion.Text = Convert.ToString(selectedRow.Cells(4).Value.ToString())
                txtCorreo.Text = Convert.ToString(selectedRow.Cells(5).Value.ToString())
                txtCelular.Text = Convert.ToString(selectedRow.Cells(6).Value.ToString())
                cboEstadoCivil.Text = Convert.ToString(selectedRow.Cells(7).Value.ToString())
                dtpFechaNacimiento.Text = Convert.ToString(selectedRow.Cells(8).Value.ToString())
                cboCargo.Text = Convert.ToString(selectedRow.Cells(9).Value.ToString())
                cboCondicion.Text = Convert.ToString(selectedRow.Cells(10).Value.ToString())
                dtpFechaIngreso.Text = Convert.ToString(selectedRow.Cells(11).Value.ToString())
                If Convert.ToString(selectedRow.Cells(12).Value) = "ACTIVO" Then
                    chkActivar.Checked = True
                Else
                    chkActivar.Checked = False
                End If

                txtBuscar.Text = String.Empty
                AcivarCajas(True)
                TapCajas()
                chkActivar.Enabled = True
                'CargarCombosAmbiente()
                'CargarTablaPabellon()
            End If
        End If
    End Sub

    Public Sub GuardarResponsable()
        Dim oPDMResponsableBO As New PDMResponsableBO()
        Dim oPDMResponsableBE As New PDMResponsableBE
        oPDMResponsableBE.idUsuario = SessionUsuario.idUsuario
        oPDMResponsableBE.Nombres = txtNombres.Text.Trim
        oPDMResponsableBE.Apellidos = txtApellidos.Text.Trim
        oPDMResponsableBE.DNI = txtDNI.Text.Trim
        oPDMResponsableBE.Direccion = txtDireccion.Text.Trim
        oPDMResponsableBE.Correo = txtCorreo.Text.Trim
        oPDMResponsableBE.Celular = txtCelular.Text.Trim
        oPDMResponsableBE.EstadoCivil = cboEstadoCivil.SelectedItem
        oPDMResponsableBE.FechaNacimiento = dtpFechaNacimiento.Value.ToString
        oPDMResponsableBE.idCargo = cboCargo.SelectedValue.ToString
        oPDMResponsableBE.Condicion = cboCondicion.SelectedItem
        oPDMResponsableBE.FechaIngreso = dtpFechaIngreso.Value.ToString
        oPDMResponsableBE.FechaIngresoR = DateTime.Now
        oPDMResponsableBE.FechaModificacion = DateTime.Now
        chkActivar.Checked = True
        If (chkActivar.Checked) Then
            oPDMResponsableBE.Estado = 1
        End If

        If Validaciones() = True Then
            If MessageBox.Show("DESEA REGISTRAR ESTE RESPONSABLE", "INFORMACIÓN", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                Dim boolGuardar As Boolean = oPDMResponsableBO.InsertarResonsable(oPDMResponsableBE)
                MessageBox.Show("RESPONSABLE REGISTRADO CORRECTAMENTE", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarTablaResponsable()
                CargarCombosResponsable()
                AcivarCajas(False)
                LimpiarCajas()
                ActivarBotones(True, False, False, True, False, False, False)
                chkActivar.Checked = True
            Else
                Return
            End If
        Else
            Return
        End If
    End Sub

    Public Sub EditarResponsable()
        Dim oPDMResponsableBO As New PDMResponsableBO()
        Dim oPDMResponsableBE As New PDMResponsableBE
        oPDMResponsableBE.idResponsable = idResponsable
        oPDMResponsableBE.idUsuario = SessionUsuario.idUsuario
        oPDMResponsableBE.Nombres = txtNombres.Text.Trim
        oPDMResponsableBE.Apellidos = txtApellidos.Text.Trim
        oPDMResponsableBE.DNI = txtDNI.Text.Trim
        oPDMResponsableBE.Direccion = txtDireccion.Text.Trim
        oPDMResponsableBE.Correo = txtCorreo.Text.Trim
        oPDMResponsableBE.Celular = txtCelular.Text.Trim
        oPDMResponsableBE.EstadoCivil = cboEstadoCivil.SelectedItem
        oPDMResponsableBE.FechaNacimiento = dtpFechaNacimiento.Value.ToString
        oPDMResponsableBE.idCargo = cboCargo.SelectedValue.ToString
        oPDMResponsableBE.Condicion = cboCondicion.SelectedItem
        oPDMResponsableBE.FechaIngreso = dtpFechaIngreso.Value.ToString
        oPDMResponsableBE.FechaModificacion = DateTime.Now
        chkActivar.Checked = True
        If (chkActivar.Checked) Then
            oPDMResponsableBE.Estado = 1
        End If

        If idResponsable = "" Then
            MessageBox.Show("DEBE SELECCIONAR UN RESPONSABLE DE LA LISTA", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If Validaciones() = True Then
                If MessageBox.Show("DESEA ACTUALIZAR ESTE RESPONSABLE", "INFORMACIÓN", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                    Dim boolGuardar As Boolean = oPDMResponsableBO.ActualizarResponsable(oPDMResponsableBE)
                    MessageBox.Show("RESPONSABLE ACTUALIZADO CORRECTAMENTE", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CargarTablaResponsable()
                    CargarCombosResponsable()
                    AcivarCajas(False)
                    LimpiarCajas()
                    ActivarBotones(True, False, False, True, False, False, False)
                    chkActivar.Checked = True
                Else
                    Return
                End If
            Else
                Return
            End If
        End If
    End Sub

    Private Sub dtpFechaIngreso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtpFechaIngreso.KeyPress
        If (btnGuardar.Visible) Then
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                GuardarResponsable()
            End If
        ElseIf btnEditar.Visible Then
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                EditarResponsable()
            End If
        End If
    End Sub

#End Region

#Region "Metodos de Formulario:frmIngresarResponsablesPDM"
    Private Sub AcivarCajas(Bol As Boolean)
        txtNombres.Enabled = Bol
        txtApellidos.Enabled = Bol
        txtDNI.Enabled = Bol
        txtDireccion.Enabled = Bol
        txtCorreo.Enabled = Bol
        txtCelular.Enabled = Bol
        cboEstadoCivil.Enabled = Bol
        cboCargo.Enabled = Bol
        cboCondicion.Enabled = Bol
        dtpFechaIngreso.Enabled = Bol
        dtpFechaNacimiento.Enabled = Bol
    End Sub

    Private Sub ActivarBotones(BolNuevo As Boolean, BolGuardar As Boolean, BolEditar As Boolean, BolBuscar As Boolean, BolCancelar As Boolean, lBuscar As Boolean, TBuscar As Boolean)
        btnNuevo.Visible = BolNuevo
        btnGuardar.Visible = BolGuardar
        btnEditar.Visible = BolEditar
        btnBuscar.Visible = BolBuscar
        btnCancelar.Visible = BolCancelar
        lblBuscar.Visible = lBuscar
        txtBuscar.Visible = TBuscar
    End Sub

    Private Sub LimpiarCajas()
        txtNombres.Text = String.Empty
        txtApellidos.Text = String.Empty
        txtDNI.Text = String.Empty
        txtDireccion.Text = String.Empty
        txtCorreo.Text = String.Empty
        txtCelular.Text = String.Empty
        'cboCargo.SelectedIndex = 0
        cboEstadoCivil.SelectedIndex = 0
        cboCondicion.SelectedIndex = 0
        dtpFechaIngreso.Value = DateTime.Now
        dtpFechaNacimiento.Value = DateTime.Now
    End Sub

    Private Sub TapCajas()
        txtNombres.Focus()
        txtNombres.TabIndex = 1
        txtApellidos.TabIndex = 2
        txtDNI.TabIndex = 3
        txtDireccion.TabIndex = 4
        txtCorreo.TabIndex = 5
        txtCelular.TabIndex = 6
        cboEstadoCivil.TabIndex = 7
        dtpFechaNacimiento.TabIndex = 8
        cboCargo.TabIndex = 8
        cboCondicion.TabIndex = 9
        dtpFechaIngreso.TabIndex = 10
    End Sub
#End Region

#Region "Validaciones del Formulario:frmIngresarResponsablePDM"
    Private Function Validaciones() As Boolean

        If txtNombres.Text = String.Empty Then
            MessageBox.Show("DEBE INGRESAR NOMBRES", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNombres.Focus()
            Return False
        End If

        If txtApellidos.Text = String.Empty Then
            MessageBox.Show("DEBE INGRESAR APELLIDOS", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtApellidos.Focus()
            Return False
        End If

        If txtDNI.Text = String.Empty Then
            MessageBox.Show("DEBE INGRESAR DNI", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtDNI.Focus()
            Return False
        End If

        If txtDireccion.Text = String.Empty Then
            MessageBox.Show("DEBE INGRESAR DIRECCION", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtDireccion.Focus()
            Return False
        End If

        If txtCorreo.Text = String.Empty Then
            MessageBox.Show("DEBE INGRESAR CORREO", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCorreo.Focus()
            Return False
        End If

        If txtCelular.Text = String.Empty Then
            MessageBox.Show("DEBE INGRESAR NUMERO DE CELULAR", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCelular.Focus()
            Return False
        End If

        If cboEstadoCivil.SelectedItem = "--SELECCIONAR--" Then
            MessageBox.Show("DEBE INGRESAR ESTADO CIVIL", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboEstadoCivil.Focus()
            Return False
        End If

        If cboCargo.SelectedIndex = 0 Then
            MessageBox.Show("DEBE INGRESAR CARGO", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboCargo.Focus()
            Return False
        End If

        If cboCondicion.SelectedItem = "--SELECCIONAR--" Then
            MessageBox.Show("DEBE INGRESAR CONDICION", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboCondicion.Focus()
            Return False
        End If

        Return True
    End Function
#End Region
End Class