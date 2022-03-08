Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Double
        Dim b As Double
        Dim c As Double
        Dim d As Double

        a = TextBox1.Text
        b = a * 35
        TextBox2.Text = b




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim c As Double
        c = TextBox3.Text - TextBox2.Text
        TextBox4.Text = c

    End Sub
End Class
