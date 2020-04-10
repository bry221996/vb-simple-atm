Public Class TransactionOptionForm
    Private Sub Button_MouseEnter(sender As Button, e As EventArgs) Handles CheckBalanceButton.MouseEnter, DepositButton.MouseEnter, WithdrawButton.MouseEnter
        sender.BackColor = Color.FromArgb(96, 200, 137)
        sender.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub Button_MouseLeave(sender As Button, e As EventArgs) Handles CheckBalanceButton.MouseLeave, DepositButton.MouseLeave, WithdrawButton.MouseLeave
        sender.BackColor = Color.FromName("ButtonFace")
        sender.ForeColor = Color.FromArgb(53, 46, 65)
    End Sub

    Private Sub CheckBalanceButton_Click(sender As Object, e As EventArgs) Handles CheckBalanceButton.Click
        Me.Hide()
        MainForm.DisplayPanel(CheckBalanceForm)
    End Sub

    Private Sub BackLabel_MouseEnter(sender As Object, e As EventArgs) Handles BackLabel.MouseEnter
        BackLabel.ForeColor = Color.FromArgb(96, 200, 137)
    End Sub

    Private Sub BackLabel_MouseLeave(sender As Object, e As EventArgs) Handles BackLabel.MouseLeave
        BackLabel.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles BackLabel.Click
        Me.Hide()
        MainForm.Hide()
        PinForm.Show()
    End Sub

    Private Sub DepositButton_Click(sender As Object, e As EventArgs) Handles DepositButton.Click
        Me.Hide()
        MainForm.DisplayPanel(DepositForm)
    End Sub

    Private Sub WithdrawButton_Click(sender As Object, e As EventArgs) Handles WithdrawButton.Click
        Me.Hide()
        MainForm.DisplayPanel(WithdrawForm)
    End Sub
End Class