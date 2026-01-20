Imports System.CodeDom
Imports System.Collections.ObjectModel
Imports System.Runtime.Serialization
Imports System.Security.Cryptography
Imports System.Windows.Markup

Friend Class CrearIconoConfig
#Region "propiedades"

    Private _selected_Imagen_Tamaños As Size()
    Private _selected_Imagen_Tamaño As Size
    Public ReadOnly Property Path_Modelo As String
        Get
            Return IO.Path.Join(Path_ModelsDir, Modelo_Name)
        End Get
    End Property
    Public Property Modelo_Name As String
    Public Property Path_WorkingDir As String
    Public Property Path_ModelsDir As String

    Public Property Imagen_Tamaño As Size
        Get
            If _selected_Imagen_Tamaño = Nothing Then _selected_Imagen_Tamaño = Imagen_Tamaños.Last()
        End Get
        Set(value As Size)
            _Set_Imagen_Tamaño(value)
        End Set
    End Property
    Private Sub _Set_Imagen_Tamaño(value? As Size)
        If value IsNot Nothing And Imagen_Tamaños.Contains(value) = False Then value = Nothing
        If value Is Nothing Then value = GetDefault_Imagen_Tamaño()
        _selected_Imagen_Tamaño = value
    End Sub

    Public Property Imagen_Tamaños As Collection(Of Size)
    Private Sub _Set_Imagen_Tamaños(values() As Size)
        Dim res As New List(Of Size)
        If values IsNot Nothing Then
            For Each value In values
                If GetDefault_Imagen_Tamaños().Contains(value) Then
                    res.Add(value)
                End If
            Next
        End If
        _selected_Imagen_Tamaños = res.ToArray
    End Sub

#End Region

#Region "defaults y estáticos"

    Public Shared ReadOnly Property Default_Config_Path As String
        Get
            Return IO.Path.Join(
                My.Application.Info.DirectoryPath,
                My.Application.Info.ProductName,
                ".config")
        End Get
    End Property

    Public Shared Function GetDefault_Imagen_Tamaño() As Size
        Return New Point(512, 512)
    End Function

    Public Shared Function GetDefault_Imagen_Tamaños() As Size()
        Return New Size() {
                New Size(16, 16), New Size(32, 32),
                New Size(64, 64), New Size(128, 128),
                New Size(48, 48), New Size(56, 56),
                New Size(96, 96), New Size(640, 640),
                New Size(256, 256), New Size(512, 512)
            }
    End Function

    Public Shared ReadOnly Property Default_Output_Path As String
        Get
            Return IO.Path.Join(
                Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures),
                My.Application.Info.ProductName,
                "Output")
        End Get
    End Property

#End Region

#Region "seria-seria-li-za-ción!"

    Public Sub Guardar()
        Guardar(Default_Config_Path)
    End Sub

    Public Sub Guardar(filepath As String)
        If String.IsNullOrEmpty(filepath) Then filepath = Default_Config_Path

        Dim js As System.Runtime.Serialization.Json.DataContractJsonSerializer = Nothing
        Dim fs As IO.FileStream = Nothing
        Try
            js = New System.Runtime.Serialization.Json.DataContractJsonSerializer(Me.GetType(), SerializationSettings())
            fs = New IO.FileStream(filepath, IO.FileMode.CreateNew, IO.FileAccess.Write)
            js.WriteObject(fs, Me)
        Catch ex As Exception
            My.Application.WriteException(ex, False, EExceptionCodes.Config_WriteFile)
        End Try
        If fs IsNot Nothing Then
            fs.Close()
            fs.Dispose()
        End If
        If js IsNot Nothing Then js = Nothing

    End Sub
    Private Shared Function SerializationSettings() As System.Runtime.Serialization.DataContractSerializerSettings
        Dim ss As New DataContractSerializerSettings
        With ss
            .RootName = New System.Xml.XmlDictionaryString(ss, "CrearIconoConfig", 0)
            .SerializeReadOnlyTypes = False
        End With
        Return ss
    End Function
    Public Sub Cargar()
        CargarConfig(Default_Config_Path)
    End Sub

    Private Sub CargarConfig(filepath As String)
        Dim cc As CrearIconoConfig = Cargar(filepath)
        Me.Copiar(cc)
    End Sub
    Public Shared Function Cargar(filepath As String) As CrearIconoConfig
        Dim cc As New CrearIconoConfig
        If IO.File.Exists(filepath) = False Then filepath = Default_Config_Path
        If IO.File.Exists(filepath) Then
            Dim js As System.Runtime.Serialization.Json.DataContractJsonSerializer = Nothing
            Dim fs As IO.FileStream = Nothing
            Try
                fs = New IO.FileStream(filepath, IO.FileMode.Open)
                cc = js.ReadObject(fs)
            Catch ex As Exception
                My.Application.WriteException(ex, False, EExceptionCodes.Config_ReadFile)
            End Try
            If fs IsNot Nothing Then
                fs.Close()
                fs.Dispose()
                fs = Nothing
            End If

        Else
            cc.Guardar(filepath)
        End If

        Return cc
    End Function

    ''' <summary>
    ''' Copia las propiedades/valores en la instancia actual
    ''' </summary>
    ''' <param name="config">Clase de la que copiar los datos</param>
    Public Sub Copiar(config As CrearIconoConfig)
        With config
            Me.Imagen_Tamaño = .Imagen_Tamaño
            Me.Imagen_Tamaños = .Imagen_Tamaños
            Me.Modelo_Name = .Modelo_Name
            Me.Path_ModelsDir = .Path_ModelsDir
            Me.Path_WorkingDir = .Path_WorkingDir
        End With
    End Sub

#End Region

#Region "construcción"

    Public Sub New()
        Iniciar()
    End Sub

    Public Sub Iniciar()
        Imagen_Tamaños = New Collection(Of Size)
        Imagen_Tamaño = New Size
        _selected_Imagen_Tamaño = GetDefault_Imagen_Tamaño()
        _selected_Imagen_Tamaños = GetDefault_Imagen_Tamaños()
        Path_WorkingDir = My.Application.Info.DirectoryPath
        Path_ModelsDir = IO.Path.Join(Path_WorkingDir, "Models")
        Modelo_Name = "fantassifiedIcons_fantassifiedIconsV20.safetensors"

    End Sub


#End Region

End Class
