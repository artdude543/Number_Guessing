<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.lblGuess = New System.Windows.Forms.Label()
        Me.mnMain = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTries = New System.Windows.Forms.TextBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.txtUserGuess = New System.Windows.Forms.TextBox()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.cmdGiveUp = New System.Windows.Forms.Button()
        Me.cmdRun = New System.Windows.Forms.Button()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLastGuess = New System.Windows.Forms.TextBox()
        Me.mnMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblGuess
        '
        Me.lblGuess.AutoSize = True
        Me.lblGuess.Location = New System.Drawing.Point(12, 63)
        Me.lblGuess.Name = "lblGuess"
        Me.lblGuess.Size = New System.Drawing.Size(65, 13)
        Me.lblGuess.TabIndex = 0
        Me.lblGuess.Text = "Your Guess:"
        '
        'mnMain
        '
        Me.mnMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.mnMain.Location = New System.Drawing.Point(0, 0)
        Me.mnMain.Name = "mnMain"
        Me.mnMain.Size = New System.Drawing.Size(331, 24)
        Me.mnMain.TabIndex = 1
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Status:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Answer:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(231, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tries:"
        '
        'txtTries
        '
        Me.txtTries.Location = New System.Drawing.Point(270, 30)
        Me.txtTries.Name = "txtTries"
        Me.txtTries.ReadOnly = True
        Me.txtTries.Size = New System.Drawing.Size(49, 20)
        Me.txtTries.TabIndex = 5
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(83, 112)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(100, 20)
        Me.txtStatus.TabIndex = 6
        '
        'txtUserGuess
        '
        Me.txtUserGuess.Location = New System.Drawing.Point(83, 60)
        Me.txtUserGuess.Name = "txtUserGuess"
        Me.txtUserGuess.Size = New System.Drawing.Size(100, 20)
        Me.txtUserGuess.TabIndex = 7
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(83, 138)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.ReadOnly = True
        Me.txtAnswer.Size = New System.Drawing.Size(100, 20)
        Me.txtAnswer.TabIndex = 8
        '
        'cmdGiveUp
        '
        Me.cmdGiveUp.Location = New System.Drawing.Point(244, 187)
        Me.cmdGiveUp.Name = "cmdGiveUp"
        Me.cmdGiveUp.Size = New System.Drawing.Size(75, 23)
        Me.cmdGiveUp.TabIndex = 9
        Me.cmdGiveUp.Text = "Give Up"
        Me.cmdGiveUp.UseVisualStyleBackColor = True
        '
        'cmdRun
        '
        Me.cmdRun.Location = New System.Drawing.Point(163, 187)
        Me.cmdRun.Name = "cmdRun"
        Me.cmdRun.Size = New System.Drawing.Size(75, 23)
        Me.cmdRun.TabIndex = 10
        Me.cmdRun.Text = "Guess"
        Me.cmdRun.UseVisualStyleBackColor = True
        '
        'cmdReset
        '
        Me.cmdReset.Location = New System.Drawing.Point(2, 187)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(75, 23)
        Me.cmdReset.TabIndex = 11
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Last Guess:"
        '
        'txtLastGuess
        '
        Me.txtLastGuess.Location = New System.Drawing.Point(83, 86)
        Me.txtLastGuess.Name = "txtLastGuess"
        Me.txtLastGuess.ReadOnly = True
        Me.txtLastGuess.Size = New System.Drawing.Size(100, 20)
        Me.txtLastGuess.TabIndex = 13
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 222)
        Me.Controls.Add(Me.txtLastGuess)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.cmdRun)
        Me.Controls.Add(Me.cmdGiveUp)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.txtUserGuess)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.txtTries)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblGuess)
        Me.Controls.Add(Me.mnMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.mnMain
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Number Guessing"
        Me.mnMain.ResumeLayout(False)
        Me.mnMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblGuess As System.Windows.Forms.Label
    Friend WithEvents mnMain As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTries As System.Windows.Forms.TextBox
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents txtUserGuess As System.Windows.Forms.TextBox
    Friend WithEvents txtAnswer As System.Windows.Forms.TextBox
    Friend WithEvents cmdGiveUp As System.Windows.Forms.Button
    Friend WithEvents cmdRun As System.Windows.Forms.Button
    Friend WithEvents cmdReset As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtLastGuess As System.Windows.Forms.TextBox

End Class
