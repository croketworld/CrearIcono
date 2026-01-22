Imports System.Drawing

Public MustInherit Class ConfiguracionBase
    Implements IConfiguracion

#Region "propiedades"

    Public ReadOnly Property ConfigVersion As Integer Implements IConfiguracion.ConfigVersion
        Get
            Return 1
        End Get
    End Property

#End Region

#Region "operadores"

    Public Shared Operator =(v1 As ConfiguracionBase, v2 As ConfiguracionBase) As Boolean
        Return v1.Equals(v2)
    End Operator
    Public Shared Operator <>(v1 As ConfiguracionBase, v2 As ConfiguracionBase) As Boolean
        Return (v1.Equals(v2) = False)
    End Operator

    Public Shared Operator =(v1 As ConfiguracionBase, v2 As IConfiguracion) As Boolean
        Return v1.Equals(v2)
    End Operator
    Public Shared Operator <>(v1 As ConfiguracionBase, v2 As IConfiguracion) As Boolean
        Return (v1.Equals(v2) = False)
    End Operator

    ''' <summary>
    ''' Determina si dos <see cref="ConfiguracionBase"/> tienen la misma versión
    ''' </summary>
    ''' <param name="v1">Objeto comparador</param>
    ''' <param name="v2">Objeto a comparar</param>
    ''' <returns></returns>
    Public Shared Operator Like(v1 As ConfiguracionBase, v2 As ConfiguracionBase) As Boolean
        Return v1.ConfigVersion = v2.ConfigVersion
    End Operator
    Public Overrides Function GetHashCode() As Integer
        Return Me.ConfigVersion
    End Function
    Public Overrides Function Equals(obj As Object) As Boolean
        Return MyBase.Equals(obj)
    End Function

    Public Overrides Function ToString() As String
        Return String.Empty
    End Function



#End Region

End Class
