Imports System.Data.SqlClient
Imports PDM.Entidades

Public Class PDMCargoDAO
    Private DbConnection As DatabaseFactorySectionHandler


    Public Sub New()
        DbConnection = New DatabaseFactorySectionHandler
    End Sub

    Public Function InsertarCargo(oPDMCargoBE As PDMCargoBE) As Boolean
        Dim boolRegistrado As Boolean = False
        Try
            Dim retValue As Integer
            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand()
                    sqlCmd.CommandText = "SP_SEL_INSERTARCARGO"
                    sqlCmd.Connection = sqlCnx
                    sqlCmd.CommandType = CommandType.StoredProcedure
                    sqlCmd.Parameters.Add("@IDLOGIN", SqlDbType.Int).Value = oPDMCargoBE.idLogin
                    sqlCmd.Parameters.Add("@DETALLE", SqlDbType.VarChar, 300).Value = oPDMCargoBE.Detalle
                    sqlCmd.Parameters.Add("@ESTADO", SqlDbType.Int).Value = oPDMCargoBE.Estado
                    sqlCmd.Parameters.Add("@FECHAINGRESO", SqlDbType.DateTime).Value = oPDMCargoBE.FechaIngreso
                    sqlCmd.Parameters.Add("@FECHAMODIFICACION", SqlDbType.DateTime).Value = oPDMCargoBE.FechaModificacion
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

    Public Function ActualizarCargo(oPDMCargoBE As PDMCargoBE) As Boolean
        Dim boolActualizado As Boolean = False
        Try
            Dim retValue As Integer
            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand()
                    sqlCmd.CommandText = "SP_SEL_ACTUALIZARCARGO"
                    sqlCmd.Connection = sqlCnx
                    sqlCmd.CommandType = CommandType.StoredProcedure
                    sqlCmd.Parameters.Add("@idCargo", SqlDbType.Int).Value = oPDMCargoBE.idCargo
                    sqlCmd.Parameters.Add("@IDLOGIN", SqlDbType.Int).Value = oPDMCargoBE.idLogin
                    sqlCmd.Parameters.Add("@DETALLE", SqlDbType.VarChar, 300).Value = oPDMCargoBE.Detalle
                    sqlCmd.Parameters.Add("@ESTADO", SqlDbType.Int).Value = oPDMCargoBE.Estado
                    sqlCmd.Parameters.Add("@FECHAMODIFICACION", SqlDbType.DateTime).Value = oPDMCargoBE.FechaModificacion
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

    Public Function ObtenerCargo(cadena As String) As PDMCargoBE
        Dim oPDMCargoBE As New PDMCargoBE
        Try

            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand()
                    sqlCmd.CommandText = "SP_SEL_ObtenerCargo"
                    sqlCmd.Connection = sqlCnx
                    sqlCmd.CommandType = CommandType.StoredProcedure
                    sqlCmd.Parameters.Add("@Detalle", SqlDbType.VarChar, 300).Value = cadena

                    Using reader As SqlDataReader = sqlCmd.ExecuteReader(CommandBehavior.SingleRow)
                        While reader.Read()
                            oPDMCargoBE.idCargo = reader("Codigo")
                            oPDMCargoBE.Detalle = reader("Cargo")
                            oPDMCargoBE.Estado = reader("Estado")
                            Exit While
                        End While

                    End Using

                End Using
                sqlCnx.Close()
            End Using
        Catch ex As Exception
            Throw ex
        End Try
        Return oPDMCargoBE
    End Function

    Public Function ObtenerTableXCargo(cadena As String) As DataTable
        Dim table As New DataTable
        Try

            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand()
                    sqlCmd.CommandText = "SP_SEL_ObtenerCargo"
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

    Public Function TableCargo() As DataTable
        Dim table As New DataTable
        Try

            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand()
                    sqlCmd.CommandText = "SP_SEL_LISTARCARGO"
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
