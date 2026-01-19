Imports System.Security.Cryptography
Imports System.Windows.Markup

Public Class CrearIconoConfig

    Private _selected_Imagen_Tamaños As Size()
    Private _selected_Imagen_Tamaño As Size

    Public ReadOnly Property Default_Config_Path As String
        Get
            Return IO.Path.Join(
                My.Application.Info.DirectoryPath,
                My.Application.Info.ProductName,
                ".config")
        End Get
    End Property


    Public ReadOnly Property Path_Modelo As String
        Get
            Return IO.Path.Join(Path_ModelsDir, Modelo_Name)
        End Get
    End Property
    Public ReadOnly Property Default_Imagen_Tamaño As Size
        Get
            Return New Point(512, 512)
        End Get
    End Property
    Public ReadOnly Property Default_Imagen_Tamaños As Size()
        Get
            Return New Size() {
                New Size(16, 16), New Size(32, 32),
                New Size(64, 64), New Size(128, 128),
                New Size(48, 48), New Size(56, 56),
                New Size(96, 96), New Size(640, 640),
                New Size(256, 256), New Size(512, 512)
            }
        End Get
    End Property
    Public ReadOnly Property Default_Output_Path As String
        Get
            Return IO.Path.Join(
                Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures),
                My.Application.Info.ProductName,
                "Output")
        End Get
    End Property

    Public Property Modelo_Name As String = "fantassifiedIcons_fantassifiedIconsV20.safetensors"
    Public Property Path_WorkingDir As String = "C:\Users\Croket\Documents\AI\Work"
    Public Property Path_ModelsDir As String = "C:\Users\Croket\Documents\AI\Models"

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
        _selected_Imagen_Tamaño = value
    End Sub

    Public Property Imagen_Tamaños As Size()
    Private Sub _Set_Imagen_Tamaños(values() As Size)
        Dim res As New List(Of Size)
        If values IsNot Nothing Then
            For Each value In values
                If Default_Imagen_Tamaños.Contains(value) Then
                    res.Add(value)
                End If
            Next
        End If
        _selected_Imagen_Tamaños = res.ToArray
    End Sub


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

        End Try
        If fs IsNot Nothing Then
            fs.Close()
            fs.Dispose()
        End If
        If js IsNot Nothing Then js = Nothing

    End Sub
    Private Function SerializationSettings() As System.Runtime.Serialization.DataContractSerializerSettings


    End Function
    Public Sub Cargar()
        Cargar(Default_Config_Path)
    End Sub

    Public Sub Cargar(filepath As String)
        If IO.File.Exists(filepath) = False Then filepath = Default_Config_Path



    End Sub

End Class
