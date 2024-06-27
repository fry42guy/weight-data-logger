Imports System.Timers
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel
Imports Phidget22
Imports Phidget22.Events
Imports System.Linq
Public Class DataloggerForm

    Public selectfolderDialog As New FolderBrowserDialog
    Public FolderPath As String
    Public Interval As Integer = 1
    Public Runtime As Integer = 1
    Public Filename As String = "Scale Data Logger"
    Public CancelProgram As Boolean = False
    Private logTimer As Timer
    Public ExcelApp As Excel.Application

    Public ExcelWorkbook As Excel.Workbook

    Public Rowindex As Integer = 2

    Public NumberofIntervals As Integer
    Public CurrentInterval As Integer
    Public offset As Double = 0
    Private Gain As Double = 50948.8540083211
    Private isCalibrated As Boolean = False

    Private loadcell As New VoltageRatioInput()



    Public Sub New()



        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub tareScale(ch As VoltageRatioInput)

        Dim numSamples As Integer = 16

        For i As Integer = 1 To numSamples

            offset += ch.VoltageRatio
            System.Threading.Thread.Sleep(ch.DataInterval)



        Next

        offset /= numSamples
        isCalibrated = True


    End Sub


    Private Sub Select_Folder_Btn_Click(sender As Object, e As EventArgs) Handles Select_Folder_Btn.Click

        selectfolderDialog.ShowDialog()

        FolderPath = selectfolderDialog.SelectedPath

        Folder_Location_Box.Text = FolderPath

    End Sub

    Private Sub Interval_Combo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Interval_Combo.SelectedIndexChanged

        Interval = Interval_Combo.SelectedItem

    End Sub

    Private Sub Run_Time_Combo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Run_Time_Combo.SelectedIndexChanged
        Runtime = Run_Time_Combo.SelectedItem

    End Sub

    Private Sub File_Name_Box_TextChanged(sender As Object, e As EventArgs) Handles File_Name_Box.TextChanged


        Filename = File_Name_Box.Text

    End Sub

    Private Sub Cancel_Btn_Click(sender As Object, e As EventArgs) Handles Cancel_Btn.Click
        Me.Close()

    End Sub

    Private Sub Pause_Btn_Click(sender As Object, e As EventArgs) Handles Pause_Btn.Click

        logTimer.Stop()
        Dim result As MsgBoxResult

        result = MsgBox("Process Pasued, Would you like to continue?" & vbNewLine & "Click Yes to Continue or No to Cancel", MsgBoxStyle.YesNo, "Paused")

        If result = MsgBoxResult.No Then

            CancelProgram = True

            Me.Close()

        Else
            logTimer.Start()


        End If


    End Sub

    Private Function GetSensorValue() As Double

        Dim weight As Double = (loadcell.VoltageRatio - offset) * Gain

        Return weight

    End Function


    Private Sub DataLogger_TEST_Run()
        offset = 0
        SetupDevice()


        Rowindex = 2

        ExcelApp = CreateObject("Excel.Application")
        ' oExcel = Excel.Application
        ExcelApp.Visible = True
        ExcelApp.DisplayAlerts = False

        CurrentInterval = 1
        Dim workbook As Workbook = ExcelApp.Workbooks.Add()
        Dim worksheet As Worksheet = workbook.Worksheets(1)

        With ExcelApp

            .Range("A2").Select()
            .ActiveCell.Value = "Time Stamp (Seconds)"
            .Range("B2").Select()
            .ActiveCell.Value = "Lbs"
            .Columns.AutoFit()

        End With
        NumberofIntervals = GetNumberofIntervals()


        logTimer = New Timer(1000 * Interval) ' Interval is set to 1000 ms (1 second)
        AddHandler logTimer.Elapsed, AddressOf OnTimedEvent

        ' Start the Timer
        logTimer.AutoReset = True ' Ensures the timer keeps firing
        logTimer.Enabled = True




    End Sub
    Private Sub AddLineToLog(Time As Double, Weight As Double)

        Rowindex = Rowindex + 1

        With ExcelApp

            .Range("A" & Rowindex).Select()
            .ActiveCell.Value = Time

            .Range("B" & Rowindex).Select()
            .ActiveCell.Value = Weight


        End With



    End Sub

    Private Sub OnTimedEvent(source As Object, e As ElapsedEventArgs)
        ' This method is called at each interval
        Dim timestamp As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        Dim value As Double = GetRandomDouble(0.0, 100.0) ' Replace this with your method to get the value

        ' Update the UI in a thread-safe manner
        If InvokeRequired Then
            Invoke(New MethodInvoker(Sub() OutputLog(timestamp, value)))
            AddLineToLog(CurrentInterval * Interval, GetSensorValue())
        Else
            OutputLog(timestamp, value)


        End If

        If CurrentInterval = NumberofIntervals Then

            logTimer.Stop()
            MsgBox("Done")
        End If
        CurrentInterval = CurrentInterval + 1

    End Sub

    Private Sub OutputLog(timestamp As String, value As Double)
        ' Output the log to a TextBox or ListBox
        Console.WriteLine($"Timestamp: {timestamp}, Value: {value}")
    End Sub

    Public Sub SetupExcelFile()

    End Sub



    Private Function GetRandomDouble(minValue As Double, maxValue As Double) As Double

        Dim rnd As New Random()
        ' Generate a random double between minValue and maxValue
        Dim value As Double = rnd.NextDouble() * (maxValue - minValue) + minValue
        ' Round to 2 decimal places
        Return Math.Round(value, 2)

    End Function

    Private Sub Run_Btn_Click(sender As Object, e As EventArgs) Handles Run_Btn.Click

        If Not String.IsNullOrEmpty(Interval_Combo.SelectedItem) Then

            If Not String.IsNullOrEmpty(Run_Time_Combo.SelectedItem) Then


                DataLogger_TEST_Run()
            Else
                MsgBox("Please Select a Runtime Amount")
            End If
        Else
            MsgBox("Please Select an Interval Amount")
        End If

    End Sub

    Public Function GetNumberofIntervals() As Integer

        Dim RunSec As Integer = Runtime * 60
        Dim Intervals As Double = RunSec / Interval

        Return CInt(Math.Round(Intervals))

    End Function

    Public Sub SetupDevice()

        loadcell.Channel = 0
        loadcell.HubPort = 0
        loadcell.DeviceSerialNumber = 716771
        loadcell.IsLocal = True
        loadcell.IsHubPortDevice = False
        loadcell.Open(5000)
        loadcell.DataInterval = 250
        System.Threading.Thread.Sleep(1000)
        tareScale(loadcell)



    End Sub

End Class