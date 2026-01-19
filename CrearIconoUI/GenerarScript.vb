Imports System.Globalization
Imports System.IO
Imports System.Numerics
Imports System.Reflection.Metadata
Imports System.Text

Friend Class GenerarScript

    Public Linea_Prompts As String = "PROMPTS = "


    Public Function GetScriptFilePath(modelpath As String, prompts() As String,
                                         outputdirectory As String,
                                         outputfilename As String) As String
        Dim content As String = SimpleInitialScriptContent() ' GetScriptFileContent(modelpath, prompts, outputdirectory, outputfilename)
        Dim sw As IO.StreamWriter = Nothing
        Dim pathscript As String = Path.Combine(My.Application.Info.DirectoryPath, "CrearIcono.py")
        If IO.File.Exists(pathscript) Then IO.File.Move(pathscript, pathscript + ".last", True)
        Try
            sw = New StreamWriter(pathscript, False)

        Catch ex As Exception
            My.Application.WriteException(ex, False, EExceptionCodes.Script_WriteFile)
        End Try
        If sw IsNot Nothing Then
            sw.Close()
            sw.Dispose()
            sw = Nothing
        End If
        Return pathscript
    End Function

    Private Function SimpleInitialScriptContent() As String
        Dim result As String = ""

        Return result
    End Function

    ''' <summary>
    ''' Devuelve el contenido del script Python que se encargará de realizar la tarea de crear un icono
    ''' </summary>
    ''' <param name="modelpath"></param>
    ''' <param name="prompts"></param>
    ''' <returns></returns>
    <Obsolete("En desuso, sólo es una idea de futuro")>
    Private Function GetScriptFileContent(modelpath As String, prompts() As String,
                                         outputdirectory As String,
                                         outputfilename As String) As String
        If String.IsNullOrEmpty(outputfilename) Then outputfilename = IO.Path.GetRandomFileName + ".png"
        If IO.Directory.Exists(outputdirectory) = False Then
            If String.IsNullOrEmpty(outputdirectory) Then outputdirectory = CrearIconoConfig.Default_Config_Path
            IO.Directory.CreateDirectory(outputdirectory)
        End If
        Dim fileout As String = Path.Combine(outputdirectory, outputfilename)

        Dim sb As New StringBuilder
        sb.AppendLine("# Importar librerías necesarias")
        sb.AppendLine("From diffusers import DiffusionPipeline")
        sb.AppendLine("import torch")
        sb.AppendLine("From PIL import Image")
        Dim promptline As String = GetScriptContent_Prompt(modelpath, prompts)
        sb.AppendLine(promptline)
        sb.Append(
        "# Cargar el modelo .safetensors (asegúrate de haberlo convertido al formato Diffusers)" + Environment.NewLine +
        "# Si usas un modelo personalizado en .safetensors, primero conviértelo usando:" + Environment.NewLine +
        "# python convert_original_stable_diffusion_to_diffusers.py --from_safetensors --checkpoint_path='ruta/modelo.safetensors' --dump_path='ruta/salida'" + Environment.NewLine +
        "# Inicializar la tubería con el modelo convertido" + Environment.NewLine +
        "pipe = DiffusionPipeline.from_pretrained(" + Environment.NewLine +
        modelpath + Environment.NewLine + "# Ruta donde guardaste el modelo convertido" + Environment.NewLine +
        "torch_dtype=torch.float16,  # Usa precisión media para mejor rendimiento" + Environment.NewLine +
        "use_safetensors=True" + Environment.NewLine +
        ")" + Environment.NewLine +
        "pipe.to(" + Chr(34) + "cuda" + Chr(34) + ")  # Usa GPU (cambia a 'cpu' si no tienes GPU)" + Environment.NewLine +
        "# Habilitar atención eficiente en memoria" + Environment.NewLine +
        "pipe.enable_xformers_memory_efficient_attention()" + Environment.NewLine +
        "# Prompt para generar un ícono" + Environment.NewLine +
        GetScriptContent_Prompt(modelpath, prompts) + Environment.NewLine +
        "# Generar la imagen" + Environment.NewLine +
        "image = pipe(prompt).images" + Environment.NewLine +
        "image.save(" + Chr(34) + fileout + Chr(34) + ")" + Environment.NewLine +
        "Print(" + Chr(34) + "¡Icono generado y guardado como " + fileout + Chr(34) + " !)  ")
        Return sb.ToString
    End Function

    ''' <summary>
    ''' TODO: acabar función para usar múltiples prompts y acondicionarlos en base al input y al modeo a usar
    ''' </summary>
    ''' <param name="modelpath"></param>
    ''' <param name="prompts"></param>
    ''' <returns></returns>
    <Obsolete("En desuso, sólo es una idea de futuro")>
    Private Function GetScriptContent_Prompt(modelpath As String, prompts() As String) As String
        Dim promptline As String = Linea_Prompts
        Dim promptcount As Integer = prompts.Length

        'para hacer ciertos flujos en base al modelo o su ruta
        If modelpath.Contains("asereje") Then

        End If
        If promptcount = 1 Then

            If IO.File.Exists(prompts(0)) Then

            ElseIf Uri.IsWellFormedUriString(prompts(0), UriKind.RelativeOrAbsolute) Then

            Else
                promptline += $"'{prompts(0) }'"
            End If

        ElseIf promptcount > 1 Then
        promptline += " ["
        For Each prompt As String In prompts
            promptline += $"'{prompts(0) }', "
        Next
        promptline = promptline.Substring(0, promptline.Length - 1)
        promptline += "]"
        Else
        promptline += $"'{"Crear un icono" }'"
        End If

        Return promptline
    End Function
    Private Shared Function EsImagen(filename As String) As Boolean
        Dim imgExtension As String() = New String() {"png", "jpg", "webp"}
        If filename.Contains("."c, StringComparison.InvariantCultureIgnoreCase) Then
            Dim parts As String() = filename.Split(".")
            Dim extpart As String = parts.Last()?.Trim()?.ToLowerInvariant()
            Return imgExtension.Contains(extpart)
        End If
        Return False
    End Function

End Class
