Public Class Form1
    'Daniel Bullock
    'Dynamic Array Demo

    Private Sub btnProcess_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProcess.Click
        Static dataArray(-1) As Integer      'array with zero elements
        Dim index As Integer
        Dim numEntered As Integer = Val(Me.txtValue.Text)

        If Me.radAdd.Checked Then
            Call AddItem(dataArray, numEntered)
            Call DisplayData(dataArray, Me.lstOutput)
        ElseIf Me.radRemove.Checked Then
            Call RemoveItem(dataArray, numEntered)
            Call DisplayData(dataArray, Me.lstOutput)
        ElseIf Me.radFind.Checked Then
            index = FindItemIndex(dataArray, numEntered)
            If index <> -1 Then
                Me.lstOutput.Items.Add("Item at index " & index)     'ADDED IF STATEMENT WITHIN IF STATEMENT ADDING THE-
            Else                                                        'ITEM NOT FOUND STATEMENT.
                Me.lstOutput.Items.Add("Item not found")
            End If
        End If
    End Sub

    'Adds new element numToAdd as the last element of dataArray().
    '
    'pre: dataArray() contains zero or more elements.
    'post: dataArray() has a new element numToAdd as the 
    'last element of the array.
    '
    Sub AddItem(ByRef dataArray() As Integer, ByVal numToAdd As Integer)
        'Use Length to size array because that value is one greater than the
        'current highest index value
        ReDim Preserve dataArray(dataArray.Length)
        dataArray(dataArray.Length - 1) = numToAdd
    End Sub

    'Removes the first occurrence of numToRemove from dataArray
    'and sizes the array with one less element.
    '
    'post: If numToRemove found, dataArray now has one less element 
    'and numToRemove has been deleted from array.
    '
    Sub RemoveItem(ByRef dataArray() As Integer, ByVal numToRemove As Integer)
        Dim itemIndex As Integer

        itemIndex = FindItemIndex(dataArray, numToRemove)
        'move remaining elements up one position in array
        If itemIndex > -1 Then
            For index As Integer = itemIndex To dataArray.Length - 2
                dataArray(index) = dataArray(index + 1)
            Next index
            ReDim Preserve dataArray(dataArray.Length - 2)
        End If
    End Sub

    'Returns the index of the first occurrence of searchItem in
    'dataArray or -1 if searchItem not found.
    '
    'post: Index of the first occurrence of searchItem has been 
    'returned, or -1 has been returned if searchItem not found.
    '
    Function FindItemIndex(ByRef dataArray() As Integer, ByVal searchItem As Integer) As Integer
        'Empty array
        If dataArray.Length = 0 Then
            Return -1               'item not found
        End If

        'Find search item
        Dim index As Integer = 0
        Do While (dataArray(index) <> searchItem) And (index < dataArray.Length - 1)
            index += 1
        Loop
        If dataArray(index) = searchItem Then
            Return index            'item found
        Else
            Return -1               'item not found
        End If
    End Function

    'Clears a list box and then displays dataArray elements 
    'in the list box.
    '
    'pre: dataArray.Length > 0
    'post: List box has been cleared of any previous items. dataArray
    'elements are now displayed in the list box.
    '
    Sub DisplayData(ByRef dataArray() As Integer, ByRef lstList As ListBox)
        lstList.Items.Clear()

        For index As Integer = 0 To dataArray.Length - 1
            lstList.Items.Add(index & vbTab & dataArray(index))
        Next index
    End Sub
End Class
