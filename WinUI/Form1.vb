Imports System.IO
Imports System.Text

Public Class Form1

    Private fileName As String
    Dim oldText As String
    Dim dt As DataTable

    Dim queryData As DataTable
    Dim outputColumn As String
    Dim screen As Integer
    Dim intersectingColumns As List(Of String) = Nothing

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each ctl As Panel In Me.Controls.OfType(Of Panel)
            ctl.Hide()
        Next
        Panel1.Show()
        screen = 1
    End Sub

    Private Sub SaveToCSV(d As DataTable, fileName As String)
        Dim sb As New StringBuilder()

        Dim columnNames As IEnumerable(Of String) = dt.Columns.Cast(Of DataColumn)().Select(Function(column) column.ColumnName)
        sb.AppendLine(String.Join(",", columnNames))

        For Each row As DataRow In d.Rows
            Dim fields As IEnumerable(Of String) = row.ItemArray.[Select](Function(field) field.ToString())
            sb.AppendLine(String.Join(",", fields))
        Next

        File.WriteAllText(fileName, sb.ToString())
    End Sub

    Private Sub ModifyDT(ByRef d As DataTable)
        If Not String.IsNullOrWhiteSpace(txtExclude.Text) Then
            Dim str As String = txtExclude.Text
            Dim exclude = str.Split(","c)
            Dim excludeIndices As New List(Of Integer)
            For Each i As String In exclude
                excludeIndices.Add(Integer.Parse(i))
            Next
            Dim columnNames As New List(Of String)
            If intersectingColumns Is Nothing Then
                For i As Integer = 0 To dt.Columns.Count - 1
                    If Not excludeIndices.Contains(i + 1) Then
                        columnNames.Add(dt.Columns(i).ColumnName)
                    End If
                Next
                intersectingColumns = columnNames
            Else
                columnNames = intersectingColumns
            End If


            ' Modify the data table
            Dim view As New DataView(d)
            d = view.ToTable(False, columnNames.ToArray())
        End If
    End Sub

    Private Sub MetroComboBox1_TextChanged(sender As Object, e As EventArgs) Handles MetroComboBox1.TextChanged
        If oldText = MetroComboBox1.Text Then
            Return
        End If
        oldText = MetroComboBox1.Text
        If MetroComboBox1.Text = "Browse..." Then
            Animator1.Hide(PictureBox1)
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                fileName = OpenFileDialog1.FileName
                MetroComboBox1.Items.Add(fileName)
                MetroComboBox1.Text = OpenFileDialog1.FileName
            End If
        Else
            If MetroComboBox1.Text.EndsWith(".csv") Then
                ' TODO: We must validate that's it's a valid CSV file here.
                Animator1.Show(PictureBox1)
            Else ' It's not a CSV
                Animator1.Hide(PictureBox1)
            End If
        End If
    End Sub

    Private Sub MetroTile1_Click(sender As Object, e As EventArgs) Handles MetroTile1.Click
        If Not PictureBox1.Visible Then
            MetroFramework.MetroMessageBox.Show(Me, "You must choose a valid CSV file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If screen = 1 Then
                ' Load data into DataGridView1
                dt = CsvImport.NewDataTable(fileName, ",")
                DataGridView1.DataSource = dt

                ' Load into output vector in cmbOutputVector
                For i As Integer = 1 To dt.Columns.Count
                    cmbOutputVector.Items.Add(i)
                Next

                ' Move to the next panel
                Animator2.Hide(Panel1, True)
                Animator2.Show(Panel2, True)
            Else
                ' Save all the data for the Python code

                Dim tempPath = Path.GetTempPath() + "\"

                Dim trainFileName As String = tempPath + "ba_train.csv"
                Dim queryFileName As String = tempPath + "ba_query.csv"

                SaveToCSV(dt, trainFileName)
                Dim sb As New StringBuilder
                sb.AppendLine(trainFileName)
                sb.AppendLine(outputColumn)
                sb.AppendLine(queryFileName)

                ' Load and format the query data
                queryData = CsvImport.NewDataTable(fileName, ",")
                ModifyDT(queryData)
                SaveToCSV(queryData, queryFileName)

                ' Write the data to the file
                File.WriteAllText(tempPath + "ba_data.txt", sb.ToString())

                ' First run the Python freezed program

                ' Load next screen
            End If
        End If
    End Sub

    Private Sub MetroTile2_Click(sender As Object, e As EventArgs) Handles MetroTile2.Click
        ' Screen 2
        Try
            ' Make sure he entered the output vector column
            If String.IsNullOrWhiteSpace(cmbOutputVector.Text) Then
                ' Oops!
                Throw New InvalidExpressionException("Invalid output vector field.")
            End If
            outputColumn = dt.Columns(Integer.Parse(cmbOutputVector.Text) - 1).ColumnName
            ModifyDT(dt)

            If MetroFramework.MetroMessageBox.Show(Me, "You are selecting " + dt.Columns.Count.ToString() + " columns. Confirm?",
                                                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
                Throw New Exception("User did not confirm")
            End If

            ' Go to next panel
            Animator2.Hide(Panel2, True)
            Animator2.Show(Panel1, True)
            MetroLabel1.Text = "Choose the query CSV."
            oldText = ""
            PictureBox1.Hide()
            MetroComboBox1.Items.Clear()
            MetroComboBox1.Items.Add("Browse...")
            screen = 3
        Catch
            MetroFramework.MetroMessageBox.Show(Me, "There was an error in your input.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
