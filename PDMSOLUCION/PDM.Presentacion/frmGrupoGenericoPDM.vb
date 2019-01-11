Imports PDM.LogicaNegocio
Imports PDM.Entidades

Public Class frmGrupoGenericoPDM

    Private idGrupoGenerico As String
    Private encontrado As Integer = 0

#Region "Eventos de Formulario:frmGrupoGenericoPDM"

    Private Sub CargarTablaGrupoGenerico()
        Dim oPDMGrupoGenericoBO As New PDMGrupoGenericoBO()
        dgvGrupoGenerico.DataSource = oPDMGrupoGenericoBO.TableGrupoGenerico
        dgvGrupoGenerico.AutoResizeColumns()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        AcivarCajas(True, False)
        LimpiarCajas()
        TapCajas()
        ActivarBotones(False, True, False, False, True, False)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        GuardarGrupoGenerico()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        EditarGrupoGenerico()
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
        CargarTablaGrupoGenerico()
        chkActivar.Checked = True
    End Sub

    Private Sub frmGrupoGenericoPDM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AcivarCajas(False, False)
        LimpiarCajas()
        ActivarBotones(True, False, False, True, False, False)
        chkActivar.Checked = True
        CargarTablaGrupoGenerico()
    End Sub

    Private Sub dgvGrupoGenerico_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGrupoGenerico.CellClick
        If (btnEditar.Visible) Then
            Dim index As Integer = e.RowIndex
            If index < 0 Then
                Return
            Else
                Dim selectedRow As DataGridViewRow = dgvGrupoGenerico.Rows(index)
                idGrupoGenerico = Convert.ToInt32(selectedRow.Cells(0).Value.ToString())
                txtCodigo.Text = Convert.ToString(selectedRow.Cells(1).Value.ToString())
                txtDetalle.Text = Convert.ToString(selectedRow.Cells(2).Value.ToString())

                If Convert.ToString(selectedRow.Cells(3).Value) = "ACTIVO" Then
                    chkActivar.Checked = True
                Else
                    chkActivar.Checked = False
                End If
                txtBuscar.Text = String.Empty
                AcivarCajas(True, True)
                TapCajas()
                txtDetalle.Focus()
                'CargarTablaEntidad()
            End If
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If (btnEditar.Visible) Then
            If (encontrado = 0) Then
                If txtBuscar.Text.Length >= 0 Then
                    Dim oPDMGrupoGenericoBO As New PDMGrupoGenericoBO()
                    dgvGrupoGenerico.DataSource = oPDMGrupoGenericoBO.ObtenerTableXGrupoGenerico(txtBuscar.Text.Trim)
                    'encontrado = dtgListarEntidad.RowCount
                End If
            Else
                If (txtBuscar.Text = String.Empty) Then
                    CargarTablaGrupoGenerico()
                    encontrado = 0
                End If
            End If
        End If
    End Sub

    Private Sub txtDetalle_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDetalle.KeyPress
        If (btnGuardar.Visible) Then
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                GuardarGrupoGenerico()
            End If
        ElseIf btnEditar.Visible Then
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                EditarGrupoGenerico()
            End If
        End If
    End Sub

    Public Sub GuardarGrupoGenerico()
        Dim oPDMGrupoGenericoBO As New PDMGrupoGenericoBO()
        Dim oPDMGrupoGenericoBE As New PDMGrupoGenericoBE
        oPDMGrupoGenericoBE.idLogin = SessionUsuario.idUsuario
        oPDMGrupoGenericoBE.Codigo = txtCodigo.Text.Trim
        oPDMGrupoGenericoBE.Detalle = txtDetalle.Text.Trim
        oPDMGrupoGenericoBE.FechaIngreso = DateTime.Now
        oPDMGrupoGenericoBE.FechaModificacion = DateTime.Now
        chkActivar.Checked = True
        If (chkActivar.Checked) Then
            oPDMGrupoGenericoBE.Estado = 1
        End If

        If Validaciones() = True Then
            If MessageBox.Show("DESEA REGISTRAR NUEVO GRUPO GENERICO", "INFORMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Dim boolGuardar As Boolean = oPDMGrupoGenericoBO.InsertarGrupoGenerico(oPDMGrupoGenericoBE)
                MessageBox.Show("GRUPO GENERICO REGISTRADO CORRECTAMENTE", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarTablaGrupoGenerico()
                AcivarCajas(False, False)
                LimpiarCajas()
                ActivarBotones(True, False, False, True, False, False)
            Else
                Return
            End If
        Else
            Return
        End If
    End Sub

    Public Sub EditarGrupoGenerico()
        Dim oPDMGrupoGenericoBO As New PDMGrupoGenericoBO()
        Dim oPDMGrupoGenericoBE As New PDMGrupoGenericoBE
        oPDMGrupoGenericoBE.idGrupoGenerico = idGrupoGenerico
        oPDMGrupoGenericoBE.idLogin = SessionUsuario.idUsuario
        oPDMGrupoGenericoBE.Codigo = txtCodigo.Text.Trim
        oPDMGrupoGenericoBE.Detalle = txtDetalle.Text.Trim
        oPDMGrupoGenericoBE.FechaModificacion = DateTime.Now
        If (chkActivar.Checked) Then
            oPDMGrupoGenericoBE.Estado = 1
        Else
            oPDMGrupoGenericoBE.Estado = 0
        End If

        If idGrupoGenerico = "" Then
            MessageBox.Show("DEBE SELECCIONAR UN GRUPO GENERICO DE LA LISTA", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If Validaciones() = True Then
                If MessageBox.Show("DESEA ACTUALIZAR ESTE GRUPO GENERICO", "INFORMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    Dim boolGuardar As Boolean = oPDMGrupoGenericoBO.ActualizarGrupoGenerico(oPDMGrupoGenericoBE)
                    MessageBox.Show("GRUPO GENERICO ACTUALIZADO CORRECTAMENTE", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CargarTablaGrupoGenerico()
                    AcivarCajas(False, False)
                    LimpiarCajas()
                    ActivarBotones(True, False, False, True, False, False)
                Else
                    Return
                End If
            Else
                Return
            End If
        End If
    End Sub
#End Region

#Region "Metodos de Formulario:frmGrupoGenericoPDM"

    Private Sub AcivarCajas(BolActivar As Boolean, bolEnaChk As Boolean)
        txtDetalle.Enabled = BolActivar
        txtCodigo.Enabled = BolActivar
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
        txtCodigo.Text = String.Empty
        txtDetalle.Text = String.Empty
    End Sub

    Private Sub TapCajas()
        txtCodigo.Focus()
        txtCodigo.TabIndex = 1
        txtDetalle.TabIndex = 2
    End Sub
#End Region

#Region "Validaciones del Formulario:frmGrupoGenericoPDM"

    Private Function Validaciones() As Boolean

        If txtCodigo.Text = String.Empty Then
            MessageBox.Show("DEBE INGRESAR CODIGO", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtDetalle.Focus()
            Return False
        End If

        If txtDetalle.Text = String.Empty Then
            MessageBox.Show("DEBE INGRESAR DETALLE", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtDetalle.Focus()
            Return False
        End If

        Return True
    End Function

#End Region

End Class