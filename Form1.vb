Public Class Form1

    'Declaring Variables as Integers
    Dim firstValue, secondValue As Decimal
    Dim isSuma As Boolean = False
    Dim isResta As Boolean = False
    Dim isMultpl As Boolean = False
    Dim isDiv As Boolean = False

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        TextBox1.Text = TextBox1.Text + "1"
        secondValue = Convert.ToDouble(TextBox1.Text)
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        TextBox1.Text = TextBox1.Text + "2"
        secondValue = Convert.ToDecimal(TextBox1.Text)
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        TextBox1.Text = TextBox1.Text + "3"
        secondValue = Convert.ToDecimal(TextBox1.Text)
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        TextBox1.Text = TextBox1.Text + "4"
        secondValue = Convert.ToDecimal(TextBox1.Text)
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        TextBox1.Text = TextBox1.Text + "5"
        secondValue = Convert.ToDecimal(TextBox1.Text)
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        TextBox1.Text = TextBox1.Text + "6"
        secondValue = Convert.ToDecimal(TextBox1.Text)
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        TextBox1.Text = TextBox1.Text + "7"
        secondValue = Convert.ToDecimal(TextBox1.Text)
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        TextBox1.Text = TextBox1.Text + "8"
        secondValue = Convert.ToDecimal(TextBox1.Text)
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        TextBox1.Text = TextBox1.Text + "9"
        secondValue = Convert.ToDecimal(TextBox1.Text)
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        TextBox1.Text = TextBox1.Text + "0"
        secondValue = Convert.ToDecimal(TextBox1.Text)
    End Sub

    Private Sub btnSum_Click(sender As Object, e As EventArgs) Handles btnSum.Click
        firstValue = Convert.ToDecimal(TextBox1.Text)
        isSuma = True
        TextBox1.Clear()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        TextBox1.Clear()
        isSuma = False
        isResta = False
        isMultpl = False
        isDiv = False
    End Sub

    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        If isSuma = True Then 'Tostring convierte a cadena
            TextBox1.Text = firstValue + secondValue 'Equal verificar que el elemento seleccionado sea igual a la cadena de caracteres
        ElseIf isResta = True Then
            TextBox1.Text = firstValue - secondValue
        ElseIf isMultpl = True Then
            TextBox1.Text = firstValue * secondValue
        ElseIf isDiv = True Then
            TextBox1.Text = firstValue / secondValue
        End If
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        firstValue = Convert.ToDecimal(TextBox1.Text)
        isResta = True
        TextBox1.Clear()
    End Sub

    Private Sub btnMult_Click(sender As Object, e As EventArgs) Handles btnMult.Click
        firstValue = Convert.ToDecimal(TextBox1.Text)
        isMultpl = True
        TextBox1.Clear()
    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        firstValue = Convert.ToDecimal(TextBox1.Text)
        isDiv = True
        TextBox1.Clear()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Enabled = False
    End Sub

    Private Sub btnPto_Click(sender As Object, e As EventArgs) Handles btnPto.Click
        TextBox1.Text += "."
        firstValue = Convert.ToDecimal(TextBox1.Text)
    End Sub



End Class
