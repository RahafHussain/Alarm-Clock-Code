<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimePanel
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        components = New ComponentModel.Container()
        Digitled1 = New DigitLED()
        Digitled2 = New DigitLED()
        Digitled3 = New DigitLED()
        Digitled4 = New DigitLED()
        Label1 = New Label()
        AMbutton = New RadioButton()
        PMbutton = New RadioButton()
        SetButton = New Button()
        ResetButton = New Button()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' Digitled1
        ' 
        Digitled1.AutoSize = True
        Digitled1.BackColor = Color.Transparent
        Digitled1.Digit = 0
        Digitled1.Font = New Font("Segoe UI", 60F, FontStyle.Regular, GraphicsUnit.Point)
        Digitled1.Location = New Point(0, 0)
        Digitled1.Margin = New Padding(4, 0, 4, 0)
        Digitled1.MaxDigit = 0
        Digitled1.Name = "Digitled1"
        Digitled1.Size = New Size(132, 159)
        Digitled1.TabIndex = 0
        Digitled1.Text = "0"
        Digitled1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Digitled2
        ' 
        Digitled2.AutoSize = True
        Digitled2.BackColor = Color.Transparent
        Digitled2.Digit = 0
        Digitled2.Font = New Font("Segoe UI", 60F, FontStyle.Regular, GraphicsUnit.Point)
        Digitled2.Location = New Point(96, 0)
        Digitled2.Margin = New Padding(4, 0, 4, 0)
        Digitled2.MaxDigit = 0
        Digitled2.Name = "Digitled2"
        Digitled2.Size = New Size(132, 159)
        Digitled2.TabIndex = 1
        Digitled2.Text = "0"
        Digitled2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Digitled3
        ' 
        Digitled3.AutoSize = True
        Digitled3.BackColor = Color.Transparent
        Digitled3.Digit = 0
        Digitled3.Font = New Font("Segoe UI", 60F, FontStyle.Regular, GraphicsUnit.Point)
        Digitled3.Location = New Point(242, 0)
        Digitled3.Margin = New Padding(4, 0, 4, 0)
        Digitled3.MaxDigit = 0
        Digitled3.Name = "Digitled3"
        Digitled3.Size = New Size(132, 159)
        Digitled3.TabIndex = 2
        Digitled3.Text = "0"
        Digitled3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Digitled4
        ' 
        Digitled4.AutoSize = True
        Digitled4.BackColor = Color.Transparent
        Digitled4.Digit = 0
        Digitled4.Font = New Font("Segoe UI", 60F, FontStyle.Regular, GraphicsUnit.Point)
        Digitled4.Location = New Point(335, 0)
        Digitled4.Margin = New Padding(4, 0, 4, 0)
        Digitled4.MaxDigit = 0
        Digitled4.Name = "Digitled4"
        Digitled4.Size = New Size(132, 159)
        Digitled4.TabIndex = 3
        Digitled4.Text = "0"
        Digitled4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 55F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(194, 0)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 146)
        Label1.TabIndex = 4
        Label1.Text = ":"
        ' 
        ' AMbutton
        ' 
        AMbutton.AutoSize = True
        AMbutton.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        AMbutton.Location = New Point(481, 51)
        AMbutton.Margin = New Padding(4)
        AMbutton.Name = "AMbutton"
        AMbutton.Size = New Size(76, 36)
        AMbutton.TabIndex = 5
        AMbutton.TabStop = True
        AMbutton.Text = "AM"
        AMbutton.UseVisualStyleBackColor = True
        ' 
        ' PMbutton
        ' 
        PMbutton.AutoSize = True
        PMbutton.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        PMbutton.Location = New Point(481, 99)
        PMbutton.Margin = New Padding(4)
        PMbutton.Name = "PMbutton"
        PMbutton.Size = New Size(74, 36)
        PMbutton.TabIndex = 6
        PMbutton.TabStop = True
        PMbutton.Text = "PM"
        PMbutton.UseVisualStyleBackColor = True
        ' 
        ' SetButton
        ' 
        SetButton.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point)
        SetButton.Location = New Point(32, 182)
        SetButton.Margin = New Padding(4)
        SetButton.Name = "SetButton"
        SetButton.Size = New Size(240, 49)
        SetButton.TabIndex = 7
        SetButton.Text = "Set"
        SetButton.UseVisualStyleBackColor = True
        ' 
        ' ResetButton
        ' 
        ResetButton.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point)
        ResetButton.Location = New Point(319, 182)
        ResetButton.Margin = New Padding(4)
        ResetButton.Name = "ResetButton"
        ResetButton.Size = New Size(242, 49)
        ResetButton.TabIndex = 8
        ResetButton.Text = "Reset"
        ResetButton.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        ' 
        ' TimePanel
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Digitled4)
        Controls.Add(ResetButton)
        Controls.Add(SetButton)
        Controls.Add(PMbutton)
        Controls.Add(AMbutton)
        Controls.Add(Digitled3)
        Controls.Add(Label1)
        Controls.Add(Digitled2)
        Controls.Add(Digitled1)
        Margin = New Padding(4)
        Name = "TimePanel"
        Size = New Size(602, 491)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Digitled1 As DigitLED
    Friend WithEvents Digitled2 As DigitLED
    Friend WithEvents Digitled3 As DigitLED
    Friend WithEvents Digitled4 As DigitLED
    Friend WithEvents Label1 As Label
    Friend WithEvents AMbutton As RadioButton
    Friend WithEvents PMbutton As RadioButton
    Friend WithEvents SetButton As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents Timer1 As Timer

End Class
