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
        Me.lstTransactions = New System.Windows.Forms.ListBox()
        Me.btnModifyAccount = New System.Windows.Forms.Button()
        Me.btnBalanceInquiry = New System.Windows.Forms.Button()
        Me.btnDeposit = New System.Windows.Forms.Button()
        Me.btnWithdrawal = New System.Windows.Forms.Button()
        Me.btnTransactions = New System.Windows.Forms.Button()
        Me.btnAddAccount = New System.Windows.Forms.Button()
        Me.btnFindAccount = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenAccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstTransactions
        '
        Me.lstTransactions.FormattingEnabled = True
        Me.lstTransactions.Location = New System.Drawing.Point(119, 41)
        Me.lstTransactions.Name = "lstTransactions"
        Me.lstTransactions.Size = New System.Drawing.Size(253, 173)
        Me.lstTransactions.TabIndex = 0
        '
        'btnModifyAccount
        '
        Me.btnModifyAccount.Enabled = False
        Me.btnModifyAccount.Location = New System.Drawing.Point(12, 88)
        Me.btnModifyAccount.Name = "btnModifyAccount"
        Me.btnModifyAccount.Size = New System.Drawing.Size(89, 20)
        Me.btnModifyAccount.TabIndex = 1
        Me.btnModifyAccount.Text = "Modify Account"
        Me.btnModifyAccount.UseVisualStyleBackColor = True
        '
        'btnBalanceInquiry
        '
        Me.btnBalanceInquiry.Enabled = False
        Me.btnBalanceInquiry.Location = New System.Drawing.Point(12, 114)
        Me.btnBalanceInquiry.Name = "btnBalanceInquiry"
        Me.btnBalanceInquiry.Size = New System.Drawing.Size(89, 20)
        Me.btnBalanceInquiry.TabIndex = 2
        Me.btnBalanceInquiry.Text = "Balance Inquiry"
        Me.btnBalanceInquiry.UseVisualStyleBackColor = True
        '
        'btnDeposit
        '
        Me.btnDeposit.Enabled = False
        Me.btnDeposit.Location = New System.Drawing.Point(12, 140)
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(89, 20)
        Me.btnDeposit.TabIndex = 3
        Me.btnDeposit.Text = "Deposit"
        Me.btnDeposit.UseVisualStyleBackColor = True
        '
        'btnWithdrawal
        '
        Me.btnWithdrawal.Enabled = False
        Me.btnWithdrawal.Location = New System.Drawing.Point(12, 166)
        Me.btnWithdrawal.Name = "btnWithdrawal"
        Me.btnWithdrawal.Size = New System.Drawing.Size(89, 20)
        Me.btnWithdrawal.TabIndex = 4
        Me.btnWithdrawal.Text = "Withdrawal"
        Me.btnWithdrawal.UseVisualStyleBackColor = True
        '
        'btnTransactions
        '
        Me.btnTransactions.Enabled = False
        Me.btnTransactions.Location = New System.Drawing.Point(12, 192)
        Me.btnTransactions.Name = "btnTransactions"
        Me.btnTransactions.Size = New System.Drawing.Size(89, 20)
        Me.btnTransactions.TabIndex = 5
        Me.btnTransactions.Text = "Transactions"
        Me.btnTransactions.UseVisualStyleBackColor = True
        '
        'btnAddAccount
        '
        Me.btnAddAccount.Location = New System.Drawing.Point(12, 62)
        Me.btnAddAccount.Name = "btnAddAccount"
        Me.btnAddAccount.Size = New System.Drawing.Size(89, 20)
        Me.btnAddAccount.TabIndex = 6
        Me.btnAddAccount.Text = "Add Account"
        Me.btnAddAccount.UseVisualStyleBackColor = True
        '
        'btnFindAccount
        '
        Me.btnFindAccount.Location = New System.Drawing.Point(12, 36)
        Me.btnFindAccount.Name = "btnFindAccount"
        Me.btnFindAccount.Size = New System.Drawing.Size(89, 20)
        Me.btnFindAccount.TabIndex = 7
        Me.btnFindAccount.Text = "Find Account"
        Me.btnFindAccount.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(387, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenAccountsToolStripMenuItem, Me.CloseAccountsToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenAccountsToolStripMenuItem
        '
        Me.OpenAccountsToolStripMenuItem.Name = "OpenAccountsToolStripMenuItem"
        Me.OpenAccountsToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.OpenAccountsToolStripMenuItem.Text = "Open Accounts"
        '
        'CloseAccountsToolStripMenuItem
        '
        Me.CloseAccountsToolStripMenuItem.Name = "CloseAccountsToolStripMenuItem"
        Me.CloseAccountsToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.CloseAccountsToolStripMenuItem.Text = "Close Accounts"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 225)
        Me.Controls.Add(Me.btnFindAccount)
        Me.Controls.Add(Me.btnAddAccount)
        Me.Controls.Add(Me.btnTransactions)
        Me.Controls.Add(Me.btnWithdrawal)
        Me.Controls.Add(Me.btnDeposit)
        Me.Controls.Add(Me.btnBalanceInquiry)
        Me.Controls.Add(Me.btnModifyAccount)
        Me.Controls.Add(Me.lstTransactions)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Local Bank"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstTransactions As System.Windows.Forms.ListBox
    Friend WithEvents btnModifyAccount As System.Windows.Forms.Button
    Friend WithEvents btnBalanceInquiry As System.Windows.Forms.Button
    Friend WithEvents btnDeposit As System.Windows.Forms.Button
    Friend WithEvents btnWithdrawal As System.Windows.Forms.Button
    Friend WithEvents btnTransactions As System.Windows.Forms.Button
    Friend WithEvents btnAddAccount As System.Windows.Forms.Button
    Friend WithEvents btnFindAccount As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenAccountsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseAccountsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class
