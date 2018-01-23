Public Class Form1
    'Daniel Bullock
    'Dynamic Numbers
    Dim LowestNumber As Integer
    Dim ArrayT(-1) As Integer

    Private Sub btnCreateArray_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateArray.Click
        Dim SizeOfArray As Integer = Me.txtEnterSize.Text
        Dim ArrayA(SizeOfArray) As Integer

        Call AddItem(ArrayA, SizeOfArray)
        Call DisplayData(ArrayA, Me.lstArray)
        Call Sort(ArrayA, Me.lstArray)
    End Sub

    Sub AddItem(ByRef ArrayA() As Integer, ByVal SizeOfArray As Integer)
        For index As Integer = 0 To ArrayA.Length - 1
            Randomize()
            ArrayA(index) = Int(99 * Rnd() + 1)
        Next index

        For index As Integer = 0 To ArrayA.Length - 1
            Me.lstArray.Items.Add(ArrayA(index))
        Next index

        ReDim Preserve ArrayA(SizeOfArray)
    End Sub

    Sub DisplayData(ByRef ArrayA() As Integer, ByRef lstList As ListBox)
        lstList.Items.Clear()

        For index As Integer = 0 To ArrayA.Length - 2
            lstList.Items.Add(index & vbTab & ArrayA(index))
        Next index
    End Sub

    Sub Sort(ByVal ArrayA() As Integer, ByRef lstList As ListBox)
        lstList.Items.Add("Sorted from lowest to highest")

        For index As Integer = 0 To ArrayA.Length - 2
            lstList.Items.Add(index & vbTab & ArrayA(LowestNumber))
        Next index
    End Sub

    Function FindLowest(ByRef ArrayA() As Integer, ByRef SizeOfArray As Integer)

        For index = 0 To ArrayA.Length - 1
            If ArrayA(index) > LowestNumber Then
                LowestNumber = ArrayA(index)
                Return LowestNumber
            End If
        Next

    End Function

    Private Sub txtEnterSize_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEnterSize.TextChanged
        Me.lstArray.Items.Clear()
    End Sub
End Class