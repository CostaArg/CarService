Public Class view_database
    Private Sub view_database_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Car_databaseDataSet.Table' table. You can move, or remove it, as needed.
        Me.TableTableAdapter.Fill(Me.Car_databaseDataSet.Table)

    End Sub

End Class