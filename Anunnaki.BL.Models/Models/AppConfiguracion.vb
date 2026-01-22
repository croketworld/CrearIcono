Imports System.Drawing
Imports Anunnaki.Models.Base

Public Class AppConfiguracion
    Inherits ConfiguracionBase
    Implements IAppConfiguracion

#Region "propiedades"

    Public Property Form_IniciarMinizado As Boolean Implements IAppConfiguracion.Form_IniciarMinizado
    Public Property Form_Tamaño As Point Implements IAppConfiguracion.Form_Tamaño
    Public Property Idioma As String Implements IAppConfiguracion.Idioma

    Public ReadOnly Property ConfigVersion As Integer Implements IAppConfiguracion.ConfigVersion
        Get
            Return 1
        End Get
    End Property

#End Region

#Region "metodos"

    ''' <summary>
    ''' Copia las propiedades de la configuración
    ''' </summary>
    ''' <param name="configbase"></param>
    Public Sub Copiar(configbase As IAppConfiguracion) Implements IAppConfiguracion.Copiar
        With configbase
            Me.Form_IniciarMinizado = .Form_IniciarMinizado
            Me.Form_Tamaño = .Form_Tamaño
            Me.Idioma = .Idioma
        End With

    End Sub




#End Region

#Region "constructores"



    ''' <summary>
    ''' Constructor especificando idioma y estado de formulario
    ''' </summary>
    ''' <param name="idioma"></param>
    ''' <param name="minimizado"></param>
    Public Sub New(idioma As String, minimizado As Boolean)
        Me.Form_IniciarMinizado = minimizado
        Me.Form_Tamaño = New Point(1240, 720)
        Me.Idioma = idioma
    End Sub

    ''' <summary>
    ''' Constructor especificando idioma
    ''' </summary>
    ''' <param name="idioma"></param>
    Public Sub New(idioma As String)
        Me.Form_IniciarMinizado = False
        Me.Form_Tamaño = New Point(1240, 720)
        Me.Idioma = idioma
    End Sub

    ''' <summary>
    ''' Constructor por defecto
    ''' </summary>
    Public Sub New()
        Me.Form_IniciarMinizado = False
        Me.Form_Tamaño = New Point(1240, 720)
        Me.Idioma = "es"
    End Sub


#End Region

#Region "operadores"

    Public Shared Operator =(v1 As AppConfiguracion, v2 As AppConfiguracion) As Boolean
        Return v1.Equals(v2)
    End Operator
    Public Shared Operator <>(v1 As AppConfiguracion, v2 As AppConfiguracion) As Boolean
        Return (v1.Equals(v2) = False)
    End Operator
    Public Shared Operator =(v1 As AppConfiguracion, v2 As IAppConfiguracion) As Boolean
        Return v1.Equals(v2)
    End Operator
    Public Shared Operator <>(v1 As AppConfiguracion, v2 As IAppConfiguracion) As Boolean
        Return (v1.Equals(v2) = False)
    End Operator

    ''' <summary>
    ''' Determina si dos <see cref="AppConfiguracion"/> tienen la misma versión
    ''' </summary>
    ''' <param name="v1">Objeto comparador</param>
    ''' <param name="v2">Objeto a comparar</param>
    ''' <returns></returns>
    Public Shared Operator Like(v1 As AppConfiguracion, v2 As AppConfiguracion) As Boolean
        Return v1.ConfigVersion = v2.ConfigVersion
    End Operator
    Public Overrides Function GetHashCode() As Integer
        Return Me.ConfigVersion
    End Function
    Public Overrides Function Equals(obj As Object) As Boolean
        If obj.GetType() IsNot GetType(AppConfiguracion) Then Return False
        Dim cfg As AppConfiguracion = CType(obj, AppConfiguracion)
        If cfg.ConfigVersion <> Me.ConfigVersion Then Return False
        If cfg.Idioma <> Me.Idioma Then Return False
        Return MyBase.Equals(obj)
    End Function

    Public Overrides Function ToString() As String
        Return String.Empty
    End Function



#End Region

End Class
