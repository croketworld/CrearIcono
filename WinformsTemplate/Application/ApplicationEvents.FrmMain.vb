Namespace My
    Partial Friend Class MyApplication
#Region "Comportamiento formulario"

        Public Shared Sub Iniciar()
            FormularioPrincipal = New FrmMain
            With FormularioPrincipal
                'TODO: añadir icono, texto, etc..  (personalizar plantilla
                .Show()
            End With
        End Sub

        Public Sub Minimizar()

        End Sub

        Public Sub Maximizar()

        End Sub

        Public Sub Salir()

        End Sub


#Region "acciones usuario"

        Public Sub DocumentacionOnline()

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