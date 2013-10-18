Public Class Main

    ' Setting Global Variables For The Application
    Dim generatedNumber As Integer
    Dim userGuesses As Integer
    Dim userCorrect As Boolean

    Friend Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Set the back color and set the text of the "Status" text box to show the user that the application is ready.
        txtStatus.BackColor = Color.Yellow
        txtStatus.Text = "Ready!"

        ' Disable these buttons so that they will be enabled later on after a set event happens.
        cmdGiveUp.Enabled = False
        cmdReset.Enabled = False

        ' This runs on runtime to randomize and set a vaiable that random number generated.
        Randomize()
        generatedNumber = Int(Rnd() * 100) + 1

        ' This sets the cursor to that the user can type straight away in the "User Guess" textbox.
        txtUserGuess.Focus()

    End Sub

    Private Sub txtUserGuess_TextChanged(sender As Object, e As EventArgs) Handles txtUserGuess.TextChanged

        ' This checks when a user types if they are entering a number or not, if they don't input a number a message box shows telling the user
        ' to type a number instead. This also cleans the "User Guess" textbox so that they can start again.
        If Val(txtUserGuess.Text) <= 100 Then

            If IsNumeric(txtUserGuess.Text) Then


            ElseIf txtUserGuess.Text.Contains(".") Then

                MsgBox("'" & txtUserGuess.Text & "'" & " This is not a valid input please enter a numeric number")
                txtUserGuess.Text = ""

            Else

                MsgBox("'" & txtUserGuess.Text & "'" & " This is not a valid input please enter a numberic number")
                txtUserGuess.Text = ""

            End If

        ElseIf Val(txtUserGuess.Text) > 100 Then

            MsgBox("Please enter a numeric number below 100")
            txtUserGuess.Text = ""

        End If

    End Sub

    Private Sub cmdRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRun.Click

        ' This checks if nothing has been entered into the "User Guess" textbox when the user clicks on the "Guess" button. If there is
        ' nothing inputed a message box appears telling to user to fix their mistake.
        If txtUserGuess.Text = "" Then

            MsgBox("Please type a guess!")

        Else

            ' This is setting the "userGuess" as an Integer so that we can store a number value to use during this session.
            Dim userGuess As Integer

            ' Here we are setting "userGess" as the value taken from the users input.
            userGuess = Val(txtUserGuess.Text)
            ' This adds an attempt each time the user clicks on "Guess"
            txtTries.Text = Val(txtTries.Text) + 1

            ' Here we are setting the "lastGuess" textbox from the value taken from the "userGuess" textbox.
            txtLastGuess.Text = txtUserGuess.Text

            ' Here we are checking if the user has guessed a number which is lower than the generated number, then we are setting the "Status" textbox
            ' to display that is "Too Low", then we set the "userGuess" textbox to clear out so the user can guess again.
            If userGuess < generatedNumber Then

                txtStatus.BackColor = Color.Red
                txtStatus.Text = "Too Low!"
                userCorrect = False
                txtUserGuess.Text = ""


                ' Here we are checking if the user has guessed a number which is higher than the generated number, then we are setting the "Status" textbox
                ' to display that is "Too High", then we set the "userGuess" textbox to clear out so the user can guess again.
            ElseIf userGuess > generatedNumber Then

                txtStatus.BackColor = Color.Red
                txtStatus.Text = "To High!"
                userCorrect = False
                txtUserGuess.Text = ""

            Else

                ' Here we are checking if the user has guessed a number which is the same (Equal Too) the generated number, then we are setting the "Status" textbox
                ' to display that is "Correct" then we are setting a value of "userCorrect" to true so that the program stops checking.
                txtStatus.BackColor = Color.GreenYellow
                txtStatus.Text = "Correct!"
                userCorrect = True
                cmdReset.Enabled = True
                txtUserGuess.Text = ""

                txtUserGuess.ReadOnly = True
                txtAnswer.Text = generatedNumber

            End If

            ' This tracks on how many attempts the user has had to guess the number, once they have gone over this the program enables the "Give Up" button
            ' to allow the user to stop playing and see the answer.
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

        ' This sets the "userGuess" textbox to nothing and then sets the "status" textbox to display that the user has given up, then it sets the "answer" textbox
        ' to show the number which was generated.
        txtUserGuess.Text = ""
        txtStatus.BackColor = Color.MediumPurple
        txtStatus.Text = "Given Up!"
        txtUserGuess.Text = ""
        userCorrect = True
        cmdReset.Enabled = True

        txtAnswer.Text = generatedNumber

    End Sub

    Private Sub cmdReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReset.Click

        ' This is only allowed to be run if the user has either "won" or "given up" then the program restarts to allow another go of the program.
        If userCorrect = True Then

            Application.Restart()

        End If

    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click

        ' This closes the application.
        Application.Exit()

    End Sub

    Private Sub txtUserGuess_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUserGuess.KeyPress

        ' This checks if the user has hit "Enter" then performs a virtal click on the "Guess" button.
        If Asc(e.KeyChar) = 13 Then

            cmdRun.PerformClick()

        End If

    End Sub

End Class