Public Class LFU
    Dim counter As Integer = 0
    Dim InputData As Char
    Dim DataArray(3) As String
    Dim count(3) As Integer
    Dim Table(3, 10) As String
    Dim order(3) As Integer
    Dim bool(3) As Boolean

    Private Sub NextBut_Click(sender As Object, e As EventArgs) Handles NextBut.Click
        Input.ReadOnly = True
        NextBut.Text = "Next"

        If Input.Text.Length > counter Then
            InputData = Input.Text.Chars(counter)
            lastData.Text = InputData
            counter = counter + 1
            counter_text.Text = Convert.ToString(counter)
            Dim IsExiest As Boolean = False
            For var As Integer = 0 To 3
                If DataArray(var) = InputData Then
                    count(var) = count(var) + 1
                    IsExiest = True
                End If
            Next

            If Not (IsExiest) Then
                Dim DupMinF As Boolean = False
                Dim DupMini As Boolean = False
                Dim Minimum As Integer = 99999
                Dim MinIndex As Integer = 0
                bool = {False, False, False, False}
                For x = 0 To 3
                    If count(x) = 0 Then
                        bool(x) = True
                    End If
                Next
                ' Find min frequency (count)
                For x As Integer = 0 To 3
                    If Minimum > count(x) Then
                        Minimum = count(x)
                        MinIndex = x
                    ElseIf Minimum = count(x) Then
                        DupMinF = True
                    End If
                Next
                For x = 0 To 3
                    Dim tempo As Integer = 0
                    For y = 0 To 3
                        If count(x) = count(y) And count(x) = Minimum Then
                            tempo = tempo + 1
                        End If
                    Next
                    If tempo > 1 Then
                        bool(x) = True
                    End If
                Next
                If DupMinF Then
                    Dim old As Integer = 99999
                    Dim oldIndex As Integer = 0
                    ' Find oldest value
                    For x As Integer = 0 To 3
                        If old > order(x) And bool(x) Then
                            old = order(x)
                            oldIndex = x
                        End If
                    Next
                    DataArray(oldIndex) = InputData
                    count(oldIndex) = 1
                    order(oldIndex) = counter
                Else
                    DataArray(MinIndex) = InputData
                    count(MinIndex) = 1
                    order(MinIndex) = counter
                End If



            End If

            Dim temp = (counter - 1) Mod 7
            If Not (temp > 0) Then
                For y As Integer = 0 To 6
                    For x As Integer = 0 To 3
                        Table(x, y) = ""
                    Next
                Next
            End If

            For x As Integer = 0 To 3
                Table(x, temp) = DataArray(x)
            Next

        Else
            MsgBox("End")
        End If

        block0.Text = DataArray(0)
        block1.Text = DataArray(1)
        block2.Text = DataArray(2)
        block3.Text = DataArray(3)
        blockc0.Text = count(0)
        blockc1.Text = count(1)
        blockc2.Text = count(2)
        blockc3.Text = count(3)
        order0.Text = order(0)
        order1.Text = order(1)
        order2.Text = order(2)
        order3.Text = order(3)
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
        NextBut.Text = "Simulate"
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
        For y As Integer = 0 To 6
            For x As Integer = 0 To 3
                Table(x, y) = ""
            Next
        Next
        For i As Integer = 0 To 3
            count(i) = 0
            order(i) = 0
            DataArray(i) = ""
        Next
        order0.Text = 0
        order1.Text = 0
        order2.Text = 0
        order3.Text = 0
        blockc0.Text = 0
        blockc1.Text = 0
        blockc2.Text = 0
        blockc3.Text = 0
        block0.Text = ""
        block1.Text = ""
        block2.Text = ""
        block3.Text = ""
    End Sub

End Class
