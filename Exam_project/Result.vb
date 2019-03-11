Public Class Result

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Result_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label12.Text = (Val(Label10.Text) / Val(Label8.Text)) * 100

    End Sub
End Class