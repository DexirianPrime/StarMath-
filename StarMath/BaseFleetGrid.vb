Public Class BaseFleetGrid
    Public Function StoreValues(Attacker As Boolean) As FleetBase()
        Dim fleets(dgfleets.RowCount - 2) As FleetBase
        For i As Integer = 0 To dgfleets.RowCount - 2
            Dim fleet As FleetBase = New FleetBase()

            fleet.Attacker = Attacker

            For j As Integer = 0 To dgfleets.ColumnCount - 1
                Select Case j
                    Case 0
                        fleet.FleetType = dgfleets.Rows(i).Cells(j).Value
                    Case 1
                        fleet.FleetCount = dgfleets.Rows(i).Cells(j).Value
                    Case 2
                        fleet.FleetHard = dgfleets.Rows(i).Cells(j).Value
                    Case 3
                        fleet.FleetHull = dgfleets.Rows(i).Cells(j).Value
                    Case 4
                        fleet.FleetCard = dgfleets.Rows(i).Cells(j).Value
                End Select
            Next j

            fleets(i) = fleet
        Next i

        Return fleets
    End Function

    Private Sub dgfleets_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgfleets.CellValueChanged
        If (dgfleets.Rows.Count > 0) And (e.RowIndex > -1) Then
            If (e.ColumnIndex = 1) Then
                Try
                    Dim i2 As Integer
                    i2 = Integer.Parse(dgfleets.Rows(e.RowIndex).Cells("FleetSize").Value, Globalization.NumberStyles.Any)

                    If i2 < 1 Or i2 > 1500 Then
                        Dim ToolTip1 As New ToolTip
                        ToolTip1.IsBalloon = True
                        ToolTip1.UseFading = True
                        ToolTip1.ToolTipIcon = ToolTipIcon.Error
                        ToolTip1.ToolTipTitle = "Please enter a number between 1 and 1500"
                        ToolTip1.Show("Value was out of range", Me, 0, 20)
                        dgfleets.Rows(e.RowIndex).Cells("FleetSize").Value = ""
                    End If
                Catch ex As Exception
                    Dim ToolTip1 As New ToolTip
                    ToolTip1.IsBalloon = True
                    ToolTip1.UseFading = True
                    ToolTip1.ToolTipIcon = ToolTipIcon.Error
                    ToolTip1.ToolTipTitle = "Please enter a number between 1 and 1500"
                    ToolTip1.Show("Style is not an Integer value", Me, 0, 20)
                    dgfleets.Rows(e.RowIndex).Cells("FleetSize").Value = ""
                End Try
            End If
        End If
    End Sub
End Class
