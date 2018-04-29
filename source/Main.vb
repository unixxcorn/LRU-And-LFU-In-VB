Public Class Main
    Private Sub Goto_LFU_on_Click(sender As Object, e As EventArgs) Handles LFUBut.Click
        LFU.ShowDialog()
    End Sub

    Private Sub LRUbut_Click(sender As Object, e As EventArgs) Handles LRUbut.Click
        LRU.ShowDialog()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim webAddress As String = "https://github.com/unixxcorn/LRU-And-LFU-In-VB"
        Process.Start(webAddress)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class