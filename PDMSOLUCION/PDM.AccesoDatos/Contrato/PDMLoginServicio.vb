Imports PDM.Entidades

Public Interface PDMLoginServicio
#Region "INTERFACE QUE CONTIENE LOS METODOS DE LOGINBE"
    Function AccesoUsuario(ByVal customerBE As PDMLoginBE) As Boolean  'Acceso al Sistema PDMLoginBE
#End Region
End Interface
