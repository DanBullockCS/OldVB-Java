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
        Me.btnAddNames = New System.Windows.Forms.Button()
        Me.lstStuNames = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnAddNames
        '
        Me.btnAddNames.Location = New System.Drawing.Point(192, 26)
        Me.btnAddNames.Name = "btnAddNames"
        Me.btnAddNames.Size = New System.Drawing.Size(75, 23)
        Me.btnAddNames.TabIndex = 0
        Me.btnAddNames.Text = "Add Names"
        Me.btnAddNames.UseVisualStyleBackColor = True
        '
        'lstStuNames
        '
        Me.lstStuNames.FormattingEnabled = True
        Me.lstStuNames.Location = New System.Drawing.Point(12, 26)
        Me.lstStuNames.Name = "lstStuNames"
        Me.lstStuNames.Size = New System.Drawing.Size(163, 121)
        Me.lstStuNames.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 168)
        Me.Controls.Add(Me.lstStuNames)
        Me.Controls.Add(Me.btnAddNames)
        Me.Name = "Form1"
        Me.Text = "Student Names"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAddNames As System.Windows.Forms.Button
    Friend WithEvents lstStuNames As System.Windows.Forms.ListBox

End Class
