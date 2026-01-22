Imports Windows.AI.MachineLearning

Namespace My
    Partial Friend Class MyApplication
#Region "Comportamiento formulario"

        Private Sub IniciarFormulario()
            FormularioPrincipal = New FrmMain
            'FormularioPrincipal.Icon = FrmDaemon.Icon
            AplicarDatosConfig()
        End Sub

        Public Sub Iniciar()
            IniciarFormulario()

            With FormularioPrincipal

                'TODO: añadir icono, texto, etc..  (personalizar plantilla
                .Show()
            End With
        End Sub

        Public Sub Minimizar()
            GuardarDatosConfig()
            Me.IconoBandeja.Icon = My.Application.FormularioPrincipal.Icon
            Me.IconoBandeja.Text = My.Application.FormularioPrincipal.Text
            Me.IconoBandeja.Visible = True

            With FormularioPrincipal
                .ShowInTaskbar = False
                .WindowState = FormWindowState.Minimized
                .Visible = False
                '.Dispose()
            End With
        End Sub

        Public Sub Maximizar()
            IniciarFormulario()
            With FormularioPrincipal
                .ShowInTaskbar = True
                .WindowState = FormWindowState.Normal
                .Visible = True
                .Show()
            End With
            If IconoBandeja IsNot Nothing Then
                ' IconoBandeja.Dispose()
                'IconoBandeja = Nothing

            End If

        End Sub

        Public Sub Salir()
            GuardarDatosConfig()
            GuardarConfig()
            Environment.Exit(0)
        End Sub


#Region "acciones usuario"

        Public Sub DocumentacionOnline()
            Process.Start(EApplicationInfo.DocumentacionUrl)
        End Sub


        Public Sub EnviarSugerencia()

        End Sub

        Public Sub ReportarError()

        End Sub


        Public Sub Actualizar()

        End Sub
#End Region




#End Region
    End Class
End Namespace