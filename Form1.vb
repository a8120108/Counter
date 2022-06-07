Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Function fiveincrease()
        If dos < 15 Then
            dos = dos + 1
        ElseIf uno < 15 Then
            uno = uno + 1
        End If
        Return uno & dos
    End Function

    Function fivedecrease()
        If uno > 0 Then
            uno = uno - 1
        ElseIf dos > 0 Then
            dos = dos - 1
        End If
        Return uno & dos
    End Function
    Function fivereset()
        uno = 15
        dos = 15
        Return uno & dos
    End Function
    Function sixincrease()
        If quatro < 24 Then
            quatro = quatro + 1
        ElseIf tres < 12 Then
            tres = tres + 1
        End If
        Return tres & quatro
    End Function

    Function sixdecrease()
        If tres > 0 Then
            tres = tres - 1
        ElseIf quatro > 0 Then
            quatro = quatro - 1
        End If
        Return tres & quatro
    End Function
    Function sixreset()
        tres = 12
        quatro = 24
        Return tres & quatro
    End Function

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mask1 As String
        mask1 = fivedecrease()
        Label3.Text = uno
        Label4.Text = dos
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim mask2 As String
        mask2 = fiveincrease()
        Label3.Text = uno
        Label4.Text = dos
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call fivereset()
        Label3.Text = uno
        Label4.Text = dos
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim mask3 As String
        mask3 = sixdecrease()
        Label5.Text = tres
        Label6.Text = quatro
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim mask4 As String
        mask4 = sixincrease()
        Label5.Text = tres
        Label6.Text = quatro
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Call sixreset()
        Label5.Text = tres
        Label6.Text = quatro
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
    End Sub
End Class
