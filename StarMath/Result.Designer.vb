<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Tfleet2hp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartingCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Damage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CombinedHP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CombinedDamage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FleetAttacker = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalLosses = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.count2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(558, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Battle Results"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Type, Me.StartingCount, Me.HP, Me.Damage, Me.CombinedHP, Me.CombinedDamage, Me.FleetAttacker, Me.TotalLosses, Me.count2})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 25)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1170, 478)
        Me.DataGridView1.TabIndex = 39
        '
        'Type
        '
        Me.Type.HeaderText = "Type"
        Me.Type.Name = "Type"
        '
        'StartingCount
        '
        Me.StartingCount.HeaderText = "Starting Count"
        Me.StartingCount.Name = "StartingCount"
        '
        'HP
        '
        Me.HP.HeaderText = "HP"
        Me.HP.Name = "HP"
        Me.HP.Width = 50
        '
        'Damage
        '
        Me.Damage.HeaderText = "Damage"
        Me.Damage.Name = "Damage"
        Me.Damage.Width = 50
        '
        'CombinedHP
        '
        Me.CombinedHP.HeaderText = "Total Fleet HP"
        Me.CombinedHP.Name = "CombinedHP"
        Me.CombinedHP.Width = 150
        '
        'CombinedDamage
        '
        Me.CombinedDamage.HeaderText = "Total Fleet Damage"
        Me.CombinedDamage.Name = "CombinedDamage"
        Me.CombinedDamage.Width = 150
        '
        'FleetAttacker
        '
        Me.FleetAttacker.HeaderText = "Is Attacker?"
        Me.FleetAttacker.Name = "FleetAttacker"
        Me.FleetAttacker.Width = 80
        '
        'TotalLosses
        '
        Me.TotalLosses.HeaderText = "Expected Losses"
        Me.TotalLosses.Name = "TotalLosses"
        '
        'count2
        '
        Me.count2.HeaderText = "Post-Combat Count"
        Me.count2.Name = "count2"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1009, 517)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1103, 517)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 41
        Me.Button2.Text = "Main Menu"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Tfleet2hp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1190, 552)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Tfleet2hp"
        Me.Text = "Battle Results"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Type As DataGridViewTextBoxColumn
    Friend WithEvents StartingCount As DataGridViewTextBoxColumn
    Friend WithEvents HP As DataGridViewTextBoxColumn
    Friend WithEvents Damage As DataGridViewTextBoxColumn
    Friend WithEvents CombinedHP As DataGridViewTextBoxColumn
    Friend WithEvents CombinedDamage As DataGridViewTextBoxColumn
    Friend WithEvents FleetAttacker As DataGridViewTextBoxColumn
    Friend WithEvents TotalLosses As DataGridViewTextBoxColumn
    Friend WithEvents count2 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
