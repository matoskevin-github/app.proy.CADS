Imports System.Data.SqlClient
Imports PDM.Entidades

Public Class PDMAmbientesDAO
    Private DbConnection As DatabaseFactorySectionHandler

    Public Sub New()
        DbConnection = New DatabaseFactorySectionHandler
    End Sub

    Public Function InsertarAmbiente(oPDMAmbientesBE As PDMAmbientesBE) As Boolean
        Dim boolRegistrado As Boolean = False
        Try
            Dim retValue As Integer
            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand()
                    sqlCmd.CommandText = "SP_SEL_INSERTARAMBIENTES"
                    sqlCmd.Connection = sqlCnx
                    sqlCmd.CommandType = CommandType.StoredProcedure
                    sqlCmd.Parameters.Add("@DETALLE", SqlDbType.VarChar, 300).Value = oPDMAmbientesBE.Detalle
                    sqlCmd.Parameters.Add("@IDPABELLON", SqlDbType.Int).Value = oPDMAmbientesBE.idPabellon
                    sqlCmd.Parameters.Add("@IDPISOS", SqlDbType.Int).Value = oPDMAmbientesBE.idPisos
                    sqlCmd.Parameters.Add("@IDLOGIN", SqlDbType.Int).Value = oPDMAmbientesBE.idLogin
                    sqlCmd.Parameters.Add("@ESTADO", SqlDbType.Int).Value = oPDMAmbientesBE.Estado
                    sqlCmd.Parameters.Add("@FECHAINGRESO", SqlDbType.DateTime).Value = oPDMAmbientesBE.FechaIngreso
                    sqlCmd.Parameters.Add("@FECHAMODIFICACION", SqlDbType.DateTime).Value = oPDMAmbientesBE.FechaModificacion
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

    Public Function ActualizarAmbiente(oPDMAmbientesBE As PDMAmbientesBE) As Boolean
        Dim boolActualizado As Boolean = False
        Try
            Dim retValue As Integer
            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand()
                    sqlCmd.CommandText = "SP_SEL_ACTUALIZARAMBIENTES"
                    sqlCmd.Connection = sqlCnx
                    sqlCmd.CommandType = CommandType.StoredProcedure
                    sqlCmd.Parameters.Add("@IDAMBIENTE", SqlDbType.Int).Value = oPDMAmbientesBE.idAmbiente
                    sqlCmd.Parameters.Add("@DETALLE", SqlDbType.VarChar, 300).Value = oPDMAmbientesBE.Detalle
                    sqlCmd.Parameters.Add("@IDPABELLON", SqlDbType.Int).Value = oPDMAmbientesBE.idPabellon
                    sqlCmd.Parameters.Add("@IDPISOS", SqlDbType.Int).Value = oPDMAmbientesBE.idPisos
                    sqlCmd.Parameters.Add("@IDLOGIN", SqlDbType.Int).Value = oPDMAmbientesBE.idLogin
                    sqlCmd.Parameters.Add("@ESTADO", SqlDbType.Int).Value = oPDMAmbientesBE.Estado
                    sqlCmd.Parameters.Add("@FECHAMODIFICACION", SqlDbType.DateTime).Value = oPDMAmbientesBE.FechaModificacion
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

    Public Function ObtenerTableXAmbiente(cadena As String) As DataTable
        Dim table As New DataTable
        Try

            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand()
                    sqlCmd.CommandText = "SP_SEL_ObtenerAmbientes"
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

    Public Function TableAmbientes() As DataTable
        Dim table As New DataTable
        Try

            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand()
                    sqlCmd.CommandText = "SP_SEL_LISTARAMBIENTES"
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

    Public Function ObtenerPabellones() As List(Of PDMPabellonBE)
        Dim listaResp As New List(Of PDMPabellonBE)
        Try
            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand()
                    sqlCmd.CommandText = "SP_SEL_LPABELLONES"
                    sqlCmd.Connection = sqlCnx
                    sqlCmd.CommandType = CommandType.StoredProcedure
                    Using reader As SqlDataReader = sqlCmd.ExecuteReader()
                        While reader.Read()
                            Dim _PabellonBE As New PDMPabellonBE
                            _PabellonBE.idPabellon = reader("idPabellon")
                            _PabellonBE.NomPabellon = reader("NomPabellon")
                            listaResp.Add(_PabellonBE)
                        End While
                        listaResp.Insert(0, New PDMPabellonBE With {
                            .idPabellon = 0,
                            .NomPabellon = "--SELECCIONAR--"
                            })
                    End Using
                End Using
                sqlCnx.Close()
            End Using
        Catch ex As Exception
            Throw ex
        End Try
        Return listaResp
    End Function

    Public Function ObtenerPisos() As List(Of PDMPisosBE)
        Dim listaResp As New List(Of PDMPisosBE)
        Try
            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand()
                    sqlCmd.CommandText = "SP_SEL_LPISOS"
                    sqlCmd.Connection = sqlCnx
                    sqlCmd.CommandType = CommandType.StoredProcedure
                    Using reader As SqlDataReader = sqlCmd.ExecuteReader()
                        While reader.Read()
                            Dim _PisosBE As New PDMPisosBE
                            _PisosBE.idPisos = reader("idPisos")
                            _PisosBE.NomPiso = reader("NomPiso")
                            listaResp.Add(_PisosBE)
                        End While
                        listaResp.Insert(0, New PDMPisosBE With {
                            .idPisos = 0,
                            .NomPiso = "--SELECCIONAR--"
                            })
                    End Using
                End Using
                sqlCnx.Close()
            End Using
        Catch ex As Exception
            Throw ex
        End Try
        Return listaResp
    End Function

End Class
