Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        For i = 1 To 3
            ComboBox1.Items.Add(i)
        Next
    End Sub

    Dim PK As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex = 1 Then
            PK = "INF"
        ElseIf ComboBox1.SelectedIndex = 2 Then
            PK = "TEK"
        ElseIf ComboBox1.SelectedIndex = 3 Then
            PK = "KMN"
        End If
        TextBox3.Text = TextBox1.Text & ", Program Keahlian anda " & PK
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
    End Sub

End Class
