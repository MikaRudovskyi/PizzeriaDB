﻿Public Class PositionsTable
    Private Sub PosadyBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PosadyBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_PizzeriaDataSet)

    End Sub
    Private Sub PositionsTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BD_PizzeriaDataSet.posady". При необходимости она может быть перемещена или удалена.
        Me.PosadyTableAdapter.Fill(Me.BD_PizzeriaDataSet.posady)

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
        End Select
        If RadioButton1.Checked Then
            PosadyDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending)
        Else
            PosadyDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending)
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Button1.Enabled = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PosadyBindingSource.Filter = "Name_posady = '" & ComboBox1.Text & " ' "
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PosadyBindingSource.Filter = " "
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For i = 0 To PosadyDataGridView.ColumnCount - 1
            For j = 0 To PosadyDataGridView.RowCount - 1
                PosadyDataGridView.Item(i, j).Style.BackColor = Color.White
                PosadyDataGridView.Item(i, j).Style.ForeColor = Color.Black
            Next j
        Next i
        For i = 0 To PosadyDataGridView.ColumnCount - 1
            For j = 0 To PosadyDataGridView.RowCount - 1
                If InStr(PosadyDataGridView.Item(i, j).Value, TextBox1.Text) Then
                    PosadyDataGridView.Item(i, j).Style.BackColor = Color.AliceBlue
                    PosadyDataGridView.Item(i, j).Style.ForeColor = Color.Blue
                End If
            Next j
        Next i
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        Positions.Show()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class