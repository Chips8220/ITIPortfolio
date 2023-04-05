' Name: Rectangle.vb
'Programmer: Jacob on 8/8/22
Public Class Rectangle
    Private intlength As Integer
    Private intwidth As Integer

    Public Property Length As Integer
        Get
            Return intlength
        End Get
        Set(value As Integer)
            If value > 0 Then
                intlength = value
            Else
                intlength = 0
            End If
        End Set
    End Property

    Public Property Width As Integer
        Get
            Return intwidth
        End Get
        Set(value As Integer)
            If value > 0 Then
                intwidth = value
            Else
                intwidth = 0
            End If
        End Set
    End Property

    Public Sub New()
        intlength = 0
        intwidth = 0
    End Sub
    Public Function GetArea() As Integer
        Return intlength * intwidth
    End Function
End Class
