Imports System.IO


Public Class StartForm

    Public replay As String

    Private Sub StartForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Close()
        Form1.Close()
        WinnerForm.Close()
    End Sub

    Private Sub StartForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Show()
        Form1.Hide()
        WinnerForm.Show()
        WinnerForm.Hide()
    End Sub

    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnReplay_Click(sender As Object, e As EventArgs) Handles btnReplay.Click
        replay = "1"
    End Sub
End Class