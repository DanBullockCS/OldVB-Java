Public Class Form1
    'Daniel Bullock
    'Even And Odd Numbers

    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        Dim NumberArray(9) As Integer 'Array has 10 elements
        'Call procedures
        Call FillArray(NumberArray, Me.lstNumbers)
        Call DisplayArray(NumberArray, Me.lstNumbers)
        Call EvenNumbers(NumberArray, Me.lstNumbers)
        Call OddNumbers(NumberArray, Me.lstNumbers)
    End Sub

    Sub FillArray(ByRef Array() As Integer, ByRef lstList As ListBox) 'Create array and random numbers
        For index As Integer = 0 To Array.Length - 1
            Randomize()
            Array(index) = Int(99 * Rnd() + 1)
        Next index
    End Sub

    Sub DisplayArray(ByRef Array() As Integer, ByRef lstList As ListBox) 'Display Array
        lstList.Items.Clear()
        For index As Integer = 0 To Array.Length - 1
            lstList.Items.Add(index & vbTab & Array(index))
        Next index
    End Sub

    Sub EvenNumbers(ByRef Array() As Integer, ByRef lstList As ListBox)
        lstList.Items.Add("Even numbers in the array:")                 'Add title
        For index As Integer = 0 To Array.Length - 1
            If Array(index) Mod 2 = 0 Then                              'Mod to find even numbers
                lstList.Items.Add(index & vbTab & Array(index))         'add to listbox
            End If
        Next index
    End Sub

    Sub OddNumbers(ByRef Array() As Integer, ByRef lstList As ListBox)
        lstList.Items.Add("Odd numbers in the array:")                 'Add title
        For index As Integer = 0 To Array.Length - 1
            If Array(index) Mod 2 <> 0 Then                             'Mod to find odd numbers
                lstList.Items.Add(index & vbTab & Array(index))         'add to listbox
            End If
        Next index
    End Sub
End Class
