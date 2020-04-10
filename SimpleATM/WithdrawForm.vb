Public Class WithdrawForm

    Dim amount As Integer = 0
    Dim balance As Integer = 0

    Private Sub WithdrawForm_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        ResetAmount()
        ErrorMessage.Visible = False
        balance = MainForm.GetBalance()
    End Sub

    Private Sub InputNumberClick(sender As Label, e As EventArgs) Handles Input0.Click, Input1.Click, Input2.Click, Input3.Click, Input4.Click, Input5.Click, Input6.Click, Input7.Click, Input8.Click, Input9.Click
        ErrorMessage.Visible = False
        Dim amountString = ""
        If (amount) Then
            amountString = amount.ToString
        End If
        amountString = amountString + sender.Text
        amountDisplay.Text = amountString
        amount = Convert.ToInt32(amountString)
    End Sub

    Private Sub Input_MouseDown(sender As Label, e As MouseEventArgs) Handles Input0.MouseDown, Input1.MouseDown, Input2.MouseDown, Input3.MouseDown, Input4.MouseDown, Input5.MouseDown, Input6.MouseDown, Input7.MouseDown, Input8.MouseDown, Input9.MouseDown
        sender.BackColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub Inputs_MouseUp(sender As Label, e As MouseEventArgs) Handles InputClear.MouseUp, InputEnter.MouseUp, Input0.MouseUp, Input1.MouseUp, Input2.MouseUp, Input3.MouseUp, Input4.MouseUp, Input5.MouseUp, Input6.MouseUp, Input7.MouseUp, Input8.MouseUp, Input9.MouseUp
        sender.BackColor = Color.FromArgb(96, 200, 137)
    End Sub

    Private Sub InputEnter_MouseDown(sender As Label, e As MouseEventArgs) Handles InputEnter.MouseDown, InputClear.MouseDown
        If (amount) Then
            sender.BackColor = Color.FromArgb(255, 255, 255)
        End If
    End Sub

    Private Sub InputEnter_Click(sender As Object, e As EventArgs) Handles InputEnter.Click
        ErrorMessage.Visible = False
        If (amount) Then
            If (amount <= balance) Then
                MainForm.SubtractBalance(amount)
                Me.Hide()
                MainForm.DisplayPanel(SuccessfulMessage)
            Else
                ErrorMessage.Visible = True
            End If
        End If
    End Sub

    Private Sub InputClear_Click(sender As Object, e As EventArgs) Handles InputClear.Click
        ErrorMessage.Visible = False
        If (amount) Then
            ResetAmount()
        End If
    End Sub

    Private Sub ResetAmount()
        amount = 0
        amountDisplay.Text = ""
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