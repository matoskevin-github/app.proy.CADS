Imports PDM.LogicaNegocio
Imports PDM.Entidades

Public Class frmIngresarPisosPDM
    Private idPisos As String
    Private encontrado As Integer = 0

#Region "Eventos de Formulario:frmIngresarPisosPDM"

    Private Sub frmIngresarPisosPDM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chkActivar.Checked = True
        AcivarCajas(False, False, False, False)
        LimpiarCajas()
        ActivarBotones(True, False, False, True, False, False, False)
        CargarTablaPisos()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        AcivarCajas(True, False, False, False)
        LimpiarCajas()
        ActivarBotones(False, True, False, False, True, False, False)
        txtNombre.Focus()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        GuardarPisos()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        EditarPisos()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        AcivarCajas(False, False, True, True)
        LimpiarCajas()
        ActivarBotones(False, False, True, False, True, True, True)
        txtBuscar.Focus()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        AcivarCajas(False, False, False, False)
        LimpiarCajas()
        ActivarBotones(True, False, False, True, False, False, False)
        chkActivar.Checked = True
        CargarTablaPisos()
    End Sub

    Private Sub CargarTablaPisos()
        Dim oPDMPisosBO As New PDMPisosBO()
        dgvListarPisos.DataSource = oPDMPisosBO.TablePisos
        dgvListarPisos.AutoResizeColumns()
    End Sub

    Private Sub dgvListarPisos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListarPisos.CellClick
        If (btnEditar.Visible) Then
            Dim index As Integer = e.RowIndex
            If index < 0 Then
                Return
            Else
                Dim selectedRow As DataGridViewRow = dgvListarPisos.Rows(index)

                idPisos = Convert.ToInt32(selectedRow.Cells(0).Value.ToString())
                txtNombre.Text = Convert.ToString(selectedRow.Cells(1).Value.ToString())

                If Convert.ToString(selectedRow.Cells(2).Value) = "ACTIVO" Then
                    chkActivar.Checked = True
                Else
                    chkActivar.Checked = False
                End If

                txtBuscar.Text = String.Empty
                AcivarCajas(True, True, True, True)
                txtNombre.Focus()
                'CargarTablaPabellon()
            End If
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If (btnEditar.Visible) Then
            If (encontrado = 0) Then
                If txtBuscar.Text.Length >= 0 Then
                    Dim oPDMPisosBO As New PDMPisosBO()
                    dgvListarPisos.DataSource = oPDMPisosBO.ObtenerTableXPisos(txtBuscar.Text.Trim)
                    'encontrado = dtgListarEntidad.RowCount
                End If
            Else
                If (txtBuscar.Text = String.Empty) Then
                    CargarTablaPisos()
                    encontrado = 0
                End If
            End If
        End If
    End Sub

    Public Sub GuardarPisos()
        Dim oPDMPisosBO As New PDMPisosBO
        Dim oPDMPisosBE As New PDMPisosBE
        oPDMPisosBE.idLogin = SessionUsuario.idUsuario
        oPDMPisosBE.NomPiso = txtNombre.Text.Trim
        oPDMPisosBE.FechaIngreso = DateTime.Now
        oPDMPisosBE.FechaModificacion = DateTime.Now
        chkActivar.Checked = True
        If (chkActivar.Checked) Then
            oPDMPisosBE.Estado = 1
        End If

        If Validaciones() = True Then
            If MessageBox.Show("DESEA REGISTRAR ESTE PISO", "INFORMACIÓN", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                Dim boolGuardar As Boolean = oPDMPisosBO.InsertarPisos(oPDMPisosBE)
                MessageBox.Show("PISO REGISTRADO CORRECTAMENTE", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarTablaPisos()
                AcivarCajas(False, False, False, False)
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

    Public Sub EditarPisos()
        Dim oPDMPisosBO As New PDMPisosBO
        Dim oPDMPisosBE As New PDMPisosBE
        oPDMPisosBE.idPisos = idPisos
        oPDMPisosBE.idLogin = SessionUsuario.idUsuario
        oPDMPisosBE.NomPiso = txtNombre.Text.Trim
        oPDMPisosBE.FechaModificacion = DateTime.Now
        If (chkActivar.Checked) Then
            oPDMPisosBE.Estado = 1
        Else
            oPDMPisosBE.Estado = 0
        End If

        If txtNombre.Text = "" Or idPisos = "" Then
            MessageBox.Show("DEBE SELECCIONAR UN PISO DE LA LISTA", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNombre.Focus()
        Else
            If MessageBox.Show("DESEA ACTUALIZAR ESTE PISO", "INFORMACIÓN", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                Dim boolGuardar As Boolean = oPDMPisosBO.ActualizarPisos(oPDMPisosBE)
                MessageBox.Show("PISO ACTUALIZADO CORRECTAMENTE", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarTablaPisos()
                AcivarCajas(False, False, False, False)
                LimpiarCajas()
                ActivarBotones(True, False, False, True, False, False, False)
                chkActivar.Checked = True
            Else
                Return
            End If
        End If
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If (btnGuardar.Visible) Then
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                GuardarPisos()
            End If
        ElseIf btnEditar.Visible Then
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                EditarPisos()
            End If
        End If
    End Sub

#End Region

#Region "Metodos de Formulario:frmIngresarPisosPDM"
    Private Sub AcivarCajas(BolActivar As Boolean, bolEnaChk As Boolean, lBuscar As Boolean, TBuscar As Boolean)
        txtNombre.Enabled = BolActivar
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
        txtNombre.Text = String.Empty
    End Sub
#End Region

#Region "Validaciones del Formulario:frmIngresarPISOSPDM"

    Private Function Validaciones() As Boolean

        If txtNombre.Text = String.Empty Then
            MessageBox.Show("DEBE INGRESAR DETALLE", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNombre.Focus()
            Return False
        End If

        Return True

    End Function

#End Region


End Class