<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Selector
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Selector))
        Me.btnBattleCalc = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnExpoPlan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBattleCalc
        '
        Me.btnBattleCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBattleCalc.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBattleCalc.Location = New System.Drawing.Point(14, 230)
        Me.btnBattleCalc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBattleCalc.Name = "btnBattleCalc"
        Me.btnBattleCalc.Size = New System.Drawing.Size(132, 42)
        Me.btnBattleCalc.TabIndex = 0
        Me.btnBattleCalc.Text = "&Battle Calculator"
        Me.btnBattleCalc.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(13, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Welcome to StarMath!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(49, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(403, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Battle Calc allows you to calculate the fleets required to overcome a"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(49, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(223, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "scanned or a well-known NPC target."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(49, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(225, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Expo planner is not yet implemented."
        '
        'btnExpoPlan
        '
        Me.btnExpoPlan.Enabled = False
        Me.btnExpoPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExpoPlan.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpoPlan.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.btnExpoPlan.Location = New System.Drawing.Point(334, 230)
        Me.btnExpoPlan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExpoPlan.Name = "btnExpoPlan"
        Me.btnExpoPlan.Size = New System.Drawing.Size(132, 42)
        Me.btnExpoPlan.TabIndex = 6
        Me.btnExpoPlan.Text = "&Expo Planner"
        Me.btnExpoPlan.UseVisualStyleBackColor = True
        '
        'Selector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(478, 282)
        Me.Controls.Add(Me.btnExpoPlan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBattleCalc)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Selector"
        Me.Text = "StarMath"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBattleCalc As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnExpoPlan As Button
End Class
