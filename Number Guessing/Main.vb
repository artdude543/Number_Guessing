Public Class Main

    Dim generatedNumber As Integer
    Dim userGuesses As Integer
    Dim userCorrect As Boolean

    Friend Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtStatus.BackColor = Color.Yellow
        txtStatus.Text = "Ready!"

        cmdGiveUp.Enabled = False
        cmdReset.Enabled = False

        Randomize()
        generatedNumber = Int(Rnd() * 100) + 1

        txtUserGuess.Focus()

    End Sub

    Private Sub txtUserGuess_TextChanged(sender As Object, e As EventArgs) Handles txtUserGuess.TextChanged

        If IsNumeric(txtUserGuess.Text) Then



        ElseIf txtUserGuess.Text = "" Then



        Else

            MsgBox("Please enter a whole number!")
            txtUserGuess.Text = ""


        End If

    End Sub

    Private Sub cmdRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRun.Click

      
        If txtUserGuess.Text = "" Then

            MsgBox("Please type a guess!")

        Else

            Dim userGuess As Integer

            userGuess = Val(txtUserGuess.Text)
            txtTries.Text = Val(txtTries.Text) + 1

            txtLastGuess.Text = txtUserGuess.Text

            If userGuess < generatedNumber Then

                txtStatus.BackColor = Color.Red
                txtStatus.Text = "To Low!"
                userCorrect = False
                txtUserGuess.Text = ""

            ElseIf userGuess > generatedNumber Then

                txtStatus.BackColor = Color.Red
                txtStatus.Text = "To High!"
                userCorrect = False
                txtUserGuess.Text = ""

            Else

                txtStatus.BackColor = Color.GreenYellow
                txtStatus.Text = "Correct!"
                userCorrect = True
                cmdReset.Enabled = True
                txtUserGuess.Text = ""

            End If

            If txtTries.Text = "20" Then

                cmdGiveUp.Enabled = True
                cmdRun.Enabled = False

            Else

                cmdGiveUp.Enabled = False
                cmdRun.Enabled = True

            End If

        End If

    End Sub

    Private Sub cmdGiveUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGiveUp.Click

        txtUserGuess.Text = ""
        txtStatus.BackColor = Color.MediumPurple
        txtStatus.Text = "Given Up!"
        txtUserGuess.Text = ""
        userCorrect = True
        cmdReset.Enabled = True

        txtAnswer.Text = generatedNumber

    End Sub

    Private Sub cmdReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReset.Click

        If userCorrect = True Then

            Application.Restart()

        End If

    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click

        Application.Exit()

    End Sub

    Private Sub txtUserGuess_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUserGuess.KeyPress

        If Asc(e.KeyChar) = 13 Then

            cmdRun.PerformClick()

        End If

    End Sub

End Class