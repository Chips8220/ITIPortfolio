﻿' Name:         Concert Project
' Purpose:      Displays the subtotal, discount, and total due for concert tickets.
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    ' Independent Sub procedure.
    Private Sub CalcDiscount(ByVal intNum As Integer, ByVal DblBeforeDiscount As Double, ByRef dblDisc As Double)

        Select Case intNum
            Case Is >= 10
                dblDisc = DblBeforeDiscount * 0.1
            Case Is >= 5
                dblDisc = DblBeforeDiscount * 0.05
            Case Else
                dblDisc = 0
        End Select
    End Sub


    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Display subtotal, discount, and total due.

        Const dblSTANDARD As Double = 62.5
        Const dblVIP As Double = 102.75
        Dim intTickets As Integer
        Dim dblSubtotal As Double
        Dim dblDiscount As Double
        Dim dblTotalDue As Double

        Integer.TryParse(txtTickets.Text, intTickets)

        ' Calculate the subtotal.
        If radStandard.Checked Then
            dblSubtotal = intTickets * dblSTANDARD
        Else
            dblSubtotal = intTickets * dblVIP
        End If

        ' Use a procedure to calculate the discount.
        CalcDiscount(intTickets, dblSubtotal, dblDiscount)

        ' Calculate the total due.
        dblSubtotal = Math.Round(dblSubtotal, 2)
        dblDiscount = Math.Round(dblDiscount, 2)
        dblTotalDue = dblSubtotal - dblDiscount

        lblSubtotal.Text = dblSubtotal.ToString("N2")
        lblDiscount.Text = dblDiscount.ToString("N2")
        lblTotalDue.Text = dblTotalDue.ToString("N2")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtTickets_Enter(sender As Object, e As EventArgs) Handles txtTickets.Enter
        txtTickets.SelectAll()
    End Sub

    Private Sub txtTickets_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTickets.KeyPress
        ' Accept only only numbers and the Backspace key.

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs) Handles txtTickets.TextChanged, radStandard.CheckedChanged, radVip.CheckedChanged
        lblSubtotal.Text = String.Empty
        lblDiscount.Text = String.Empty
        lblTotalDue.Text = String.Empty
    End Sub
End Class
