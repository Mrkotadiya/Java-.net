Public Class Redio

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim a As String
        a = ComboBox1.SelectedItem
        If a = "PenalControl" Then
            Panel1.Show()
            GroupBox1.Hide()
        End If
        If a = "GroupBox" Then
            GroupBox1.Show()
            Panel1.Hide()
        End If

    End Sub

    Private Sub Redio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If a = "GroupBox" Then
        GroupBox1.Hide()
        Panel1.Hide()
        'End If
    End Sub
End Class