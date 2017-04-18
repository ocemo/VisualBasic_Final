Imports System.IO

Public Class Form1

    Public winner As String

    Public moves As Long = 0

    Dim gamerecord As StreamWriter = New StreamWriter("gamerecord.txt")
    'Dim gamerecordread As StreamReader = New StreamReader("gamerecord.txt")

    Dim recordOfMoves As Stack(Of String) = New Stack(Of String)
    Dim movetoundo As String

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing, ExitToolStripMenuItem.Click, ExitToolStripMenuItem1.Click
        'Me.Close()
        StartForm.Close()
        WinnerForm.Close()
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'lblWinnerOne.Visible = True

        If StartForm.replay = "1" Then
            deactivateSquareGroup(gbxOne, gbxTwo, gbxThree, gbxFour, gbxFive, gbxSix, gbxSeven, gbxEight, gbxNine)
            deactivateSquare(gbxOne)
            'replaySub()
        End If
    End Sub



    Private Sub ComboBox54_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb21.SelectedIndexChanged, cmb19.SelectedIndexChanged, cmb1.SelectedIndexChanged, cmb71.SelectedIndexChanged,
                                                                                          cmb20.SelectedIndexChanged, cmb12.SelectedIndexChanged, cmb3.SelectedIndexChanged, cmb11.SelectedIndexChanged,
                                                                                          cmb10.SelectedIndexChanged, cmb2.SelectedIndexChanged, cmb1.SelectedIndexChanged, cmb1.SelectedIndexChanged,
                                                                                          cmb14.SelectedIndexChanged, cmb4.SelectedIndexChanged, cmb5.SelectedIndexChanged, cmb13.SelectedIndexChanged,
                                                                                          cmb6.SelectedIndexChanged, cmb15.SelectedIndexChanged, cmb23.SelectedIndexChanged, cmb22.SelectedIndexChanged,
                                                                                          cmb24.SelectedIndexChanged, cmb17.SelectedIndexChanged, cmb7.SelectedIndexChanged, cmb8.SelectedIndexChanged,
                                                                                          cmb16.SelectedIndexChanged, cmb9.SelectedIndexChanged, cmb18.SelectedIndexChanged, cmb26.SelectedIndexChanged,
                                                                                          cmb25.SelectedIndexChanged, cmb27.SelectedIndexChanged, cmb61.SelectedIndexChanged, cmb62.SelectedIndexChanged,
                                                                                          cmb70.SelectedIndexChanged, cmb63.SelectedIndexChanged, cmb72.SelectedIndexChanged, cmb80.SelectedIndexChanged,
                                                                                          cmb79.SelectedIndexChanged, cmb81.SelectedIndexChanged, cmb68.SelectedIndexChanged, cmb58.SelectedIndexChanged,
                                                                                          cmb59.SelectedIndexChanged, cmb67.SelectedIndexChanged, cmb60.SelectedIndexChanged, cmb69.SelectedIndexChanged,
                                                                                          cmb77.SelectedIndexChanged, cmb76.SelectedIndexChanged, cmb78.SelectedIndexChanged, cmb65.SelectedIndexChanged,
                                                                                          cmb55.SelectedIndexChanged, cmb56.SelectedIndexChanged, cmb64.SelectedIndexChanged, cmb57.SelectedIndexChanged,
                                                                                          cmb66.SelectedIndexChanged, cmb74.SelectedIndexChanged, cmb73.SelectedIndexChanged, cmb75.SelectedIndexChanged,
                                                                                          cmb44.SelectedIndexChanged, cmb34.SelectedIndexChanged, cmb35.SelectedIndexChanged, cmb43.SelectedIndexChanged,
                                                                                          cmb36.SelectedIndexChanged, cmb45.SelectedIndexChanged, cmb53.SelectedIndexChanged, cmb52.SelectedIndexChanged,
                                                                                          cmb54.SelectedIndexChanged, cmb41.SelectedIndexChanged, cmb31.SelectedIndexChanged, cmb32.SelectedIndexChanged,
                                                                                          cmb40.SelectedIndexChanged, cmb33.SelectedIndexChanged, cmb42.SelectedIndexChanged, cmb50.SelectedIndexChanged,
                                                                                          cmb49.SelectedIndexChanged, cmb51.SelectedIndexChanged, cmb38.SelectedIndexChanged, cmb28.SelectedIndexChanged,
                                                                                          cmb29.SelectedIndexChanged, cmb37.SelectedIndexChanged, cmb30.SelectedIndexChanged, cmb39.SelectedIndexChanged,
                                                                                          cmb47.SelectedIndexChanged, cmb46.SelectedIndexChanged, cmb46.SelectedIndexChanged, cmb48.SelectedIndexChanged

        If CheckWinnerFullForm() = True Then
            Me.Hide()
            WinnerForm.Show()
        End If

        moves += 1

        gamerecord.WriteLine(CStr(sender.Name()))
        recordOfMoves.Push(CStr(sender.Name()))

        'CheckWinnerSquare()
        CheckWinnerSquare(cmb1.SelectedItem, cmb2.SelectedItem, cmb3.SelectedItem, cmb10.SelectedItem, cmb11.SelectedItem, cmb12.SelectedItem, cmb19.SelectedItem, cmb20.SelectedItem, cmb21.SelectedItem, lblWinnerOne)
        CheckWinnerSquare(cmb4.SelectedItem, cmb5.SelectedItem, cmb6.SelectedItem, cmb13.SelectedItem, cmb14.SelectedItem, cmb15.SelectedItem, cmb22.SelectedItem, cmb23.SelectedItem, cmb24.SelectedItem, lblWinnerTwo)
        CheckWinnerSquare(cmb7.SelectedItem, cmb8.SelectedItem, cmb9.SelectedItem, cmb16.SelectedItem, cmb17.SelectedItem, cmb18.SelectedItem, cmb25.SelectedItem, cmb26.SelectedItem, cmb27.SelectedItem, lblWinnerThree)
        CheckWinnerSquare(cmb28.SelectedItem, cmb29.SelectedItem, cmb30.SelectedItem, cmb37.SelectedItem, cmb38.SelectedItem, cmb39.SelectedItem, cmb46.SelectedItem, cmb47.SelectedItem, cmb48.SelectedItem, lblWinnerFour)
        CheckWinnerSquare(cmb31.SelectedItem, cmb32.SelectedItem, cmb33.SelectedItem, cmb40.SelectedItem, cmb41.SelectedItem, cmb42.SelectedItem, cmb49.SelectedItem, cmb50.SelectedItem, cmb51.SelectedItem, lblWinnerFive)
        CheckWinnerSquare(cmb34.SelectedItem, cmb35.SelectedItem, cmb36.SelectedItem, cmb43.SelectedItem, cmb44.SelectedItem, cmb45.SelectedItem, cmb52.SelectedItem, cmb53.SelectedItem, cmb54.SelectedItem, lblWinnerSix)
        CheckWinnerSquare(cmb55.SelectedItem, cmb56.SelectedItem, cmb57.SelectedItem, cmb64.SelectedItem, cmb65.SelectedItem, cmb66.SelectedItem, cmb73.SelectedItem, cmb74.SelectedItem, cmb75.SelectedItem, lblWinnerSeven)
        CheckWinnerSquare(cmb58.SelectedItem, cmb59.SelectedItem, cmb60.SelectedItem, cmb67.SelectedItem, cmb68.SelectedItem, cmb69.SelectedItem, cmb76.SelectedItem, cmb77.SelectedItem, cmb78.SelectedItem, lblWinnerEight)
        CheckWinnerSquare(cmb61.SelectedItem, cmb62.SelectedItem, cmb63.SelectedItem, cmb70.SelectedItem, cmb71.SelectedItem, cmb72.SelectedItem, cmb79.SelectedItem, cmb80.SelectedItem, cmb81.SelectedItem, lblWinnerNine)

    End Sub

    'Handles all of the moves that go in the top left corner of the board
    Private Sub cmb1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb1.SelectedIndexChanged, cmb4.SelectedIndexChanged, cmb7.SelectedIndexChanged, cmb28.SelectedIndexChanged,
                                                                                    cmb31.SelectedIndexChanged, cmb34.SelectedIndexChanged, cmb55.SelectedIndexChanged, cmb58.SelectedIndexChanged,
                                                                                    cmb61.SelectedIndexChanged

        deactivateSquareGroup(gbxOne, gbxTwo, gbxThree, gbxFour, gbxFive, gbxSix, gbxSeven, gbxEight, gbxNine)

        If lblWinnerOne.Text = "One" Or lblWinnerOne.Text = "Two" Then
            deactivateSquare(gbxOne)
        End If

    End Sub

    'Handles all of the moves that go in the top middle of the board
    Private Sub cmb2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb2.SelectedIndexChanged, cmb5.SelectedIndexChanged, cmb8.SelectedIndexChanged, cmb29.SelectedIndexChanged,
                                                                                    cmb32.SelectedIndexChanged, cmb35.SelectedIndexChanged, cmb56.SelectedIndexChanged, cmb59.SelectedIndexChanged,
                                                                                    cmb62.SelectedIndexChanged

        deactivateSquareGroup(gbxTwo, gbxOne, gbxThree, gbxFour, gbxFive, gbxSix, gbxSeven, gbxEight, gbxNine)

        If lblWinnerTwo.Text = "One" Or lblWinnerTwo.Text = "Two" Then
            deactivateSquare(gbxTwo)
        End If

    End Sub

    'Handles all of the moves that go in the top right of the board
    Private Sub cmb3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb3.SelectedIndexChanged, cmb6.SelectedIndexChanged, cmb9.SelectedIndexChanged, cmb30.SelectedIndexChanged,
                                                                                    cmb33.SelectedIndexChanged, cmb36.SelectedIndexChanged, cmb57.SelectedIndexChanged, cmb60.SelectedIndexChanged,
                                                                                    cmb63.SelectedIndexChanged

        deactivateSquareGroup(gbxThree, gbxTwo, gbxOne, gbxFour, gbxFive, gbxSix, gbxSeven, gbxEight, gbxNine)

        If lblWinnerThree.Text = "One" Or lblWinnerThree.Text = "Two" Then
            deactivateSquare(gbxThree)
        End If

    End Sub

    'Handles all of the moves in the middle left of the board
    Private Sub cmb10_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb10.SelectedIndexChanged, cmb13.SelectedIndexChanged, cmb16.SelectedIndexChanged, cmb37.SelectedIndexChanged,
                                                                                     cmb40.SelectedIndexChanged, cmb43.SelectedIndexChanged, cmb64.SelectedIndexChanged, cmb67.SelectedIndexChanged,
                                                                                     cmb70.SelectedIndexChanged

        deactivateSquareGroup(gbxFour, gbxTwo, gbxOne, gbxThree, gbxFive, gbxSix, gbxSeven, gbxEight, gbxNine)

        If lblWinnerFour.Text = "One" Or lblWinnerFour.Text = "Two" Then
            deactivateSquare(gbxFour)
        End If

    End Sub

    'Handles all of the moves in the center of the board
    Private Sub cmb11_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb11.SelectedIndexChanged, cmb14.SelectedIndexChanged, cmb17.SelectedIndexChanged, cmb38.SelectedIndexChanged,
                                                                                     cmb41.SelectedIndexChanged, cmb44.SelectedIndexChanged, cmb65.SelectedIndexChanged, cmb68.SelectedIndexChanged,
                                                                                     cmb71.SelectedIndexChanged

        deactivateSquareGroup(gbxFive, gbxTwo, gbxThree, gbxFour, gbxOne, gbxSix, gbxSeven, gbxEight, gbxNine)

        If lblWinnerFive.Text = "One" Or lblWinnerFive.Text = "Two" Then
            deactivateSquare(gbxFive)
        End If

    End Sub

    'Handles all of the moves in the right middle of the board
    Private Sub cmd12_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb12.SelectedIndexChanged, cmb15.SelectedIndexChanged, cmb18.SelectedIndexChanged, cmb39.SelectedIndexChanged,
                                                                                     cmb42.SelectedIndexChanged, cmb45.SelectedIndexChanged, cmb66.SelectedIndexChanged, cmb69.SelectedIndexChanged,
                                                                                     cmb72.SelectedIndexChanged

        deactivateSquareGroup(gbxSix, gbxTwo, gbxThree, gbxFour, gbxFive, gbxOne, gbxSeven, gbxEight, gbxNine)

        If lblWinnerSix.Text = "One" Or lblWinnerSix.Text = "Two" Then
            deactivateSquare(gbxSix)
        End If

    End Sub

    'Handles all of the moves in the bottom left of the board
    Private Sub cmb19_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb19.SelectedIndexChanged, cmb22.SelectedIndexChanged, cmb25.SelectedIndexChanged, cmb46.SelectedIndexChanged,
                                                                                     cmb49.SelectedIndexChanged, cmb52.SelectedIndexChanged, cmb73.SelectedIndexChanged, cmb76.SelectedIndexChanged,
                                                                                     cmb79.SelectedIndexChanged

        deactivateSquareGroup(gbxSeven, gbxTwo, gbxThree, gbxFour, gbxFive, gbxSix, gbxOne, gbxEight, gbxNine)

        If lblWinnerSeven.Text = "One" Or lblWinnerSeven.Text = "Two" Then
            deactivateSquare(gbxSeven)
        End If

    End Sub

    'Handles bottom middle of the board
    Private Sub cmb20_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb20.SelectedIndexChanged, cmb23.SelectedIndexChanged, cmb26.SelectedIndexChanged, cmb47.SelectedIndexChanged,
                                                                                     cmb50.SelectedIndexChanged, cmb53.SelectedIndexChanged, cmb74.SelectedIndexChanged, cmb77.SelectedIndexChanged,
                                                                                     cmb80.SelectedIndexChanged

        deactivateSquareGroup(gbxEight, gbxTwo, gbxThree, gbxFour, gbxFive, gbxSix, gbxSeven, gbxOne, gbxNine)

        If lblWinnerEight.Text = "One" Or lblWinnerEight.Text = "Two" Then
            deactivateSquare(gbxEight)
        End If

    End Sub

    'Handles bottom right of the board
    Private Sub cmb21_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb21.SelectedIndexChanged, cmb24.SelectedIndexChanged, cmb27.SelectedIndexChanged, cmb48.SelectedIndexChanged,
                                                                                     cmb51.SelectedIndexChanged, cmb54.SelectedIndexChanged, cmb75.SelectedIndexChanged, cmb78.SelectedIndexChanged,
                                                                                     cmb81.SelectedIndexChanged

        deactivateSquareGroup(gbxNine, gbxTwo, gbxThree, gbxFour, gbxFive, gbxSix, gbxSeven, gbxEight, gbxOne)

        If lblWinnerNine.Text = "One" Or lblWinnerNine.Text = "Two" Then
            deactivateSquare(gbxNine)
        End If

    End Sub

    Public Function CheckWinnerFullForm()
        If (lblWinnerOne.Text & lblWinnerTwo.Text & lblWinnerThree.Text = "1") Then
            winner = "One"
            Return True
        ElseIf (lblWinnerOne.Text & lblWinnerTwo.Text & lblWinnerThree.Text = "2") Then
            winner = "Two"
            Return True
        ElseIf (lblWinnerOne.Text & lblWinnerFive.Text & lblWinnerNine.Text = "1") Then
            winner = "One"
            Return True
        ElseIf (lblWinnerOne.Text & lblWinnerFive.Text & lblWinnerNine.Text = "2") Then
            winner = "Two"
            Return True
        ElseIf (lblWinnerOne.Text & lblWinnerFour.Text & lblWinnerSeven.Text = "1") Then
            winner = "One"
            Return True
        ElseIf (lblWinnerOne.Text & lblWinnerFour.Text & lblWinnerSeven.Text = "2") Then
            winner = "Two"
            Return True
        ElseIf (lblWinnerFour.Text & lblWinnerFive.Text & lblWinnerSix.Text = "1") Then
            winner = "One"
            Return True
        ElseIf (lblWinnerFour.Text & lblWinnerFive.Text & lblWinnerSix.Text = "2") Then
            winner = "Two"
            Return True
        ElseIf (lblWinnerSeven.Text & lblWinnerEight.Text & lblWinnerNine.Text = "1") Then
            winner = "One"
            Return True
        ElseIf (lblWinnerSeven.Text & lblWinnerEight.Text & lblWinnerNine.Text = "2") Then
            winner = "Two"
            Return True
        ElseIf (lblWinnerSeven.Text & lblWinnerFive.Text & lblWinnerThree.Text = "1") Then
            winner = "One"
            Return True
        ElseIf (lblWinnerSeven.Text & lblWinnerFive.Text & lblWinnerThree.Text = "2") Then
            winner = "Two"
            Return True
        ElseIf (lblWinnerTwo.Text & lblWinnerFive.Text & lblWinnerEight.Text = "1") Then
            winner = "One"
            Return True
        ElseIf (lblWinnerThree.Text & lblWinnerSix.Text & lblWinnerNine.Text = "2") Then
            winner = "Two"
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub CheckWinnerSquare(ByRef cmb1, ByRef cmb2, ByRef cmb3, ByRef cmb4, ByRef cmb5, ByRef cmb6, ByRef cmb7, ByRef cmb8, ByRef cmb9, ByRef label)

        If cmb1 = "X" And cmb2 = "X" And cmb3 = "X" Then
            lblWinnerOne.Text = "One"
        ElseIf cmb1 = "X" And cmb5 = "X" And cmb9 = "X" Then
            lblWinnerOne.Text = "One"
        ElseIf cmb1 = "X" And cmb4 = "X" And cmb7 = "X" Then
            lblWinnerOne.Text = "One"
        ElseIf cmb4 = "X" And cmb5 = "X" And cmb6 = "X" Then
            lblWinnerOne.Text = "One"
        ElseIf cmb7 = "X" And cmb8 = "X" And cmb9 = "X" Then
            lblWinnerOne.Text = "One"
        ElseIf cmb2 = "X" And cmb5 = "X" And cmb8 = "X" Then
            lblWinnerOne.Text = "One"
        ElseIf cmb3 = "X" And cmb6 = "X" And cmb9 = "X" Then
            lblWinnerOne.Text = "One"
        ElseIf cmb7 = "X" And cmb5 = "X" And cmb3 = "X" Then
            lblWinnerOne.Text = "One"
        ElseIf cmb1 = "O" And cmb2 = "O" And cmb3 = "O" Then
            lblWinnerOne.Text = "Two"
        ElseIf cmb1 = "O" And cmb5 = "O" And cmb9 = "O" Then
            lblWinnerOne.Text = "Two"
        ElseIf cmb1 = "O" And cmb4 = "O" And cmb7 = "O" Then
            lblWinnerOne.Text = "Two"
        ElseIf cmb4 = "O" And cmb5 = "O" And cmb6 = "O" Then
            lblWinnerOne.Text = "Two"
        ElseIf cmb7 = "O" And cmb8 = "O" And cmb9 = "O" Then
            lblWinnerOne.Text = "Two"
        ElseIf cmb2 = "O" And cmb5 = "O" And cmb8 = "O" Then
            lblWinnerOne.Text = "Two"
        ElseIf cmb3 = "O" And cmb6 = "O" And cmb9 = "O" Then
            lblWinnerOne.Text = "Two"
        ElseIf cmb7 = "O" And cmb5 = "O" And cmb3 = "O" Then
            lblWinnerOne.Text = "Two"
        End If


        'If cmb1 & cmb2 & cmb3 = "X" Then
        '    lblWinnerOne.Text = "One"
        'ElseIf cmb1 & cmb5 & cmb9 = "X" Then
        '    lblWinnerOne.Text = "One"
        'ElseIf cmb1 & cmb4 & cmb7 = "X" Then
        '    lblWinnerOne.Text = "One"
        'ElseIf cmb4 & cmb5 & cmb6 = "X" Then
        '    lblWinnerOne.Text = "One"
        'ElseIf cmb7 & cmb8 & cmb9 = "X" Then
        '    lblWinnerOne.Text = "One"
        'ElseIf cmb2 & cmb5 & cmb8 = "X" Then
        '    lblWinnerOne.Text = "One"
        'ElseIf cmb3 & cmb6 & cmb9 = "X" Then
        '    lblWinnerOne.Text = "One"
        'ElseIf cmb7 & cmb5 & cmb3 = "X" Then
        '    lblWinnerOne.Text = "One"
        'ElseIf cmb1 & cmb2 & cmb3 = "O" Then
        '    lblWinnerOne.Text = "Two"
        'ElseIf cmb1 & cmb5 & cmb9 = "O" Then
        '    lblWinnerOne.Text = "Two"
        'ElseIf cmb1 & cmb4 & cmb7 = "O" Then
        '    lblWinnerOne.Text = "Two"
        'ElseIf cmb4 & cmb5 & cmb6 = "O" Then
        '    lblWinnerOne.Text = "Two"
        'ElseIf cmb7 & cmb8 & cmb9 = "O" Then
        '    lblWinnerOne.Text = "Two"
        'ElseIf cmb2 & cmb5 & cmb8 = "O" Then
        '    lblWinnerOne.Text = "Two"
        'ElseIf cmb3 & cmb6 & cmb9 = "O" Then
        '    lblWinnerOne.Text = "Two"
        'ElseIf cmb7 & cmb5 & cmb3 = "O" Then
        '    lblWinnerOne.Text = "Two"
        'End If

    End Sub

    Public Sub activateSquare(ByRef groupbox)
        groupbox.Enabled = True
    End Sub

    Public Sub deactivateSquare(ByRef groupbox)
        groupbox.Enabled = False
    End Sub

    Public Sub deactivateSquareGroup(ByRef groupbox1, ByRef groupbox2, ByRef groupbox3, ByRef groupbox4, ByRef groupbox5, ByRef groupbox6, ByRef groupbox7, ByRef groupbox8, ByRef groupbox9)

        activateSquare(groupbox1)
        deactivateSquare(groupbox2)
        deactivateSquare(groupbox3)
        deactivateSquare(groupbox4)
        deactivateSquare(groupbox5)
        deactivateSquare(groupbox6)
        deactivateSquare(groupbox7)
        deactivateSquare(groupbox8)
        deactivateSquare(groupbox9)

    End Sub

    Private Sub HelpToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem1.Click, HelpToolStripMenuItem.Click 'Code used to show the help to the user
        MessageBox.Show("The game is played by one player picking somewhere to move, and the next move made by the second player has to be in the groupbox that corresponds with the location of the other players move.")
    End Sub

    'Private Sub UdnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click


    '    movetoundo = recordOfMoves.Pop

    'Dim Obj As ComboBox
    '    For Each elem In Me.Controls
    '        If elem.Name = movetoundo Then
    '            Obj = elem
    '            Exit For
    '        End If
    '    Next

    '    Obj.SelectedItem = -1

    '    If CStr(Obj.Name()) = cmb1.Name() Or cmb2.Name() Or cmb3.Name() Or cmb10.Name() Or cmb11.Name() Or cmb12.Name() Or cmb19.Name() Or cmb20.Name() Or cmb21.Name() Then
    '        deactivateSquareGroup(gbxOne, gbxTwo, gbxThree, gbxFour, gbxFive, gbxSix, gbxSeven, gbxEight, gbxNine)
    '    ElseIf CStr(Obj.Name()) = cmb4.Name() Or cmb5.Name() Or cmb6.Name() Or cmb13.Name() Or cmb14.Name() Or cmb15.Name() Or cmb22.Name() Or cmb23.Name() Or cmb24.Name() Then
    '        deactivateSquareGroup(gbxTwo, gbxOne, gbxThree, gbxFour, gbxFive, gbxSix, gbxSeven, gbxEight, gbxNine)
    '    ElseIf CStr(Obj.Name()) = cmb7.Name() Or cmb8.Name() Or cmb9.Name() Or cmb16.Name() Or cmb17.Name() Or cmb18.Name() Or cmb25.Name() Or cmb26.Name() Or cmb27.Name() Then
    '        deactivateSquareGroup(gbxThree, gbxTwo, gbxOne, gbxFour, gbxFive, gbxSix, gbxSeven, gbxEight, gbxNine)
    '    ElseIf CStr(Obj.Name()) = cmb28.Name() Or cmb29.Name() Or cmb30.Name() Or cmb37.Name() Or cmb38.Name() Or cmb39.Name() Or cmb46.Name() Or cmb47.Name() Or cmb48.Name() Then
    '        deactivateSquareGroup(gbxFour, gbxTwo, gbxThree, gbxOne, gbxFive, gbxSix, gbxSeven, gbxEight, gbxNine)
    '    ElseIf CStr(Obj.Name()) = cmb31.Name() Or cmb32.Name() Or cmb33.Name() Or cmb40.Name() Or cmb41.Name() Or cmb42.Name() Or cmb49.Name() Or cmb50.Name() Or cmb51.Name() Then
    '        deactivateSquareGroup(gbxFive, gbxTwo, gbxThree, gbxOne, gbxFour, gbxSix, gbxSeven, gbxEight, gbxNine)
    '    ElseIf CStr(Obj.Name()) = cmb34.Name() Or cmb35.Name() Or cmb36.Name() Or cmb43.Name() Or cmb44.Name() Or cmb45.Name() Or cmb52.Name() Or cmb53.Name() Or cmb54.Name() Then
    '        deactivateSquareGroup(gbxSix, gbxTwo, gbxThree, gbxFour, gbxFive, gbxOne, gbxSeven, gbxEight, gbxNine)
    '    ElseIf CStr(Obj.Name()) = cmb55.Name() Or cmb56.Name() Or cmb57.Name() Or cmb64.Name() Or cmb65.Name() Or cmb66.Name() Or cmb73.Name() Or cmb74.Name() Or cmb75.Name() Then
    '        deactivateSquareGroup(gbxSeven, gbxTwo, gbxThree, gbxFour, gbxFive, gbxSix, gbxOne, gbxEight, gbxNine)
    '    ElseIf CStr(Obj.Name()) = cmb58.Name() Or cmb59.Name() Or cmb60.Name() Or cmb67.Name() Or cmb68.Name() Or cmb69.Name() Or cmb76.Name() Or cmb77.Name() Or cmb78.Name() Then
    '        deactivateSquareGroup(gbxEight, gbxTwo, gbxThree, gbxFour, gbxFive, gbxSix, gbxSeven, gbxOne, gbxNine)
    '    ElseIf CStr(Obj.Name()) = cmb61.Name() Or cmb62.Name() Or cmb63.Name() Or cmb70.Name() Or cmb71.Name() Or cmb72.Name() Or cmb79.Name() Or cmb80.Name() Or cmb81.Name() Then
    '        deactivateSquareGroup(gbxNine, gbxTwo, gbxThree, gbxFour, gbxFive, gbxSix, gbxSeven, gbxEight, gbxOne)
    '    End If

    'End Sub

    'Public Sub replaySub()

    '    recordOfMoves.Enqueue("1")
    '    Dim recordOfMove As String

    '    'Reads all of the moves into the queue, from a file
    '    While gamerecordread.Peek() <> -1
    '        recordOfMoves.Enqueue(gamerecordread.ReadLine())
    '    End While



    '    While (recordOfMove = "1")


    '    End While

    'End Sub

    Private Sub UdnoToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles UdnoToolStripMenuItem.Click

        movetoundo = recordOfMoves.Pop

        Dim Obj As New ComboBox
        For Each elem In Me.Controls
            If elem.Name() = movetoundo Then
                Obj = elem
                Exit For
            End If
        Next

        Obj.ResetText()

        If CStr(Obj.Name()) = cmb1.Name() Or CStr(Obj.Name()) = cmb2.Name() Or CStr(Obj.Name()) = cmb3.Name() Or CStr(Obj.Name()) = cmb10.Name() Or CStr(Obj.Name()) = cmb11.Name() Or CStr(Obj.Name()) = cmb12.Name() Or CStr(Obj.Name()) = cmb19.Name() Or CStr(Obj.Name()) = cmb20.Name() Or CStr(Obj.Name()) = cmb21.Name() Then
            deactivateSquareGroup(gbxOne, gbxTwo, gbxThree, gbxFour, gbxFive, gbxSix, gbxSeven, gbxEight, gbxNine)
        ElseIf CStr(Obj.Name()) = cmb4.Name() Or CStr(Obj.Name()) = cmb5.Name() Or CStr(Obj.Name()) = cmb6.Name() Or CStr(Obj.Name()) = cmb13.Name() Or CStr(Obj.Name()) = cmb14.Name() Or CStr(Obj.Name()) = cmb15.Name() Or CStr(Obj.Name()) = cmb22.Name() Or CStr(Obj.Name()) = cmb23.Name() Or CStr(Obj.Name()) = cmb24.Name() Then
            deactivateSquareGroup(gbxTwo, gbxOne, gbxThree, gbxFour, gbxFive, gbxSix, gbxSeven, gbxEight, gbxNine)
        ElseIf CStr(Obj.Name()) = cmb7.Name() Or CStr(Obj.Name()) = cmb8.Name() Or CStr(Obj.Name()) = cmb9.Name() Or CStr(Obj.Name()) = cmb16.Name() Or CStr(Obj.Name()) = cmb17.Name() Or CStr(Obj.Name()) = cmb18.Name() Or CStr(Obj.Name()) = cmb25.Name() Or CStr(Obj.Name()) = cmb26.Name() Or CStr(Obj.Name()) = cmb27.Name() Then
            deactivateSquareGroup(gbxThree, gbxTwo, gbxOne, gbxFour, gbxFive, gbxSix, gbxSeven, gbxEight, gbxNine)
        ElseIf CStr(Obj.Name()) = cmb28.Name() Or CStr(Obj.Name()) = cmb29.Name() Or CStr(Obj.Name()) = cmb30.Name() Or CStr(Obj.Name()) = cmb37.Name() Or CStr(Obj.Name()) = cmb38.Name() Or CStr(Obj.Name()) = cmb39.Name() Or CStr(Obj.Name()) = cmb46.Name() Or CStr(Obj.Name()) = cmb47.Name() Or CStr(Obj.Name()) = cmb48.Name() Then
            deactivateSquareGroup(gbxFour, gbxTwo, gbxThree, gbxOne, gbxFive, gbxSix, gbxSeven, gbxEight, gbxNine)
        ElseIf CStr(Obj.Name()) = cmb31.Name() Or CStr(Obj.Name()) = cmb32.Name() Or CStr(Obj.Name()) = cmb33.Name() Or CStr(Obj.Name()) = cmb40.Name() Or CStr(Obj.Name()) = cmb41.Name() Or CStr(Obj.Name()) = cmb42.Name() Or CStr(Obj.Name()) = cmb49.Name() Or CStr(Obj.Name()) = cmb50.Name() Or CStr(Obj.Name()) = cmb51.Name() Then
            deactivateSquareGroup(gbxFive, gbxTwo, gbxThree, gbxOne, gbxFour, gbxSix, gbxSeven, gbxEight, gbxNine)
        ElseIf CStr(Obj.Name()) = cmb34.Name() Or CStr(Obj.Name()) = cmb35.Name() Or CStr(Obj.Name()) = cmb36.Name() Or CStr(Obj.Name()) = cmb43.Name() Or CStr(Obj.Name()) = cmb44.Name() Or CStr(Obj.Name()) = cmb45.Name() Or CStr(Obj.Name()) = cmb52.Name() Or CStr(Obj.Name()) = cmb53.Name() Or CStr(Obj.Name()) = cmb54.Name() Then
            deactivateSquareGroup(gbxSix, gbxTwo, gbxThree, gbxFour, gbxFive, gbxOne, gbxSeven, gbxEight, gbxNine)
        ElseIf CStr(Obj.Name()) = cmb55.Name() Or CStr(Obj.Name()) = cmb56.Name() Or CStr(Obj.Name()) = cmb57.Name() Or CStr(Obj.Name()) = cmb64.Name() Or CStr(Obj.Name()) = cmb65.Name() Or CStr(Obj.Name()) = cmb66.Name() Or CStr(Obj.Name()) = cmb73.Name() Or CStr(Obj.Name()) = cmb74.Name() Or CStr(Obj.Name()) = cmb75.Name() Then
            deactivateSquareGroup(gbxSeven, gbxTwo, gbxThree, gbxFour, gbxFive, gbxSix, gbxOne, gbxEight, gbxNine)
        ElseIf CStr(Obj.Name()) = cmb58.Name() Or CStr(Obj.Name()) = cmb59.Name() Or CStr(Obj.Name()) = cmb60.Name() Or CStr(Obj.Name()) = cmb67.Name() Or CStr(Obj.Name()) = cmb68.Name() Or CStr(Obj.Name()) = cmb69.Name() Or CStr(Obj.Name()) = cmb76.Name() Or CStr(Obj.Name()) = cmb77.Name() Or CStr(Obj.Name()) = cmb78.Name() Then
            deactivateSquareGroup(gbxEight, gbxTwo, gbxThree, gbxFour, gbxFive, gbxSix, gbxSeven, gbxOne, gbxNine)
        ElseIf CStr(Obj.Name()) = cmb61.Name() Or CStr(Obj.Name()) = cmb62.Name() Or CStr(Obj.Name()) = cmb63.Name() Or CStr(Obj.Name()) = cmb70.Name() Or CStr(Obj.Name()) = cmb71.Name() Or CStr(Obj.Name()) = cmb72.Name() Or CStr(Obj.Name()) = cmb79.Name() Or CStr(Obj.Name()) = cmb80.Name() Or CStr(Obj.Name()) = cmb81.Name() Then
            deactivateSquareGroup(gbxNine, gbxTwo, gbxThree, gbxFour, gbxFive, gbxSix, gbxSeven, gbxEight, gbxOne)
        End If
    End Sub
End Class
