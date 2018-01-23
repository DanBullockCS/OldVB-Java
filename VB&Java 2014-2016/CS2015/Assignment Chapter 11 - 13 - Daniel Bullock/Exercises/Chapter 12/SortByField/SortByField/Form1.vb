'Daniel Bullock
'Chapter 12 - Exercise 2
Public Class Form1

    Structure Person                        'Structure
        Dim FirstName As String
        Dim LastName As String
        Dim Age As Integer
    End Structure

    Dim NUM_OF_PEOPLE As Integer
    Dim People(100) As Person

    Private Sub EnterInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnterInformationToolStripMenuItem.Click
        
        NUM_OF_PEOPLE = InputBox("Enter the number of people you would like to sort")
        For index As Integer = 0 To NUM_OF_PEOPLE - 1
            People(index).FirstName = InputBox("Enter the person's first name:")
            People(index).LastName = InputBox("Enter the person's last name:")
            People(index).Age = InputBox("Enter the person's age:")
        Next

        ReDim Preserve People(NUM_OF_PEOPLE)

        Me.lstSortedItems.Items.Add("First Name" & vbTab & "Last Name" & vbTab & "Age" & vbNewLine) 'Add Subtitles

        For index As Integer = 0 To NUM_OF_PEOPLE - 1
            Me.lstSortedItems.Items.Add(People(index).FirstName & vbTab & vbTab & People(index).LastName & vbTab & vbTab & People(index).Age & vbNewLine)
        Next
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub radFirstName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radFirstName.CheckedChanged
        Dim temp As String
        Dim swapRequired As Boolean = True          'flag

        Do While swapRequired
            swapRequired = False
            For testItem As Integer = 0 To People.Length - 2
                If People(testItem).FirstName > People(testItem + 1).FirstName Then
                    'Swap elements
                    temp = People(testItem).FirstName
                    People(testItem + 1).FirstName = temp
                    swapRequired = True
                End If
            Next testItem
        Loop

        lstSortedItems.Items.Clear()

        Me.lstSortedItems.Items.Add("First Name" & vbTab & "Last Name" & vbTab & "Age" & vbCrLf) 'Add Subtitles

        For index As Integer = 0 To People.Length - 2
            Me.lstSortedItems.Items.Add(People(index).FirstName & vbTab & vbTab & People(index).LastName & vbTab & vbTab & People(index).Age & vbNewLine)
        Next
    End Sub

    Private Sub radLastName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radLastName.CheckedChanged
        Dim temp As String
        Dim swapRequired As Boolean = True          'flag

        Do While swapRequired
            swapRequired = False
            For testItem As Integer = 0 To People.Length - 2
                If People(testItem).LastName > People(testItem + 1).LastName Then
                    'Swap elements
                    temp = People(testItem).LastName
                    People(testItem + 1).LastName = temp
                    swapRequired = True
                End If
            Next testItem
        Loop

        lstSortedItems.Items.Clear()

        Me.lstSortedItems.Items.Add("First Name" & vbTab & "Last Name" & vbTab & "Age" & vbNewLine) 'Add Subtitles

        For index As Integer = 0 To People.Length - 2
            Me.lstSortedItems.Items.Add(People(index).FirstName & vbTab & vbTab & People(index).LastName & vbTab & vbTab & People(index).Age & vbNewLine)
        Next
    End Sub

    Private Sub radAge_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAge.CheckedChanged
        Dim temp As Integer
        Dim swapRequired As Boolean = True          'flag

        Do While swapRequired
            swapRequired = False
            For testItem As Integer = 0 To People.Length - 2
                If People(testItem).Age > People(testItem + 1).Age Then
                    'Swap elements
                    temp = People(testItem).Age
                    People(testItem + 1).Age = temp
                    swapRequired = True
                End If
            Next testItem
        Loop
      
        lstSortedItems.Items.Clear()

        Me.lstSortedItems.Items.Add("First Name" & vbTab & "Last Name" & vbTab & "Age" & vbNewLine) 'Add Subtitles

        For index As Integer = 0 To People.Length - 2
            Me.lstSortedItems.Items.Add(People(index).FirstName & vbTab & vbTab & People(index).LastName & vbTab & vbTab & People(index).Age & vbNewLine)
        Next
    End Sub
End Class