Public Class MainForm
    Dim Balance As Integer = 0

    Private Sub MainForm_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        DisplayPanel(TransactionOptionForm)
    End Sub

    Public Sub DisplayPanel(panel As Form)
        MainPanel.Controls.Clear()
        panel.TopLevel = False
        panel.Show()
        MainPanel.Controls.Add(panel)
    End Sub

    Function GetBalance()
        Return Balance
    End Function

    Public Sub AddBalance(amount As Integer)
        Balance = Balance + amount
    End Sub

    Public Sub SubtractBalance(amount As Integer)
        Balance = Balance - amount
    End Sub
End Class