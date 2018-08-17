Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim openFileDialog1 As OpenFileDialog = New OpenFileDialog

        ' Set filter options
        openFileDialog1.Filter = "All Files (*.*)|*.*"
        openFileDialog1.Multiselect = False

        ' If the user clicks OK, read the file
        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Label1.Text = openFileDialog1.FileName
            Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(openFileDialog1.FileName)
                MyReader.TextFieldType = FileIO.FieldType.Delimited
                MyReader.Delimiters = New String() {"~"}
                Dim currentRow As String()
                While Not MyReader.EndOfData
                    Try
                        currentRow = MyReader.ReadFields()
                        For Each row As String In currentRow
                            TextBoxResults.Text = TextBoxResults.Text + row + vbCrLf
                        Next

                    Catch ex As Exception
                        openFileDialog1.Dispose()
                    End Try
                End While
            End Using
        End If
        openFileDialog1.Dispose()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

End Class
