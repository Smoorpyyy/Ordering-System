﻿Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
    Private cblack As Double = 150
    Private bgray As Double = 200
    Private wb As Double = 200
    Private snb As Double = 200
    Private wpink As Double = 200
    Private dblack As Double = 200
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        UpdateQuantityAndTotal(+1, TextBox1, TextBox7, cblack)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        UpdateQuantityAndTotal(-1, TextBox1, TextBox7, cblack)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        UpdateQuantityAndTotal(+1, TextBox3, TextBox2, bgray)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        UpdateQuantityAndTotal(-1, TextBox3, TextBox2, bgray)
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        UpdateQuantityAndTotal(+1, TextBox5, TextBox4, wb)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        UpdateQuantityAndTotal(-1, TextBox5, TextBox4, wb)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        UpdateQuantityAndTotal(+1, TextBox8, TextBox6, snb)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        UpdateQuantityAndTotal(-1, TextBox8, TextBox6, snb)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        UpdateQuantityAndTotal(+1, TextBox10, TextBox9, wpink)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        UpdateQuantityAndTotal(-1, TextBox10, TextBox9, wpink)
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        UpdateQuantityAndTotal(+1, TextBox12, TextBox11, dblack)
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        UpdateQuantityAndTotal(-1, TextBox12, TextBox11, dblack)
    End Sub
    Private Sub UpdateQuantityAndTotal(change As Integer, quantityTextBox As TextBox, totalTextBox As TextBox, price As Double)
        Dim quantity As Integer
        Integer.TryParse(quantityTextBox.Text, quantity)

        ' Update quantity and ensure it doesn't go negative
        quantity += change
        If quantity < 0 Then quantity = 0

        ' Update quantity textbox and calculate total
        quantityTextBox.Text = quantity.ToString()
        totalTextBox.Text = (quantity * price).ToString("F2")
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged

    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub
    Private Sub UpdateTotal()
        Dim value1 As Double = 0
        Dim value2 As Double = 0
        Dim value3 As Double = 0
        Dim value4 As Double = 0
        Dim value5 As Double = 0
        Dim value6 As Double = 0

        ' Parse the values from each textbox, if possible
        Double.TryParse(TextBox7.Text, value1)
        Double.TryParse(TextBox2.Text, value2)
        Double.TryParse(TextBox4.Text, value3)
        Double.TryParse(TextBox6.Text, value4)
        Double.TryParse(TextBox9.Text, value5)
        Double.TryParse(TextBox11.Text, value6)

        ' Calculate the total
        Dim total As Double = value1 + value2 + value3 + value4 + value5 + value6

        ' Display the total in the total textbox with 2 decimal places
        TextBox13.Text = total.ToString("F2")
    End Sub

    ' Event handler for text changes in each textbox
    Private Sub txtBox_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged, TextBox2.TextChanged, TextBox4.TextChanged, TextBox6.TextChanged, TextBox9.TextChanged, TextBox11.TextChanged
        UpdateTotal() ' Call the UpdateTotal method whenever any textbox value changes
    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged
        Form1.UpdateTotal()
    End Sub
    Public ReadOnly Property Carrier As Double
        Get
            Dim value As Double = 0
            Double.TryParse(TextBox13.Text, value)
            Return value
        End Get
    End Property
End Class