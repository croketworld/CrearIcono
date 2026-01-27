Imports System.Diagnostics.Eventing.Reader

Public Class Form1

    Public Elemento As ElementoMenuContextual

    Public ElementoCargado As ElementoMenuContextual

    Public RutaElementoCargadoGuardado As String

    '1: shell registro clasico
    'For files:
    'HKEY_CLASSES_ROOT\[FileExtension]\shell\[MenuItemName]\command
    '
    'For folders:
    'HKEY_CLASSES_ROOT\Directory\shell\[MenuItemName]\command
    '
    'For desktop background:
    'HKEY_CLASSES_ROOT\Directory\Background\shell\[MenuItemName]\command
    '
    '
    'using Microsoft.Win32;

    'RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\Classes\Directory\shell\MyCustomMenu");
    'key.SetValue("", "My Custom Command");
    'key.CreateSubKey("command").SetValue("", @"C:\path\to\your\app.exe ""%1""");   
    '

    '2 explorercommand windows 11 con app identity
    '
    'COM Shell Extension (Recommended for Windows 11+)
    'To ensure your context menu appears at the top level in Windows 11, you must implement a COM-based shell extension using the IExplorerCommand interface.
    'Steps:
    '        Implement IExplorerCommand:
    '            Define the command title, icon, tooltip, And logic In InvokeAsync.
    'Example: Return Task < String > GetTitleAsync() And Task InvokeAsync(). 
    'Register the COM Class:
    '   Use [ComVisible(true)], [ProgId(...)], And a unique [Guid(...)].
    '    Register via app manifest (For packaged apps) Or regsvr32 (Not recommended For modern apps).
    'Use a packaged app With identity:
    '    Windows 11 requires application identity (via AppX package Or manifest) for top-level context menu visibility. 
    '
    '


#Region "acciones ejecutable"

    ''' <summary>
    ''' seleccionar imagen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PictureBox1_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick
        Dim ofd As New OpenFileDialog

        With ofd
            .FileName = ""
            .CheckFileExists = True
            .Filter = "JPG|*.jpg|JPEG|*.jpeg|PNG|*.png|ICO|*.ico|BMP|*.bmp|WEBP|*.webp|Todos los archivos|*.*"
            .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures)
        End With

        Dim dlgres = ofd.ShowDialog
        If dlgres = DialogResult.OK And IO.File.Exists(ofd.FileName) Then Me.Elemento.RutaIcono = ofd.FileName
    End Sub

    ''' <summary>
    ''' seleccionar ruita de ejecutable
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ofd As New OpenFileDialog

        With ofd
            .FileName = ""
            .CheckFileExists = True
            .Filter = "Ejecutable|*.exe|Script por lotes|*.bat|script VB|*.vbs|Ejecutable MSI|*.msi|Script Python|*.py|Script Powershell|*.ps1|Todos los archivos|*.*"
            .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures)
        End With

        Dim dlgres = ofd.ShowDialog
        If dlgres = DialogResult.OK And IO.File.Exists(ofd.FileName) Then Me.Elemento.Accion = ofd.FileName
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Elemento = New ElementoMenuContextual
        Me.ElementoCargado = New ElementoMenuContextual

    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Elemento.EjecutarComoAdministrador = CheckBox1.Checked
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        GroupBox4.Visible = CheckBox4.Checked
    End Sub


#End Region

