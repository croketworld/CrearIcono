Imports System.Collections.ObjectModel

Namespace My
    Partial Friend Class MyApplication
#Region "Argumentos"

        Public Sub InicioArgumentos(args As ReadOnlyCollection(Of String))
            Me.ArgumentosInicio = String.Join(" ", args)
        End Sub



#End Region
    End Class
End Namespace