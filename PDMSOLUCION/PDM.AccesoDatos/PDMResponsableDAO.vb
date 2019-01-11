Imports System.Data.SqlClient
Imports PDM.Entidades
Imports System.Windows.Forms

Public Class PDMResponsableDAO
    Private DbConnection As DatabaseFactorySectionHandler

    Public Sub New()
        DbConnection = New DatabaseFactorySectionHandler
    End Sub

    Public Function InsertarResonsable(oPDMResponsableBE As PDMResponsableBE) As Boolean
        Dim boolRegistrado As Boolean = False
        Try
            Dim retValue As Integer
            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand()
                    sqlCmd.CommandText = "SP_SEL_INSERTAR_RESPONSABLE"
                    sqlCmd.Connection = sqlCnx
                    sqlCmd.CommandType = CommandType.StoredProcedure
                    sqlCmd.Parameters.Add("@NOMBRES", SqlDbType.VarChar, 100).Value = oPDMResponsableBE.Nombres
                    sqlCmd.Parameters.Add("@APELLIDOS", SqlDbType.VarChar, 100).Value = oPDMResponsableBE.Apellidos
                    sqlCmd.Parameters.Add("@DNI", SqlDbType.VarChar, 8).Value = oPDMResponsableBE.DNI
                    sqlCmd.Parameters.Add("@DIRECCION", SqlDbType.VarChar, 100).Value = oPDMResponsableBE.Direccion
                    sqlCmd.Parameters.Add("@CORREO", SqlDbType.VarChar, 100).Value = oPDMResponsableBE.Correo
                    sqlCmd.Parameters.Add("@CELULAR", SqlDbType.VarChar, 100).Value = oPDMResponsableBE.Celular
                    sqlCmd.Parameters.Add("@ESTADOCIVIL", SqlDbType.VarChar, 20).Value = oPDMResponsableBE.EstadoCivil
                    sqlCmd.Parameters.Add("@FECHANACIMIENTO", SqlDbType.DateTime).Value = oPDMResponsableBE.FechaNacimiento
                    sqlCmd.Parameters.Add("@IDCARGO", SqlDbType.Int).Value = oPDMResponsableBE.idCargo
                    sqlCmd.Parameters.Add("@IDLOGIN", SqlDbType.Int).Value = oPDMResponsableBE.idUsuario
                    sqlCmd.Parameters.Add("@CONDICION", SqlDbType.VarChar, 20).Value = oPDMResponsableBE.Condicion
                    sqlCmd.Parameters.Add("@FECHAINGRESO", SqlDbType.DateTime).Value = oPDMResponsableBE.FechaIngreso
                    sqlCmd.Parameters.Add("@ESTADO", SqlDbType.Int).Value = oPDMResponsableBE.Estado
                    sqlCmd.Parameters.Add("@FECHAINGRESOR", SqlDbType.DateTime).Value = oPDMResponsableBE.FechaIngresoR
                    sqlCmd.Parameters.Add("@FECHAMODIFICACION", SqlDbType.DateTime).Value = oPDMResponsableBE.FechaModificacion
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

    Public Function ActualizarResponsable(oPDMResponsableBE As PDMResponsableBE) As Boolean
        Dim boolActualizado As Boolean = False
        Try
            Dim retValue As Integer
            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand()
                    sqlCmd.CommandText = "SP_SEL_ACTUALIZAR_RESPONSABLE"
                    sqlCmd.Connection = sqlCnx
                    sqlCmd.CommandType = CommandType.StoredProcedure
                    sqlCmd.Parameters.Add("@IDRESPONSABLE", SqlDbType.Int).Value = oPDMResponsableBE.idResponsable
                    sqlCmd.Parameters.Add("@NOMBRES", SqlDbType.VarChar, 100).Value = oPDMResponsableBE.Nombres
                    sqlCmd.Parameters.Add("@APELLIDOS", SqlDbType.VarChar, 100).Value = oPDMResponsableBE.Apellidos
                    sqlCmd.Parameters.Add("@DNI", SqlDbType.VarChar, 8).Value = oPDMResponsableBE.DNI
                    sqlCmd.Parameters.Add("@DIRECCION", SqlDbType.VarChar, 100).Value = oPDMResponsableBE.Direccion
                    sqlCmd.Parameters.Add("@CORREO", SqlDbType.VarChar, 100).Value = oPDMResponsableBE.Correo
                    sqlCmd.Parameters.Add("@CELULAR", SqlDbType.VarChar, 100).Value = oPDMResponsableBE.Celular
                    sqlCmd.Parameters.Add("@ESTADOCIVIL", SqlDbType.VarChar, 20).Value = oPDMResponsableBE.EstadoCivil
                    sqlCmd.Parameters.Add("@FECHANACIMIENTO", SqlDbType.DateTime).Value = oPDMResponsableBE.FechaNacimiento
                    sqlCmd.Parameters.Add("@IDCARGO", SqlDbType.Int).Value = oPDMResponsableBE.idCargo
                    sqlCmd.Parameters.Add("@IDLOGIN", SqlDbType.Int).Value = oPDMResponsableBE.idUsuario
                    sqlCmd.Parameters.Add("@CONDICION", SqlDbType.VarChar, 20).Value = oPDMResponsableBE.Condicion
                    sqlCmd.Parameters.Add("@FECHAINGRESO", SqlDbType.DateTime).Value = oPDMResponsableBE.FechaIngreso
                    sqlCmd.Parameters.Add("@ESTADO", SqlDbType.Int).Value = oPDMResponsableBE.Estado
                    sqlCmd.Parameters.Add("@FECHAMODIFICACION", SqlDbType.DateTime).Value = oPDMResponsableBE.FechaModificacion
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

    Public Function ObtenerTableXResponsable(cadena As String) As DataTable
        Dim table As New DataTable
        Try

            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand()
                    sqlCmd.CommandText = "SP_SEL_Obtener_Responsable"
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

    Public Function TableResponsable() As DataTable
        Dim table As New DataTable
        Try

            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand()
                    sqlCmd.CommandText = "SP_SEL_LISTAR_RESPONSABLES"
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

    Public Function ObtenerCargo() As List(Of PDMCargoBE)
        Dim listaResp As New List(Of PDMCargoBE)
        Try
            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand()
                    sqlCmd.CommandText = "SP_SEL_LCARGOS"
                    sqlCmd.Connection = sqlCnx
                    sqlCmd.CommandType = CommandType.StoredProcedure
                    Using reader As SqlDataReader = sqlCmd.ExecuteReader()
                        While reader.Read()
                            Dim _CargoBE As New PDMCargoBE
                            _CargoBE.idCargo = reader("idCargo")
                            _CargoBE.Detalle = reader("Detalle")
                            listaResp.Add(_CargoBE)
                        End While
                        listaResp.Insert(0, New PDMCargoBE With {
                            .idCargo = 0,
                            .Detalle = "--SELECCIONAR--"
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

    Public Function ObtenerTableXLCargo(cadena As String) As DataTable
        Dim table As New DataTable
        Try

            Using sqlCnx As SqlConnection = New SqlConnection(DbConnection.DbCnxStr)
                sqlCnx.Open()
                Using sqlCmd As SqlCommand = New SqlCommand()
                    sqlCmd.CommandText = "SP_SEL_LOBTENERCARGO"
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

   

End Class
