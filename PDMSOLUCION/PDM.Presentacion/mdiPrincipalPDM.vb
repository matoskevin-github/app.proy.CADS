Imports System.Windows.Forms
Imports PDM.Entidades
Imports PDM.LogicaNegocio

Public Class mdiPrincipalPDM
#Region "Metodos Externos"

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub


    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub



    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer
#End Region


    Private Sub mdiPrincipalPDM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim TipoUsuario As Integer = SessionUsuario.TipoUsuario
        Dim idUsuario As Integer = SessionUsuario.idUsuario
        txtUsuarioActual.Text = SessionUsuario.NombreCompleto.ToUpper
        IncializarPerfiles(TipoUsuario)

    End Sub



    Private Sub IncializarPerfiles(TipoUsuario As Integer)
        Select Case TipoUsuario
            Case Cargos.CARGO_TIPO_SUPER_ADMINISTRADOR
                CargarPerfilSuperAdministrador()
            Case Cargos.CARGO_TIPO_ADMINISTRADOR
                CargarPerfilAdministrador()
            Case Cargos.CARGO_TIPO_USUARIO_REPORTE
                CargarPerfilUsuarioReporte()
            Case Cargos.CARGO_TIPO_REQUERIMIENTO
                CargarPerfilUsuarioRequerimiento()
        End Select
    End Sub

    Private Sub CargarPerfilSuperAdministrador()
        txtMantenimiento.Visible = True
        txtRegistro.Visible = True
        txtReportes.Visible = True
        txtRequerimiento.Visible = True
    End Sub

    Private Sub CargarPerfilAdministrador()
        txtMantenimiento.Visible = True
        txtRegistro.Visible = True
        txtReportes.Visible = True
        txtRequerimiento.Visible = True
    End Sub

    Private Sub CargarPerfilUsuarioReporte()
        txtMantenimiento.Visible = False
        txtRegistro.Visible = False
        txtReportes.Visible = True
        txtRequerimiento.Visible = True
    End Sub

    Private Sub CargarPerfilUsuarioRequerimiento()
        txtMantenimiento.Visible = False
        txtRegistro.Visible = False
        txtReportes.Visible = False
        txtRequerimiento.Visible = True
    End Sub

    Public Enum Cargos
        CARGO_TIPO_SUPER_ADMINISTRADOR = 1
        CARGO_TIPO_ADMINISTRADOR = 2
        CARGO_TIPO_USUARIO_REPORTE = 3
        CARGO_TIPO_REQUERIMIENTO = 4
    End Enum

    Private Sub btnNuevoAmbiente_Click(sender As Object, e As EventArgs) Handles btnNuevoAmbiente.Click
        Dim ob As New frmIngresarAmbientesPDM
        ob.MdiParent = Me
        ob.Show()
    End Sub

    Private Sub btnAsignacionAmbiente_Click(sender As Object, e As EventArgs) Handles btnAsignacionAmbiente.Click
        Dim ob As New frmAsignaciondeAmbientesPDM
        ob.MdiParent = Me
        ob.Show()
    End Sub

    Private Sub btnCargo_Click(sender As Object, e As EventArgs) Handles btnCargo.Click
        Dim ob As New frmIngresaCargo
        ob.MdiParent = Me
        ob.Show()
    End Sub

    Private Sub btnCaja_Click(sender As Object, e As EventArgs) Handles btnCaja.Click
        Dim ob As New frmIngresoCaja
        ob.MdiParent = Me
        ob.Show()
    End Sub

    Private Sub btnCondicionAltaBaja_Click(sender As Object, e As EventArgs) Handles btnCondicionAltaBaja.Click
        Dim ob As New frmCondicionAltayBaja
        ob.MdiParent = Me
        ob.Show()
    End Sub

    Private Sub btnConservacion_Click(sender As Object, e As EventArgs) Handles btnConservacion.Click
        Dim ob As New frmConservacion
        ob.MdiParent = Me
        ob.Show()
    End Sub

    Private Sub btnDocumento_Click(sender As Object, e As EventArgs) Handles btnDocumento.Click
        Dim ob As New frmDocumentoPDM
        ob.MdiParent = Me
        ob.Show()
    End Sub

    Private Sub btnEntidadEducativa_Click(sender As Object, e As EventArgs) Handles btnEntidadEducativa.Click
        Dim ob As New frmEntidadEducativaPDM
        ob.MdiParent = Me
        ob.Show()
    End Sub

    Private Sub btnFormaAdquisicion_Click(sender As Object, e As EventArgs) Handles btnFormaAdquisicion.Click
        Dim ob As New frmFormadeAdquisicion
        ob.MdiParent = Me
        ob.Show()
    End Sub

    Private Sub btnGruposGenericos_Click(sender As Object, e As EventArgs) Handles btnGruposGenericos.Click
        Dim ob As New frmGrupoGenericoPDM
        ob.MdiParent = Me
        ob.Show()
    End Sub

    Private Sub btnNivelEstado_Click(sender As Object, e As EventArgs) Handles btnNivelEstado.Click
        Dim ob As New frmNivelEstadoPDM
        ob.MdiParent = Me
        ob.Show()
    End Sub

    Private Sub btnPabellones_Click(sender As Object, e As EventArgs) Handles btnPabellones.Click
        Dim ob As New frmIngresarPabellones
        ob.MdiParent = Me
        ob.Show()
    End Sub

    Private Sub btnPisos_Click(sender As Object, e As EventArgs) Handles btnPisos.Click
        Dim ob As New frmIngresarPisosPDM
        ob.MdiParent = Me
        ob.Show()
    End Sub

    Private Sub btnResponsables_Click(sender As Object, e As EventArgs) Handles btnResponsables.Click
        Dim ob As New frmIngresarResponsablesPDM
        ob.MdiParent = Me
        ob.Show()
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        Dim ob As New frmGestiondeUsuariosPDM
        ob.MdiParent = Me
        ob.Show()
    End Sub

    Private Sub AgregarBienToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btnArticulos.Click
        Dim ob As New frmArticulosPDM
        ob.MdiParent = Me
        ob.Show()
    End Sub
End Class
