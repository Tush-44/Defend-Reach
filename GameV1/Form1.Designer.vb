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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ArizonWall = New System.Windows.Forms.PictureBox()
        Me.Bullet = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArizonWall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.GameV1.My.Resources.Resources._811k0lk_ykL__AC_UL1500_
        Me.PictureBox1.Location = New System.Drawing.Point(12, 151)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(195, 229)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.GameV1.My.Resources.Resources.covenant_elite_minor_mega_construx_clash_on_ring_halo_800x1
        Me.PictureBox3.Location = New System.Drawing.Point(594, 139)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(194, 229)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'ArizonWall
        '
        Me.ArizonWall.Image = Global.GameV1.My.Resources.Resources._5_newmethodfor
        Me.ArizonWall.Location = New System.Drawing.Point(-3, -5)
        Me.ArizonWall.Name = "ArizonWall"
        Me.ArizonWall.Size = New System.Drawing.Size(1679, 45)
        Me.ArizonWall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ArizonWall.TabIndex = 3
        Me.ArizonWall.TabStop = False
        '
        'Bullet
        '
        Me.Bullet.BackColor = System.Drawing.Color.Transparent
        Me.Bullet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Bullet.Image = Global.GameV1.My.Resources.Resources.download
        Me.Bullet.Location = New System.Drawing.Point(213, 151)
        Me.Bullet.Name = "Bullet"
        Me.Bullet.Size = New System.Drawing.Size(27, 27)
        Me.Bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bullet.TabIndex = 4
        Me.Bullet.TabStop = False
        Me.Bullet.UseWaitCursor = True
        Me.Bullet.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ScoreLabel"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GameV1.My.Resources.Resources._8381171693f7fedc6b6411c39f15f9fb
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Bullet)
        Me.Controls.Add(Me.ArizonWall)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "Protect Tiki Land"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArizonWall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ArizonWall As PictureBox
    Friend WithEvents Bullet As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label1 As Label
End Class
