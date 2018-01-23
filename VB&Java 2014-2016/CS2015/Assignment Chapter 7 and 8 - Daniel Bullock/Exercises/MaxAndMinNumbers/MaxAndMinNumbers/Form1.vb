Public Class Form1
    'Daniel Bullock
    'Max And Min Numbers

    Dim Numbers(9) As Integer   'Array of 10 elements

    Private Sub btnNumbers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNumbers.Click
        lstNumbers.Items.Clear()
        For index As Integer = 0 To Numbers.Length - 1
            Randomize()                             'Randomize numbers
            Numbers(index) = Int(99 * Rnd() + 1)
        Next index

        For index As Integer = 0 To Numbers.Length - 1
            Me.lstNumbers.Items.Add(Numbers(index))     'Add them to list
        Next index
    End Sub

    Private Sub btnMax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMax.Click
        Dim Max As Integer
        Max = Numbers(0)
        'Find maximum number
        For index As Integer = 0 To Numbers.Length - 1
            If Numbers(index) > Max Then
                Max = Numbers(index)
            End If
        Next index

        Me.lblMaxOrMinNum.Text = "Max Number = " & Max 'Display maximum number into label
    End Sub

    Private Sub btnMin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMin.Click
        Dim Min As Integer
        Min = Numbers(0)
        'Find minimum number
        For index As Integer = 0 To Numbers.Length - 1
            If Numbers(index) < Min Then
                Min = Numbers(index)
            End If
        Next index

        Me.lblMaxOrMinNum.Text = "Min Number = " & Min 'Display minimum number into label
    End Sub
End Class
