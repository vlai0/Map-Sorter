Public Class FrmDieSortProcessing
    Dim strFileName As String
    Private Sub PopulateList(list As List(Of Point), gridView As DataGridView)
        For Each point As Point In list
            gridView.Rows.Add(point.Y, point.X)
        Next
    End Sub

    Private Sub Open_Click(sender As Object, e As EventArgs) Handles OpenMenuItem.Click
        Try
            Dim fd As OpenFileDialog = New OpenFileDialog()


            fd.Title = "Open File"
            fd.InitialDirectory = "Downloads\"
            fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
            fd.FilterIndex = 2
            fd.RestoreDirectory = True

            Dim zeroCounter As Int16 = 0
            Dim fiveCounter As Int16 = 0
            Dim sixCounter As Int16 = 0
            Dim twoCounter As Int16 = 0
            Dim oneCounter As Int16 = 0

            Dim sixCoordinates As List(Of Point) = New List(Of Point)()
            Dim twoCoordinates As List(Of Point) = New List(Of Point)()
            Dim oneCoordinates As List(Of Point) = New List(Of Point)()

            Dim rowCounter As Int16 = 1

            If fd.ShowDialog() = DialogResult.OK Then
                strFileName = fd.FileName

                Using SR As New System.IO.StreamReader(fd.FileName)
                    Do While SR.Peek() >= 0
                        Dim colCounter As Int16 = 1

                        ' Go through file, count + remember point of num

                        Dim firstLine As String = SR.ReadLine
                        For Each c As Char In firstLine
                            Select Case c
                                Case "0"
                                    Dim point As Point = New Point(1, 1)
                                    zeroCounter += 1
                                Case "5"
                                    fiveCounter += 1
                                Case "6"
                                    sixCoordinates.Add(New Point(colCounter, rowCounter))
                                    sixCounter += 1
                                Case "2"
                                    twoCoordinates.Add(New Point(colCounter, rowCounter))
                                    twoCounter += 1
                                Case "1"
                                    oneCoordinates.Add(New Point(colCounter, rowCounter))
                                    oneCounter += 1
                                Case "_"
                                    Exit Do
                            End Select
                            colCounter += 1
                        Next
                        rowCounter += 1
                    Loop


                End Using
            End If

            ' Display
            Counter0.Text = zeroCounter
            Counter5.Text = fiveCounter
            Counter6.Text = sixCounter
            Counter2.Text = twoCounter
            Counter1.Text = oneCounter

            PopulateList(sixCoordinates, sixGridView)
            PopulateList(twoCoordinates, twoGridView)
            PopulateList(oneCoordinates, oneGridView)

            'Export basic information
            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\Vince\OneDrive\Desktop\DieProcess\DieProcess\test.txt", False)
            file.WriteLine("Number of 0: " & zeroCounter)
            file.WriteLine("Number of 5: " & fiveCounter)
            file.WriteLine("Number of 6: " & sixCounter)
            file.WriteLine("Number of 2: " & twoCounter)
            file.WriteLine("Number of 1: " & oneCounter)
            file.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Console.WriteLine("Exception caught: {0}", ex)
        End Try
    End Sub

    Private Sub ExitMenuItem_Click(sender As Object, e As EventArgs) Handles ExitMenuItem.Click
        Me.Dispose(True)
    End Sub

    Private Sub Show_Click(sender As Object, e As EventArgs) Handles Show.Click
        Try
            Process.Start("C:\Windows\System32\notepad.exe", strFileName)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Console.WriteLine("Exception caught: {0}", ex)
        End Try
    End Sub
End Class
