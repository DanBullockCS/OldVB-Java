<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnterInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstSortedItems = New System.Windows.Forms.ListBox()
        Me.grpField = New System.Windows.Forms.GroupBox()
        Me.radAge = New System.Windows.Forms.RadioButton()
        Me.radLastName = New System.Windows.Forms.RadioButton()
        Me.radFirstName = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1.SuspendLayout()
        Me.grpField.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(324, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnterInformationToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'EnterInformationToolStripMenuItem
        '
        Me.EnterInformationToolStripMenuItem.Name = "EnterInformationToolStripMenuItem"
        Me.EnterInformationToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.EnterInformationToolStripMenuItem.Text = "Enter Information"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'lstSortedItems
        '
        Me.lstSortedItems.FormattingEnabled = True
        Me.lstSortedItems.Location = New System.Drawing.Point(0, 27)
        Me.lstSortedItems.Name = "lstSortedItems"
        Me.lstSortedItems.Size = New System.Drawing.Size(324, 160)
        Me.lstSortedItems.TabIndex = 1
        '
        'grpField
        '
        Me.grpField.Controls.Add(Me.radAge)
        Me.grpField.Controls.Add(Me.radLastName)
        Me.grpField.Controls.Add(Me.radFirstName)
        Me.grpField.Location = New System.Drawing.Point(12, 203)
        Me.grpField.Name = "grpField"
        Me.grpField.Size = New System.Drawing.Size(300, 56)
        Me.grpField.TabIndex = 2
        Me.grpField.TabStop = False
        Me.grpField.Text = "Sort Field"
        '
        'radAge
        '
        Me.radAge.AutoSize = True
        Me.radAge.Location = New System.Drawing.Point(237, 19)
        Me.radAge.Name = "radAge"
        Me.radAge.Size = New System.Drawing.Size(44, 17)
        Me.radAge.TabIndex = 2
        Me.radAge.Text = "Age"
        Me.radAge.UseVisualStyleBackColor = True
        '
        'radLastName
        '
        Me.radLastName.AutoSize = True
        Me.radLastName.Location = New System.Drawing.Point(119, 19)
        Me.radLastName.Name = "radLastName"
        Me.radLastName.Size = New System.Drawing.Size(76, 17)
        Me.radLastName.TabIndex = 1
        Me.radLastName.Text = "Last Name"
        Me.radLastName.UseVisualStyleBackColor = True
        '
        'radFirstName
        '
        Me.radFirstName.AutoSize = True
        Me.radFirstName.Location = New System.Drawing.Point(16, 19)
        Me.radFirstName.Name = "radFirstName"
        Me.radFirstName.Size = New System.Drawing.Size(75, 17)
        Me.radFirstName.TabIndex = 0
        Me.radFirstName.Text = "First Name"
        Me.radFirstName.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 281)
        Me.Controls.Add(Me.grpField)
        Me.Controls.Add(Me.lstSortedItems)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Sort By Field"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpField.ResumeLayout(False)
        Me.grpField.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnterInformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lstSortedItems As System.Windows.Forms.ListBox
    Friend WithEvents grpField As System.Windows.Forms.GroupBox
    Friend WithEvents radAge As System.Windows.Forms.RadioButton
    Friend WithEvents radLastName As System.Windows.Forms.RadioButton
    Friend WithEvents radFirstName As System.Windows.Forms.RadioButton

End Class
