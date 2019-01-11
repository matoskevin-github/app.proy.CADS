<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIngresoArticulosPDM
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIngresoArticulosPDM))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnEditar = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtSalida = New System.Windows.Forms.TextBox()
        Me.txtSocket = New System.Windows.Forms.TextBox()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.txtCapacidad = New System.Windows.Forms.TextBox()
        Me.txtUnidadMedida = New System.Windows.Forms.TextBox()
        Me.txtFrecuencia = New System.Windows.Forms.TextBox()
        Me.txtNucleos = New System.Windows.Forms.TextBox()
        Me.txtGeneracion = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtAncho = New System.Windows.Forms.TextBox()
        Me.txtLargo = New System.Windows.Forms.TextBox()
        Me.txtAlto = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtMotor = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtDiametro = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtMaterial = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboNivelEstado = New System.Windows.Forms.ComboBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.cboTipoCaja = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboEntidad = New System.Windows.Forms.ComboBox()
        Me.txtDetalle = New System.Windows.Forms.TextBox()
        Me.txtPrecioSIGV = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPrecioCIGV = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrecioUnitario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboFormaAdquisicion = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboDocumento = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpFechaBaja = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpFechaAlta = New System.Windows.Forms.DateTimePicker()
        Me.cboCondicion = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboConservacion = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtResponsable = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtPabellon = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cboAmbiente = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboGrupoGenerico = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnGuardar, Me.btnEditar, Me.btnCancelar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(841, 54)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = Global.PDM.Presentacion.My.Resources.Resources.GUARDAR
        Me.btnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(53, 51)
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnEditar
        '
        Me.btnEditar.Image = Global.PDM.Presentacion.My.Resources.Resources.EDITAR
        Me.btnEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(41, 51)
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.PDM.Presentacion.My.Resources.Resources.CANCELAR
        Me.btnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(57, 51)
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtSalida)
        Me.GroupBox2.Controls.Add(Me.txtSocket)
        Me.GroupBox2.Controls.Add(Me.txtTipo)
        Me.GroupBox2.Controls.Add(Me.txtCapacidad)
        Me.GroupBox2.Controls.Add(Me.txtUnidadMedida)
        Me.GroupBox2.Controls.Add(Me.txtFrecuencia)
        Me.GroupBox2.Controls.Add(Me.txtNucleos)
        Me.GroupBox2.Controls.Add(Me.txtGeneracion)
        Me.GroupBox2.Controls.Add(Me.Label38)
        Me.GroupBox2.Controls.Add(Me.Label37)
        Me.GroupBox2.Controls.Add(Me.Label36)
        Me.GroupBox2.Controls.Add(Me.Label35)
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Controls.Add(Me.Label31)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txtAncho)
        Me.GroupBox2.Controls.Add(Me.txtLargo)
        Me.GroupBox2.Controls.Add(Me.txtAlto)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtMotor)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.txtObservaciones)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.txtDiametro)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.txtSerie)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.txtColor)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.txtMaterial)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.txtMarca)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.txtModelo)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 311)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(818, 279)
        Me.GroupBox2.TabIndex = 63
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "[ Datos Tecnicos ]"
        '
        'txtSalida
        '
        Me.txtSalida.Location = New System.Drawing.Point(647, 135)
        Me.txtSalida.Name = "txtSalida"
        Me.txtSalida.Size = New System.Drawing.Size(159, 21)
        Me.txtSalida.TabIndex = 89
        '
        'txtSocket
        '
        Me.txtSocket.Location = New System.Drawing.Point(647, 108)
        Me.txtSocket.Name = "txtSocket"
        Me.txtSocket.Size = New System.Drawing.Size(159, 21)
        Me.txtSocket.TabIndex = 88
        '
        'txtTipo
        '
        Me.txtTipo.Location = New System.Drawing.Point(377, 161)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(159, 21)
        Me.txtTipo.TabIndex = 87
        '
        'txtCapacidad
        '
        Me.txtCapacidad.Location = New System.Drawing.Point(377, 135)
        Me.txtCapacidad.Name = "txtCapacidad"
        Me.txtCapacidad.Size = New System.Drawing.Size(159, 21)
        Me.txtCapacidad.TabIndex = 86
        '
        'txtUnidadMedida
        '
        Me.txtUnidadMedida.Location = New System.Drawing.Point(377, 108)
        Me.txtUnidadMedida.Name = "txtUnidadMedida"
        Me.txtUnidadMedida.Size = New System.Drawing.Size(159, 21)
        Me.txtUnidadMedida.TabIndex = 85
        '
        'txtFrecuencia
        '
        Me.txtFrecuencia.Location = New System.Drawing.Point(109, 161)
        Me.txtFrecuencia.Name = "txtFrecuencia"
        Me.txtFrecuencia.Size = New System.Drawing.Size(167, 21)
        Me.txtFrecuencia.TabIndex = 84
        '
        'txtNucleos
        '
        Me.txtNucleos.Location = New System.Drawing.Point(109, 135)
        Me.txtNucleos.Name = "txtNucleos"
        Me.txtNucleos.Size = New System.Drawing.Size(167, 21)
        Me.txtNucleos.TabIndex = 83
        '
        'txtGeneracion
        '
        Me.txtGeneracion.Location = New System.Drawing.Point(109, 108)
        Me.txtGeneracion.Name = "txtGeneracion"
        Me.txtGeneracion.Size = New System.Drawing.Size(167, 21)
        Me.txtGeneracion.TabIndex = 82
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(601, 111)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(42, 15)
        Me.Label38.TabIndex = 81
        Me.Label38.Text = "Socket:"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(605, 138)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(38, 15)
        Me.Label37.TabIndex = 80
        Me.Label37.Text = "Salida:"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(291, 111)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(85, 15)
        Me.Label36.TabIndex = 79
        Me.Label36.Text = "Unidad Medida:"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(342, 164)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(34, 15)
        Me.Label35.TabIndex = 78
        Me.Label35.Text = "Tipo:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(316, 138)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(60, 15)
        Me.Label32.TabIndex = 77
        Me.Label32.Text = "Capacidad:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(44, 164)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(61, 15)
        Me.Label31.TabIndex = 76
        Me.Label31.Text = "Frecuencia:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(56, 138)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(49, 15)
        Me.Label30.TabIndex = 75
        Me.Label30.Text = "Nucleos:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(41, 111)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 15)
        Me.Label17.TabIndex = 74
        Me.Label17.Text = "Generación:"
        '
        'txtAncho
        '
        Me.txtAncho.Location = New System.Drawing.Point(233, 80)
        Me.txtAncho.Name = "txtAncho"
        Me.txtAncho.Size = New System.Drawing.Size(43, 21)
        Me.txtAncho.TabIndex = 73
        '
        'txtLargo
        '
        Me.txtLargo.Location = New System.Drawing.Point(377, 81)
        Me.txtLargo.Name = "txtLargo"
        Me.txtLargo.Size = New System.Drawing.Size(43, 21)
        Me.txtLargo.TabIndex = 72
        '
        'txtAlto
        '
        Me.txtAlto.Location = New System.Drawing.Point(143, 81)
        Me.txtAlto.Name = "txtAlto"
        Me.txtAlto.Size = New System.Drawing.Size(43, 21)
        Me.txtAlto.TabIndex = 71
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(339, 84)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 15)
        Me.Label11.TabIndex = 70
        Me.Label11.Text = "Largo:"
        '
        'txtMotor
        '
        Me.txtMotor.Location = New System.Drawing.Point(647, 29)
        Me.txtMotor.Name = "txtMotor"
        Me.txtMotor.Size = New System.Drawing.Size(159, 21)
        Me.txtMotor.TabIndex = 65
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(601, 32)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(42, 15)
        Me.Label29.TabIndex = 61
        Me.Label29.Text = "Motor:"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(109, 189)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(697, 84)
        Me.txtObservaciones.TabIndex = 60
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(57, 32)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(48, 15)
        Me.Label18.TabIndex = 41
        Me.Label18.Text = "Modelo:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(64, 58)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(41, 15)
        Me.Label19.TabIndex = 42
        Me.Label19.Text = "Marca:"
        '
        'txtDiametro
        '
        Me.txtDiametro.Location = New System.Drawing.Point(493, 81)
        Me.txtDiametro.Name = "txtDiametro"
        Me.txtDiametro.Size = New System.Drawing.Size(43, 21)
        Me.txtDiametro.TabIndex = 58
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(325, 32)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(51, 15)
        Me.Label21.TabIndex = 44
        Me.Label21.Text = "Material:"
        '
        'txtSerie
        '
        Me.txtSerie.Location = New System.Drawing.Point(377, 55)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(159, 21)
        Me.txtSerie.TabIndex = 56
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(606, 58)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(37, 15)
        Me.Label22.TabIndex = 45
        Me.Label22.Text = "Color:"
        '
        'txtColor
        '
        Me.txtColor.Location = New System.Drawing.Point(647, 55)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(159, 21)
        Me.txtColor.TabIndex = 55
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(343, 58)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(33, 15)
        Me.Label23.TabIndex = 46
        Me.Label23.Text = "Serie:"
        '
        'txtMaterial
        '
        Me.txtMaterial.Location = New System.Drawing.Point(377, 29)
        Me.txtMaterial.Name = "txtMaterial"
        Me.txtMaterial.Size = New System.Drawing.Size(159, 21)
        Me.txtMaterial.TabIndex = 54
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(33, 84)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 15)
        Me.Label24.TabIndex = 47
        Me.Label24.Text = "Dimensiones:"
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(109, 55)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(167, 21)
        Me.txtMarca.TabIndex = 53
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(194, 84)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(42, 15)
        Me.Label25.TabIndex = 48
        Me.Label25.Text = "Ancho:"
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(109, 29)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(167, 21)
        Me.txtModelo.TabIndex = 52
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(111, 84)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(32, 15)
        Me.Label26.TabIndex = 49
        Me.Label26.Text = "Alto:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(25, 192)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(80, 15)
        Me.Label28.TabIndex = 51
        Me.Label28.Text = "Observaciones:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(437, 84)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(55, 15)
        Me.Label27.TabIndex = 50
        Me.Label27.Text = "Diametro:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cboNivelEstado)
        Me.GroupBox1.Controls.Add(Me.Label34)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.Label33)
        Me.GroupBox1.Controls.Add(Me.cboTipoCaja)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboEntidad)
        Me.GroupBox1.Controls.Add(Me.txtDetalle)
        Me.GroupBox1.Controls.Add(Me.txtPrecioSIGV)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtPrecioCIGV)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtPrecioUnitario)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cboFormaAdquisicion)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cboDocumento)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.dtpFechaBaja)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.dtpFechaAlta)
        Me.GroupBox1.Controls.Add(Me.cboCondicion)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cboConservacion)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtResponsable)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtPabellon)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.cboAmbiente)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cboGrupoGenerico)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(818, 243)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "[ Datos del Bien ]"
        '
        'cboNivelEstado
        '
        Me.cboNivelEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNivelEstado.FormattingEnabled = True
        Me.cboNivelEstado.Location = New System.Drawing.Point(444, 127)
        Me.cboNivelEstado.Name = "cboNivelEstado"
        Me.cboNivelEstado.Size = New System.Drawing.Size(110, 23)
        Me.cboNivelEstado.TabIndex = 45
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(350, 131)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(86, 15)
        Me.Label34.TabIndex = 44
        Me.Label34.Text = "Nivel de Estado:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(109, 48)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(182, 21)
        Me.txtCodigo.TabIndex = 43
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(5, 51)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(100, 15)
        Me.Label33.TabIndex = 42
        Me.Label33.Text = "Codigo de Articulo:"
        '
        'cboTipoCaja
        '
        Me.cboTipoCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoCaja.FormattingEnabled = True
        Me.cboTipoCaja.Location = New System.Drawing.Point(109, 101)
        Me.cboTipoCaja.Name = "cboTipoCaja"
        Me.cboTipoCaja.Size = New System.Drawing.Size(182, 23)
        Me.cboTipoCaja.TabIndex = 40
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(17, 77)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(88, 15)
        Me.Label20.TabIndex = 39
        Me.Label20.Text = "Grupo Generico:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Denominacion:"
        '
        'cboEntidad
        '
        Me.cboEntidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEntidad.FormattingEnabled = True
        Me.cboEntidad.Location = New System.Drawing.Point(444, 48)
        Me.cboEntidad.Name = "cboEntidad"
        Me.cboEntidad.Size = New System.Drawing.Size(267, 23)
        Me.cboEntidad.TabIndex = 38
        '
        'txtDetalle
        '
        Me.txtDetalle.Location = New System.Drawing.Point(109, 24)
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.Size = New System.Drawing.Size(327, 21)
        Me.txtDetalle.TabIndex = 1
        '
        'txtPrecioSIGV
        '
        Me.txtPrecioSIGV.Location = New System.Drawing.Point(699, 208)
        Me.txtPrecioSIGV.Name = "txtPrecioSIGV"
        Me.txtPrecioSIGV.Size = New System.Drawing.Size(107, 21)
        Me.txtPrecioSIGV.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tipo de Caja:"
        '
        'txtPrecioCIGV
        '
        Me.txtPrecioCIGV.Location = New System.Drawing.Point(444, 208)
        Me.txtPrecioCIGV.Name = "txtPrecioCIGV"
        Me.txtPrecioCIGV.Size = New System.Drawing.Size(141, 21)
        Me.txtPrecioCIGV.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(389, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Entidad:"
        '
        'txtPrecioUnitario
        '
        Me.txtPrecioUnitario.Location = New System.Drawing.Point(109, 208)
        Me.txtPrecioUnitario.Name = "txtPrecioUnitario"
        Me.txtPrecioUnitario.Size = New System.Drawing.Size(147, 21)
        Me.txtPrecioUnitario.TabIndex = 35
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Condicion:"
        '
        'cboFormaAdquisicion
        '
        Me.cboFormaAdquisicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormaAdquisicion.FormattingEnabled = True
        Me.cboFormaAdquisicion.Location = New System.Drawing.Point(444, 101)
        Me.cboFormaAdquisicion.Name = "cboFormaAdquisicion"
        Me.cboFormaAdquisicion.Size = New System.Drawing.Size(109, 23)
        Me.cboFormaAdquisicion.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 15)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Conservacion:"
        '
        'cboDocumento
        '
        Me.cboDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDocumento.FormattingEnabled = True
        Me.cboDocumento.Location = New System.Drawing.Point(444, 73)
        Me.cboDocumento.Name = "cboDocumento"
        Me.cboDocumento.Size = New System.Drawing.Size(109, 23)
        Me.cboDocumento.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(385, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 15)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Pabellon:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(48, 184)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 15)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Ambiente:"
        '
        'dtpFechaBaja
        '
        Me.dtpFechaBaja.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaBaja.Location = New System.Drawing.Point(699, 154)
        Me.dtpFechaBaja.Name = "dtpFechaBaja"
        Me.dtpFechaBaja.Size = New System.Drawing.Size(107, 21)
        Me.dtpFechaBaja.TabIndex = 31
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(620, 184)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 15)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Responsanble:"
        '
        'dtpFechaAlta
        '
        Me.dtpFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaAlta.Location = New System.Drawing.Point(444, 154)
        Me.dtpFechaAlta.Name = "dtpFechaAlta"
        Me.dtpFechaAlta.Size = New System.Drawing.Size(141, 21)
        Me.dtpFechaAlta.TabIndex = 30
        '
        'cboCondicion
        '
        Me.cboCondicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCondicion.FormattingEnabled = True
        Me.cboCondicion.Location = New System.Drawing.Point(109, 155)
        Me.cboCondicion.Name = "cboCondicion"
        Me.cboCondicion.Size = New System.Drawing.Size(182, 23)
        Me.cboCondicion.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(370, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 15)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Documento:"
        '
        'cboConservacion
        '
        Me.cboConservacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConservacion.FormattingEnabled = True
        Me.cboConservacion.Location = New System.Drawing.Point(109, 128)
        Me.cboConservacion.Name = "cboConservacion"
        Me.cboConservacion.Size = New System.Drawing.Size(182, 23)
        Me.cboConservacion.TabIndex = 28
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(321, 104)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(115, 15)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Forma de Adquisicion:"
        '
        'txtResponsable
        '
        Me.txtResponsable.Enabled = False
        Me.txtResponsable.Location = New System.Drawing.Point(699, 182)
        Me.txtResponsable.Name = "txtResponsable"
        Me.txtResponsable.Size = New System.Drawing.Size(107, 21)
        Me.txtResponsable.TabIndex = 27
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(22, 211)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 15)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Precio Unitario:"
        '
        'txtPabellon
        '
        Me.txtPabellon.Enabled = False
        Me.txtPabellon.Location = New System.Drawing.Point(444, 181)
        Me.txtPabellon.Name = "txtPabellon"
        Me.txtPabellon.Size = New System.Drawing.Size(141, 21)
        Me.txtPabellon.TabIndex = 26
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(350, 211)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(86, 15)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Precio Con IGV:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(616, 211)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 15)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Precio Sin IGV:"
        '
        'cboAmbiente
        '
        Me.cboAmbiente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAmbiente.FormattingEnabled = True
        Me.cboAmbiente.Location = New System.Drawing.Point(109, 181)
        Me.cboAmbiente.Name = "cboAmbiente"
        Me.cboAmbiente.Size = New System.Drawing.Size(182, 23)
        Me.cboAmbiente.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(361, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 15)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Fecha de Alta:"
        '
        'cboGrupoGenerico
        '
        Me.cboGrupoGenerico.FormattingEnabled = True
        Me.cboGrupoGenerico.Location = New System.Drawing.Point(109, 74)
        Me.cboGrupoGenerico.Name = "cboGrupoGenerico"
        Me.cboGrupoGenerico.Size = New System.Drawing.Size(182, 23)
        Me.cboGrupoGenerico.TabIndex = 21
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(621, 158)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(76, 15)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "Fecha de Baja:"
        '
        'frmIngresoArticulosPDM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.PDM.Presentacion.My.Resources.Resources.PDMFondos
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(841, 600)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmIngresoArticulosPDM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso de Articulos"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMotor As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtDiametro As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtSerie As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtColor As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtMaterial As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtMarca As System.Windows.Forms.TextBox
    Friend WithEvents txtModelo As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboNivelEstado As System.Windows.Forms.ComboBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents cboTipoCaja As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboEntidad As System.Windows.Forms.ComboBox
    Friend WithEvents txtDetalle As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecioSIGV As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPrecioCIGV As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPrecioUnitario As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboFormaAdquisicion As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaBaja As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaAlta As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboCondicion As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboConservacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtResponsable As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtPabellon As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cboAmbiente As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboGrupoGenerico As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtAncho As System.Windows.Forms.TextBox
    Friend WithEvents txtLargo As System.Windows.Forms.TextBox
    Friend WithEvents txtAlto As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtSalida As System.Windows.Forms.TextBox
    Friend WithEvents txtSocket As System.Windows.Forms.TextBox
    Friend WithEvents txtTipo As System.Windows.Forms.TextBox
    Friend WithEvents txtCapacidad As System.Windows.Forms.TextBox
    Friend WithEvents txtUnidadMedida As System.Windows.Forms.TextBox
    Friend WithEvents txtFrecuencia As System.Windows.Forms.TextBox
    Friend WithEvents txtNucleos As System.Windows.Forms.TextBox
    Friend WithEvents txtGeneracion As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
End Class
