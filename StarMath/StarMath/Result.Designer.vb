<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tfleet2hp
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tfleet1 = New System.Windows.Forms.Label()
        Me.tfleet1count = New System.Windows.Forms.Label()
        Me.tfleet1hp = New System.Windows.Forms.Label()
        Me.tfleet1dmg = New System.Windows.Forms.Label()
        Me.tfleet2dmg = New System.Windows.Forms.Label()
        Me.tfleet2hpp = New System.Windows.Forms.Label()
        Me.tfleet2count = New System.Windows.Forms.Label()
        Me.tfleet2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(359, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Battle Results"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Attacking Fleets"
        '
        'tfleet1
        '
        Me.tfleet1.AutoSize = True
        Me.tfleet1.Location = New System.Drawing.Point(12, 59)
        Me.tfleet1.Name = "tfleet1"
        Me.tfleet1.Size = New System.Drawing.Size(50, 13)
        Me.tfleet1.TabIndex = 2
        Me.tfleet1.Text = "fleet type"
        '
        'tfleet1count
        '
        Me.tfleet1count.AutoSize = True
        Me.tfleet1count.Location = New System.Drawing.Point(110, 59)
        Me.tfleet1count.Name = "tfleet1count"
        Me.tfleet1count.Size = New System.Drawing.Size(42, 13)
        Me.tfleet1count.TabIndex = 3
        Me.tfleet1count.Text = "fleetcnt"
        '
        'tfleet1hp
        '
        Me.tfleet1hp.AutoSize = True
        Me.tfleet1hp.Location = New System.Drawing.Point(201, 59)
        Me.tfleet1hp.Name = "tfleet1hp"
        Me.tfleet1hp.Size = New System.Drawing.Size(39, 13)
        Me.tfleet1hp.TabIndex = 4
        Me.tfleet1hp.Text = "fleethp"
        '
        'tfleet1dmg
        '
        Me.tfleet1dmg.AutoSize = True
        Me.tfleet1dmg.Location = New System.Drawing.Point(294, 59)
        Me.tfleet1dmg.Name = "tfleet1dmg"
        Me.tfleet1dmg.Size = New System.Drawing.Size(47, 13)
        Me.tfleet1dmg.TabIndex = 5
        Me.tfleet1dmg.Text = "fleetdmg"
        '
        'tfleet2dmg
        '
        Me.tfleet2dmg.AutoSize = True
        Me.tfleet2dmg.Location = New System.Drawing.Point(294, 90)
        Me.tfleet2dmg.Name = "tfleet2dmg"
        Me.tfleet2dmg.Size = New System.Drawing.Size(47, 13)
        Me.tfleet2dmg.TabIndex = 9
        Me.tfleet2dmg.Text = "fleetdmg"
        '
        'tfleet2hpp
        '
        Me.tfleet2hpp.AutoSize = True
        Me.tfleet2hpp.Location = New System.Drawing.Point(201, 90)
        Me.tfleet2hpp.Name = "tfleet2hpp"
        Me.tfleet2hpp.Size = New System.Drawing.Size(39, 13)
        Me.tfleet2hpp.TabIndex = 8
        Me.tfleet2hpp.Text = "fleethp"
        '
        'tfleet2count
        '
        Me.tfleet2count.AutoSize = True
        Me.tfleet2count.Location = New System.Drawing.Point(110, 90)
        Me.tfleet2count.Name = "tfleet2count"
        Me.tfleet2count.Size = New System.Drawing.Size(42, 13)
        Me.tfleet2count.TabIndex = 7
        Me.tfleet2count.Text = "fleetcnt"
        '
        'tfleet2
        '
        Me.tfleet2.AutoSize = True
        Me.tfleet2.Location = New System.Drawing.Point(12, 90)
        Me.tfleet2.Name = "tfleet2"
        Me.tfleet2.Size = New System.Drawing.Size(50, 13)
        Me.tfleet2.TabIndex = 6
        Me.tfleet2.Text = "fleet type"
        '
        'tfleet2hp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tfleet2dmg)
        Me.Controls.Add(Me.tfleet2hpp)
        Me.Controls.Add(Me.tfleet2count)
        Me.Controls.Add(Me.tfleet2)
        Me.Controls.Add(Me.tfleet1dmg)
        Me.Controls.Add(Me.tfleet1hp)
        Me.Controls.Add(Me.tfleet1count)
        Me.Controls.Add(Me.tfleet1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "tfleet2hp"
        Me.Text = "Battle Results"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tfleet1 As Label
    Friend WithEvents tfleet1count As Label
    Friend WithEvents tfleet1hp As Label
    Friend WithEvents tfleet1dmg As Label
    Friend WithEvents tfleet2dmg As Label
    Friend WithEvents tfleet2hpp As Label
    Friend WithEvents tfleet2count As Label
    Friend WithEvents tfleet2 As Label
End Class
