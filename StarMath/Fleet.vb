Public Class Fleet


    Dim i As Integer
    Dim i2 As Integer

    Private Sub cbfleet1type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbfleet1type.SelectedIndexChanged
        fleet1type = cbfleet1type.SelectedItem
    End Sub

    Private Sub tbfleet1size_TextChanged(sender As Object, e As EventArgs) Handles tbfleet1size.TextChanged
        Try
            i = Integer.Parse(tbfleet1size.Text, Globalization.NumberStyles.Any)
        Catch ex As Exception
            Dim ToolTip1 As New ToolTip
            ToolTip1.IsBalloon = True
            ToolTip1.UseFading = True
            ToolTip1.ToolTipIcon = ToolTipIcon.Error
            ToolTip1.ToolTipTitle = "Please enter a number between 1 and 1500"
            ToolTip1.Show("Style is not an Integer value", tbfleet1size, New Point(0, -80), 2500)
            tbfleet1size.Text = ""
        End Try
        If i >= 1 AndAlso i <= 1500 Then
            fleet1count = i
            Me.Text = fleet1count.ToString
        Else
            Dim ToolTip1 As New ToolTip
            ToolTip1.IsBalloon = True
            ToolTip1.UseFading = True
            ToolTip1.ToolTipIcon = ToolTipIcon.Error
            ToolTip1.ToolTipTitle = "Please enter a number between 1 and 1500"
            ToolTip1.Show("Value was out of range", tbfleet1size, New Point(0, -80), 2500)
            tbfleet1size.Text = ""
        End If
    End Sub

    Private Sub cbfleet1hard_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbfleet1hard.SelectedIndexChanged
        fleet1hard = cbfleet1hard.SelectedItem
    End Sub

    Private Sub cbfleet1hull_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbfleet1hull.SelectedIndexChanged
        fleet1hull = cbfleet1hull.SelectedItem
    End Sub

    Private Sub cbfleet1card_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbfleet1card.SelectedIndexChanged
        fleet1card = cbfleet1card.SelectedItem
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        BC1.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        DefFleet.Show()
    End Sub

    Private Sub cbfleet2type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbfleet2type.SelectedIndexChanged
        fleet2type = cbfleet2type.SelectedItem
    End Sub

    Private Sub cbfleet2hull_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbfleet2hull.SelectedIndexChanged
        fleet2hull = cbfleet2hull.SelectedItem

    End Sub

    Private Sub cbfleet2hard_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbfleet2hard.SelectedIndexChanged
        fleet2hard = cbfleet2hard.SelectedItem
    End Sub

    Private Sub tbfleet2size_TextChanged(sender As Object, e As EventArgs) Handles tbfleet2size.TextChanged
        Try
            i2 = Integer.Parse(tbfleet2size.Text, Globalization.NumberStyles.Any)
        Catch ex As Exception
            Dim ToolTip1 As New ToolTip
            ToolTip1.IsBalloon = True
            ToolTip1.UseFading = True
            ToolTip1.ToolTipIcon = ToolTipIcon.Error
            ToolTip1.ToolTipTitle = "Please enter a number between 1 and 1500"
            ToolTip1.Show("Style is not an Integer value", tbfleet1size, New Point(0, -80), 2500)
            tbfleet2size.Text = ""
        End Try
        If i2 >= 1 AndAlso i2 <= 1500 Then
            fleet2count = i2
            Me.Text = fleet2count.ToString
        Else
            Dim ToolTip1 As New ToolTip
            ToolTip1.IsBalloon = True
            ToolTip1.UseFading = True
            ToolTip1.ToolTipIcon = ToolTipIcon.Error
            ToolTip1.ToolTipTitle = "Please enter a number between 1 and 1500"
            ToolTip1.Show("Value was out of range", tbfleet1size, New Point(0, -80), 2500)
            tbfleet2size.Text = ""
        End If
    End Sub

    Private Sub cbfleet2card_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbfleet2card.SelectedIndexChanged
        fleet2card = cbfleet2card.SelectedItem
    End Sub


End Class