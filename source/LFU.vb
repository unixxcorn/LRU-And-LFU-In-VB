Public Class LFU
    Dim counter As Integer = 0
    Dim InputData As Char
    Dim DataArray(3) As String
    Dim Table(3, 10) As String

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

                blockc0.Text = 1
                order0.Text = counter
                block0.Text = InputData
            ElseIf Convert.ToInt32(blockc1.Text) < Convert.ToInt32(blockc0.Text) And
                   Convert.ToInt32(blockc1.Text) < Convert.ToInt32(blockc2.Text) And
                   Convert.ToInt32(blockc1.Text) < Convert.ToInt32(blockc3.Text) Then
                DataArray(1) = InputData

                blockc1.Text = 1
                order1.Text = counter
                block1.Text = InputData
            ElseIf Convert.ToInt32(blockc2.Text) < Convert.ToInt32(blockc0.Text) And
                   Convert.ToInt32(blockc2.Text) < Convert.ToInt32(blockc1.Text) And
                   Convert.ToInt32(blockc2.Text) < Convert.ToInt32(blockc3.Text) Then
                DataArray(2) = InputData

                blockc2.Text = 1
                order2.Text = counter
                block2.Text = InputData
            ElseIf Convert.ToInt32(blockc3.Text) < Convert.ToInt32(blockc0.Text) And
                   Convert.ToInt32(blockc3.Text) < Convert.ToInt32(blockc1.Text) And
                   Convert.ToInt32(blockc3.Text) < Convert.ToInt32(blockc2.Text) Then
                DataArray(3) = InputData

                blockc3.Text = 1
                order3.Text = counter
                block3.Text = InputData

            ElseIf Convert.ToInt32(order0.Text) <= Convert.ToInt32(order1.Text) And
                   Convert.ToInt32(order0.Text) <= Convert.ToInt32(order2.Text) And
                   Convert.ToInt32(order0.Text) <= Convert.ToInt32(order3.Text) Then
                DataArray(0) = InputData

                blockc0.Text = 1
                order0.Text = counter
                block0.Text = InputData
            ElseIf Convert.ToInt32(order1.Text) <= Convert.ToInt32(order0.Text) And
                   Convert.ToInt32(order1.Text) <= Convert.ToInt32(order2.Text) And
                   Convert.ToInt32(order1.Text) <= Convert.ToInt32(order3.Text) Then
                DataArray(1) = InputData

                blockc1.Text = 1
                order1.Text = counter
                block1.Text = InputData
            ElseIf Convert.ToInt32(order2.Text) <= Convert.ToInt32(order0.Text) And
                   Convert.ToInt32(order2.Text) <= Convert.ToInt32(order1.Text) And
                   Convert.ToInt32(order2.Text) <= Convert.ToInt32(order3.Text) Then
                DataArray(2) = InputData

                blockc2.Text = 1
                order2.Text = counter
                block2.Text = InputData
            ElseIf Convert.ToInt32(order3.Text) <= Convert.ToInt32(order0.Text) And
                   Convert.ToInt32(order3.Text) <= Convert.ToInt32(order1.Text) And
                   Convert.ToInt32(order3.Text) <= Convert.ToInt32(order2.Text) Then
                DataArray(3) = InputData

                blockc3.Text = 1
                order3.Text = counter
                block3.Text = InputData

            End If
        Else
            MsgBox("End")
        End If
        Dim temp = (counter - 1) Mod 7
        If Not (temp > 0) Then
            Table(0, 0) = ""
            Table(1, 0) = ""
            Table(2, 0) = ""
            Table(3, 0) = ""
            Table(0, 1) = ""
            Table(1, 1) = ""
            Table(2, 1) = ""
            Table(3, 1) = ""
            Table(0, 2) = ""
            Table(1, 2) = ""
            Table(2, 2) = ""
            Table(3, 2) = ""
            Table(0, 3) = ""
            Table(1, 3) = ""
            Table(2, 3) = ""
            Table(3, 3) = ""
            Table(0, 4) = ""
            Table(1, 4) = ""
            Table(2, 4) = ""
            Table(3, 4) = ""
            Table(0, 5) = ""
            Table(1, 5) = ""
            Table(2, 5) = ""
            Table(3, 5) = ""
            Table(0, 6) = ""
            Table(1, 6) = ""
            Table(2, 6) = ""
            Table(3, 6) = ""
        End If
        Table(0, temp) = DataArray(0)
        Table(1, temp) = DataArray(1)
        Table(2, temp) = DataArray(2)
        Table(3, temp) = DataArray(3)

        TextBox000.Text = Table(0, 0)
        TextBox100.Text = Table(1, 0)
        TextBox200.Text = Table(2, 0)
        TextBox300.Text = Table(3, 0)
        TextBox001.Text = Table(0, 1)
        TextBox101.Text = Table(1, 1)
        TextBox201.Text = Table(2, 1)
        TextBox301.Text = Table(3, 1)
        TextBox002.Text = Table(0, 2)
        TextBox102.Text = Table(1, 2)
        TextBox202.Text = Table(2, 2)
        TextBox302.Text = Table(3, 2)
        TextBox003.Text = Table(0, 3)
        TextBox103.Text = Table(1, 3)
        TextBox203.Text = Table(2, 3)
        TextBox303.Text = Table(3, 3)
        TextBox004.Text = Table(0, 4)
        TextBox104.Text = Table(1, 4)
        TextBox204.Text = Table(2, 4)
        TextBox304.Text = Table(3, 4)
        TextBox005.Text = Table(0, 5)
        TextBox105.Text = Table(1, 5)
        TextBox205.Text = Table(2, 5)
        TextBox305.Text = Table(3, 5)
        TextBox006.Text = Table(0, 6)
        TextBox106.Text = Table(1, 6)
        TextBox206.Text = Table(2, 6)
        TextBox306.Text = Table(3, 6)

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
        TextBox001.Text = ""
        TextBox101.Text = ""
        TextBox201.Text = ""
        TextBox301.Text = ""
        TextBox002.Text = ""
        TextBox102.Text = ""
        TextBox202.Text = ""
        TextBox302.Text = ""
        TextBox003.Text = ""
        TextBox103.Text = ""
        TextBox203.Text = ""
        TextBox303.Text = ""
        TextBox004.Text = ""
        TextBox104.Text = ""
        TextBox204.Text = ""
        TextBox304.Text = ""
        TextBox005.Text = ""
        TextBox105.Text = ""
        TextBox205.Text = ""
        TextBox305.Text = ""
        TextBox006.Text = ""
        TextBox106.Text = ""
        TextBox206.Text = ""
        TextBox306.Text = ""
        Table(0, 0) = ""
        Table(1, 0) = ""
        Table(2, 0) = ""
        Table(3, 0) = ""
        Table(0, 1) = ""
        Table(1, 1) = ""
        Table(2, 1) = ""
        Table(3, 1) = ""
        Table(0, 2) = ""
        Table(1, 2) = ""
        Table(2, 2) = ""
        Table(3, 2) = ""
        Table(0, 3) = ""
        Table(1, 3) = ""
        Table(2, 3) = ""
        Table(3, 3) = ""
        Table(0, 4) = ""
        Table(1, 4) = ""
        Table(2, 4) = ""
        Table(3, 4) = ""
        Table(0, 5) = ""
        Table(1, 5) = ""
        Table(2, 5) = ""
        Table(3, 5) = ""
        Table(0, 6) = ""
        Table(1, 6) = ""
        Table(2, 6) = ""
        Table(3, 6) = ""
        order0.Text = 0
        order1.Text = 0
        order2.Text = 0
        order3.Text = 0
        DataArray(0) = ""
        DataArray(1) = ""
        DataArray(2) = ""
        DataArray(3) = ""
        blockc0.Text = 0
        blockc1.Text = 0
        blockc2.Text = 0
        blockc3.Text = 0
    End Sub


End Class
