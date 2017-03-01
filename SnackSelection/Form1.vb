Public Class frmSnackSelection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub



    Private Sub btnMiniPretzels_Click(sender As Object, e As EventArgs) Handles btnMiniPretzels.Click
        picMiniPretzels.Visible = True
        picSaltedPeanuts.Visible = False
        picCheeseNCrackers.Visible = False
        picChocChipCookies.Visible = False
        lblConfirmChoice.Visible = False
        btnConfirmSelection.Enabled = True

    End Sub

    Private Sub btnChocChipCookies_Click(sender As Object, e As EventArgs) Handles btnChocChipCookies.Click
        picChocChipCookies.Visible = True
        picCheeseNCrackers.Visible = False
        picMiniPretzels.Visible = False
        picSaltedPeanuts.Visible = False
        btnConfirmSelection.Enabled = True

    End Sub

    Private Sub btnCheeseNCrackers_Click(sender As Object, e As EventArgs) Handles btnCheeseNCrackers.Click
        picCheeseNCrackers.Visible = True
        picChocChipCookies.Visible = False
        picMiniPretzels.Visible = False
        picSaltedPeanuts.Visible = False
        btnConfirmSelection.Enabled = True

    End Sub

    Private Sub btnSaltedPeanuts_Click(sender As Object, e As EventArgs) Handles btnSaltedPeanuts.Click
        'This dispays the picture of the Salted Peanuts when the user selects the Salted Peanuts button 
        ' It also enables the confirm selection button and hides the CheeseNCrackers pic, ChocChipCoookies pic, MiniPretzels pic

        picSaltedPeanuts.Visible = True
        picCheeseNCrackers.Visible = False
        picChocChipCookies.Visible = False
        picMiniPretzels.Visible = False
        btnConfirmSelection.Enabled = True


    End Sub

    Private Sub btnConfirmSelection_Click(sender As Object, e As EventArgs) Handles btnConfirmSelection.Click
        'This shows the confirmation message when the user clicks confirm selection button
        'and disables the confirm selection button and the salted peanut button, mini pretzels button
        'chocolate chip cookies button, and the cheese and crackers button
        lblConfirmChoice.Visible = True
        btnConfirmSelection.Enabled = False
        btnCheeseNCrackers.Enabled = False
        btnChocChipCookies.Enabled = False
        btnMiniPretzels.Enabled = False
        btnSaltedPeanuts.Enabled = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'This Closes the program when the user clicks the exit window button on the form
        Close()

    End Sub
End Class
