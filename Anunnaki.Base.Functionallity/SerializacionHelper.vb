Imports System.Runtime.InteropServices.ObjectiveC
Imports System.Runtime.Serialization

Namespace Serialization
    Public Class SerializacionHelper


        ''' <summary>
        ''' Serializa un objeto cualquiera a un stream json
        ''' </summary>
        ''' <typeparam name="T">El tipo de objeto a serializar</typeparam>
        ''' <param name="objeto">El objeto a serializar</param>
        ''' <returns>Devuelve un stream con el objeto serializado con <see cref="System.Runtime.Serialization.Json.DataContractJsonSerializer"></see> </returns>
        ''' <remarks> Deserailiza de vuelta usando <see cref="Deserializar(Of T)(IO.Stream)"></see> </remarks>
        Public Shared Function Serializar(Of T)(objeto As T) As System.IO.Stream
            Dim js As System.Runtime.Serialization.Json.DataContractJsonSerializer
            Dim ms As New IO.MemoryStream
            Try
                js = New Json.DataContractJsonSerializer(objeto.GetType())
                js.WriteObject(ms, objeto)
            Catch

            End Try
            Return ms
        End Function

        ''' <summary>
        ''' Deerializa un stream de un modelo
        ''' </summary>
        ''' <typeparam name="T">El tipo de objeto a serializar</typeparam>
        ''' <param name="strim">EL stream con el objeto JSON serializado con el método <see cref="Serializar(Of T)(T)"/> </param>
        ''' <returns>Devuelve el modelo deserializado</returns>
        Public Shared Function Deserializar(Of T)(strim As System.IO.Stream) As T
            If (strim IsNot Nothing) = False Then Return Nothing
            Dim objeto As T = Activator.CreateInstance(Of T)()

            Dim js As System.Runtime.Serialization.Json.DataContractJsonSerializer
            Try
                js = New Json.DataContractJsonSerializer(objeto.GetType())
                objeto = js.ReadObject(strim)
            Catch
            End Try
            Return objeto
        End Function

    End Class
End Namespace
