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
        Me.btnHappy = New System.Windows.Forms.Button()
        Me.btnSad = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnHappy
        '
        Me.btnHappy.Location = New System.Drawing.Point(29, 10)
        Me.btnHappy.Name = "btnHappy"
        Me.btnHappy.Size = New System.Drawing.Size(75, 23)
        Me.btnHappy.TabIndex = 0
        Me.btnHappy.Text = "Happy"
        Me.btnHappy.UseVisualStyleBackColor = True
        '
        'btnSad
        '
        Me.btnSad.Location = New System.Drawing.Point(206, 10)
        Me.btnSad.Name = "btnSad"
        Me.btnSad.Size = New System.Drawing.Size(75, 23)
        Me.btnSad.TabIndex = 1
        Me.btnSad.Text = "Sad"
        Me.btnSad.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 270)
        Me.Controls.Add(Me.btnSad)
        Me.Controls.Add(Me.btnHappy)
        Me.Name = "Form1"
        Me.Text = "Face"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnHappy As System.Windows.Forms.Button
    Friend WithEvents btnSad As System.Windows.Forms.Button

End Class
