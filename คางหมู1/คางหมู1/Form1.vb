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
            Label7.Text = area
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txt_a1.Text = "" '
        txt_a2.Text = ""
        txt_high.Text = ""  '
        txt_a1.Focus()
        Label7.Text = "0.00"
    End Sub

    Private Sub btExit_Click(sender As Object, e As EventArgs) Handles btExit.Click
        Dim bt_Exit As MsgBoxResult
        bt_Exit = MsgBox("จบการทำงานใช่หรือไม่ ?", MsgBoxStyle.YesNo, "จบการทำงาน")
        If bt_Exit = MsgBoxResult.Yes Then
            MsgBox("เลิกการทำงาน.....", MsgBoxStyle.Exclamation, "จบการทำงาน")
            Application.Exit() '       แจ้งเตือนการจบการทำงาน กาว
        Else
            bt_Exit = MsgBoxResult.No
            Me.Close()
        End If
    End Sub
End Class
