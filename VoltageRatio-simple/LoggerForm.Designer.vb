<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataloggerForm
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
        Me.Run_Btn = New System.Windows.Forms.Button()
        Me.Pause_Btn = New System.Windows.Forms.Button()
        Me.End_Now_Btn = New System.Windows.Forms.Button()
        Me.Cancel_Btn = New System.Windows.Forms.Button()
        Me.Interval_Combo = New System.Windows.Forms.ComboBox()
        Me.Run_Time_Combo = New System.Windows.Forms.ComboBox()
        Me.Folder_Location_Box = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Select_Folder_Btn = New System.Windows.Forms.Button()
        Me.File_Name_Box = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Run_Btn
        '
        Me.Run_Btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Run_Btn.Location = New System.Drawing.Point(12, 392)
        Me.Run_Btn.Name = "Run_Btn"
        Me.Run_Btn.Size = New System.Drawing.Size(100, 40)
        Me.Run_Btn.TabIndex = 0
        Me.Run_Btn.Text = "Run"
        Me.Run_Btn.UseVisualStyleBackColor = True
        '
        'Pause_Btn
        '
        Me.Pause_Btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Pause_Btn.Location = New System.Drawing.Point(137, 392)
        Me.Pause_Btn.Name = "Pause_Btn"
        Me.Pause_Btn.Size = New System.Drawing.Size(100, 40)
        Me.Pause_Btn.TabIndex = 1
        Me.Pause_Btn.Text = "Pause"
        Me.Pause_Btn.UseVisualStyleBackColor = True
        '
        'End_Now_Btn
        '
        Me.End_Now_Btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.End_Now_Btn.Location = New System.Drawing.Point(731, 392)
        Me.End_Now_Btn.Name = "End_Now_Btn"
        Me.End_Now_Btn.Size = New System.Drawing.Size(100, 40)
        Me.End_Now_Btn.TabIndex = 2
        Me.End_Now_Btn.Text = "End Now"
        Me.End_Now_Btn.UseVisualStyleBackColor = True
        '
        'Cancel_Btn
        '
        Me.Cancel_Btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel_Btn.Location = New System.Drawing.Point(866, 392)
        Me.Cancel_Btn.Name = "Cancel_Btn"
        Me.Cancel_Btn.Size = New System.Drawing.Size(100, 40)
        Me.Cancel_Btn.TabIndex = 3
        Me.Cancel_Btn.Text = "Cancel"
        Me.Cancel_Btn.UseVisualStyleBackColor = True
        '
        'Interval_Combo
        '
        Me.Interval_Combo.FormattingEnabled = True
        Me.Interval_Combo.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "10", "15", "20", "30", "60", "120"})
        Me.Interval_Combo.Location = New System.Drawing.Point(222, 32)
        Me.Interval_Combo.Name = "Interval_Combo"
        Me.Interval_Combo.Size = New System.Drawing.Size(121, 28)
        Me.Interval_Combo.TabIndex = 4
        '
        'Run_Time_Combo
        '
        Me.Run_Time_Combo.FormattingEnabled = True
        Me.Run_Time_Combo.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "10", "15", "20", "30", "60", "120", "240", "480"})
        Me.Run_Time_Combo.Location = New System.Drawing.Point(222, 95)
        Me.Run_Time_Combo.Name = "Run_Time_Combo"
        Me.Run_Time_Combo.Size = New System.Drawing.Size(121, 28)
        Me.Run_Time_Combo.TabIndex = 5
        '
        'Folder_Location_Box
        '
        Me.Folder_Location_Box.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Folder_Location_Box.Location = New System.Drawing.Point(12, 210)
        Me.Folder_Location_Box.Name = "Folder_Location_Box"
        Me.Folder_Location_Box.Size = New System.Drawing.Size(331, 26)
        Me.Folder_Location_Box.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(408, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Interval (Sec)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(408, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Run Time (Min)"
        '
        'Select_Folder_Btn
        '
        Me.Select_Folder_Btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Select_Folder_Btn.Location = New System.Drawing.Point(412, 203)
        Me.Select_Folder_Btn.Name = "Select_Folder_Btn"
        Me.Select_Folder_Btn.Size = New System.Drawing.Size(170, 40)
        Me.Select_Folder_Btn.TabIndex = 9
        Me.Select_Folder_Btn.Text = "Select Save Folder"
        Me.Select_Folder_Btn.UseVisualStyleBackColor = True
        '
        'File_Name_Box
        '
        Me.File_Name_Box.Location = New System.Drawing.Point(222, 156)
        Me.File_Name_Box.MaxLength = 64
        Me.File_Name_Box.Name = "File_Name_Box"
        Me.File_Name_Box.Size = New System.Drawing.Size(121, 26)
        Me.File_Name_Box.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(412, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "File Name"
        '
        'DataloggerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 444)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.File_Name_Box)
        Me.Controls.Add(Me.Select_Folder_Btn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Folder_Location_Box)
        Me.Controls.Add(Me.Run_Time_Combo)
        Me.Controls.Add(Me.Interval_Combo)
        Me.Controls.Add(Me.Cancel_Btn)
        Me.Controls.Add(Me.End_Now_Btn)
        Me.Controls.Add(Me.Pause_Btn)
        Me.Controls.Add(Me.Run_Btn)
        Me.MinimumSize = New System.Drawing.Size(1000, 500)
        Me.Name = "DataloggerForm"
        Me.Text = "form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Run_Btn As Button
    Friend WithEvents Pause_Btn As Button
    Friend WithEvents End_Now_Btn As Button
    Friend WithEvents Cancel_Btn As Button
    Friend WithEvents Interval_Combo As ComboBox
    Friend WithEvents Run_Time_Combo As ComboBox
    Friend WithEvents Folder_Location_Box As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Select_Folder_Btn As Button
    Friend WithEvents File_Name_Box As TextBox
    Friend WithEvents Label3 As Label
End Class
