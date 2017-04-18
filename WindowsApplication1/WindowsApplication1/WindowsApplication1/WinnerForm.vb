Public Class WinnerForm

    Dim winner As String

    Private Sub WinnerForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed, btnExit.Click
        Me.Close()
        StartForm.Close()
        Form1.Close()
    End Sub

    Private Sub WinnerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.winner = "One" Then
            winner = "Player One"
        ElseIf Form1.winner = "Two" Then
            winner = "Player Two"
        End If

        lblWinner.Text = winner & " has won the game!"

        Dim DatabaseTableAdapter As New Database11DataSetTableAdapters.ScoresTableAdapter

        DatabaseTableAdapter.Insert(CStr(StartForm.txtPlayerOne.Text), CStr(StartForm.txtPlayerTwo.Text), Form1.moves)

        'Dim newRegionRow As Database11DataSet.ScoresRow

        'newRegionRow = Me.Database11DataSet._Region.NewRegionRow()
        'newRegionRow.Moves_Total = Form1.moves
        'newRegionRow.Player_One = StartForm.txtPlayerOne.Text
        'newRegionRow.Player_Two = StartForm.txtPlayerOne.Text



    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        Me.Hide()
        StartForm.Show()
        Form1.Close()
    End Sub

    Private Sub btnWinners_Click(sender As Object, e As EventArgs) Handles btnWinners.Click
        Winners.Show()
        Me.Hide()
    End Sub
End Class