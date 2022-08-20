Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a1, a2, high, area As Single '
        a1 = txt_a1.Text '
        a2 = txt_a2.Text '
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txt_a1.Text = "" '

        txt_high.Text = ""  '

    End Sub

    Private Sub btExit_Click(sender As Object, e As EventArgs) Handles btExit.Click
        Me.Close()
    End Sub
End Class
