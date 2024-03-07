Public Class Form8

    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form7.Hide()
    End Sub

    Private Sub Form8_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        If Me.Visible = True Then
            Form7.Hide()
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1.Show()
        Label1.Text = "رقمك هو"
        Label2.Text = 0
    End Sub

    Private Sub Label2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label2.TextChanged
        If Label2.Text >= 61 Or (Label2.Text <= 0) Then
            Label1.Text = "أنت مجنون"
        ElseIf Label2.Text <= 60 Or (Label2.Text >= 1) Then
            Label1.Text = "رقمك هو"
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub
End Class