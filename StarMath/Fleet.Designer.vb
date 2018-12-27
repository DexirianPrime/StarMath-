<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFleet
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbByOurBlood = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BaseFleetGrid2 = New StarMath.BaseFleetGrid()
        Me.BaseFleetGrid1 = New StarMath.BaseFleetGrid()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(823, 697)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(904, 697)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 2
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(403, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(182, 24)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "ATTACKING FLEET"
        '
        'cbByOurBlood
        '
        Me.cbByOurBlood.AutoSize = True
        Me.cbByOurBlood.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cbByOurBlood.Location = New System.Drawing.Point(35, 343)
        Me.cbByOurBlood.Name = "cbByOurBlood"
        Me.cbByOurBlood.Size = New System.Drawing.Size(94, 17)
        Me.cbByOurBlood.TabIndex = 26
        Me.cbByOurBlood.Text = "By Our Blood I"
        Me.cbByOurBlood.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(403, 365)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 24)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "DEFENDING FLEETS"
        '
        'BaseFleetGrid2
        '
        Me.BaseFleetGrid2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BaseFleetGrid2.Location = New System.Drawing.Point(35, 410)
        Me.BaseFleetGrid2.Name = "BaseFleetGrid2"
        Me.BaseFleetGrid2.Size = New System.Drawing.Size(925, 278)
        Me.BaseFleetGrid2.TabIndex = 27
        '
        'BaseFleetGrid1
        '
        Me.BaseFleetGrid1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BaseFleetGrid1.Location = New System.Drawing.Point(35, 45)
        Me.BaseFleetGrid1.Name = "BaseFleetGrid1"
        Me.BaseFleetGrid1.Size = New System.Drawing.Size(925, 278)
        Me.BaseFleetGrid1.TabIndex = 0
        '
        'frmFleet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 732)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BaseFleetGrid2)
        Me.Controls.Add(Me.cbByOurBlood)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.BaseFleetGrid1)
        Me.Name = "frmFleet"
        Me.Text = "Fleet Input"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BaseFleetGrid1 As BaseFleetGrid
    Friend WithEvents btnBack As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents cbByOurBlood As CheckBox
    Friend WithEvents BaseFleetGrid2 As BaseFleetGrid
    Friend WithEvents Label2 As Label
End Class
