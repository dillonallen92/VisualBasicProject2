Option Explicit On
Option Infer Off
Option Strict On

Public Class Form1

    Public Class Ship
        Private _health As Double
        Private _damage As Double
    End Class

    Public Class Enemy
        Inherits Ship
        'Private _speed As Double = 20.0
    End Class

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                picPlayer.SetBounds(picPlayer.Left, picPlayer.Top - 5, 0, 0)
            Case Keys.Down
                picPlayer.SetBounds(picPlayer.Left, picPlayer.Top + 5, 0, 0)
            Case Keys.Left
                picPlayer.SetBounds(picPlayer.Left - 5, picPlayer.Top, 0, 0)
            Case Keys.Right
                picPlayer.SetBounds(picPlayer.Left + 5, picPlayer.Top, 0, 0)
            Case Keys.Space

        End Select
    End Sub
End Class
