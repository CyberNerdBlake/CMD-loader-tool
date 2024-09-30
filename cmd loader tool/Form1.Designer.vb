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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        RainbowCheckBox = New CheckBox()
        RainbowTimer = New Timer(components)
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Control
        Button1.Cursor = Cursors.Hand
        Button1.Font = New Font("MS Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Red
        Button1.Location = New Point(-3, 612)
        Button1.Name = "Button1"
        Button1.Size = New Size(97, 51)
        Button1.TabIndex = 0
        Button1.Text = "Press To Load CMD"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Cursor = Cursors.Hand
        Label1.Font = New Font("MS Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(856, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(21, 22)
        Label1.TabIndex = 1
        Label1.Text = "X"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Cursor = Cursors.Hand
        Label2.Font = New Font("MS Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Red
        Label2.Location = New Point(834, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(21, 22)
        Label2.TabIndex = 2
        Label2.Text = "-"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Cursor = Cursors.No
        Label3.ForeColor = Color.Red
        Label3.Location = New Point(-3, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(144, 25)
        Label3.TabIndex = 3
        Label3.Text = "CMD loader tool"
        ' 
        ' RainbowCheckBox
        ' 
        RainbowCheckBox.AutoSize = True
        RainbowCheckBox.Cursor = Cursors.Hand
        RainbowCheckBox.Font = New Font("MS Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RainbowCheckBox.ForeColor = Color.Red
        RainbowCheckBox.Location = New Point(-3, 669)
        RainbowCheckBox.Name = "RainbowCheckBox"
        RainbowCheckBox.Size = New Size(97, 22)
        RainbowCheckBox.TabIndex = 4
        RainbowCheckBox.Text = "Rainbow"
        RainbowCheckBox.UseVisualStyleBackColor = True
        ' 
        ' RainbowTimer
        ' 
        RainbowTimer.Interval = 10
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(876, 695)
        Controls.Add(RainbowCheckBox)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RainbowCheckBox As CheckBox
    Friend WithEvents RainbowTimer As Timer

End Class
