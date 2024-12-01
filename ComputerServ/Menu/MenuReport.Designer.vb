<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuReport
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuReport))
        Me.menuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BD_PizzeriaDataSet = New ComputerServ.BD_PizzeriaDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.menuTableAdapter = New ComputerServ.BD_PizzeriaDataSetTableAdapters.menuTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.menuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_PizzeriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menuBindingSource
        '
        Me.menuBindingSource.DataMember = "menu"
        Me.menuBindingSource.DataSource = Me.BD_PizzeriaDataSet
        '
        'BD_PizzeriaDataSet
        '
        Me.BD_PizzeriaDataSet.DataSetName = "BD_PizzeriaDataSet"
        Me.BD_PizzeriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(49, Byte), Integer))
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.menuBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ComputerServ.MenuReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(5, 3)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(611, 445)
        Me.ReportViewer1.TabIndex = 0
        '
        'menuTableAdapter
        '
        Me.menuTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(650, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 42)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Повернутись"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MenuReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "MenuReport"
        Me.Text = "Звіт Меню"
        CType(Me.menuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_PizzeriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents menuBindingSource As BindingSource
    Friend WithEvents BD_PizzeriaDataSet As BD_PizzeriaDataSet
    Friend WithEvents menuTableAdapter As BD_PizzeriaDataSetTableAdapters.menuTableAdapter
    Friend WithEvents Button1 As Button
End Class
