Imports System.Text.RegularExpressions
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.InitialDirectory = CurDir.ToString
        openFileDialog1.Filter = "Log Files (*.txt; *.log)|*.txt;*.log|All files (*.*)|*.*"
        openFileDialog1.Title = "Select a fileZilla Log File"
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            ' Assign the cursor in the Stream to the Form's Cursor property.
            TextBox1.Text = openFileDialog1.FileName.ToString
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If My.Computer.FileSystem.FileExists(TextBox1.Text) Then
            logView.Rows.Clear()
            Dim TextLine As String = ""
            Dim findUser As String = ".*?"
            If userSearch.Text <> "" Then
                findUser = userSearch.Text
            End If
            'git
            Using objReader As New System.IO.StreamReader(TextBox1.Text)
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
End Class
