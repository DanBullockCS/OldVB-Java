<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlayAgain
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
        Me.btnDeleteMoreViruses = New System.Windows.Forms.Button()
        Me.btnNope = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDeleteMoreViruses
        '
        Me.btnDeleteMoreViruses.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnDeleteMoreViruses.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnDeleteMoreViruses.ForeColor = System.Drawing.Color.Lime
        Me.btnDeleteMoreViruses.Location = New System.Drawing.Point(32, 18)
        Me.btnDeleteMoreViruses.Name = "btnDeleteMoreViruses"
        Me.btnDeleteMoreViruses.Size = New System.Drawing.Size(222, 42)
        Me.btnDeleteMoreViruses.TabIndex = 0
        Me.btnDeleteMoreViruses.Text = "Delete more viruses"
        Me.btnDeleteMoreViruses.UseVisualStyleBackColor = False
        '
        'btnNope
        '
        Me.btnNope.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnNope.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnNope.ForeColor = System.Drawing.Color.Red
        Me.btnNope.Location = New System.Drawing.Point(32, 66)
        Me.btnNope.Name = "btnNope"
        Me.btnNope.Size = New System.Drawing.Size(222, 42)
        Me.btnNope.TabIndex = 1
        Me.btnNope.Text = "Nope."
        Me.btnNope.UseVisualStyleBackColor = False
        '
        'PlayAgain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(290, 135)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnNope)
        Me.Controls.Add(Me.btnDeleteMoreViruses)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PlayAgain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Play Again?"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDeleteMoreViruses As System.Windows.Forms.Button
    Friend WithEvents btnNope As System.Windows.Forms.Button
End Class
