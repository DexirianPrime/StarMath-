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

        '
        'BaseFleetGrid2
        '
        Me.BaseFleetGrid2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BaseFleetGrid2.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(683, 702)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Armed Garrisons"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.ComboBox1.Location = New System.Drawing.Point(773, 699)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(44, 21)
        Me.ComboBox1.TabIndex = 30
        '
        'frmFleet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 732)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
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
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
