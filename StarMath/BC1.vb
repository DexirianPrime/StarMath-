Public Class BC1



    Dim i As Integer

    Dim Userint As Integer

    Dim i2 As Integer

    Dim Userint2 As Integer






    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Selector.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmFleet.Show()
        Me.Hide()
        attacktype = "raid"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmFleet.Show()
        Me.Hide()
        attacktype = "assault"
    End Sub

    Private Sub BC1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BC1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Selector.Close()
    End Sub
End Class