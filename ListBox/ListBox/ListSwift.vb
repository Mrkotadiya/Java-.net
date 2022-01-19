Public Class ListSwift

   
    Private Sub btnShiftRight_Click(sender As Object, e As EventArgs) Handles btnShiftRight.Click
        lstCity2.Items.Add(lstCity1.SelectedItem)
        lstCity1.Items.Remove(lstCity1.SelectedItem)
    End Sub

    Private Sub btnAllShift_Click(sender As Object, e As EventArgs) Handles btnAllShift.Click
        Dim i As Integer
        For i = 0 To lstCity1.Items.Count - 1
            lstCity2.Items.Add(lstCity1.Items.Item(i))
        Next
        lstCity1.Items.Clear()

    End Sub

    Private Sub btnLeftShift_Click(sender As Object, e As EventArgs) Handles btnLeftShift.Click
        lstCity1.Items.Add(lstCity2.SelectedItem)
        lstCity2.Items.Remove(lstCity2.SelectedItem)
    End Sub

    Private Sub btnAllLeftShift_Click(sender As Object, e As EventArgs) Handles btnAllLeftShift.Click
        Dim a As Integer
        For a = 0 To lstCity1.Items.Count - 1
            lstCity1.Items.Add(lstCity2.Items.Item(a))
        Next
        lstCity2.Items.Clear()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        lstCity1.Items.Add(txtCity.Text)
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        lstCity1.Items.Remove(lstCity1.SelectedItem)
    End Sub
End Class