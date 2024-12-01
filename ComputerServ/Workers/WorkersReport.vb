Public Class WorkersReport
    Private Sub WorkersReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BD_PizzeriaDataSet.pracivnyky". При необходимости она может быть перемещена или удалена.
        Me.pracivnykyTableAdapter.Fill(Me.BD_PizzeriaDataSet.pracivnyky)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Workers.Show()
    End Sub
End Class