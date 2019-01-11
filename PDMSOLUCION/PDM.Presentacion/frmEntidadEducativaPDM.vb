Imports PDM.LogicaNegocio
Imports PDM.Entidades

Public Class frmEntidadEducativaPDM
    Private idEntidad As String
    Private encontrado As Integer = 0

#Region "Eventos de Formulario:frmEntidadEducativaPDM"

    Private Sub frmEntidadEducativaPDM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AcivarCajas(False, False)
        LimpiarCajas()
        ActivarBotones(True, False, False, True, False, False)
        chkActivar.Checked = True
        CargarTablaEntidad()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        AcivarCajas(True, False)
        LimpiarCajas()
        ActivarBotones(False, True, False, False, True, False)
        txtEntidad.Focus()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        GuardarEntidad()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        ActualizarEntidad()
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
        CargarTablaEntidad()
        chkActivar.Checked = True
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If (btnEditar.Visible) Then
            If (encontrado = 0) Then
                If txtBuscar.Text.Length >= 0 Then
                    Dim oPDMEntidadBO As New PDMEntidadBO()
                    dtgListarEntidad.DataSource = oPDMEntidadBO.ObtenerTableXEntidad(txtBuscar.Text.Trim)
                    'encontrado = dtgListarEntidad.RowCount
                End If
            Else
                If (txtBuscar.Text = String.Empty) Then
                    CargarTablaEntidad()
                    encontrado = 0
                End If
            End If
        End If
    End Sub

    Private Sub dtgListarEntidad_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgListarEntidad.CellClick, dtgListarEntidad.CellContentClick
        If (btnEditar.Visible) Then
            Dim index As Integer = e.RowIndex
            If index < 0 Then
                Return
            Else
                Dim selectedRow As DataGridViewRow = dtgListarEntidad.Rows(index)
                idEntidad = Convert.ToInt32(selectedRow.Cells(0).Value.ToString())
                txtEntidad.Text = Convert.ToString(selectedRow.Cells(1).Value.ToString())

                If Convert.ToString(selectedRow.Cells(2).Value) = "ACTIVO" Then
                    chkActivar.Checked = True
                Else
                    chkActivar.Checked = False
                End If
                txtBuscar.Text = String.Empty
                AcivarCajas(True, True)
                txtEntidad.Focus()
                'CargarTablaEntidad()
            End If
        End If
    End Sub

    Private Sub CargarTablaEntidad()
        Dim oPDMEntidadBO As New PDMEntidadBO()
        dtgListarEntidad.DataSource = oPDMEntidadBO.TableEntidades
        dtgListarEntidad.AutoResizeColumns()
    End Sub

    Public Sub GuardarEntidad()
        Dim oPDMEntidadBO As New PDMEntidadBO()
        Dim oPDMEntidadBE As New PDMEntidadBE
        oPDMEntidadBE.idLogin = SessionUsuario.idUsuario
        oPDMEntidadBE.Detalle = txtEntidad.Text.Trim
        oPDMEntidadBE.fechaIngreso = DateTime.Now
        oPDMEntidadBE.fechaModificacion = DateTime.Now
        chkActivar.Checked = True
        If (chkActivar.Checked) Then
            oPDMEntidadBE.estado = 1
        End If

        If txtEntidad.Text = String.Empty Then
            MessageBox.Show("DEBE INGRESAR DETALLE", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtEntidad.Focus()
        Else
            If MessageBox.Show("DESEA REGISTRAR ESTA ENTIDAD", "INFORMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Dim boolGuardar As Boolean = oPDMEntidadBO.InsertarEntidad(oPDMEntidadBE)
                MessageBox.Show("ENTIDAD REGISTRADA CORRECTAMENTE", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarTablaEntidad()
                AcivarCajas(False, False)
                LimpiarCajas()
                ActivarBotones(True, False, False, True, False, False)
            Else
                Return
            End If
        End If
    End Sub

    Public Sub ActualizarEntidad()
        Dim oPDMEntidadBO As New PDMEntidadBO()
        Dim oPDMEntidadBE As New PDMEntidadBE
        oPDMEntidadBE.idEntidad = idEntidad
        oPDMEntidadBE.idLogin = SessionUsuario.idUsuario
        oPDMEntidadBE.Detalle = txtEntidad.Text.Trim
        oPDMEntidadBE.fechaModificacion = DateTime.Now
        If (chkActivar.Checked) Then
            oPDMEntidadBE.estado = 1
        Else
            oPDMEntidadBE.estado = 0
        End If

        If txtEntidad.Text = String.Empty Or idEntidad = "" Then
            MessageBox.Show("DEBE SELECCIONAR UNA ENTIDAD DE LA LISTA", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtEntidad.Focus()
        Else
            If MessageBox.Show("DESEA ACTUALIZAR ESTA ENTIDAD", "INFORMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Dim boolGuardar As Boolean = oPDMEntidadBO.ActualizarEntidad(oPDMEntidadBE)
                MessageBox.Show("ENTIDAD ACTUALIZADA CORRECTAMENTE", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarTablaEntidad()
                AcivarCajas(False, False)
                LimpiarCajas()
                ActivarBotones(True, False, False, True, False, False)
            Else
                Return
            End If
        End If
    End Sub

    Private Sub txtEntidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEntidad.KeyPress
        If (btnGuardar.Visible) Then
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                GuardarEntidad()
            End If
        ElseIf btnEditar.Visible Then
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                ActualizarEntidad()
            End If
        End If
    End Sub

#End Region

#Region "Metodos de Formulario:frmEntidadEducativaPDM"
    Private Sub AcivarCajas(BolActivar As Boolean, bolEnaChk As Boolean)
        txtEntidad.Enabled = BolActivar
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
        txtEntidad.Text = String.Empty

    End Sub
#End Region

End Class