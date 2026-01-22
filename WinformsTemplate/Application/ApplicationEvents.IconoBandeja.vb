Namespace My
    Partial Friend Class MyApplication



#Region "icono bandeja"



        Public Sub IniciarIconoBandeja()
            IconoBandeja = New NotifyIcon
            Dim ctmenu As New ContextMenuStrip

            Dim MaximizarContextMenuStrip1 As New ToolStripMenuItem With {
                .Name = "MaximizarContextMenuStrip1",
                .ShortcutKeys = Keys.Control Or Keys.Up,
                .Size = New Size(289, 34),
                .Text = ETextosMenus.Maximizar
            }
            AddHandler MaximizarContextMenuStrip1.Click, AddressOf My.Application.Maximizar

            Dim SalirContextMenuStrip1 As New ToolStripMenuItem With {
                .Name = "SalirContextMenuStrip1",
                .ShortcutKeys = Keys.Alt Or Keys.F4,
                .Size = New Size(289, 34),
                .Text = ETextosMenus.Salir
            }
            AddHandler SalirContextMenuStrip1.Click, AddressOf My.Application.Salir
            With ctmenu
                ctmenu.Items.Add(MaximizarContextMenuStrip1)
                ctmenu.Items.Add(SalirContextMenuStrip1)
            End With

            With IconoBandeja
                .Text = My.Application.Info.ProductName
                .ContextMenuStrip = ctmenu
            End With

        End Sub



#End Region
    End Class
End Namespace