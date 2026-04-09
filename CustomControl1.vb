Public Class DigitLED
    Inherits Label

    Private _MaxDigit As Integer
    Private _Digit As Integer

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)

        'Add your custom paint code here
    End Sub

    Public Sub New()
        MyBase.New()
        Me.BackColor = Color.Transparent
        Me.Font = New Font("Segoe UI", 60)
        Me.TextAlign = ContentAlignment.MiddleCenter
    End Sub

    Public Property MaxDigit As Integer
        Get
            Return _MaxDigit
        End Get

        Set(value As Integer)
            If value >= 0 And value <= 9 Then
                _MaxDigit = value
            End If
        End Set
    End Property

    Public Property Digit As Integer
        Get
            Return _Digit
        End Get
        Set(value As Integer)
            If value >= 0 And value <= MaxDigit Then
                _Digit = value
                Me.Text = value.ToString()
            End If
        End Set
    End Property
End Class
