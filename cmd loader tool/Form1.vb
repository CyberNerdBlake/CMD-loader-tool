Public Class Form1
    Private r As Integer = 255
    Private g As Integer
    Private b As Integer
    Private mouseDown As Boolean
    Private lastLocation As Point
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("C:\Windows\System32\cmd.exe")

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MsgBox("Thx for using this program!")
    End Sub

    Private Sub RainbowCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles RainbowCheckBox.CheckedChanged
        If Me.RainbowCheckBox.Checked Then
            Me.RainbowTimer.Enabled = True
            Return
        End If
        Me.RainbowTimer.Enabled = False
    End Sub

    Private Sub RainbowTimer_Tick(sender As Object, e As EventArgs) Handles RainbowTimer.Tick
        If Me.r > 0 AndAlso Me.b = 0 Then
            Me.r -= 1
            Me.g += 1
        End If
        If Me.g > 0 AndAlso Me.r = 0 Then
            Me.g -= 1
            Me.b += 1
        End If
        If Me.b > 0 AndAlso Me.g = 0 Then
            Me.b -= 1
            Me.r += 1
        End If
        Dim color As Color = Color.FromArgb(Me.r, Me.g, Me.b)
        Label3.ForeColor = color
        Label1.ForeColor = color
        Label2.ForeColor = color
        RainbowCheckBox.ForeColor = color
        Button1.ForeColor = color

    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        mouseDown = True
        lastLocation = e.Location
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If mouseDown Then
            Location = New Point(Location.X - lastLocation.X + e.X, Location.Y - lastLocation.Y + e.Y)
            Update()
        End If
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        mouseDown = False
    End Sub
End Class
