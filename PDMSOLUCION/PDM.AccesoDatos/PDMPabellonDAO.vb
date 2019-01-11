Imports System.Data.SqlClient
Imports PDM.Entidades

Public Class PDMPabellonDAO
    Private DbConnection As DatabaseFactorySectionHandler

    Public Sub New()
        DbConnection = New DatabaseFactorySectionHandler
    End Sub

    Public Function InsertarPabellon(oPDMPabellonBE As PDMPabellonBE) As Boolean
        Dim boolRegistrado As Boolean = False
        Try
            Dim retValue As Integer
            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand()
                    sqlCmd.CommandText = "SP_SEL_INSERTARPABELLON"
                    sqlCmd.Connection = sqlCnx
                    sqlCmd.CommandType = CommandType.StoredProcedure
                    sqlCmd.Parameters.Add("@IDLOGIN", SqlDbType.Int).Value = oPDMPabellonBE.idLogin
                    sqlCmd.Parameters.Add("@NOMPABELLON", SqlDbType.VarChar, 300).Value = oPDMPabellonBE.NomPabellon
                    sqlCmd.Parameters.Add("@CANTPISOS", SqlDbType.Int).Value = oPDMPabellonBE.CantPisos
                    sqlCmd.Parameters.Add("@CANTAMBIENTE", SqlDbType.Int).Value = oPDMPabellonBE.CantAmbientes
                    sqlCmd.Parameters.Add("@ESTADO", SqlDbType.Int).Value = oPDMPabellonBE.Estado
                    sqlCmd.Parameters.Add("@FECHAINGRESO", SqlDbType.DateTime).Value = oPDMPabellonBE.FechaIngreso
                    sqlCmd.Parameters.Add("@FECHAMODIFICACION", SqlDbType.DateTime).Value = oPDMPabellonBE.FechaModificacion
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

    Public Function ActualizarPabellon(oPDMPabellonBE As PDMPabellonBE) As Boolean
        Dim boolActualizado As Boolean = False
        Try
            Dim retValue As Integer
            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand()
                    sqlCmd.CommandText = "SP_SEL_ACTUALIZARPABELLON"
                    sqlCmd.Connection = sqlCnx
                    sqlCmd.CommandType = CommandType.StoredProcedure
                    sqlCmd.Parameters.Add("@IDPABELLON", SqlDbType.Int).Value = oPDMPabellonBE.idPabellon
                    sqlCmd.Parameters.Add("@IDLOGIN", SqlDbType.Int).Value = oPDMPabellonBE.idLogin
                    sqlCmd.Parameters.Add("@NOMPABELLON", SqlDbType.VarChar, 300).Value = oPDMPabellonBE.NomPabellon
                    sqlCmd.Parameters.Add("@CANTPISOS", SqlDbType.Int).Value = oPDMPabellonBE.CantPisos
                    sqlCmd.Parameters.Add("@CANTAMBIENTE", SqlDbType.Int).Value = oPDMPabellonBE.CantAmbientes
                    sqlCmd.Parameters.Add("@ESTADO", SqlDbType.Int).Value = oPDMPabellonBE.Estado
                    sqlCmd.Parameters.Add("@FECHAMODIFICACION", SqlDbType.DateTime).Value = oPDMPabellonBE.FechaModificacion
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

    Public Function ObtenerPabellon(cadena As String) As PDMPabellonBE
        Dim oPDMPabellonBE As New PDMPabellonBE
        Try
            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand()
                    sqlCmd.CommandText = "SP_SEL_ObtenerPabellon"
                    sqlCmd.Connection = sqlCnx
                    sqlCmd.CommandType = CommandType.StoredProcedure
                    sqlCmd.Parameters.Add("@NomPabellon", SqlDbType.VarChar, 300).Value = cadena
                    Using reader As SqlDataReader = sqlCmd.ExecuteReader(CommandBehavior.SingleRow)
                        While reader.Read()
                            oPDMPabellonBE.idPabellon = reader("Codigo")
                            oPDMPabellonBE.NomPabellon = reader("Pabellon")
                            oPDMPabellonBE.CantPisos = reader("Pisos")
                            oPDMPabellonBE.CantAmbientes = reader("Ambientes")
                            oPDMPabellonBE.Estado = reader("Estado")
                            Exit While
                        End While
                    End Using
                End Using
                sqlCnx.Close()
            End Using
        Catch ex As Exception
            Throw ex
        End Try
        Return oPDMPabellonBE
    End Function

    Public Function ObtenerTableXPabellon(cadena As String) As DataTable
        Dim table As New DataTable
        Try

            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand()
                    sqlCmd.CommandText = "SP_SEL_ObtenerPabellon"
                    sqlCmd.Connection = sqlCnx
                    sqlCmd.CommandType = CommandType.StoredProcedure
                    sqlCmd.Parameters.Add("@NomPabellon", SqlDbType.VarChar, 300).Value = cadena
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

    Public Function TablePabellones() As DataTable
        Dim table As New DataTable
        Try

            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand()
                    sqlCmd.CommandText = "SP_SEL_LISTARPABELLONES"
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
