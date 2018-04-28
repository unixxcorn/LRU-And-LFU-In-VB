Public Class LFU
    Dim counter As Integer = 0
    Dim InputData As Char
    Dim DataArray(3) As String

    Private Sub NextBut_Click(sender As Object, e As EventArgs) Handles NextBut.Click
        Input.ReadOnly = True
        If Input.Text.Length > counter Then
            InputData = Input.Text.Chars(counter)
            lastData.Text = InputData
            counter = counter + 1
            counter_text.Text = Convert.ToString(counter)

            If DataArray(0) = InputData Then
                blockc0.Text = blockc0.Text + 1
            ElseIf DataArray(1) = InputData Then
                blockc1.Text = blockc1.Text + 1
            ElseIf DataArray(2) = InputData Then
                blockc2.Text = blockc2.Text + 1
            ElseIf DataArray(3) = InputData Then
                blockc3.Text = blockc3.Text + 1

            ElseIf Convert.ToInt32(blockc0.Text) < Convert.ToInt32(blockc1.Text) And
                   Convert.ToInt32(blockc0.Text) < Convert.ToInt32(blockc2.Text) And
                   Convert.ToInt32(blockc0.Text) < Convert.ToInt32(blockc3.Text) Then
                DataArray(0) = InputData
                TextBox000.Text = DataArray(0)
                blockc0.Text = 1
                order0.Text = counter
                block0.Text = InputData
            ElseIf Convert.ToInt32(blockc1.Text) < Convert.ToInt32(blockc0.Text) And
                   Convert.ToInt32(blockc1.Text) < Convert.ToInt32(blockc2.Text) And
                   Convert.ToInt32(blockc1.Text) < Convert.ToInt32(blockc3.Text) Then
                DataArray(1) = InputData
                TextBox100.Text = DataArray(1)
                blockc1.Text = 1
                order1.Text = counter
                block1.Text = InputData
            ElseIf Convert.ToInt32(blockc2.Text) < Convert.ToInt32(blockc0.Text) And
                   Convert.ToInt32(blockc2.Text) < Convert.ToInt32(blockc1.Text) And
                   Convert.ToInt32(blockc2.Text) < Convert.ToInt32(blockc3.Text) Then
                DataArray(2) = InputData
                TextBox200.Text = DataArray(2)
                blockc2.Text = 1
                order2.Text = counter
                block2.Text = InputData
            ElseIf Convert.ToInt32(blockc3.Text) < Convert.ToInt32(blockc0.Text) And
                   Convert.ToInt32(blockc3.Text) < Convert.ToInt32(blockc1.Text) And
                   Convert.ToInt32(blockc3.Text) < Convert.ToInt32(blockc2.Text) Then
                DataArray(3) = InputData
                TextBox300.Text = DataArray(3)
                blockc3.Text = 1
                order3.Text = counter
                block3.Text = InputData

            ElseIf Convert.ToInt32(order0.Text) <= Convert.ToInt32(order1.Text) And
                   Convert.ToInt32(order0.Text) <= Convert.ToInt32(order2.Text) And
                   Convert.ToInt32(order0.Text) <= Convert.ToInt32(order3.Text) Then
                DataArray(0) = InputData
                TextBox000.Text = DataArray(0)
                blockc0.Text = 1
                order0.Text = counter
                block0.Text = InputData
            ElseIf Convert.ToInt32(order1.Text) <= Convert.ToInt32(order0.Text) And
                   Convert.ToInt32(order1.Text) <= Convert.ToInt32(order2.Text) And
                   Convert.ToInt32(order1.Text) <= Convert.ToInt32(order3.Text) Then
                DataArray(1) = InputData
                TextBox100.Text = DataArray(1)
                blockc1.Text = 1
                order1.Text = counter
                block1.Text = InputData
            ElseIf Convert.ToInt32(order2.Text) <= Convert.ToInt32(order0.Text) And
                   Convert.ToInt32(order2.Text) <= Convert.ToInt32(order1.Text) And
                   Convert.ToInt32(order2.Text) <= Convert.ToInt32(order3.Text) Then
                DataArray(2) = InputData
                TextBox200.Text = DataArray(2)
                blockc2.Text = 1
                order2.Text = counter
                block2.Text = InputData
            ElseIf Convert.ToInt32(order3.Text) <= Convert.ToInt32(order0.Text) And
                   Convert.ToInt32(order3.Text) <= Convert.ToInt32(order1.Text) And
                   Convert.ToInt32(order3.Text) <= Convert.ToInt32(order2.Text) Then
                DataArray(3) = InputData
                TextBox300.Text = DataArray(3)
                blockc3.Text = 1
                order3.Text = counter
                block3.Text = InputData

            End If
        Else
            MsgBox("End")
        End If
    End Sub

    Private Sub LFU_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ClearBut_Click(sender As Object, e As EventArgs) Handles ClearBut.Click
        Input.ReadOnly = False
        counter = 0
        counter_text.Text = Convert.ToString(counter)
        TextBox000.Text = ""
        TextBox100.Text = ""
        TextBox200.Text = ""
        TextBox300.Text = ""
        order0.Text = 0
        order1.Text = 0
        order2.Text = 0
        order3.Text = 0
        DataArray(0) = 0
        DataArray(1) = 0
        DataArray(2) = 0
        DataArray(3) = 0
        blockc0.Text = 0
        blockc1.Text = 0
        blockc2.Text = 0
        blockc3.Text = 0
    End Sub


End Class
