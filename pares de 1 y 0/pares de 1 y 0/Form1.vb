Public Class Form1
    Dim cabezal = 0
    Dim cinta As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text += " "
        s1()
    End Sub
    Sub s1()
        If TextBox1.Text(cabezal) = "1" Then
            cinta += "1"
            cabezal += 1
            Label1.Text = cinta
            MsgBox("1:1,D")
            s2()
        ElseIf TextBox1.Text(cabezal) = "0" Then
            cinta += "0"
            cabezal += 1
            Label1.Text = cinta
            MsgBox("0:0,D")
            s2()
        ElseIf TextBox1.Text(cabezal) = " " Then
            MsgBox("no se acepta la cadena")

        End If
    End Sub
    Sub s2()
        If TextBox1.Text(cabezal) = "1" Then
            cinta += "1"
            cabezal += 1
            Label1.Text = cinta
            MsgBox("1:1,D")
            s3()
        ElseIf TextBox1.Text(cabezal) = "0" Then
            cinta += "0"
            cabezal += 1
            Label1.Text = cinta
            MsgBox("0:0,D")
            s3()
        ElseIf TextBox1.Text(cabezal) = " " Then
            MsgBox("No se acepta la cadena")
        End If

    End Sub
    Sub s3()
        If TextBox1.Text(cabezal) = "1" Then
            cinta += "1"
            cabezal += 1
            Label1.Text = cinta
            MsgBox("1:1,D")
            s2()
        ElseIf TextBox1.Text(cabezal) = "0" Then
            cinta += "0"
            cabezal += 1
            Label1.Text = cinta
            MsgBox("0:0,D")
            s2()
        ElseIf TextBox1.Text(cabezal) = " " Then
            MsgBox("0's y 1's Pares")
        End If
    End Sub
End Class
