Public Class frmTranslator
    Private Function getLang_Tagalog() As String
        If radMother.Checked Then
            Return "Inay"
        ElseIf radFather.Checked Then
            Return "Ama"
        ElseIf radSister.Checked Then
            Return "Kuya"
        ElseIf radBrother.Checked Then
            Return "Ate"
        End If

    End Function
    Private Function getLang_Japanese() As String
        If radMother.Checked Then
            Return "母親
                    (Mother)"
        ElseIf radFather.Checked Then
            Return "お父さん
                    (Father)"
        ElseIf radSister.Checked Then
            Return "シスター
                    (Sister)"
        ElseIf radBrother.Checked Then
            Return "兄弟
                   (Brother)"
        End If
    End Function
    Private Function getLang_Chinese() As String
        If radMother.Checked Then
            Return "母親
                    (Mother)"
        ElseIf radFather.Checked Then
            Return "父親
                    (Father)"
        ElseIf radSister.Checked Then
            Return "姐姐
                    (Sister)"
        ElseIf radBrother.Checked Then
            Return "兄弟
                   (Brother)"
        End If
    End Function
    Private Sub btnTranslate_Click(sender As Object, e As EventArgs) Handles btnTranslate.Click
        Select Case getLang.SelectedItem
            Case "Tagalog"
                lblTranslated.Text = getLang_Tagalog()
            Case "Japanese"
                lblTranslated.Text = getLang_Japanese()
            Case "Chinese"
                lblTranslated.Text = getLang_Chinese()
        End Select

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub getLang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles getLang.SelectedIndexChanged
        lblTranslated.Text = String.Empty
    End Sub
End Class
