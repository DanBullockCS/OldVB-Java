<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.lstArrayElements = New System.Windows.Forms.ListBox()
        Me.lblNumberPrompt = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.lblIndexesChecked = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(9, 10)
        Me.btnGenerate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(110, 37)
        Me.btnGenerate.TabIndex = 2
        Me.btnGenerate.Tag = "Generate"
        Me.btnGenerate.Text = "Generate and Display Sorted Array"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'lstArrayElements
        '
        Me.lstArrayElements.FormattingEnabled = True
        Me.lstArrayElements.Location = New System.Drawing.Point(9, 54)
        Me.lstArrayElements.Margin = New System.Windows.Forms.Padding(2)
        Me.lstArrayElements.Name = "lstArrayElements"
        Me.lstArrayElements.Size = New System.Drawing.Size(110, 160)
        Me.lstArrayElements.TabIndex = 3
        '
        'lblNumberPrompt
        '
        Me.lblNumberPrompt.AutoSize = True
        Me.lblNumberPrompt.Location = New System.Drawing.Point(142, 54)
        Me.lblNumberPrompt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNumberPrompt.Name = "lblNumberPrompt"
        Me.lblNumberPrompt.Size = New System.Drawing.Size(105, 13)
        Me.lblNumberPrompt.TabIndex = 4
        Me.lblNumberPrompt.Text = "Enter number to find:"
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(252, 52)
        Me.txtNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(38, 20)
        Me.txtNumber.TabIndex = 5
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(191, 98)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(56, 19)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Tag = "Search"
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Location = New System.Drawing.Point(142, 160)
        Me.lblResults.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(0, 13)
        Me.lblResults.TabIndex = 7
        '
        'lblIndexesChecked
        '
        Me.lblIndexesChecked.AutoSize = True
        Me.lblIndexesChecked.Location = New System.Drawing.Point(124, 200)
        Me.lblIndexesChecked.Name = "lblIndexesChecked"
        Me.lblIndexesChecked.Size = New System.Drawing.Size(0, 13)
        Me.lblIndexesChecked.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 222)
        Me.Controls.Add(Me.lblIndexesChecked)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.lblNumberPrompt)
        Me.Controls.Add(Me.lstArrayElements)
        Me.Controls.Add(Me.btnGenerate)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Binary Search"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents lstArrayElements As System.Windows.Forms.ListBox
    Friend WithEvents lblNumberPrompt As System.Windows.Forms.Label
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents lblResults As System.Windows.Forms.Label
    Friend WithEvents lblIndexesChecked As System.Windows.Forms.Label

End Class
