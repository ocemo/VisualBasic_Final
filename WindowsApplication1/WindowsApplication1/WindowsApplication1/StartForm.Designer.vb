<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartForm
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
        Me.lblPlayerOne = New System.Windows.Forms.Label()
        Me.lblPlayerTwo = New System.Windows.Forms.Label()
        Me.txtPlayerOne = New System.Windows.Forms.TextBox()
        Me.txtPlayerTwo = New System.Windows.Forms.TextBox()
        Me.btnNewGame = New System.Windows.Forms.Button()
        Me.btnReplay = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPlayerOne
        '
        Me.lblPlayerOne.AutoSize = True
        Me.lblPlayerOne.Location = New System.Drawing.Point(12, 9)
        Me.lblPlayerOne.Name = "lblPlayerOne"
        Me.lblPlayerOne.Size = New System.Drawing.Size(62, 13)
        Me.lblPlayerOne.TabIndex = 0
        Me.lblPlayerOne.Text = "Player One:"
        '
        'lblPlayerTwo
        '
        Me.lblPlayerTwo.AutoSize = True
        Me.lblPlayerTwo.Location = New System.Drawing.Point(12, 50)
        Me.lblPlayerTwo.Name = "lblPlayerTwo"
        Me.lblPlayerTwo.Size = New System.Drawing.Size(63, 13)
        Me.lblPlayerTwo.TabIndex = 1
        Me.lblPlayerTwo.Text = "Player Two:"
        '
        'txtPlayerOne
        '
        Me.txtPlayerOne.Location = New System.Drawing.Point(80, 6)
        Me.txtPlayerOne.Name = "txtPlayerOne"
        Me.txtPlayerOne.Size = New System.Drawing.Size(100, 20)
        Me.txtPlayerOne.TabIndex = 2
        '
        'txtPlayerTwo
        '
        Me.txtPlayerTwo.Location = New System.Drawing.Point(80, 47)
        Me.txtPlayerTwo.Name = "txtPlayerTwo"
        Me.txtPlayerTwo.Size = New System.Drawing.Size(100, 20)
        Me.txtPlayerTwo.TabIndex = 3
        '
        'btnNewGame
        '
        Me.btnNewGame.Location = New System.Drawing.Point(15, 88)
        Me.btnNewGame.Name = "btnNewGame"
        Me.btnNewGame.Size = New System.Drawing.Size(116, 23)
        Me.btnNewGame.TabIndex = 4
        Me.btnNewGame.Text = "Start Game"
        Me.btnNewGame.UseVisualStyleBackColor = True
        '
        'btnReplay
        '
        Me.btnReplay.Location = New System.Drawing.Point(15, 117)
        Me.btnReplay.Name = "btnReplay"
        Me.btnReplay.Size = New System.Drawing.Size(116, 23)
        Me.btnReplay.TabIndex = 5
        Me.btnReplay.Text = "Replay Last Game"
        Me.btnReplay.UseVisualStyleBackColor = True
        Me.btnReplay.Visible = False
        '
        'StartForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(226, 183)
        Me.Controls.Add(Me.btnReplay)
        Me.Controls.Add(Me.btnNewGame)
        Me.Controls.Add(Me.txtPlayerTwo)
        Me.Controls.Add(Me.txtPlayerOne)
        Me.Controls.Add(Me.lblPlayerTwo)
        Me.Controls.Add(Me.lblPlayerOne)
        Me.Name = "StartForm"
        Me.Text = "StartForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPlayerOne As System.Windows.Forms.Label
    Friend WithEvents lblPlayerTwo As System.Windows.Forms.Label
    Friend WithEvents txtPlayerOne As System.Windows.Forms.TextBox
    Friend WithEvents txtPlayerTwo As System.Windows.Forms.TextBox
    Friend WithEvents btnNewGame As System.Windows.Forms.Button
    Friend WithEvents btnReplay As System.Windows.Forms.Button
End Class
