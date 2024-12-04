Public Class foods
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub foods_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private dfoodsPrice As Double = 65
    Private cfoodsPrice As Double = 60
    Private ctreatsPrice As Double = 35
    Private dtreatsPrice As Double = 25
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        UpdateQuantityAndTotal(-1, TextBox1, TextBox5, dfoodsPrice)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        UpdateQuantityAndTotal(+1, TextBox1, TextBox5, dfoodsPrice)
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        UpdateQuantityAndTotal(-1, TextBox2, TextBox6, cfoodsPrice)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        UpdateQuantityAndTotal(+1, TextBox2, TextBox6, cfoodsPrice)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        UpdateQuantityAndTotal(-1, TextBox3, TextBox7, ctreatsPrice)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        UpdateQuantityAndTotal(+1, TextBox3, TextBox7, ctreatsPrice)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        UpdateQuantityAndTotal(-1, TextBox4, TextBox8, dtreatsPrice)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        UpdateQuantityAndTotal(+1, TextBox4, TextBox8, dtreatsPrice)
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
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        Form1.UpdateTotal()
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub
    Private Sub UpdateTotal()
        Dim value1 As Double = 0
        Dim value2 As Double = 0
        Dim value3 As Double = 0
        Dim value4 As Double = 0

        ' Parse the values from each textbox, if possible
        Double.TryParse(TextBox5.Text, value1)
        Double.TryParse(TextBox6.Text, value2)
        Double.TryParse(TextBox7.Text, value3)
        Double.TryParse(TextBox8.Text, value4)

        ' Calculate the total
        Dim total As Double = value1 + value2 + value3 + value4

        ' Display the total in the total textbox with 2 decimal places
        TextBox9.Text = total.ToString("F2")
    End Sub

    ' Event handler for text changes in each textbox
    Private Sub txtBox_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged, TextBox6.TextChanged, TextBox7.TextChanged, TextBox8.TextChanged
        UpdateTotal() ' Call the UpdateTotal method whenever any textbox value changes
    End Sub
    Public ReadOnly Property Food As Double
        Get
            Dim value As Double = 0
            Double.TryParse(TextBox9.Text, value)
            Return value
        End Get
    End Property
End Class