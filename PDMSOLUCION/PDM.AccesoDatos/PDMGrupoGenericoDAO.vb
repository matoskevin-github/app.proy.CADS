Imports System.Data.SqlClient
Imports PDM.Entidades

Public Class PDMGrupoGenericoDAO
    Private DbConnection As DatabaseFactorySectionHandler


    Public Sub New()
        DbConnection = New DatabaseFactorySectionHandler
    End Sub

    Public Function InsertarGrupoGenerico(oPDMGrupoGenericoBE As PDMGrupoGenericoBE) As Boolean
        Dim boolRegistrado As Boolean = False
        Try
            Dim retValue As Integer
            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand()
                    sqlCmd.CommandText = "SP_SEL_INSERTARGRUPOGENERICO"
                    sqlCmd.Connection = sqlCnx
                    sqlCmd.CommandType = CommandType.StoredProcedure
                    sqlCmd.Parameters.Add("@IDLOGIN", SqlDbType.Int).Value = oPDMGrupoGenericoBE.idLogin
                    sqlCmd.Parameters.Add("@CODIGO", SqlDbType.VarChar, 300).Value = oPDMGrupoGenericoBE.Codigo
                    sqlCmd.Parameters.Add("@DETALLE", SqlDbType.VarChar, 300).Value = oPDMGrupoGenericoBE.Detalle
                    sqlCmd.Parameters.Add("@ESTADO", SqlDbType.Int).Value = oPDMGrupoGenericoBE.Estado
                    sqlCmd.Parameters.Add("@FECHAINGRESO", SqlDbType.DateTime).Value = oPDMGrupoGenericoBE.FechaIngreso
                    sqlCmd.Parameters.Add("@FECHAMODIFICACION", SqlDbType.DateTime).Value = oPDMGrupoGenericoBE.FechaModificacion
                    retValue = sqlCmd.ExecuteNonQuery()

                    If (retValue > 0) Then
                        boolRegistrado = True
                    End If

                End Using
                sqlCnx.Close()
            End Using
        Catch ex As Exception
            Throw ex
        End Try
        Return boolRegistrado
    End Function

    Public Function ActualizarGrupoGenerico(oPDMGrupoGenericoBE As PDMGrupoGenericoBE) As Boolean
        Dim boolActualizado As Boolean = False
        Try
            Dim retValue As Integer
            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand()
                    sqlCmd.CommandText = "SP_SEL_ACTUALIZARGRUPOGENERICO"
                    sqlCmd.Connection = sqlCnx
                    sqlCmd.CommandType = CommandType.StoredProcedure
                    sqlCmd.Parameters.Add("@IDGRUPOGENERICO", SqlDbType.Int).Value = oPDMGrupoGenericoBE.idGrupoGenerico
                    sqlCmd.Parameters.Add("@IDLOGIN", SqlDbType.Int).Value = oPDMGrupoGenericoBE.idLogin
                    sqlCmd.Parameters.Add("@CODIGO", SqlDbType.VarChar, 300).Value = oPDMGrupoGenericoBE.Codigo
                    sqlCmd.Parameters.Add("@DETALLE", SqlDbType.VarChar, 300).Value = oPDMGrupoGenericoBE.Detalle
                    sqlCmd.Parameters.Add("@ESTADO", SqlDbType.Int).Value = oPDMGrupoGenericoBE.Estado
                    sqlCmd.Parameters.Add("@FECHAMODIFICACION", SqlDbType.DateTime).Value = oPDMGrupoGenericoBE.FechaModificacion
                    retValue = sqlCmd.ExecuteNonQuery()
                    If (retValue > 0) Then
                        boolActualizado = True
                    End If
                End Using
                sqlCnx.Close()
            End Using
        Catch ex As Exception
            Throw ex
        End Try
        Return boolActualizado
    End Function

    Public Function ObtenerTableXGrupoGenerico(cadena As String) As DataTable
        Dim table As New DataTable
        Try
            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand()
                    sqlCmd.CommandText = "SP_SEL_ObtenerGrupoGenerico"
                    sqlCmd.Connection = sqlCnx
                    sqlCmd.CommandType = CommandType.StoredProcedure
                    sqlCmd.Parameters.Add("@Detalle", SqlDbType.VarChar, 300).Value = cadena
                    Dim daSql As New SqlDataAdapter(sqlCmd)
                    daSql.Fill(table)
                End Using
                sqlCnx.Close()
            End Using
        Catch ex As Exception
            Throw ex
        End Try
        Return table
    End Function

    Public Function TableGrupoGenerico() As DataTable
        Dim table As New DataTable
        Try

            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand()
                    sqlCmd.CommandText = "SP_SEL_LISTARGRUPOGENERICO"
                    sqlCmd.Connection = sqlCnx
                    sqlCmd.CommandType = CommandType.StoredProcedure
                    Dim daSql As New SqlDataAdapter(sqlCmd)
                    daSql.Fill(table)
                End Using
                sqlCnx.Close()
            End Using
        Catch ex As Exception
            Throw ex
        End Try
        Return table
    End Function

End Class
