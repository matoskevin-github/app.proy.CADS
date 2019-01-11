<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIngresarResponsablesPDM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIngresarResponsablesPDM))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnEditar = New System.Windows.Forms.ToolStripButton()
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.txtBuscar = New System.Windows.Forms.ToolStripTextBox()
        Me.lblBuscar = New System.Windows.Forms.ToolStripLabel()
        Me.grbAmbiente = New System.Windows.Forms.GroupBox()
        Me.chkActivar = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtpFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.cboCondicion = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboCargo = New System.Windows.Forms.ComboBox()
        Me.grbPersonal = New System.Windows.Forms.GroupBox()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboEstadoCivil = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.dgvResponsable = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1.SuspendLayout()
        Me.grbAmbiente.SuspendLayout()
        Me.grbPersonal.SuspendLayout()
        CType(Me.dgvResponsable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnGuardar, Me.btnEditar, Me.btnBuscar, Me.btnCancelar, Me.txtBuscar, Me.lblBuscar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(674, 54)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = Global.PDM.Presentacion.My.Resources.Resources.NUEVO
        Me.btnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(46, 51)
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.PDM.Presentacion.My.Resources.Resources.BUSCAR
        Me.btnBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(46, 51)
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'txtBuscar
        '
        Me.txtBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(1, 0, 5, 0)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(250, 54)
        '
        'lblBuscar
        '
        Me.lblBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(45, 51)
        Me.lblBuscar.Text = "Buscar:"
        '
        'grbAmbiente
        '
        Me.grbAmbiente.BackColor = System.Drawing.Color.Transparent
        Me.grbAmbiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.grbAmbiente.Controls.Add(Me.chkActivar)
        Me.grbAmbiente.Controls.Add(Me.Label12)
        Me.grbAmbiente.Controls.Add(Me.dtpFechaIngreso)
        Me.grbAmbiente.Controls.Add(Me.cboCondicion)
        Me.grbAmbiente.Controls.Add(Me.Label11)
        Me.grbAmbiente.Controls.Add(Me.Label7)
        Me.grbAmbiente.Controls.Add(Me.Label9)
        Me.grbAmbiente.Controls.Add(Me.cboCargo)
        Me.grbAmbiente.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbAmbiente.Location = New System.Drawing.Point(12, 228)
        Me.grbAmbiente.Name = "grbAmbiente"
        Me.grbAmbiente.Size = New System.Drawing.Size(653, 87)
        Me.grbAmbiente.TabIndex = 22
        Me.grbAmbiente.TabStop = False
        Me.grbAmbiente.Text = "[ Datos Laborales ]"
        '
        'chkActivar
        '
        Me.chkActivar.AutoSize = True
        Me.chkActivar.Checked = True
        Me.chkActivar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActivar.Location = New System.Drawing.Point(123, 58)
        Me.chkActivar.Name = "chkActivar"
        Me.chkActivar.Size = New System.Drawing.Size(59, 19)
        Me.chkActivar.TabIndex = 22
        Me.chkActivar.Text = "Activo"
        Me.chkActivar.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(74, 59)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 15)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Estado:"
        '
        'dtpFechaIngreso
        '
        Me.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIngreso.Location = New System.Drawing.Point(506, 55)
        Me.dtpFechaIngreso.Name = "dtpFechaIngreso"
        Me.dtpFechaIngreso.Size = New System.Drawing.Size(127, 21)
        Me.dtpFechaIngreso.TabIndex = 18
        '
        'cboCondicion
        '
        Me.cboCondicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCondicion.FormattingEnabled = True
        Me.cboCondicion.Items.AddRange(New Object() {"--SELECCIONAR--", "CONTRATADO", "NOMBRADO", "INTERNO"})
        Me.cboCondicion.Location = New System.Drawing.Point(506, 23)
        Me.cboCondicion.Name = "cboCondicion"
        Me.cboCondicion.Size = New System.Drawing.Size(127, 23)
        Me.cboCondicion.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(410, 59)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 15)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Fecha de Ingreso:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(441, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 15)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Condición:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(79, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 15)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Cargo:"
        '
        'cboCargo
        '
        Me.cboCargo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboCargo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCargo.Location = New System.Drawing.Point(123, 23)
        Me.cboCargo.Name = "cboCargo"
        Me.cboCargo.Size = New System.Drawing.Size(224, 23)
        Me.cboCargo.TabIndex = 13
        '
        'grbPersonal
        '
        Me.grbPersonal.BackColor = System.Drawing.Color.Transparent
        Me.grbPersonal.Controls.Add(Me.txtDNI)
        Me.grbPersonal.Controls.Add(Me.Label14)
        Me.grbPersonal.Controls.Add(Me.dtpFechaNacimiento)
        Me.grbPersonal.Controls.Add(Me.Label1)
        Me.grbPersonal.Controls.Add(Me.Label8)
        Me.grbPersonal.Controls.Add(Me.Label2)
        Me.grbPersonal.Controls.Add(Me.cboEstadoCivil)
        Me.grbPersonal.Controls.Add(Me.Label3)
        Me.grbPersonal.Controls.Add(Me.Label4)
        Me.grbPersonal.Controls.Add(Me.txtCelular)
        Me.grbPersonal.Controls.Add(Me.Label5)
        Me.grbPersonal.Controls.Add(Me.txtCorreo)
        Me.grbPersonal.Controls.Add(Me.Label6)
        Me.grbPersonal.Controls.Add(Me.txtDireccion)
        Me.grbPersonal.Controls.Add(Me.txtApellidos)
        Me.grbPersonal.Controls.Add(Me.txtNombres)
        Me.grbPersonal.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbPersonal.Location = New System.Drawing.Point(12, 62)
        Me.grbPersonal.Name = "grbPersonal"
        Me.grbPersonal.Size = New System.Drawing.Size(653, 160)
        Me.grbPersonal.TabIndex = 21
        Me.grbPersonal.TabStop = False
        Me.grbPersonal.Text = "[ Datos Personales ]"
        '
        'txtDNI
        '
        Me.txtDNI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDNI.Location = New System.Drawing.Point(123, 75)
        Me.txtDNI.MaxLength = 8
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(127, 21)
        Me.txtDNI.TabIndex = 18
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(85, 80)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(32, 15)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "DNI:"
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(506, 72)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(127, 21)
        Me.dtpFechaNacimiento.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombres:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(390, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 15)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Fecha de Nacimiento:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellidos:"
        '
        'cboEstadoCivil
        '
        Me.cboEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstadoCivil.FormattingEnabled = True
        Me.cboEstadoCivil.Items.AddRange(New Object() {"--SELECCIONAR--", "CASADO(a)", "SOLTERO(a)", "VIUDO", "DIVORCIADO"})
        Me.cboEstadoCivil.Location = New System.Drawing.Point(506, 46)
        Me.cboEstadoCivil.Name = "cboEstadoCivil"
        Me.cboEstadoCivil.Size = New System.Drawing.Size(127, 23)
        Me.cboEstadoCivil.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Dirección:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(431, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Estado Civil:"
        '
        'txtCelular
        '
        Me.txtCelular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCelular.Location = New System.Drawing.Point(506, 20)
        Me.txtCelular.MaxLength = 9
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(127, 21)
        Me.txtCelular.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Correo Electronico:"
        '
        'txtCorreo
        '
        Me.txtCorreo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCorreo.Location = New System.Drawing.Point(123, 126)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(224, 21)
        Me.txtCorreo.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(456, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Celular:"
        '
        'txtDireccion
        '
        Me.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccion.Location = New System.Drawing.Point(123, 101)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(224, 21)
        Me.txtDireccion.TabIndex = 10
        '
        'txtApellidos
        '
        Me.txtApellidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApellidos.Location = New System.Drawing.Point(123, 48)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(224, 21)
        Me.txtApellidos.TabIndex = 9
        '
        'txtNombres
        '
        Me.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombres.Location = New System.Drawing.Point(123, 24)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(224, 21)
        Me.txtNombres.TabIndex = 8
        '
        'dgvResponsable
        '
        Me.dgvResponsable.AllowUserToAddRows = False
        Me.dgvResponsable.AllowUserToDeleteRows = False
        Me.dgvResponsable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResponsable.Location = New System.Drawing.Point(12, 321)
        Me.dgvResponsable.Name = "dgvResponsable"
        Me.dgvResponsable.ReadOnly = True
        Me.dgvResponsable.Size = New System.Drawing.Size(653, 189)
        Me.dgvResponsable.TabIndex = 23
        '
        'frmIngresarResponsablesPDM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.PDM.Presentacion.My.Resources.Resources.PDMFondos
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(674, 518)
        Me.Controls.Add(Me.dgvResponsable)
        Me.Controls.Add(Me.grbAmbiente)
        Me.Controls.Add(Me.grbPersonal)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmIngresarResponsablesPDM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingresar Responsables"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.grbAmbiente.ResumeLayout(False)
        Me.grbAmbiente.PerformLayout()
        Me.grbPersonal.ResumeLayout(False)
        Me.grbPersonal.PerformLayout()
        CType(Me.dgvResponsable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents grbAmbiente As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFechaIngreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboCondicion As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboCargo As System.Windows.Forms.ComboBox
    Friend WithEvents grbPersonal As System.Windows.Forms.GroupBox
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboEstadoCivil As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCelular As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCorreo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtApellidos As System.Windows.Forms.TextBox
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgvResponsable As System.Windows.Forms.DataGridView
    Friend WithEvents chkActivar As System.Windows.Forms.CheckBox
    Friend WithEvents txtBuscar As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents lblBuscar As System.Windows.Forms.ToolStripLabel
End Class
