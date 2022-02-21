Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "Lanstar" Then
            Shell("taskkill /f /t /im LanClt.exe")
        End If
        If ComboBox1.Text = "极域电子教室" Then
            Shell("taskkill /f /t /im StudentMain.exe")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Shell(TextBox1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If CheckBox2.Checked = True Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If
        If CheckBox1.Checked = False Then
            Me.ShowInTaskbar = True
        Else
            Me.ShowInTaskbar = False
        End If
        Me.Opacity = NumericUpDown1.Value
    End Sub
End Class
