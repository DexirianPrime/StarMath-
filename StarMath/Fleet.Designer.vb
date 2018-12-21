<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fleet
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbfleet1type = New System.Windows.Forms.ComboBox()
        Me.tbfleet1size = New System.Windows.Forms.TextBox()
        Me.cbfleet1hard = New System.Windows.Forms.ComboBox()
        Me.cbfleet1hull = New System.Windows.Forms.ComboBox()
        Me.cbfleet1card = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbfleet2card = New System.Windows.Forms.ComboBox()
        Me.cbfleet2hull = New System.Windows.Forms.ComboBox()
        Me.cbfleet2hard = New System.Windows.Forms.ComboBox()
        Me.tbfleet2size = New System.Windows.Forms.TextBox()
        Me.cbfleet2type = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ship Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(181, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fleet Size"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(422, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hull Card"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(272, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Hardpoint Card"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(555, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fleet Character"
        '
        'cbfleet1type
        '
        Me.cbfleet1type.FormattingEnabled = True
        Me.cbfleet1type.Items.AddRange(New Object() {"Corvette", "Patrol Ship", "Frigate", "Destroyer", "Gunship", "Carrier", "Dreadnaught", "Industrial"})
        Me.cbfleet1type.Location = New System.Drawing.Point(27, 87)
        Me.cbfleet1type.Name = "cbfleet1type"
        Me.cbfleet1type.Size = New System.Drawing.Size(121, 21)
        Me.cbfleet1type.TabIndex = 5
        '
        'tbfleet1size
        '
        Me.tbfleet1size.Location = New System.Drawing.Point(183, 87)
        Me.tbfleet1size.Name = "tbfleet1size"
        Me.tbfleet1size.Size = New System.Drawing.Size(51, 20)
        Me.tbfleet1size.TabIndex = 6
        '
        'cbfleet1hard
        '
        Me.cbfleet1hard.FormattingEnabled = True
        Me.cbfleet1hard.Items.AddRange(New Object() {"Common HP", "Rare HP", "Epic HP", "Legendary HP", "Common DMG", "Rare DMG", "Epic DMG", "Legendary DMG"})
        Me.cbfleet1hard.Location = New System.Drawing.Point(250, 87)
        Me.cbfleet1hard.Name = "cbfleet1hard"
        Me.cbfleet1hard.Size = New System.Drawing.Size(121, 21)
        Me.cbfleet1hard.TabIndex = 7
        '
        'cbfleet1hull
        '
        Me.cbfleet1hull.FormattingEnabled = True
        Me.cbfleet1hull.Items.AddRange(New Object() {"Common HP", "Rare HP", "Epic HP", "Legendary HP", "Common DMG", "Rare DMG", "Epic DMG", "Legendary DMG"})
        Me.cbfleet1hull.Location = New System.Drawing.Point(390, 87)
        Me.cbfleet1hull.Name = "cbfleet1hull"
        Me.cbfleet1hull.Size = New System.Drawing.Size(121, 21)
        Me.cbfleet1hull.TabIndex = 8
        '
        'cbfleet1card
        '
        Me.cbfleet1card.FormattingEnabled = True
        Me.cbfleet1card.Items.AddRange(New Object() {"Fleet Cadet", "Max Rykov"})
        Me.cbfleet1card.Location = New System.Drawing.Point(534, 86)
        Me.cbfleet1card.Name = "cbfleet1card"
        Me.cbfleet1card.Size = New System.Drawing.Size(121, 21)
        Me.cbfleet1card.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(473, 302)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(580, 302)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Next"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(246, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(182, 24)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "ATTACKING FLEET"
        '
        'cbfleet2card
        '
        Me.cbfleet2card.FormattingEnabled = True
        Me.cbfleet2card.Items.AddRange(New Object() {"Fleet Cadet", "Max Rykov"})
        Me.cbfleet2card.Location = New System.Drawing.Point(534, 134)
        Me.cbfleet2card.Name = "cbfleet2card"
        Me.cbfleet2card.Size = New System.Drawing.Size(121, 21)
        Me.cbfleet2card.TabIndex = 17
        '
        'cbfleet2hull
        '
        Me.cbfleet2hull.FormattingEnabled = True
        Me.cbfleet2hull.Items.AddRange(New Object() {"Common HP", "Rare HP", "Epic HP", "Legendary HP", "Common DMG", "Rare DMG", "Epic DMG", "Legendary DMG"})
        Me.cbfleet2hull.Location = New System.Drawing.Point(390, 135)
        Me.cbfleet2hull.Name = "cbfleet2hull"
        Me.cbfleet2hull.Size = New System.Drawing.Size(121, 21)
        Me.cbfleet2hull.TabIndex = 16
        '
        'cbfleet2hard
        '
        Me.cbfleet2hard.FormattingEnabled = True
        Me.cbfleet2hard.Items.AddRange(New Object() {"Common HP", "Rare HP", "Epic HP", "Legendary HP", "Common DMG", "Rare DMG", "Epic DMG", "Legendary DMG"})
        Me.cbfleet2hard.Location = New System.Drawing.Point(250, 135)
        Me.cbfleet2hard.Name = "cbfleet2hard"
        Me.cbfleet2hard.Size = New System.Drawing.Size(121, 21)
        Me.cbfleet2hard.TabIndex = 15
        '
        'tbfleet2size
        '
        Me.tbfleet2size.Location = New System.Drawing.Point(183, 135)
        Me.tbfleet2size.Name = "tbfleet2size"
        Me.tbfleet2size.Size = New System.Drawing.Size(51, 20)
        Me.tbfleet2size.TabIndex = 14
        '
        'cbfleet2type
        '
        Me.cbfleet2type.FormattingEnabled = True
        Me.cbfleet2type.Items.AddRange(New Object() {"Corvette", "Patrol Ship", "Frigate", "Destroyer", "Gunship", "Carrier", "Dreadnaught", "Industrial"})
        Me.cbfleet2type.Location = New System.Drawing.Point(27, 135)
        Me.cbfleet2type.Name = "cbfleet2type"
        Me.cbfleet2type.Size = New System.Drawing.Size(121, 21)
        Me.cbfleet2type.TabIndex = 13
        '
        'Fleet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 351)
        Me.Controls.Add(Me.cbfleet2card)
        Me.Controls.Add(Me.cbfleet2hull)
        Me.Controls.Add(Me.cbfleet2hard)
        Me.Controls.Add(Me.tbfleet2size)
        Me.Controls.Add(Me.cbfleet2type)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbfleet1card)
        Me.Controls.Add(Me.cbfleet1hull)
        Me.Controls.Add(Me.cbfleet1hard)
        Me.Controls.Add(Me.tbfleet1size)
        Me.Controls.Add(Me.cbfleet1type)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Fleet"
        Me.Text = "Attackers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbfleet1type As ComboBox
    Friend WithEvents tbfleet1size As TextBox
    Friend WithEvents cbfleet1hard As ComboBox
    Friend WithEvents cbfleet1hull As ComboBox
    Friend WithEvents cbfleet1card As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents cbfleet2card As ComboBox
    Friend WithEvents cbfleet2hull As ComboBox
    Friend WithEvents cbfleet2hard As ComboBox
    Friend WithEvents tbfleet2size As TextBox
    Friend WithEvents cbfleet2type As ComboBox
End Class
