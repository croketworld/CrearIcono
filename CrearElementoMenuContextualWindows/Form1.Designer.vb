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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label2 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        CheckBox1 = New CheckBox()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        CheckBox2 = New CheckBox()
        GroupBox1 = New GroupBox()
        CheckBox4 = New CheckBox()
        CheckBox3 = New CheckBox()
        GroupBox2 = New GroupBox()
        Button3 = New Button()
        GroupBox3 = New GroupBox()
        TextBox3 = New TextBox()
        Label4 = New Label()
        ToolTip1 = New ToolTip(components)
        ListBox1 = New ListBox()
        Button4 = New Button()
        Button5 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        Button6 = New Button()
        GroupBox4 = New GroupBox()
        MenuStrip1 = New MenuStrip()
        AplicaciónToolStripMenuItem = New ToolStripMenuItem()
        MinimizarToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        DocumentaciónOnlineToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator2 = New ToolStripSeparator()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        ArchivoelementoDeMenúContextualToolStripMenuItem = New ToolStripMenuItem()
        CargarToolStripMenuItem = New ToolStripMenuItem()
        GuardarToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator4 = New ToolStripSeparator()
        ReestablecerToolStripMenuItem = New ToolStripMenuItem()
        EliminarToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator3 = New ToolStripSeparator()
        ProbarToolStripMenuItem = New ToolStripMenuItem()
        CrearToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator5 = New ToolStripSeparator()
        ClonarToolStripMenuItem = New ToolStripMenuItem()
        GroupBox5 = New GroupBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        MenuStrip1.SuspendLayout()
        GroupBox5.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(11, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(65, 25)
        Label1.TabIndex = 0
        Label1.Text = "Acción"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.ControlDark
        TextBox1.ForeColor = SystemColors.GradientInactiveCaption
        TextBox1.Location = New Point(11, 60)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(484, 31)
        TextBox1.TabIndex = 0
        ToolTip1.SetToolTip(TextBox1, "La ruta que del archivo, aplicación o script que se ejecutará")
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.ControlDark
        TextBox2.ForeColor = SystemColors.GradientInactiveCaption
        TextBox2.Location = New Point(11, 119)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.ScrollBars = ScrollBars.Both
        TextBox2.Size = New Size(484, 110)
        TextBox2.TabIndex = 0
        TextBox2.Text = """%1"""
        ToolTip1.SetToolTip(TextBox2, resources.GetString("TextBox2.ToolTip"))
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(11, 91)
        Label2.Name = "Label2"
        Label2.Size = New Size(111, 25)
        Label2.TabIndex = 2
        Label2.Text = "Argumentos"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Peru
        Button1.Enabled = False
        Button1.ForeColor = SystemColors.GradientInactiveCaption
        Button1.Location = New Point(18, 33)
        Button1.Name = "Button1"
        Button1.Size = New Size(96, 34)
        Button1.TabIndex = 4
        Button1.Text = "Probar"
        ToolTip1.SetToolTip(Button1, "Realiza la ejecución del comando con depuración, para capturar cualquier error que pueda producirse y ver si funciona antes de registrarlo")
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.SeaGreen
        Button2.Enabled = False
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(18, 73)
        Button2.Name = "Button2"
        Button2.Size = New Size(111, 57)
        Button2.TabIndex = 5
        Button2.Text = "Crear"
        ToolTip1.SetToolTip(Button2, "Crea el comando en el registro de windows")
        Button2.UseVisualStyleBackColor = False
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(11, 235)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(266, 29)
        CheckBox1.TabIndex = 3
        CheckBox1.Text = "Ejecutar cómo administrador"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ControlDark
        PictureBox1.Location = New Point(20, 58)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(32, 32)
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(9, 31)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 25)
        Label3.TabIndex = 8
        Label3.Text = "Icono"
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.BackColor = SystemColors.ControlDark
        CheckBox2.ForeColor = SystemColors.GradientInactiveCaption
        CheckBox2.Location = New Point(28, 42)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(193, 29)
        CheckBox2.TabIndex = 9
        CheckBox2.Text = "Fondo de escritorio"
        CheckBox2.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.LightSlateGray
        GroupBox1.Controls.Add(CheckBox4)
        GroupBox1.Controls.Add(CheckBox3)
        GroupBox1.Controls.Add(CheckBox2)
        GroupBox1.ForeColor = SystemColors.GradientActiveCaption
        GroupBox1.Location = New Point(318, 336)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(300, 150)
        GroupBox1.TabIndex = 10
        GroupBox1.TabStop = False
        GroupBox1.Text = "Donde debe aparecer"
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.BackColor = SystemColors.ControlDark
        CheckBox4.ForeColor = SystemColors.GradientInactiveCaption
        CheckBox4.Location = New Point(28, 115)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(106, 29)
        CheckBox4.TabIndex = 11
        CheckBox4.Text = "Archivos"
        CheckBox4.UseVisualStyleBackColor = False
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.BackColor = SystemColors.ControlDark
        CheckBox3.ForeColor = SystemColors.GradientInactiveCaption
        CheckBox3.Location = New Point(28, 77)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(107, 29)
        CheckBox3.TabIndex = 10
        CheckBox3.Text = "Carpetas"
        CheckBox3.UseVisualStyleBackColor = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.LightSlateGray
        GroupBox2.Controls.Add(Button3)
        GroupBox2.Controls.Add(TextBox1)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(TextBox2)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(CheckBox1)
        GroupBox2.ForeColor = SystemColors.GradientActiveCaption
        GroupBox2.Location = New Point(12, 52)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(558, 280)
        GroupBox2.TabIndex = 11
        GroupBox2.TabStop = False
        GroupBox2.Text = "Comando"
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ControlDark
        Button3.ForeColor = SystemColors.GradientInactiveCaption
        Button3.Location = New Point(501, 60)
        Button3.Name = "Button3"
        Button3.Size = New Size(40, 31)
        Button3.TabIndex = 1
        Button3.Text = "..."
        ToolTip1.SetToolTip(Button3, "Selecciona una aplicación, script o archivo mediante un diálogo")
        Button3.UseVisualStyleBackColor = False
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.LightSlateGray
        GroupBox3.Controls.Add(TextBox3)
        GroupBox3.Controls.Add(Label4)
        GroupBox3.Controls.Add(PictureBox1)
        GroupBox3.Controls.Add(Label3)
        GroupBox3.ForeColor = SystemColors.GradientActiveCaption
        GroupBox3.Location = New Point(12, 336)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(300, 150)
        GroupBox3.TabIndex = 12
        GroupBox3.TabStop = False
        GroupBox3.Text = "Aspecto"
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.ControlDark
        TextBox3.ForeColor = SystemColors.GradientInactiveCaption
        TextBox3.Location = New Point(72, 59)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(222, 31)
        TextBox3.TabIndex = 10
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(69, 31)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 25)
        Label4.TabIndex = 9
        Label4.Text = "Texto"
        ' 
        ' ListBox1
        ' 
        ListBox1.BackColor = SystemColors.ControlDark
        ListBox1.ColumnWidth = 80
        ListBox1.Dock = DockStyle.Fill
        ListBox1.ForeColor = SystemColors.GradientInactiveCaption
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(3, 27)
        ListBox1.MultiColumn = True
        ListBox1.Name = "ListBox1"
        ListBox1.SelectionMode = SelectionMode.MultiSimple
        ListBox1.Size = New Size(246, 120)
        ListBox1.TabIndex = 0
        ToolTip1.SetToolTip(ListBox1, "Lista de extensiones de archivo en los cuales será visible éste menú contextual." & vbCrLf & "Por ejemplo:" & vbCrLf & "jpg" & vbCrLf & "png" & vbCrLf & "jpeg" & vbCrLf & "webp" & vbCrLf & "svg")
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.PaleVioletRed
        Button4.Enabled = False
        Button4.ForeColor = SystemColors.GradientInactiveCaption
        Button4.Location = New Point(152, 153)
        Button4.Name = "Button4"
        Button4.Size = New Size(112, 34)
        Button4.TabIndex = 14
        Button4.Text = "Eliminar"
        ToolTip1.SetToolTip(Button4, "Elimina el comando actual del registro de Windows")
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.SteelBlue
        Button5.Enabled = False
        Button5.ForeColor = SystemColors.GradientInactiveCaption
        Button5.Location = New Point(152, 73)
        Button5.Name = "Button5"
        Button5.Size = New Size(112, 34)
        Button5.TabIndex = 15
        Button5.Text = "Guardar"
        ToolTip1.SetToolTip(Button5, "Guarda el comando actual del registro de Windows para posteriormente poder eliminarlo o editarlo")
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.DarkGoldenrod
        Button7.Enabled = False
        Button7.ForeColor = SystemColors.GradientInactiveCaption
        Button7.Location = New Point(139, 32)
        Button7.Name = "Button7"
        Button7.Size = New Size(125, 34)
        Button7.TabIndex = 17
        Button7.Text = "Reestablecer"
        ToolTip1.SetToolTip(Button7, "Recupera los valores originales del elemento de menú cargado o dejándolo en blanco si se ha iniciadosi no se ha cargado ninguno. Al realizar ésta acción pierdes todos los cambios.")
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.LightSalmon
        Button8.Enabled = False
        Button8.ForeColor = SystemColors.GradientInactiveCaption
        Button8.Location = New Point(18, 136)
        Button8.Name = "Button8"
        Button8.Size = New Size(96, 34)
        Button8.TabIndex = 18
        Button8.Text = "Clonar"
        ToolTip1.SetToolTip(Button8, "Inicia una nueva instancia de la aplicación, clonando los datos actuales")
        Button8.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.BlueViolet
        Button6.Enabled = False
        Button6.ForeColor = SystemColors.GradientInactiveCaption
        Button6.Location = New Point(152, 113)
        Button6.Name = "Button6"
        Button6.Size = New Size(112, 34)
        Button6.TabIndex = 16
        Button6.Text = "Cargar"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackColor = Color.LightSlateGray
        GroupBox4.Controls.Add(ListBox1)
        GroupBox4.ForeColor = SystemColors.GradientActiveCaption
        GroupBox4.Location = New Point(624, 336)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(252, 150)
        GroupBox4.TabIndex = 13
        GroupBox4.TabStop = False
        GroupBox4.Text = "Extensiones de archivo"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.LightSlateGray
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {AplicaciónToolStripMenuItem, ArchivoelementoDeMenúContextualToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1218, 33)
        MenuStrip1.TabIndex = 17
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' AplicaciónToolStripMenuItem
        ' 
        AplicaciónToolStripMenuItem.BackColor = Color.LightSlateGray
        AplicaciónToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {MinimizarToolStripMenuItem, ToolStripSeparator1, DocumentaciónOnlineToolStripMenuItem, ToolStripSeparator2, SalirToolStripMenuItem})
        AplicaciónToolStripMenuItem.ForeColor = SystemColors.GradientActiveCaption
        AplicaciónToolStripMenuItem.Name = "AplicaciónToolStripMenuItem"
        AplicaciónToolStripMenuItem.Size = New Size(109, 29)
        AplicaciónToolStripMenuItem.Text = "&Aplicación"
        ' 
        ' MinimizarToolStripMenuItem
        ' 
        MinimizarToolStripMenuItem.BackColor = SystemColors.ControlDark
        MinimizarToolStripMenuItem.ForeColor = SystemColors.GradientInactiveCaption
        MinimizarToolStripMenuItem.Name = "MinimizarToolStripMenuItem"
        MinimizarToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.Down
        MinimizarToolStripMenuItem.Size = New Size(323, 34)
        MinimizarToolStripMenuItem.Text = "&Minimizar"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(320, 6)
        ' 
        ' DocumentaciónOnlineToolStripMenuItem
        ' 
        DocumentaciónOnlineToolStripMenuItem.BackColor = SystemColors.ControlDark
        DocumentaciónOnlineToolStripMenuItem.ForeColor = SystemColors.GradientInactiveCaption
        DocumentaciónOnlineToolStripMenuItem.Name = "DocumentaciónOnlineToolStripMenuItem"
        DocumentaciónOnlineToolStripMenuItem.ShortcutKeys = Keys.F1
        DocumentaciónOnlineToolStripMenuItem.Size = New Size(323, 34)
        DocumentaciónOnlineToolStripMenuItem.Text = "&Documentación online"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(320, 6)
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.BackColor = SystemColors.ControlDark
        SalirToolStripMenuItem.ForeColor = SystemColors.GradientInactiveCaption
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.ShortcutKeys = Keys.Alt Or Keys.F4
        SalirToolStripMenuItem.Size = New Size(323, 34)
        SalirToolStripMenuItem.Text = "&Salir"
        ' 
        ' ArchivoelementoDeMenúContextualToolStripMenuItem
        ' 
        ArchivoelementoDeMenúContextualToolStripMenuItem.BackColor = Color.LightSlateGray
        ArchivoelementoDeMenúContextualToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CargarToolStripMenuItem, GuardarToolStripMenuItem, ToolStripSeparator4, ReestablecerToolStripMenuItem, EliminarToolStripMenuItem, ToolStripSeparator3, ProbarToolStripMenuItem, CrearToolStripMenuItem, ToolStripSeparator5, ClonarToolStripMenuItem})
        ArchivoelementoDeMenúContextualToolStripMenuItem.ForeColor = SystemColors.GradientActiveCaption
        ArchivoelementoDeMenúContextualToolStripMenuItem.Name = "ArchivoelementoDeMenúContextualToolStripMenuItem"
        ArchivoelementoDeMenúContextualToolStripMenuItem.Size = New Size(338, 29)
        ArchivoelementoDeMenúContextualToolStripMenuItem.Text = "&Archivo (elemento de menú contextual)"
        ' 
        ' CargarToolStripMenuItem
        ' 
        CargarToolStripMenuItem.BackColor = Color.BlueViolet
        CargarToolStripMenuItem.ForeColor = SystemColors.GradientInactiveCaption
        CargarToolStripMenuItem.Name = "CargarToolStripMenuItem"
        CargarToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.O
        CargarToolStripMenuItem.Size = New Size(330, 36)
        CargarToolStripMenuItem.Text = "Cargar"
        CargarToolStripMenuItem.ToolTipText = "Carga un elemento de menú contextual previamente creado para editarlo o eliminarlo"
        ' 
        ' GuardarToolStripMenuItem
        ' 
        GuardarToolStripMenuItem.BackColor = Color.SteelBlue
        GuardarToolStripMenuItem.ForeColor = SystemColors.GradientInactiveCaption
        GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        GuardarToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.S
        GuardarToolStripMenuItem.Size = New Size(330, 36)
        GuardarToolStripMenuItem.Text = "Guardar"
        GuardarToolStripMenuItem.ToolTipText = "Guarda el comando actual del registro de Windows para posteriormente poder eliminarlo o editarlo"
        ' 
        ' ToolStripSeparator4
        ' 
        ToolStripSeparator4.Name = "ToolStripSeparator4"
        ToolStripSeparator4.Size = New Size(327, 6)
        ' 
        ' ReestablecerToolStripMenuItem
        ' 
        ReestablecerToolStripMenuItem.BackColor = Color.DarkGoldenrod
        ReestablecerToolStripMenuItem.ForeColor = SystemColors.GradientInactiveCaption
        ReestablecerToolStripMenuItem.Name = "ReestablecerToolStripMenuItem"
        ReestablecerToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.Z
        ReestablecerToolStripMenuItem.Size = New Size(330, 36)
        ReestablecerToolStripMenuItem.Text = "&Reestablecer"
        ReestablecerToolStripMenuItem.ToolTipText = "Recupera los valores originales del elemento de menú cargado o dejándolo en blanco si se ha iniciadosi no se ha cargado ninguno. Al realizar ésta acción pierdes todos los cambios."
        ' 
        ' EliminarToolStripMenuItem
        ' 
        EliminarToolStripMenuItem.BackColor = Color.PaleVioletRed
        EliminarToolStripMenuItem.ForeColor = SystemColors.GradientInactiveCaption
        EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        EliminarToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.Delete
        EliminarToolStripMenuItem.Size = New Size(330, 36)
        EliminarToolStripMenuItem.Text = "Eliminar"
        EliminarToolStripMenuItem.ToolTipText = "Elimina el comando actual del registro de Windows"
        ' 
        ' ToolStripSeparator3
        ' 
        ToolStripSeparator3.Name = "ToolStripSeparator3"
        ToolStripSeparator3.Size = New Size(327, 6)
        ' 
        ' ProbarToolStripMenuItem
        ' 
        ProbarToolStripMenuItem.BackColor = Color.Peru
        ProbarToolStripMenuItem.ForeColor = SystemColors.GradientInactiveCaption
        ProbarToolStripMenuItem.Name = "ProbarToolStripMenuItem"
        ProbarToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.F5
        ProbarToolStripMenuItem.Size = New Size(330, 36)
        ProbarToolStripMenuItem.Text = "Probar"
        ' 
        ' CrearToolStripMenuItem
        ' 
        CrearToolStripMenuItem.BackColor = Color.SeaGreen
        CrearToolStripMenuItem.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CrearToolStripMenuItem.ForeColor = SystemColors.GradientInactiveCaption
        CrearToolStripMenuItem.Name = "CrearToolStripMenuItem"
        CrearToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.Alt Or Keys.F5
        CrearToolStripMenuItem.Size = New Size(330, 36)
        CrearToolStripMenuItem.Text = "Crear"
        CrearToolStripMenuItem.ToolTipText = "Crea el comando en el registro de windows"
        ' 
        ' ToolStripSeparator5
        ' 
        ToolStripSeparator5.Name = "ToolStripSeparator5"
        ToolStripSeparator5.Size = New Size(327, 6)
        ' 
        ' ClonarToolStripMenuItem
        ' 
        ClonarToolStripMenuItem.BackColor = Color.LightSalmon
        ClonarToolStripMenuItem.ForeColor = SystemColors.GradientInactiveCaption
        ClonarToolStripMenuItem.Name = "ClonarToolStripMenuItem"
        ClonarToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.Shift Or Keys.C
        ClonarToolStripMenuItem.Size = New Size(330, 36)
        ClonarToolStripMenuItem.Text = "Clonar"
        ' 
        ' GroupBox5
        ' 
        GroupBox5.BackColor = Color.LightSlateGray
        GroupBox5.Controls.Add(Button8)
        GroupBox5.Controls.Add(Button7)
        GroupBox5.Controls.Add(Button1)
        GroupBox5.Controls.Add(Button6)
        GroupBox5.Controls.Add(Button2)
        GroupBox5.Controls.Add(Button5)
        GroupBox5.Controls.Add(Button4)
        GroupBox5.ForeColor = SystemColors.GradientActiveCaption
        GroupBox5.Location = New Point(576, 52)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(300, 205)
        GroupBox5.TabIndex = 18
        GroupBox5.TabStop = False
        GroupBox5.Text = "Acciones"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSlateGray
        ClientSize = New Size(1218, 664)
        Controls.Add(GroupBox5)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(MenuStrip1)
        ForeColor = SystemColors.GradientActiveCaption
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Crear acción en menú contextual explorador de Wndows"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        GroupBox5.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AplicaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MinimizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents DocumentaciónOnlineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArchivoelementoDeMenúContextualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ProbarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ReestablecerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents ClonarToolStripMenuItem As ToolStripMenuItem

End Class
