Public Class MenuTable
    Private Sub MenuBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MenuBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_PizzeriaDataSet)

    End Sub
    Private Sub MenuTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BD_PizzeriaDataSet.menu". При необходимости она может быть перемещена или удалена.
        Me.MenuTableAdapter.Fill(Me.BD_PizzeriaDataSet.menu)

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
            Case 7
                Col = DataGridViewTextBoxColumn8
            Case 8
                Col = DataGridViewTextBoxColumn9
        End Select
        If RadioButton1.Checked Then
            MenuDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending)
        Else
            MenuDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending)
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Button1.Enabled = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MenuBindingSource.Filter = "Name_stravy = '" & ComboBox1.Text & " ' "
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MenuBindingSource.Filter = " "
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For i = 0 To MenuDataGridView.ColumnCount - 1
            For j = 0 To MenuDataGridView.RowCount - 1
                MenuDataGridView.Item(i, j).Style.BackColor = Color.White
                MenuDataGridView.Item(i, j).Style.ForeColor = Color.Black
            Next j
        Next i
        For i = 0 To MenuDataGridView.ColumnCount - 1
            For j = 0 To MenuDataGridView.RowCount - 1
                If InStr(MenuDataGridView.Item(i, j).Value, TextBox1.Text) Then
                    MenuDataGridView.Item(i, j).Style.BackColor = Color.AliceBlue
                    MenuDataGridView.Item(i, j).Style.ForeColor = Color.Blue
                End If
            Next j
        Next i
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        MenuPizzeria.Show()
    End Sub
End Class