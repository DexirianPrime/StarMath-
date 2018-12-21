Public Class DefFleet


    Dim i As Integer
    Dim i2 As Integer

    Private Sub cbdfleet1type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbdfleet1type.SelectedIndexChanged
        dfleet1type = cbdfleet1type.SelectedItem
    End Sub

    Private Sub tbdfleet1size_TextChanged(sender As Object, e As EventArgs) Handles tbdfleet1size.TextChanged
        Try
            i = Integer.Parse(tbdfleet1size.Text, Globalization.NumberStyles.Any)
        Catch ex As Exception
            Dim ToolTip1 As New ToolTip
            ToolTip1.IsBalloon = True
            ToolTip1.UseFading = True
            ToolTip1.ToolTipIcon = ToolTipIcon.Error
            ToolTip1.ToolTipTitle = "Please enter a number between 1 and 1500"
            ToolTip1.Show("Style is not an Integer value", tbdfleet1size, New Point(0, -80), 2500)
            tbdfleet1size.Text = ""
        End Try
        If i >= 1 AndAlso i <= 1500 Then
            dfleet1count = i
            Me.Text = dfleet1count.ToString
        Else
            Dim ToolTip1 As New ToolTip
            ToolTip1.IsBalloon = True
            ToolTip1.UseFading = True
            ToolTip1.ToolTipIcon = ToolTipIcon.Error
            ToolTip1.ToolTipTitle = "Please enter a number between 1 and 1500"
            ToolTip1.Show("Value was out of range", tbdfleet1size, New Point(0, -80), 2500)
            tbdfleet1size.Text = ""
        End If
    End Sub

    Private Sub cbdfleet1hard_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbdfleet1hard.SelectedIndexChanged
        dfleet1hard = cbdfleet1hard.SelectedItem
    End Sub

    Private Sub cbdfleet1hull_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbdfleet1hull.SelectedIndexChanged
        dfleet1hull = cbdfleet1hull.SelectedItem
    End Sub

    Private Sub cbdfleet1card_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbdfleet1card.SelectedIndexChanged
        dfleet1card = cbdfleet1card.SelectedItem
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Fleet.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Tfleet2hp.Show()

    End Sub

    Private Sub cbdfleet2type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbdfleet2type.SelectedIndexChanged
        dfleet2type = cbdfleet2type.SelectedItem
    End Sub

    Private Sub cbdfleet2hull_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbdfleet2hull.SelectedIndexChanged
        dfleet2hull = cbdfleet2hull.SelectedItem

    End Sub

    Private Sub cbdfleet2hard_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbdfleet2hard.SelectedIndexChanged
        dfleet2hard = cbdfleet2hard.SelectedItem
    End Sub

    Private Sub tbdfleet2size_TextChanged(sender As Object, e As EventArgs) Handles tbdfleet2size.TextChanged
        Try
            i2 = Integer.Parse(tbdfleet2size.Text, Globalization.NumberStyles.Any)
        Catch ex As Exception
            Dim ToolTip1 As New ToolTip
            ToolTip1.IsBalloon = True
            ToolTip1.UseFading = True
            ToolTip1.ToolTipIcon = ToolTipIcon.Error
            ToolTip1.ToolTipTitle = "Please enter a number between 1 and 1500"
            ToolTip1.Show("Style is not an Integer value", tbdfleet1size, New Point(0, -80), 2500)
            tbdfleet2size.Text = ""
        End Try
        If i2 >= 1 AndAlso i2 <= 1500 Then
            dfleet2count = i2
            Me.Text = dfleet2count.ToString
        Else
            Dim ToolTip1 As New ToolTip
            ToolTip1.IsBalloon = True
            ToolTip1.UseFading = True
            ToolTip1.ToolTipIcon = ToolTipIcon.Error
            ToolTip1.ToolTipTitle = "Please enter a number between 1 and 1500"
            ToolTip1.Show("Value was out of range", tbdfleet1size, New Point(0, -80), 2500)
            tbdfleet2size.Text = ""
        End If
    End Sub

    Private Sub cbdfleet2card_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbdfleet2card.SelectedIndexChanged
        dfleet2card = cbdfleet2card.SelectedItem
    End Sub


End Class