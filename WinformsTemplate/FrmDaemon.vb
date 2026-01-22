Public Class FrmDaemon
    Inherits System.Windows.Forms.Form




#Region "diseñador"

    Public Sub New()
        InitializeComponent()


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

    'Required by the Windows Form Designer
    Private ReadOnly components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        SuspendLayout()
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
        ResumeLayout(False)


    End Sub
#End Region
End Class
