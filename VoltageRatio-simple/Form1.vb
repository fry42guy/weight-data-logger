'A reference to the Phidget22.NET.dll must be added to new projects in VB.Net 
'From the "Project" menu select "Add Reference" 
'From the "Add Reference" window select the "Browse" tab 
'Browse to the directory you installed the Phidgets library to 
'The default is "C:\Program Files\Phidgets" 
'Select "Phidget22.NET.dll" and click "OK" 
'To view objects that have been added, select the "View" menu 
'Select "Object Browser" 
'Then expand the Phidget22.NET.dll item 



Imports Phidget22
Imports Phidget22.Events
Imports System.Linq

Public Class Form1
    Dim WithEvents device As Phidget22.VoltageRatioInput
    Dim open As ExampleUtils.ExampleUtils.CommandLineOpen
    Dim errorBox As ErrorEventBox
    Dim m_Logger As New DataloggerForm
    Public Sub New()
        open = New ExampleUtils.ExampleUtils.CommandLineOpen(Me)
        Phidget22.Phidget.InvokeEventCallbacks = True
        InitializeComponent()
    End Sub

    Public Sub New(ByVal commandLine As String())
        open = New ExampleUtils.ExampleUtils.CommandLineOpen(Me)
        open.commandLine = commandLine
        Phidget22.Phidget.InvokeEventCallbacks = True

        InitializeComponent()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        errorBox = New ErrorEventBox(Me)
        device = New Phidget22.VoltageRatioInput()

        Dim phidgetParameters As ExampleUtils.commandLineData = open.parseCmdLine()

        Try 'set all the values grabbed from command line.  these values have defaults that are set in ExampleUtils.vb, you can check there to see them
            device.Channel = phidgetParameters.Channel 'selects the channel on the device to open
            device.DeviceSerialNumber = phidgetParameters.SerialNumber 'selects the device or hub to open
            device.HubPort = phidgetParameters.HubPort 'selects th eport on the hub to open
            device.IsHubPortDevice = phidgetParameters.isHubPortDevice 'is the device a port on a vint hub?

            If phidgetParameters.isRemote Then 'are we trying to open a remote device?
                device.IsRemote = True
                Net.EnableServerDiscovery(ServerType.Device) 'turn on network scan
                If phidgetParameters.Password <> vbNullString And phidgetParameters.ServerName <> vbNullString Then
                    Net.SetServerPassword(phidgetParameters.ServerName, phidgetParameters.Password)
                End If
            Else
                device.IsLocal = True
            End If

            device.Open() 'open the device specified by the above parameters ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Catch ex As PhidgetException
            errorBox.addMessage("Error opening the device: " + ex.Message)
        End Try
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.DoEvents()
        If device.Attached Then
            device.Close()
        End If
    End Sub

    Private Sub device_Attach(ByVal sender As Object, ByVal e As Phidget22.Events.AttachEventArgs) Handles device.Attach
        Dim attachedDevice As VoltageRatioInput = CType(sender, VoltageRatioInput)
        PhidgetInfoBox1.FillPhidgetInfo(attachedDevice)

        Try
            dataIntervalTrk.Unit = "ms"
            dataIntervalTrk.minTxt = attachedDevice.MinDataInterval.ToString()
            dataIntervalTrk.Minimum = attachedDevice.MinDataInterval
            dataIntervalTrk.maxTxt = attachedDevice.MaxDataInterval.ToString()
            dataIntervalTrk.Maximum = attachedDevice.MaxDataInterval
            dataIntervalTrk.Value = attachedDevice.DataInterval

            changeTriggerTrk.Unit = "V/V"
            changeTriggerTrk.minTxt = attachedDevice.MinVoltageRatioChangeTrigger.ToString()
            changeTriggerTrk.Minimum = attachedDevice.MinVoltageRatioChangeTrigger
            changeTriggerTrk.Maximum = attachedDevice.MaxVoltageRatioChangeTrigger
            changeTriggerTrk.maxTxt = attachedDevice.MaxVoltageRatioChangeTrigger.ToString()
            changeTriggerTrk.Value = attachedDevice.VoltageRatioChangeTrigger
        Catch ex As Exception
            errorBox.addMessage("Error initializing device: " + ex.Message)
        End Try

        'settings specific to a channel subclass
        Select Case attachedDevice.ChannelSubClass
            Case ChannelSubClass.VoltageRatioInputBridge
                'not all gain selections are valid for all bridge devices
                If (attachedDevice.DeviceID = DeviceID.PN_1046) Then
                    Dim supportedGains As [Enum]() = New [Enum]() {Phidget22.BridgeGain.Gain_1x,
                                                                   Phidget22.BridgeGain.Gain_8x,
                                                                   Phidget22.BridgeGain.Gain_16x,
                                                                   Phidget22.BridgeGain.Gain_32x,
                                                                   Phidget22.BridgeGain.Gain_64x,
                                                                   Phidget22.BridgeGain.Gain_128x}
                    gainCombo.DataSource = supportedGains.ToList()
                    gainCombo.SelectedIndex = 0
                    enabledChk.Visible = True
                    enabledChk.Checked = False
                    attachedDevice.BridgeEnabled = False
                Else
                    Dim supportedGains As [Enum]() = New [Enum]() {Phidget22.BridgeGain.Gain_1x,
                                                                   Phidget22.BridgeGain.Gain_2x,
                                                                   Phidget22.BridgeGain.Gain_4x,
                                                                   Phidget22.BridgeGain.Gain_8x,
                                                                   Phidget22.BridgeGain.Gain_16x,
                                                                   Phidget22.BridgeGain.Gain_32x,
                                                                   Phidget22.BridgeGain.Gain_64x,
                                                                   Phidget22.BridgeGain.Gain_128x}
                    gainCombo.DataSource = supportedGains.ToList()
                    gainCombo.SelectedValue = Phidget22.BridgeGain.Gain_1x
                End If
                bridge_gain_panel.Show()
                sensor_type_panel.Hide()
                sensor_value_panel.Hide()
                gainCombo.SelectedIndex = 0
            Case Else
                bridge_gain_panel.Hide()
                If attachedDevice.ChannelSubclass = ChannelSubclass.VoltageInputSensorPort Then
                    sensorTypeCmb.DataSource = ExampleUtils.EnumHelper.ToList([Enum].GetValues(GetType(Phidget22.VoltageRatioSensorType)).Cast(Of [Enum]).ToArray()) 'appears redundant but this adds the description to the array elements by using the ToList from ExampleUtils rather than standard libraries.
                    sensor_type_panel.Show()
                    sensor_value_panel.Show()
                    sensorTypeCmb.SelectedIndex = 0
                End If
        End Select

        settingsBox.Visible = True
        outputBox.Visible = True
    End Sub

    Private Sub device_Detach(ByVal sender As Object, ByVal e As Phidget22.Events.DetachEventArgs) Handles device.Detach
        PhidgetInfoBox1.Clear()

        settingsBox.Visible = False
        outputBox.Visible = False
    End Sub

    Private Sub device_Error(ByVal sender As Object, ByVal e As Phidget22.Events.ErrorEventArgs) Handles device.Error
        errorBox.addMessage(e.Description)
    End Sub

    Private Sub device_VoltageRatioChange(ByVal sender As Object, ByVal e As Phidget22.Events.VoltageRatioInputVoltageRatioChangeEventArgs) Handles device.VoltageRatioChange
        Try
            voltageTxt.Text = e.VoltageRatio.ToString("F4") + " V/V"
        Catch ex As Exception
            errorBox.addMessage("Error reading output: " + ex.Message)
        End Try
    End Sub

    Private Sub device_SensorValueChange(ByVal sender As Object, ByVal e As Phidget22.Events.VoltageRatioInputSensorChangeEventArgs) Handles device.SensorChange
        Try
            sensorTxt.Text = device.SensorValue.ToString("F4") + " " + device.SensorUnit.ToString()
        Catch ex As PhidgetException
            errorBox.addMessage("Error reading sensor value: " + ex.Message)
        End Try
    End Sub

    Private Sub dataIntervalTrk_Scroll(sender As Object, e As EventArgs) Handles dataIntervalTrk.LogScroll
        If (MouseButtons = MouseButtons.Left) Then
            Try
                device.DataInterval = CType(dataIntervalTrk.Value, Integer)
            Catch ex As Exception
                errorBox.addMessage("Error setting data interval: " + ex.Message)
            End Try
        End If
    End Sub

    Private Sub dataIntervalTrk_LogMouseUp(sender As Object, e As EventArgs) Handles dataIntervalTrk.LogMouseUp
        Try
            device.DataInterval = CType(dataIntervalTrk.Value, Integer)
        Catch ex As Exception
            errorBox.addMessage("Error setting data interval: " + ex.Message)
        End Try
    End Sub

    Private Sub changeTriggertrk_Scroll(sender As Object, e As EventArgs) Handles changeTriggerTrk.LogScroll
        If (MouseButtons = MouseButtons.Left) Then
            Try
                device.VoltageRatioChangeTrigger = CType(changeTriggerTrk.Value, Double)
            Catch ex As Exception
                errorBox.addMessage("Error setting data interval: " + ex.Message)
            End Try
        End If
    End Sub

    Private Sub changeTriggerTrk_LogMouseUp(sender As Object, e As EventArgs) Handles changeTriggerTrk.LogMouseUp
        Try
            device.VoltageRatioChangeTrigger = CType(changeTriggerTrk.Value, Double)
        Catch ex As Exception
            errorBox.addMessage("Error setting data interval: " + ex.Message)
        End Try
    End Sub

    Private Sub gainCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gainCombo.SelectedIndexChanged
        Try
            device.BridgeGain = CType([Enum].Parse(GetType(Phidget22.BridgeGain), gainCombo.SelectedValue.ToString()), Phidget22.BridgeGain)
        Catch ex As Exception
            errorBox.addMessage("Error setting gain: " + ex.Message)
        End Try
    End Sub

    Private Sub enabledChk_CheckedChanged(sender As Object, e As EventArgs) Handles enabledChk.CheckedChanged
        Try
            device.BridgeEnabled = enabledChk.Checked
        Catch ex As Exception
            errorBox.addMessage("Error enabling: " + ex.Message)
        End Try
    End Sub

    Private Sub deviceTypeCmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sensorTypeCmb.SelectedIndexChanged
        Try
            device.SensorType = CType([Enum].Parse(GetType(Phidget22.VoltageRatioSensorType), sensorTypeCmb.SelectedValue.ToString()), Phidget22.VoltageRatioSensorType)
        Catch ex As Exception
            errorBox.addMessage("Error setting sensor type: " + ex.Message)
        End Try

        If sensorTypeCmb.SelectedIndex = 0 Then
            panel1.Enabled = True ' standard voltage ratio events (i.e. generic sensor type selected)
            sensor_value_panel.Enabled = False

        Else
            panel1.Enabled = False 'specific Event For sensor type (this disables normal events)
            sensor_value_panel.Enabled = True
        End If

    End Sub

    Public Function Getweight() As Double

        Return 0.0
    End Function


    Public Function IsGainComboItemDisabled(ByVal index As Integer) As Boolean
        Dim gain As Phidget22.BridgeGain = ([Enum].GetValues(GetType(Phidget22.BridgeGain)))(index)

        '1046 does not support a gain of 2 or 4
        If (device.DeviceID = DeviceID.PN_1046 And (gain = Phidget22.BridgeGain.Gain_2x Or gain = Phidget22.BridgeGain.Gain_4x)) Then
            Return True
        End If
        Return False
    End Function

    Private Sub DataLogger_Btn_Click(sender As Object, e As EventArgs) Handles DataLogger_Btn.Click

        device.Close()


        Dim m_Logger As New DataloggerForm()

        m_Logger.ShowDialog()

        device.Open()

    End Sub
End Class



