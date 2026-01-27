Imports System.Runtime.Serialization

<Flags>
Public Enum EEstadoElementoMenu
    Ninguno = 0
    NotSet = Ninguno
    Cargado = 1
    Guardado = 2
    Editado = 4
    Modificado = 5
End Enum

Public Class ElementoMenuContextual

#Region "propiedades"

#Region "ejecución"
    ''' <summary>
    ''' El comando a ejecutar
    ''' </summary>
    ''' <returns></returns>
    Public Property Accion As String
    ''' <summary>
    ''' Los argumentos de línea de comandoas a pasar a la acción
    ''' </summary>
    ''' <returns></returns>
    Public Property Argumentos As String

    ''' <summary>
    ''' Si debe ejecutarse como administrador
    ''' </summary>
    ''' <returns></returns>
    Public Property EjecutarComoAdministrador As Boolean

#End Region

#Region "datos"

    ''' <summary>
    ''' Nombre de usuario creador
    ''' </summary>
    Public Property Creador As String

    ''' <summary>
    ''' El estado del elemento editado
    ''' </summary>
    ''' <returns></returns>
    <IgnoreDataMember>
    Public Property Estado As EEstadoElementoMenu

    ''' <summary>
    ''' Nombre del último editor
    ''' </summary>
    ''' <returns></returns>
    Public Property Editor As String



    ''' <summary>
    ''' Nombre y texto a mostrar en el menú
    ''' </summary>
    ''' <returns></returns>
    Public Property Nombre As String


    ''' <summary>
    ''' Fecha en la que se ah creado el elemento
    ''' </summary>
    ''' <returns></returns>
    Public Property FechaCreacion As DateTime
    ''' <summary>
    ''' Fecha de la última modificación
    ''' </summary>
    ''' <returns></returns>
    Public Property FechaUltimaEdicion As DateTime

    ''' <summary>
    ''' Ruta del archivo que hará de icono
    ''' </summary>
    ''' <returns></returns>
    Public Property RutaIcono As String


#End Region

#Region "estados readonly"

    ''' <summary>
    ''' Si corresponde el elemento en edición con el cargado
    ''' </summary>
    ''' <returns></returns>
    <IgnoreDataMember>
    Public ReadOnly Property Guardado As Boolean
        Get
            Return Me.Estado And EEstadoElementoMenu.Guardado = 1
        End Get
    End Property
    ''' <summary>
    ''' Si el contenido del editor es igual al guardado
    ''' </summary>
    ''' <returns></returns>
    <IgnoreDataMember>
    Public ReadOnly Property Cargado As Boolean
        Get
            Return Me.Estado And EEstadoElementoMenu.Cargado = 1
        End Get
    End Property

    ''' <summary>
    ''' Si ha sido cargado y se ha editado (algún valor es diferente al orioginal
    ''' </summary>
    ''' <returns></returns>
    <IgnoreDataMember>
    Public ReadOnly Property Modificado As Boolean
        Get
            Return Me.Editado And Me.Cargado
        End Get
    End Property

    ''' <summary>
    ''' Si se ha editado algún valor
    ''' </summary>
    ''' <returns></returns>
    <IgnoreDataMember>
    Public ReadOnly Property Editado As Boolean
        Get
            Return Me.Estado And EEstadoElementoMenu.Editado = 1
        End Get
    End Property

#End Region

#End Region

#Region "metodos"

    Public Sub Cargar(ruta As String)
        If IO.File.Exists(ruta) = False Then
            'TODO aviso y log intento de carga de archivo que no existe
            Exit Sub
        End If
        Dim js As System.Runtime.Serialization.Json.DataContractJsonSerializer = Nothing
        Dim fs As IO.FileStream = Nothing
        Dim res As ElementoMenuContextual = Nothing
        Try
            js = New System.Runtime.Serialization.Json.DataContractJsonSerializer(Me.GetType)
            fs = New IO.FileStream(ruta, IO.FileMode.Open)
            res = js.ReadObject(fs)
        Catch ex As Exception
            'TODO: log error y mostrar a usuario
        End Try
        If fs IsNot Nothing Then
            fs.Close()
            fs.Dispose()
        End If
        js = Nothing
        Me.Copiar(res)
        Me.Estado = EEstadoElementoMenu.Cargado
    End Sub

    Public Sub Guardar(ruta As String, Optional preguntarSobreEscribir As Boolean = False)
        Dim sobreescribirSiExiste As Boolean = True
        If IO.File.Exists(ruta) And preguntarSobreEscribir Then
            Dim dlgres As DialogResult = MessageBox.Show("Se ha especificado una ruta de archivo existente," & Environment.NewLine &
                                                         "¿deseas sobreescribir el archivo?", "¿Sobreescribir archivo?" & Environment.NewLine &
                                                         "Si - Sobreescribe el archivo." & Environment.NewLine &
                                                         "No - Crea un archivo nuevo junto al existente." & Environment.NewLine &
                                                         "Cancelar - omite el guardado.",
                            MessageBoxButtons.YesNoCancel)
            Select Case dlgres
                Case DialogResult.Cancel
                    Exit Sub
                Case DialogResult.No
                    sobreescribirSiExiste = False
                Case DialogResult.Yes
                    sobreescribirSiExiste = True
                Case Else
                    sobreescribirSiExiste = True
            End Select
        End If

        Dim js As System.Runtime.Serialization.Json.DataContractJsonSerializer = Nothing
        Dim fs As IO.FileStream = Nothing
        If sobreescribirSiExiste = False Then
            Dim nuevoNombre As String = ReemplazarNuevoNombreArchivo(ruta)


        End If
        Try
            js = New Runtime.Serialization.Json.DataContractJsonSerializer(Me.GetType)
            fs = New IO.FileStream(ruta, IO.FileMode.Create)
        Catch ex As Exception

        End Try

    End Sub
    ''' <summary>
    ''' Genera una nueva ruta basada en el archivo objetivo, 
    ''' añdiendo una adición que puede ser un símbolo, una numeración, un ID, GUID.. 
    ''' ¡lo que quieras que le dé identidad propia y no sea una mera copia en su nombre al menos!
    ''' </summary>
    ''' <param name="archivo">Ruta completa del archivo</param>
    ''' <param name="adicion"> lo que se añade al nombre del archivo existente</param>
    ''' <returns></returns>
    ''' <remarks>Por defecto se añade <see cref="Adicion_Defecto_CopiaArchivo"> un valor legíble</see> </remarks>
    Private Function ReemplazarNuevoNombreArchivo(archivo As String, Optional adicion As String = " - Copia") As String
        Dim archivillo As New IO.FileInfo(archivo)
        Dim nuevoNombre As String = String.Format("{0}\{1}{2}{3}",
            archivillo.DirectoryName,
            archivillo.Name,
            adicion,
            archivillo.Extension)
        Return nuevoNombre
    End Function

    Public Const Adicion_Defecto_CopiaArchivo As String = " - Copia"

    Public Sub Copiar(elemento As ElementoMenuContextual)
        If elemento IsNot Nothing Then
            With elemento
                Me.Accion = .Accion
                Me.Argumentos = .Argumentos
                Me.Creador = .Creador
                Me.Editor = .Editor
                Me.EjecutarComoAdministrador = .EjecutarComoAdministrador
                Me.FechaCreacion = .FechaCreacion
                Me.FechaUltimaEdicion = .FechaUltimaEdicion
                Me.Nombre = .Nombre
                Me.RutaIcono = .RutaIcono
            End With
        End If
    End Sub

