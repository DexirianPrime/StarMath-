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
        Me.cbdfleet1card = New System.Windows.Forms.ComboBox()
        Me.cbdfleet1hull = New System.Windows.Forms.ComboBox()
        Me.cbdfleet1hard = New System.Windows.Forms.ComboBox()
        Me.tbdfleet1size = New System.Windows.Forms.TextBox()
        Me.cbdfleet1type = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbdfleet2card = New System.Windows.Forms.ComboBox()
        Me.cbdfleet2hull = New System.Windows.Forms.ComboBox()
        Me.cbdfleet2hard = New System.Windows.Forms.ComboBox()
        Me.tbdfleet2size = New System.Windows.Forms.TextBox()
        Me.cbdfleet2type = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(245, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(185, 24)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "DEFENDING FLEET"
        '
        'cbdfleet1card
        '
        Me.cbdfleet1card.FormattingEnabled = True
        Me.cbdfleet1card.Items.AddRange(New Object() {"Fleet Cadet", "Max Rykov"})
        Me.cbdfleet1card.Location = New System.Drawing.Point(533, 99)
        Me.cbdfleet1card.Name = "cbdfleet1card"
        Me.cbdfleet1card.Size = New System.Drawing.Size(121, 21)
        Me.cbdfleet1card.TabIndex = 22
        '
        'cbdfleet1hull
        '
        Me.cbdfleet1hull.FormattingEnabled = True
        Me.cbdfleet1hull.Items.AddRange(New Object() {"Common HP", "Rare HP", "Epic HP", "Legendary HP", "Common DMG", "Rare DMG", "Epic DMG", "Legendary DMG"})
        Me.cbdfleet1hull.Location = New System.Drawing.Point(389, 100)
        Me.cbdfleet1hull.Name = "cbdfleet1hull"
        Me.cbdfleet1hull.Size = New System.Drawing.Size(121, 21)
        Me.cbdfleet1hull.TabIndex = 21
        '
        'cbdfleet1hard
        '
        Me.cbdfleet1hard.FormattingEnabled = True
        Me.cbdfleet1hard.Items.AddRange(New Object() {"Common HP", "Rare HP", "Epic HP", "Legendary HP", "Common DMG", "Rare DMG", "Epic DMG", "Legendary DMG"})
        Me.cbdfleet1hard.Location = New System.Drawing.Point(249, 100)
        Me.cbdfleet1hard.Name = "cbdfleet1hard"
        Me.cbdfleet1hard.Size = New System.Drawing.Size(121, 21)
        Me.cbdfleet1hard.TabIndex = 20
        '
        'tbdfleet1size
        '
        Me.tbdfleet1size.Location = New System.Drawing.Point(182, 100)
        Me.tbdfleet1size.Name = "tbdfleet1size"
        Me.tbdfleet1size.Size = New System.Drawing.Size(51, 20)
        Me.tbdfleet1size.TabIndex = 19
        '
        'cbdfleet1type
        '
        Me.cbdfleet1type.FormattingEnabled = True
        Me.cbdfleet1type.Items.AddRange(New Object() {"Corvette", "Patrol Ship", "Frigate", "Destroyer", "Gunship", "Carrier", "Dreadnaught"})
        Me.cbdfleet1type.Location = New System.Drawing.Point(26, 100)
        Me.cbdfleet1type.Name = "cbdfleet1type"
        Me.cbdfleet1type.Size = New System.Drawing.Size(121, 21)
        Me.cbdfleet1type.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(554, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Fleet Character"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(271, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Hardpoint Card"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(421, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Hull Card"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(180, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Fleet Size"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Ship Type"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(578, 321)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Next"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(471, 321)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cbdfleet2card
        '
        Me.cbdfleet2card.FormattingEnabled = True
        Me.cbdfleet2card.Items.AddRange(New Object() {"Fleet Cadet", "Max Rykov"})
        Me.cbdfleet2card.Location = New System.Drawing.Point(533, 141)
        Me.cbdfleet2card.Name = "cbdfleet2card"
        Me.cbdfleet2card.Size = New System.Drawing.Size(121, 21)
        Me.cbdfleet2card.TabIndex = 30
        '
        'cbdfleet2hull
        '
        Me.cbdfleet2hull.FormattingEnabled = True
        Me.cbdfleet2hull.Items.AddRange(New Object() {"Common HP", "Rare HP", "Epic HP", "Legendary HP", "Common DMG", "Rare DMG", "Epic DMG", "Legendary DMG"})
        Me.cbdfleet2hull.Location = New System.Drawing.Point(389, 142)
        Me.cbdfleet2hull.Name = "cbdfleet2hull"
        Me.cbdfleet2hull.Size = New System.Drawing.Size(121, 21)
        Me.cbdfleet2hull.TabIndex = 29
        '
        'cbdfleet2hard
        '
        Me.cbdfleet2hard.FormattingEnabled = True
        Me.cbdfleet2hard.Items.AddRange(New Object() {"Common HP", "Rare HP", "Epic HP", "Legendary HP", "Common DMG", "Rare DMG", "Epic DMG", "Legendary DMG"})
        Me.cbdfleet2hard.Location = New System.Drawing.Point(249, 142)
        Me.cbdfleet2hard.Name = "cbdfleet2hard"
        Me.cbdfleet2hard.Size = New System.Drawing.Size(121, 21)
        Me.cbdfleet2hard.TabIndex = 28
        '
        'tbdfleet2size
        '
        Me.tbdfleet2size.Location = New System.Drawing.Point(182, 142)
        Me.tbdfleet2size.Name = "tbdfleet2size"
        Me.tbdfleet2size.Size = New System.Drawing.Size(51, 20)
        Me.tbdfleet2size.TabIndex = 27
        '
        'cbdfleet2type
        '
        Me.cbdfleet2type.FormattingEnabled = True
        Me.cbdfleet2type.Items.AddRange(New Object() {"Corvette", "Patrol Ship", "Frigate", "Destroyer", "Gunship", "Carrier", "Dreadnaught"})
        Me.cbdfleet2type.Location = New System.Drawing.Point(26, 142)
        Me.cbdfleet2type.Name = "cbdfleet2type"
        Me.cbdfleet2type.Size = New System.Drawing.Size(121, 21)
        Me.cbdfleet2type.TabIndex = 26
        '
        'DefFleet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 365)
        Me.Controls.Add(Me.cbdfleet2card)
        Me.Controls.Add(Me.cbdfleet2hull)
        Me.Controls.Add(Me.cbdfleet2hard)
        Me.Controls.Add(Me.tbdfleet2size)
        Me.Controls.Add(Me.cbdfleet2type)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbdfleet1card)
        Me.Controls.Add(Me.cbdfleet1hull)
        Me.Controls.Add(Me.cbdfleet1hard)
        Me.Controls.Add(Me.tbdfleet1size)
        Me.Controls.Add(Me.cbdfleet1type)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DefFleet"
        Me.Text = "DefFleet"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents cbdfleet1card As ComboBox
    Friend WithEvents cbdfleet1hull As ComboBox
    Friend WithEvents cbdfleet1hard As ComboBox
    Friend WithEvents tbdfleet1size As TextBox
    Friend WithEvents cbdfleet1type As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents cbdfleet2card As ComboBox
    Friend WithEvents cbdfleet2hull As ComboBox
    Friend WithEvents cbdfleet2hard As ComboBox
    Friend WithEvents tbdfleet2size As TextBox
    Friend WithEvents cbdfleet2type As ComboBox
End Class
