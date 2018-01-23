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
        Me.lblFahrenheit = New System.Windows.Forms.Label()
        Me.lblTempCelsius = New System.Windows.Forms.Label()
        Me.lblTemp = New System.Windows.Forms.Label()
        Me.btnCelsius = New System.Windows.Forms.Button()
        Me.txtboxFahrenheit = New System.Windows.Forms.TextBox()
        Me.btnFahrenheit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblFahrenheit
        '
        Me.lblFahrenheit.AutoSize = True
        Me.lblFahrenheit.Location = New System.Drawing.Point(22, 32)
        Me.lblFahrenheit.Name = "lblFahrenheit"
        Me.lblFahrenheit.Size = New System.Drawing.Size(112, 13)
        Me.lblFahrenheit.TabIndex = 0
        Me.lblFahrenheit.Text = "Enter the temperature:"
        '
        'lblTempCelsius
        '
        Me.lblTempCelsius.AutoSize = True
        Me.lblTempCelsius.Location = New System.Drawing.Point(22, 70)
        Me.lblTempCelsius.Name = "lblTempCelsius"
        Me.lblTempCelsius.Size = New System.Drawing.Size(112, 13)
        Me.lblTempCelsius.TabIndex = 1
        Me.lblTempCelsius.Text = "The temperature in  is:"
        '
        'lblTemp
        '
        Me.lblTemp.AutoSize = True
        Me.lblTemp.Location = New System.Drawing.Point(174, 71)
        Me.lblTemp.Name = "lblTemp"
        Me.lblTemp.Size = New System.Drawing.Size(0, 13)
        Me.lblTemp.TabIndex = 2
        '
        'btnCelsius
        '
        Me.btnCelsius.Location = New System.Drawing.Point(25, 99)
        Me.btnCelsius.Name = "btnCelsius"
        Me.btnCelsius.Size = New System.Drawing.Size(72, 23)
        Me.btnCelsius.TabIndex = 3
        Me.btnCelsius.Text = "Celsius"
        Me.btnCelsius.UseVisualStyleBackColor = True
        '
        'txtboxFahrenheit
        '
        Me.txtboxFahrenheit.Location = New System.Drawing.Point(181, 29)
        Me.txtboxFahrenheit.Name = "txtboxFahrenheit"
        Me.txtboxFahrenheit.Size = New System.Drawing.Size(47, 20)
        Me.txtboxFahrenheit.TabIndex = 4
        '
        'btnFahrenheit
        '
        Me.btnFahrenheit.Location = New System.Drawing.Point(156, 99)
        Me.btnFahrenheit.Name = "btnFahrenheit"
        Me.btnFahrenheit.Size = New System.Drawing.Size(72, 23)
        Me.btnFahrenheit.TabIndex = 5
        Me.btnFahrenheit.Text = "Fahrenheit"
        Me.btnFahrenheit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(283, 134)
        Me.Controls.Add(Me.btnFahrenheit)
        Me.Controls.Add(Me.txtboxFahrenheit)
        Me.Controls.Add(Me.btnCelsius)
        Me.Controls.Add(Me.lblTemp)
        Me.Controls.Add(Me.lblTempCelsius)
        Me.Controls.Add(Me.lblFahrenheit)
        Me.Name = "Form1"
        Me.Text = "Temperature Conversion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFahrenheit As System.Windows.Forms.Label
    Friend WithEvents lblTempCelsius As System.Windows.Forms.Label
    Friend WithEvents lblTemp As System.Windows.Forms.Label
    Friend WithEvents btnCelsius As System.Windows.Forms.Button
    Friend WithEvents txtboxFahrenheit As System.Windows.Forms.TextBox
    Friend WithEvents btnFahrenheit As System.Windows.Forms.Button

End Class
