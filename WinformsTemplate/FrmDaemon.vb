Friend Class FrmDaemon
    Inherits System.Windows.Forms.Form




#Region "diseñador"

    Public Sub New()
        InitializeComponent()

        AddHandler MaximizarToolStripMenuItem.Click, AddressOf My.Application.Maximizar
        AddHandler SalirToolStripMenuItem.Click, AddressOf My.Application.Salir
        AddHandler NotifyIcon1.DoubleClick, AddressOf My.Application.Maximizar
    End Sub



    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents MaximizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        MaximizarToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        NotifyIcon1 = New NotifyIcon(components)
        ContextMenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(24, 24)
        ContextMenuStrip1.Items.AddRange(New ToolStripItem() {MaximizarToolStripMenuItem, ToolStripSeparator1, SalirToolStripMenuItem})
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(239, 74)
        ' 
        ' MaximizarToolStripMenuItem
        ' 
        MaximizarToolStripMenuItem.Name = "MaximizarToolStripMenuItem"
        MaximizarToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.Up
        MaximizarToolStripMenuItem.Size = New Size(238, 32)
        MaximizarToolStripMenuItem.Text = "&Maximizar"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(235, 6)
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.ShortcutKeys = Keys.Alt Or Keys.F4
        SalirToolStripMenuItem.Size = New Size(238, 32)
        SalirToolStripMenuItem.Text = "&Salir"
        ' 
        ' NotifyIcon1
        ' 
        NotifyIcon1.ContextMenuStrip = ContextMenuStrip1
        ' 
        ' FrmDaemon
        ' 
        AccessibleRole = AccessibleRole.None
        BackgroundImageLayout = ImageLayout.None
        CausesValidation = False
        ClientSize = New Size(278, 244)
        ControlBox = False
        MaximizeBox = False
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        Name = "FrmDaemon"
        Opacity = 0R
        ShowIcon = False
        ShowInTaskbar = False
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.Manual
        WindowState = FormWindowState.Minimized
        ContextMenuStrip1.ResumeLayout(False)
        ResumeLayout(False)


    End Sub

#End Region
End Class
