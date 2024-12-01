<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stock
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
        Dim Name_ingridientaLabel As System.Windows.Forms.Label
        Dim Data_vypuskuLabel As System.Windows.Forms.Label
        Dim ObiemLabel As System.Windows.Forms.Label
        Dim Termin_prydatnostiLabel As System.Windows.Forms.Label
        Dim VartistLabel As System.Windows.Forms.Label
        Dim PostachalnykLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Stock))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BD_PizzeriaDataSet = New ComputerServ.BD_PizzeriaDataSet()
        Me.SkladBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SkladTableAdapter = New ComputerServ.BD_PizzeriaDataSetTableAdapters.skladTableAdapter()
        Me.TableAdapterManager = New ComputerServ.BD_PizzeriaDataSetTableAdapters.TableAdapterManager()
        Me.Name_ingridientaTextBox = New System.Windows.Forms.TextBox()
        Me.Data_vypuskuDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ObiemTextBox = New System.Windows.Forms.TextBox()
        Me.Termin_prydatnostiDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.VartistTextBox = New System.Windows.Forms.TextBox()
        Me.PostachalnykTextBox = New System.Windows.Forms.TextBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ID_ingridientaComboBox = New System.Windows.Forms.ComboBox()
        Name_ingridientaLabel = New System.Windows.Forms.Label()
        Data_vypuskuLabel = New System.Windows.Forms.Label()
        ObiemLabel = New System.Windows.Forms.Label()
        Termin_prydatnostiLabel = New System.Windows.Forms.Label()
        VartistLabel = New System.Windows.Forms.Label()
        PostachalnykLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.BD_PizzeriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SkladBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Name_ingridientaLabel
        '
        Name_ingridientaLabel.AutoSize = True
        Name_ingridientaLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(49, Byte), Integer))
        Name_ingridientaLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Name_ingridientaLabel.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Name_ingridientaLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(61, Byte), Integer))
        Name_ingridientaLabel.Location = New System.Drawing.Point(67, 97)
        Name_ingridientaLabel.Name = "Name_ingridientaLabel"
        Name_ingridientaLabel.Size = New System.Drawing.Size(200, 27)
        Name_ingridientaLabel.TabIndex = 2
        Name_ingridientaLabel.Text = "Назва інгредієнта"
        '
        'Data_vypuskuLabel
        '
        Data_vypuskuLabel.AutoSize = True
        Data_vypuskuLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(49, Byte), Integer))
        Data_vypuskuLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Data_vypuskuLabel.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Data_vypuskuLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(61, Byte), Integer))
        Data_vypuskuLabel.Location = New System.Drawing.Point(111, 136)
        Data_vypuskuLabel.Name = "Data_vypuskuLabel"
        Data_vypuskuLabel.Size = New System.Drawing.Size(156, 27)
        Data_vypuskuLabel.TabIndex = 4
        Data_vypuskuLabel.Text = "Дата випуску"
        '
        'ObiemLabel
        '
        ObiemLabel.AutoSize = True
        ObiemLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(49, Byte), Integer))
        ObiemLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        ObiemLabel.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        ObiemLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(61, Byte), Integer))
        ObiemLabel.Location = New System.Drawing.Point(196, 211)
        ObiemLabel.Name = "ObiemLabel"
        ObiemLabel.Size = New System.Drawing.Size(71, 27)
        ObiemLabel.TabIndex = 6
        ObiemLabel.Text = "Об'єм"
        '
        'Termin_prydatnostiLabel
        '
        Termin_prydatnostiLabel.AutoSize = True
        Termin_prydatnostiLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(49, Byte), Integer))
        Termin_prydatnostiLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Termin_prydatnostiLabel.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Termin_prydatnostiLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(61, Byte), Integer))
        Termin_prydatnostiLabel.Location = New System.Drawing.Point(45, 172)
        Termin_prydatnostiLabel.Name = "Termin_prydatnostiLabel"
        Termin_prydatnostiLabel.Size = New System.Drawing.Size(222, 27)
        Termin_prydatnostiLabel.TabIndex = 8
        Termin_prydatnostiLabel.Text = "Термін придатності"
        '
        'VartistLabel
        '
        VartistLabel.AutoSize = True
        VartistLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(49, Byte), Integer))
        VartistLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        VartistLabel.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        VartistLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(61, Byte), Integer))
        VartistLabel.Location = New System.Drawing.Point(153, 248)
        VartistLabel.Name = "VartistLabel"
        VartistLabel.Size = New System.Drawing.Size(114, 27)
        VartistLabel.TabIndex = 10
        VartistLabel.Text = "Вартість"
        '
        'PostachalnykLabel
        '
        PostachalnykLabel.AutoSize = True
        PostachalnykLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(49, Byte), Integer))
        PostachalnykLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        PostachalnykLabel.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        PostachalnykLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(61, Byte), Integer))
        PostachalnykLabel.Location = New System.Drawing.Point(104, 286)
        PostachalnykLabel.Name = "PostachalnykLabel"
        PostachalnykLabel.Size = New System.Drawing.Size(163, 27)
        PostachalnykLabel.TabIndex = 12
        PostachalnykLabel.Text = "Постачальник"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(49, Byte), Integer))
        Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label1.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(61, Byte), Integer))
        Label1.Location = New System.Drawing.Point(92, 59)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(175, 27)
        Label1.TabIndex = 58
        Label1.Text = "Код інгредієнта"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(689, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Повернутись"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BD_PizzeriaDataSet
        '
        Me.BD_PizzeriaDataSet.DataSetName = "BD_PizzeriaDataSet"
        Me.BD_PizzeriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SkladBindingSource
        '
        Me.SkladBindingSource.DataMember = "sklad"
        Me.SkladBindingSource.DataSource = Me.BD_PizzeriaDataSet
        '
        'SkladTableAdapter
        '
        Me.SkladTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.menuTableAdapter = Nothing
        Me.TableAdapterManager.posadyTableAdapter = Nothing
        Me.TableAdapterManager.pracivnykyTableAdapter = Nothing
        Me.TableAdapterManager.skladTableAdapter = Me.SkladTableAdapter
        Me.TableAdapterManager.UpdateOrder = ComputerServ.BD_PizzeriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.zamovlenniaTableAdapter = Nothing
        '
        'Name_ingridientaTextBox
        '
        Me.Name_ingridientaTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Name_ingridientaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SkladBindingSource, "Name_ingridienta", True))
        Me.Name_ingridientaTextBox.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Name_ingridientaTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Name_ingridientaTextBox.Location = New System.Drawing.Point(273, 95)
        Me.Name_ingridientaTextBox.Name = "Name_ingridientaTextBox"
        Me.Name_ingridientaTextBox.Size = New System.Drawing.Size(467, 29)
        Me.Name_ingridientaTextBox.TabIndex = 3
        '
        'Data_vypuskuDateTimePicker
        '
        Me.Data_vypuskuDateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Data_vypuskuDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SkladBindingSource, "Data_vypusku", True))
        Me.Data_vypuskuDateTimePicker.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Data_vypuskuDateTimePicker.Location = New System.Drawing.Point(273, 136)
        Me.Data_vypuskuDateTimePicker.Name = "Data_vypuskuDateTimePicker"
        Me.Data_vypuskuDateTimePicker.Size = New System.Drawing.Size(467, 29)
        Me.Data_vypuskuDateTimePicker.TabIndex = 5
        '
        'ObiemTextBox
        '
        Me.ObiemTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ObiemTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SkladBindingSource, "Obiem", True))
        Me.ObiemTextBox.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ObiemTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.ObiemTextBox.Location = New System.Drawing.Point(273, 211)
        Me.ObiemTextBox.Name = "ObiemTextBox"
        Me.ObiemTextBox.Size = New System.Drawing.Size(467, 29)
        Me.ObiemTextBox.TabIndex = 7
        '
        'Termin_prydatnostiDateTimePicker
        '
        Me.Termin_prydatnostiDateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Termin_prydatnostiDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SkladBindingSource, "Termin_prydatnosti", True))
        Me.Termin_prydatnostiDateTimePicker.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Termin_prydatnostiDateTimePicker.Location = New System.Drawing.Point(273, 171)
        Me.Termin_prydatnostiDateTimePicker.Name = "Termin_prydatnostiDateTimePicker"
        Me.Termin_prydatnostiDateTimePicker.Size = New System.Drawing.Size(467, 29)
        Me.Termin_prydatnostiDateTimePicker.TabIndex = 9
        '
        'VartistTextBox
        '
        Me.VartistTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.VartistTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SkladBindingSource, "Vartist", True))
        Me.VartistTextBox.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.VartistTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.VartistTextBox.Location = New System.Drawing.Point(273, 248)
        Me.VartistTextBox.Name = "VartistTextBox"
        Me.VartistTextBox.Size = New System.Drawing.Size(467, 29)
        Me.VartistTextBox.TabIndex = 11
        '
        'PostachalnykTextBox
        '
        Me.PostachalnykTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PostachalnykTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SkladBindingSource, "Postachalnyk", True))
        Me.PostachalnykTextBox.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.PostachalnykTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.PostachalnykTextBox.Location = New System.Drawing.Point(273, 284)
        Me.PostachalnykTextBox.Name = "PostachalnykTextBox"
        Me.PostachalnykTextBox.Size = New System.Drawing.Size(467, 29)
        Me.PostachalnykTextBox.TabIndex = 13
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Button10.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Button10.Location = New System.Drawing.Point(542, 350)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(131, 29)
        Me.Button10.TabIndex = 56
        Me.Button10.Text = "Звіт"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Button9.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Button9.Location = New System.Drawing.Point(405, 437)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(131, 29)
        Me.Button9.TabIndex = 55
        Me.Button9.Text = "Таблиця"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Button8.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Button8.Location = New System.Drawing.Point(405, 408)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(131, 29)
        Me.Button8.TabIndex = 54
        Me.Button8.Text = "Видалити"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Button7.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Button7.Location = New System.Drawing.Point(405, 379)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(131, 29)
        Me.Button7.TabIndex = 53
        Me.Button7.Text = "Остання"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Button6.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Button6.Location = New System.Drawing.Point(405, 350)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(131, 29)
        Me.Button6.TabIndex = 52
        Me.Button6.Text = "Попередня"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Button5.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(174, 408)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(131, 29)
        Me.Button5.TabIndex = 51
        Me.Button5.Text = "Наступна"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(174, 379)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(131, 29)
        Me.Button4.TabIndex = 50
        Me.Button4.Text = "Додати"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(174, 350)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(131, 29)
        Me.Button3.TabIndex = 49
        Me.Button3.Text = "Перша"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(174, 437)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 29)
        Me.Button2.TabIndex = 48
        Me.Button2.Text = "Зберегти"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ID_ingridientaComboBox
        '
        Me.ID_ingridientaComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ID_ingridientaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SkladBindingSource, "ID_ingridienta", True))
        Me.ID_ingridientaComboBox.DataSource = Me.SkladBindingSource
        Me.ID_ingridientaComboBox.DisplayMember = "ID_ingridienta"
        Me.ID_ingridientaComboBox.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold)
        Me.ID_ingridientaComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.ID_ingridientaComboBox.FormattingEnabled = True
        Me.ID_ingridientaComboBox.Location = New System.Drawing.Point(273, 57)
        Me.ID_ingridientaComboBox.Name = "ID_ingridientaComboBox"
        Me.ID_ingridientaComboBox.Size = New System.Drawing.Size(467, 31)
        Me.ID_ingridientaComboBox.TabIndex = 57
        '
        'Stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(816, 486)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.ID_ingridientaComboBox)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(PostachalnykLabel)
        Me.Controls.Add(Me.PostachalnykTextBox)
        Me.Controls.Add(VartistLabel)
        Me.Controls.Add(Me.VartistTextBox)
        Me.Controls.Add(Termin_prydatnostiLabel)
        Me.Controls.Add(Me.Termin_prydatnostiDateTimePicker)
        Me.Controls.Add(ObiemLabel)
        Me.Controls.Add(Me.ObiemTextBox)
        Me.Controls.Add(Data_vypuskuLabel)
        Me.Controls.Add(Me.Data_vypuskuDateTimePicker)
        Me.Controls.Add(Name_ingridientaLabel)
        Me.Controls.Add(Me.Name_ingridientaTextBox)
        Me.Controls.Add(Me.Button1)
        Me.DoubleBuffered = True
        Me.Name = "Stock"
        Me.Text = "Склад"
        CType(Me.BD_PizzeriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SkladBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents BD_PizzeriaDataSet As BD_PizzeriaDataSet
    Friend WithEvents SkladBindingSource As BindingSource
    Friend WithEvents SkladTableAdapter As BD_PizzeriaDataSetTableAdapters.skladTableAdapter
    Friend WithEvents TableAdapterManager As BD_PizzeriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Name_ingridientaTextBox As TextBox
    Friend WithEvents Data_vypuskuDateTimePicker As DateTimePicker
    Friend WithEvents ObiemTextBox As TextBox
    Friend WithEvents Termin_prydatnostiDateTimePicker As DateTimePicker
    Friend WithEvents VartistTextBox As TextBox
    Friend WithEvents PostachalnykTextBox As TextBox
    Friend WithEvents Button10 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ID_ingridientaComboBox As ComboBox
End Class
