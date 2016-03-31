Option Explicit On
Option Infer Off
Option Strict On

Public Class Form1
    Dim game As String = ""
    Dim Bullets() As PictureBox = {p1b1, p1b2, p1b3, p1b4, p1b5}
    Dim EnBullets() As PictureBox = {p2b1, p2b2, p2b3, p2b4, p2b5}
    Dim enArray() As PictureBox = {picEn, picEn, picEn, picEn, picEn}
    Dim rnd As New Random
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
        Dim EnBullets() As PictureBox = {p2b1, p2b2, p2b3, p2b4, p2b5}

        Static intCount As Integer = 0
        Static intCount2 As Integer = 0
        If game = "Over" Then
            intCount = 0
            intCount2 = 0
            For i As Integer = 0 To 4
                Bullets(i).SetBounds(0, 0, 5, 5)
                EnBullets(i).SetBounds(0, 0, 5, 5)
            Next
            GameOver()
        Else
            Select Case e.KeyCode 'the arrows are for the player on the right, WASD is for the player on the left
                Case Keys.Up
                    If game.Equals("Multiplayer") Then
                        If Not picEn.Location.Y - 5 < 70 Then
                            Loc = New Point(picEn.Location.X, picEn.Location.Y - 20)
                            picEn.Location = Loc
                        End If
                    End If

                Case Keys.W
                    If Not picPlayer.Location.Y - 5 < 70 Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 20)
                        picPlayer.Location = Loc
                    End If

                Case Keys.Down
                    If game.Equals("Multiplayer") Then
                        If Not picEn.Location.Y - 5 > Me.Height - picEn.Height * 1.6 Then
                            Loc = New Point(picEn.Location.X, picEn.Location.Y + 20)
                            picEn.Location = Loc
                        End If
                    End If

                Case Keys.S
                    If Not picPlayer.Location.Y - 5 > Me.Height - picPlayer.Height * 1.6 Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 20)
                        picPlayer.Location = Loc
                    End If

                Case Keys.Left
                    If game.Equals("Multiplayer") Then
                        If Not picEn.Location.X - 5 < 0 Then
                            Loc = New Point(picEn.Location.X - 20, picEn.Location.Y)
                            picEn.Location = Loc
                        End If
                    End If

                Case Keys.A
                    If Not picPlayer.Location.X - 5 < 0 Then
                        Loc = New Point(picPlayer.Location.X - 20, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                    End If

                Case Keys.Right
                    If game.Equals("Multiplayer") Then
                        If Not picEn.Location.X - 5 > Me.Width - picEn.Width - 5 Then
                            Loc = New Point(picEn.Location.X + 20, picEn.Location.Y)
                            picEn.Location = Loc
                        End If
                    End If

                Case Keys.D
                    If Not picPlayer.Location.X - 5 > Me.Width - picPlayer.Width - 5 Then
                        Loc = New Point(picPlayer.Location.X + 20, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                    End If

                Case Keys.Space 'bullet for player one
                    If game.Equals("Over") = False Then
                        Bullets(intCount).Location = picPlayer.Location
                        tmrBullet.Enabled = True

                        Timer1.Enabled = True

                        Bullets(intCount).Visible = True
                        intCount += 1
                        If intCount = 5 Then
                            intCount = 0
                        End If
                    End If
                Case Keys.D0
                    If game.Equals("Multiplayer") Then
                        If game.Equals("Over") = False Then
                            EnBullets(intCount2).Location = picEn.Location
                            tmrEnBullet.Enabled = True
                            EnBullets(intCount2).Visible = True
                            intCount2 += 1
                            If intCount2 = 5 Then
                                intCount2 = 0
                            End If
                        End If
                    End If
            End Select
        End If
        'If picPlayer.Bounds.IntersectsWith(picEn.Bounds) Then 'May need to be moved later
        '   'picEn.SetBounds(100, Me.Width - 100, 0, 0) ' location of the enemy
        '    
        '   prbHealth.Value -= 10
        '   
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
            picEn.SetBounds(888, 237, 0, 0) 'changes location
            prbEnHp.Value -= 10
            If prbEnHp.Value = 0 Then
                tmrBullet.Enabled = False
                tmrEnBullet.Enabled = False
                GameOver()
            End If
        End If

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim enArray() As PictureBox = {picEn, picEn2, picEn3, picEn4, picEn5}
        Dim en As PictureBox
        Dim Loc As Point
        picEn.Left -= 10

        For x As Integer = 0 To enArray.Length - 1
            en = enArray(x)
            Dim int As Integer = rnd.Next(-20, 20)
            Loc = New Point(en.Location.X - int, en.Location.Y - int)
            enArray(x).Location = Loc


            If bulletCol(en) Then
                en.SetBounds(888 - int * 2, 237 - int * 2, 0, 0) 'changes location
            End If
            If en.Location.X - 5 < 0 Then
                en.SetBounds(888 - int * 2, 237 - int * 2, 0, 0)
                prbHealth.Value -= 10 'player loses health if enemy makes it to the edge
                If prbHealth.Value = 0 Then
                    tmrBullet.Enabled = False
                    Timer1.Enabled = False
                    game = "Over"
                    MessageBox.Show("Game Over")
                End If
            End If
            If picPlayer.Bounds.IntersectsWith(en.Bounds) Then 'May need to be moved later
                'picEn.SetBounds(100, Me.Width - 100, 0, 0) ' location of the enemy

                prbHealth.Value -= 10

                If prbHealth.Value = 0 Then
                    tmrBullet.Enabled = False
                    Timer1.Enabled = False
                    game = "Over"
                    MessageBox.Show("Game Over")
                End If
            End If
        Next


    End Sub

    Private Sub NormalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NormalToolStripMenuItem.Click
        StartGame()
    End Sub

    Private Sub MultiplayerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MultiplayerToolStripMenuItem.Click
        StartMultiplayer()
    End Sub

    Public Sub StartGame() 'start the normal game here.... going to spawn an array of enemies that will keep respawning until character dies
        game = "Normal"
        prbHealth.Value = 100
        picPlayer.SetBounds(90, 247, 0, 0)
        picEn.SetBounds(888, 247, 0, 0)
        Timer1.Enabled = True 'starts the timer that makes the enemy move
        prbEnHp.Visible = False
        Label2.Visible = False
    End Sub

    Public Sub StartMultiplayer()
        game = "Multiplayer"
        prbEnHp.Value = 100
        prbHealth.Value = 100
        prbEnHp.Visible = True
        Label2.Visible = True
        picPlayer.SetBounds(90, 247, 0, 0)
        picEn.SetBounds(888, 247, 0, 0)
    End Sub

    Public Sub GameOver()

        Timer1.Enabled = False
        tmrBullet.Enabled = False
        tmrEnBullet.Enabled = False
        game = "Over"
        MessageBox.Show("Game is over!")
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

    Private Function EnBulletCol(pic As PictureBox) As Boolean
        If p2b1.Bounds.IntersectsWith(pic.Bounds) Then
            p2b1.SetBounds(100, Me.Width - 100, 5, 5)
            Return True
        ElseIf p2b2.Bounds.IntersectsWith(pic.Bounds) Then
            p2b2.SetBounds(100, Me.Width - 100, 5, 5)
            Return True
        ElseIf p2b3.Bounds.IntersectsWith(pic.Bounds) Then
            p2b3.SetBounds(100, Me.Width - 100, 5, 5)
            Return True
        ElseIf p2b4.Bounds.IntersectsWith(pic.Bounds) Then
            p2b4.SetBounds(100, Me.Width - 100, 5, 5)
            Return True
        ElseIf p2b5.Bounds.IntersectsWith(pic.Bounds) Then
            p2b5.SetBounds(100, Me.Width - 100, 5, 5)
            Return True
        Else
            Return False
        End If


    End Function
   
    Private Sub tmrEnBullet_Tick(sender As Object, e As EventArgs) Handles tmrEnBullet.Tick
        Dim EnBullets() As PictureBox = {p2b1, p2b2, p2b3, p2b4, p2b5}

        For x As Integer = 0 To EnBullets.Length - 1
            EnBullets(x).Left -= 10
        Next
        If EnBulletCol(picPlayer) Then
            prbHealth.Value -= 10
            If prbHealth.Value = 0 Then
                tmrEnBullet.Enabled = False
                tmrBullet.Enabled = False
                GameOver()
            End If
        End If
        
    End Sub

    'Private Sub tmrEnemy_Tick(sender As Object, e As EventArgs) Handles tmrEnemy.Tick
    '    Dim enArray() As PictureBox = {picEn, picEn2, picEn3, picEn4, picEn5}
    '    Dim en As PictureBox
    '    Dim Loc As Point
    '    For x As Integer = 0 To enArray.Length - 1
    '        en = enArray(x)
    '        Dim int As Integer = rnd.Next(-20, 20)
    '        Loc = New Point(en.Location.X - int, en.Location.Y - int)
    '        enArray(x).Location = Loc

    '        If bulletCol(en) Then
    '            en.SetBounds(888 - int * 2, 237 - int * 2, 0, 0) 'changes location
    '        End If
    '    Next

    'End Sub
End Class
