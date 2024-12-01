Public Class OrdersReport
    Private Sub OrdersReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BD_PizzeriaDataSet.zamovlennia". При необходимости она может быть перемещена или удалена.
        Me.zamovlenniaTableAdapter.Fill(Me.BD_PizzeriaDataSet.zamovlennia)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Orders.Show()
    End Sub
End Class