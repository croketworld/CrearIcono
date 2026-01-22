Namespace My
    Partial Friend Class MyApplication
#Region ""



        Public Shared Sub IniciarIconoBandeja()
            IconoBandeja = New NotifyIcon
            With IconoBandeja
                .Text = My.Application.Info.ProductName

            End With

        End Sub



#End Region
    End Class
End Namespace