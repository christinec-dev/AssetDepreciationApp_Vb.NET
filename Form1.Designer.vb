<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.AssetCostLabel = New System.Windows.Forms.Label()
        Me.SalvgValLabel = New System.Windows.Forms.Label()
        Me.UsefulLifeLabel = New System.Windows.Forms.Label()
        Me.DepSchedulesGB = New System.Windows.Forms.GroupBox()
        Me.DepSYDTxt = New System.Windows.Forms.RichTextBox()
        Me.DepDDPTxt = New System.Windows.Forms.RichTextBox()
        Me.SumOfDigitsLabel = New System.Windows.Forms.Label()
        Me.DoubleDeBalancesLabel = New System.Windows.Forms.Label()
        Me.UseLifeLst = New System.Windows.Forms.ComboBox()
        Me.AssetCTxt = New System.Windows.Forms.TextBox()
        Me.SalvgValTxt = New System.Windows.Forms.TextBox()
        Me.CalcBtn = New System.Windows.Forms.Button()
        Me.ExtBtn = New System.Windows.Forms.Button()
        Me.DepSchedulesGB.SuspendLayout()
        Me.SuspendLayout()
        '
        'AssetCostLabel
        '
        Me.AssetCostLabel.AutoSize = True
        Me.AssetCostLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AssetCostLabel.Location = New System.Drawing.Point(30, 66)
        Me.AssetCostLabel.Name = "AssetCostLabel"
        Me.AssetCostLabel.Size = New System.Drawing.Size(90, 17)
        Me.AssetCostLabel.TabIndex = 0
        Me.AssetCostLabel.Text = "Asset Cost:"
        '
        'SalvgValLabel
        '
        Me.SalvgValLabel.AutoSize = True
        Me.SalvgValLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalvgValLabel.Location = New System.Drawing.Point(30, 121)
        Me.SalvgValLabel.Name = "SalvgValLabel"
        Me.SalvgValLabel.Size = New System.Drawing.Size(117, 17)
        Me.SalvgValLabel.TabIndex = 1
        Me.SalvgValLabel.Text = "Salvage Value:"
        '
        'UsefulLifeLabel
        '
        Me.UsefulLifeLabel.AutoSize = True
        Me.UsefulLifeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsefulLifeLabel.Location = New System.Drawing.Point(30, 179)
        Me.UsefulLifeLabel.Name = "UsefulLifeLabel"
        Me.UsefulLifeLabel.Size = New System.Drawing.Size(91, 17)
        Me.UsefulLifeLabel.TabIndex = 2
        Me.UsefulLifeLabel.Text = "Useful Life:"
        '
        'DepSchedulesGB
        '
        Me.DepSchedulesGB.Controls.Add(Me.DepSYDTxt)
        Me.DepSchedulesGB.Controls.Add(Me.DepDDPTxt)
        Me.DepSchedulesGB.Controls.Add(Me.SumOfDigitsLabel)
        Me.DepSchedulesGB.Controls.Add(Me.DoubleDeBalancesLabel)
        Me.DepSchedulesGB.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepSchedulesGB.Location = New System.Drawing.Point(371, 41)
        Me.DepSchedulesGB.Name = "DepSchedulesGB"
        Me.DepSchedulesGB.Size = New System.Drawing.Size(474, 333)
        Me.DepSchedulesGB.TabIndex = 3
        Me.DepSchedulesGB.TabStop = False
        Me.DepSchedulesGB.Text = "Depreciation Schedules"
        '
        'DepSYDTxt
        '
        Me.DepSYDTxt.Location = New System.Drawing.Point(248, 80)
        Me.DepSYDTxt.Name = "DepSYDTxt"
        Me.DepSYDTxt.Size = New System.Drawing.Size(202, 228)
        Me.DepSYDTxt.TabIndex = 7
        Me.DepSYDTxt.Text = "Year" & Global.Microsoft.VisualBasic.ChrW(9) & "Depreciation"
        '
        'DepDDPTxt
        '
        Me.DepDDPTxt.Location = New System.Drawing.Point(17, 80)
        Me.DepDDPTxt.Name = "DepDDPTxt"
        Me.DepDDPTxt.Size = New System.Drawing.Size(202, 228)
        Me.DepDDPTxt.TabIndex = 6
        Me.DepDDPTxt.Text = "Year" & Global.Microsoft.VisualBasic.ChrW(9) & "Depreciation"
        '
        'SumOfDigitsLabel
        '
        Me.SumOfDigitsLabel.AutoSize = True
        Me.SumOfDigitsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SumOfDigitsLabel.Location = New System.Drawing.Point(245, 60)
        Me.SumOfDigitsLabel.Name = "SumOfDigitsLabel"
        Me.SumOfDigitsLabel.Size = New System.Drawing.Size(185, 17)
        Me.SumOfDigitsLabel.TabIndex = 5
        Me.SumOfDigitsLabel.Text = "Sum of first years digits:"
        '
        'DoubleDeBalancesLabel
        '
        Me.DoubleDeBalancesLabel.AutoSize = True
        Me.DoubleDeBalancesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DoubleDeBalancesLabel.Location = New System.Drawing.Point(14, 60)
        Me.DoubleDeBalancesLabel.Name = "DoubleDeBalancesLabel"
        Me.DoubleDeBalancesLabel.Size = New System.Drawing.Size(205, 17)
        Me.DoubleDeBalancesLabel.TabIndex = 4
        Me.DoubleDeBalancesLabel.Text = "Double-declining balances:"
        '
        'UseLifeLst
        '
        Me.UseLifeLst.FormattingEnabled = True
        Me.UseLifeLst.Items.AddRange(New Object() {"3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.UseLifeLst.Location = New System.Drawing.Point(154, 179)
        Me.UseLifeLst.Name = "UseLifeLst"
        Me.UseLifeLst.Size = New System.Drawing.Size(175, 24)
        Me.UseLifeLst.TabIndex = 6
        '
        'AssetCTxt
        '
        Me.AssetCTxt.Location = New System.Drawing.Point(154, 66)
        Me.AssetCTxt.Name = "AssetCTxt"
        Me.AssetCTxt.Size = New System.Drawing.Size(175, 22)
        Me.AssetCTxt.TabIndex = 7
        '
        'SalvgValTxt
        '
        Me.SalvgValTxt.Location = New System.Drawing.Point(154, 121)
        Me.SalvgValTxt.Name = "SalvgValTxt"
        Me.SalvgValTxt.Size = New System.Drawing.Size(175, 22)
        Me.SalvgValTxt.TabIndex = 8
        '
        'CalcBtn
        '
        Me.CalcBtn.Location = New System.Drawing.Point(33, 283)
        Me.CalcBtn.Name = "CalcBtn"
        Me.CalcBtn.Size = New System.Drawing.Size(149, 46)
        Me.CalcBtn.TabIndex = 9
        Me.CalcBtn.Text = "Calculate Depreciation Value"
        Me.CalcBtn.UseVisualStyleBackColor = True
        '
        'ExtBtn
        '
        Me.ExtBtn.Location = New System.Drawing.Point(200, 283)
        Me.ExtBtn.Name = "ExtBtn"
        Me.ExtBtn.Size = New System.Drawing.Size(149, 46)
        Me.ExtBtn.TabIndex = 10
        Me.ExtBtn.Text = "Exit"
        Me.ExtBtn.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 450)
        Me.Controls.Add(Me.ExtBtn)
        Me.Controls.Add(Me.CalcBtn)
        Me.Controls.Add(Me.SalvgValTxt)
        Me.Controls.Add(Me.AssetCTxt)
        Me.Controls.Add(Me.UseLifeLst)
        Me.Controls.Add(Me.DepSchedulesGB)
        Me.Controls.Add(Me.UsefulLifeLabel)
        Me.Controls.Add(Me.SalvgValLabel)
        Me.Controls.Add(Me.AssetCostLabel)
        Me.Name = "FormMain"
        Me.Text = "RGIT annual asset depreciation App"
        Me.DepSchedulesGB.ResumeLayout(False)
        Me.DepSchedulesGB.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AssetCostLabel As Label
    Friend WithEvents SalvgValLabel As Label
    Friend WithEvents UsefulLifeLabel As Label
    Friend WithEvents DepSchedulesGB As GroupBox
    Friend WithEvents SumOfDigitsLabel As Label
    Friend WithEvents DoubleDeBalancesLabel As Label
    Friend WithEvents UseLifeLst As ComboBox
    Friend WithEvents AssetCTxt As TextBox
    Friend WithEvents SalvgValTxt As TextBox
    Friend WithEvents CalcBtn As Button
    Friend WithEvents ExtBtn As Button
    Friend WithEvents DepDDPTxt As RichTextBox
    Friend WithEvents DepSYDTxt As RichTextBox
End Class
