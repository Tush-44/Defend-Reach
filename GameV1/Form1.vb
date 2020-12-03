Public Class Form1
    Dim R As New Random
    Dim score As Integer
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode

            Case Keys.Up
                MoveTo(PictureBox1, 0, -15)
            Case Keys.Down
                MoveTo(PictureBox1, 0, 15)
            Case Keys.Left
                MoveTo(PictureBox1, -15, 0)
            Case Keys.Right
                MoveTo(PictureBox1, 15, 0)
            Case Keys.Space
                CreateNew("bullet", Bullet, PictureBox1.Location)
            Case Keys.R
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipX)
                Me.Refresh()

        End Select
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    End Sub

    Sub follow(p As PictureBox)
        Static headstart As Integer
        Static c As New Collection
        c.Add(PictureBox1.Location)
        headstart = headstart + 1
        If headstart > 10 Then
            p.Location = c.Item(1)
            c.Remove(1)
        End If
    End Sub

    Public Sub chase(p As PictureBox)
        Dim x, y As Integer
        If p.Location.X > PictureBox1.Location.X Then
            x = -5
        Else
            x = 5
        End If
        MoveTo(p, x, 0)
        If p.Location.Y < PictureBox1.Location.Y Then
            y = 5
        Else
            y = -5
        End If
        MoveTo(p, x, y)
    End Sub

    Function Collision(p As PictureBox, t As String)
        Dim col As Boolean

        For Each c In Controls
            Dim obj As Control
            obj = c
            If p.Bounds.IntersectsWith(obj.Bounds) And obj.Name.ToUpper.Contains(t.ToUpper) Then
                col = True
            End If
        Next
        Return col
    End Function
    'Return true or false if moving to the new location is clear of objects ending with t
    Function IsClear(p As PictureBox, distx As Integer, disty As Integer, t As String) As Boolean
        Dim b As Boolean

        p.Location += New Point(distx, disty)
        b = Not Collision(p, t)
        p.Location -= New Point(distx, disty)
        Return b
        Dim f As New Form2
        f.ShowDialog()
        Me.Visible = True
    End Function
    'Moves and object (won't move onto objects containing  "wall" and shows green if object ends with "win"
    Sub MoveTo(p As PictureBox, distx As Integer, disty As Integer)
        If IsClear(p, distx, disty, "WALL") Then
            p.Location += New Point(distx, disty)
        End If

        If p.Name = "PictureBox1" And Collision(p, "WIN") Then
            Me.BackColor = Color.Green
            Return
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub
    Dim bDir As Integer = 5
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Bullet.Location.X < 0 Then
            bDir = 10
        End If
        If Bullet.Location.X > 1000 Then
            bDir = -10
        End If
        MoveTo(Bullet, bDir, 0)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub CreateNew(name As String, pic As PictureBox, location As Point)
        Dim p As New PictureBox
        p.Location = location
        p.Image = pic.Image
        p.BackColor = pic.BackColor
        p.Name = name
        p.Width = pic.Width
        p.Height = pic.Height
        p.SizeMode = PictureBoxSizeMode.StretchImage
        Controls.Add(p)

    End Sub

    Sub Randmove(P As PictureBox)
        Dim X As Integer
        Dim Y As Integer
        X = R.Next(-10, 11)
        Y = R.Next(-10, 11)
        MoveTo(P, X, Y)
    End Sub
End Class

