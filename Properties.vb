
Imports System.Net.Mail
Public Class Properties

    Private Sub Properties_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim process As New Process
            process.StartInfo.UseShellExecute = False
            process.StartInfo.RedirectStandardOutput = True

            Try
                process.StartInfo.FileName = "ipconfig"
                process.StartInfo.Arguments = "/all"
                process.StartInfo.CreateNoWindow = True
                process.Start()
                txtnetwork.Text = txtnetwork.Text + Replace(process.StandardOutput.ReadToEnd, Chr(13) & Chr(13), Chr(13))
                process.WaitForExit()
            Catch ex As Exception
            End Try
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim Message As New MailMessage
            Message.From = New MailAddress(txtmail.Text)
            Message.To.Add(txttomail.Text)
            Message.Subject = subject.Text
            Message.Body = body.Text

            Dim SMTP As New SmtpClient("smtp.gmail.com")
            SMTP.Port = 587
            SMTP.EnableSsl = True
            SMTP.Credentials = New System.Net.NetworkCredential(txtmail.Text, password.Text)
            SMTP.Send(Message)
            MsgBox("Mail Sent Successfully")
            txtmail.Clear()
            txttomail.Clear()
            password.Clear()
            subject.Clear()
            body.Clear()


        Catch ex As Exception
            MsgBox(ex.ToString)
            txtmail.Clear()
            txttomail.Clear()
            password.Clear()
            subject.Clear()
            body.Clear()

        End Try

    End Sub
End Class
