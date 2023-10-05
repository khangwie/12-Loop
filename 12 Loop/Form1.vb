Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Num As Integer
        For Num = 1 To 5

            Num += 1
            MsgBox(Num)

            If Num = 4 Then
                Exit For

            End If
        Next
        MsgBox("out of the loop")
    End Sub
End Class
