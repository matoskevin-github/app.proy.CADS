Imports PDM.LogicaNegocio
Imports PDM.Entidades

Public Class frmIngresarPabellones

    Private idPabellon As String
    Private encontrado As Integer = 0

#Region "Eventos de Formulario:frmIngresarPabellonesPDM"

    Private Sub CargarTablaPabellon()
        Dim oPDMPabellonBO As New PDMPabellonBO()
        dgvListarPabellones.DataSource = oPDMPabellonBO.TablePabellones
        dgvListarPabellones.AutoResizeColumns()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        AcivarCajas(True, True, True, False, False, False)
        LimpiarCajas()
        ActivarBotones(False, True, False, False, True, False, False)
        TapCajas()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        GuardarPabellon()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        EditarPabellon()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        AcivarCajas(False, False, False, False, True, True)
        LimpiarCajas()
        ActivarBotones(False, False, True, False, True, True, True)
        txtBuscar.Focus()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        AcivarCajas(False, False, False, False, False, False)
        LimpiarCajas()
        ActivarBotones(True, False, False, True, False, False, False)
        chkActivar.Checked = True
        CargarTablaPabellon()
    End Sub

    Private Sub frmIngresarPabellones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chkActivar.Checked = True
        AcivarCajas(False, False, False, False, False, False)
        LimpiarCajas()
        ActivarBotones(True, False, False, True, False, False, False)
        CargarTablaPabellon()
    End Sub

    Private Sub dgvListarPabellones_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListarPabellones.CellClick
        If (btnEditar.Visible) Then
            Dim index As Integer = e.RowIndex
            If index < 0 Then
                Return
            Else
                Dim selectedRow As DataGridViewRow = dgvListarPabellones.Rows(index)

                idPabellon = Convert.ToInt32(selectedRow.Cells(0).Value.ToString())
                txtPabellon.Text = Convert.ToString(selectedRow.Cells(1).Value.ToString())
                nudPisos.Value = Convert.ToInt32(selectedRow.Cells(2).Value)
                nudAmbientes.Value = Convert.ToInt32(selectedRow.Cells(3).Value)

                If Convert.ToString(selectedRow.Cells(4).Value) = "ACTIVO" Then
                    chkActivar.Checked = True
                Else
                    chkActivar.Checked = False
                End If

                txtBuscar.Text = String.Empty
                AcivarCajas(True, True, True, True, True, True)
                TapCajas()
                'CargarTablaPabellon()
            End If
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If (btnEditar.Visible) Then
            If (encontrado = 0) Then
                If txtBuscar.Text.Length >= 0 Then
                    Dim oPDMPabellonBO As New PDMPabellonBO()
                    dgvListarPabellones.DataSource = oPDMPabellonBO.ObtenerTableXPabellon(txtBuscar.Text.Trim)
                    'encontrado = dtgListarEntidad.RowCount
                End If
            Else
                If (txtBuscar.Text = String.Empty) Then
                    CargarTablaPabellon()
                    encontrado = 0
                End If
            End If
        End If
    End Sub

    Public Sub GuardarPabellon()
        Dim oPDMPabellonBO As New PDMPabellonBO()
        Dim oPDMPabellonBE As New PDMPabellonBE
        oPDMPabellonBE.idLogin = SessionUsuario.idUsuario
        oPDMPabellonBE.NomPabellon = txtPabellon.Text.Trim
        oPDMPabellonBE.CantPisos = nudPisos.Value
        oPDMPabellonBE.CantAmbientes = nudAmbientes.Value
        oPDMPabellonBE.FechaIngreso = DateTime.Now
        oPDMPabellonBE.FechaModificacion = DateTime.Now
        chkActivar.Checked = True
        If (chkActivar.Checked) Then
            oPDMPabellonBE.Estado = 1
        End If

        If Validaciones() = True Then
            If MessageBox.Show("DESEA REGISTRAR ESTE PABELLON", "INFORMACIÓN", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                Dim boolGuardar As Boolean = oPDMPabellonBO.InsertarPabellon(oPDMPabellonBE)
                MessageBox.Show("PABELON REGISTRADO CORRECTAMENTE", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarTablaPabellon()
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

    Public Sub EditarPabellon()
        Dim oPDMPabellonBO As New PDMPabellonBO()
        Dim oPDMPabellonBE As New PDMPabellonBE
        oPDMPabellonBE.idPabellon = idPabellon
        oPDMPabellonBE.idLogin = SessionUsuario.idUsuario
        oPDMPabellonBE.NomPabellon = txtPabellon.Text.Trim
        oPDMPabellonBE.CantPisos = nudPisos.Value
        oPDMPabellonBE.CantAmbientes = nudAmbientes.Value
        oPDMPabellonBE.FechaModificacion = DateTime.Now
        If (chkActivar.Checked) Then
            oPDMPabellonBE.Estado = 1
        Else
            oPDMPabellonBE.Estado = 0
        End If

        If idPabellon = "" Then
            MessageBox.Show("DEBE SELECCIONAR UN PABELLON DE LA LISTA", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If Validaciones() = True Then
                If MessageBox.Show("DESEA ACTUALIZAR ESTE PABELLON", "INFORMACIÓN", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                    Dim boolGuardar As Boolean = oPDMPabellonBO.ActualizarPabellon(oPDMPabellonBE)
                    MessageBox.Show("PABELLON ACTUALIZADO CORRECTAMENTE", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CargarTablaPabellon()
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

    Private Sub nudAmbientes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nudAmbientes.KeyPress
        If (btnGuardar.Visible) Then
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                GuardarPabellon()
            End If
        ElseIf btnEditar.Visible Then
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                EditarPabellon()
            End If
        End If
    End Sub

#End Region

#Region "Metodos de Formulario:frmIngresarPabellonesPDM"
    Private Sub AcivarCajas(BolActivar As Boolean, BolPisos As Boolean, BolAmbientes As Boolean, bolEnaChk As Boolean, lBuscar As Boolean, TBuscar As Boolean)
        txtPabellon.Enabled = BolActivar
        nudPisos.Enabled = BolPisos
        nudAmbientes.Enabled = BolAmbientes
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
        txtPabellon.Text = String.Empty
        nudPisos.Value = 0
        nudAmbientes.Value = 0
    End Sub

    Private Sub TapCajas()
        txtPabellon.Focus()
        txtPabellon.TabIndex = 1
        nudPisos.TabIndex = 2
        nudAmbientes.TabIndex = 3
    End Sub
#End Region

#Region "Validaciones del Formulario:frmIngresarPabellonesPDM"
    Private Function Validaciones() As Boolean

        If txtPabellon.Text = String.Empty Then
            MessageBox.Show("DEBE INGRESAR DETALLE", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPabellon.Focus()
            Return False
        End If

        If nudPisos.Value = 0 Then
            MessageBox.Show("DEBE INGRESAR CANTIDAD DE PISOS", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            nudPisos.Focus()
            Return False
        End If

        If nudAmbientes.Value = 0 Then
            MessageBox.Show("DEBE INGRESAR CANTIDAD DE AMBIENTES", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            nudAmbientes.Focus()
            Return False
        End If

        Return True
    End Function
#End Region

End Class