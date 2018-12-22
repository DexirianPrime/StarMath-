<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BaseFleetGrid
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.dgfleets = New System.Windows.Forms.DataGridView()
        Me.ShipType = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.FleetSize = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HardpointCard = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.HullCard = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.FleetCharacter = New System.Windows.Forms.DataGridViewComboBoxColumn()
        CType(Me.dgfleets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgfleets
        '
        Me.dgfleets.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgfleets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgfleets.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ShipType, Me.FleetSize, Me.HardpointCard, Me.HullCard, Me.FleetCharacter})
        Me.dgfleets.Location = New System.Drawing.Point(0, 0)
        Me.dgfleets.Name = "dgfleets"
        Me.dgfleets.Size = New System.Drawing.Size(936, 167)
        Me.dgfleets.TabIndex = 20
        '
        'ShipType
        '
        Me.ShipType.HeaderText = "ShipType"
        Me.ShipType.Items.AddRange(New Object() {"Corvette", "Patrol Ship", "Destroyer", "Frigate", "Gunship", "Dreadnaught", "Carrier", "Industrial"})
        Me.ShipType.Name = "ShipType"
        Me.ShipType.Width = 200
        '
        'FleetSize
        '
        Me.FleetSize.HeaderText = "FleetSize"
        Me.FleetSize.Name = "FleetSize"
        Me.FleetSize.Width = 50
        '
        'HardpointCard
        '
        Me.HardpointCard.HeaderText = "HardpointCard"
        Me.HardpointCard.Items.AddRange(New Object() {"Common HP", "Rare HP", "Epic HP", "Legendary HP", "Common DMG", "Rare DMG", "Epic DMG", "Legendary DMG"})
        Me.HardpointCard.Name = "HardpointCard"
        Me.HardpointCard.Width = 200
        '
        'HullCard
        '
        Me.HullCard.HeaderText = "HullCard"
        Me.HullCard.Items.AddRange(New Object() {"Common HP", "Rare HP", "Epic HP", "Legendary HP", "Common DMG", "Rare DMG", "Epic DMG", "Legendary DMG"})
        Me.HullCard.Name = "HullCard"
        Me.HullCard.Width = 200
        '
        'FleetCharacter
        '
        Me.FleetCharacter.HeaderText = "FleetCharacter"
        Me.FleetCharacter.Items.AddRange(New Object() {"Fleet Cadet", "Max Rykov"})
        Me.FleetCharacter.Name = "FleetCharacter"
        Me.FleetCharacter.Width = 200
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgfleets)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(936, 167)
        CType(Me.dgfleets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgfleets As DataGridView
    Friend WithEvents ShipType As DataGridViewComboBoxColumn
    Friend WithEvents FleetSize As DataGridViewTextBoxColumn
    Friend WithEvents HardpointCard As DataGridViewComboBoxColumn
    Friend WithEvents HullCard As DataGridViewComboBoxColumn
    Friend WithEvents FleetCharacter As DataGridViewComboBoxColumn
End Class
