'Daniel Bullock
'Exercise 5 - Chapter 13

Public Class Form1

    Private Sub CalculatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculatorToolStripMenuItem.Click
        Static docNum As Integer = 0    'document number
        Dim doc As New Calculator()     'create a new document window

        'Assign document parent
        doc.MdiParent = Me
        'Create title bar that includes document number
        docNum += 1
        doc.Text = "Calculator " & docNum
        'Show window
        doc.Show()
    End Sub

    Private Sub TriangleCalculatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TriangleCalculatorToolStripMenuItem.Click
        Static docNum As Integer = 0    'document number
        Dim doc As New TriangleCalculator()     'create a new document window

        'Assign document parent
        doc.MdiParent = Me
        'Create title bar that includes document number
        docNum += 1
        doc.Text = "Triangle Calculator " & docNum
        'Show window
        doc.Show()
    End Sub

    Private Sub TextEditorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextEditorToolStripMenuItem.Click
        Static docNum As Integer = 0    'document number
        Dim doc As New TextEditor()     'create a new document window

        'Assign document parent
        doc.MdiParent = Me
        'Create title bar that includes document number
        docNum += 1
        doc.Text = "Text Editor " & docNum
        'Show window
        doc.Show()
    End Sub

    Private Sub ClickItToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClickItToolStripMenuItem.Click
        Static docNum As Integer = 0    'document number
        Dim doc As New ClickIt()     'create a new document window

        'Assign document parent
        doc.MdiParent = Me
        'Create title bar that includes document number
        docNum += 1
        doc.Text = "Click It! " & docNum
        'Show window
        doc.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
    Private Sub CutToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripButton.Click
        Dim activeDoc As TextEditor = Me.ActiveMdiChild
        activeDoc.txtFileContents.Cut()
    End Sub

    Private Sub CopyToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripButton.Click
        Dim activeDoc As TextEditor = Me.ActiveMdiChild
        activeDoc.txtFileContents.Copy()
    End Sub

    Private Sub PasteToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripButton.Click
        Dim activeDoc As TextEditor = Me.ActiveMdiChild
        activeDoc.txtFileContents.Paste()
    End Sub

    Private Sub HelpToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripButton.Click
        AboutDialogBox.Show()
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub
End Class
