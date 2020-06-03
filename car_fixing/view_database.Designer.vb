<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class view_database
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ServicesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Car_databaseDataSet = New car_fixing.car_databaseDataSet()
        Me.CardatabaseDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableTableAdapter = New car_fixing.car_databaseDataSetTableAdapters.TableTableAdapter()
        Me.updatebutton = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Car_databaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CardatabaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ServicesDataGridViewTextBoxColumn, Me.TimeDataGridViewTextBoxColumn, Me.CostDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TableBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(64, 69)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(343, 213)
        Me.DataGridView1.TabIndex = 0
        '
        'ServicesDataGridViewTextBoxColumn
        '
        Me.ServicesDataGridViewTextBoxColumn.DataPropertyName = "services"
        Me.ServicesDataGridViewTextBoxColumn.HeaderText = "services"
        Me.ServicesDataGridViewTextBoxColumn.Name = "ServicesDataGridViewTextBoxColumn"
        '
        'TimeDataGridViewTextBoxColumn
        '
        Me.TimeDataGridViewTextBoxColumn.DataPropertyName = "time"
        Me.TimeDataGridViewTextBoxColumn.HeaderText = "time"
        Me.TimeDataGridViewTextBoxColumn.Name = "TimeDataGridViewTextBoxColumn"
        '
        'CostDataGridViewTextBoxColumn
        '
        Me.CostDataGridViewTextBoxColumn.DataPropertyName = "cost"
        Me.CostDataGridViewTextBoxColumn.HeaderText = "cost"
        Me.CostDataGridViewTextBoxColumn.Name = "CostDataGridViewTextBoxColumn"
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
        'CardatabaseDataSetBindingSource
        '
        Me.CardatabaseDataSetBindingSource.DataSource = Me.Car_databaseDataSet
        Me.CardatabaseDataSetBindingSource.Position = 0
        '
        'TableTableAdapter
        '
        Me.TableTableAdapter.ClearBeforeFill = True
        '
        'updatebutton
        '
        Me.updatebutton.Location = New System.Drawing.Point(553, 114)
        Me.updatebutton.Name = "updatebutton"
        Me.updatebutton.Size = New System.Drawing.Size(75, 23)
        Me.updatebutton.TabIndex = 1
        Me.updatebutton.Text = "Update"
        Me.updatebutton.UseVisualStyleBackColor = True
        '
        'view_database
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 477)
        Me.Controls.Add(Me.updatebutton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "view_database"
        Me.Text = "view_database"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Car_databaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CardatabaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CardatabaseDataSetBindingSource As BindingSource
    Friend WithEvents Car_databaseDataSet As car_databaseDataSet
    Friend WithEvents TableBindingSource As BindingSource
    Friend WithEvents TableTableAdapter As car_databaseDataSetTableAdapters.TableTableAdapter
    Friend WithEvents ServicesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents updatebutton As Button
End Class
