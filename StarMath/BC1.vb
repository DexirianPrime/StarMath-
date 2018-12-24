Public Class BC1



    Dim i As Integer

    Dim Userint As Integer

    Dim i2 As Integer

    Dim Userint2 As Integer

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

        Try
            i = Integer.Parse(TextBox1.Text, Globalization.NumberStyles.Any)
        Catch ex As Exception
            Dim ToolTip1 As New ToolTip
            ToolTip1.IsBalloon = True
            ToolTip1.UseFading = True
            ToolTip1.ToolTipIcon = ToolTipIcon.Error
            ToolTip1.ToolTipTitle = "Please enter a number between 1 and 5"
            ToolTip1.Show("Style is not an Integer value", TextBox1, New Point(0, -80), 2500)
            TextBox1.Text = ""
        End Try
        If i >= 1 AndAlso i <= 5 Then
            Userint = i
            Me.Text = Userint.ToString
            fleetcount = Userint
        Else
            Dim ToolTip1 As New ToolTip
            ToolTip1.IsBalloon = True
            ToolTip1.UseFading = True
            ToolTip1.ToolTipIcon = ToolTipIcon.Error
            ToolTip1.ToolTipTitle = "Please enter a number between 1 and 5"
            ToolTip1.Show("Value was out of range", TextBox1, New Point(0, -80), 2500)
            TextBox1.Text = ""
        End If

    End Sub


    Private Sub TextBox2_TextChanged_1(sender As Object, e As EventArgs)
        Try
            i2 = Integer.Parse(TextBox2.Text, Globalization.NumberStyles.Any)
        Catch ex As Exception
            Dim ToolTip1 As New ToolTip
            ToolTip1.IsBalloon = True
            ToolTip1.UseFading = True
            ToolTip1.ToolTipIcon = ToolTipIcon.Error
            ToolTip1.ToolTipTitle = "Please enter a number between 1 and 5"
            ToolTip1.Show("Style is not an Integer value", TextBox1, New Point(0, -80), 2500)
            TextBox2.Text = ""
        End Try
        If i2 >= 1 AndAlso i2 <= 5 Then
            Userint2 = i2
            Me.Text = Userint2.ToString
            dfleetcount = Userint2
        Else
            Dim ToolTip1 As New ToolTip
            ToolTip1.IsBalloon = True
            ToolTip1.UseFading = True
            ToolTip1.ToolTipIcon = ToolTipIcon.Error
            ToolTip1.ToolTipTitle = "Please enter a number between 1 and 5"
            ToolTip1.Show("Value was out of range", TextBox1, New Point(0, -80), 2500)
            TextBox2.Text = ""
        End If
    End Sub

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