Public Class Form3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        Dim i As Byte
        For i = 1 To 3
            ListBox1.Items.Add(i)
        Next
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.Text = "1" Then
            TextBox1.Text = "MOTOR"
        ElseIf ListBox1.Text = "2" Then
            TextBox1.Text = "MOBIL"
        ElseIf ListBox1.Text = "3" Then
            TextBox1.Text = "MOBIL BOX"
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ComboBox2.Items.Clear()
        Dim a As Byte
        Do While a < 4
            a = a + 1
            ComboBox2.Items.Add(a)
        Loop
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Select Case ComboBox2.Text
            Case 1
                TextBox3.Text = 2000
            Case 2
                TextBox3.Text = 5000
            Case 3
                TextBox3.Text = 10000
        End Select
    End Sub
End Class

