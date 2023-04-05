' Name:         Validate Number Project
' Purpose:      Validate a 9-digit number.
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnValidate_Click(sender As Object, e As EventArgs) Handles btnValidate.Click
        Dim toCheck As String = txtNumber.Text
        Dim isValid As Boolean = True
        Dim EvenProd As Integer = Integer.Parse(toCheck.ElementAt(1))
        Dim acc As Integer = 0


        For index As Integer = 1 To 8 Step 2
            EvenProd = Integer.Parse(toCheck.ElementAt(index)) * 2
            If EvenProd > 9 Then
                Dim str As String = EvenProd.ToString()
                EvenProd = Integer.Parse(str.ElementAt(0)) + Integer.Parse(str.ElementAt(1))
            End If
            acc += EvenProd
        Next index
        acc += Integer.Parse(toCheck.ElementAt(0)) + Integer.Parse(toCheck.ElementAt(2)) + Integer.Parse(toCheck.ElementAt(4)) +
        Integer.Parse(toCheck.ElementAt(6)) + Integer.Parse(toCheck.ElementAt(8))
        If acc Mod 10 = 0 Then
            lblStatus.Text = "Valid"
        Else
            lblStatus.Text = "Not Valid"
        End If

    End Sub


End Class
