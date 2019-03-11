Public Class Q2

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = Label3.Text - 1
        If Label3.Text = 0 Then
            TextBox3.Text = 1
            Q3.TextBox1.Text = TextBox1.Text
            Q3.TextBox2.Text = TextBox2.Text
            Q3.TextBox3.Text = TextBox3.Text
            Q3.Show()
            Me.Close()

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox3.Text = Val(TextBox3.Text) + 1
        Q3.TextBox1.Text = TextBox1.Text
        Q3.TextBox2.Text = TextBox2.Text
        Q3.TextBox3.Text = TextBox3.Text
        Q3.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox3.Text = Val(TextBox3.Text) + 1
        Q3.TextBox1.Text = TextBox1.Text
        Q3.TextBox2.Text = TextBox2.Text
        Q3.TextBox3.Text = TextBox3.Text
        Q3.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = Val(TextBox1.Text) + 5
        TextBox2.Text = Val(TextBox2.Text) + 1
        Q3.TextBox1.Text = TextBox1.Text
        Q3.TextBox2.Text = TextBox2.Text
        Q3.TextBox3.Text = TextBox3.Text
        Q3.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox3.Text = Val(TextBox3.Text) + 1
        Q3.TextBox1.Text = TextBox1.Text
        Q3.TextBox2.Text = TextBox2.Text
        Q3.TextBox3.Text = TextBox3.Text
        Q3.Show()
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Q2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class