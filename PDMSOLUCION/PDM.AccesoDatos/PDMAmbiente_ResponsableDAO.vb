Imports System.Data.SqlClient
Imports PDM.Entidades
Imports System.Windows.Forms

Public Class PDMAmbiente_ResponsableDAO
    Private DbConnection As DatabaseFactorySectionHandler

    Public Sub New()
        DbConnection = New DatabaseFactorySectionHandler
    End Sub

    Public Function InsertarAmbiente_Responsable(oPDMAmbientesxResponsableBE As PDMAmbiente_ResponsableBE) As Boolean
        Dim boolRegistrado As Boolean = False
        Try
            Dim retValue As Integer
            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand()
                    sqlCmd.CommandText = "SP_SEL_INGRESAR_AMBIENTE_RESPONSABLE"
                    sqlCmd.Connection = sqlCnx
                    sqlCmd.CommandType = CommandType.StoredProcedure
                    sqlCmd.Parameters.Add("@IDAMBIENTE", SqlDbType.Int).Value = oPDMAmbientesxResponsableBE.idAmbiente
                    sqlCmd.Parameters.Add("@IDRESPONSABLE", SqlDbType.Int).Value = oPDMAmbientesxResponsableBE.idResponsable
                    sqlCmd.Parameters.Add("@IDLOGIN", SqlDbType.Int).Value = oPDMAmbientesxResponsableBE.idLogin
                    sqlCmd.Parameters.Add("@FECHAINGRESO", SqlDbType.DateTime).Value = oPDMAmbientesxResponsableBE.FechaIngreso
                    sqlCmd.Parameters.Add("@FECHAMODIFICACION", SqlDbType.DateTime).Value = oPDMAmbientesxResponsableBE.FechaModificacion
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

    Public Function ActualizarAmbiente_Responsable(oPDMAmbientesxResponsableBE As PDMAmbiente_ResponsableBE) As Boolean
        Dim boolActualizado As Boolean = False
        Try
            Dim retValue As Integer
            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand()
                    sqlCmd.CommandText = "SP_SEL_ACTUALIZAR_AMBIENTE_RESPONSABLE"
                    sqlCmd.Connection = sqlCnx
                    sqlCmd.CommandType = CommandType.StoredProcedure
                    sqlCmd.Parameters.Add("@IDAMBIENTERESPONSABLE", SqlDbType.Int).Value = oPDMAmbientesxResponsableBE.idAmbienteResponsable
                    sqlCmd.Parameters.Add("@IDAMBIENTE", SqlDbType.Int).Value = oPDMAmbientesxResponsableBE.idAmbiente
                    sqlCmd.Parameters.Add("@IDRESPONSABLE", SqlDbType.Int).Value = oPDMAmbientesxResponsableBE.idResponsable
                    sqlCmd.Parameters.Add("@IDLOGIN", SqlDbType.Int).Value = oPDMAmbientesxResponsableBE.idLogin
                    sqlCmd.Parameters.Add("@FECHAINGRESO", SqlDbType.DateTime).Value = oPDMAmbientesxResponsableBE.FechaIngreso
                    sqlCmd.Parameters.Add("@FECHAMODIFICACION", SqlDbType.DateTime).Value = oPDMAmbientesxResponsableBE.FechaModificacion
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

    Public Function TableAmbientes() As DataTable
        Dim table As New DataTable
        Try

            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand()
                    sqlCmd.CommandText = "SP_SEL_LISTA_LAMBIENTES"
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

    Public Function ObtenerTableXAmbiente(cadena As String) As DataTable
        Dim table As New DataTable
        Try

            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand()
                    sqlCmd.CommandText = "SP_SEL_OBTENER_LAMBIENTES"
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

    Public Function ObtenerResponsablexAmbiente(codigo As Integer) As DataTable
        Dim table As New DataTable
        Try

            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand()
                    sqlCmd.CommandText = "SP_SEL_OBTENER_AMBIENTE_RESPONSABLE"
                    sqlCmd.Connection = sqlCnx
                    sqlCmd.CommandType = CommandType.StoredProcedure
                    sqlCmd.Parameters.Add("@IDRESPONSABLE", SqlDbType.Int).Value = codigo
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

    Public Sub getCollectionResponsable(ByVal autoComplete As AutoCompleteStringCollection)
        Try
            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand()
                    sqlCmd.CommandText = "SP_SEL_OBTENER_LRESPONSABLE"
                    sqlCmd.Connection = sqlCnx
                    sqlCmd.CommandType = CommandType.StoredProcedure
                    Using reader As SqlDataReader = sqlCmd.ExecuteReader()
                        While reader.Read()
                            autoComplete.Add(reader("RESPONSABLE"))
                        End While
                    End Using
                End Using
                sqlCnx.Close()
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Sub




End Class
