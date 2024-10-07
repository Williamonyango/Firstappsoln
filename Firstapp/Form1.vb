Public Class Form1
    Private Sub btnOnclick_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        lblName.Visible = False
        lblProgramming.Visible = False
        txtName.Visible = False
        lblDOB.Visible = False
        DateTimePicker1.Visible = False
        GroupBox1.Visible = False
        units.Visible = False


    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        lblName.Visible = True
        lblProgramming.Visible = True
        txtName.Visible = True
        lblDOB.Visible = True
        DateTimePicker1.Visible = True
        GroupBox1.Visible = True
        units.Visible = True
    End Sub

    Private Sub btnColor_Click(sender As Object, e As EventArgs) Handles btnColor.Click
        lblName.ForeColor = Color.White
        lblProgramming.ForeColor = Color.Wheat
        lblName.BackColor = Color.Red
        lblProgramming.BackColor = Color.Red
    End Sub

    Private Sub btnEraseTxt_Click(sender As Object, e As EventArgs) Handles btnEraseTxt.Click
        txtName.Clear()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSize_Click(sender As Object, e As EventArgs) Handles btnSize22.Click
        lblName.Font = New Font(Font.Size, 22)
        lblProgramming.Font = New Font(Font.Size, 22)
        txtName.Font = New Font(Font.Size, 22)
    End Sub

    Private Sub btnSize30_Click(sender As Object, e As EventArgs) Handles btnSize30.Click
        lblName.Font = New Font(Font.Size, 30)
        lblProgramming.Font = New Font(Font.Size, 30)
        txtName.Font = New Font(Font.Size, 30)
    End Sub

    Private Sub btnSize40_Click(sender As Object, e As EventArgs) Handles btnSize40.Click
        lblName.Font = New Font(Font.Size, 40)
        lblProgramming.Font = New Font(Font.Size, 40)
        txtName.Font = New Font(Font.Size, 40)
    End Sub

    Private Sub btnUnderline_Click(sender As Object, e As EventArgs) Handles btnUnderline.Click
        lblName.Font = New Font(lblName.Font.FontFamily, 16, FontStyle.Underline)
        lblProgramming.Font = New Font(lblProgramming.Font.FontFamily, 16, FontStyle.Underline)
    End Sub

    Private Sub btnItalic_Click(sender As Object, e As EventArgs) Handles btnItalic.Click
        lblName.Font = New Font(lblName.Font.FontFamily, 16, FontStyle.Italic)
        lblProgramming.Font = New Font(lblProgramming.Font.FontFamily, 16, FontStyle.Italic)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Hobbies.Items.Add(txtHobies.Text)
        txtHobies.Clear()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Get all hobbies from ListBox (Hobbies)
        Dim allHobbies As String = ""
        For Each hobby As String In Hobbies.Items
            allHobbies &= hobby & ", "
        Next
        ' Remove the trailing comma and space
        If allHobbies.Length > 0 Then
            allHobbies = allHobbies.Substring(0, allHobbies.Length - 2)
        End If

        ' Get selected units from CheckBoxes
        Dim selectedUnits As String = ""
        If CheckBox1.Checked Then
            selectedUnits &= CheckBox1.Text & ", "
        End If
        If CheckBox2.Checked Then
            selectedUnits &= CheckBox2.Text & ", "
        End If
        If CheckBox3.Checked Then
            selectedUnits &= CheckBox3.Text & ", "
        End If
        If CheckBox4.Checked Then
            selectedUnits &= CheckBox4.Text & ", "
        End If
        ' Remove the trailing comma and space
        If selectedUnits.Length > 0 Then
            selectedUnits = selectedUnits.Substring(0, selectedUnits.Length - 2)
        End If

        ' Display the message
        MessageBox.Show("Welcome " & txtName.Text & ", you were born in " & DateTimePicker1.Value.Year.ToString() & ". " &
                        "You are registered to do the following units: " & selectedUnits & " and your hobbies are: " & allHobbies)
    End Sub


End Class
