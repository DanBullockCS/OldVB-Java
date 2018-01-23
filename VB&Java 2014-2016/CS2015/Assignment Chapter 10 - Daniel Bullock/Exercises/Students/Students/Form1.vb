'Daniel Bullock
'Students - Exercise 3 Chapter 10

Public Class Form1
    Private Sub ScoreButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnAverageScore.Click, btnEnterScore.Click, btnMaxScore.Click, _
        btnMinScore.Click, btnDisplayFullname.Click
        Static students(-1) As Student
        Dim ButtonClicked As Button = sender

        If Me.txtFirstName.Text = Nothing Or Me.txtLastName.Text = Nothing Then
            MessageBox.Show("Type a first and last name in the text boxes.")
        Else
            Dim position As Integer = -1
            'Check for the name in the array
            For index As Integer = 0 To students.Length - 1
                If students(index).FirstName = Me.txtFirstName.Text And _
                    students(index).LastName = Me.txtLastName.Text Then
                    position = index
                End If
            Next index

            If position = -1 Then 'name was not in the array, so add the student and increaseZ+ the array's size
                ReDim Preserve students(students.Length)
                position = students.Length - 1
                students(position) = New Student(Me.txtFirstName.Text, Me.txtLastName.Text)
            End If

            Select Case ButtonClicked.Tag
                Case "Enter Score"
                    lblMin.Text = Nothing
                    lblMax.Text = Nothing
                    lblAverage.Text = Nothing
                    Dim score As Integer
                    score = Val(InputBox("Enter a score", "Students"))
                    If (score <> Nothing) Then
                        students(position).NewScore(score)
                    End If
                Case "Average Score"
                    Me.lblAverage.Text = students(position).Avg
                Case "Minimum Score"
                    Me.lblMin.Text = students(position).Min
                Case "Maximum Score"
                    Me.lblMax.Text = students(position).Max
                Case "Display"
                    students(position).FirstName = Me.txtFirstName.Text
                    students(position).LastName = Me.txtLastName.Text
                    Me.lblFullName.Text = students(position).FullName
            End Select
        End If
    End Sub

    Private Sub txtFirstName_txtLastName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles _
    txtFirstName.TextChanged, txtLastName.TextChanged
        lblMax.Text = Nothing
        lblMin.Text = Nothing
        lblFullName.Text = Nothing
        lblAverage.Text = Nothing
    End Sub
End Class
