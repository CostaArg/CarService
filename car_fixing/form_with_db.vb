Public Class form_with_db
    Private Sub clear_form_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_form.Click
        resetAllControls(Me)
    End Sub

    Private Sub resetAllControls(ByVal container As Control)
        For Each ctrl As Control In container.Controls
            If TypeOf ctrl Is RadioButton Then
                DirectCast(ctrl, RadioButton).Checked = False
            ElseIf TypeOf ctrl Is TextBox Then
                DirectCast(ctrl, TextBox).Clear()
            End If
            If ctrl.Controls.Count > 0 Then
                resetAllControls(ctrl)
            End If
        Next
    End Sub
    Private Sub exit_app_Click(sender As Object, e As EventArgs) Handles exit_app.Click
        Application.Exit()
        End
    End Sub


    Private Sub pendingbutton_CheckedChanged(sender As Object, e As EventArgs) Handles pendingbutton.CheckedChanged
        Datedtp.Visible = True
        rateus.Visible = False
        rate1.Visible = False
        rate2.Visible = False
        rate3.Visible = False
        rate4.Visible = False
        rate5.Visible = False
    End Sub

    Private Sub techinprogressbutton_CheckedChanged(sender As Object, e As EventArgs) Handles techinprogressbutton.CheckedChanged
        Datedtp.Visible = False
        rateus.Visible = False
        rate1.Visible = False
        rate2.Visible = False
        rate3.Visible = False
        rate4.Visible = False
        rate5.Visible = False
    End Sub

    Private Sub techcompletedbutton_CheckedChanged(sender As Object, e As EventArgs) Handles techcompletedbutton.CheckedChanged
        Datedtp.Visible = False
        rateus.Visible = True
        rate1.Visible = True
        rate2.Visible = True
        rate3.Visible = True
        rate4.Visible = True
        rate5.Visible = True

    End Sub

    Private Sub form_with_db_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Car_brand_dataset.Table' table. You can move, or remove it, as needed.
        Me.TableTableAdapter1.Fill(Me.Car_brand_dataset.Table)
        'TODO: This line of code loads data into the 'Car_databaseDataSet.Table' table. You can move, or remove it, as needed.
        Me.TableTableAdapter.Fill(Me.Car_databaseDataSet.Table)
        Datedtp.Visible = False
        rateus.Visible = False
        rate1.Visible = False
        rate2.Visible = False
        rate3.Visible = False
        rate4.Visible = False
        rate5.Visible = False
    End Sub

End Class