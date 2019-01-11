Imports System.Data.SqlClient
Imports PDM.Entidades

Public Class PDMEntidadDAO
    Private DbConnection As DatabaseFactorySectionHandler


    Public Sub New()
        DbConnection = New DatabaseFactorySectionHandler
    End Sub

    Public Function InsertarEntidad(oPDMEntidadBE As PDMEntidadBE) As Boolean
        Dim boolRegistrado As Boolean = False
        Try
            Dim retValue As Integer
            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand()
                    sqlCmd.CommandText = "SP_SEL_INSERTARENTIDAD"
                    sqlCmd.Connection = sqlCnx
                    sqlCmd.CommandType = CommandType.StoredProcedure
                    sqlCmd.Parameters.Add("@IDLOGIN", SqlDbType.Int).Value = oPDMEntidadBE.idLogin
                    sqlCmd.Parameters.Add("@DETALLE", SqlDbType.VarChar, 300).Value = oPDMEntidadBE.Detalle
                    sqlCmd.Parameters.Add("@ESTADO", SqlDbType.Int).Value = oPDMEntidadBE.estado
                    sqlCmd.Parameters.Add("@FECHAINGRESO", SqlDbType.DateTime).Value = oPDMEntidadBE.fechaIngreso
                    sqlCmd.Parameters.Add("@FECHAMODIFICACION", SqlDbType.DateTime).Value = oPDMEntidadBE.fechaModificacion
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

    Public Function ActualizarEntidad(oPDMEntidadBE As PDMEntidadBE) As Boolean
        Dim boolActualizado As Boolean = False
        Try
            Dim retValue As Integer
            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand()
                    sqlCmd.CommandText = "SP_SEL_ACTUALIZARENTIDAD"
                    sqlCmd.Connection = sqlCnx
                    sqlCmd.CommandType = CommandType.StoredProcedure
                    sqlCmd.Parameters.Add("@idEntidad", SqlDbType.Int).Value = oPDMEntidadBE.idEntidad
                    sqlCmd.Parameters.Add("@IDLOGIN", SqlDbType.Int).Value = oPDMEntidadBE.idLogin
                    sqlCmd.Parameters.Add("@DETALLE", SqlDbType.VarChar, 300).Value = oPDMEntidadBE.Detalle
                    sqlCmd.Parameters.Add("@ESTADO", SqlDbType.Int).Value = oPDMEntidadBE.estado
                    sqlCmd.Parameters.Add("@FECHAMODIFICACION", SqlDbType.DateTime).Value = oPDMEntidadBE.fechaModificacion
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

    Public Function ObtenerEntidad(cadena As String) As PDMEntidadBE
        Dim oPDMEntidadBE As New PDMEntidadBE
        Try

            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand()
                    sqlCmd.CommandText = "SP_SEL_ObtenerENTIDADES"
                    sqlCmd.Connection = sqlCnx
                    sqlCmd.CommandType = CommandType.StoredProcedure
                    sqlCmd.Parameters.Add("@Detalle", SqlDbType.VarChar, 300).Value = cadena

                    Using reader As SqlDataReader = sqlCmd.ExecuteReader(CommandBehavior.SingleRow)
                        While reader.Read()
                            oPDMEntidadBE.idEntidad = reader("Codigo")
                            oPDMEntidadBE.Detalle = reader("Entidad")
                            oPDMEntidadBE.estado = reader("Estado")
                            Exit While
                        End While

                    End Using

                End Using
                sqlCnx.Close()
            End Using
        Catch ex As Exception
            Throw ex
        End Try
        Return oPDMEntidadBE
    End Function

    Public Function ObtenerTableXEntidad(cadena As String) As DataTable
        Dim table As New DataTable
        Try

            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand()
                    sqlCmd.CommandText = "SP_SEL_ObtenerENTIDADES"
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

    'Public Function ListaEntidades() As List(Of PDMEntidadBE)
    '    Dim oPDMEntidadBE As New PDMEntidadBE
    '    Dim lstPDMEntidadBE As New List(Of PDMEntidadBE)
    '    Try

    '        Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
    '            sqlCnx.Open()
    '            Using sqlCmd As SqlCommand = New SqlCommand()
    '                sqlCmd.CommandText = "SP_SEL_LISTARENTIDADES"
    '                sqlCmd.Connection = sqlCnx
    '                sqlCmd.CommandType = CommandType.StoredProcedure


    '                Using reader As SqlDataReader = sqlCmd.ExecuteReader()
    '                    While reader.Read()
    '                        oPDMEntidadBE.idEntidad = reader("idEntidad")
    '                        oPDMEntidadBE.Detalle = reader("Entidad")
    '                        oPDMEntidadBE.estado = reader("Estado")
    '                        lstPDMEntidadBE.Add(oPDMEntidadBE)
    '                    End While
    '                End Using

    '            End Using
    '            sqlCnx.Close()
    '        End Using
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    '    Return lstPDMEntidadBE
    'End Function


    Public Function TableEntidades() As DataTable
        Dim table As New DataTable
        Try

            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand()
                    sqlCmd.CommandText = "SP_SEL_LISTARENTIDADES"
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
