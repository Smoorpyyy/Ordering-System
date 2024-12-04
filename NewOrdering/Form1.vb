Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With foods
            .TopLevel = False
            Panel2.Controls.Add(foods)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With collar
            .TopLevel = False
            Panel2.Controls.Add(collar)
            .BringToFront()
            .Show()
        End With
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        With Form2
            .TopLevel = False
            Panel2.Controls.Add(Form2)
            .BringToFront()
            .Show()
        End With
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        With cage
            .TopLevel = False
            Panel2.Controls.Add(cage)
            .BringToFront()
            .Show()
        End With
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel1_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel2_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        For Each ctrl As Control In Panel2.Controls
            ctrl.Hide() ' Hides each control
        Next

        ' Show the welcome label in Panel6
        Panel6.Visible = True
    End Sub

    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub
    Public Sub UpdateTotal()
        ' Assuming Form2, Form3, Form4, Form5 are already open and accessible
        Dim total As Double = foods.Food + collar.Collar + Form2.Carrier + cage.Cage

        ' Display the total in the txtTotal textbox on Form1, formatted to 2 decimal places
        RichTextBox1.Text = total.ToString("F2")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ' Assuming you have a TextBox named txtTotal to display the total price
        ' and a Button named btnCalculateChange.

        Dim totalPrice As Double
        If Not Double.TryParse(RichTextBox1.Text, totalPrice) Then
            MessageBox.Show("Please enter a valid total price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Prompt the user to enter the cash amount.
        Dim inputCash As String = InputBox("Please enter the cash amount:", "Cash Input")

        ' Parse and validate the cash input.
        Dim cashGiven As Double
        If Not Double.TryParse(inputCash, cashGiven) Then
            MessageBox.Show("Invalid cash amount entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Check if the cash given is enough to cover the total price.
        If cashGiven < totalPrice Then
            MessageBox.Show("Insufficient cash. Please provide at least: " & totalPrice.ToString("F2"), "Insufficient Cash", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Calculate the change.
        Dim change As Double = cashGiven - totalPrice

        ' Display the change in a message box.
        MessageBox.Show("Transaction successful! Your change is: PHP " & change.ToString("F2"), "Change", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
