<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_with_db
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
        Me.components = New System.ComponentModel.Container()
        Me.customer_case = New System.Windows.Forms.GroupBox()
        Me.submitbutton = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rateus = New System.Windows.Forms.Label()
        Me.add_to_cart = New System.Windows.Forms.Button()
        Me.rate5 = New System.Windows.Forms.RadioButton()
        Me.clear_form = New System.Windows.Forms.Button()
        Me.rate4 = New System.Windows.Forms.RadioButton()
        Me.exit_app = New System.Windows.Forms.Button()
        Me.rate3 = New System.Windows.Forms.RadioButton()
        Me.rate2 = New System.Windows.Forms.RadioButton()
        Me.rate1 = New System.Windows.Forms.RadioButton()
        Me.Datedtp = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.total_cost_display = New System.Windows.Forms.TextBox()
        Me.Serviceslst = New System.Windows.Forms.ListView()
        Me.total_time_display = New System.Windows.Forms.TextBox()
        Me.total_cost_label = New System.Windows.Forms.Label()
        Me.total_time_label = New System.Windows.Forms.Label()
        Me.techcompletedbutton = New System.Windows.Forms.RadioButton()
        Me.techinprogressbutton = New System.Windows.Forms.RadioButton()
        Me.pendingbutton = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Car_databaseDataSet = New car_fixing.car_databaseDataSet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.phone_number = New System.Windows.Forms.TextBox()
        Me.phone_number_label = New System.Windows.Forms.Label()
        Me.customer_name_label = New System.Windows.Forms.Label()
        Me.customer_name = New System.Windows.Forms.TextBox()
        Me.CardatabaseDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CardatabaseDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableTableAdapter = New car_fixing.car_databaseDataSetTableAdapters.TableTableAdapter()
        Me.CardatabaseDataSetBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CardatabaseDataSetBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Car_brand_dataset = New car_fixing.car_brand_dataset()
        Me.CarbranddatasetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CarbranddatasetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CarbranddatasetBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableTableAdapter1 = New car_fixing.car_brand_datasetTableAdapters.TableTableAdapter()
        Me.TableBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.customer_case.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Car_databaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CardatabaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CardatabaseDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CardatabaseDataSetBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CardatabaseDataSetBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Car_brand_dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarbranddatasetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarbranddatasetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarbranddatasetBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'customer_case
        '
        Me.customer_case.Controls.Add(Me.submitbutton)
        Me.customer_case.Controls.Add(Me.GroupBox2)
        Me.customer_case.Controls.Add(Me.rateus)
        Me.customer_case.Controls.Add(Me.add_to_cart)
        Me.customer_case.Controls.Add(Me.rate5)
        Me.customer_case.Controls.Add(Me.clear_form)
        Me.customer_case.Controls.Add(Me.rate4)
        Me.customer_case.Controls.Add(Me.exit_app)
        Me.customer_case.Controls.Add(Me.rate3)
        Me.customer_case.Controls.Add(Me.rate2)
        Me.customer_case.Controls.Add(Me.rate1)
        Me.customer_case.Controls.Add(Me.Datedtp)
        Me.customer_case.Controls.Add(Me.GroupBox1)
        Me.customer_case.Controls.Add(Me.techcompletedbutton)
        Me.customer_case.Controls.Add(Me.techinprogressbutton)
        Me.customer_case.Controls.Add(Me.pendingbutton)
        Me.customer_case.Controls.Add(Me.Label5)
        Me.customer_case.Controls.Add(Me.Label4)
        Me.customer_case.Controls.Add(Me.ComboBox2)
        Me.customer_case.Controls.Add(Me.Label3)
        Me.customer_case.Controls.Add(Me.TextBox2)
        Me.customer_case.Controls.Add(Me.Label2)
        Me.customer_case.Controls.Add(Me.ComboBox1)
        Me.customer_case.Controls.Add(Me.phone_number)
        Me.customer_case.Controls.Add(Me.phone_number_label)
        Me.customer_case.Controls.Add(Me.customer_name_label)
        Me.customer_case.Controls.Add(Me.customer_name)
        Me.customer_case.Location = New System.Drawing.Point(31, 43)
        Me.customer_case.Name = "customer_case"
        Me.customer_case.Size = New System.Drawing.Size(771, 420)
        Me.customer_case.TabIndex = 1
        Me.customer_case.TabStop = False
        Me.customer_case.Text = "Customer Case"
        '
        'submitbutton
        '
        Me.submitbutton.Location = New System.Drawing.Point(651, 40)
        Me.submitbutton.Name = "submitbutton"
        Me.submitbutton.Size = New System.Drawing.Size(75, 23)
        Me.submitbutton.TabIndex = 50
        Me.submitbutton.Text = "Submit"
        Me.submitbutton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox7)
        Me.GroupBox2.Controls.Add(Me.TextBox6)
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 279)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(404, 135)
        Me.GroupBox2.TabIndex = 49
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Summary"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(263, 109)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 9
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(263, 88)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 8
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(263, 69)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 7
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(263, 48)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(263, 27)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(178, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Average Customer Satisfaction Rate"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 95)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Total Gathered Amount"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(161, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Cases in Tech Completed Status"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(163, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Cases in Tech in Progress Status"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Cases in Pending Status"
        '
        'rateus
        '
        Me.rateus.AutoSize = True
        Me.rateus.Location = New System.Drawing.Point(195, 235)
        Me.rateus.Name = "rateus"
        Me.rateus.Size = New System.Drawing.Size(46, 13)
        Me.rateus.TabIndex = 48
        Me.rateus.Text = "Rate Us"
        '
        'add_to_cart
        '
        Me.add_to_cart.Location = New System.Drawing.Point(342, 124)
        Me.add_to_cart.Name = "add_to_cart"
        Me.add_to_cart.Size = New System.Drawing.Size(75, 23)
        Me.add_to_cart.TabIndex = 4
        Me.add_to_cart.Text = "Add to Cart"
        Me.add_to_cart.UseVisualStyleBackColor = True
        '
        'rate5
        '
        Me.rate5.AutoSize = True
        Me.rate5.Location = New System.Drawing.Point(399, 233)
        Me.rate5.Name = "rate5"
        Me.rate5.Size = New System.Drawing.Size(31, 17)
        Me.rate5.TabIndex = 47
        Me.rate5.TabStop = True
        Me.rate5.Text = "5"
        Me.rate5.UseVisualStyleBackColor = True
        '
        'clear_form
        '
        Me.clear_form.Location = New System.Drawing.Point(651, 68)
        Me.clear_form.Name = "clear_form"
        Me.clear_form.Size = New System.Drawing.Size(75, 23)
        Me.clear_form.TabIndex = 5
        Me.clear_form.Text = "Clear Form"
        Me.clear_form.UseVisualStyleBackColor = True
        '
        'rate4
        '
        Me.rate4.AutoSize = True
        Me.rate4.Location = New System.Drawing.Point(362, 233)
        Me.rate4.Name = "rate4"
        Me.rate4.Size = New System.Drawing.Size(31, 17)
        Me.rate4.TabIndex = 46
        Me.rate4.TabStop = True
        Me.rate4.Text = "4"
        Me.rate4.UseVisualStyleBackColor = True
        '
        'exit_app
        '
        Me.exit_app.Location = New System.Drawing.Point(651, 98)
        Me.exit_app.Name = "exit_app"
        Me.exit_app.Size = New System.Drawing.Size(75, 23)
        Me.exit_app.TabIndex = 6
        Me.exit_app.Text = "Exit App"
        Me.exit_app.UseVisualStyleBackColor = True
        '
        'rate3
        '
        Me.rate3.AutoSize = True
        Me.rate3.Location = New System.Drawing.Point(325, 233)
        Me.rate3.Name = "rate3"
        Me.rate3.Size = New System.Drawing.Size(31, 17)
        Me.rate3.TabIndex = 45
        Me.rate3.TabStop = True
        Me.rate3.Text = "3"
        Me.rate3.UseVisualStyleBackColor = True
        '
        'rate2
        '
        Me.rate2.AutoSize = True
        Me.rate2.Location = New System.Drawing.Point(288, 233)
        Me.rate2.Name = "rate2"
        Me.rate2.Size = New System.Drawing.Size(31, 17)
        Me.rate2.TabIndex = 44
        Me.rate2.TabStop = True
        Me.rate2.Text = "2"
        Me.rate2.UseVisualStyleBackColor = True
        '
        'rate1
        '
        Me.rate1.AutoSize = True
        Me.rate1.Location = New System.Drawing.Point(251, 233)
        Me.rate1.Name = "rate1"
        Me.rate1.Size = New System.Drawing.Size(31, 17)
        Me.rate1.TabIndex = 43
        Me.rate1.TabStop = True
        Me.rate1.Text = "1"
        Me.rate1.UseVisualStyleBackColor = True
        '
        'Datedtp
        '
        Me.Datedtp.Location = New System.Drawing.Point(198, 187)
        Me.Datedtp.Name = "Datedtp"
        Me.Datedtp.Size = New System.Drawing.Size(200, 20)
        Me.Datedtp.TabIndex = 42
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.total_cost_display)
        Me.GroupBox1.Controls.Add(Me.Serviceslst)
        Me.GroupBox1.Controls.Add(Me.total_time_display)
        Me.GroupBox1.Controls.Add(Me.total_cost_label)
        Me.GroupBox1.Controls.Add(Me.total_time_label)
        Me.GroupBox1.Location = New System.Drawing.Point(456, 162)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(301, 252)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cart"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(102, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Selected Services"
        '
        'total_cost_display
        '
        Me.total_cost_display.Location = New System.Drawing.Point(150, 194)
        Me.total_cost_display.Name = "total_cost_display"
        Me.total_cost_display.ReadOnly = True
        Me.total_cost_display.Size = New System.Drawing.Size(100, 20)
        Me.total_cost_display.TabIndex = 7
        '
        'Serviceslst
        '
        Me.Serviceslst.Location = New System.Drawing.Point(23, 47)
        Me.Serviceslst.Name = "Serviceslst"
        Me.Serviceslst.Size = New System.Drawing.Size(247, 97)
        Me.Serviceslst.TabIndex = 39
        Me.Serviceslst.UseCompatibleStateImageBehavior = False
        Me.Serviceslst.View = System.Windows.Forms.View.List
        '
        'total_time_display
        '
        Me.total_time_display.Location = New System.Drawing.Point(150, 220)
        Me.total_time_display.Name = "total_time_display"
        Me.total_time_display.ReadOnly = True
        Me.total_time_display.Size = New System.Drawing.Size(100, 20)
        Me.total_time_display.TabIndex = 8
        '
        'total_cost_label
        '
        Me.total_cost_label.AutoSize = True
        Me.total_cost_label.Location = New System.Drawing.Point(66, 197)
        Me.total_cost_label.Name = "total_cost_label"
        Me.total_cost_label.Size = New System.Drawing.Size(55, 13)
        Me.total_cost_label.TabIndex = 9
        Me.total_cost_label.Text = "Total Cost"
        '
        'total_time_label
        '
        Me.total_time_label.AutoSize = True
        Me.total_time_label.Location = New System.Drawing.Point(66, 223)
        Me.total_time_label.Name = "total_time_label"
        Me.total_time_label.Size = New System.Drawing.Size(57, 13)
        Me.total_time_label.TabIndex = 10
        Me.total_time_label.Text = "Total Time"
        '
        'techcompletedbutton
        '
        Me.techcompletedbutton.AutoSize = True
        Me.techcompletedbutton.Location = New System.Drawing.Point(76, 233)
        Me.techcompletedbutton.Name = "techcompletedbutton"
        Me.techcompletedbutton.Size = New System.Drawing.Size(103, 17)
        Me.techcompletedbutton.TabIndex = 22
        Me.techcompletedbutton.TabStop = True
        Me.techcompletedbutton.Text = "Tech Completed"
        Me.techcompletedbutton.UseVisualStyleBackColor = True
        '
        'techinprogressbutton
        '
        Me.techinprogressbutton.AutoSize = True
        Me.techinprogressbutton.Location = New System.Drawing.Point(76, 210)
        Me.techinprogressbutton.Name = "techinprogressbutton"
        Me.techinprogressbutton.Size = New System.Drawing.Size(105, 17)
        Me.techinprogressbutton.TabIndex = 21
        Me.techinprogressbutton.TabStop = True
        Me.techinprogressbutton.Text = "Tech in Progress"
        Me.techinprogressbutton.UseVisualStyleBackColor = True
        '
        'pendingbutton
        '
        Me.pendingbutton.AutoSize = True
        Me.pendingbutton.Location = New System.Drawing.Point(76, 187)
        Me.pendingbutton.Name = "pendingbutton"
        Me.pendingbutton.Size = New System.Drawing.Size(64, 17)
        Me.pendingbutton.TabIndex = 20
        Me.pendingbutton.TabStop = True
        Me.pendingbutton.Text = "Pending"
        Me.pendingbutton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Status"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(249, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Select Car Brand"
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.TableBindingSource1
        Me.ComboBox2.DisplayMember = "brands"
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(342, 37)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 17
        '
        'TableBindingSource
        '
        Me.TableBindingSource.DataMember = "Table"
        Me.TableBindingSource.DataSource = Me.Car_databaseDataSet
        '
        'Car_databaseDataSet
        '
        Me.Car_databaseDataSet.DataSetName = "car_databaseDataSet"
        Me.Car_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(260, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Select Service"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(43, 51)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Case Number"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.TableBindingSource3
        Me.ComboBox1.DisplayMember = "services"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(342, 68)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 11
        '
        'phone_number
        '
        Me.phone_number.Location = New System.Drawing.Point(43, 140)
        Me.phone_number.Name = "phone_number"
        Me.phone_number.Size = New System.Drawing.Size(100, 20)
        Me.phone_number.TabIndex = 3
        '
        'phone_number_label
        '
        Me.phone_number_label.AutoSize = True
        Me.phone_number_label.Location = New System.Drawing.Point(46, 124)
        Me.phone_number_label.Name = "phone_number_label"
        Me.phone_number_label.Size = New System.Drawing.Size(78, 13)
        Me.phone_number_label.TabIndex = 2
        Me.phone_number_label.Text = "Phone Number"
        '
        'customer_name_label
        '
        Me.customer_name_label.AutoSize = True
        Me.customer_name_label.Location = New System.Drawing.Point(46, 76)
        Me.customer_name_label.Name = "customer_name_label"
        Me.customer_name_label.Size = New System.Drawing.Size(82, 13)
        Me.customer_name_label.TabIndex = 1
        Me.customer_name_label.Text = "Customer Name"
        '
        'customer_name
        '
        Me.customer_name.Location = New System.Drawing.Point(43, 92)
        Me.customer_name.Name = "customer_name"
        Me.customer_name.Size = New System.Drawing.Size(100, 20)
        Me.customer_name.TabIndex = 0
        '
        'CardatabaseDataSetBindingSource
        '
        Me.CardatabaseDataSetBindingSource.DataSource = Me.Car_databaseDataSet
        Me.CardatabaseDataSetBindingSource.Position = 0
        '
        'CardatabaseDataSetBindingSource1
        '
        Me.CardatabaseDataSetBindingSource1.DataSource = Me.Car_databaseDataSet
        Me.CardatabaseDataSetBindingSource1.Position = 0
        '
        'TableTableAdapter
        '
        Me.TableTableAdapter.ClearBeforeFill = True
        '
        'CardatabaseDataSetBindingSource2
        '
        Me.CardatabaseDataSetBindingSource2.DataSource = Me.Car_databaseDataSet
        Me.CardatabaseDataSetBindingSource2.Position = 0
        '
        'CardatabaseDataSetBindingSource3
        '
        Me.CardatabaseDataSetBindingSource3.DataSource = Me.Car_databaseDataSet
        Me.CardatabaseDataSetBindingSource3.Position = 0
        '
        'Car_brand_dataset
        '
        Me.Car_brand_dataset.DataSetName = "car_brand_dataset"
        Me.Car_brand_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CarbranddatasetBindingSource
        '
        Me.CarbranddatasetBindingSource.DataSource = Me.Car_brand_dataset
        Me.CarbranddatasetBindingSource.Position = 0
        '
        'CarbranddatasetBindingSource1
        '
        Me.CarbranddatasetBindingSource1.DataSource = Me.Car_brand_dataset
        Me.CarbranddatasetBindingSource1.Position = 0
        '
        'CarbranddatasetBindingSource2
        '
        Me.CarbranddatasetBindingSource2.DataSource = Me.Car_brand_dataset
        Me.CarbranddatasetBindingSource2.Position = 0
        '
        'TableBindingSource1
        '
        Me.TableBindingSource1.DataMember = "Table"
        Me.TableBindingSource1.DataSource = Me.Car_brand_dataset
        '
        'TableTableAdapter1
        '
        Me.TableTableAdapter1.ClearBeforeFill = True
        '
        'TableBindingSource2
        '
        Me.TableBindingSource2.DataMember = "Table"
        Me.TableBindingSource2.DataSource = Me.Car_databaseDataSet
        '
        'TableBindingSource3
        '
        Me.TableBindingSource3.DataMember = "Table"
        Me.TableBindingSource3.DataSource = Me.Car_databaseDataSet
        '
        'form_with_db
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 496)
        Me.Controls.Add(Me.customer_case)
        Me.Name = "form_with_db"
        Me.Text = "form_with_db"
        Me.customer_case.ResumeLayout(False)
        Me.customer_case.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Car_databaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CardatabaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CardatabaseDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CardatabaseDataSetBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CardatabaseDataSetBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Car_brand_dataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarbranddatasetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarbranddatasetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarbranddatasetBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents customer_case As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents total_time_label As Label
    Friend WithEvents total_cost_label As Label
    Friend WithEvents total_time_display As TextBox
    Friend WithEvents total_cost_display As TextBox
    Friend WithEvents exit_app As Button
    Friend WithEvents clear_form As Button
    Friend WithEvents add_to_cart As Button
    Friend WithEvents phone_number As TextBox
    Friend WithEvents phone_number_label As Label
    Friend WithEvents customer_name_label As Label
    Friend WithEvents customer_name As TextBox
    Friend WithEvents CardatabaseDataSetBindingSource As BindingSource
    Friend WithEvents Car_databaseDataSet As car_databaseDataSet
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CardatabaseDataSetBindingSource1 As BindingSource
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Serviceslst As ListView
    Friend WithEvents techcompletedbutton As RadioButton
    Friend WithEvents techinprogressbutton As RadioButton
    Friend WithEvents pendingbutton As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Datedtp As DateTimePicker
    Friend WithEvents rateus As Label
    Friend WithEvents rate5 As RadioButton
    Friend WithEvents rate4 As RadioButton
    Friend WithEvents rate3 As RadioButton
    Friend WithEvents rate2 As RadioButton
    Friend WithEvents rate1 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TableBindingSource As BindingSource
    Friend WithEvents TableTableAdapter As car_databaseDataSetTableAdapters.TableTableAdapter
    Friend WithEvents submitbutton As Button
    Friend WithEvents CardatabaseDataSetBindingSource2 As BindingSource
    Friend WithEvents CardatabaseDataSetBindingSource3 As BindingSource
    Friend WithEvents Car_brand_dataset As car_brand_dataset
    Friend WithEvents CarbranddatasetBindingSource As BindingSource
    Friend WithEvents CarbranddatasetBindingSource1 As BindingSource
    Friend WithEvents CarbranddatasetBindingSource2 As BindingSource
    Friend WithEvents TableBindingSource1 As BindingSource
    Friend WithEvents TableTableAdapter1 As car_brand_datasetTableAdapters.TableTableAdapter
    Friend WithEvents TableBindingSource2 As BindingSource
    Friend WithEvents TableBindingSource3 As BindingSource
End Class
