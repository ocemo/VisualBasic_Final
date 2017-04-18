Public Class Winners

    Private Sub Winners_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database11DataSet.Scores' table. You can move, or remove it, as needed.
        Me.ScoresTableAdapter.Fill(Me.Database11DataSet.Scores)

        'Dim newRegionRow As Database11DataSet.ScoresRow

        ''newRegionRow = Me.Database11DataSet._Region.NewRegionRow()
        'newRegionRow.Moves_Total = Form1.moves
        'newRegionRow.Player_One = StartForm.txtPlayerOne.Text
        'newRegionRow.Player_Two = StartForm.txtPlayerOne.Text

        

    End Sub

    Private Sub ScoresBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ScoresBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ScoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database11DataSet)

    End Sub
End Class