Public Class BaseFleetGrid

    Public Function StoreValues(Attacker As Boolean) As FleetBase()
        Dim fleets(dgfleets.RowCount - 2) As FleetBase
        For i As Integer = 0 To dgfleets.RowCount - 2
            Dim fleet As FleetBase = New FleetBase()

            fleet.Attacker = Attacker

            fleet.FleetType = dgfleets.Rows(i).Cells(0).Value
            fleet.FleetCount = dgfleets.Rows(i).Cells(1).Value
            fleet.FleetHard = dgfleets.Rows(i).Cells(2).Value
            fleet.FleetHull = dgfleets.Rows(i).Cells(3).Value
            fleet.FleetCard = dgfleets.Rows(i).Cells(4).Value

            fleets(i) = fleet
        Next i

        Return fleets
    End Function

    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) And e.KeyChar <> Convert.ToChar(Keys.Delete) And e.KeyChar <> Convert.ToChar(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub dgfleets_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgfleets.EditingControlShowing
        If (dgfleets.CurrentCell.ColumnIndex = 1) Then
            AddHandler e.Control.KeyPress, AddressOf TextBox_KeyPress
            AddHandler e.Control.TextChanged, AddressOf TextBox_TextChanged
        End If
    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs)
        Dim tb As TextBox = CType(sender, TextBox)
        Try
            Dim value As Integer = Integer.Parse(tb.Text)
            If (value > 1500) Then
                tb.Text = "1500"
                tb.SelectionStart = tb.Text.Length  ' Place the cursor at the end of the textbox content
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
