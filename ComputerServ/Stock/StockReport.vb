Public Class StockReport
    Private Sub StockReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BD_PizzeriaDataSet.sklad". При необходимости она может быть перемещена или удалена.
        Me.skladTableAdapter.Fill(Me.BD_PizzeriaDataSet.sklad)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Stock.Show()
    End Sub
End Class