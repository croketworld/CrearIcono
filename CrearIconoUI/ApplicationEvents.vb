Imports Microsoft.VisualBasic.ApplicationServices

Namespace My


    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed. This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active.
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.

    ' **NEW** ApplyApplicationDefaults: Raised when the application queries default values to be set for the application.

    ' Example:
    ' Private Sub MyApplication_ApplyApplicationDefaults(sender As Object, e As ApplyApplicationDefaultsEventArgs) Handles Me.ApplyApplicationDefaults
    '
    '   ' Setting the application-wide default Font:
    '   e.Font = New Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular)
    '
    '   ' Setting the HighDpiMode for the Application:
    '   e.HighDpiMode = HighDpiMode.PerMonitorV2
    '
    '   ' If a splash dialog is used, this sets the minimum display time:
    '   e.MinimumSplashScreenDisplayTime = 4000
    ' End Sub

    Partial Friend Class MyApplication
        Public Shared LogExceptionsContent As String
        Public Shared Config As CrearIconoConfig

        Public Function GetConfig() As CrearIconoConfig
            Return Config
        End Function

        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            Config = New CrearIconoConfig
            Config.Cargar()
        End Sub
        ''' <summary>
        ''' Excepciones no controladas
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub MyApplication_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs) Handles Me.UnhandledException
            If e.Exception IsNot Nothing Then
                WriteException(e.Exception, True, 1)
                e.ExitApplication = True
            End If

        End Sub
        Public Sub WriteException(exe As Exception,
                                  Optional mustExit As Boolean = True,
                                  Optional exitcode As Integer = 1)
            Write_Exception(exe)
            If mustExit Then
                Environment.Exit(exitcode)
                'TODO

                'reiniciar aplicación en caso de error


            End If
        End Sub

        Public Shared Sub Write_Exception(exe As Exception)
            LogExceptionsContent += exe.Message
            LogExceptionsContent += Environment.NewLine
        End Sub

        Private Sub MyApplication_Shutdown(sender As Object, e As EventArgs) Handles Me.Shutdown
            If (Config IsNot Nothing) = False Then
                Config = New CrearIconoConfig
            End If
            Config.Guardar()
        End Sub

        Private Sub WriteLogToFile()
            Dim sw As IO.StreamWriter = Nothing
            Dim filepath As String = IO.Path.Join(
                                          My.Application.Info.DirectoryPath, "-",
                                          DateTime.UtcNow.ToShortTimeString(),
                                          My.Application.Info.AssemblyName, "-",
                                                          "exception.log")
            Try
                sw = New IO.StreamWriter(filepath, True)
                sw.Write(LogExceptionsContent)
            Catch
                ''TODO: ¿messagebox?
            End Try
            If sw IsNot Nothing Then
                sw.Close()
                sw.Dispose()
                sw = Nothing
            End If
        End Sub

    End Class
End Namespace
