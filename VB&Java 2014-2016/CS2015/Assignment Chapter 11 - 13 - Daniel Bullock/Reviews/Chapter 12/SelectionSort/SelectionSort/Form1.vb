'SelectionSort
'Chapter 12
'Lawrenceville Press
'February 16, 2006

Public Class Form1

    Private Sub btnSort_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSort.Click
        Dim itemArray(-1) As Integer
        Dim numItems As Integer

        'User chooses the number of elements for array
        numItems = Val(Me.txtNumElements.Text)
        If numItems > 0 Then
            'Create array of integers
            Call GenerateArray(numItems, itemArray)

            'Display generated array
            Me.lstArrayElements.Items.Clear()     'clear any existing data
            Call DisplayData(itemArray, Me.lstArrayElements, "Original array:")

            'Sort array
            Call SelectionSort(itemArray)

            'Display sorted array
            Call DisplayData(itemArray, Me.lstArrayElements, "Sorted array:")
        Else
            MessageBox.Show("Number of elements must be greater than 0.")
            Me.txtNumElements.Text = Nothing      'clear text box
        End If
    End Sub

    'Resizes the dynamic intArray to numElements elements and then assigns to 
    'each element a random integer between 1 and MAX_NUMBER.
    '
    'pre: numElements > 0
    'post: intArray has been assigned numElements elements of random integers 
    'between 0 and MAX_NUMBER
    '
    Sub GenerateArray(ByVal numElements As Integer, ByRef intArray() As Integer)
        Const MAX_NUMBER As Integer = 100
        ReDim intArray(numElements - 1)

        'Assign each array element a random value
        Randomize()
        For index As Integer = 0 To intArray.Length - 1
            intArray(index) = Int(MAX_NUMBER * Rnd() + 1)
        Next index

        Dim startTime As New DateTime()
        Dim endTime As New DateTime()

        startTime = DateTime.Now    'start timing
        Call SelectionSort(intArray)
        endTime = DateTime.Now      'end Timing

        MessageBox.Show("The elements were sorted in " & endTime.Millisecond - startTime.Millisecond & " Milliseconds.")
    End Sub

    'Displays the contents of intArray in a list box
    '
    'post: intArray items have been displayed in a list box.
    '
    Sub DisplayData(ByRef intArray() As Integer, ByRef lstListBox As ListBox, ByVal title As String)
        lstListBox.Items.Add(title)
        For index As Integer = 0 To intArray.Length - 1
            lstListBox.Items.Add(index & vbTab & intArray(index))
        Next index
    End Sub

    'Sorts intArray from low to high
    '
    'post: intArray elements have been sorted low to high
    '
    Sub SelectionSort(ByRef intArray() As Integer)
        Dim temp As Integer

        For itemIndex As Integer = 0 To intArray.Length - 1
            For lowItemIndex As Integer = itemIndex To intArray.Length - 1
                If intArray(lowItemIndex) < intArray(itemIndex) Then
                    'Swap Elements
                    temp = intArray(itemIndex)
                    intArray(itemIndex) = intArray(lowItemIndex)
                    intArray(lowItemIndex) = temp
                End If
            Next lowItemIndex
        Next itemIndex
    End Sub
End Class
