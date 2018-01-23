<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Scores
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
        Me.lstScores = New System.Windows.Forms.ListBox()
        Me.btnDeleteMoreViruses = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstScores
        '
        Me.lstScores.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lstScores.Dock = System.Windows.Forms.DockStyle.Top
        Me.lstScores.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lstScores.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lstScores.FormattingEnabled = True
        Me.lstScores.ItemHeight = 24
        Me.lstScores.Location = New System.Drawing.Point(0, 0)
        Me.lstScores.Name = "lstScores"
        Me.lstScores.Size = New System.Drawing.Size(484, 388)
        Me.lstScores.TabIndex = 0
        '
        'btnDeleteMoreViruses
        '
        Me.btnDeleteMoreViruses.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnDeleteMoreViruses.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btnDeleteMoreViruses.ForeColor = System.Drawing.Color.Lime
        Me.btnDeleteMoreViruses.Location = New System.Drawing.Point(184, 416)
        Me.btnDeleteMoreViruses.Name = "btnDeleteMoreViruses"
        Me.btnDeleteMoreViruses.Size = New System.Drawing.Size(102, 42)
        Me.btnDeleteMoreViruses.TabIndex = 1
        Me.btnDeleteMoreViruses.Text = "Ok"
        Me.btnDeleteMoreViruses.UseVisualStyleBackColor = False
        '
        'Scores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(484, 462)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnDeleteMoreViruses)
        Me.Controls.Add(Me.lstScores)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Scores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Scores"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstScores As System.Windows.Forms.ListBox
    Friend WithEvents btnDeleteMoreViruses As System.Windows.Forms.Button
End Class
