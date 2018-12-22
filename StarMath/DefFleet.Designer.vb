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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DefFleet))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbTarget = New System.Windows.Forms.ComboBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.dgFleetList = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.fltType = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.fltAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fltWorstCase = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.fltWorstCaseLevel = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.fltHardPoint = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.fltHullCard = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.fltUtility = New System.Windows.Forms.DataGridViewComboBoxColumn()
        CType(Me.dgFleetList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(12, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 17)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "&Target:"
        '
        'cmbTarget
        '
        Me.cmbTarget.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.cmbTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTarget.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbTarget.FormattingEnabled = True
        Me.cmbTarget.Location = New System.Drawing.Point(66, 19)
        Me.cmbTarget.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbTarget.Name = "cmbTarget"
        Me.cmbTarget.Size = New System.Drawing.Size(350, 25)
        Me.cmbTarget.TabIndex = 32
        '
        'btnNext
        '
        Me.btnNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(715, 420)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(132, 42)
        Me.btnNext.TabIndex = 33
        Me.btnNext.Text = "&Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 420)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(132, 42)
        Me.btnBack.TabIndex = 34
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'dgFleetList
        '
        Me.dgFleetList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgFleetList.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dgFleetList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgFleetList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fltType, Me.fltAmount, Me.fltWorstCase, Me.fltWorstCaseLevel, Me.fltHardPoint, Me.fltHullCard, Me.fltUtility})
        Me.dgFleetList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgFleetList.Location = New System.Drawing.Point(0, 0)
        Me.dgFleetList.Name = "dgFleetList"
        Me.dgFleetList.Size = New System.Drawing.Size(835, 362)
        Me.dgFleetList.TabIndex = 35
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.Controls.Add(Me.dgFleetList)
        Me.Panel1.Location = New System.Drawing.Point(12, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(835, 362)
        Me.Panel1.TabIndex = 36
        '
        'fltType
        '
        Me.fltType.HeaderText = "Fleet Type"
        Me.fltType.Items.AddRange(New Object() {"Patrols", "Corvettes", "Scouts", "Industrials", "Destroyers", "Frigates", "Gunships", "Recons", "Carriers", "Dreadnaughts"})
        Me.fltType.Name = "fltType"
        Me.fltType.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'fltAmount
        '
        Me.fltAmount.HeaderText = "# of Ships"
        Me.fltAmount.Name = "fltAmount"
        '
        'fltWorstCase
        '
        Me.fltWorstCase.HeaderText = "Worst Case?"
        Me.fltWorstCase.Name = "fltWorstCase"
        Me.fltWorstCase.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.fltWorstCase.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'fltWorstCaseLevel
        '
        Me.fltWorstCaseLevel.HeaderText = "Worst Case Level"
        Me.fltWorstCaseLevel.Items.AddRange(New Object() {"None", "Common", "Rare", "Epic", "Legendary"})
        Me.fltWorstCaseLevel.Name = "fltWorstCaseLevel"
        '
        'fltHardPoint
        '
        Me.fltHardPoint.HeaderText = "HardPoint Card"
        Me.fltHardPoint.Items.AddRange(New Object() {"None", "Common", "Rare", "Epic", "Legendary"})
        Me.fltHardPoint.Name = "fltHardPoint"
        Me.fltHardPoint.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'fltHullCard
        '
        Me.fltHullCard.HeaderText = "Hull Card"
        Me.fltHullCard.Items.AddRange(New Object() {"None", "Common", "Rare", "Epic", "Legendary"})
        Me.fltHullCard.Name = "fltHullCard"
        Me.fltHullCard.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'fltUtility
        '
        Me.fltUtility.HeaderText = "Utility Card"
        Me.fltUtility.Items.AddRange(New Object() {"None", "Common", "Rare", "Epic", "Legendary"})
        Me.fltUtility.Name = "fltUtility"
        Me.fltUtility.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.fltUtility.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DefFleet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(856, 477)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.cmbTarget)
        Me.Controls.Add(Me.Label6)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "DefFleet"
        Me.Text = "Defending Fleets"
        CType(Me.dgFleetList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbTarget As ComboBox
    Friend WithEvents btnNext As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents dgFleetList As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents fltType As DataGridViewComboBoxColumn
    Friend WithEvents fltAmount As DataGridViewTextBoxColumn
    Friend WithEvents fltWorstCase As DataGridViewCheckBoxColumn
    Friend WithEvents fltWorstCaseLevel As DataGridViewComboBoxColumn
    Friend WithEvents fltHardPoint As DataGridViewComboBoxColumn
    Friend WithEvents fltHullCard As DataGridViewComboBoxColumn
    Friend WithEvents fltUtility As DataGridViewComboBoxColumn
End Class
