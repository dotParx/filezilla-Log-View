Imports System.Text.RegularExpressions
Public Class Form1

    Dim strRow As String()
    Dim intCount As Int16
    Dim dblAmount As Double             'Variable for total amount 
    Dim blnReported As Boolean = True   'Flag to check progress report completed or not

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Allow background operation to be cancelled
        bgWorker.WorkerSupportsCancellation = True

        'Allow background operation to report progress
        bgWorker.WorkerReportsProgress = True
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.InitialDirectory = CurDir.ToString
        openFileDialog1.Filter = "Log Files (*.txt; *.log)|*.txt;*.log|All files (*.*)|*.*"
        openFileDialog1.Title = "Select a fileZilla Log File"
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            ' Assign the cursor in the Stream to the Form's Cursor property.
            SourceFile.Text = openFileDialog1.FileName.ToString
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If My.Computer.FileSystem.FileExists(SourceFile.Text) Then

            logView.Rows.Clear()
            intCount = 0
            Call bgWorker.RunWorkerAsync()
            If 1 = 2 Then ' Begin Never Run
                Dim TextLine As String = ""
                Dim findUser As String = ".*?"
                If userSearch.Text <> "" Then
                    findUser = userSearch.Text
                End If
                'git
                Using objReader As New System.IO.StreamReader(SourceFile.Text)
                    'uid..datetime..user..ip..message
                    Dim pattern As String = "(.*?)\s+(.*?)\s+\-\s+(" & findUser & ")\s+\((.*?)\)\>(.*)"
                    If RETR.Checked.ToString = "True" Then
                        pattern = "(.*?)\s+(.*?)\s+\-\s+(" & findUser & ")\s+\((.*?)\)\>\s+(RETR .*)"
                    End If
                    Do While objReader.Peek() <> -1
                        TextLine = objReader.ReadLine()
                        Dim r As Regex = New Regex(pattern)
                        If (r.IsMatch(TextLine)) Then
                            Dim m As Match = r.Match(TextLine)
                            logView.Rows.Add({m.Groups(1), m.Groups(2), m.Groups(3), m.Groups(4), m.Groups(5)})
                        End If
                    Loop
                End Using
            End If ' Never Run
        Else
            MsgBox("Error: File not found.")
        End If
    End Sub

    Private Sub exportData_Click(sender As Object, e As EventArgs) Handles exportData.Click
        'Check that rows are selected
        Dim totalRow As Int16 = logView.SelectedRows.Count
        If totalRow > 0 Then
            Dim saveFileDialog1 As New SaveFileDialog()
            saveFileDialog1.Filter = "TXT|*.txt|Log|*.log"
            saveFileDialog1.Title = "Save selected rows to"
            saveFileDialog1.ShowDialog()
            'Check that a file location is selected for saving.
            If saveFileDialog1.FileName <> "" Then
                Dim logTo As System.IO.StreamWriter
                logTo = My.Computer.FileSystem.OpenTextFileWriter(saveFileDialog1.FileName.ToString, True)
                For Each row As DataGridViewRow In logView.SelectedRows
                    logTo.WriteLine(row.Cells(0).Value.ToString _
                                    & vbTab & row.Cells(1).Value.ToString _
                                    & vbTab & row.Cells(2).Value.ToString _
                                    & vbTab & row.Cells(3).Value.ToString _
                                    & vbTab & row.Cells(4).Value.ToString)
                Next
                'If you don't close the stream the data won't appear.
                logTo.Close()
            End If

        Else
            MsgBox("No rows are selected. Make sure to choose from the first column.")
        End If


    End Sub

    Private Sub bgWorker_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgWorker.DoWork
        Dim TextLine As String = ""
        Dim findUser As String = ".*?"
        If userSearch.Text <> "" Then
            findUser = userSearch.Text
        End If
        'git
        Using objReader As New System.IO.StreamReader(SourceFile.Text)
            'uid..datetime..user..ip..message
            Dim pattern As String = "(.*?)\s+(.*?)\s+\-\s+(" & findUser & ")\s+\((.*?)\)\>(.*)"
            If RETR.Checked.ToString = "True" Then
                pattern = "(.*?)\s+(.*?)\s+\-\s+(" & findUser & ")\s+\((.*?)\)\>\s+(RETR .*)"
            End If
            Do While objReader.Peek() <> -1
                If bgWorker.CancellationPending Then
                    e.Cancel = True
                    Exit Sub
                Else
                    While Not blnReported
                        Application.DoEvents()
                    End While
                    TextLine = objReader.ReadLine()
                    Dim r As Regex = New Regex(pattern)
                    If (r.IsMatch(TextLine)) Then
                        Dim m As Match = r.Match(TextLine)
                        strRow = {m.Groups(1).ToString, m.Groups(2).ToString, m.Groups(3).ToString, m.Groups(4).ToString, m.Groups(5).ToString}
                        blnReported = False
                        intCount += 1
                        bgWorker.ReportProgress(10, intCount)
                    End If
                End If
                System.Threading.Thread.Sleep(5)
            Loop
        End Using

    End Sub

    Private Sub bgWorker_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles bgWorker.ProgressChanged
        'Copy values to data grid
        logView.Rows.Add(strRow)
        Me.LinesCounted.Text = intCount
        blnReported = True

    End Sub

    Private Sub bgWorker_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgWorker.RunWorkerCompleted

        If e.Cancelled Or Not IsNothing(e.Error) Then
            'Clear the data grid
            logView.Rows.Clear()
            Me.LinesCounted.Text = 0
        Else
            'to come

        End If
    End Sub
End Class
