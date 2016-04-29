Namespace Mobile.Models

    Public Class Programmer

        Public Property Nombre As String
        Public Property Apellidos As String
        Public Property Titulo As String
        Public Property Ciudad As String
        Public Property Pais As String
        Public Property Lenguaje As String

        Public Sub New(ByVal firstName As String, ByVal lastName As String, ByVal title As String, ByVal city As String, ByVal country As String, ByVal language As String)

            Nombre = firstName
            Apellidos = lastName
            Titulo = title
            Ciudad = city
            Pais = country
            Lenguaje = language

        End Sub

    End Class

End Namespace
