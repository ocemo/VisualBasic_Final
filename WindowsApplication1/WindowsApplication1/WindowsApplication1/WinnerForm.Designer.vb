<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WinnerForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblWinner = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.btnWinners = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Congratulations!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblWinner
        '
        Me.lblWinner.AutoSize = True
        Me.lblWinner.Location = New System.Drawing.Point(78, 34)
        Me.lblWinner.Name = "lblWinner"
        Me.lblWinner.Size = New System.Drawing.Size(39, 13)
        Me.lblWinner.TabIndex = 1
        Me.lblWinner.Text = "Label2"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(63, 95)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnRestart
        '
        Me.btnRestart.Location = New System.Drawing.Point(63, 124)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(80, 23)
        Me.btnRestart.TabIndex = 3
        Me.btnRestart.Text = "Restart"
        Me.btnRestart.UseVisualStyleBackColor = True
        '
        'btnWinners
        '
        Me.btnWinners.Location = New System.Drawing.Point(63, 66)
        Me.btnWinners.Name = "btnWinners"
        Me.btnWinners.Size = New System.Drawing.Size(80, 23)
        Me.btnWinners.TabIndex = 4
        Me.btnWinners.Text = "See Winners"
        Me.btnWinners.UseVisualStyleBackColor = True
        '
        'WinnerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(211, 172)
        Me.Controls.Add(Me.btnWinners)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblWinner)
        Me.Controls.Add(Me.Label1)
        Me.Name = "WinnerForm"
        Me.Text = "Winner!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblWinner As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnRestart As System.Windows.Forms.Button
    Friend WithEvents btnWinners As System.Windows.Forms.Button
End Class
