Imports PDM.LogicaNegocio
Imports PDM.Entidades

Public Class frmConservacion
    Private idConservacion As String
    Private encontrado As Integer = 0

#Region "Eventos de Formulario:frmConservacionPDM"

    Private Sub CargarTablaCondicion()
        Dim oPDMConservacionBO As New PDMConservacionBO()
        dgvConservacion.DataSource = oPDMConservacionBO.TableConservacion
        dgvConservacion.AutoResizeColumns()
    End Sub

    Private Sub frmConservacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        GuardarConservacion()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        EditarConservacion()
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
                    Dim oPDMConservacionBO As New PDMConservacionBO()
                    dgvConservacion.DataSource = oPDMConservacionBO.ObtenerTableXConservacion(txtBuscar.Text.Trim)
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

    Private Sub dgvConservacion_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvConservacion.CellClick
        If (btnEditar.Visible) Then
            Dim index As Integer = e.RowIndex
            If index < 0 Then
                Return
            Else
                Dim selectedRow As DataGridViewRow = dgvConservacion.Rows(index)
                idConservacion = Convert.ToInt32(selectedRow.Cells(0).Value.ToString())
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
                GuardarConservacion()
            End If
        ElseIf btnEditar.Visible Then
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                EditarConservacion()
            End If
        End If
    End Sub

    Public Sub GuardarConservacion()
        Dim oPDMConservacionBO As New PDMConservacionBO()
        Dim oPDMConservacionBE As New PDMConservacionBE
        oPDMConservacionBE.idLogin = SessionUsuario.idUsuario
        oPDMConservacionBE.Detalle = txtDetalle.Text.Trim
        oPDMConservacionBE.FechaIngreso = DateTime.Now
        oPDMConservacionBE.FechaModificacion = DateTime.Now
        chkActivar.Checked = True
        If (chkActivar.Checked) Then
            oPDMConservacionBE.Estado = 1
        End If

        If txtDetalle.Text = String.Empty Then
            MessageBox.Show("DEBE INGRESAR DETALLE", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtDetalle.Focus()
        Else
            If MessageBox.Show("DESEA REGISTRAR ESTA CONSERVACION", "INFORMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Dim boolGuardar As Boolean = oPDMConservacionBO.InsertarConservacion(oPDMConservacionBE)
                MessageBox.Show("CONSERVACION REGISTRADA CORRECTAMENTE", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarTablaCondicion()
                AcivarCajas(False, False)
                LimpiarCajas()
                ActivarBotones(True, False, False, True, False, False)
            Else
                Return
            End If
        End If
    End Sub

    Public Sub EditarConservacion()
        Dim oPDMConservacionBO As New PDMConservacionBO()
        Dim oPDMConservacionBE As New PDMConservacionBE
        oPDMConservacionBE.idConservacion = idConservacion
        oPDMConservacionBE.idLogin = SessionUsuario.idUsuario
        oPDMConservacionBE.Detalle = txtDetalle.Text.Trim
        oPDMConservacionBE.FechaModificacion = DateTime.Now
        If (chkActivar.Checked) Then
            oPDMConservacionBE.Estado = 1
        Else
            oPDMConservacionBE.Estado = 0
        End If

        If txtDetalle.Text = String.Empty Or idConservacion = "" Then
            MessageBox.Show("DEBE SELECCIONAR UNA CONDICION DE LA LISTA", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtDetalle.Focus()
        Else
            If MessageBox.Show("DESEA ACTUALIZAR ESTA CONSERVACION", "INFORMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Dim boolGuardar As Boolean = oPDMConservacionBO.ActualizarConservacion(oPDMConservacionBE)
                MessageBox.Show("CONSERVACION ACTUALIZADA CORRECTAMENTE", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarTablaCondicion()
                AcivarCajas(False, False)
                LimpiarCajas()
                ActivarBotones(True, False, False, True, False, False)
            Else
                Return
            End If
        End If
    End Sub

#End Region

#Region "Metodos de Formulario:frmConservacionPDM"
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