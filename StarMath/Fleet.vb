Public Class frmFleet

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        fleetarray = BaseFleetGrid1.StoreValues(True)
        dfleetarray = BaseFleetGrid2.StoreValues(False)

        If ValidateValues() Then
            Me.Hide()
            Tfleet2hp.Show()
        Else
            MessageBox.Show("Please input valid values!")
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        BC1.Show()
    End Sub

    Function ValidateValues() As Boolean
        Dim result As Boolean = True
        For i As Integer = 0 To fleetarray.Length - 1
            result = ((fleetarray(i).FleetType <> "") And (fleetarray(i).FleetCount <> Nothing))

            If Not result Then
                Exit For
            End If
        Next
        For i As Integer = 0 To dfleetarray.Length - 1
            result = ((dfleetarray(i).FleetType <> "") And (dfleetarray(i).FleetCount <> Nothing))

            If Not result Then
                Exit For
            End If
        Next

        Return result
    End Function

    Private Sub frmFleet_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Selector.Close()
    End Sub

    Private Sub cbByOurBlood_CheckedChanged(sender As Object, e As EventArgs) Handles cbByOurBlood.CheckedChanged
        ByOurBlood = cbByOurBlood.Checked
    End Sub
End Class