Public Class MiniBrowser

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        WebBrowser1.GoBack()


    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        WebBrowser1.GoForward()


    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        WebBrowser1.Refresh()

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        WebBrowser1.GoSearch()
        WebBrowser1.Navigate(ToolStripTextBox1.Text)



    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        WebBrowser1.GoHome()

    End Sub

    Private Sub MiniBrowser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        WebBrowser1.Dock = DockStyle.Fill
        WebBrowser1.Navigate("www.google.com")

        ToolStripComboBox1.Items.Add("Google")
        ToolStripComboBox1.Items.Add("Youtube")
        ToolStripComboBox1.Items.Add("Wikipedia")

        ToolStripComboBox1.SelectedIndex = 0

        WebBrowser1.ScriptErrorsSuppressed = True

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        ToolStripTextBox1.Text = WebBrowser1.Url.ToString()
        My.Settings.History.Add(WebBrowser1.Url.ToString)
        History.ListBox1.Items.Add(WebBrowser1.Url.ToString)

        TabControl1.SelectedTab.Text = WebBrowser1.DocumentTitle.ToString

    End Sub
    Private Sub WebBrowser1_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles WebBrowser1.Navigating

        ToolStripProgressBar1.Visible = True
        With ToolStripProgressBar1
            .Minimum = 0
            .Maximum = 50
            .Step = 5
        End With
        For index As Integer = 0 To 50 Step 5
            ToolStripProgressBar1.Value = index
            System.Threading.Thread.Sleep(35)
        Next
    End Sub


    Private Sub HistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoryToolStripMenuItem.Click
        History.Visible = True
    End Sub

    Private Sub ToolStripTextBox2_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox2.KeyUp

        Select Case (ToolStripComboBox1.SelectedIndex)
            Case 0
                If e.KeyCode = Keys.Enter Then
                    WebBrowser1.Navigate("http://www.google.co.in/search?q=" + ToolStripTextBox2.Text)

                End If
            Case 1
                If e.KeyCode = Keys.Enter Then
                    WebBrowser1.Navigate("https://www.youtube.com/results?search_query=" + ToolStripTextBox2.Text)
                End If
            Case 2
                If e.KeyCode = Keys.Enter Then
                    WebBrowser1.Navigate("https://en.wikipedia.org/wiki/" + ToolStripTextBox2.Text)

                End If

        End Select
    End Sub

    Private Sub ToolStripTextBox1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox1.KeyUp

        Dim browser As webBrowserFunction = Me.TabControl1.SelectedTab.Tag
        If e.KeyCode = Keys.Enter Then
            browser.Navigate(ToolStripTextBox1.Text)

        End If

    End Sub

    Private Sub NewTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewTabToolStripMenuItem.Click
        addTab(TabControl1)


    End Sub

    Private Sub CloseTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseTabToolStripMenuItem.Click
        removeTab()

    End Sub

    Public Sub addTab(ByRef tabControl As TabControl)
        Dim browser As New webBrowserFunction
        Dim tab As New TabPage
        browser.Tag = tab
        tab.Tag = browser
        TabControl1.TabPages.Add(tab)
        tab.Controls.Add(browser)
        browser.Dock = DockStyle.Fill
        browser.Navigate("www.google.com")

        TabControl1.SelectedTab = tab
    End Sub

    Public Sub removeTab()
        If TabControl1.TabPages.Count <> 0 Then
            TabControl1.TabPages.Remove(TabControl1.SelectedTab)

        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Dim browser As webBrowserFunction = TabControl1.SelectedTab.Tag
        Try
            ToolStripTextBox1.Text = browser.Url.ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub NewWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewWindowToolStripMenuItem.Click
        Dim newwindow As New MiniBrowser
        newwindow.Show()

    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        ToolStripTextBox1.Undo()

    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        ToolStripTextBox1.ClearUndo()

    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        ToolStripTextBox1.Cut()

    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        ToolStripTextBox1.Copy()

    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        ToolStripTextBox1.Paste()

    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        ToolStripTextBox1.SelectAll()

    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        MsgBox("No Help,just google it")

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()


    End Sub

    Private Sub tmrDate_Tick(sender As Object, e As EventArgs) Handles tmrDate.Tick
        lbldate.Text = Now
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        Properties.Visible = True

    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        Dim psd As New PageSetupDialog

        Dim pd As New Printing.PrintDocument

        psd.Document = pd

        If psd.ShowDialog = Windows.Forms.DialogResult.OK Then

            PrintMiniBrowser.PrinterSettings = psd.PrinterSettings

            PrintMiniBrowser.PrinterSettings.DefaultPageSettings.PaperSize = psd.PrinterSettings.DefaultPageSettings.PaperSize

            If PrintMiniBrowser.PrinterSettings.IsValid Then

                PrintMiniBrowser.Print()
            End If
        End If

    End Sub

    Public Function PrintMiniBrowser() As Object
        Throw New NotImplementedException
    End Function

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        PrintMiniBrowser.Print()
    End Sub

    Private Sub CustomizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomizeToolStripMenuItem.Click
        Incognito.Visible = True
    End Sub
End Class
