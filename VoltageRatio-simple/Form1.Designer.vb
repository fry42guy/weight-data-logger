<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.settingsBox = New System.Windows.Forms.GroupBox()
        Me.changeTriggerTrk = New temperaturesensor_thermocouple_simple.CustomScroll()
        Me.dataIntervalTrk = New temperaturesensor_thermocouple_simple.CustomScroll()
        Me.bridge_gain_panel = New System.Windows.Forms.Panel()
        Me.gainLbl = New System.Windows.Forms.Label()
        Me.gainCombo = New System.Windows.Forms.ComboBox()
        Me.enabledChk = New System.Windows.Forms.CheckBox()
        Me.outputBox = New System.Windows.Forms.GroupBox()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.label5 = New System.Windows.Forms.Label()
        Me.voltageTxt = New System.Windows.Forms.TextBox()
        Me.sensor_value_panel = New System.Windows.Forms.Panel()
        Me.label11 = New System.Windows.Forms.Label()
        Me.sensorTxt = New System.Windows.Forms.TextBox()
        Me.sensor_type_panel = New System.Windows.Forms.Panel()
        Me.sensorTypeLbl = New System.Windows.Forms.Label()
        Me.sensorTypeCmb = New System.Windows.Forms.ComboBox()
        Me.PhidgetInfoBox1 = New temperaturesensor_thermocouple_simple.ExampleUtils.PhidgetInfoBox()
        Me.DataLogger_Btn = New System.Windows.Forms.Button()
        Me.settingsBox.SuspendLayout()
        Me.bridge_gain_panel.SuspendLayout()
        Me.outputBox.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.sensor_value_panel.SuspendLayout()
        Me.sensor_type_panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'settingsBox
        '
        Me.settingsBox.AutoSize = True
        Me.settingsBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.settingsBox.Controls.Add(Me.changeTriggerTrk)
        Me.settingsBox.Controls.Add(Me.dataIntervalTrk)
        Me.settingsBox.Controls.Add(Me.bridge_gain_panel)
        Me.settingsBox.Controls.Add(Me.enabledChk)
        Me.settingsBox.Location = New System.Drawing.Point(18, 154)
        Me.settingsBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.settingsBox.Name = "settingsBox"
        Me.settingsBox.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.settingsBox.Size = New System.Drawing.Size(418, 238)
        Me.settingsBox.TabIndex = 2
        Me.settingsBox.TabStop = False
        Me.settingsBox.Text = "Settings"
        Me.settingsBox.Visible = False
        '
        'changeTriggerTrk
        '
        Me.changeTriggerTrk.isIntValue = False
        Me.changeTriggerTrk.labelTxt = "Change Trigger:"
        Me.changeTriggerTrk.Location = New System.Drawing.Point(9, 29)
        Me.changeTriggerTrk.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.changeTriggerTrk.Maximum = -1.0R
        Me.changeTriggerTrk.maxTxt = "max"
        Me.changeTriggerTrk.Minimum = -1.0R
        Me.changeTriggerTrk.minTxt = "min"
        Me.changeTriggerTrk.Name = "changeTriggerTrk"
        Me.changeTriggerTrk.Size = New System.Drawing.Size(399, 68)
        Me.changeTriggerTrk.TabIndex = 106
        Me.changeTriggerTrk.trkText = ""
        Me.changeTriggerTrk.Unit = ""
        Me.changeTriggerTrk.Value = -1.0R
        '
        'dataIntervalTrk
        '
        Me.dataIntervalTrk.isIntValue = True
        Me.dataIntervalTrk.labelTxt = "Data Interval:"
        Me.dataIntervalTrk.Location = New System.Drawing.Point(9, 100)
        Me.dataIntervalTrk.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.dataIntervalTrk.Maximum = -1.0R
        Me.dataIntervalTrk.maxTxt = "max"
        Me.dataIntervalTrk.Minimum = -1.0R
        Me.dataIntervalTrk.minTxt = "min"
        Me.dataIntervalTrk.Name = "dataIntervalTrk"
        Me.dataIntervalTrk.Size = New System.Drawing.Size(399, 68)
        Me.dataIntervalTrk.TabIndex = 105
        Me.dataIntervalTrk.trkText = ""
        Me.dataIntervalTrk.Unit = ""
        Me.dataIntervalTrk.Value = -1.0R
        '
        'bridge_gain_panel
        '
        Me.bridge_gain_panel.Controls.Add(Me.gainLbl)
        Me.bridge_gain_panel.Controls.Add(Me.gainCombo)
        Me.bridge_gain_panel.Location = New System.Drawing.Point(9, 172)
        Me.bridge_gain_panel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bridge_gain_panel.Name = "bridge_gain_panel"
        Me.bridge_gain_panel.Size = New System.Drawing.Size(252, 37)
        Me.bridge_gain_panel.TabIndex = 104
        '
        'gainLbl
        '
        Me.gainLbl.AutoSize = True
        Me.gainLbl.Location = New System.Drawing.Point(4, 6)
        Me.gainLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.gainLbl.Name = "gainLbl"
        Me.gainLbl.Size = New System.Drawing.Size(97, 20)
        Me.gainLbl.TabIndex = 2
        Me.gainLbl.Text = "Bridge Gain:"
        '
        'gainCombo
        '
        Me.gainCombo.DisplayMember = "Value"
        Me.gainCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.gainCombo.FormattingEnabled = True
        Me.gainCombo.Location = New System.Drawing.Point(111, 5)
        Me.gainCombo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gainCombo.Name = "gainCombo"
        Me.gainCombo.Size = New System.Drawing.Size(130, 28)
        Me.gainCombo.TabIndex = 0
        Me.gainCombo.TabStop = False
        Me.gainCombo.ValueMember = "Key"
        '
        'enabledChk
        '
        Me.enabledChk.AutoSize = True
        Me.enabledChk.Location = New System.Drawing.Point(291, 177)
        Me.enabledChk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.enabledChk.Name = "enabledChk"
        Me.enabledChk.Size = New System.Drawing.Size(85, 24)
        Me.enabledChk.TabIndex = 1
        Me.enabledChk.TabStop = False
        Me.enabledChk.Text = "Enable"
        Me.enabledChk.UseVisualStyleBackColor = True
        Me.enabledChk.Visible = False
        '
        'outputBox
        '
        Me.outputBox.Controls.Add(Me.panel1)
        Me.outputBox.Controls.Add(Me.sensor_value_panel)
        Me.outputBox.Controls.Add(Me.sensor_type_panel)
        Me.outputBox.Location = New System.Drawing.Point(448, 154)
        Me.outputBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.outputBox.Name = "outputBox"
        Me.outputBox.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.outputBox.Size = New System.Drawing.Size(387, 174)
        Me.outputBox.TabIndex = 3
        Me.outputBox.TabStop = False
        Me.outputBox.Text = "Data"
        Me.outputBox.Visible = False
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.label5)
        Me.panel1.Controls.Add(Me.voltageTxt)
        Me.panel1.Location = New System.Drawing.Point(9, 29)
        Me.panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(369, 37)
        Me.panel1.TabIndex = 106
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(4, 9)
        Me.label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(110, 20)
        Me.label5.TabIndex = 1
        Me.label5.Text = "Voltage Ratio:"
        '
        'voltageTxt
        '
        Me.voltageTxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.voltageTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.voltageTxt.Location = New System.Drawing.Point(123, 9)
        Me.voltageTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.voltageTxt.Name = "voltageTxt"
        Me.voltageTxt.ReadOnly = True
        Me.voltageTxt.Size = New System.Drawing.Size(242, 19)
        Me.voltageTxt.TabIndex = 16
        Me.voltageTxt.TabStop = False
        '
        'sensor_value_panel
        '
        Me.sensor_value_panel.Controls.Add(Me.label11)
        Me.sensor_value_panel.Controls.Add(Me.sensorTxt)
        Me.sensor_value_panel.Location = New System.Drawing.Point(9, 120)
        Me.sensor_value_panel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.sensor_value_panel.Name = "sensor_value_panel"
        Me.sensor_value_panel.Size = New System.Drawing.Size(369, 37)
        Me.sensor_value_panel.TabIndex = 105
        Me.sensor_value_panel.Visible = False
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(4, 9)
        Me.label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(109, 20)
        Me.label11.TabIndex = 2
        Me.label11.Text = "Sensor Value:"
        '
        'sensorTxt
        '
        Me.sensorTxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sensorTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.sensorTxt.Location = New System.Drawing.Point(123, 9)
        Me.sensorTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.sensorTxt.Name = "sensorTxt"
        Me.sensorTxt.ReadOnly = True
        Me.sensorTxt.Size = New System.Drawing.Size(242, 19)
        Me.sensorTxt.TabIndex = 17
        Me.sensorTxt.TabStop = False
        '
        'sensor_type_panel
        '
        Me.sensor_type_panel.Controls.Add(Me.sensorTypeLbl)
        Me.sensor_type_panel.Controls.Add(Me.sensorTypeCmb)
        Me.sensor_type_panel.Location = New System.Drawing.Point(9, 75)
        Me.sensor_type_panel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.sensor_type_panel.Name = "sensor_type_panel"
        Me.sensor_type_panel.Size = New System.Drawing.Size(369, 37)
        Me.sensor_type_panel.TabIndex = 105
        Me.sensor_type_panel.Visible = False
        '
        'sensorTypeLbl
        '
        Me.sensorTypeLbl.AutoSize = True
        Me.sensorTypeLbl.Location = New System.Drawing.Point(4, 8)
        Me.sensorTypeLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.sensorTypeLbl.Name = "sensorTypeLbl"
        Me.sensorTypeLbl.Size = New System.Drawing.Size(102, 20)
        Me.sensorTypeLbl.TabIndex = 9
        Me.sensorTypeLbl.Text = "Sensor Type:"
        '
        'sensorTypeCmb
        '
        Me.sensorTypeCmb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sensorTypeCmb.DisplayMember = "Value"
        Me.sensorTypeCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sensorTypeCmb.DropDownWidth = 350
        Me.sensorTypeCmb.FormattingEnabled = True
        Me.sensorTypeCmb.Location = New System.Drawing.Point(118, 3)
        Me.sensorTypeCmb.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.sensorTypeCmb.Name = "sensorTypeCmb"
        Me.sensorTypeCmb.Size = New System.Drawing.Size(244, 28)
        Me.sensorTypeCmb.TabIndex = 0
        Me.sensorTypeCmb.ValueMember = "Key"
        '
        'PhidgetInfoBox1
        '
        Me.PhidgetInfoBox1.Location = New System.Drawing.Point(18, 18)
        Me.PhidgetInfoBox1.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.PhidgetInfoBox1.Name = "PhidgetInfoBox1"
        Me.PhidgetInfoBox1.Size = New System.Drawing.Size(818, 126)
        Me.PhidgetInfoBox1.TabIndex = 0
        '
        'DataLogger_Btn
        '
        Me.DataLogger_Btn.Location = New System.Drawing.Point(487, 31)
        Me.DataLogger_Btn.Name = "DataLogger_Btn"
        Me.DataLogger_Btn.Size = New System.Drawing.Size(237, 42)
        Me.DataLogger_Btn.TabIndex = 4
        Me.DataLogger_Btn.Text = "Data Logger"
        Me.DataLogger_Btn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(846, 406)
        Me.Controls.Add(Me.DataLogger_Btn)
        Me.Controls.Add(Me.settingsBox)
        Me.Controls.Add(Me.outputBox)
        Me.Controls.Add(Me.PhidgetInfoBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Voltage Ratio"
        Me.settingsBox.ResumeLayout(False)
        Me.settingsBox.PerformLayout()
        Me.bridge_gain_panel.ResumeLayout(False)
        Me.bridge_gain_panel.PerformLayout()
        Me.outputBox.ResumeLayout(False)
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.sensor_value_panel.ResumeLayout(False)
        Me.sensor_value_panel.PerformLayout()
        Me.sensor_type_panel.ResumeLayout(False)
        Me.sensor_type_panel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PhidgetInfoBox1 As ExampleUtils.PhidgetInfoBox
    Private WithEvents settingsBox As GroupBox
    Private WithEvents bridge_gain_panel As Panel
    Private WithEvents gainLbl As Label
    Private WithEvents gainCombo As ComboBox
    Private WithEvents enabledChk As CheckBox
    Private WithEvents outputBox As GroupBox
    Private WithEvents panel1 As Panel
    Private WithEvents label5 As Label
    Private WithEvents voltageTxt As TextBox
    Private WithEvents sensor_value_panel As Panel
    Private WithEvents label11 As Label
    Private WithEvents sensorTxt As TextBox
    Private WithEvents sensor_type_panel As Panel
    Private WithEvents sensorTypeLbl As Label
    Private WithEvents sensorTypeCmb As ComboBox
    Friend WithEvents changeTriggerTrk As CustomScroll
    Friend WithEvents dataIntervalTrk As CustomScroll
    Friend WithEvents DataLogger_Btn As Button
End Class
