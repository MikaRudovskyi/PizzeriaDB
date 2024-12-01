Public Class PositionsReport
    Private Sub PositionsReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BD_PizzeriaDataSet.posady". При необходимости она может быть перемещена или удалена.
        Me.posadyTableAdapter.Fill(Me.BD_PizzeriaDataSet.posady)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Positions.Show()
    End Sub
End Class