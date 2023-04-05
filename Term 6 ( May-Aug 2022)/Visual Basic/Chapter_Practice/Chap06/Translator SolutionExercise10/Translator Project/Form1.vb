Public Class frmTranslator
    Private Sub getLang_Tagalog()
        If radMother.Checked Then
            lblTranslated.Text = "Inay"
        ElseIf radFather.Checked Then
            lblTranslated.Text = "Ama"
        ElseIf radSister.Checked Then
            lblTranslated.Text = "Kuya"
        ElseIf radBrother.Checked Then
            lblTranslated.Text = "Ate"
        End If

    End Sub
    Private Function getLang_Japanese()
        If radMother.Checked Then
            lblTranslated.Text = "母親
                                 (Mother)"
        ElseIf radFather.Checked Then
            lblTranslated.Text = "お父さん
                                 (Father)"
        ElseIf radSister.Checked Then
            lblTranslated.Text = "シスター
                                (Sister)"
        ElseIf radBrother.Checked Then
            lblTranslated.Text = "兄弟
                                 (Brother)"
        End If
    End Function
    Private Function getLang_Chinese()
        If radMother.Checked Then
            lblTranslated.Text = "母親
                                 (Mother)"
        ElseIf radFather.Checked Then
            lblTranslated.Text = "父親
                                 (Father)"
        ElseIf radSister.Checked Then
            lblTranslated.Text = "姐姐
                                 (Sister)"
        ElseIf radBrother.Checked Then
            lblTranslated.Text = "兄弟
                                 (Brother)"
        End If
    End Function
    Private Sub btnTranslate_Click(sender As Object, e As EventArgs) Handles btnTranslate.Click
        Select Case getLang.SelectedItem
            Case "Tagalog"
                getLang_Tagalog()
            Case "Japanese"
                getLang_Japanese()
            Case "Chinese"
                getLang_Chinese()
        End Select

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub getLang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles getLang.SelectedIndexChanged
        lblTranslated.Text = String.Empty
    End Sub
End Class
