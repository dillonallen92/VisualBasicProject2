Option Explicit On
Option Infer Off
Option Strict On

Public Class Form1
    Dim game As String = ""
    Dim Bullets() As PictureBox = {p1b1, p1b2, p1b3, p1b4, p1b5}

    'Public Class Bullet
    '    Private _x As Integer
    '    Private _Y As Integer
    '    Public Property X As Integer
    '        Get
    '            Return _x
    '        End Get
    '        Set(value As Integer)
    '            If value > 100 Then
    '                _x = value
    '            Else
    '                _x = 100
    '            End If
    '        End Set
    '    End Property

    '    Public Property Y As Integer
    '        Get
    '            Return _Y
    '        End Get
    '        Set(value As Integer)
    '            If value > 70 Then
    '                _Y = value
    '            Else
    '                _Y = 70
    '            End If
    '        End Set
    '    End Property

    '    Public Sub New(ByVal currentX As Integer, ByVal currentY As Integer)
    '        X = currentX
    '        Y = currentY
    '    End Sub
    'End Class
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
        Dim Bullets() As PictureBox = {p1b1, p1b2, p1b3, p1b4, p1b5}

        Static intCount As Integer = 0
        Select Case e.KeyCode 'the arrows are for the player on the right, WASD is for the player on the left
            Case Keys.Up
                If game.Equals("Multiplayer") Then
                    If Not picEn.Location.Y - 5 < 70 Then
                        Loc = New Point(picEn.Location.X, picEn.Location.Y - 5)
                        picEn.Location = Loc
                    End If
                End If

            Case Keys.W
                    If Not picPlayer.Location.Y - 5 < 70 Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                        picPlayer.Location = Loc
                    End If

            Case Keys.Down
                    If game.Equals("Multiplayer") Then
                        If Not picEn.Location.Y - 5 > Me.Height - picEn.Height * 1.6 Then
                            Loc = New Point(picEn.Location.X, picEn.Location.Y + 5)
                            picEn.Location = Loc
                        End If
                    End If

            Case Keys.S
                    If Not picPlayer.Location.Y - 5 > Me.Height - picPlayer.Height * 1.6 Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                        picPlayer.Location = Loc
                    End If

            Case Keys.Left
                If game.Equals("Multiplayer") Then
                    If Not picEn.Location.X - 5 < 0 Then
                        Loc = New Point(picEn.Location.X - 5, picEn.Location.Y)
                        picEn.Location = Loc
                    End If
                End If

            Case Keys.A
                If Not picPlayer.Location.X - 5 < 0 Then
                    Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                    picPlayer.Location = Loc
                End If

            Case Keys.Right
                If game.Equals("Multiplayer") Then
                    If Not picEn.Location.X - 5 > Me.Width - picEn.Width - 5 Then
                        Loc = New Point(picEn.Location.X + 5, picEn.Location.Y)
                        picEn.Location = Loc
                    End If
                End If

            Case Keys.D
                If Not picPlayer.Location.X - 5 > Me.Width - picPlayer.Width - 5 Then
                    Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                    picPlayer.Location = Loc
                End If

            Case Keys.Space 'bullet for player one
                Bullets(intCount).Location = picPlayer.Location
                tmrBullet.Enabled = True

                Timer1.Enabled = True

                Bullets(intCount).Visible = True
                intCount += 1
                If intCount = 5 Then
                    intCount = 0
                End If
                

        End Select
        'If picPlayer.Bounds.IntersectsWith(picEn.Bounds) Then 'May need to be moved later
        '    'picEn.SetBounds(100, Me.Width - 100, 0, 0) ' location of the enemy
        '    For i As Integer = 1 To 10
        '        prbHealth.Value -= 1
        '    Next
        '    If prbHealth.Value = 0 Then
        '        MessageBox.Show("Game Over")
        '    End If
        'End If
    End Sub

    Private Sub tmrBullet_Tick(sender As Object, e As EventArgs) Handles tmrBullet.Tick
        Dim Bullets() As PictureBox = {p1b1, p1b2, p1b3, p1b4, p1b5}

        For x As Integer = 0 To Bullets.Length - 1
            Bullets(x).Left += 10
        Next
        If bulletCol(picEn) Then
            For i As Integer = 1 To 10
                prbEnHp.Value -= 1
            Next
            If prbEnHp.Value = 0 Then
                tmrBullet.Enabled = False
                MessageBox.Show("Game Over")
            End If
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        p1b5.Left += 10

    End Sub

    Private Sub NormalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NormalToolStripMenuItem.Click
        StartGame()
    End Sub

    Private Sub MultiplayerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MultiplayerToolStripMenuItem.Click
        StartMultiplayer()
    End Sub

    Public Sub StartGame()
        game = "Normal"
    End Sub

    Public Sub StartMultiplayer()
        game = "Multiplayer"
    End Sub

    Public Sub GameOver()
        MessageBox.Show("Game is over!")
        'do something better

    End Sub

    Private Function bulletCol(pic As PictureBox) As Boolean
        If p1b1.Bounds.IntersectsWith(pic.Bounds) Then
            p1b1.SetBounds(100, Me.Width - 100, 5, 5)
            Return True
        ElseIf p1b2.Bounds.IntersectsWith(pic.Bounds) Then
            p1b2.SetBounds(100, Me.Width - 100, 5, 5)
            Return True
        ElseIf p1b3.Bounds.IntersectsWith(pic.Bounds) Then
            p1b3.SetBounds(100, Me.Width - 100, 5, 5)
            Return True
        ElseIf p1b4.Bounds.IntersectsWith(pic.Bounds) Then
            p1b4.SetBounds(100, Me.Width - 100, 5, 5)
            Return True
        ElseIf p1b5.Bounds.IntersectsWith(pic.Bounds) Then
            p1b5.SetBounds(100, Me.Width - 100, 5, 5)
            Return True
        Else
            Return False
        End If

    End Function
   
End Class
