Public Class Q1

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = Label3.Text - 1
        If Label3.Text = 0 Then
            TextBox3.Text = 1
            Q2.TextBox1.Text = TextBox1.Text
            Q2.TextBox2.Text = TextBox2.Text
            Q2.TextBox3.Text = TextBox3.Text
            Q2.Show()
            Me.Close()

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = "5"
        TextBox2.Text = "1"
        Q2.TextBox1.Text = TextBox1.Text
        Q2.TextBox2.Text = TextBox2.Text
        Q2.TextBox3.Text = TextBox3.Text
        Q2.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox3.Text = "1"
        Q2.TextBox1.Text = TextBox1.Text
        Q2.TextBox2.Text = TextBox2.Text
        Q2.TextBox3.Text = TextBox3.Text
        Q2.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox3.Text = "1"
        Q2.TextBox1.Text = TextBox1.Text
        Q2.TextBox2.Text = TextBox2.Text
        Q2.TextBox3.Text = TextBox3.Text
        Q2.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox3.Text = "1"
        Q2.TextBox1.Text = TextBox1.Text
        Q2.TextBox2.Text = TextBox2.Text
        Q2.TextBox3.Text = TextBox3.Text
        Q2.Show()
        Me.Close()
    End Sub

    Private Sub Q1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class