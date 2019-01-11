Imports PDM.Entidades
Imports PDM.LogicaNegocio
Imports PDM.Common

Public Class frmLoginPDM
    Dim Datos As New PDMLoginBE
    Dim Funcion As New PDMLoginBO

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        IngresarSistema()
    End Sub

    Private Sub frmLoginPDM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ObtenerDatosUsuario(Usuario As String)
        Dim PDMLoginBO As New PDMLoginBO
        Dim oResponsable As PDMResponsableBE = PDMLoginBO.ObtenerInfoUsuario(Usuario)
        SessionUsuario.idUsuario = oResponsable.idUsuario
        SessionUsuario.NombreCompleto = oResponsable.Nombres.Trim & " " & oResponsable.Apellidos.Trim
        SessionUsuario.idResponsable = oResponsable.idResponsable
        SessionUsuario.TipoUsuario = oResponsable.TipoUsuario

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Application.Exit()
    End Sub

    Private Sub txtContraseña_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContraseña.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            IngresarSistema()
        End If
    End Sub

    Private Sub IngresarSistema()
        Try
            Datos.Usuario = txtUsuario.Text
            Datos.Contraseña = txtContraseña.Text
            If Funcion.AccesoUsuario(Datos) = True Then
                SessionUsuario.Usuario = Convert.ToString(Datos.Usuario)
                ObtenerDatosUsuario(SessionUsuario.Usuario)
                MessageBox.Show("Bienvenido " & SessionUsuario.NombreCompleto & " al Sistema de Inventario PDM N° 41", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                mdiPrincipalPDM.Show()
            ElseIf Funcion.AccesoUsuario(Datos) = False And txtUsuario.Text.Length = 0 And txtContraseña.Text.Length = 0 Then
                MessageBox.Show("Campos Vacios, Por Favor rellenar los campos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtUsuario.Clear()
                txtContraseña.Clear()
                txtUsuario.Focus()
            ElseIf Funcion.AccesoUsuario(Datos) = False And txtUsuario.Text.Length = 0 Or txtContraseña.Text.Length = 0 Then
                MessageBox.Show("Ingresar Usuario y/o Contraseña", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtUsuario.Clear()
                txtContraseña.Clear()
                txtUsuario.Focus()
            Else
                MessageBox.Show("Usuario o Contraseña Incorrectos o No Tiene Acceso al Sistema", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUsuario.Clear()
                txtContraseña.Clear()
                txtUsuario.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
