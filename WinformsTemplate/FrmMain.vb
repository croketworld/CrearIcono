Public Class FrmMain
    Inherits System.Windows.Forms.Form



#Region "inicio"

    Public Sub Iniciar()
        Me.Text = ""



    End Sub



#End Region


#Region "diseñador"

    Public Sub New()
        InitializeComponent()
        AddHandler Me.Load, AddressOf Iniciar


        AddHandler MinimizarToolStripMenuItem.Click, AddressOf My.Application.Minimizar
        AddHandler SalirToolStripMenuItem.Click, AddressOf My.Application.Salir



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

#Region "declaraciones de componentes"


    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AplicaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MinimizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents DocumentaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerDocumentaciónonlineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportarErrorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SugerirMejoraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Lb_status As ToolStripStatusLabel
    Friend WithEvents Pb_status As ToolStripProgressBar
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem

    'Required by the Windows Form Designer
    Private ReadOnly components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        MenuStrip1 = New MenuStrip()
        AplicaciónToolStripMenuItem = New ToolStripMenuItem()
        MinimizarToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        DocumentaciónToolStripMenuItem = New ToolStripMenuItem()
        VerDocumentaciónonlineToolStripMenuItem = New ToolStripMenuItem()
        ReportarErrorToolStripMenuItem = New ToolStripMenuItem()
        SugerirMejoraToolStripMenuItem = New ToolStripMenuItem()
        ActualizarToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator2 = New ToolStripSeparator()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        ArchivoToolStripMenuItem = New ToolStripMenuItem()
        StatusStrip1 = New StatusStrip()
        Lb_status = New ToolStripStatusLabel()
        Pb_status = New ToolStripProgressBar()
        MenuStrip1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {AplicaciónToolStripMenuItem, ArchivoToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1218, 33)
        MenuStrip1.TabIndex = 0
        ' 
        ' AplicaciónToolStripMenuItem
        ' 
        AplicaciónToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {MinimizarToolStripMenuItem, ToolStripSeparator1, DocumentaciónToolStripMenuItem, ActualizarToolStripMenuItem, ToolStripSeparator2, SalirToolStripMenuItem})
        AplicaciónToolStripMenuItem.Name = "AplicaciónToolStripMenuItem"
        AplicaciónToolStripMenuItem.Size = New Size(109, 29)
        AplicaciónToolStripMenuItem.Text = "&Aplicación"
        ' 
        ' MinimizarToolStripMenuItem
        ' 
        MinimizarToolStripMenuItem.Name = "MinimizarToolStripMenuItem"
        MinimizarToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.Down
        MinimizarToolStripMenuItem.Size = New Size(289, 34)
        MinimizarToolStripMenuItem.Text = "&Minimizar"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(286, 6)
        ' 
        ' DocumentaciónToolStripMenuItem
        ' 
        DocumentaciónToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {VerDocumentaciónonlineToolStripMenuItem, ReportarErrorToolStripMenuItem, SugerirMejoraToolStripMenuItem})
        DocumentaciónToolStripMenuItem.Name = "DocumentaciónToolStripMenuItem"
        DocumentaciónToolStripMenuItem.Size = New Size(289, 34)
        DocumentaciónToolStripMenuItem.Text = "&Documentación"
        ' 
        ' VerDocumentaciónonlineToolStripMenuItem
        ' 
        VerDocumentaciónonlineToolStripMenuItem.Name = "VerDocumentaciónonlineToolStripMenuItem"
        VerDocumentaciónonlineToolStripMenuItem.ShortcutKeys = Keys.F1
        VerDocumentaciónonlineToolStripMenuItem.Size = New Size(353, 34)
        VerDocumentaciónonlineToolStripMenuItem.Text = "Ver Documentación &online"
        ' 
        ' ReportarErrorToolStripMenuItem
        ' 
        ReportarErrorToolStripMenuItem.Name = "ReportarErrorToolStripMenuItem"
        ReportarErrorToolStripMenuItem.ShortcutKeys = Keys.F2
        ReportarErrorToolStripMenuItem.Size = New Size(353, 34)
        ReportarErrorToolStripMenuItem.Text = "&Reportar error"
        ' 
        ' SugerirMejoraToolStripMenuItem
        ' 
        SugerirMejoraToolStripMenuItem.Name = "SugerirMejoraToolStripMenuItem"
        SugerirMejoraToolStripMenuItem.ShortcutKeys = Keys.F3
        SugerirMejoraToolStripMenuItem.Size = New Size(353, 34)
        SugerirMejoraToolStripMenuItem.Text = "&Sugerir mejora"
        ' 
        ' ActualizarToolStripMenuItem
        ' 
        ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        ActualizarToolStripMenuItem.ShortcutKeys = Keys.F5
        ActualizarToolStripMenuItem.Size = New Size(289, 34)
        ActualizarToolStripMenuItem.Text = "&Actualizar"
        ActualizarToolStripMenuItem.Visible = False
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(286, 6)
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.ShortcutKeys = Keys.Alt Or Keys.F4
        SalirToolStripMenuItem.Size = New Size(289, 34)
        SalirToolStripMenuItem.Text = "&Salir"
        ' 
        ' ArchivoToolStripMenuItem
        ' 
        ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        ArchivoToolStripMenuItem.Size = New Size(88, 29)
        ArchivoToolStripMenuItem.Text = "&Archivo"
        ArchivoToolStripMenuItem.Visible = False
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(24, 24)
        StatusStrip1.Items.AddRange(New ToolStripItem() {Lb_status, Pb_status})
        StatusStrip1.Location = New Point(0, 632)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(1218, 32)
        StatusStrip1.TabIndex = 1
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' Lb_status
        ' 
        Lb_status.AutoSize = False
        Lb_status.Name = "Lb_status"
        Lb_status.Size = New Size(1080, 25)
        Lb_status.Text = "Estado: chill"
        Lb_status.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Pb_status
        ' 
        Pb_status.AutoSize = False
        Pb_status.Name = "Pb_status"
        Pb_status.Size = New Size(100, 24)
        Pb_status.Style = ProgressBarStyle.Marquee
        Pb_status.Value = 60
        ' 
        ' FrmMain
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1218, 664)
        Controls.Add(StatusStrip1)
        Controls.Add(MenuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Name = "FrmMain"
        Text = "Plantilla"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub


#End Region

#End Region

End Class
