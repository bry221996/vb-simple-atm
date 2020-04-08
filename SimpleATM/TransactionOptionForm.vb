Public Class TransactionOptionForm
    Private Sub Button_MouseEnter(sender As Button, e As EventArgs) Handles CheckBalanceButton.MouseEnter, DepositButton.MouseEnter, WithdrawButton.MouseEnter
        sender.BackColor = Color.FromArgb(96, 200, 137)
        sender.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub Button_MouseLeave(sender As Button, e As EventArgs) Handles CheckBalanceButton.MouseLeave, DepositButton.MouseLeave, WithdrawButton.MouseLeave
        sender.BackColor = Color.FromName("ButtonFace")
        sender.ForeColor = Color.FromArgb(53, 46, 65)
    End Sub
End Class