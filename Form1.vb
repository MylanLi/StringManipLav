Public Class Form1
    'String that will hold the word that is input by user
    Dim strInput As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnReverse_Click(sender As Object, e As EventArgs) Handles btnReverse.Click
        'assign what has been typed into textbox as the input word
        strInput = tbIn.Text
        'length of the string, to be used for loops, adjusted for index purposes
        Dim strInLen As Integer = strInput.Length - 1
        'array of chars to hold the word being constructed
        Dim chaOutput(0 To strInLen) As Char

        For i = 0 To strInLen
            chaOutput(i) = strInput(strInLen - i)
        Next

        Dim strOutput As String = New String(chaOutput)

        If String.Compare(strInput, strOutput, False) = 0 Then
            MessageBox.Show("Its an anagram!")
        End If

        lblOut.Text = strOutput


    End Sub
End Class
