<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDialog
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Friend WithEvents TableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents LabelProductName As System.Windows.Forms.Label
    Friend WithEvents LabelVersion As System.Windows.Forms.Label
    Friend WithEvents LabelCompanyName As System.Windows.Forms.Label
    Friend WithEvents TextBoxDescription As System.Windows.Forms.TextBox
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents LabelCopyright As System.Windows.Forms.Label

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDialog))
        TableLayoutPanel = New TableLayoutPanel()
        LogoPictureBox = New PictureBox()
        LabelProductName = New Label()
        LabelVersion = New Label()
        LabelCopyright = New Label()
        LabelCompanyName = New Label()
        TextBoxDescription = New TextBox()
        OKButton = New Button()
        TableLayoutPanel.SuspendLayout()
        CType(LogoPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TableLayoutPanel
        ' 
        TableLayoutPanel.ColumnCount = 2
        TableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33F))
        TableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 67F))
        TableLayoutPanel.Controls.Add(LogoPictureBox, 0, 0)
        TableLayoutPanel.Controls.Add(LabelProductName, 1, 0)
        TableLayoutPanel.Controls.Add(LabelVersion, 1, 1)
        TableLayoutPanel.Controls.Add(LabelCopyright, 1, 2)
        TableLayoutPanel.Controls.Add(LabelCompanyName, 1, 3)
        TableLayoutPanel.Controls.Add(TextBoxDescription, 1, 4)
        TableLayoutPanel.Controls.Add(OKButton, 1, 5)
        TableLayoutPanel.Dock = DockStyle.Fill
        TableLayoutPanel.Location = New Point(15, 17)
        TableLayoutPanel.Margin = New Padding(5, 6, 5, 6)
        TableLayoutPanel.Name = "TableLayoutPanel"
        TableLayoutPanel.RowCount = 6
        TableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel.Size = New Size(660, 497)
        TableLayoutPanel.TabIndex = 0
        ' 
        ' LogoPictureBox
        ' 
        LogoPictureBox.Dock = DockStyle.Fill
        LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), Image)
        LogoPictureBox.Location = New Point(5, 6)
        LogoPictureBox.Margin = New Padding(5, 6, 5, 6)
        LogoPictureBox.Name = "LogoPictureBox"
        TableLayoutPanel.SetRowSpan(LogoPictureBox, 6)
        LogoPictureBox.Size = New Size(207, 485)
        LogoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        LogoPictureBox.TabIndex = 0
        LogoPictureBox.TabStop = False
        ' 
        ' LabelProductName
        ' 
        LabelProductName.Dock = DockStyle.Fill
        LabelProductName.Location = New Point(227, 0)
        LabelProductName.Margin = New Padding(10, 0, 5, 0)
        LabelProductName.MaximumSize = New Size(0, 33)
        LabelProductName.Name = "LabelProductName"
        LabelProductName.Size = New Size(428, 33)
        LabelProductName.TabIndex = 0
        LabelProductName.Text = "Nombre de producto"
        LabelProductName.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LabelVersion
        ' 
        LabelVersion.Dock = DockStyle.Fill
        LabelVersion.Location = New Point(227, 49)
        LabelVersion.Margin = New Padding(10, 0, 5, 0)
        LabelVersion.MaximumSize = New Size(0, 33)
        LabelVersion.Name = "LabelVersion"
        LabelVersion.Size = New Size(428, 33)
        LabelVersion.TabIndex = 0
        LabelVersion.Text = "Versión"
        LabelVersion.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LabelCopyright
        ' 
        LabelCopyright.Dock = DockStyle.Fill
        LabelCopyright.Location = New Point(227, 98)
        LabelCopyright.Margin = New Padding(10, 0, 5, 0)
        LabelCopyright.MaximumSize = New Size(0, 33)
        LabelCopyright.Name = "LabelCopyright"
        LabelCopyright.Size = New Size(428, 33)
        LabelCopyright.TabIndex = 0
        LabelCopyright.Text = "Copyright"
        LabelCopyright.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LabelCompanyName
        ' 
        LabelCompanyName.Dock = DockStyle.Fill
        LabelCompanyName.Location = New Point(227, 147)
        LabelCompanyName.Margin = New Padding(10, 0, 5, 0)
        LabelCompanyName.MaximumSize = New Size(0, 33)
        LabelCompanyName.Name = "LabelCompanyName"
        LabelCompanyName.Size = New Size(428, 33)
        LabelCompanyName.TabIndex = 0
        LabelCompanyName.Text = "Nombre de la compañía"
        LabelCompanyName.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TextBoxDescription
        ' 
        TextBoxDescription.Dock = DockStyle.Fill
        TextBoxDescription.Location = New Point(227, 202)
        TextBoxDescription.Margin = New Padding(10, 6, 5, 6)
        TextBoxDescription.Multiline = True
        TextBoxDescription.Name = "TextBoxDescription"
        TextBoxDescription.ReadOnly = True
        TextBoxDescription.ScrollBars = ScrollBars.Both
        TextBoxDescription.Size = New Size(428, 236)
        TextBoxDescription.TabIndex = 0
        TextBoxDescription.TabStop = False
        TextBoxDescription.Text = resources.GetString("TextBoxDescription.Text")
        ' 
        ' OKButton
        ' 
        OKButton.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        OKButton.DialogResult = DialogResult.Cancel
        OKButton.Location = New Point(530, 450)
        OKButton.Margin = New Padding(5, 6, 5, 6)
        OKButton.Name = "OKButton"
        OKButton.Size = New Size(125, 41)
        OKButton.TabIndex = 0
        OKButton.Text = "&Aceptar"
        ' 
        ' FrmDialog
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = OKButton
        ClientSize = New Size(690, 531)
        Controls.Add(TableLayoutPanel)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(5, 6, 5, 6)
        MaximizeBox = False
        MinimizeBox = False
        Name = "FrmDialog"
        Padding = New Padding(15, 17, 15, 17)
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "FrmDialog"
        TableLayoutPanel.ResumeLayout(False)
        TableLayoutPanel.PerformLayout()
        CType(LogoPictureBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

End Class