#End Region

#Region "constructores"

    Public Sub New(ruta As String)
        Me.Cargar(ruta)
    End Sub
    Public Sub New()
        Me.Estado = EEstadoElementoMenu.Ninguno
        Me.Creador = My.User.Name
        Me.FechaCreacion = DateTime.Now
    End Sub

#End Region

#Region "operadores"

    Public Shared Operator =(v1 As ElementoMenuContextual, v2 As ElementoMenuContextual) As Boolean
        If (v1 IsNot Nothing And v2 IsNot Nothing) = False Then Return False
        If (v1.Accion = v2.Accion) = False Then Return False
        If (v1.Argumentos = v2.Argumentos) = False Then Return False
        If (v1.Creador = v2.Creador) = False Then Return False
        If (v1.Editor = v2.Editor) = False Then Return False
        If (v1.EjecutarComoAdministrador = v2.EjecutarComoAdministrador) = False Then Return False
        If (v1.FechaCreacion = v2.FechaCreacion) = False Then Return False
        If (v1.FechaUltimaEdicion = v2.FechaUltimaEdicion) = False Then Return False
        If (v1.Nombre = v2.Nombre) = False Then Return False
        If (v1.RutaIcono = v2.RutaIcono) = False Then Return False

        Return True
    End Operator

    Public Shared Operator <>(v1 As ElementoMenuContextual, v2 As ElementoMenuContextual) As Boolean
        Return (v1 = v2) = False
    End Operator


    Public Overrides Function ToString() As String
        Return String.Format("{0}-{1}", My.User.Name, Me.Nombre)
    End Function
    ''' <summary>
    ''' Obtiene un hashcode en base a lo que devuelve <see cref="ToString()"/>
    ''' </summary>
    ''' <returns>Valor numérico determinístico que no es completamente único</returns>
    Public Overrides Function GetHashCode() As Integer
        Dim nombre As String = Me.ToString
        Dim v As Long = 0
        For Each letra As Char In nombre
            v += Asc(letra)
        Next
        If v > Int32.MaxValue Then v = v - Int32.MaxValue
        Return CInt(v)
    End Function
    Public Overrides Function Equals(obj As Object) As Boolean
        If obj.GetType() Is GetType(ElementoMenuContextual) Then
            Dim v1 As ElementoMenuContextual = obj
            Return Me = v1
        End If
        Return MyBase.Equals(obj)
    End Function

#End Region

End Class
