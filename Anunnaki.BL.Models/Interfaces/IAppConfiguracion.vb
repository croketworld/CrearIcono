Imports System.Drawing
Imports Anunnaki.Models.Base

Public Interface IAppConfiguracion
    Inherits IConfiguracion


    ''' <summary>
    ''' Comportamineto aplicación / iniciar en la bandeja del sistema (junto al reló miarma!)
    ''' </summary>
    ''' <returns></returns>
    Property Form_IniciarMinizado As Boolean


    ''' <summary>
    ''' El tamaño del formulario
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks>Por defecto tendrá un valor de 1240 x 720</remarks>
    Property Form_Tamaño As Point

    ''' <summary>
    ''' Idioma de la aplicación
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks>Iniciales: es y en</remarks>
    Property Idioma As String



    Sub Copiar(configbase As [IAppConfiguracion])




End Interface


