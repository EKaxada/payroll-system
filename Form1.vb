Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tax As Integer
        Dim rent As Integer
        Dim ans As Integer
        Dim deduc As Integer
        Dim net As Integer
        ans = ((TextBox3.Text * TextBox4.Text) * (TextBox2.Text))
        TextBox5.Text = ans
        tax = ans * 0.18
        TextBox6.Text = tax
        rent = ans * 0.05
        TextBox7.Text = rent
        deduc = tax + rent
        TextBox8.Text = deduc
        TextBox10.Text = deduc
        TextBox9.Text = ans

        net = TextBox9.Text - TextBox10.Text
        TextBox11.Text = net

    End Sub
End Class
