' Name:         CourseGrade.vb
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class CourseGrade
    Private intScore1 As Integer
    Private intScore2 As Integer
    Private strGrade As String

    Public Property Score1 As Integer
        Get
            Return intScore1
        End Get
        Set(value As Integer)
            intScore1 = value
        End Set
    End Property

    Public Property Score2 As Integer
        Get
            Return intScore2
        End Get
        Set(value As Integer)
            intScore2 = value
        End Set
    End Property

    Public ReadOnly Property Grade As String
        Get
            Return strGrade
        End Get
    End Property
    Public Sub New()
        intScore1 = 0
        intScore2 = 0
        strGrade = String.Empty
    End Sub
    Public Sub DetermineGrade()
        Select Case intScore1 + intScore2
            Case Is >= 180
                strGrade = "A"
            Case Is >= 160
                strGrade = "B"
            Case Is >= 140
                strGrade = "C"
            Case Is >= 120
                strGrade = "D"
            Case Else
                strGrade = "F"
        End Select
    End Sub
End Class



