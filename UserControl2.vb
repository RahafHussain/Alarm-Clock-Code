Public Class AlarmPanel

    Public Event AlarmToggled(ByVal enabled As Boolean)

    Private normalImage As Image
    Private alarmImage As Image
    Private alarmTimer As Timer

    Public Sub New()
        InitializeComponent()

        TimePanel1.SetToZero()
        TimePanel1.AMbutton.Checked = True
        TimePanel1.PMbutton.Checked = False
        alarmTimer = New Timer()
        alarmTimer.Interval = 5000
        AddHandler alarmTimer.Tick, Sub()
                                        PictureButton.Image = normalImage
                                        alarmTimer.Stop()
                                    End Sub
    End Sub

    Public Sub SetToZero()
        TimePanel1.Digitled1.Digit = 0
        TimePanel1.Digitled2.Digit = 0
        TimePanel1.Digitled3.Digit = 0
        TimePanel1.Digitled4.Digit = 0
    End Sub

    Public Property AlarmEnabled As Boolean
        Get
            Return CheckBoxEnable.Checked
        End Get
        Set(value As Boolean)
            CheckBoxEnable.Checked = value
        End Set
    End Property

    Private Sub CheckBoxEnable_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxEnable.CheckedChanged
        RaiseEvent AlarmToggled(CheckBoxEnable.Checked)
    End Sub

    Public Sub PlayGif()
        PictureButton.Image = PictureButton.BackgroundImage
        PictureButton.SizeMode = PictureBoxSizeMode.StretchImage

        Dim timer As New Timer()
        timer.Interval = 5000
        AddHandler timer.Tick, Sub(s, args)
                                   PictureButton.Image = Nothing
                                   timer.Stop()
                                   timer.Dispose()
                               End Sub
        timer.Start()
    End Sub
End Class