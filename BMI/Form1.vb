Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim weight As String = TextBox1.Text
        Dim strheight As String = TextBox2.Text
        Dim Result As String
        Dim bmi As String

        bmi = weight / strheight ^ 2

        If bmi < 18.5 Then
            Result = " Underweight"
        ElseIf bmi >= 18.5 And bmi <= 24.9 Then
            Result = " Normal weight"
        ElseIf bmi >= 25 And bmi <= 29.9 Then
            Result = " Overweight"
        ElseIf bmi >= 30 Then
            Result = " Obesity"
        Else
            Result = " please input a correct weight and height"
        End If
        Label1.Text = bmi + Result
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
