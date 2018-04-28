<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.LFUBut = New System.Windows.Forms.Button()
        Me.LRUbut = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LFUBut
        '
        Me.LFUBut.Location = New System.Drawing.Point(355, 103)
        Me.LFUBut.Name = "LFUBut"
        Me.LFUBut.Size = New System.Drawing.Size(400, 195)
        Me.LFUBut.TabIndex = 0
        Me.LFUBut.Text = "Button1"
        Me.LFUBut.UseVisualStyleBackColor = True
        '
        'LRUbut
        '
        Me.LRUbut.Location = New System.Drawing.Point(99, 132)
        Me.LRUbut.Name = "LRUbut"
        Me.LRUbut.Size = New System.Drawing.Size(263, 234)
        Me.LRUbut.TabIndex = 1
        Me.LRUbut.Text = "LRUbut"
        Me.LRUbut.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LRUbut)
        Me.Controls.Add(Me.LFUBut)
        Me.Name = "Main"
        Me.Text = "Main"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LFUBut As Button
    Friend WithEvents LRUbut As Button
End Class
