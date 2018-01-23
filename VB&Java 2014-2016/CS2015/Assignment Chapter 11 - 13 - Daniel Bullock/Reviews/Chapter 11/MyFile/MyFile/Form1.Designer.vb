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
        Me.btnCreateFile = New System.Windows.Forms.Button()
        Me.btnDeleteFile = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCreateFile
        '
        Me.btnCreateFile.Location = New System.Drawing.Point(46, 12)
        Me.btnCreateFile.Name = "btnCreateFile"
        Me.btnCreateFile.Size = New System.Drawing.Size(75, 23)
        Me.btnCreateFile.TabIndex = 0
        Me.btnCreateFile.Text = "Create File"
        Me.btnCreateFile.UseVisualStyleBackColor = True
        '
        'btnDeleteFile
        '
        Me.btnDeleteFile.Location = New System.Drawing.Point(46, 41)
        Me.btnDeleteFile.Name = "btnDeleteFile"
        Me.btnDeleteFile.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteFile.TabIndex = 1
        Me.btnDeleteFile.Text = "Delete File"
        Me.btnDeleteFile.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(167, 71)
        Me.Controls.Add(Me.btnDeleteFile)
        Me.Controls.Add(Me.btnCreateFile)
        Me.Name = "Form1"
        Me.Text = "My File"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCreateFile As System.Windows.Forms.Button
    Friend WithEvents btnDeleteFile As System.Windows.Forms.Button

End Class
