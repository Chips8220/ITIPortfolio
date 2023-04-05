' Name:         Password Project
' Purpose:      Create a password.
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        ' Create a password.

        Dim strWords As String
        Dim strPassword As String = ""
        Dim intSpaceIndex As Integer

        strWords = txtWords.Text.Trim
        Dim wordArray() As String = Split(strWords)

        For Each str As String In wordArray
            strPassword += str(0)
        Next




        If strWords <> String.Empty Then
            ' Assign the first character as the password.
            strPassword = strWords(0)
            ' Search for the first space in the input.
            intSpaceIndex = strWords.IndexOf(" ")
            Do Until intSpaceIndex = -1
                ' Concatenate the character that follows 
                ' the space to the password.
                strPassword = strPassword & strWords(intSpaceIndex + 1)
                ' Search for the next space.
                intSpaceIndex = strWords.IndexOf(" ", intSpaceIndex + 1)
            Loop
            Dim firstupper As Boolean = strPassword(0) Like "[A-Z]"
            For index As Integer = 1 To strPassword.Length - 1
                Dim temp As Char
                If firstupper Then
                    temp = Char.ToLower(strPassword(index))
                Else
                    temp = Char.ToUpper(strPassword(index))
                End If
                strPassword = strPassword.Remove(index, 1)
                strPassword = strPassword.Insert(index, temp.ToString())
                firstupper = Not firstupper
            Next

            lblPassword.Text = strPassword
            ' Insert the number after the first character. 
            strPassword = strPassword.Insert(1, strPassword.Length.ToString)
            ' Display the final password.
            lblPassword.Text = strPassword
        End If
    End Sub

    Private Sub txtWords_Enter(sender As Object, e As EventArgs) Handles txtWords.Enter
        txtWords.SelectAll()
    End Sub

    Private Sub txtWords_TextChanged(sender As Object, e As EventArgs) Handles txtWords.TextChanged
        lblPassword.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
