' Name:         Woods Project
' Purpose:      Calculates the gross pay for salaried and hourly employees and displays a report.
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Displays the gross pay and a report.

        ' Declare variables.
        Dim ourEmployee As Employee
        Dim dblAnnualSalary As Double
        Dim dblHours As Double
        Dim dblHourRate As Double
        Dim dblGross As Double
        ' Instantiate and initialize an Employee object.
        ourEmployee = New Employee(txtNum.Text, txtName.Text.Trim)
        ' Determine the selected radio button.
        If radHourly.Checked Then
            'Calculate the gross pay for an hourly employee
            Double.TryParse(lstHours.SelectedItem.ToString, dblHours)
            Double.TryParse(lstRate.SelectedItem.ToString, dblHourRate)
            dblGross = ourEmployee.GetGross(dblHours, dblHourRate)
        Else
            'calculate the gross pay for a salaried employee
            Double.TryParse(lstSalary.SelectedItem.ToString, dblAnnualSalary)
            dblGross = ourEmployee.GetGross(dblAnnualSalary)
        End If

        ' Display the gross pay and report.
        lblGross.Text = dblGross.ToString("C2")
        txtReport.Text = txtReport.Text & ourEmployee.Number.PadRight(6) & ourEmployee.EmpName.PadRight(24) & dblGross.ToString("N2").PadLeft(9) & ControlChars.NewLine
        txtNum.Focus()
    End Sub

    Private Sub ClearGross(sender As Object, e As EventArgs) Handles lstHours.SelectedValueChanged,
            lstRate.SelectedValueChanged, txtNum.TextChanged, txtName.TextChanged
        lblGross.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtNum_Enter(sender As Object, e As EventArgs) Handles txtNum.Enter
        txtNum.SelectAll()
    End Sub

    Private Sub txtName_Enter(sender As Object, e As EventArgs) Handles txtName.Enter
        txtName.SelectAll()
    End Sub

    Private Sub radHourly_CheckedChanged(sender As Object, e As EventArgs) Handles radHourly.CheckedChanged
        ' Displays the labels and list boxes used to enter the number of hours worked and
        ' the rate of pay. Hides the label and list box used to enter the salary.

        lblGross.Text = String.Empty
        lblHoursId.Visible = True
        lstHours.Visible = True
        lblRateId.Visible = True
        lstRate.Visible = True
        lblSalaryId.Visible = False
        lstSalary.Visible = False
    End Sub

    Private Sub radSalaried_CheckedChanged(sender As Object, e As EventArgs) Handles radSalaried.CheckedChanged
        ' Displays the label and list box used to enter the salary. Hides the labels and  
        ' list boxes used to enter the number of hours worked and the rate of pay.

        lblGross.Text = String.Empty
        lblSalaryId.Visible = True
        lstSalary.Visible = True
        lblHoursId.Visible = False
        lstHours.Visible = False
        lblRateId.Visible = False
        lstRate.Visible = False
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Fills the list boxes with values and then selects a default item in each list box.

        For intSalary As Integer = 15000 To 35000 Step 1000
            lstSalary.Items.Add(intSalary.ToString)
        Next intSalary

        For dblHour As Double = 0.5 To 40 Step 0.5
            lstHours.Items.Add(dblHour.ToString("N1"))
        Next dblHour

        For dblRate As Double = 8 To 16 Step 0.5
            lstRate.Items.Add(dblRate.ToString("N2"))
        Next dblRate

        lstHours.SelectedItem = "40.0"
        lstRate.SelectedItem = "10.00"
        lstSalary.SelectedItem = "25000"
    End Sub
End Class
