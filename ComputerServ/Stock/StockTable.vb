Public Class StockTable
    Private Sub SkladBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.SkladBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_PizzeriaDataSet)

    End Sub

    Private Sub StockTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BD_PizzeriaDataSet.sklad". При необходимости она может быть перемещена или удалена.
        Me.SkladTableAdapter.Fill(Me.BD_PizzeriaDataSet.sklad)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Col As System.Windows.Forms.DataGridViewColumn
        Select Case ListBox1.SelectedIndex
            Case 0
                Col = DataGridViewTextBoxColumn1
            Case 1
                Col = DataGridViewTextBoxColumn2
            Case 2
                Col = DataGridViewTextBoxColumn3
            Case 3
                Col = DataGridViewTextBoxColumn4
            Case 4
                Col = DataGridViewTextBoxColumn5
            Case 5
                Col = DataGridViewTextBoxColumn6
            Case 6
                Col = DataGridViewTextBoxColumn7
        End Select
        If RadioButton1.Checked Then
            SkladDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending)
        Else
            SkladDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending)
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Button1.Enabled = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SkladBindingSource.Filter = "Name_ingridienta = '" & ComboBox1.Text & " ' "
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SkladBindingSource.Filter = " "
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For i = 0 To SkladDataGridView.ColumnCount - 1
            For j = 0 To SkladDataGridView.RowCount - 1
                SkladDataGridView.Item(i, j).Style.BackColor = Color.White
                SkladDataGridView.Item(i, j).Style.ForeColor = Color.Black
            Next j
        Next i
        For i = 0 To SkladDataGridView.ColumnCount - 1
            For j = 0 To SkladDataGridView.RowCount - 1
                If InStr(SkladDataGridView.Item(i, j).Value, TextBox1.Text) Then
                    SkladDataGridView.Item(i, j).Style.BackColor = Color.AliceBlue
                    SkladDataGridView.Item(i, j).Style.ForeColor = Color.Blue
                End If
            Next j
        Next i
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        Stock.Show()
    End Sub
End Class