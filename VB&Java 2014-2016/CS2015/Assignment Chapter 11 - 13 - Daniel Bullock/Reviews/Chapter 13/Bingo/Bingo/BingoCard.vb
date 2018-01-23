'Bingo
'Chapter 13 case study
'Lawrenceville Press
'February 16, 2006

Public Class BingoCard

    Private Sub Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBSlot1.Click, btnBSlot2.Click, _
    btnBSlot3.Click, btnBSlot4.Click, btnBSlot5.Click, btnGSlot1.Click, btnGSlot2.Click, btnGSlot3.Click, btnGSlot4.Click, btnBSlot5.Click, _
    btnISlot1.Click, btnISlot2.Click, btnISlot3.Click, btnISlot4.Click, btnISlot5.Click, btnNSlot1.Click, btnNSlot2.Click, _
    btnNSlot3.Click, btnNSlot4.Click, btnNSlot5.Click, btnOSlot1.Click, btnOSlot2.Click, btnOSlot3.Click, btnNSlot4.Click, btnOSlot5.Click, btnGSlot5.Click, _
    btnOSlot4.Click
        Dim btnButtonClicked As Button = sender
        btnButtonClicked.BackColor = Color.Green
    End Sub
End Class