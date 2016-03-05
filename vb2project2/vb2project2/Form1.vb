Option Explicit On
Option Infer Off
Option Strict On

Public Class Form1
    Public Bullets As New List(Of Bullet)

    Public Class Bullet
        Private _x As Integer
        Private _Y As Integer
        Public Property X As Integer
            Get
                Return _x
            End Get
            Set(value As Integer)
                If value > 100 Then
                    _x = value
                Else
                    _x = 100
                End If
            End Set
        End Property

        Public Property Y As Integer
            Get
                Return _Y
            End Get
            Set(value As Integer)
                If value > 70 Then
                    _Y = value
                Else
                    _Y = 70
                End If
            End Set
        End Property

        Public Sub New(ByVal currentX As Integer, ByVal currentY As Integer)
            X = currentX
            Y = currentY
        End Sub
    End Class
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
        Dim Loc As Point
        Select Case e.KeyCode
            Case Keys.Up
                If Not picEn.Location.Y - 5 < 70 Then
                    Loc = New Point(picEn.Location.X, picEn.Location.Y - 5)
                    picEn.Location = Loc
                End If

            Case Keys.W
                If Not picPlayer.Location.Y - 5 < 70 Then
                    Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                    picPlayer.Location = Loc
                End If

            Case Keys.Down
                If Not picEn.Location.Y - 5 > Me.Height - picEn.Height * 1.6 Then
                    Loc = New Point(picEn.Location.X, picEn.Location.Y + 5)
                    picEn.Location = Loc
                End If

            Case Keys.S
                If Not picPlayer.Location.Y - 5 > Me.Height - picPlayer.Height * 1.6 Then
                    Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                    picPlayer.Location = Loc
                End If

            Case Keys.Left
                If Not picEn.Location.X - 5 < 0 Then
                    Loc = New Point(picEn.Location.X - 5, picEn.Location.Y)
                    picEn.Location = Loc
                End If

            Case Keys.A
                If Not picPlayer.Location.X - 5 < 0 Then
                    Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                    picPlayer.Location = Loc
                End If

            Case Keys.Right
                If Not picEn.Location.X - 5 > Me.Width - picEn.Width - 5 Then
                    Loc = New Point(picEn.Location.X + 5, picEn.Location.Y)
                    picEn.Location = Loc
                End If

            Case Keys.D
                If Not picPlayer.Location.X - 5 > Me.Width - picPlayer.Width - 5 Then
                    Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                    picPlayer.Location = Loc
                End If

            Case Keys.Space
                tmrBullet.Enabled = True
                Dim b As New Bullet(picPlayer.Location.X, picPlayer.Location.Y)
                Bullets.Add(b)

        End Select
        If picPlayer.Bounds.IntersectsWith(picEn.Bounds) Then 'May need to be moved later
            picEn.SetBounds(100, Me.Width - 100, 0, 0) ' location of the enemy
            For i As Integer = 1 To 10
                prbHealth.Value -= 1
            Next
            If prbHealth.Value = 0 Then
                MessageBox.Show("Game Over")
            End If
        End If
    End Sub

    Private Sub tmrBullet_Tick(sender As Object, e As EventArgs) Handles tmrBullet.Tick
        For Each b As Bullet In Bullets
            b.X += 5
            If b.X = picEn.Location.X AndAlso b.Y = picEn.Location.Y Then
                MessageBox.Show("Hit") 'Test
            End If
        Next
    End Sub
End Class
