Public Class Workers
    Private Sub PracivnykyBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PracivnykyBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_PizzeriaDataSet)

    End Sub

    Private Sub Workers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BD_PizzeriaDataSet.pracivnyky". При необходимости она может быть перемещена или удалена.
        Me.PracivnykyTableAdapter.Fill(Me.BD_PizzeriaDataSet.pracivnyky)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Tables.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PracivnykyBindingSource.MoveFirst()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        PracivnykyBindingSource.MovePrevious()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PracivnykyBindingSource.AddNew()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        PracivnykyBindingSource.MoveLast()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        PracivnykyBindingSource.MoveNext()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        PracivnykyBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Validate()
        Me.PracivnykyBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_PizzeriaDataSet)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Close()
        WorkersTable.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Close()
        WorkersReport.Show()
    End Sub
End Class