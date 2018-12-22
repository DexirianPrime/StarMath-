Public Class DefFleet
    Private Sub DefFleet_Close(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Me.Hide()
        Selector.Show()
    End Sub

    Private Sub DefFleet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Make sure we've loaded everything
        If cmbTarget.Items.Count = 0 Then
            cmbTarget.Items.Add("? - Player")

            For Each enIt In Selector.enemies
                cmbTarget.Items.Add(enIt.Value.level.ToString() + " - " + enIt.Key)
            Next
        End If

        ' Set our default
        If cmbTarget.SelectedIndex = -1 Then
            cmbTarget.SelectedIndex = 0
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Selector.Show()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.Hide()
        Results.Show()
    End Sub

    Private threatByLevel As String() = {"None", "Common", "Rare", "Epic", "Legendary"}

    ' They are going up against something different
    ' TODO:  If they are in player mode, save their current grid so we can come back to it if they reselect it
    Private Sub cmbTarget_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTarget.SelectedIndexChanged
        dgFleetList.Rows.Clear()
        dgFleetList.Refresh()

        If cmbTarget.SelectedIndex <> 0 Then
            Dim sel As String = cmbTarget.Items(cmbTarget.SelectedIndex).ToString().Substring(4)
            Dim lvl As Integer = CInt(cmbTarget.Items(cmbTarget.SelectedIndex).ToString().Substring(0, 1))

            Dim el = Selector.enemies(sel)
            Dim r = dgFleetList.Rows.Count - 1

            For Each _e In el.LineItems
                dgFleetList.Rows.Insert(r, _e.Key, _e.Value, True, threatByLevel(lvl), threatByLevel(lvl), threatByLevel(lvl), threatByLevel(lvl - 1))
                MakeReadOnly(r, True)
            Next
        End If

        dgFleetList.Refresh()
    End Sub

    ' TODO: Put code in here for worst case Player level
    Private Sub dgFleetList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgFleetList.CellContentClick
        If e.ColumnIndex = 2 Then


        End If
    End Sub

    Private Sub MakeReadOnly(_r As Integer, _ro As Boolean)
        dgFleetList.Rows(_r).Cells(2).ReadOnly = _ro
        dgFleetList.Rows(_r).Cells(3).ReadOnly = _ro
        dgFleetList.Rows(_r).Cells(4).ReadOnly = _ro
        dgFleetList.Rows(_r).Cells(5).ReadOnly = _ro
        dgFleetList.Rows(_r).Cells(6).ReadOnly = _ro
    End Sub
End Class