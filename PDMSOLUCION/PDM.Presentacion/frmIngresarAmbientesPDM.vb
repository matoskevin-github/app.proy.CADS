Imports PDM.LogicaNegocio
Imports PDM.Entidades

Public Class frmIngresarAmbientesPDM
    Private idAmbiente As String
    Private encontrado As Integer = 0

#Region "Eventos de Formulario:frmIngresarAmbientesPDM"

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        AcivarCajas(True, True, True, False, False, False)
        LimpiarCajas()
        ActivarBotones(False, True, False, False, True, False, False)
        TapCajas()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        GuardarAmbiente()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        EditarAmbiente()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        AcivarCajas(False, False, False, False, True, True)
        LimpiarCajas()
        ActivarBotones(False, False, True, False, True, True, True)
        txtBuscar.Focus()
        CargarCombosAmbiente()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        AcivarCajas(False, False, False, False, False, False)
        LimpiarCajas()
        ActivarBotones(True, False, False, True, False, False, False)
        chkActivar.Checked = True
        CargarTablaAmbiente()
    End Sub

    Private Sub frmIngresarAmbientesPDM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chkActivar.Checked = True
        AcivarCajas(False, False, False, False, False, False)
        LimpiarCajas()
        ActivarBotones(True, False, False, True, False, False, False)
        CargarTablaAmbiente()
        CargarCombosAmbiente()
    End Sub

    Private Sub CargarTablaAmbiente()
        Dim oPDMAmbienteBO As New PDMAmbientesBO()
        dgvAmbientes.DataSource = oPDMAmbienteBO.TableAmbientes
        dgvAmbientes.AutoResizeColumns()
    End Sub

    Private Sub CargarCombosAmbiente()
        Dim oPDMAmbienteBO As New PDMAmbientesBO()
        cboPabellon.DataSource = oPDMAmbienteBO.ObtenerPabellones
        cboPabellon.ValueMember = "idPabellon"
        cboPabellon.DisplayMember = "NomPabellon"
        cboPisos.DataSource = oPDMAmbienteBO.ObtenerPisos
        cboPisos.ValueMember = "idPisos"
        cboPisos.DisplayMember = "NomPiso"
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If (btnEditar.Visible) Then
            If (encontrado = 0) Then
                If txtBuscar.Text.Length >= 0 Then
                    Dim oPDMAmbienteBO As New PDMAmbientesBO()
                    dgvAmbientes.DataSource = oPDMAmbienteBO.ObtenerTableXAmbiente(txtBuscar.Text.Trim)
                    'encontrado = dtgListarEntidad.RowCount
                End If
            Else
                If (txtBuscar.Text = String.Empty) Then
                    CargarTablaAmbiente()
                    encontrado = 0
                End If
            End If
        End If
    End Sub

    Private Sub dgvAmbientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAmbientes.CellClick
        If (btnEditar.Visible) Then
            Dim index As Integer = e.RowIndex
            If index < 0 Then
                Return
            Else
                Dim selectedRow As DataGridViewRow = dgvAmbientes.Rows(index)

                idAmbiente = Convert.ToInt32(selectedRow.Cells(0).Value.ToString())
                txtAmbiente.Text = Convert.ToString(selectedRow.Cells(1).Value.ToString())
                cboPabellon.Text = Convert.ToString(selectedRow.Cells(2).Value)
                cboPisos.Text = Convert.ToString(selectedRow.Cells(3).Value)

                If Convert.ToString(selectedRow.Cells(4).Value) = "ACTIVO" Then
                    chkActivar.Checked = True
                Else
                    chkActivar.Checked = False
                End If

                txtBuscar.Text = String.Empty
                AcivarCajas(True, True, True, True, True, True)
                TapCajas()
                'CargarCombosAmbiente()
                'CargarTablaPabellon()
            End If
        End If
    End Sub

    Public Sub GuardarAmbiente()
        Dim oPDMAmbienteBO As New PDMAmbientesBO()
        Dim oPDMAmbienteBE As New PDMAmbientesBE
        oPDMAmbienteBE.idLogin = SessionUsuario.idUsuario
        oPDMAmbienteBE.Detalle = txtAmbiente.Text.Trim
        oPDMAmbienteBE.idPabellon = cboPabellon.SelectedValue.ToString
        oPDMAmbienteBE.idPisos = cboPisos.SelectedValue.ToString
        oPDMAmbienteBE.FechaIngreso = DateTime.Now
        oPDMAmbienteBE.FechaModificacion = DateTime.Now
        chkActivar.Checked = True
        If (chkActivar.Checked) Then
            oPDMAmbienteBE.Estado = 1
        End If

        If Validaciones() = True Then
            If MessageBox.Show("DESEA REGISTRAR ESTE AMBIENTE", "INFORMACIÓN", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                Dim boolGuardar As Boolean = oPDMAmbienteBO.InsertarAmbiente(oPDMAmbienteBE)
                MessageBox.Show("AMBIENTE REGISTRADO CORRECTAMENTE", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarTablaAmbiente()
                CargarCombosAmbiente()
                AcivarCajas(False, False, False, False, False, False)
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

    Public Sub EditarAmbiente()
        Dim oPDMAmbienteBO As New PDMAmbientesBO()
        Dim oPDMAmbienteBE As New PDMAmbientesBE
        oPDMAmbienteBE.idAmbiente = idAmbiente
        oPDMAmbienteBE.idLogin = SessionUsuario.idUsuario
        oPDMAmbienteBE.Detalle = txtAmbiente.Text.Trim
        oPDMAmbienteBE.idPabellon = cboPabellon.SelectedValue.ToString
        oPDMAmbienteBE.idPisos = cboPisos.SelectedValue.ToString
        oPDMAmbienteBE.FechaModificacion = DateTime.Now
        chkActivar.Checked = True
        If (chkActivar.Checked) Then
            oPDMAmbienteBE.Estado = 1
        End If

        If idAmbiente = "" Then
            MessageBox.Show("DEBE SELECCIONAR UN AMBIENTE DE LA LISTA", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If Validaciones() = True Then
                If MessageBox.Show("DESEA ACTUALIZAR ESTE PABELLON", "INFORMACIÓN", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                    Dim boolGuardar As Boolean = oPDMAmbienteBO.ActualizarAmbiente(oPDMAmbienteBE)
                    MessageBox.Show("PABELLON ACTUALIZADO CORRECTAMENTE", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CargarTablaAmbiente()
                    CargarCombosAmbiente()
                    AcivarCajas(False, False, False, False, False, False)
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

    Private Sub cboPisos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboPisos.KeyPress
        If (btnGuardar.Visible) Then
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                GuardarAmbiente()
            End If
        ElseIf btnEditar.Visible Then
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                EditarAmbiente()
            End If
        End If
    End Sub

#End Region

#Region "Validaciones del Formulario:frmIngresarAmbientesPDM"
    Private Function Validaciones() As Boolean

        If txtAmbiente.Text = String.Empty Then
            MessageBox.Show("DEBE INGRESAR DETALLE", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtAmbiente.Focus()
            Return False
        End If

        If cboPabellon.SelectedIndex = 0 Then
            MessageBox.Show("DEBE INGRESAR PABELLON", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboPabellon.Focus()
            Return False
        End If

        If cboPisos.SelectedIndex = 0 Then
            MessageBox.Show("DEBE INGRESAR PISO", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboPisos.Focus()
            Return False
        End If

        Return True
    End Function

#End Region

#Region "Metodos de Formulario:frmIngresarAmbientesPDM"

    Private Sub AcivarCajas(BolActivar As Boolean, BolAmbientes As Boolean, BolPisos As Boolean, bolEnaChk As Boolean, lBuscar As Boolean, TBuscar As Boolean)
        txtAmbiente.Enabled = BolActivar
        cboPabellon.Enabled = BolAmbientes
        cboPisos.Enabled = BolPisos
        chkActivar.Enabled = bolEnaChk
        lblBuscar.Enabled = lBuscar
        txtBuscar.Enabled = TBuscar
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
        txtAmbiente.Text = String.Empty
    End Sub

    Private Sub TapCajas()
        txtAmbiente.Focus()
        txtAmbiente.TabIndex = 1
        cboPabellon.TabIndex = 2
        cboPisos.TabIndex = 3
    End Sub

#End Region



End Class