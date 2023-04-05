' Name:         Zip Project
' Purpose:      Validate a ZIP code.
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtZip_Enter(sender As Object, e As EventArgs) Handles txtZip.Enter
        txtZip.SelectAll()
    End Sub

    Private Sub txtZip_TextChanged(sender As Object, e As EventArgs) Handles txtZip.TextChanged
        lblStatus.Text = String.Empty
    End Sub

    Private Sub txtZip_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtZip.KeyPress
        ' Allow only numbers and the Backspace key.

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        If (txtZip.Text.StartsWith("4") Or txtZip.Text.StartsWith("2") Or txtZip.Text.StartsWith("1") Or txtZip.Text.StartsWith("0")) And (txtZip.Text.EndsWith("2") Or txtZip.Text.EndsWith("3") Or txtZip.Text.EndsWith("4")) AndAlso txtZip.Text.Length = 4 Then
            lblStatus.Text = "Valid."
            txtZip.Focus()
        Else
            lblStatus.Text = "Not Valid."
            MessageBox.Show("Please input a Valid Zip.")
        End If

    End Sub
End Class
