Imports Anunnaki.Models.Base
Imports Anunnaki.BL.Models
Imports Anunnaki.BL.Serialization
Imports Anunnaki.BL.Models.Anunnaki.BL.Serialization
Namespace My

    Partial Friend Class MyApplication

        Public Function RutaArchivo_Configuracion() As String
            Return IO.Path.Combine(My.Application.Info.DirectoryPath, My.Application.Info.AssemblyName & ".cfg")
        End Function


#Region "config"
        Public Sub IniciarConfig()

            Me.Config = New AppConfiguracion
            CargarConfig()
        End Sub

        Public Sub CargarConfig()
            Dim archivoCfgPath As String = RutaArchivo_Configuracion()
            If IO.File.Exists(archivoCfgPath) = False Then
                GuardarConfig()
                Exit Sub
            End If

            Dim fs As IO.FileStream = Nothing
            Try
                fs = New IO.FileStream(archivoCfgPath, IO.FileMode.Open)
            Catch
                'TODO: log error
                System.Diagnostics.Debug.WriteLine("Error cargando config")
            End Try
            Me.Config.Deserializar(fs)
            If fs IsNot Nothing Then
                fs.Close()
                fs.Dispose()
            End If
        End Sub
        Public Sub GuardarConfig()
            If (Me.Config IsNot Nothing) = False Then Me.Config = New AppConfiguracion
            Dim archivoCfgPath As String = RutaArchivo_Configuracion()
            Dim fs As IO.FileStream = Nothing
            Dim ms As IO.MemoryStream = Me.Config.Serializar()
            Try
                fs = New IO.FileStream(archivoCfgPath, IO.FileMode.CreateNew)
                ms.CopyTo(fs)
            Catch
                'TODO: log error
                System.Diagnostics.Debug.WriteLine("Error guardando config")
            End Try
            If ms IsNot Nothing Then
                ms.Close()
                ms.Dispose()
            End If
            If fs IsNot Nothing Then
                fs.Close()
                fs.Dispose()
            End If

        End Sub


        Public Sub GuardarDatosConfig()
            Me.Config.Form_Tamaño = FormularioPrincipal.Size
        End Sub


        Public Sub AplicarDatosConfig()
            FormularioPrincipal.Size = Me.Config.Form_Tamaño
        End Sub
#End Region
    End Class
End Namespace