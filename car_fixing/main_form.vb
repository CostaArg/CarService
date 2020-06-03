Public Class main_form

    Dim time_required
    Dim cost
    Dim total_time_required
    Dim total_cost
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles add_to_cart.Click
        total_time_required = total_time_required + time_required
        total_cost = total_cost + cost
        total_time_display.Text = total_time_required
        total_cost_display.Text = total_cost
    End Sub
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
            total_time_required = 0
            total_cost = 0
        Next
    End Sub
    Private Sub exit_app_Click(sender As Object, e As EventArgs) Handles exit_app.Click
        Application.Exit()
        End
    End Sub

    Private Sub car_strap_change_CheckedChanged(sender As Object, e As EventArgs) Handles car_strap_change.CheckedChanged

        If car_strap_change.Checked = True Then
            time_required = 1.5
            cost = 30
        End If
    End Sub

    Private Sub car_oil_change_CheckedChanged(sender As Object, e As EventArgs) Handles car_oil_change.CheckedChanged
        If car_oil_change.Checked = True Then
            time_required = 1
            cost = 20
        End If
    End Sub


    Private Sub car_radioator_fix_CheckedChanged(sender As Object, e As EventArgs) Handles car_radiator_fix.CheckedChanged
        If car_radiator_fix.Checked = True Then
            time_required = 2.5
            cost = 50
        End If
    End Sub

End Class