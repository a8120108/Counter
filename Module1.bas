Attribute VB_Name = "Module1"
Sub B305_increase_normal_Click()
Dim r As Integer
Dim s As Integer
r = Range("D3").Value
s = Range("E3").Value
If (s < 19) Then
    Range("E3").Value = s + 1
ElseIf (r < 19) Then
    Range("D3").Value = r + 1
End If
End Sub
Sub B305_decrease_normal_Click()
Dim r As Integer
Dim s As Integer
r = Range("D3").Value
s = Range("E3").Value
If (r > 0) Then
    Range("D3").Value = r - 1
ElseIf (s > 0) Then
    Range("E3").Value = s - 1
End If
End Sub
Sub Reset_B305_Click()
Dim r As Integer
Dim s As Integer
Range("D3").Value = 19
Range("E3").Value = 19
End Sub
Sub B306_increase_normal_Click()
Dim t As Integer
Dim u As Integer
t = Range("D4").Value
u = Range("E4").Value
If (u < 14) Then
    Range("E4").Value = u + 1
ElseIf (t < 12) Then
    Range("D4").Value = t + 1
End If
End Sub
Sub B306_decrease_normal_Click()
Dim t As Integer
Dim u As Integer
t = Range("D4").Value
u = Range("E4").Value
If (t > 0) Then
    Range("D4").Value = t - 1
ElseIf (u > 0) Then
    Range("E4").Value = u - 1
End If
End Sub
Sub Reset_B306_Click()
Dim t As Integer
Dim u As Integer
Range("D4").Value = 12
Range("E4").Value = 14
End Sub
