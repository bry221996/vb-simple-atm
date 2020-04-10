Public Class CheckBalanceForm
    Private Sub CheckBalanceForm_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        BalanceText.Text = "PHP " + MainForm.GetBalance().ToString
    End Sub

    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles BackLabel.MouseEnter
        BackLabel.ForeColor = Color.FromArgb(96, 200, 137)
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles BackLabel.MouseLeave
        BackLabel.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles BackLabel.Click
        Me.Hide()
        MainForm.DisplayPanel(TransactionOptionForm)
    End Sub
End Class