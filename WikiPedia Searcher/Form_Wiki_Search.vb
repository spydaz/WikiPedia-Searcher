Imports System.Net

Public Class Form_Wiki_Search




    Function Search(ByRef SearchText As String) As String

        Dim SearchClient As New WebClient
        Dim WebResult As String = ""
        Dim SearchResult As String = SearchText & ":" & vbNewLine
        WebResult = SearchClient.DownloadString("https://en.wikipedia.org/w/api.php?action=opensearch&search=" & SearchText & "&limit=10&namespace=0&format=json")
        ' "https://en.wikipedia.org/w/api.php?action=opensearch&search=Hampi&limit=10&namespace=0&format=jsonfm"
        'Char [] {' ', ',', '.', ':', '\t' }
        Dim DeserializedWebResult As Object = Newtonsoft.Json.JsonConvert.DeserializeObject(WebResult)
        Dim SearchResultArr() As String = DeserializedWebResult.ToString.Split(New Char() {"[", "]"c})

        Dim Count As Integer = 0
        For Each item In SearchResultArr
            If item.Contains(SearchText & " ") = True Then

                Dim SearchResultArr2() As String = item.Split(",")
                For Each Sentence In SearchResultArr2
                    If Sentence.Contains(SearchText & " ") = True Then



                        ' SearchResult &= "[" & Count & "]" & Sentence & vbNewLine
                        SearchResult &= Sentence & "." & vbNewLine
                        Count += 1

                    Else
                    End If
                Next



            Else
            End If

        Next
        Return SearchResult & vbNewLine
    End Function

    Function Getbetween(ByRef Item As String, ByRef FrontChar As Char, ByRef BackChar As Char) As String
        Dim Result As String = ""
        Dim front As Integer = Item.IndexOf(FrontChar) + 1
        Dim back As Integer = Item.IndexOf(BackChar)
        If front >= 0 AndAlso back > front Then
            Result &= Item.ToString.Substring(front, back - front) & vbNewLine
        End If
        Return Result
    End Function

    Private Sub GoSearch_Click(sender As Object, e As EventArgs) Handles GoSearch.Click
        Dim SearchMe As String = SearchText.Text
        SearchText.Text = ""
        DisplayText.Text &= Search(SearchMe)
    End Sub

    Private Sub ClearText_Click(sender As Object, e As EventArgs) Handles ClearText.Click
        DisplayText.Clear()
    End Sub
End Class
