<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        tx_prompt = New TextBox()
        lbl_prompt = New Label()
        Button1 = New Button()
        tx_promptFinal = New TextBox()
        Label1 = New Label()
        ck_tamaños = New CheckedListBox()
        Label2 = New Label()
        MenuStrip1 = New MenuStrip()
        AplicaciónToolStripMenuItem = New ToolStripMenuItem()
        MinimizarToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        ConfiguraciónToolStripMenuItem = New ToolStripMenuItem()
        DocumentaciónToolStripMenuItem = New ToolStripMenuItem()
        VerDocumentaciónToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator3 = New ToolStripSeparator()
        ReportarErrorToolStripMenuItem = New ToolStripMenuItem()
        EnviarSugerenciaToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator2 = New ToolStripSeparator()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        StatusStrip1 = New StatusStrip()
        lb_status = New ToolStripStatusLabel()
        pb_working = New ToolStripProgressBar()
        tx_log = New TextBox()
        tx_output_filename = New TextBox()
        lb_outputpath = New Label()
        MenuStrip1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' tx_prompt
        ' 
        tx_prompt.Location = New Point(12, 75)
        tx_prompt.Multiline = True
        tx_prompt.Name = "tx_prompt"
        tx_prompt.PlaceholderText = "Una hoja de libreta con una pluma escribiendo.."
        tx_prompt.ScrollBars = ScrollBars.Both
        tx_prompt.Size = New Size(471, 51)
        tx_prompt.TabIndex = 0
        ' 
        ' lbl_prompt
        ' 
        lbl_prompt.AutoSize = True
        lbl_prompt.Location = New Point(12, 47)
        lbl_prompt.Name = "lbl_prompt"
        lbl_prompt.Size = New Size(346, 25)
        lbl_prompt.TabIndex = 1
        lbl_prompt.Text = "Prompt (petición del contenido del icono):"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 281)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 2
        Button1.Text = "Crear icono"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' tx_promptFinal
        ' 
        tx_promptFinal.Location = New Point(12, 166)
        tx_promptFinal.Multiline = True
        tx_promptFinal.Name = "tx_promptFinal"
        tx_promptFinal.Size = New Size(471, 109)
        tx_promptFinal.TabIndex = 3
        tx_promptFinal.Text = "Crea un icono de"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 138)
        Label1.Name = "Label1"
        Label1.Size = New Size(115, 25)
        Label1.TabIndex = 4
        Label1.Text = "Petición final:"
        ' 
        ' ck_tamaños
        ' 
        ck_tamaños.FormattingEnabled = True
        ck_tamaños.Location = New Point(510, 75)
        ck_tamaños.Name = "ck_tamaños"
        ck_tamaños.Size = New Size(212, 200)
        ck_tamaños.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(510, 47)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 25)
        Label2.TabIndex = 6
        Label2.Text = "Tamaños:"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {AplicaciónToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(734, 33)
        MenuStrip1.TabIndex = 7
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' AplicaciónToolStripMenuItem
        ' 
        AplicaciónToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {MinimizarToolStripMenuItem, ToolStripSeparator1, ConfiguraciónToolStripMenuItem, DocumentaciónToolStripMenuItem, ToolStripSeparator2, SalirToolStripMenuItem})
        AplicaciónToolStripMenuItem.Name = "AplicaciónToolStripMenuItem"
        AplicaciónToolStripMenuItem.Size = New Size(109, 29)
        AplicaciónToolStripMenuItem.Text = "&Aplicación"
        ' 
        ' MinimizarToolStripMenuItem
        ' 
        MinimizarToolStripMenuItem.Name = "MinimizarToolStripMenuItem"
        MinimizarToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.Down
        MinimizarToolStripMenuItem.Size = New Size(290, 34)
        MinimizarToolStripMenuItem.Text = "&Minimizar"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(287, 6)
        ' 
        ' ConfiguraciónToolStripMenuItem
        ' 
        ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        ConfiguraciónToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.O
        ConfiguraciónToolStripMenuItem.Size = New Size(290, 34)
        ConfiguraciónToolStripMenuItem.Text = "&Configuración"
        ' 
        ' DocumentaciónToolStripMenuItem
        ' 
        DocumentaciónToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {VerDocumentaciónToolStripMenuItem, ToolStripSeparator3, ReportarErrorToolStripMenuItem, EnviarSugerenciaToolStripMenuItem})
        DocumentaciónToolStripMenuItem.Name = "DocumentaciónToolStripMenuItem"
        DocumentaciónToolStripMenuItem.Size = New Size(290, 34)
        DocumentaciónToolStripMenuItem.Text = "&Documentación"
        ' 
        ' VerDocumentaciónToolStripMenuItem
        ' 
        VerDocumentaciónToolStripMenuItem.Name = "VerDocumentaciónToolStripMenuItem"
        VerDocumentaciónToolStripMenuItem.ShortcutKeys = Keys.F1
        VerDocumentaciónToolStripMenuItem.Size = New Size(298, 34)
        VerDocumentaciónToolStripMenuItem.Text = "&Ver documentación"
        ' 
        ' ToolStripSeparator3
        ' 
        ToolStripSeparator3.Name = "ToolStripSeparator3"
        ToolStripSeparator3.Size = New Size(295, 6)
        ' 
        ' ReportarErrorToolStripMenuItem
        ' 
        ReportarErrorToolStripMenuItem.Name = "ReportarErrorToolStripMenuItem"
        ReportarErrorToolStripMenuItem.ShortcutKeys = Keys.F2
        ReportarErrorToolStripMenuItem.Size = New Size(298, 34)
        ReportarErrorToolStripMenuItem.Text = "&Reportar error"
        ' 
        ' EnviarSugerenciaToolStripMenuItem
        ' 
        EnviarSugerenciaToolStripMenuItem.Name = "EnviarSugerenciaToolStripMenuItem"
        EnviarSugerenciaToolStripMenuItem.ShortcutKeys = Keys.F3
        EnviarSugerenciaToolStripMenuItem.Size = New Size(298, 34)
        EnviarSugerenciaToolStripMenuItem.Text = "&Enviar Sugerencia"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(287, 6)
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.ShortcutKeys = Keys.Alt Or Keys.F4
        SalirToolStripMenuItem.Size = New Size(290, 34)
        SalirToolStripMenuItem.Text = "&Salir"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(24, 24)
        StatusStrip1.Items.AddRange(New ToolStripItem() {lb_status, pb_working})
        StatusStrip1.Location = New Point(0, 454)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(734, 32)
        StatusStrip1.TabIndex = 8
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' lb_status
        ' 
        lb_status.Name = "lb_status"
        lb_status.Size = New Size(105, 25)
        lb_status.Text = "Estado: chill"
        ' 
        ' pb_working
        ' 
        pb_working.Name = "pb_working"
        pb_working.Size = New Size(100, 24)
        pb_working.Style = ProgressBarStyle.Marquee
        pb_working.ToolTipText = "Progreso de la tarea"
        pb_working.Visible = False
        ' 
        ' tx_log
        ' 
        tx_log.Location = New Point(14, 321)
        tx_log.Multiline = True
        tx_log.Name = "tx_log"
        tx_log.ReadOnly = True
        tx_log.ScrollBars = ScrollBars.Both
        tx_log.Size = New Size(708, 130)
        tx_log.TabIndex = 9
        tx_log.TextAlign = HorizontalAlignment.Center
        tx_log.Visible = False
        ' 
        ' tx_output_filename
        ' 
        tx_output_filename.Location = New Point(510, 284)
        tx_output_filename.Name = "tx_output_filename"
        tx_output_filename.Size = New Size(212, 31)
        tx_output_filename.TabIndex = 10
        ' 
        ' lb_outputpath
        ' 
        lb_outputpath.Location = New Point(216, 287)
        lb_outputpath.Name = "lb_outputpath"
        lb_outputpath.Size = New Size(288, 28)
        lb_outputpath.TabIndex = 11
        lb_outputpath.Text = "Label3"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(734, 486)
        Controls.Add(lb_outputpath)
        Controls.Add(tx_output_filename)
        Controls.Add(tx_log)
        Controls.Add(StatusStrip1)
        Controls.Add(Label2)
        Controls.Add(ck_tamaños)
        Controls.Add(Label1)
        Controls.Add(tx_promptFinal)
        Controls.Add(Button1)
        Controls.Add(lbl_prompt)
        Controls.Add(tx_prompt)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tx_prompt As TextBox
    Friend WithEvents lbl_prompt As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents tx_promptFinal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ck_tamaños As CheckedListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AplicaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MinimizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ConfiguraciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DocumentaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerDocumentaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ReportarErrorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnviarSugerenciaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lb_status As ToolStripStatusLabel
    Friend WithEvents pb_working As ToolStripProgressBar
    Friend WithEvents tx_log As TextBox
    Friend WithEvents tx_output_filename As TextBox
    Friend WithEvents lb_outputpath As Label

End Class
