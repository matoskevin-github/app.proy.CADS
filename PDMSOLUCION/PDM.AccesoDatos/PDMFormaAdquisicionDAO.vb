Imports System.Data.SqlClient
Imports PDM.Entidades

Public Class PDMFormaAdquisicionDAO
    Private DbConnection As DatabaseFactorySectionHandler

    Public Sub New()
        DbConnection = New DatabaseFactorySectionHandler
    End Sub

    Public Function InsertarFormaAdquisicion(oPDMFormaAdquisicionBE As PDMFormaAdquisicionBE) As Boolean
        Dim boolRegistrado As Boolean = False
        Try
            Dim retValue As Integer
            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand()
                    sqlCmd.CommandText = "SP_SEL_INSERTARFORMAADQUISICION"
                    sqlCmd.Connection = sqlCnx
                    sqlCmd.CommandType = CommandType.StoredProcedure
                    sqlCmd.Parameters.Add("@IDLOGIN", SqlDbType.Int).Value = oPDMFormaAdquisicionBE.idLogin
                    sqlCmd.Parameters.Add("@DETALLE", SqlDbType.VarChar, 300).Value = oPDMFormaAdquisicionBE.Detalle
                    sqlCmd.Parameters.Add("@ESTADO", SqlDbType.Int).Value = oPDMFormaAdquisicionBE.Estado
                    sqlCmd.Parameters.Add("@FECHAINGRESO", SqlDbType.DateTime).Value = oPDMFormaAdquisicionBE.FechaIngreso
                    sqlCmd.Parameters.Add("@FECHAMODIFICACION", SqlDbType.DateTime).Value = oPDMFormaAdquisicionBE.FechaModificacion
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

    Public Function ActualizarFormaAdquisicion(oPDMFormaAdquisicionBE As PDMFormaAdquisicionBE) As Boolean
        Dim boolActualizado As Boolean = False
        Try
            Dim retValue As Integer
            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand()
                    sqlCmd.CommandText = "SP_SEL_ACTUALIZARFORMAADQUISICION"
                    sqlCmd.Connection = sqlCnx
                    sqlCmd.CommandType = CommandType.StoredProcedure
                    sqlCmd.Parameters.Add("@FORMAADQUISICION", SqlDbType.Int).Value = oPDMFormaAdquisicionBE.idFormaAdquisicion
                    sqlCmd.Parameters.Add("@IDLOGIN", SqlDbType.Int).Value = oPDMFormaAdquisicionBE.idLogin
                    sqlCmd.Parameters.Add("@DETALLE", SqlDbType.VarChar, 300).Value = oPDMFormaAdquisicionBE.Detalle
                    sqlCmd.Parameters.Add("@ESTADO", SqlDbType.Int).Value = oPDMFormaAdquisicionBE.Estado
                    sqlCmd.Parameters.Add("@FECHAMODIFICACION", SqlDbType.DateTime).Value = oPDMFormaAdquisicionBE.FechaModificacion
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

    Public Function ObtenerTableXFormaAdquisicion(cadena As String) As DataTable
        Dim table As New DataTable
        Try
            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand()
                    sqlCmd.CommandText = "SP_SEL_ObtenerFormaAdquisicion"
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

    Public Function TableFormaAdquisicion() As DataTable
        Dim table As New DataTable
        Try

            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand()
                    sqlCmd.CommandText = "SP_SEL_LISTARFORMAADQUISICION"
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
