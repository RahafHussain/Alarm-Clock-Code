<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        TabControl = New TabControl()
        Clock = New TabPage()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        PictureButton = New PictureBox()
        TimePanel1 = New TimePanel()
        Alarm1 = New TabPage()
        AlarmPanel1 = New AlarmPanel()
        Alarm2 = New TabPage()
        AlarmPanel2 = New AlarmPanel()
        Alarm3 = New TabPage()
        AlarmPanel3 = New AlarmPanel()
        Button9 = New Button()
        Button8 = New Button()
        Keypad = New Panel()
        Button6 = New Button()
        Button5 = New Button()
        OKButton = New Button()
        Button0 = New Button()
        CancelButton = New Button()
        Button7 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        TabControl.SuspendLayout()
        Clock.SuspendLayout()
        CType(PictureButton, ComponentModel.ISupportInitialize).BeginInit()
        Alarm1.SuspendLayout()
        Alarm2.SuspendLayout()
        Alarm3.SuspendLayout()
        Keypad.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl
        ' 
        TabControl.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TabControl.Controls.Add(Clock)
        TabControl.Controls.Add(Alarm1)
        TabControl.Controls.Add(Alarm2)
        TabControl.Controls.Add(Alarm3)
        TabControl.ItemSize = New Size(120, 25)
        TabControl.Location = New Point(15, 15)
        TabControl.Margin = New Padding(4)
        TabControl.Multiline = True
        TabControl.Name = "TabControl"
        TabControl.SelectedIndex = 0
        TabControl.Size = New Size(608, 1071)
        TabControl.SizeMode = TabSizeMode.Fixed
        TabControl.TabIndex = 0
        ' 
        ' Clock
        ' 
        Clock.BackColor = Color.Transparent
        Clock.Controls.Add(CheckBox3)
        Clock.Controls.Add(CheckBox2)
        Clock.Controls.Add(CheckBox1)
        Clock.Controls.Add(PictureButton)
        Clock.Controls.Add(TimePanel1)
        Clock.Location = New Point(4, 29)
        Clock.Margin = New Padding(4)
        Clock.Name = "Clock"
        Clock.Padding = New Padding(4)
        Clock.Size = New Size(600, 1038)
        Clock.TabIndex = 0
        Clock.Text = "Clock"
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox3.Location = New Point(359, 414)
        CheckBox3.Margin = New Padding(4)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(153, 34)
        CheckBox3.TabIndex = 7
        CheckBox3.Text = "Alarm 3 ON"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox2.Location = New Point(359, 349)
        CheckBox2.Margin = New Padding(4)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(153, 34)
        CheckBox2.TabIndex = 6
        CheckBox2.Text = "Alarm 2 ON"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox1.Location = New Point(359, 284)
        CheckBox1.Margin = New Padding(4)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(153, 34)
        CheckBox1.TabIndex = 5
        CheckBox1.Text = "Alarm 1 ON"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' PictureButton
        ' 
        PictureButton.BackgroundImage = CType(resources.GetObject("PictureButton.BackgroundImage"), Image)
        PictureButton.BackgroundImageLayout = ImageLayout.Stretch
        PictureButton.Location = New Point(61, 279)
        PictureButton.Margin = New Padding(4)
        PictureButton.Name = "PictureButton"
        PictureButton.Size = New Size(181, 181)
        PictureButton.TabIndex = 9
        PictureButton.TabStop = False
        ' 
        ' TimePanel1
        ' 
        TimePanel1.Dig1 = 1
        TimePanel1.Dig2 = 0
        TimePanel1.Dig3 = 0
        TimePanel1.Dig4 = 3
        TimePanel1.Location = New Point(0, 0)
        TimePanel1.Margin = New Padding(5)
        TimePanel1.Name = "TimePanel1"
        TimePanel1.Size = New Size(602, 491)
        TimePanel1.TabIndex = 4
        ' 
        ' Alarm1
        ' 
        Alarm1.Controls.Add(AlarmPanel1)
        Alarm1.Location = New Point(4, 29)
        Alarm1.Margin = New Padding(4)
        Alarm1.Name = "Alarm1"
        Alarm1.Padding = New Padding(4)
        Alarm1.RightToLeft = RightToLeft.No
        Alarm1.Size = New Size(600, 1038)
        Alarm1.TabIndex = 1
        Alarm1.Text = "Alarm 1"
        Alarm1.UseVisualStyleBackColor = True
        ' 
        ' AlarmPanel1
        ' 
        AlarmPanel1.AlarmEnabled = False
        AlarmPanel1.BackColor = Color.OldLace
        AlarmPanel1.Location = New Point(0, 0)
        AlarmPanel1.Margin = New Padding(5)
        AlarmPanel1.Name = "AlarmPanel1"
        AlarmPanel1.Size = New Size(598, 491)
        AlarmPanel1.TabIndex = 0
        ' 
        ' Alarm2
        ' 
        Alarm2.Controls.Add(AlarmPanel2)
        Alarm2.Location = New Point(4, 29)
        Alarm2.Margin = New Padding(4)
        Alarm2.Name = "Alarm2"
        Alarm2.Size = New Size(600, 1038)
        Alarm2.TabIndex = 2
        Alarm2.Text = "Alarm 2"
        Alarm2.UseVisualStyleBackColor = True
        ' 
        ' AlarmPanel2
        ' 
        AlarmPanel2.AlarmEnabled = False
        AlarmPanel2.BackColor = Color.MistyRose
        AlarmPanel2.Location = New Point(0, 0)
        AlarmPanel2.Margin = New Padding(5)
        AlarmPanel2.Name = "AlarmPanel2"
        AlarmPanel2.Size = New Size(598, 491)
        AlarmPanel2.TabIndex = 0
        ' 
        ' Alarm3
        ' 
        Alarm3.Controls.Add(AlarmPanel3)
        Alarm3.Location = New Point(4, 29)
        Alarm3.Margin = New Padding(4)
        Alarm3.Name = "Alarm3"
        Alarm3.Size = New Size(600, 1038)
        Alarm3.TabIndex = 3
        Alarm3.Text = "Alarm 3"
        Alarm3.UseVisualStyleBackColor = True
        ' 
        ' AlarmPanel3
        ' 
        AlarmPanel3.AlarmEnabled = False
        AlarmPanel3.BackColor = Color.Honeydew
        AlarmPanel3.Location = New Point(0, 0)
        AlarmPanel3.Margin = New Padding(5)
        AlarmPanel3.Name = "AlarmPanel3"
        AlarmPanel3.Size = New Size(598, 491)
        AlarmPanel3.TabIndex = 1
        ' 
        ' Button9
        ' 
        Button9.Font = New Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Button9.Location = New Point(419, 290)
        Button9.Margin = New Padding(4)
        Button9.Name = "Button9"
        Button9.Size = New Size(146, 90)
        Button9.TabIndex = 8
        Button9.Text = "9"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Font = New Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Button8.Location = New Point(229, 290)
        Button8.Margin = New Padding(4)
        Button8.Name = "Button8"
        Button8.Size = New Size(146, 90)
        Button8.TabIndex = 7
        Button8.Text = "8"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Keypad
        ' 
        Keypad.Controls.Add(Button6)
        Keypad.Controls.Add(Button5)
        Keypad.Controls.Add(Button9)
        Keypad.Controls.Add(OKButton)
        Keypad.Controls.Add(Button8)
        Keypad.Controls.Add(Button0)
        Keypad.Controls.Add(CancelButton)
        Keypad.Controls.Add(Button7)
        Keypad.Controls.Add(Button4)
        Keypad.Controls.Add(Button3)
        Keypad.Controls.Add(Button2)
        Keypad.Controls.Add(Button1)
        Keypad.Location = New Point(15, 550)
        Keypad.Margin = New Padding(4)
        Keypad.Name = "Keypad"
        Keypad.Size = New Size(602, 538)
        Keypad.TabIndex = 1
        Keypad.Visible = False
        ' 
        ' Button6
        ' 
        Button6.Font = New Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Button6.Location = New Point(419, 160)
        Button6.Margin = New Padding(4)
        Button6.Name = "Button6"
        Button6.Size = New Size(146, 90)
        Button6.TabIndex = 5
        Button6.Text = "6"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Button5.Location = New Point(229, 160)
        Button5.Margin = New Padding(4)
        Button5.Name = "Button5"
        Button5.Size = New Size(146, 90)
        Button5.TabIndex = 4
        Button5.Text = "5"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' OKButton
        ' 
        OKButton.Font = New Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point)
        OKButton.Location = New Point(419, 420)
        OKButton.Margin = New Padding(4)
        OKButton.Name = "OKButton"
        OKButton.Size = New Size(146, 90)
        OKButton.TabIndex = 11
        OKButton.Text = "OK"
        OKButton.UseVisualStyleBackColor = True
        ' 
        ' Button0
        ' 
        Button0.Font = New Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Button0.Location = New Point(229, 420)
        Button0.Margin = New Padding(4)
        Button0.Name = "Button0"
        Button0.Size = New Size(146, 90)
        Button0.TabIndex = 10
        Button0.Text = "0"
        Button0.UseVisualStyleBackColor = True
        ' 
        ' CancelButton
        ' 
        CancelButton.Font = New Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point)
        CancelButton.Location = New Point(39, 420)
        CancelButton.Margin = New Padding(4)
        CancelButton.Name = "CancelButton"
        CancelButton.Size = New Size(146, 90)
        CancelButton.TabIndex = 9
        CancelButton.Text = "Cancel"
        CancelButton.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Font = New Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Button7.Location = New Point(39, 290)
        Button7.Margin = New Padding(4)
        Button7.Name = "Button7"
        Button7.Size = New Size(146, 90)
        Button7.TabIndex = 6
        Button7.Text = "7"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.Location = New Point(39, 160)
        Button4.Margin = New Padding(4)
        Button4.Name = "Button4"
        Button4.Size = New Size(146, 90)
        Button4.TabIndex = 3
        Button4.Text = "4"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(419, 30)
        Button3.Margin = New Padding(4)
        Button3.Name = "Button3"
        Button3.Size = New Size(146, 90)
        Button3.TabIndex = 2
        Button3.Text = "3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(229, 30)
        Button2.Margin = New Padding(4)
        Button2.Name = "Button2"
        Button2.Size = New Size(146, 90)
        Button2.TabIndex = 1
        Button2.Text = "2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(39, 30)
        Button1.Margin = New Padding(4)
        Button1.Name = "Button1"
        Button1.Size = New Size(146, 90)
        Button1.TabIndex = 0
        Button1.Text = "1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        ClientSize = New Size(638, 1101)
        Controls.Add(Keypad)
        Controls.Add(TabControl)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4)
        Name = "Form1"
        Text = "Rahaf's Alarm Clock"
        TabControl.ResumeLayout(False)
        Clock.ResumeLayout(False)
        Clock.PerformLayout()
        CType(PictureButton, ComponentModel.ISupportInitialize).EndInit()
        Alarm1.ResumeLayout(False)
        Alarm2.ResumeLayout(False)
        Alarm3.ResumeLayout(False)
        Keypad.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl As TabControl
    Friend WithEvents Clock As TabPage
    Friend WithEvents Alarm1 As TabPage
    Friend WithEvents Alarm2 As TabPage
    Friend WithEvents Alarm3 As TabPage
    Friend WithEvents Keypad As Panel
    Friend WithEvents TimePanel1 As TimePanel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents OKButton As Button
    Friend WithEvents Button0 As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents PictureButton As PictureBox
    Friend WithEvents AlarmPanel1 As AlarmPanel
    Friend WithEvents AlarmPanel2 As AlarmPanel
    Friend WithEvents AlarmPanel3 As AlarmPanel

End Class
