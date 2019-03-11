Public Class Incognito

    Private Sub RbhisRem_CheckedChanged(sender As Object, e As EventArgs) Handles RbHisRem.CheckedChanged
        If RbHisRem.Checked = True Then
            History.Visible = 1
        End If
    End Sub

    Private Sub RbNoHisRem_CheckedChanged(sender As Object, e As EventArgs) Handles RbNoHisRem.CheckedChanged
        If RbNoHisRem.Checked = True Then
            History.Visible = 0
        End If
    End Sub

End Class