#Region "acciones app"

    Public Sub Documentación()
        Process.Start("https://github.com/croketworld/CrearIcono/blob/commander/CrearElementoMenuContextualWindows/Readme.md")
    End Sub

    Public Sub Salir()
        Dim salirok As Boolean = True
        If Me.Elemento.Estado <> 0 And Me.Elemento.Estado <> EEstadoElementoMenu.Guardado Then salirok = ConfirmarSalir()

        If salirok Then
            Environment.Exit(0)
        End If
    End Sub

    Public Sub Minimizar()

    End Sub

    Private Function ConfirmarSalir() As Boolean
        Dim texto As String = "Hay cambios sin guardar ¿deseas salir sin guardar los cambios?" &
            Environment.NewLine & "pulsa NO para cancelar el cierre de la aplicación." &
            Environment.NewLine & "pulsa SI para cerrar la aplicación perdiendo los cambios."
        Dim msgres As DialogResult = MessageBox.Show(texto, "Salir sin guardar cambios", MessageBoxButtons.YesNo)
        Return (msgres = DialogResult.Yes)
    End Function

    Private Function ConfirmarRecarga() As Boolean
        Dim texto As String = "Hay cambios sin guardar ¿deseas realizar la carga aún perdiendo los datos?" &
            Environment.NewLine & "pulsa NO para cargar el elemento en una nueva instancia." &
            Environment.NewLine & "pulsa SI para realizar la carga perdiendo los cambios."
        Dim msgres As DialogResult = MessageBox.Show(texto, "Cargar sin guardar cambios", MessageBoxButtons.YesNo)
        Return (msgres = DialogResult.Yes)
    End Function
#End Region


    Private Sub AñadirHandlers()
        AddHandler CrearToolStripMenuItem.Click, AddressOf Accion_CrearMenu
        AddHandler Button2.Click, AddressOf Accion_CrearMenu

        AddHandler Button8.Click, AddressOf Accion_Clonar
        AddHandler ClonarToolStripMenuItem.Click, AddressOf Accion_Clonar

        AddHandler ProbarToolStripMenuItem.Click, AddressOf Accion_Probar
        AddHandler Button1.Click, AddressOf Accion_Probar

        AddHandler ReestablecerToolStripMenuItem.Click, AddressOf Accion_Reestablecer
        AddHandler Button7.Click, AddressOf Accion_Reestablecer

        AddHandler GuardarToolStripMenuItem.Click, AddressOf Accion_Reestablecer
        AddHandler Button5.Click, AddressOf Accion_Reestablecer

        AddHandler CargarToolStripMenuItem.Click, AddressOf Accion_Cargar
        AddHandler Button6.Click, AddressOf Accion_Cargar

        AddHandler EliminarToolStripMenuItem.Click, AddressOf Accion_Eliminar
        AddHandler Button4.Click, AddressOf Accion_Eliminar


    End Sub

#Region "acciones usuario"

    Private Sub Accion_CrearMenu()

    End Sub

    Private Sub Accion_Clonar()

    End Sub

    Private Sub Accion_Probar()

    End Sub
    Private Sub Accion_Reestablecer()

    End Sub
    Private Sub Accion_Guardar()

    End Sub
    Public Sub Accion_Cargar()
        Dim ofd As New OpenFileDialog
        With ofd
            .Title = "Cargar elemento de menú contextual desde archivo"
            .Filter = "Elemento de menú contextual|*crkwdcme|Todos los archivos|*.*"
        End With
        Dim dlgres As DialogResult = ofd.ShowDialog
        If dlgres = DialogResult.OK Then
            Me.RutaElementoCargadoGuardado = ofd.FileName
        End If
        Accion_ReCargarElemento()
    End Sub

    Public Sub Accion_ReCargarElemento()
        Me.ElementoCargado = New ElementoMenuContextual(Me.RutaElementoCargadoGuardado)
        If Me.Elemento <> Me.ElementoCargado Then
            Dim confirmacion As DialogResult = ConfirmarRecarga()
            If confirmacion = DialogResult.Cancel Then Exit Sub
            If confirmacion = DialogResult.No Then

            End If
        End If
    End Sub

    ''' <summary>
    ''' Comprueba si el elemento es diferente de cuando se ha creado
    ''' </summary>
    ''' <returns></returns>
    Public Function Comprobar_esDiferente() As Boolean

    End Function


    Private Sub Accion_Eliminar()

    End Sub


#End Region

End Class
