Public Class Form1
    'Daniel Bullock
    'Number Occurences

    Private Sub btnCountNumerals_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCountNumerals.Click
        Const UNICODE_9 As Integer = AscW("9")
        Dim NumberCounts(UNICODE_9) As Integer

        Dim InputedNumbers As String = Me.txtEnterNumber.Text
        Call CountNumbers(InputedNumbers, NumberCounts)
        Call DisplayNumberCounts(NumberCounts, Me.lstNumbers)
    End Sub

    Sub CountNumbers(ByVal InputedNumbers As String, ByRef NumberCounts() As Integer)
        Dim NumberIndex As Integer
        Dim IndividualNumber As Char

        For Number As Integer = 0 To InputedNumbers.Length - 1
            IndividualNumber = Char.ToUpper(InputedNumbers.Chars(Number))
            If IndividualNumber >= "0" And IndividualNumber <= "9" Then
                NumberIndex = AscW(IndividualNumber)
                NumberCounts(NumberIndex) += 1
            End If
        Next Number

    End Sub

    Sub DisplayNumberCounts(ByRef NumberCounts() As Integer, ByRef lstList As ListBox)
        For Number As Integer = AscW("0") To AscW("9")
            lstList.Items.Add(ChrW(Number) & vbTab & NumberCounts(Number))
        Next Number
    End Sub

    Private Sub txtEnterNumber_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEnterNumber.TextChanged
        Me.lstNumbers.Items.Clear()
    End Sub
End Class