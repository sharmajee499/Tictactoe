Public Class Form1


    'this click count will help to alter the options of mark and circle. if first btn clicked is circle than another will be mark. 
    Dim clickcount As Integer = 1

    'function to check the click count
    Private Function clickbtn(clickcount As Integer) As Boolean
        If (clickcount Mod 2 = 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    ' if the clickcount is odd than it will be mark and circle if it's odd. in other words if the boolean value is true it's circle and if false mark. 

    'function to check the value in the button
    Private Function check_values(first_button As String, second_button As String, third_button As String) As Boolean
        Dim result As Boolean
        If ((first_button = "Circle") And (second_button = "Circle") And (third_button = "Circle")) Then
            result = True
        ElseIf ((first_button = "Mark") And (second_button = "Mark") And (third_button = "Mark")) Then
            result = True
        End If

        Return result

    End Function



    Private Sub btn_1_Click(sender As Object, e As EventArgs) Handles btn_1.Click

        'the below if statement will show the name on button. Mean it will show either mark or circle on name. 

        If clickbtn(clickcount) = True Then
            btn_1.Text = "Circle"
            btn_1.BackColor = Color.DarkOrange


        Else
            btn_1.Text = "Mark"
            btn_1.BackColor = Color.Crimson


        End If

        'these apperence will change when the button is clicked
        btn_1.Enabled = False

        'when the button is clicked it will increase the count by 1.
        clickcount = clickcount + 1

        'below if statment checks the winner 
        If check_values(btn_1.Text, btn_2.Text, btn_3.Text) = True Then
            MessageBox.Show("The last person who clicked the button won the game. Click Reset button to start again", "WINNER WINNER Chicken Dinner", MessageBoxButtons.OK)

        End If

        If check_values(btn_1.Text, btn_4.Text, btn_7.Text) = True Then
            MessageBox.Show("The last person who clicked the button won the game. Click Reset button to start again", "WINNER WINNER Chicken Dinner", MessageBoxButtons.OK)

        End If

        If check_values(btn_1.Text, btn_5.Text, btn_9.Text) = True Then
            MessageBox.Show("The last person who clicked the button won the game. Click Reset button to start again", "WINNER WINNER Chicken Dinner", MessageBoxButtons.OK)

        End If

    End Sub

    Private Sub btn_2_Click(sender As Object, e As EventArgs) Handles btn_2.Click
        'the below if statement will show the name on button. Mean it will show either mark or circle on name. 
        If clickbtn(clickcount) = True Then
            btn_2.Text = "Circle"
            btn_2.BackColor = Color.DarkOrange

        Else
            btn_2.Text = "Mark"
            btn_2.BackColor = Color.Crimson
        End If

        'these apperence will change when the button is clicked
        btn_2.Enabled = False

        'when the button is clicked it will increase the count by 1.
        clickcount = clickcount + 1

        'below if statment checks the winner 
        If check_values(btn_1.Text, btn_2.Text, btn_3.Text) = True Then
            MessageBox.Show("The last person who clicked the button won the game. Click Reset button to start again", "WINNER WINNER Chicken Dinner", MessageBoxButtons.OK)

        End If

        If check_values(btn_2.Text, btn_1.Text, btn_3.Text) = True Then
            MessageBox.Show("The last person who clicked the button won the game. Click Reset button to start again", "WINNER WINNER Chicken Dinner", MessageBoxButtons.OK)

        End If

        If check_values(btn_2.Text, btn_5.Text, btn_8.Text) = True Then
            MessageBox.Show("The last person who clicked the button won the game. Click Reset button to start again", "WINNER WINNER Chicken Dinner", MessageBoxButtons.OK)

        End If


    End Sub

    Private Sub btn_3_Click(sender As Object, e As EventArgs) Handles btn_3.Click
        'the below if statement will show the name on button. Mean it will show either mark or circle on name. 
        If clickbtn(clickcount) = True Then
            btn_3.Text = "Circle"
            btn_3.BackColor = Color.DarkOrange

        Else
            btn_3.Text = "Mark"
            btn_3.BackColor = Color.Crimson
        End If

        'these apperence will change when the button is clicked
        btn_3.Enabled = False

        'when the button is clicked it will increase the count by 1.
        clickcount = clickcount + 1


        'below if statment checks the winner 
        If check_values(btn_1.Text, btn_2.Text, btn_3.Text) = True Then
            MessageBox.Show("The last person who clicked the button won the game. Click Reset button to start again", "WINNER WINNER Chicken Dinner", MessageBoxButtons.OK)

        End If

        If check_values(btn_3.Text, btn_6.Text, btn_9.Text) = True Then
            MessageBox.Show("The last person who clicked the button won the game. Click Reset button to start again", "WINNER WINNER Chicken Dinner", MessageBoxButtons.OK)

        End If

        If check_values(btn_3.Text, btn_5.Text, btn_7.Text) = True Then
            MessageBox.Show("The last person who clicked the button won the game. Click Reset button to start again", "WINNER WINNER Chicken Dinner", MessageBoxButtons.OK)

        End If

    End Sub

    Private Sub btn_4_Click(sender As Object, e As EventArgs) Handles btn_4.Click
        'the below if statement will show the name on button. Mean it will show either mark or circle on name. 
        If clickbtn(clickcount) = True Then
            btn_4.Text = "Circle"
            btn_4.BackColor = Color.DarkOrange
        Else
            btn_4.Text = "Mark"
            btn_4.BackColor = Color.Crimson
        End If

        'these apperence will change when the button is clicked
        btn_4.Enabled = False

        'when the button is clicked it will increase the count by 1.
        clickcount = clickcount + 1

        'below if statment checks the winner 
        If check_values(btn_1.Text, btn_4.Text, btn_7.Text) = True Then
            MessageBox.Show("The last person who clicked the button won the game. Click Reset button to start again", "WINNER WINNER Chicken Dinner", MessageBoxButtons.OK)

        End If

        If check_values(btn_4.Text, btn_5.Text, btn_6.Text) = True Then
            MessageBox.Show("The last person who clicked the button won the game. Click Reset button to start again", "WINNER WINNER Chicken Dinner", MessageBoxButtons.OK)

        End If

    End Sub

    Private Sub btn_5_Click(sender As Object, e As EventArgs) Handles btn_5.Click
        'the below if statement will show the name on button. Mean it will show either mark or circle on name. 
        If clickbtn(clickcount) = True Then
            btn_5.Text = "Circle"
            btn_5.BackColor = Color.DarkOrange

        Else
            btn_5.Text = "Mark"
            btn_5.BackColor = Color.Crimson
        End If

        'these apperence will change when the button is clicked
        btn_5.Enabled = False

        'when the button is clicked it will increase the count by 1.
        clickcount = clickcount + 1

        'below if statment checks the winner 
        If check_values(btn_1.Text, btn_5.Text, btn_9.Text) = True Then
            MessageBox.Show("The last person who clicked the button won the game. Click Reset button to start again", "WINNER WINNER Chicken Dinner", MessageBoxButtons.OK)

        End If

        If check_values(btn_3.Text, btn_5.Text, btn_7.Text) = True Then
            MessageBox.Show("The last person who clicked the button won the game. Click Reset button to start again", "WINNER WINNER Chicken Dinner", MessageBoxButtons.OK)

        End If

        If check_values(btn_4.Text, btn_5.Text, btn_6.Text) = True Then
            MessageBox.Show("The last person who clicked the button won the game. Click Reset button to start again", "WINNER WINNER Chicken Dinner", MessageBoxButtons.OK)

        End If

    End Sub

    Private Sub btn_6_Click(sender As Object, e As EventArgs) Handles btn_6.Click
        'the below if statement will show the name on button. Mean it will show either mark or circle on name. 
        If clickbtn(clickcount) = True Then
            btn_6.Text = "Circle"
            btn_6.BackColor = Color.DarkOrange

        Else
            btn_6.Text = "Mark"
            btn_6.BackColor = Color.Crimson
        End If

        'these apperence will change when the button is clicked
        btn_6.Enabled = False

        'when the button is clicked it will increase the count by 1.
        clickcount = clickcount + 1

        'below if statment checks the winner 
        If check_values(btn_3.Text, btn_6.Text, btn_9.Text) = True Then
            MessageBox.Show("The last person who clicked the button won the game. Click Reset button to start again", "WINNER WINNER Chicken Dinner", MessageBoxButtons.OK)
        End If

        If check_values(btn_4.Text, btn_5.Text, btn_6.Text) = True Then
            MessageBox.Show("The last person who clicked the button won the game. Click Reset button to start again", "WINNER WINNER Chicken Dinner", MessageBoxButtons.OK)
        End If

    End Sub

    Private Sub btn_7_Click(sender As Object, e As EventArgs) Handles btn_7.Click
        'the below if statement will show the name on button. Mean it will show either mark or circle on name. 
        If clickbtn(clickcount) = True Then
            btn_7.Text = "Circle"
            btn_7.BackColor = Color.DarkOrange

        Else
            btn_7.Text = "Mark"
            btn_7.BackColor = Color.Crimson
        End If

        'these apperence will change when the button is clicked
        btn_7.Enabled = False

        'when the button is clicked it will increase the count by 1.
        clickcount = clickcount + 1

        'below if statment checks the winner 
        If check_values(btn_1.Text, btn_4.Text, btn_7.Text) = True Then
            MessageBox.Show("The last person who clicked the button won the game. Click Reset button to start again", "WINNER WINNER Chicken Dinner", MessageBoxButtons.OK)
        End If

        If check_values(btn_3.Text, btn_5.Text, btn_7.Text) = True Then
            MessageBox.Show("The last person who clicked the button won the game. Click Reset button to start again", "WINNER WINNER Chicken Dinner", MessageBoxButtons.OK)
        End If

        If check_values(btn_7.Text, btn_8.Text, btn_9.Text) = True Then
            MessageBox.Show("The last person who clicked the button won the game. Click Reset button to start again", "WINNER WINNER Chicken Dinner", MessageBoxButtons.OK)
        End If

    End Sub

    Private Sub btn_8_Click(sender As Object, e As EventArgs) Handles btn_8.Click
        'the below if statement will show the name on button. Mean it will show either mark or circle on name. 
        If clickbtn(clickcount) = True Then
            btn_8.Text = "Circle"
            btn_8.BackColor = Color.DarkOrange

        Else
            btn_8.Text = "Mark"
            btn_8.BackColor = Color.Crimson
        End If

        'these apperence will change when the button is clicked
        btn_8.Enabled = False

        'when the button is clicked it will increase the count by 1.
        clickcount = clickcount + 1

        'below if statment checks the winner 
        If check_values(btn_2.Text, btn_5.Text, btn_8.Text) = True Then
            MessageBox.Show("The last person who clicked the button won the game. Click Reset button to start again", "WINNER WINNER Chicken Dinner", MessageBoxButtons.OK)
        End If

        If check_values(btn_7.Text, btn_8.Text, btn_9.Text) = True Then
            MessageBox.Show("The last person who clicked the button won the game. Click Reset button to start again", "WINNER WINNER Chicken Dinner", MessageBoxButtons.OK)
        End If

    End Sub

    Private Sub btn_9_Click(sender As Object, e As EventArgs) Handles btn_9.Click
        'the below if statement will show the name on button. Mean it will show either mark or circle on name. 
        If clickbtn(clickcount) = True Then
            btn_9.Text = "Circle"
            btn_9.BackColor = Color.DarkOrange

        Else
            btn_9.Text = "Mark"
            btn_9.BackColor = Color.Crimson
        End If

        'these apperence will change when the button is clicked
        btn_9.Enabled = False

        'when the button is clicked it will increase the count by 1.
        clickcount = clickcount + 1

        'below if statment checks the winner 
        If check_values(btn_1.Text, btn_5.Text, btn_9.Text) = True Then
            MessageBox.Show("The last person who clicked the button won the game. Click Reset button to start again", "WINNER WINNER Chicken Dinner", MessageBoxButtons.OK)
        End If

        If check_values(btn_3.Text, btn_6.Text, btn_9.Text) = True Then
            MessageBox.Show("The last person who clicked the button won the game. Click Reset button to start again", "WINNER WINNER Chicken Dinner", MessageBoxButtons.OK)
        End If

        If check_values(btn_7.Text, btn_8.Text, btn_9.Text) = True Then
            MessageBox.Show("The last person who clicked the button won the game. Click Reset button to start again", "WINNER WINNER Chicken Dinner", MessageBoxButtons.OK)
        End If

    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        Controls.Clear()
        InitializeComponent()

    End Sub


End Class
