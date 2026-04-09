Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class TimePanel

    Public Event Reset(ByVal IsClock As Boolean)

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        SetToComputerTime()

        Timer1.Interval = 1000
        Timer1.Start()
        UpdateTime()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        UpdateTime()
    End Sub

    Public Sub SetToZero()
        Digitled1.Digit = 0
        Digitled2.Digit = 0
        Digitled3.Digit = 0
        Digitled4.Digit = 0
        AMbutton.Checked = True
        PMbutton.Checked = False
    End Sub

    Public Sub SetToComputerTime()
        Dim ComputerTime As DateTime = DateTime.Now
        Dim Hours12 As Integer

        If ComputerTime.Hour = 0 Then
            Hours12 = 12
        ElseIf ComputerTime.Hour > 12 Then
            Hours12 = ComputerTime.Hour - 12
        Else
            Hours12 = ComputerTime.Hour
        End If
        Digitled1.MaxDigit = 1
        Digitled2.MaxDigit = 9
        Digitled3.MaxDigit = 5
        Digitled4.MaxDigit = 9
        Digitled1.Digit = (Hours12 \ 10)
        Digitled2.Digit = (Hours12 Mod 10)
        Digitled3.Digit = (DateTime.Now.Minute \ 10)
        Digitled4.Digit = (DateTime.Now.Minute Mod 10)
        AMorPM()
    End Sub

    Public Sub AMorPM()
        Dim Hour As Integer = DateTime.Now.Hour
        If Hour < 12 Then
            AMbutton.Checked = True
            PMbutton.Checked = False
        Else
            AMbutton.Checked = False
            PMbutton.Checked = True
        End If
    End Sub

    Private Sub UpdateTime()
        Dim ComputerTime As DateTime = DateTime.Now

        If ComputerTime.Second <> 0 Then Exit Sub

        Dim Hours12 As Integer

        If ComputerTime.Hour = 0 Then
            Hours12 = 12
        ElseIf ComputerTime.Hour > 12 Then
            Hours12 = ComputerTime.Hour Mod 12
        Else
            Hours12 = ComputerTime.Hour
        End If

        Digitled1.Digit = (Hours12 \ 10)
        Digitled2.Digit = (Hours12 Mod 10)
        Digitled3.Digit = (ComputerTime.Minute \ 10)
        Digitled4.Digit = (ComputerTime.Minute Mod 10)

        AMorPM()

        Dim mainForm As Form1 = TryCast(Me.FindForm(), Form1)
        If mainForm Is Nothing Then Exit Sub
        If Not Me Is mainForm.TimePanel1 Then Exit Sub

        Dim nowTime As DateTime = DateTime.Now

        If mainForm.AlarmPanel1.AlarmEnabled Then
            If nowTime.Hour = GetHour(mainForm.AlarmPanel1.TimePanel1) AndAlso
           nowTime.Minute = GetMinute(mainForm.AlarmPanel1.TimePanel1) Then
                mainForm.TabControl.SelectedTab = mainForm.Alarm1
                mainForm.AlarmPanel1.PlayGif()
            End If
        End If

        If mainForm.AlarmPanel2.AlarmEnabled Then
            If nowTime.Hour = GetHour(mainForm.AlarmPanel2.TimePanel1) AndAlso
           nowTime.Minute = GetMinute(mainForm.AlarmPanel2.TimePanel1) Then
                mainForm.TabControl.SelectedTab = mainForm.Alarm1
                mainForm.AlarmPanel1.PlayGif()
            End If
        End If

        If mainForm.AlarmPanel3.AlarmEnabled Then
            If nowTime.Hour = GetHour(mainForm.AlarmPanel3.TimePanel1) AndAlso
           nowTime.Minute = GetMinute(mainForm.AlarmPanel3.TimePanel1) Then
                mainForm.TabControl.SelectedTab = mainForm.Alarm1
                mainForm.AlarmPanel1.PlayGif()
            End If
        End If
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        RaiseEvent Reset(True)
    End Sub

    Private Sub SetButton_Click(sender As Object, e As EventArgs) Handles SetButton.Click
        SetToZero()
        Dim MainForm As Form1 = CType(Me.FindForm(), Form1)
        MainForm.KeypadVisibility = True
        MainForm.Height = MainForm.FullHeight
        MainForm.HideKeys()
    End Sub

    Public Property Dig1 As Integer
        Get
            Return Digitled1.Digit
        End Get
        Set(value As Integer)
            If value <= Digitled1.MaxDigit Then
                Digitled1.Digit = value
            End If
        End Set
    End Property

    Public Property Dig2 As Integer
        Get
            Return Digitled2.Digit
        End Get
        Set(value As Integer)
            If value <= Digitled2.MaxDigit Then
                Digitled2.Digit = value
            End If
        End Set
    End Property

    Public Property Dig3 As Integer
        Get
            Return Digitled3.Digit
        End Get
        Set(value As Integer)
            If value <= Digitled3.MaxDigit Then
                Digitled3.Digit = value
            End If
        End Set
    End Property

    Public Property Dig4 As Integer
        Get
            Return Digitled4.Digit
        End Get
        Set(value As Integer)
            If value <= Digitled4.MaxDigit Then
                Digitled4.Digit = value
            End If
        End Set
    End Property

    Private Function GetHour(tp As TimePanel) As Integer
        Dim hour As Integer = tp.Digitled1.Digit * 10 + tp.Digitled2.Digit

        If tp.PMbutton.Checked AndAlso hour <> 12 Then
            hour += 12
        End If

        If tp.AMbutton.Checked AndAlso hour = 12 Then
            hour = 0
        End If

        Return hour
    End Function

    Private Function GetMinute(tp As TimePanel) As Integer
        Return tp.Digitled3.Digit * 10 + tp.Digitled4.Digit
    End Function
End Class
