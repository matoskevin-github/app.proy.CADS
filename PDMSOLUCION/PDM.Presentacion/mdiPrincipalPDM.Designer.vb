<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mdiPrincipalPDM
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdiPrincipalPDM))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.txtMantenimiento = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresarAmbientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnNuevoAmbiente = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAsignacionAmbiente = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCargo = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCaja = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCondicionAltaBaja = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnConservacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnDocumento = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnEntidadEducativa = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnFormaAdquisicion = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnGruposGenericos = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnNivelEstado = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnPabellones = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnPisos = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnResponsables = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnUsuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtRegistro = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnArticulos = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnEnseres = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtReportes = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeInventarioAPAFAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeInventarioUGELToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeInventarioGeneralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtRequerimiento = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtUsuarioActual = New System.Windows.Forms.ToolStripTextBox()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtMantenimiento, Me.txtRegistro, Me.txtReportes, Me.txtRequerimiento, Me.txtUsuarioActual})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(898, 27)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'txtMantenimiento
        '
        Me.txtMantenimiento.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresarAmbientesToolStripMenuItem, Me.btnCargo, Me.btnCaja, Me.btnCondicionAltaBaja, Me.btnConservacion, Me.btnDocumento, Me.btnEntidadEducativa, Me.btnFormaAdquisicion, Me.btnGruposGenericos, Me.btnNivelEstado, Me.btnPabellones, Me.btnPisos, Me.btnResponsables, Me.btnUsuarios})
        Me.txtMantenimiento.Name = "txtMantenimiento"
        Me.txtMantenimiento.Size = New System.Drawing.Size(106, 23)
        Me.txtMantenimiento.Text = "Mantenimientos"
        '
        'IngresarAmbientesToolStripMenuItem
        '
        Me.IngresarAmbientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevoAmbiente, Me.btnAsignacionAmbiente})
        Me.IngresarAmbientesToolStripMenuItem.Name = "IngresarAmbientesToolStripMenuItem"
        Me.IngresarAmbientesToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.IngresarAmbientesToolStripMenuItem.Text = "Ambientes"
        '
        'btnNuevoAmbiente
        '
        Me.btnNuevoAmbiente.Name = "btnNuevoAmbiente"
        Me.btnNuevoAmbiente.Size = New System.Drawing.Size(209, 22)
        Me.btnNuevoAmbiente.Text = "Nuevo Ambiente"
        '
        'btnAsignacionAmbiente
        '
        Me.btnAsignacionAmbiente.Name = "btnAsignacionAmbiente"
        Me.btnAsignacionAmbiente.Size = New System.Drawing.Size(209, 22)
        Me.btnAsignacionAmbiente.Text = "Asignacion de Ambientes"
        '
        'btnCargo
        '
        Me.btnCargo.Name = "btnCargo"
        Me.btnCargo.Size = New System.Drawing.Size(187, 22)
        Me.btnCargo.Text = "Cargo"
        '
        'btnCaja
        '
        Me.btnCaja.Name = "btnCaja"
        Me.btnCaja.Size = New System.Drawing.Size(187, 22)
        Me.btnCaja.Text = "Caja"
        '
        'btnCondicionAltaBaja
        '
        Me.btnCondicionAltaBaja.Name = "btnCondicionAltaBaja"
        Me.btnCondicionAltaBaja.Size = New System.Drawing.Size(187, 22)
        Me.btnCondicionAltaBaja.Text = "Condicion Alta y Baja"
        '
        'btnConservacion
        '
        Me.btnConservacion.Name = "btnConservacion"
        Me.btnConservacion.Size = New System.Drawing.Size(187, 22)
        Me.btnConservacion.Text = "Conservación"
        '
        'btnDocumento
        '
        Me.btnDocumento.Name = "btnDocumento"
        Me.btnDocumento.Size = New System.Drawing.Size(187, 22)
        Me.btnDocumento.Text = "Documento"
        '
        'btnEntidadEducativa
        '
        Me.btnEntidadEducativa.Name = "btnEntidadEducativa"
        Me.btnEntidadEducativa.Size = New System.Drawing.Size(187, 22)
        Me.btnEntidadEducativa.Text = "Entidad Educativa"
        '
        'btnFormaAdquisicion
        '
        Me.btnFormaAdquisicion.Name = "btnFormaAdquisicion"
        Me.btnFormaAdquisicion.Size = New System.Drawing.Size(187, 22)
        Me.btnFormaAdquisicion.Text = "Forma de Aquisicion"
        '
        'btnGruposGenericos
        '
        Me.btnGruposGenericos.Name = "btnGruposGenericos"
        Me.btnGruposGenericos.Size = New System.Drawing.Size(187, 22)
        Me.btnGruposGenericos.Text = "Grupos Genericos"
        '
        'btnNivelEstado
        '
        Me.btnNivelEstado.Name = "btnNivelEstado"
        Me.btnNivelEstado.Size = New System.Drawing.Size(187, 22)
        Me.btnNivelEstado.Text = "Nivel de Estado"
        '
        'btnPabellones
        '
        Me.btnPabellones.Name = "btnPabellones"
        Me.btnPabellones.Size = New System.Drawing.Size(187, 22)
        Me.btnPabellones.Text = "Pabellones"
        '
        'btnPisos
        '
        Me.btnPisos.Name = "btnPisos"
        Me.btnPisos.Size = New System.Drawing.Size(187, 22)
        Me.btnPisos.Text = "Pisos"
        '
        'btnResponsables
        '
        Me.btnResponsables.Name = "btnResponsables"
        Me.btnResponsables.Size = New System.Drawing.Size(187, 22)
        Me.btnResponsables.Text = "Responsables"
        '
        'btnUsuarios
        '
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(187, 22)
        Me.btnUsuarios.Text = "Usuarios"
        '
        'txtRegistro
        '
        Me.txtRegistro.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnArticulos, Me.btnEnseres})
        Me.txtRegistro.Name = "txtRegistro"
        Me.txtRegistro.Size = New System.Drawing.Size(67, 23)
        Me.txtRegistro.Text = "Registros"
        '
        'btnArticulos
        '
        Me.btnArticulos.Name = "btnArticulos"
        Me.btnArticulos.Size = New System.Drawing.Size(152, 22)
        Me.btnArticulos.Text = "Articulos"
        '
        'btnEnseres
        '
        Me.btnEnseres.Name = "btnEnseres"
        Me.btnEnseres.Size = New System.Drawing.Size(152, 22)
        Me.btnEnseres.Text = "Enseres"
        '
        'txtReportes
        '
        Me.txtReportes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReporteDeInventarioAPAFAToolStripMenuItem, Me.ReporteDeInventarioUGELToolStripMenuItem, Me.ReporteDeInventarioGeneralToolStripMenuItem})
        Me.txtReportes.Name = "txtReportes"
        Me.txtReportes.Size = New System.Drawing.Size(65, 23)
        Me.txtReportes.Text = "Reportes"
        '
        'ReporteDeInventarioAPAFAToolStripMenuItem
        '
        Me.ReporteDeInventarioAPAFAToolStripMenuItem.Name = "ReporteDeInventarioAPAFAToolStripMenuItem"
        Me.ReporteDeInventarioAPAFAToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.ReporteDeInventarioAPAFAToolStripMenuItem.Text = "Reporte de Inventario APAFA"
        '
        'ReporteDeInventarioUGELToolStripMenuItem
        '
        Me.ReporteDeInventarioUGELToolStripMenuItem.Name = "ReporteDeInventarioUGELToolStripMenuItem"
        Me.ReporteDeInventarioUGELToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.ReporteDeInventarioUGELToolStripMenuItem.Text = "Reporte de Inventario UGEL"
        '
        'ReporteDeInventarioGeneralToolStripMenuItem
        '
        Me.ReporteDeInventarioGeneralToolStripMenuItem.Name = "ReporteDeInventarioGeneralToolStripMenuItem"
        Me.ReporteDeInventarioGeneralToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.ReporteDeInventarioGeneralToolStripMenuItem.Text = "Reporte de Inventario General"
        '
        'txtRequerimiento
        '
        Me.txtRequerimiento.Name = "txtRequerimiento"
        Me.txtRequerimiento.Size = New System.Drawing.Size(102, 23)
        Me.txtRequerimiento.Text = "Requerimientos"
        '
        'txtUsuarioActual
        '
        Me.txtUsuarioActual.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtUsuarioActual.Enabled = False
        Me.txtUsuarioActual.Name = "txtUsuarioActual"
        Me.txtUsuarioActual.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtUsuarioActual.Size = New System.Drawing.Size(200, 23)
        Me.txtUsuarioActual.Text = "Usuario Actual"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 532)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(898, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(224, 17)
        Me.ToolStripStatusLabel1.Text = "Desarrollado por Bryan Aguilar Chuquino"
        '
        'mdiPrincipalPDM
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.PDM.Presentacion.My.Resources.Resources._47370131_1960271860735029_5071678600671920128_o
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(898, 554)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "mdiPrincipalPDM"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Bienvenidos al Sistema de Inventario PDM N° 41"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents txtMantenimiento As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresarAmbientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnPabellones As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnResponsables As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCargo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnEntidadEducativa As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCaja As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtRegistro As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnArticulos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnEnseres As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtReportes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteDeInventarioAPAFAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteDeInventarioUGELToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteDeInventarioGeneralToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnAsignacionAmbiente As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnNuevoAmbiente As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtUsuarioActual As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents txtRequerimiento As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCondicionAltaBaja As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnConservacion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnDocumento As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnNivelEstado As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnGruposGenericos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnFormaAdquisicion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnPisos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnUsuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel

End Class
