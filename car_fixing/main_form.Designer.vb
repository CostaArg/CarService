<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main_form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.customer_case = New System.Windows.Forms.GroupBox()
        Me.total_time_label = New System.Windows.Forms.Label()
        Me.total_cost_label = New System.Windows.Forms.Label()
        Me.total_time_display = New System.Windows.Forms.TextBox()
        Me.total_cost_display = New System.Windows.Forms.TextBox()
        Me.exit_app = New System.Windows.Forms.Button()
        Me.clear_form = New System.Windows.Forms.Button()
        Me.add_to_cart = New System.Windows.Forms.Button()
        Me.car_labor = New System.Windows.Forms.GroupBox()
        Me.car_radiator_fix = New System.Windows.Forms.RadioButton()
        Me.car_oil_change = New System.Windows.Forms.RadioButton()
        Me.car_strap_change = New System.Windows.Forms.RadioButton()
        Me.phone_number = New System.Windows.Forms.TextBox()
        Me.car_brand = New System.Windows.Forms.GroupBox()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.phone_number_label = New System.Windows.Forms.Label()
        Me.customer_name_label = New System.Windows.Forms.Label()
        Me.customer_name = New System.Windows.Forms.TextBox()
        Me.customer_case.SuspendLayout()
        Me.car_labor.SuspendLayout()
        Me.car_brand.SuspendLayout()
        Me.SuspendLayout()
        '
        'customer_case
        '
        Me.customer_case.Controls.Add(Me.total_time_label)
        Me.customer_case.Controls.Add(Me.total_cost_label)
        Me.customer_case.Controls.Add(Me.total_time_display)
        Me.customer_case.Controls.Add(Me.total_cost_display)
        Me.customer_case.Controls.Add(Me.exit_app)
        Me.customer_case.Controls.Add(Me.clear_form)
        Me.customer_case.Controls.Add(Me.add_to_cart)
        Me.customer_case.Controls.Add(Me.car_labor)
        Me.customer_case.Controls.Add(Me.phone_number)
        Me.customer_case.Controls.Add(Me.car_brand)
        Me.customer_case.Controls.Add(Me.phone_number_label)
        Me.customer_case.Controls.Add(Me.customer_name_label)
        Me.customer_case.Controls.Add(Me.customer_name)
        Me.customer_case.Location = New System.Drawing.Point(24, 30)
        Me.customer_case.Name = "customer_case"
        Me.customer_case.Size = New System.Drawing.Size(303, 308)
        Me.customer_case.TabIndex = 0
        Me.customer_case.TabStop = False
        Me.customer_case.Text = "Customer Case"
        '
        'total_time_label
        '
        Me.total_time_label.AutoSize = True
        Me.total_time_label.Location = New System.Drawing.Point(10, 274)
        Me.total_time_label.Name = "total_time_label"
        Me.total_time_label.Size = New System.Drawing.Size(57, 13)
        Me.total_time_label.TabIndex = 10
        Me.total_time_label.Text = "Total Time"
        '
        'total_cost_label
        '
        Me.total_cost_label.AutoSize = True
        Me.total_cost_label.Location = New System.Drawing.Point(10, 248)
        Me.total_cost_label.Name = "total_cost_label"
        Me.total_cost_label.Size = New System.Drawing.Size(55, 13)
        Me.total_cost_label.TabIndex = 9
        Me.total_cost_label.Text = "Total Cost"
        '
        'total_time_display
        '
        Me.total_time_display.Location = New System.Drawing.Point(72, 270)
        Me.total_time_display.Name = "total_time_display"
        Me.total_time_display.ReadOnly = True
        Me.total_time_display.Size = New System.Drawing.Size(100, 20)
        Me.total_time_display.TabIndex = 8
        '
        'total_cost_display
        '
        Me.total_cost_display.Location = New System.Drawing.Point(73, 244)
        Me.total_cost_display.Name = "total_cost_display"
        Me.total_cost_display.ReadOnly = True
        Me.total_cost_display.Size = New System.Drawing.Size(100, 20)
        Me.total_cost_display.TabIndex = 7
        '
        'exit_app
        '
        Me.exit_app.Location = New System.Drawing.Point(196, 241)
        Me.exit_app.Name = "exit_app"
        Me.exit_app.Size = New System.Drawing.Size(75, 23)
        Me.exit_app.TabIndex = 6
        Me.exit_app.Text = "Exit App"
        Me.exit_app.UseVisualStyleBackColor = True
        '
        'clear_form
        '
        Me.clear_form.Location = New System.Drawing.Point(196, 211)
        Me.clear_form.Name = "clear_form"
        Me.clear_form.Size = New System.Drawing.Size(75, 23)
        Me.clear_form.TabIndex = 5
        Me.clear_form.Text = "Clear Form"
        Me.clear_form.UseVisualStyleBackColor = True
        '
        'add_to_cart
        '
        Me.add_to_cart.Location = New System.Drawing.Point(196, 182)
        Me.add_to_cart.Name = "add_to_cart"
        Me.add_to_cart.Size = New System.Drawing.Size(75, 23)
        Me.add_to_cart.TabIndex = 4
        Me.add_to_cart.Text = "Add to Cart"
        Me.add_to_cart.UseVisualStyleBackColor = True
        '
        'car_labor
        '
        Me.car_labor.Controls.Add(Me.car_radiator_fix)
        Me.car_labor.Controls.Add(Me.car_oil_change)
        Me.car_labor.Controls.Add(Me.car_strap_change)
        Me.car_labor.Location = New System.Drawing.Point(39, 133)
        Me.car_labor.Name = "car_labor"
        Me.car_labor.Size = New System.Drawing.Size(124, 101)
        Me.car_labor.TabIndex = 2
        Me.car_labor.TabStop = False
        Me.car_labor.Text = "Car Labor"
        '
        'car_radiator_fix
        '
        Me.car_radiator_fix.AutoSize = True
        Me.car_radiator_fix.Location = New System.Drawing.Point(6, 65)
        Me.car_radiator_fix.Name = "car_radiator_fix"
        Me.car_radiator_fix.Size = New System.Drawing.Size(100, 17)
        Me.car_radiator_fix.TabIndex = 2
        Me.car_radiator_fix.TabStop = True
        Me.car_radiator_fix.Text = "Car Radiator Fix"
        Me.car_radiator_fix.UseVisualStyleBackColor = True
        '
        'car_oil_change
        '
        Me.car_oil_change.AutoSize = True
        Me.car_oil_change.Location = New System.Drawing.Point(6, 42)
        Me.car_oil_change.Name = "car_oil_change"
        Me.car_oil_change.Size = New System.Drawing.Size(96, 17)
        Me.car_oil_change.TabIndex = 1
        Me.car_oil_change.TabStop = True
        Me.car_oil_change.Text = "Car Oil Change"
        Me.car_oil_change.UseVisualStyleBackColor = True
        '
        'car_strap_change
        '
        Me.car_strap_change.AutoSize = True
        Me.car_strap_change.Location = New System.Drawing.Point(6, 19)
        Me.car_strap_change.Name = "car_strap_change"
        Me.car_strap_change.Size = New System.Drawing.Size(109, 17)
        Me.car_strap_change.TabIndex = 0
        Me.car_strap_change.TabStop = True
        Me.car_strap_change.Text = "Car Strap Change"
        Me.car_strap_change.UseVisualStyleBackColor = True
        '
        'phone_number
        '
        Me.phone_number.Location = New System.Drawing.Point(54, 99)
        Me.phone_number.Name = "phone_number"
        Me.phone_number.Size = New System.Drawing.Size(100, 20)
        Me.phone_number.TabIndex = 3
        '
        'car_brand
        '
        Me.car_brand.Controls.Add(Me.RadioButton5)
        Me.car_brand.Controls.Add(Me.RadioButton4)
        Me.car_brand.Controls.Add(Me.RadioButton3)
        Me.car_brand.Controls.Add(Me.RadioButton2)
        Me.car_brand.Controls.Add(Me.RadioButton1)
        Me.car_brand.Location = New System.Drawing.Point(188, 19)
        Me.car_brand.Name = "car_brand"
        Me.car_brand.Size = New System.Drawing.Size(93, 141)
        Me.car_brand.TabIndex = 1
        Me.car_brand.TabStop = False
        Me.car_brand.Text = "Car Brand"
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(18, 110)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(58, 17)
        Me.RadioButton5.TabIndex = 4
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Toyota"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(18, 87)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(46, 17)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Audi"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(18, 64)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(42, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Fiat"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(18, 42)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(52, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Volvo"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(18, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(47, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Opel"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'phone_number_label
        '
        Me.phone_number_label.AutoSize = True
        Me.phone_number_label.Location = New System.Drawing.Point(57, 83)
        Me.phone_number_label.Name = "phone_number_label"
        Me.phone_number_label.Size = New System.Drawing.Size(78, 13)
        Me.phone_number_label.TabIndex = 2
        Me.phone_number_label.Text = "Phone Number"
        '
        'customer_name_label
        '
        Me.customer_name_label.AutoSize = True
        Me.customer_name_label.Location = New System.Drawing.Point(57, 35)
        Me.customer_name_label.Name = "customer_name_label"
        Me.customer_name_label.Size = New System.Drawing.Size(82, 13)
        Me.customer_name_label.TabIndex = 1
        Me.customer_name_label.Text = "Customer Name"
        '
        'customer_name
        '
        Me.customer_name.Location = New System.Drawing.Point(54, 51)
        Me.customer_name.Name = "customer_name"
        Me.customer_name.Size = New System.Drawing.Size(100, 20)
        Me.customer_name.TabIndex = 0
        '
        'main_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 363)
        Me.Controls.Add(Me.customer_case)
        Me.Name = "main_form"
        Me.Text = "Customer Case"
        Me.customer_case.ResumeLayout(False)
        Me.customer_case.PerformLayout()
        Me.car_labor.ResumeLayout(False)
        Me.car_labor.PerformLayout()
        Me.car_brand.ResumeLayout(False)
        Me.car_brand.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents customer_case As GroupBox
    Friend WithEvents phone_number As TextBox
    Friend WithEvents phone_number_label As Label
    Friend WithEvents customer_name_label As Label
    Friend WithEvents customer_name As TextBox
    Friend WithEvents car_brand As GroupBox
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents car_labor As GroupBox
    Friend WithEvents car_radiator_fix As RadioButton
    Friend WithEvents car_oil_change As RadioButton
    Friend WithEvents car_strap_change As RadioButton
    Friend WithEvents add_to_cart As Button
    Friend WithEvents exit_app As Button
    Friend WithEvents clear_form As Button
    Friend WithEvents total_time_label As Label
    Friend WithEvents total_cost_label As Label
    Friend WithEvents total_time_display As TextBox
    Friend WithEvents total_cost_display As TextBox
End Class
