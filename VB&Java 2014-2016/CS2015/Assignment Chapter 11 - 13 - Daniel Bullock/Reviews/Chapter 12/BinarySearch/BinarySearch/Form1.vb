'BinarySearch
'Chapter 12
'Lawrenceville Press
'February 16, 2006

Public Class Form1

    Private Sub btnButtonClicked_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles btnGenerate.Click, btnSearch.Click
        Static itemArray(-1) As Integer
        Dim btnButtonClicked As Button = sender
        Dim numToFind, numFoundIndex As Integer

        Select Case btnButtonClicked.Tag
            Case "Generate"
                'Create array of integers
                Call GenerateSortedArray(itemArray)
                'Display generated array
                Me.lstArrayElements.Items.Clear()     'clear any existing data
                Call DisplayData(itemArray, Me.lstArrayElements, "Sorted array:")
            Case "Search"
                'Get search number from user
                numToFind = Val(Me.txtNumber.Text)
                'Find number
                numFoundIndex = BinarySearch(itemArray, numToFind)
                If numFoundIndex = -1 Then
                    Me.lblResults.Text = "Number not found."
                Else
                    Me.lblResults.Text = "Number found at index " & numFoundIndex
                End If
        End Select
    End Sub

    'Resizes the dynamic intArray to NUM_ELEMENTS elements, assigns a random 
    'integer between 1 and MAX_NUMBER to each element, and then sorts the array.
    '
    'post: intArray has been assigned NUM_ELEMENTS elements of random integers 
    'between 0 and MAX_NUMBER and then sorted from low to high.
    '
    Sub GenerateSortedArray(ByRef intArray() As Integer)
        Const NUM_ELEMENTS As Integer = 50
        Const MAX_NUMBER As Integer = 100
        ReDim intArray(NUM_ELEMENTS - 1)

        'Assign each array element a random value
        Randomize()
        For index As Integer = 0 To intArray.Length - 1
            intArray(index) = Int(MAX_NUMBER * Rnd() + 1)
        Next index

        'Sort array
        InsertionSort(intArray)

        Me.lblIndexesChecked.Text = Nothing 'Clear label
    End Sub

    'Returns the index of numToFind or -1 if numToFind is not in array.
    '
    'post: A -1 or the index of numToFind has been returned.
    '
    Function BinarySearch(ByRef intArray() As Integer, ByVal numToFind As Integer) As Integer
        Dim highIndex As Integer = intArray.Length - 1
        Dim midIndex As Integer
        Dim lowIndex = 0
        Dim found As Boolean = False

        Do While (Not found) And (lowIndex <= highIndex)
            midIndex = (highIndex + lowIndex) \ 2
            If intArray(midIndex) = numToFind Then
                found = True
            ElseIf intArray(midIndex) > numToFind Then
                highIndex = midIndex - 1
            Else
                lowIndex = midIndex + 1
            End If
        Loop
        If found Then
            Me.lblIndexesChecked.Text = "Indexes checked: " & highIndex & " " & midIndex & " " & lowIndex
            Return midIndex
        Else
            Return -1
        End If
    End Function

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
    Sub InsertionSort(ByRef intArray() As Integer)
        Dim previousItemIndex As Integer
        Dim temp As Integer

        For itemIndex As Integer = 1 To intArray.Length - 1
            temp = intArray(itemIndex)
            previousItemIndex = itemIndex - 1
            Do While intArray(previousItemIndex) > temp And previousItemIndex > 0
                'Shift item up into next element position
                intArray(previousItemIndex + 1) = intArray(previousItemIndex)
                'Decrease index to compare current item to next previous item
                previousItemIndex -= 1
            Loop

            'Element at index 0 is greater than current item
            If intArray(previousItemIndex) > temp Then
                'Shift item in first element up into next element position
                intArray(previousItemIndex + 1) = intArray(previousItemIndex)
                'Place current item at index 0 (first element)
                intArray(previousItemIndex) = temp
            Else    'element at previous index is less than current item
                'Place current item at index ahead of previous item
                intArray(previousItemIndex + 1) = temp
            End If
        Next itemIndex
    End Sub

    Private Sub NewFind(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumber.TextChanged
        Me.lblResults.Text = Nothing
        Me.lblIndexesChecked.Text = Nothing
    End Sub
End Class
