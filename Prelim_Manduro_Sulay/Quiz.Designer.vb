<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Quiz
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.a = New System.Windows.Forms.Button()
        Me.b = New System.Windows.Forms.Button()
        Me.c = New System.Windows.Forms.Button()
        Me.d = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Pause = New System.Windows.Forms.Button()
        Me.Go = New System.Windows.Forms.Button()
        Me.LabelT = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 450)
        Me.Panel1.TabIndex = 0
        '
        'Button4
        '
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button4.Location = New System.Drawing.Point(0, 178)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(200, 53)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Exit"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button3.Location = New System.Drawing.Point(0, 125)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(200, 53)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Reset"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.Location = New System.Drawing.Point(0, 72)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 53)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Change Name"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 72)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(327, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Question"
        '
        'a
        '
        Me.a.Location = New System.Drawing.Point(331, 155)
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(185, 60)
        Me.a.TabIndex = 2
        Me.a.Text = "Button5"
        Me.a.UseVisualStyleBackColor = True
        '
        'b
        '
        Me.b.Location = New System.Drawing.Point(604, 155)
        Me.b.Name = "b"
        Me.b.Size = New System.Drawing.Size(185, 60)
        Me.b.TabIndex = 3
        Me.b.Text = "Button2"
        Me.b.UseVisualStyleBackColor = True
        '
        'c
        '
        Me.c.Location = New System.Drawing.Point(331, 264)
        Me.c.Name = "c"
        Me.c.Size = New System.Drawing.Size(185, 60)
        Me.c.TabIndex = 4
        Me.c.Text = "Button6"
        Me.c.UseVisualStyleBackColor = True
        '
        'd
        '
        Me.d.Location = New System.Drawing.Point(604, 264)
        Me.d.Name = "d"
        Me.d.Size = New System.Drawing.Size(185, 60)
        Me.d.TabIndex = 5
        Me.d.Text = "Button7"
        Me.d.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Pause
        '
        Me.Pause.Location = New System.Drawing.Point(750, 379)
        Me.Pause.Name = "Pause"
        Me.Pause.Size = New System.Drawing.Size(75, 32)
        Me.Pause.TabIndex = 6
        Me.Pause.Text = "Pause"
        Me.Pause.UseVisualStyleBackColor = True
        '
        'Go
        '
        Me.Go.Location = New System.Drawing.Point(750, 379)
        Me.Go.Name = "Go"
        Me.Go.Size = New System.Drawing.Size(75, 32)
        Me.Go.TabIndex = 7
        Me.Go.Text = "Go"
        Me.Go.UseVisualStyleBackColor = True
        '
        'LabelT
        '
        Me.LabelT.AutoSize = True
        Me.LabelT.ForeColor = System.Drawing.Color.White
        Me.LabelT.Location = New System.Drawing.Point(849, 52)
        Me.LabelT.Name = "LabelT"
        Me.LabelT.Size = New System.Drawing.Size(56, 20)
        Me.LabelT.TabIndex = 8
        Me.LabelT.Text = "Timer :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(912, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Label2"
        '
        'Quiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1095, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabelT)
        Me.Controls.Add(Me.Go)
        Me.Controls.Add(Me.Pause)
        Me.Controls.Add(Me.d)
        Me.Controls.Add(Me.c)
        Me.Controls.Add(Me.b)
        Me.Controls.Add(Me.a)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Quiz"
        Me.Text = "e"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents a As Button
    Friend WithEvents b As Button
    Friend WithEvents c As Button
    Friend WithEvents d As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Pause As Button
    Friend WithEvents Go As Button
    Friend WithEvents LabelT As Label
    Friend WithEvents Label2 As Label
End Class
