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
        Me.lblElementsPrompt = New System.Windows.Forms.Label
        Me.txtNumElements = New System.Windows.Forms.TextBox
        Me.btnSort = New System.Windows.Forms.Button
        Me.lstArrayElements = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'lblElementsPrompt
        '
        Me.lblElementsPrompt.AutoSize = True
        Me.lblElementsPrompt.Location = New System.Drawing.Point(9, 16)
        Me.lblElementsPrompt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblElementsPrompt.Name = "lblElementsPrompt"
        Me.lblElementsPrompt.Size = New System.Drawing.Size(130, 13)
        Me.lblElementsPrompt.TabIndex = 0
        Me.lblElementsPrompt.Text = "Enter number of elements:"
        '
        'txtNumElements
        '
        Me.txtNumElements.Location = New System.Drawing.Point(145, 12)
        Me.txtNumElements.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNumElements.Name = "txtNumElements"
        Me.txtNumElements.Size = New System.Drawing.Size(36, 20)
        Me.txtNumElements.TabIndex = 1
        '
        'btnSort
        '
        Me.btnSort.Location = New System.Drawing.Point(11, 46)
        Me.btnSort.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(39, 19)
        Me.btnSort.TabIndex = 2
        Me.btnSort.Text = "Sort"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'lstArrayElements
        '
        Me.lstArrayElements.FormattingEnabled = True
        Me.lstArrayElements.Location = New System.Drawing.Point(70, 46)
        Me.lstArrayElements.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lstArrayElements.Name = "lstArrayElements"
        Me.lstArrayElements.Size = New System.Drawing.Size(110, 160)
        Me.lstArrayElements.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(202, 216)
        Me.Controls.Add(Me.lstArrayElements)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.txtNumElements)
        Me.Controls.Add(Me.lblElementsPrompt)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "Insertion Sort"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblElementsPrompt As System.Windows.Forms.Label
    Friend WithEvents txtNumElements As System.Windows.Forms.TextBox
    Friend WithEvents btnSort As System.Windows.Forms.Button
    Friend WithEvents lstArrayElements As System.Windows.Forms.ListBox

End Class
