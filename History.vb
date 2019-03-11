Public Class History

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MiniBrowser.WebBrowser1.Navigate(ListBox1.SelectedItem)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.History.Remove(ListBox1.SelectedItem)
        ListBox1.Items.Remove(ListBox1.SelectedItem)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Settings.History.Clear()
        ListBox1.Items.Clear()
    End Sub

    Private Sub History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Visible = False

    End Sub
End Class