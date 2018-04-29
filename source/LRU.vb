Public Class LRU
    Dim pageRef As String
    Dim pageLen As Integer
    Dim buffer(,) As String
    Dim bufferNum As Integer
    Dim startRow As Integer

    Private Sub LRU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bufferNum = 4
        startRow = 0
    End Sub

    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        If ButtonNext.Text.Equals("Simulate") And Not TextBoxInput.Text.Equals("") Then
            ' Simulate Stage
            TextBoxInput.ReadOnly = True
            pageRef = TextBoxInput.Text
            pageLen = pageRef.Length
            FindLRU(bufferNum, pageLen)
            For Each panel In PanelGrid.Controls
                For Each item In panel.Controls
                    If TypeOf (item) Is System.Windows.Forms.TextBox Then
                        item.Text = "_"
                    End If
                Next
            Next
            ButtonNext.Text = "Next"

        ElseIf ButtonNext.Text.Equals("Next") Then
            ' Next Stage
            If startRow > 6 Then
                If startRow Mod 7 = 0 Then
                    For Each panel In PanelGrid.Controls
                        For Each item In panel.Controls
                            If TypeOf (item) Is System.Windows.Forms.TextBox Then
                                item.Text = "_"
                            End If
                        Next
                    Next
                End If
            End If

            For Each panel In PanelGrid.Controls
                For Each item In panel.Controls
                    If TypeOf (item) Is System.Windows.Forms.TextBox Then
                        Dim i As Integer = Convert.ToInt32(item.Name.SubString(7, 1))
                        Dim j As Integer = Convert.ToInt32(item.Name.SubString(8, 1))
                        If i = startRow Mod 7 Then
                            item.Text = buffer(j, startRow)
                        End If
                    End If
                Next
            Next
            startRow += 1

            ' Show Result
            TextBox_Index2.Text = startRow
            TextBox_Page2.Text = pageRef(startRow - 1)
            For i = 3 To 0 Step -1
                If Not buffer(i, startRow - 1).Equals("_") Then
                    TextBox_LR2.Text = buffer(i, startRow - 1)
                    Exit For
                End If
            Next

            If startRow >= pageRef.Length Then
                ' End Stage
                ButtonNext.Text = "End"
                ButtonNext.Enabled = False
            End If

        Else
            ' Raise Error
            MsgBox("Please Enter some cache")
        End If
    End Sub

    Public Sub FindLRU(ByVal bufferNum As Integer, ByVal pageLen As Integer)
        ReDim buffer(bufferNum - 1, pageLen - 1)
        Dim pageHit As Boolean = False

        ' Initialize Buffer Queue
        For i = 0 To bufferNum - 1
            For j = 0 To pageLen - 1
                buffer(i, j) = "_"
            Next
        Next

        ' Simulate Cache Replacement with LRU algorithm
        For i = 0 To pageLen - 1
            pageHit = False
            If i > 0 Then
                For j = 0 To bufferNum - 1
                    buffer(j, i) = buffer(j, i - 1)
                Next
            End If

            ' Find Page HIT
            For j = 0 To bufferNum - 1
                If buffer(j, i).Equals(pageRef(i)) Then
                    pageHit = True
                    For k = j To 1 Step -1
                        buffer(k, i) = buffer(k - 1, i)
                    Next
                    buffer(0, i) = pageRef(i)
                    Exit For
                End If
            Next

            ' If Page FAULT
            If pageHit = False Then
                If i > 0 Then
                    For j = bufferNum - 1 To 1 Step -1
                        buffer(j, i) = buffer(j - 1, i)
                    Next
                    buffer(0, i) = "_"
                End If

                For j = 0 To bufferNum - 1
                    If buffer(j, i).Equals("_") Then
                        buffer(j, i) = pageRef(i)
                        Exit For
                    End If
                Next
            End If

        Next
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        ClearAll()
    End Sub

    Private Sub ClearAll()
        startRow = 0
        TextBoxInput.ReadOnly = False
        TextBoxInput.Text = ""
        ButtonNext.Text = "Simulate"
        ButtonNext.Enabled = True
        TextBox_Index2.Text = "0"
        TextBox_Page2.Text = ""
        TextBox_LR2.Text = ""

        For Each panel In PanelGrid.Controls
            For Each item In panel.Controls
                If TypeOf (item) Is System.Windows.Forms.TextBox Then
                    item.Text = ""
                End If
            Next
        Next
    End Sub

End Class
