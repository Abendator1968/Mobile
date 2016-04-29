Imports System.Web.Mvc
Imports Mobile.Mobile.Models

Namespace Mobile.Controllers

    Public Class HomeController
        Inherits Controller

        Private progs As Programmer() = {
            New Programmer("Alice", "Smith", "Lead Developer", "Paris", "France", "C#"),
            New Programmer("Joe", "Dunston", "Developer", "London", "UK", "Java"),
            New Programmer("Peter", "Jones", "Developer", "Chicago", "USA", "C#"),
            New Programmer("Murray", "Woods", "Jnr Developer", "Boston", "USA", "C#")
        }

        Public Function Index() As ActionResult

            Return View(progs)

        End Function

        'Public Function Browser() As ActionResult

        '    Return View()

        'End Function

    End Class

End Namespace
