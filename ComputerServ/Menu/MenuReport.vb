Public Class MenuReport
    Private Sub MenuReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BD_PizzeriaDataSet.menu". При необходимости она может быть перемещена или удалена.
        Me.menuTableAdapter.Fill(Me.BD_PizzeriaDataSet.menu)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        MenuPizzeria.Show()
    End Sub
End Class