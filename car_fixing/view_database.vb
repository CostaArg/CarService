Public Class view_database
    Private Sub view_database_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TableTableAdapter.Fill(Me.Car_databaseDataSet.Table)

    End Sub

End Class