Imports System.IO
Imports System.Runtime.CompilerServices
Imports Anunnaki.BL.Serialization
Imports Anunnaki.Models.Base

Namespace Anunnaki.BL.Serialization


    Public Module SerializationModule

        <Extension>
        Public Function Serializar(config As AppConfiguracion) As Stream
            Return SerializacionHelper.Serializar(Of AppConfiguracion)(config)
        End Function

        <Extension>
        Public Sub Deserializar(config As AppConfiguracion, strim As Stream)
            config.Copiar(SerializacionHelper.Deserializar(Of AppConfiguracion)(strim))
        End Sub

    End Module
End Namespace
