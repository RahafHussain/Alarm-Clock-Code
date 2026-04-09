Public Class Form1

    Dim scaleFactor As Single = Me.DeviceDpi / 96.0F
    Public FullHeight As Integer = CInt(928 * scaleFactor)
    Public CollapsedHeight As Integer = CInt(400 * scaleFactor)

    Private ThisTab As TabPage
    Private Keys() As Button
    Private CurrentDigit As Integer = 1

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Height = CollapsedHeight

        TimePanel1.SetToComputerTime()
        TimePanel1.AMorPM()

        AlarmPanel1.PictureButton.BackgroundImage = My.Resources.Lily
        AlarmPanel2.PictureButton.BackgroundImage = My.Resources.Heart
        AlarmPanel3.PictureButton.BackgroundImage = My.Resources.Train
        AlarmPanel1.PictureButton.BackgroundImageLayout = ImageLayout.Stretch
        AlarmPanel2.PictureButton.BackgroundImageLayout = ImageLayout.Stretch
        AlarmPanel3.PictureButton.BackgroundImageLayout = ImageLayout.Stretch

        Keys = {Button0, Button1, Button2, Button3, Button4, Button5, Button6, Button7, Button8, Button9}
        For Each Key As Button In Keys
            AddHandler Key.Click, AddressOf DigitButton_Click
        Next
        AddHandler OKButton.Click, AddressOf OKButton_Click
        AddHandler CancelButton.Click, AddressOf CancelButton_Click
        AddHandler TimePanel1.Reset, AddressOf ResetClick
        AddHandler AlarmPanel1.TimePanel1.Reset, AddressOf ResetClick
        AddHandler AlarmPanel2.TimePanel1.Reset, AddressOf ResetClick
        AddHandler AlarmPanel3.TimePanel1.Reset, AddressOf ResetClick
        AddHandler CheckBox1.CheckedChanged, AddressOf ClockAlarm1Changed
        AddHandler CheckBox2.CheckedChanged, AddressOf ClockAlarm2Changed
        AddHandler CheckBox3.CheckedChanged, AddressOf ClockAlarm3Changed
        AddHandler AlarmPanel1.AlarmToggled, AddressOf Alarm1Toggled
        AddHandler AlarmPanel2.AlarmToggled, AddressOf Alarm2Toggled
        AddHandler AlarmPanel3.AlarmToggled, AddressOf Alarm3Toggled
    End Sub

    Private Sub ClockAlarm1Changed(sender As Object, e As EventArgs)
        AlarmPanel1.AlarmEnabled = CheckBox1.Checked
    End Sub

    Private Sub ClockAlarm2Changed(sender As Object, e As EventArgs)
        AlarmPanel2.AlarmEnabled = CheckBox2.Checked
    End Sub

    Private Sub ClockAlarm3Changed(sender As Object, e As EventArgs)
        AlarmPanel3.AlarmEnabled = CheckBox3.Checked
    End Sub

    Private Sub Alarm1Toggled(enabled As Boolean)
        CheckBox1.Checked = enabled
    End Sub

    Private Sub Alarm2Toggled(enabled As Boolean)
        CheckBox2.Checked = enabled
    End Sub

    Private Sub Alarm3Toggled(enabled As Boolean)
        CheckBox3.Checked = enabled
    End Sub

    Public Property KeypadVisibility As Boolean
        Get
            Return Keypad.Visible
        End Get
        Set(value As Boolean)
            Keypad.Visible = value
        End Set
    End Property

    Public Sub HideKeys()
        For Each Key As Button In Keys
            Dim Digit As Integer = Convert.ToInt32(Key.Text)
            Key.Enabled = IsPositionValid(Digit)
        Next
    End Sub

    Private Sub HideAllKeys()
        For Each Key As Button In Keys
            Key.Enabled = False
        Next
    End Sub

    Private Function IsPositionValid(Digit As Integer) As Boolean
        Dim CurrentTimePanel As TimePanel = If(TabControl.SelectedTab Is Clock, TimePanel1, GetCurrentTimePanel())

        Select Case CurrentDigit
            Case 1
                Return (Digit <= 1)
            Case 2
                If CurrentTimePanel.Digitled1.Digit = 1 Then
                    Return (Digit <= 2)
                Else
                    Return (Digit <= 9)
                End If
            Case 3
                Return (Digit <= 5)
            Case 4
                Return (Digit <= 9)
            Case Else
                Return True
        End Select
    End Function

    Private Sub ResetClick(ByVal IsClock As Boolean)
        If TabControl.SelectedTab Is Clock Then
            TimePanel1.SetToComputerTime()
        ElseIf TabControl.SelectedTab Is Alarm1 Then
            AlarmPanel1.TimePanel1.SetToZero()
        ElseIf TabControl.SelectedTab Is Alarm2 Then
            AlarmPanel2.TimePanel1.SetToZero()
        ElseIf TabControl.SelectedTab Is Alarm3 Then
            AlarmPanel3.TimePanel1.SetToZero()
        End If
    End Sub

    Private Sub DigitButton_Click(sender As Object, e As EventArgs)
        Dim Btn As Button = CType(sender, Button)
        Dim ClickedDigit As Integer = Convert.ToInt32(Btn.Text)
        Dim CurrentTimePanel As TimePanel = If(TabControl.SelectedTab Is Clock, TimePanel1, GetCurrentTimePanel())

        Select Case CurrentDigit
            Case 1
                CurrentTimePanel.Digitled1.Digit = ClickedDigit
            Case 2
                CurrentTimePanel.Digitled2.Digit = ClickedDigit
            Case 3
                CurrentTimePanel.Digitled3.Digit = ClickedDigit
            Case 4
                CurrentTimePanel.Digitled4.Digit = ClickedDigit
        End Select

        CurrentDigit += 1

        If CurrentDigit >= 4 Then
            HideAllKeys()
        End If

        HideKeys()
    End Sub

    Private Function GetCurrentTimePanel() As TimePanel
        If TabControl.SelectedTab Is Alarm1 Then
            Return AlarmPanel1.TimePanel1
        ElseIf TabControl.SelectedTab Is Alarm2 Then
            Return AlarmPanel2.TimePanel1
        ElseIf TabControl.SelectedTab Is Alarm3 Then
            Return AlarmPanel3.TimePanel1
        End If
        Return Nothing
    End Function

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        ThisTab = TabControl.SelectedTab
        Keypad.Visible = False
        Me.Height = CollapsedHeight
        If ThisTab Is Clock Then
            TimePanel1.SetToComputerTime()
        ElseIf ThisTab Is Alarm1 Then
            AlarmPanel1.TimePanel1.SetToZero()
        ElseIf ThisTab Is Alarm2 Then
            AlarmPanel2.TimePanel1.SetToZero()
        ElseIf ThisTab Is Alarm3 Then
            AlarmPanel3.TimePanel1.SetToZero()
        End If
        CurrentDigit = 1
    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        Keypad.Visible = False
        Me.Height = CollapsedHeight
        CurrentDigit = 1
    End Sub
End Class