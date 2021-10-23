

Imports System.Drawing.Bitmap

Public Class Form1


    Public bmp1 As Bitmap
    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

       


            bmp1 = New Bitmap(PictureBox1.Width, PictureBox1.Height)
            If RadioButton3.Checked = True Then
            If x1_textbox.Text = "" Or x2_textbox.Text = "" Or y1_textbox.Text = "" Or y2_textbox.Text = "" Then
                MsgBox("Koordinatlar boş bırakılmaz")
            Else
                PictureBox1.Refresh()
                Dim x1 As Double, x2 As Double
                Dim y1 As Double, y2 As Double, x As Double, y As Double, ymax As Double, ymin As Double
                Dim xmax As Double, xmin As Double
                Dim egim As Double





                x1 = CDbl(x1_textbox.Text)
                x2 = CDbl(x2_textbox.Text)
                y1 = CDbl(y1_textbox.Text)
                y2 = CDbl(y2_textbox.Text)



                If x1 > x2 Then
                    xmax = x1
                    xmin = x2
                Else
                    xmax = x2
                    xmin = x1
                End If
                If y1 > y2 Then
                    ymax = y1
                    ymin = y2
                Else
                    ymax = y2
                    ymin = y1
                End If

                egim = (y2 - y1) / (x2 - x1)

                If ((x1 < 0 Or x1 > PictureBox1.Width) Or (x2 < 0 Or x2 > PictureBox1.Width)) Or ((y1 < 0 Or y1 > PictureBox1.Height) Or (y2 < 0 Or y2 > PictureBox1.Height)) Then
                    MsgBox("Çizmek istediğiniz şekil; sınırları aşıyor .Lütfen değerleri tekrar giriniz")
                Else
                    If xmax <> xmin Then
                        If NumericUpDown1.Value = 1 Then
                            If egim < 1 And egim > -1 Then
                                For i = xmin To xmax
                                    y = egim * (i - x1) + y1
                                    bmp1.SetPixel(i, y, Color.MediumBlue)
                                    PictureBox1.Image = bmp1
                                Next
                            Else
                                For i = ymin To ymax
                                    x = (i - y1) / egim + x1
                                    bmp1.SetPixel(x, i, Color.MediumBlue)
                                    PictureBox1.Image = bmp1
                                Next
                            End If
                        ElseIf NumericUpDown1.Value = 2 Then
                            If egim < 1 And egim > -1 Then
                                For i = xmin To xmax
                                    y = egim * (i - x1) + y1
                                    bmp1.SetPixel(i, y, Color.Cyan)
                                    bmp1.SetPixel(i + 1, y + 1, Color.Cyan)
                                    PictureBox1.Image = bmp1
                                Next
                            Else
                                For i = ymin To ymax
                                    x = (i - y1) / egim + x1
                                    bmp1.SetPixel(x, i, Color.Cyan)
                                    bmp1.SetPixel(x + 1, i + 1, Color.Cyan)
                                    PictureBox1.Image = bmp1
                                Next
                            End If
                        ElseIf NumericUpDown1.Value = 3 Then
                            If egim < 1 And egim > -1 Then
                                For i = xmin To xmax
                                    y = egim * (i - x1) + y1
                                    bmp1.SetPixel(i, y, Color.DarkGreen)
                                    bmp1.SetPixel(i + 1, y + 1, Color.DarkGreen)
                                    bmp1.SetPixel(i - 1, y - 1, Color.DarkGreen)
                                    PictureBox1.Image = bmp1
                                Next
                            Else
                                For i = ymin To ymax
                                    x = (i - y1) / egim + x1
                                    bmp1.SetPixel(x, i, Color.DarkGreen)
                                    bmp1.SetPixel(x + 1, i + 1, Color.DarkGreen)
                                    bmp1.SetPixel(x - 1, i - 1, Color.DarkGreen)
                                    PictureBox1.Image = bmp1
                                Next
                            End If
                        Else
                            If egim < 1 And egim > -1 Then
                                For i = xmin To xmax
                                    y = egim * (i - x1) + y1
                                    bmp1.SetPixel(i, y, Color.DeepSkyBlue)
                                    bmp1.SetPixel(i + 1, y + 1, Color.DeepSkyBlue)
                                    bmp1.SetPixel(i - 1, y - 1, Color.DeepSkyBlue)
                                    bmp1.SetPixel(i + 2, y + 2, Color.DeepSkyBlue)
                                    PictureBox1.Image = bmp1
                                Next
                            Else
                                For i = ymin To ymax
                                    x = (i - y1) / egim + x1
                                    bmp1.SetPixel(x, i, Color.DeepSkyBlue)
                                    bmp1.SetPixel(x + 1, i + 1, Color.DeepSkyBlue)
                                    bmp1.SetPixel(x - 1, i - 1, Color.DeepSkyBlue)
                                    bmp1.SetPixel(x - 2, i - 2, Color.DeepSkyBlue)
                                    PictureBox1.Image = bmp1
                                Next
                            End If
                        End If
                    Else
                        If NumericUpDown1.Value = 1 Then
                            For i = ymin To ymax
                                bmp1.SetPixel(xmax, i, Color.DarkViolet)
                                PictureBox1.Image = bmp1
                            Next
                        ElseIf NumericUpDown1.Value = 2 Then
                            For i = ymin To ymax
                                bmp1.SetPixel(xmax, i, Color.DarkTurquoise)
                                bmp1.SetPixel(xmax + 1, i, Color.DarkTurquoise)
                                PictureBox1.Image = bmp1
                            Next
                        ElseIf NumericUpDown1.Value = 3 Then
                            For i = ymin To ymax
                                bmp1.SetPixel(xmax, i, Color.MediumTurquoise)
                                bmp1.SetPixel(xmax + 1, i, Color.MediumTurquoise)
                                bmp1.SetPixel(xmax - 1, i, Color.MediumTurquoise)
                                PictureBox1.Image = bmp1
                            Next
                        Else
                            For i = ymin To ymax
                                bmp1.SetPixel(xmax, i, Color.PaleTurquoise)
                                bmp1.SetPixel(xmax + 1, i, Color.PaleTurquoise)
                                bmp1.SetPixel(xmax - 1, i, Color.PaleTurquoise)
                                bmp1.SetPixel(xmax + 2, i, Color.PaleTurquoise)
                                PictureBox1.Image = bmp1
                            Next


                        End If

                    End If

                End If
            End If

        ElseIf RadioButton2.Checked = True Then
            If Merkez_x_textbox.Text = "" Or Merkez_Y_textbox.Text = "" Or yarıcap_textbox.Text = "" Then
                MsgBox("Merkez koordinatlar ve yarıçap boş bırakılmaz")
            Else
                PictureBox1.Refresh()
                Dim mer_x As Single, mer_y As Single
                Dim x As Integer, y As Integer
                Dim r As Integer
                mer_x = CSng(Merkez_x_textbox.Text)
                mer_y = CSng(Merkez_Y_textbox.Text)
                r = CInt(yarıcap_textbox.Text)
                If Merkez_x_textbox.Text = vbNullString Or Merkez_Y_textbox.Text = vbNullString Or yarıcap_textbox.Text = vbNullString Then
                    MsgBox("Merkez koordinatları ve yarıçap boş bırakılamaz!")
                End If
                If ((mer_x + r > PictureBox1.Height Or mer_x + r > PictureBox1.Width Or mer_y + r > PictureBox1.Height Or mer_y + r > PictureBox1.Width) Or (mer_x - r < 0 Or mer_x - r < 0 Or mer_y - r < 0 Or mer_y - r < 0)) Then
                    MsgBox("Çizmek istediğiniz şekil; sınırları aşıyor .Lütfen değerleri tekrar giriniz")

                Else
                    If NumericUpDown1.Value = 1 Then
                        For i = 0 To 360
                            x = CUInt(mer_x + r * Math.Cos(i * 2 * Math.PI / 180))
                            y = CUInt(mer_y + r * Math.Sin(i * 2 * Math.PI / 180))
                            bmp1.SetPixel(x, y, Color.PaleVioletRed)
                            PictureBox1.Image = bmp1
                        Next
                    ElseIf NumericUpDown1.Value = 2 Then
                        For i = 0 To 360
                            x = CUInt(mer_x + r * Math.Cos(i * 2 * Math.PI / 180))
                            y = CUInt(mer_y + r * Math.Sin(i * 2 * Math.PI / 180))
                            bmp1.SetPixel(x, y, Color.PaleGreen)
                            PictureBox1.Image = bmp1
                            x = CUInt(mer_x + (r + 1) * Math.Cos(i * 2 * Math.PI / 180))
                            y = CUInt(mer_y + (r + 1) * Math.Sin(i * 2 * Math.PI / 180))
                            bmp1.SetPixel(x, y, Color.PaleGreen)
                            PictureBox1.Image = bmp1
                        Next

                    ElseIf NumericUpDown1.Value = 3 Then
                        For i = 0 To 360
                            x = CUInt(mer_x + r * Math.Cos(i * 2 * Math.PI / 180))
                            y = CUInt(mer_y + r * Math.Sin(i * 2 * Math.PI / 180))
                            bmp1.SetPixel(x, y, Color.Olive)
                            PictureBox1.Image = bmp1
                            x = CUInt(mer_x + (r + 1) * Math.Cos(i * 2 * Math.PI / 180))
                            y = CUInt(mer_y + (r + 1) * Math.Sin(i * 2 * Math.PI / 180))
                            bmp1.SetPixel(x, y, Color.Olive)
                            PictureBox1.Image = bmp1
                            x = CUInt(mer_x + (r - 1) * Math.Cos(i * 2 * Math.PI / 180))
                            y = CUInt(mer_y + (r - 1) * Math.Sin(i * 2 * Math.PI / 180))
                            bmp1.SetPixel(x, y, Color.Olive)
                            PictureBox1.Image = bmp1
                        Next
                    Else
                        For i = 0 To 360
                            x = CUInt(mer_x + r * Math.Cos(i * 2 * Math.PI / 180))
                            y = CUInt(mer_y + r * Math.Sin(i * 2 * Math.PI / 180))
                            bmp1.SetPixel(x, y, Color.Purple)
                            PictureBox1.Image = bmp1
                            x = CUInt(mer_x + (r + 1) * Math.Cos(i * 2 * Math.PI / 180))
                            y = CUInt(mer_y + (r + 1) * Math.Sin(i * 2 * Math.PI / 180))
                            bmp1.SetPixel(x, y, Color.Purple)
                            PictureBox1.Image = bmp1
                            x = CUInt(mer_x + (r - 1) * Math.Cos(i * 2 * Math.PI / 180))
                            y = CUInt(mer_y + (r - 1) * Math.Sin(i * 2 * Math.PI / 180))
                            bmp1.SetPixel(x, y, Color.Purple)
                            PictureBox1.Image = bmp1
                            x = CUInt(mer_x + (r + 2) * Math.Cos(i * 2 * Math.PI / 180))
                            y = CUInt(mer_y + (r + 2) * Math.Sin(i * 2 * Math.PI / 180))
                            bmp1.SetPixel(x, y, Color.Purple)
                            PictureBox1.Image = bmp1


                        Next


                    End If
                    If CheckBox1.Checked = True Then
                        For j = 0 To r
                            For i = 0 To 720
                                x = CUInt(mer_x + j * Math.Cos(i * 2 * Math.PI / 180))
                                y = CUInt(mer_y + j * Math.Sin(i * 2 * Math.PI / 180))
                                bmp1.SetPixel(x, y, Color.MidnightBlue)
                                PictureBox1.Image = bmp1
                            Next
                        Next
                    End If
                End If
            End If



        Else
            If x_textbox.Text = "" Or y_textbox.Text = "" Or width_textbox.Text = "" Or Height_textbox.Text = "" Then
                MsgBox("Sol üst köşe koordinatlar , tükseklik ve genişlik boş bırakılamaz")
            Else
                Dim x As Integer, y As Integer
                Dim height As Integer, width As Integer

                x = CStr(x_textbox.Text)
                y = CStr(y_textbox.Text)

                height = CStr(Height_textbox.Text)
                width = CStr(width_textbox.Text)

                If x_textbox.Text = vbNullString Or y_textbox.Text = vbNullString Or Height_textbox.Text = vbNullString Or width_textbox.Text = vbNullString Then
                    MsgBox("Sol üst köşe koordinatları ,yükseklik ve genişlik boş bırakılamaz!")
                End If


                If x + height > PictureBox1.Height Or x + width > PictureBox1.Width Or y + height > PictureBox1.Height Or y + width > PictureBox1.Width Then
                    MsgBox("Çizmek istediğiniz şekil; sınırları aşıyor .Lütfen değerleri tekrar giriniz")
                Else
                    If NumericUpDown1.Value = 1 Then
                        For i = x To x + width
                            bmp1.SetPixel(i, y, Color.OrangeRed)
                            bmp1.SetPixel(i, y + height, Color.OrangeRed)
                            PictureBox1.Image = bmp1
                        Next
                        For i = y To y + height
                            bmp1.SetPixel(x, i, Color.OrangeRed)
                            bmp1.SetPixel(x + width, i, Color.OrangeRed)
                            PictureBox1.Image = bmp1
                        Next
                    ElseIf NumericUpDown1.Value = 2 Then
                        For i = x To x + width
                            bmp1.SetPixel(i, y, Color.Red)
                            bmp1.SetPixel(i, y + height, Color.Red)
                            bmp1.SetPixel(i + 1, y, Color.Red)
                            bmp1.SetPixel(i + 1, y + height, Color.Red)
                            PictureBox1.Image = bmp1
                        Next
                        For i = y To y + height
                            bmp1.SetPixel(x, i, Color.Red)
                            bmp1.SetPixel(x + width, i, Color.Red)
                            bmp1.SetPixel(x, i + 1, Color.Red)
                            bmp1.SetPixel(x + width, i + 1, Color.Red)
                            PictureBox1.Image = bmp1
                        Next
                    ElseIf NumericUpDown1.Value = 3 Then
                        For i = x To x + width
                            bmp1.SetPixel(i, y, Color.DarkBlue)
                            bmp1.SetPixel(i, y + height, Color.DarkBlue)
                            bmp1.SetPixel(i + 1, y, Color.Black)
                            bmp1.SetPixel(i + 1, y + height, Color.DarkBlue)
                            bmp1.SetPixel(i - 1, y, Color.DarkBlue)
                            bmp1.SetPixel(i - 1, y + height, Color.DarkBlue)
                            PictureBox1.Image = bmp1
                        Next
                        For i = y To y + height
                            bmp1.SetPixel(x, i, Color.DarkBlue)
                            bmp1.SetPixel(x + width, i, Color.DarkBlue)
                            bmp1.SetPixel(x, i + 1, Color.DarkBlue)
                            bmp1.SetPixel(x + width, i + 1, Color.DarkBlue)
                            bmp1.SetPixel(x, i - 1, Color.DarkBlue)
                            bmp1.SetPixel(x + width, i - 1, Color.DarkBlue)
                            PictureBox1.Image = bmp1
                        Next
                    Else
                        For i = x To x + width
                            bmp1.SetPixel(i, y, Color.MediumSeaGreen)
                            bmp1.SetPixel(i, y + height, Color.MediumSeaGreen)
                            bmp1.SetPixel(i + 1, y, Color.MediumSeaGreen)
                            bmp1.SetPixel(i + 1, y + height, Color.MediumSeaGreen)
                            bmp1.SetPixel(i - 1, y, Color.MediumSeaGreen)
                            bmp1.SetPixel(i - 1, y + height, Color.MediumSeaGreen)
                            bmp1.SetPixel(i + 2, y, Color.MediumSeaGreen)
                            bmp1.SetPixel(i + 2, y + height, Color.MediumSeaGreen)
                            PictureBox1.Image = bmp1
                        Next
                        For i = y To y + height
                            bmp1.SetPixel(x, i, Color.MediumSeaGreen)
                            bmp1.SetPixel(x + width, i, Color.MediumSeaGreen)
                            bmp1.SetPixel(x, i + 1, Color.MediumSeaGreen)
                            bmp1.SetPixel(x + width, i + 1, Color.MediumSeaGreen)
                            bmp1.SetPixel(x, i - 1, Color.MediumSeaGreen)
                            bmp1.SetPixel(x + width, i - 1, Color.MediumSeaGreen)
                            bmp1.SetPixel(x, i + 2, Color.MediumSeaGreen)
                            bmp1.SetPixel(x + width, i + 2, Color.MediumSeaGreen)
                            PictureBox1.Image = bmp1
                        Next


                    End If
                    If CheckBox2.Checked = True Then
                        For i = x To x + width
                            For j = y To y + height
                                bmp1.SetPixel(i, j, Color.MediumSlateBlue)
                            Next
                        Next
                    End If
                End If
            End If
        End If


    End Sub

    Private Sub TextBox11_TextChanged(sender As System.Object, e As System.EventArgs) Handles y2_textbox.TextChanged

    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        bmp1 = New Bitmap(PictureBox1.Width, PictureBox1.Height)


    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            GroupBox2.Enabled = False
            GroupBox3.Enabled = False
            GroupBox4.Enabled = True

        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            GroupBox2.Enabled = True
            GroupBox3.Enabled = False
            GroupBox4.Enabled = False

        End If

    End Sub

    Private Sub x1_textbox_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)

    End Sub

    Private Sub x1_textbox_TextChanged(sender As System.Object, e As System.EventArgs) Handles x1_textbox.TextChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            GroupBox2.Enabled = False
            GroupBox3.Enabled = True
            GroupBox4.Enabled = False

        End If
    End Sub

    Private Sub y1_textbox_TextChanged(sender As System.Object, e As System.EventArgs) Handles y1_textbox.TextChanged

    End Sub

    Private Sub x2_textbox_TextChanged(sender As System.Object, e As System.EventArgs) Handles x2_textbox.TextChanged

    End Sub

    Private Sub Merkez_x_textbox_TextChanged(sender As System.Object, e As System.EventArgs) Handles Merkez_x_textbox.TextChanged

    End Sub

    Private Sub Merkez_x_textbox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles yarıcap_textbox.KeyPress, y2_textbox.KeyPress, y1_textbox.KeyPress, x2_textbox.KeyPress, x1_textbox.KeyPress, Height_textbox.KeyPress, width_textbox.KeyPress, y_textbox.KeyPress, x_textbox.KeyPress, pctrheight_textbox.KeyPress, pctrwidth_textbox.KeyPress, Merkez_Y_textbox.KeyPress, Merkez_x_textbox.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            e.Handled = Not IsNumeric(e.KeyChar)
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        PictureBox1.Height = CStr(pctrheight_textbox.Text)
        PictureBox1.Width = CStr(pctrwidth_textbox.Text)


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub
End Class
