Public Class webBrowserFunction
    Inherits WebBrowser

    Private Sub webBrowserDocCompl() Handles Me.DocumentCompleted
        Dim tabpage As TabPage = Me.Tag
        Dim MiniBrowser As New MiniBrowser
        tabpage.Text = Me.DocumentTitle
        MiniBrowser.ToolStripTextBox1.Text = Me.Url.ToString
    End Sub

    Public Sub New()
        Me.ScriptErrorsSuppressed = True

    End Sub
End Class
