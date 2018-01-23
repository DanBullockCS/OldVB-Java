Imports System.IO
Public Class Form1
    'Daniel Bullock

    Private Sub NewToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Static docNum As Integer = 0                            'document number
        Dim doc As New NewDocument()                            'create new document window

        'Assign document parent
        doc.MdiParent = Me
        'Create title bar that includes document number
        docNum += 1
        doc.Text = "New Document " & docNum
        'Show window
        doc.Show()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.ActiveMdiChild.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
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

    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        Dim activeDoc As NewDocument = Me.ActiveMdiChild
        activeDoc.txtDocument.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        Dim activeDoc As NewDocument = Me.ActiveMdiChild
        activeDoc.txtDocument.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        Dim activeDoc As NewDocument = Me.ActiveMdiChild
        activeDoc.txtDocument.Paste()
    End Sub

    Private Sub AlignmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlignmentToolStripMenuItem.Click
        Dim alignmentDB As New AlignmentDialogBox()
        Dim activeDoc As NewDocument = Me.ActiveMdiChild

        'show dialog box
        alignmentDB.ShowDialog()

        'Change alignment of text in active document
        If alignmentDB.DialogResult = Windows.Forms.DialogResult.OK Then
            If alignmentDB.radLeft.Checked Then
                activeDoc.txtDocument.TextAlign = HorizontalAlignment.Left
            ElseIf alignmentDB.radCenter.Checked Then
                activeDoc.txtDocument.TextAlign = HorizontalAlignment.Center
            Else
                activeDoc.txtDocument.TextAlign = HorizontalAlignment.Right
            End If
        End If
    End Sub

    Private Sub AboutTextEditorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutTextEditorToolStripMenuItem.Click
        Dim aboutDB As New AboutDialogBox()

        'Show dialog box
        aboutDB.ShowDialog()
    End Sub

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        Static docNum As Integer = 0                            'document number
        Dim doc As New NewDocument()                            'create new document window

        'Assign document parent
        doc.MdiParent = Me
        'Create title bar that includes document number
        docNum += 1
        doc.Text = "New Document " & docNum
        'Show window
        doc.Show()
    End Sub

    Private Sub OpenToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripButton.Click
        Dim activeDoc As NewDocument = Me.ActiveMdiChild
        Me.OpenFileDialog1.ShowDialog()         'open dialog box

        'Assign selected file name
        Dim fileName As String = Me.OpenFileDialog1.FileName

        If fileName <> Nothing Then
            Dim fs As New FileStream(fileName, FileMode.Open, FileAccess.Read)
            Dim textFile As New StreamReader(fs)
            Dim lineOfText As String

            'Clear text box of previous contents
            activeDoc.txtDocument.Text = Nothing

            Do While textFile.Peek > -1                 'check for the end of file
                lineOfText = textFile.ReadLine()
                'Display line of text
                activeDoc.txtDocument.Text &= lineOfText & vbCrLf
            Loop

            textFile.Close()
            fs.Close()
        End If
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        Dim activeDoc As NewDocument = Me.ActiveMdiChild

        Me.SaveFileDialog1.ShowDialog()                         'display Save as dialog box
        Dim fileName As String = Me.SaveFileDialog1.FileName    'get file name
        Dim fs As New FileStream(fileName, FileMode.Create, FileAccess.Write)
        Dim textFile As New StreamWriter(fs)

        textFile.Write(activeDoc.txtDocument.Text)             'write text box contents to file

        textFile.Close()
        fs.Close()
    End Sub

    Private Sub PrintToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripButton.Click
        PrintForm1.Print()
    End Sub

    Private Sub CutToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripButton.Click
        Dim activeDoc As NewDocument = Me.ActiveMdiChild
        activeDoc.txtDocument.Cut()
    End Sub

    Private Sub CopyToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripButton.Click
        Dim activeDoc As NewDocument = Me.ActiveMdiChild
        activeDoc.txtDocument.Copy()
    End Sub

    Private Sub PasteToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripButton.Click
        Dim activeDoc As NewDocument = Me.ActiveMdiChild
        activeDoc.txtDocument.Paste()
    End Sub

    Private Sub HelpToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripButton.Click
        AboutDialogBox.Show()
    End Sub
End Class
