Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim q, a, fac, fib, kuad As Integer
        q = TextBox1.Text

        fac = 1
        For a = 1 To q
            fac = a * fac
            TextBox2.Text = fac

        Next

        fib = 0
        For a = 1 To q
            fib = a + fib
            TextBox3.Text = fib
        Next


        kuad = q * q

        TextBox4.Text = kuad

    End Sub
End Class