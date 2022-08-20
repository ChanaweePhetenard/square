Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(txt_a1.Text) Or String.IsNullOrEmpty(txt_a2.Text) Or String.IsNullOrEmpty(txt_high.Text) Then
            MessageBox.Show("กรุณากรอกตัวเลข") ' 
        Else
            Dim a1, a2, high, area As Single '
            a1 = txt_a1.Text '
            a2 = txt_a2.Text '
            high = txt_high.Text ' 
            area = 0.5 * (a1 + a2) * high
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txt_a1.Text = "" '

        txt_high.Text = ""  '

    End Sub

    Private Sub btExit_Click(sender As Object, e As EventArgs) Handles btExit.Click
        Me.Close()
    End Sub
End Class
