Public Class Form1
    'Daniel Bullock
    'FindName

    Private Sub btnProcess_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProcess.Click
        Static dataArray(-1) As String      'array with zero elements
        Dim index As Integer
        Dim NameEntered As String = Me.txtNames.Text
        
        If Me.radAdd.Checked Then
            Call AddItem(dataArray, NameEntered)
            Call DisplayData(dataArray, Me.lstOutput)
        ElseIf Me.radRemove.Checked Then
            Call RemoveItem(dataArray, NameEntered)
            Call DisplayData(dataArray, Me.lstOutput)
        ElseIf Me.radFind.Checked Then
            index = FindItemIndex(dataArray, NameEntered)
            If index <> -1 Then
                Me.lstOutput.Items.Add("Name at index " & index)
            Else
                Me.lstOutput.Items.Add("Index not found")
            End If
        End If
    End Sub

    Sub AddItem(ByRef dataArray() As String, ByVal NameToAdd As String)

        ReDim Preserve dataArray(dataArray.Length)
        dataArray(dataArray.Length - 1) = NameToAdd
    End Sub

    Sub RemoveItem(ByRef dataArray() As String, ByVal NameToRemove As String)
        Dim itemIndex As Integer

        itemIndex = FindItemIndex(dataArray, NameToRemove)
        If itemIndex > -1 Then
            For index As Integer = itemIndex To dataArray.Length - 2
                dataArray(index) = dataArray(index + 1)
            Next index
            ReDim Preserve dataArray(dataArray.Length - 2)
        End If
    End Sub

    Function FindItemIndex(ByRef dataArray() As String, ByVal searchItem As String)
        If dataArray.Length = 0 Then
            Return -1
        End If

        Dim index As Integer = 0
        Do While (dataArray(index) <> searchItem) And (index < dataArray.Length - 1)
            index += 1
        Loop
        If dataArray(index) = searchItem Then
            Return index
        Else
            Return -1
        End If
    End Function

    Sub DisplayData(ByRef dataArray() As String, ByRef lstList As ListBox)
        lstList.Items.Clear()

        For index As Integer = 0 To dataArray.Length - 1
            lstList.Items.Add(index & vbTab & dataArray(index))
        Next index
    End Sub
End Class
