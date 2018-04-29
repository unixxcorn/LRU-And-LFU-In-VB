<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.LFUBut = New System.Windows.Forms.Button()
        Me.LRUbut = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LFUBut
        '
        Me.LFUBut.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.LFUBut.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFUBut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.LFUBut.Location = New System.Drawing.Point(300, 364)
        Me.LFUBut.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LFUBut.Name = "LFUBut"
        Me.LFUBut.Size = New System.Drawing.Size(172, 86)
        Me.LFUBut.TabIndex = 0
        Me.LFUBut.Text = "LFU"
        Me.LFUBut.UseVisualStyleBackColor = False
        '
        'LRUbut
        '
        Me.LRUbut.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.LRUbut.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LRUbut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.LRUbut.Location = New System.Drawing.Point(834, 364)
        Me.LRUbut.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LRUbut.Name = "LRUbut"
        Me.LRUbut.Size = New System.Drawing.Size(172, 86)
        Me.LRUbut.TabIndex = 1
        Me.LRUbut.Text = "LRU"
        Me.LRUbut.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(424, 584)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 20)
        Me.Label2.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(596, 620)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 32)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Visit Us"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(1143, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 50)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(444, -22)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(433, 358)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.LFULRUSimulator.My.Resources.Resources.GitHub_Mark_Light_64px
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(589, 507)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(129, 97)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 744)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LRUbut)
        Me.Controls.Add(Me.LFUBut)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1286, 800)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1286, 800)
        Me.Name = "Main"
        Me.Text = "LRUandLFU simulator"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LFUBut As Button
    Friend WithEvents LRUbut As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
