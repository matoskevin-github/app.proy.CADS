Imports System.Data.SqlClient
Imports PDM.Entidades

Public Class PDMLoginDAO : Implements PDMLoginServicio
    Private DbConnection As DatabaseFactorySectionHandler


    Public Sub New()
        DbConnection = New DatabaseFactorySectionHandler
    End Sub

    Public Function AccesoUsuario(loginBE As PDMLoginBE) As Boolean Implements PDMLoginServicio.AccesoUsuario
        Dim boolAcceso As Boolean = False
        Dim registro As Integer
        Try
            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand()
                    sqlCmd.CommandText = "SP_SEL_INICIO_SESION"
                    sqlCmd.Connection = sqlCnx
                    sqlCmd.CommandType = CommandType.StoredProcedure
                    sqlCmd.Parameters.AddWithValue("@usuario", loginBE.Usuario)
                    sqlCmd.Parameters.AddWithValue("@contraseña", loginBE.Contraseña)
                    Using reader As SqlDataReader = sqlCmd.ExecuteReader(CommandBehavior.SingleRow)
                        While reader.Read()
                            registro = Conversion.Int(reader("EXISTE"))
                            Exit While
                        End While
                        If (registro <> 0) Then
                            boolAcceso = True
                        End If
                    End Using
                End Using
                sqlCnx.Close()
            End Using
        Catch ex As Exception
            Throw ex
        End Try
        Return boolAcceso
    End Function

    Public Function ObtenerInfoUsuario(Usuario As String) As PDMResponsableBE
        Dim oPDMResponsableBE As New PDMResponsableBE
        Try
            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand()
                    sqlCmd.CommandText = "SP_SEL_OBTENERINFOUSUARIO"
                    sqlCmd.Connection = sqlCnx
                    sqlCmd.CommandType = CommandType.StoredProcedure
                    sqlCmd.Parameters.Add("@usuario", SqlDbType.VarChar, 30).Value = Usuario

                    Using reader As SqlDataReader = sqlCmd.ExecuteReader(CommandBehavior.SingleRow)
                        While reader.Read()
                            oPDMResponsableBE.idUsuario = reader("idLogin")
                            oPDMResponsableBE.Nombres = reader("Nombres")
                            oPDMResponsableBE.Apellidos = reader("Apellidos")
                            oPDMResponsableBE.TipoUsuario = reader("TipoUsuario")
                            oPDMResponsableBE.idResponsable = reader("idResponsable")

                            Exit While
                        End While

                    End Using
                End Using
                sqlCnx.Close()
            End Using
        Catch ex As Exception
            Throw ex
        End Try
        Return oPDMResponsableBE
    End Function

End Class
