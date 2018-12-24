<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DefFleet
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BaseFleetGrid1 = New StarMath.BaseFleetGrid()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(390, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(185, 24)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "DEFENDING FLEET"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(903, 330)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Next"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(796, 330)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BaseFleetGrid1
        '
        Me.BaseFleetGrid1.Location = New System.Drawing.Point(12, 46)
        Me.BaseFleetGrid1.Name = "BaseFleetGrid1"
        Me.BaseFleetGrid1.Size = New System.Drawing.Size(970, 278)
        Me.BaseFleetGrid1.TabIndex = 31
        '
        'DefFleet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 365)
        Me.Controls.Add(Me.BaseFleetGrid1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Name = "DefFleet"
        Me.Text = "Defenders"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BaseFleetGrid1 As BaseFleetGrid
End Class
