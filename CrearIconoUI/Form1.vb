Imports System.Collections.ObjectModel

Public Class Form1
    Private cfg As CrearIconoConfig
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub CargarTamaños()
        Dim tamaños = cfg.Imagen_Tamaños
        ck_tamaños.Items.Clear()

        For Each tamaño As Size In tamaños
            ck_tamaños.Items.Add(tamaño.ToString(), tamaño = cfg.Imagen_Tamaño)
        Next
    End Sub

    Public Sub Iniciar()
        cfg = My.Application.GetConfig()
        AddHandler tx_prompt.TextChanged, AddressOf PromptChanged
        CargarTamaños()
        tx_prompt.Text = My.Application.prompt
        lb_outputpath.Text = cfg.Path_WorkingDir
    End Sub

    Public Sub New()

        InitializeComponent()
        Iniciar()

    End Sub

    Private Sub PromptChanged(sender As Object, e As EventArgs)
        tx_promptFinal.Text = My.Application.preprompt + tx_prompt.Text.Trim()
        tx_promptFinal.Text = tx_promptFinal.Text.Trim()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CrearIcono(tx_promptFinal.Text.Trim(), ck_tamaños.CheckedItems.Cast(Of Size))
    End Sub

    Private Sub CrearIcono(promptfinal As String, tamaños As Collection(Of Size), Optional fondotransparente As Boolean = False)
        '1º crear script python
        Dim gs As New GenerarScript(promptfinal, lb_outputpath.Text, tx_output_filename.Text)
        '2º ejecutar script capturando output
        Dim argus As New List(Of String) From {
            "python",
            gs.ScriptPath
        }
        Dim ps As New ProcessStartInfo("C:\Windows\System32\cmd.exe", argus)
        With ps
            .CreateNoWindow = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
            .ErrorDialog = False
            .RedirectStandardError = True
            .WorkingDirectory = cfg.Path_WorkingDir
            .WindowStyle = ProcessWindowStyle.Hidden

        End With
        Dim proceso As Process = Nothing
        Try
            proceso = Process.Start(ps)
            AddHandler proceso.OutputDataReceived, AddressOf ScriptOutputDataReceived
            AddHandler proceso.ErrorDataReceived, AddressOf ScriptOutputErrorReceived
            AddHandler proceso.Exited, AddressOf ScriptFinalizado
            AddHandler proceso.Disposed, AddressOf ScriptDisposed
        Catch ex As Exception
            My.Application.WriteException(ex, False)
        End Try
        '3º mostrar resultado

    End Sub

    Private Sub ScriptDisposed(sender As Object, e As EventArgs)
        Throw New NotImplementedException()
    End Sub

    Private Sub ScriptFinalizado(sender As Object, e As EventArgs)
        Throw New NotImplementedException()
    End Sub
    Private Sub ScriptOutputErrorReceived(sender As Object, e As DataReceivedEventArgs)

        If e.Data IsNot Nothing Then
#Disable Warning BC42025 ' Acceso del miembro compartido, el miembro de constante, el miembro de enumeración o el tipo anidado a través de una instancia
            If My.Application?.LogExceptionsContent IsNot Nothing Then

                My.Application.LogExceptionsContent += Environment.NewLine + e.Data
            Else
                My.Application.LogExceptionsContent = e.Data
            End If
#Enable Warning BC42025 ' Acceso del miembro compartido, el miembro de constante, el miembro de enumeración o el tipo anidado a través de una instancia
        End If

    End Sub

    Private Sub ScriptOutputDataReceived(sender As Object, e As DataReceivedEventArgs)
        If e.Data IsNot Nothing Then
            tx_log.Text += e.Data + Environment.NewLine
        End If
    End Sub

    Private Sub ActualizarEstado(texto_status As String,
                                 Optional texto_progreso As String = "",
                                 Optional porcentaje_progreso As Integer = 0)
        lb_status.Text = estado_chill
        If String.IsNullOrEmpty(texto_status) = False Then
            lb_status.Text = "Estado: " + texto_status
        End If
        If String.IsNullOrEmpty(texto_progreso) = False Then
            pb_working.Visible = True
            pb_working.ToolTipText = texto_progreso
            pb_working.Value = porcentaje_progreso
        End If

    End Sub

    Private Const estado_chill As String = "Estado: Chill"

    Private Sub Lb_status_Click(sender As Object, e As EventArgs) Handles lb_status.Click
        tx_log.Visible = True
    End Sub
End Class
