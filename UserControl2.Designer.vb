<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlarmPanel
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        SoundList = New ListBox()
        CheckBoxEnable = New CheckBox()
        PictureButton = New PictureBox()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        TimePanel1 = New TimePanel()
        CType(PictureButton, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SoundList
        ' 
        SoundList.FormattingEnabled = True
        SoundList.ItemHeight = 25
        SoundList.Location = New Point(348, 262)
        SoundList.Margin = New Padding(4, 4, 4, 4)
        SoundList.Name = "SoundList"
        SoundList.Size = New Size(186, 154)
        SoundList.TabIndex = 2
        ' 
        ' CheckBoxEnable
        ' 
        CheckBoxEnable.AutoSize = True
        CheckBoxEnable.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBoxEnable.Location = New Point(348, 432)
        CheckBoxEnable.Margin = New Padding(4, 4, 4, 4)
        CheckBoxEnable.Name = "CheckBoxEnable"
        CheckBoxEnable.Size = New Size(135, 34)
        CheckBoxEnable.TabIndex = 3
        CheckBoxEnable.Text = "Alarm ON"
        CheckBoxEnable.UseVisualStyleBackColor = True
        ' 
        ' PictureButton
        ' 
        PictureButton.BackgroundImageLayout = ImageLayout.Stretch
        PictureButton.Location = New Point(65, 262)
        PictureButton.Margin = New Padding(4, 4, 4, 4)
        PictureButton.Name = "PictureButton"
        PictureButton.Size = New Size(181, 181)
        PictureButton.TabIndex = 5
        PictureButton.TabStop = False
        ' 
        ' TimePanel1
        ' 
        TimePanel1.Dig1 = 0
        TimePanel1.Dig2 = 2
        TimePanel1.Dig3 = 0
        TimePanel1.Dig4 = 0
        TimePanel1.Location = New Point(0, 0)
        TimePanel1.Margin = New Padding(5, 5, 5, 5)
        TimePanel1.Name = "TimePanel1"
        TimePanel1.Size = New Size(598, 491)
        TimePanel1.TabIndex = 6
        ' 
        ' AlarmPanel
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(CheckBoxEnable)
        Controls.Add(SoundList)
        Controls.Add(PictureButton)
        Controls.Add(TimePanel1)
        Margin = New Padding(4, 4, 4, 4)
        Name = "AlarmPanel"
        Size = New Size(598, 491)
        CType(PictureButton, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents SoundList As ListBox
    Friend WithEvents CheckBoxEnable As CheckBox
    Friend WithEvents TimePanel1 As TimePanel
    Friend WithEvents PictureButton As PictureBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker

End Class
