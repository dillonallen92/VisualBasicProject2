<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.picEn = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StartGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NormalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MultiplayerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstructionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.prbHealth = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tmrBullet = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.prbEnHp = New System.Windows.Forms.ProgressBar()
        Me.p1b1 = New System.Windows.Forms.PictureBox()
        Me.p1b2 = New System.Windows.Forms.PictureBox()
        Me.p1b5 = New System.Windows.Forms.PictureBox()
        Me.p1b3 = New System.Windows.Forms.PictureBox()
        Me.p1b4 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.p1b1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p1b2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p1b5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p1b3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p1b4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPlayer
        '
        Me.picPlayer.Image = CType(resources.GetObject("picPlayer.Image"), System.Drawing.Image)
        Me.picPlayer.InitialImage = CType(resources.GetObject("picPlayer.InitialImage"), System.Drawing.Image)
        Me.picPlayer.Location = New System.Drawing.Point(120, 304)
        Me.picPlayer.Margin = New System.Windows.Forms.Padding(4)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(100, 50)
        Me.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picPlayer.TabIndex = 0
        Me.picPlayer.TabStop = False
        '
        'picEn
        '
        Me.picEn.Image = CType(resources.GetObject("picEn.Image"), System.Drawing.Image)
        Me.picEn.Location = New System.Drawing.Point(1185, 420)
        Me.picEn.Margin = New System.Windows.Forms.Padding(4)
        Me.picEn.Name = "picEn"
        Me.picEn.Size = New System.Drawing.Size(100, 50)
        Me.picEn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picEn.TabIndex = 1
        Me.picEn.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartGameToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1521, 28)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StartGameToolStripMenuItem
        '
        Me.StartGameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NormalToolStripMenuItem, Me.MultiplayerToolStripMenuItem})
        Me.StartGameToolStripMenuItem.Name = "StartGameToolStripMenuItem"
        Me.StartGameToolStripMenuItem.Size = New System.Drawing.Size(95, 24)
        Me.StartGameToolStripMenuItem.Text = "Start Game"
        '
        'NormalToolStripMenuItem
        '
        Me.NormalToolStripMenuItem.Name = "NormalToolStripMenuItem"
        Me.NormalToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.NormalToolStripMenuItem.Text = "Normal"
        '
        'MultiplayerToolStripMenuItem
        '
        Me.MultiplayerToolStripMenuItem.Name = "MultiplayerToolStripMenuItem"
        Me.MultiplayerToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.MultiplayerToolStripMenuItem.Text = "Multiplayer"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InstructionsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'InstructionsToolStripMenuItem
        '
        Me.InstructionsToolStripMenuItem.Name = "InstructionsToolStripMenuItem"
        Me.InstructionsToolStripMenuItem.Size = New System.Drawing.Size(159, 26)
        Me.InstructionsToolStripMenuItem.Text = "Instructions"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(159, 26)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'prbHealth
        '
        Me.prbHealth.BackColor = System.Drawing.SystemColors.Control
        Me.prbHealth.Location = New System.Drawing.Point(16, 54)
        Me.prbHealth.Margin = New System.Windows.Forms.Padding(4)
        Me.prbHealth.Name = "prbHealth"
        Me.prbHealth.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.prbHealth.Size = New System.Drawing.Size(133, 28)
        Me.prbHealth.TabIndex = 0
        Me.prbHealth.Value = 100
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(16, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Health"
        '
        'tmrBullet
        '
        Me.tmrBullet.Interval = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(1459, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Health"
        '
        'prbEnHp
        '
        Me.prbEnHp.BackColor = System.Drawing.SystemColors.Control
        Me.prbEnHp.Location = New System.Drawing.Point(1375, 54)
        Me.prbEnHp.Margin = New System.Windows.Forms.Padding(4)
        Me.prbEnHp.Name = "prbEnHp"
        Me.prbEnHp.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.prbEnHp.Size = New System.Drawing.Size(133, 28)
        Me.prbEnHp.TabIndex = 6
        Me.prbEnHp.Value = 100
        '
        'p1b1
        '
        Me.p1b1.Location = New System.Drawing.Point(169, 107)
        Me.p1b1.Name = "p1b1"
        Me.p1b1.Size = New System.Drawing.Size(5, 5)
        Me.p1b1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.p1b1.TabIndex = 7
        Me.p1b1.TabStop = False
        Me.p1b1.Visible = False
        '
        'p1b2
        '
        Me.p1b2.Location = New System.Drawing.Point(434, 147)
        Me.p1b2.Name = "p1b2"
        Me.p1b2.Size = New System.Drawing.Size(5, 5)
        Me.p1b2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.p1b2.TabIndex = 8
        Me.p1b2.TabStop = False
        Me.p1b2.Visible = False
        '
        'p1b5
        '
        Me.p1b5.Location = New System.Drawing.Point(613, 107)
        Me.p1b5.Name = "p1b5"
        Me.p1b5.Size = New System.Drawing.Size(5, 5)
        Me.p1b5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.p1b5.TabIndex = 9
        Me.p1b5.TabStop = False
        Me.p1b5.Visible = False
        '
        'p1b3
        '
        Me.p1b3.Location = New System.Drawing.Point(515, 107)
        Me.p1b3.Name = "p1b3"
        Me.p1b3.Size = New System.Drawing.Size(5, 5)
        Me.p1b3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.p1b3.TabIndex = 10
        Me.p1b3.TabStop = False
        Me.p1b3.Visible = False
        '
        'p1b4
        '
        Me.p1b4.Location = New System.Drawing.Point(376, 181)
        Me.p1b4.Name = "p1b4"
        Me.p1b4.Size = New System.Drawing.Size(5, 5)
        Me.p1b4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.p1b4.TabIndex = 11
        Me.p1b4.TabStop = False
        Me.p1b4.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1521, 795)
        Me.Controls.Add(Me.p1b4)
        Me.Controls.Add(Me.p1b3)
        Me.Controls.Add(Me.p1b5)
        Me.Controls.Add(Me.p1b2)
        Me.Controls.Add(Me.p1b1)
        Me.Controls.Add(Me.prbEnHp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.prbHealth)
        Me.Controls.Add(Me.picEn)
        Me.Controls.Add(Me.picPlayer)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "EbolaKiller"
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.p1b1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p1b2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p1b5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p1b3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p1b4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents picEn As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents StartGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InstructionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents prbHealth As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tmrBullet As Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents prbEnHp As System.Windows.Forms.ProgressBar
    Friend WithEvents NormalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MultiplayerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents p1b1 As System.Windows.Forms.PictureBox
    Friend WithEvents p1b2 As System.Windows.Forms.PictureBox
    Friend WithEvents p1b5 As System.Windows.Forms.PictureBox
    Friend WithEvents p1b3 As System.Windows.Forms.PictureBox
    Friend WithEvents p1b4 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
