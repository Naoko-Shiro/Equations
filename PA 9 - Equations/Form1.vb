Public Class Form1

    Dim Watermark As String = "Yes"
    Dim FG As Integer
    Dim P, G, L As Double

    Private Sub txtCurrentGrade_Enter(sender As Object, e As EventArgs) Handles txtCurrentGrade.Enter
        If Watermark = "Yes" Then
            txtCurrentGrade.Clear()
            txtCurrentGrade.ForeColor = Color.Black
            Watermark = "No"
        End If
        Watermark = "Yes"
    End Sub

    Private Sub txtFinalPercent_Enter(sender As Object, e As EventArgs) Handles txtFinalPercent.Enter
        If Watermark = "Yes" Then
            txtFinalPercent.Clear()
            txtFinalPercent.ForeColor = Color.Black
            Watermark = "No"
        End If
        Watermark = "Yes"
    End Sub

    Private Sub txtGradeWanted_Enter(sender As Object, e As EventArgs) Handles txtGradeWanted.Enter
        If Watermark = "Yes" Then
            txtGradeWanted.Clear()
            txtGradeWanted.ForeColor = Color.Black
            Watermark = "No"
        End If
        Watermark = "Yes"
    End Sub

    Private Sub butCalculate_MouseHover(sender As Object, e As EventArgs) Handles butCalculate.MouseHover
            butCalculate.BackColor = Color.White
    End Sub

    Private Sub butCalculate_MouseLeave(sender As Object, e As EventArgs) Handles butCalculate.MouseLeave
            butCalculate.BackColor = Color.Black
    End Sub

    Private Sub butCalculate_Click(sender As Object, e As EventArgs) Handles butCalculate.Click
        P = txtFinalPercent.Text / 100
        FG = txtGradeWanted.Text
        G = txtCurrentGrade.Text
        L = (FG - G + P * G) / P
        MessageBox.Show(L & "% is what you need on the final to achieve a " & FG & "% as a Final Grade.")
    End Sub
End Class
