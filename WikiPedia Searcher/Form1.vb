Imports System.Net

Public Class Form1




    Sub Search(ByRef SearchText As String)

        Dim SearchClient As New WebClient
        Dim WebResult As String = ""
        WebResult = SearchClient.DownloadString("https://en.wikipedia.org/w/api.php?action=opensearch&search" & SearchText)


    End Sub
End Class
