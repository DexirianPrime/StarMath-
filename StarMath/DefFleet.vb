Public Class DefFleet

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        frmFleet.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        dfleetarray = BaseFleetGrid1.StoreValues(False)

        If ValidateValues() Then
            Me.Hide()
            Tfleet2hp.Show()
        Else
            MessageBox.Show("Please input valid values!")
        End If
    End Sub


    Function ValidateValues() As Boolean
        Dim result As Boolean = True
        For i As Integer = 0 To dfleetarray.Length - 1
            result = ((dfleetarray(i).FleetType <> "") And (dfleetarray(i).FleetCount <> Nothing))

            If Not result Then
                Exit For
            End If
        Next

        Return result
    End Function

    Private Sub DefFleet_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Selector.Close()
    End Sub

    Private Sub BaseFleetGrid1_Load(sender As Object, e As EventArgs) Handles BaseFleetGrid1.Load

    End Sub

    Private Sub DefFleet_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class