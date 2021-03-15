Public Class Form1
    Private Sub ОПрограммеToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОПрограммеToolStripMenuItem.Click
        MessageBox.Show("Автор программы Заказ авиабилетов: Сергей Галкин. Дата релиза: 15.03.2021 г.", "Внимание!!")
    End Sub

    Private Sub ВыходToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ВыходToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'MsgBox(TextBox1.Text)
        Dim msg As String
        msg = "Направление:    " + TextBox1.Text + vbCrLf + "Класс:   "
        If RadioButton1.Checked Then
            msg += "красный"
        End If
        If RadioButton2.Checked Then
            msg += "жёлтый"
        End If
        If RadioButton3.Checked Then
            msg += "фиолетовый"
        End If
        If CheckBox1.Checked And ComboBox1.SelectedIndex <> -1 Then
            msg = msg + vbCrLf + "Цена билета:   " + ComboBox1.SelectedItem
            TextBox2.Size = New Size(250, 90)
        Else
            TextBox2.Size = New Size(250, 79)
        End If
        TextBox2.Text = msg
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        Me.BackColor = Color.Bisque
        CheckBox1.Checked = True
        ComboBox1.SelectedIndex = -1
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Me.BackColor = Color.Red
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Me.BackColor = Color.Yellow
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Me.BackColor = Color.Violet
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Label3.Visible = CheckBox1.Checked
        ComboBox1.Visible = CheckBox1.Checked
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'MsgBox(ComboBox1.SelectedItem)
    End Sub
End Class
