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
        Me.btnCategory = New System.Windows.Forms.Button()
        Me.lblEnterWind = New System.Windows.Forms.Label()
        Me.txtboxMPH = New System.Windows.Forms.TextBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCategory
        '
        Me.btnCategory.Location = New System.Drawing.Point(152, 65)
        Me.btnCategory.Name = "btnCategory"
        Me.btnCategory.Size = New System.Drawing.Size(79, 24)
        Me.btnCategory.TabIndex = 0
        Me.btnCategory.Text = "Category"
        Me.btnCategory.UseVisualStyleBackColor = True
        '
        'lblEnterWind
        '
        Me.lblEnterWind.AutoSize = True
        Me.lblEnterWind.Location = New System.Drawing.Point(92, 19)
        Me.lblEnterWind.Name = "lblEnterWind"
        Me.lblEnterWind.Size = New System.Drawing.Size(125, 13)
        Me.lblEnterWind.TabIndex = 1
        Me.lblEnterWind.Text = "Enter wind speed (MPH):"
        '
        'txtboxMPH
        '
        Me.txtboxMPH.Location = New System.Drawing.Point(242, 16)
        Me.txtboxMPH.Name = "txtboxMPH"
        Me.txtboxMPH.Size = New System.Drawing.Size(32, 20)
        Me.txtboxMPH.TabIndex = 2
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Location = New System.Drawing.Point(41, 105)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(0, 13)
        Me.lblCategory.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 137)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.txtboxMPH)
        Me.Controls.Add(Me.lblEnterWind)
        Me.Controls.Add(Me.btnCategory)
        Me.Name = "Form1"
        Me.Text = "Hurricane"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCategory As System.Windows.Forms.Button
    Friend WithEvents lblEnterWind As System.Windows.Forms.Label
    Friend WithEvents txtboxMPH As System.Windows.Forms.TextBox
    Friend WithEvents lblCategory As System.Windows.Forms.Label

End Class
