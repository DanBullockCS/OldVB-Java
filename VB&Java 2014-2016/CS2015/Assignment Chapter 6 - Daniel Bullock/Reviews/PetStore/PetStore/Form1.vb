Public Class Form1

    Private Sub btnGetInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetInfo.Click
        Dim PetName As String

        PetName = Me.txtPetName.Text

        'Show pet info
        Select Case PetName.ToUpper
            Case "CAT"
                Call CATInfo()
            Case "DOG"
                Call DOGInfo()
            Case "FISH"
                Call FISHInfo()
            Case Else
                MessageBox.Show("Sorry, no infomation available.")
        End Select
    End Sub

    Sub CATInfo()
        Me.picPetPhoto.Image = My.Resources.cat
        Me.lblPetInfo.Text = "This kitten is 4 months old and loves playing with children."
    End Sub

    Sub DOGInfo()
        Me.picPetPhoto.Image = My.Resources.dog
        Me.lblPetInfo.Text = "This puppy is just 3 months old and needs a good home."
    End Sub

    Sub FISHInfo()
        Me.picPetPhoto.Image = My.Resources.fish
        Me.lblPetInfo.Text = "We have a variety of goldfish."
    End Sub
End Class
