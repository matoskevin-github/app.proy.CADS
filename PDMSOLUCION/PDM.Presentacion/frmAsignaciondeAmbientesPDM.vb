Imports PDM.LogicaNegocio
Imports PDM.Entidades

Public Class frmAsignaciondeAmbientesPDM

#Region "Eventos de Formulario:frmAsignaciondeAmbientesPDM"
    Private idxAmbienteCargo As Integer

    Private Sub frmAsignaciondeAmbientesPDM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActivarCajas(False, False)
        ActivarBotones(True, False, True, True)
        LimpiarCajas()
        CargaResponsableArray()
        dgvAmbientesCargo.DataSource = dsAmbientesCargo.Tables(0)

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        LimpiarCajas()
        ActivarCajas(True, False)
        ActivarBotones(True, False, False, True)
        ActivarBotones2(True, True, False, False)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        LimpiarCajas()
        ActivarCajas(True, False)
        ActivarBotones(False, True, False, True)
        ActivarBotones2(True, True, True, True)
        btnGrabar.Text = "Editar"
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        LimpiarCajas()
        ActivarCajas(False, False)
        ActivarBotones(True, False, True, True)
    End Sub

    Public Sub CargarAmbientes()
        Dim oPDMAmbientexResponsableBO As New PDMAmbiente_ResponsableBO()
        dgvAmbientes.DataSource = oPDMAmbientexResponsableBO.TableAmbientes
        dgvAmbientes.AutoResizeColumns()
    End Sub

    Private Sub txtResponsable_KeyDown(sender As Object, e As KeyEventArgs) Handles txtResponsable.KeyDown
        If btnNuevo.Visible = True Then
            If e.KeyData = Keys.Enter Then
                Dim strCadena As String = Me.txtResponsable.Text
                If (strCadena <> String.Empty) Then
                    Dim strArray As String() = strCadena.Split("|")
                    If (strArray.Length = 2) Then
                        txtResponsable.Text = strCadena
                        ActivarCajas(False, True)
                        CargarAmbientes()
                        txtAmbiente.Focus()
                        dgvAmbientesCargo.DataSource = dsAmbientesCargo.Tables(0)
                    End If
                End If
            End If
        ElseIf btnNuevo.Visible = False Then
            If e.KeyData = Keys.Enter Then
                Dim oPDMAmbientexResponsableBO As New PDMAmbiente_ResponsableBO()
                Dim strCadena As String = Me.txtResponsable.Text
                If (strCadena <> String.Empty) Then
                    Dim strArray As String() = strCadena.Split("|")
                    If (strArray.Length = 2) Then
                        txtResponsable.Text = strCadena
                        ActivarCajas(False, True)
                        CargarAmbientes()
                        txtAmbiente.Focus()
                        Dim strResponsable As String = txtResponsable.Text
                        Dim strCodResponsable As String = strResponsable.Split("|")(1).Substring(5).ToString()
                        dgvAmbientesCargo.DataSource = oPDMAmbientexResponsableBO.ObtenerResponsablexAmbiente(Convert.ToInt32(strCodResponsable))
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub CargaResponsableArray()
        Dim oPDMAmbientexResponsableBO As New PDMAmbiente_ResponsableBO()
        Dim autoComplete As New AutoCompleteStringCollection()
        oPDMAmbientexResponsableBO.getCollectionResponsable(autoComplete)
        txtResponsable.AutoCompleteCustomSource = autoComplete
    End Sub

    Private Sub txtAmbiente_TextChanged(sender As Object, e As EventArgs) Handles txtAmbiente.TextChanged
        If txtAmbiente.Text.Length >= 0 Then
            Dim oPDMAmbientexResponsableBO As New PDMAmbiente_ResponsableBO()
            dgvAmbientes.DataSource = oPDMAmbientexResponsableBO.ObtenerTableXAmbiente(txtAmbiente.Text)
        End If
    End Sub

    Private Sub dgvAmbientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAmbientes.CellClick
        Dim idx As Integer = dgvAmbientes.CurrentRow.Index
        Dim codAmbiente As String = dgvAmbientes.Item(0, idx).Value
        If (idx >= 0 And codAmbiente <> String.Empty) Then
            dgvAmbientes.Rows(idx).Selected = True
        End If

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If (dgvAmbientes.RowCount = 1) Then
          

            Dim strCodigo As String = dgvAmbientes.Item(0, 0).Value
            Dim strAmbiente As String = dgvAmbientes.Item(1, 0).Value
            Dim strPabellon As String = dgvAmbientes.Item(2, 0).Value
            Dim strPiso As String = dgvAmbientes.Item(3, 0).Value
            Dim boolAgregado As Boolean = True

            'VALIDAR REPETIDO
            For Each row As DataRow In dsAmbientesCargo.Tables(0).Rows
                If row("Codigo") = strCodigo And row("Ambiente") = strAmbiente Then
                    MsgBox("NO AGREGAR DOS VECES")
                    boolAgregado = False
                    Exit For
                End If
            Next

            If boolAgregado Then
                dsAmbientesCargo.Tables(0).Rows.Add(strCodigo, strAmbiente, strPabellon, strPiso)
                ActivarBotones2(True, True, True, True)
                txtAmbiente.Focus()
            End If

          
        End If

    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Dim oPDMAmbientexResponsableBO As New PDMAmbiente_ResponsableBO()
        Dim oPDMAmbientesxResponsableBE As New PDMAmbiente_ResponsableBE
        Dim strResponsable As String = txtResponsable.Text
        Dim strCodResponsable As String = strResponsable.Split("|")(1).Substring(5).ToString()
        If (dgvAmbientesCargo.RowCount > 0) Then
            For Each row As DataRow In dsAmbientesCargo.Tables(0).Rows
                oPDMAmbientesxResponsableBE.idResponsable = Convert.ToInt32(strCodResponsable)
                oPDMAmbientesxResponsableBE.idAmbiente = Convert.ToInt32(row("Codigo"))
                oPDMAmbientesxResponsableBE.idLogin = Convert.ToInt32(SessionUsuario.idUsuario)
                oPDMAmbientesxResponsableBE.FechaIngreso = DateTime.Now
                oPDMAmbientesxResponsableBE.FechaModificacion = DateTime.Now
                oPDMAmbientexResponsableBO.InsertarAmbiente_Responsable(oPDMAmbientesxResponsableBE)
            Next row
            MessageBox.Show("AMBIETES GUARDADOS CORRECTAMENTE", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnCancelar2_Click(sender As Object, e As EventArgs) Handles btnCancelar2.Click
        txtAmbiente.Text = String.Empty
        CargarAmbientes()
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        If (dgvAmbientesCargo.RowCount > 0) Then
            Dim selectedRow As DataGridViewRow = dgvAmbientesCargo.Rows(idxAmbienteCargo)
            Dim strAmbiente As String = selectedRow.Cells(0).Value.ToString()
            For Each row As DataRow In dsAmbientesCargo.Tables(0).Rows
                If row("Codigo") = strAmbiente Then
                    dsAmbientesCargo.Tables(0).Rows.Remove(row)
                    Exit For
                End If
            Next
            dgvAmbientesCargo.DataSource = dsAmbientesCargo.Tables(0)
        End If
    End Sub

    Private Sub dgvAmbientesCargo_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAmbientesCargo.CellClick
        Dim idx As Integer = dgvAmbientesCargo.CurrentRow.Index
        Dim codAmbiente As String = dgvAmbientesCargo.Item(0, idx).Value
        If (idx >= 0 And codAmbiente <> String.Empty) Then
            dgvAmbientesCargo.Rows(idx).Selected = True
            idxAmbienteCargo = idx
        End If
    End Sub

#End Region

#Region "Metodos de Formulario:frmAsignaciondeAmbienesPDM"

    Private Sub ActivarCajas(bolResponsable As Boolean, bolAmbiente As Boolean)

        txtResponsable.Enabled = bolResponsable
        txtAmbiente.Enabled = bolAmbiente
    End Sub

    Private Sub ActivarBotones(BolNuevo As Boolean, BolEditar As Boolean, BolBuscar As Boolean, BolCancelar As Boolean)
        btnNuevo.Visible = BolNuevo
        btnBuscar.Visible = BolBuscar
        btnCancelar.Visible = BolCancelar
    End Sub

    Private Sub LimpiarCajas()
        txtAmbiente.Text = String.Empty
        txtResponsable.Text = String.Empty
    End Sub

    Private Sub ActivarBotones2(BolAgregar As Boolean, BolCancelar As Boolean, BolGrabar As Boolean, BolQuitar As Boolean)
        btnAgregar.Enabled = BolAgregar
        btnCancelar2.Enabled = BolCancelar
        btnGrabar.Enabled = BolGrabar
        btnQuitar.Enabled = BolQuitar
    End Sub

    

#End Region


   
End Class