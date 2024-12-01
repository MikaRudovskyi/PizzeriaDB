<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Workers
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim PIBLabel As System.Windows.Forms.Label
        Dim VikLabel As System.Windows.Forms.Label
        Dim AdresaLabel As System.Windows.Forms.Label
        Dim TelefonLabel As System.Windows.Forms.Label
        Dim Pasportni_daniLabel As System.Windows.Forms.Label
        Dim StatLabel As System.Windows.Forms.Label
        Dim ID_posadyLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Workers))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BD_PizzeriaDataSet = New ComputerServ.BD_PizzeriaDataSet()
        Me.PracivnykyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PracivnykyTableAdapter = New ComputerServ.BD_PizzeriaDataSetTableAdapters.pracivnykyTableAdapter()
        Me.TableAdapterManager = New ComputerServ.BD_PizzeriaDataSetTableAdapters.TableAdapterManager()
        Me.PIBTextBox = New System.Windows.Forms.TextBox()
        Me.VikTextBox = New System.Windows.Forms.TextBox()
        Me.AdresaTextBox = New System.Windows.Forms.TextBox()
        Me.Pasportni_daniTextBox = New System.Windows.Forms.TextBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.StatTextBox = New System.Windows.Forms.TextBox()
        Me.ID_posadyComboBox = New System.Windows.Forms.ComboBox()
        Me.IDComboBox = New System.Windows.Forms.ComboBox()
        Me.TelefonMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        PIBLabel = New System.Windows.Forms.Label()
        VikLabel = New System.Windows.Forms.Label()
        AdresaLabel = New System.Windows.Forms.Label()
        TelefonLabel = New System.Windows.Forms.Label()
        Pasportni_daniLabel = New System.Windows.Forms.Label()
        StatLabel = New System.Windows.Forms.Label()
        ID_posadyLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.BD_PizzeriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PracivnykyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PIBLabel
        '
        PIBLabel.AutoSize = True
        PIBLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(157, Byte), Integer))
        PIBLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        PIBLabel.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        PIBLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(211, Byte), Integer))
        PIBLabel.Location = New System.Drawing.Point(194, 87)
        PIBLabel.Name = "PIBLabel"
        PIBLabel.Size = New System.Drawing.Size(53, 27)
        PIBLabel.TabIndex = 2
        PIBLabel.Text = "ПІБ"
        '
        'VikLabel
        '
        VikLabel.AutoSize = True
        VikLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(157, Byte), Integer))
        VikLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        VikLabel.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        VikLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(211, Byte), Integer))
        VikLabel.Location = New System.Drawing.Point(202, 122)
        VikLabel.Name = "VikLabel"
        VikLabel.Size = New System.Drawing.Size(45, 27)
        VikLabel.TabIndex = 4
        VikLabel.Text = "Вік"
        '
        'AdresaLabel
        '
        AdresaLabel.AutoSize = True
        AdresaLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(157, Byte), Integer))
        AdresaLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        AdresaLabel.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        AdresaLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(211, Byte), Integer))
        AdresaLabel.Location = New System.Drawing.Point(165, 192)
        AdresaLabel.Name = "AdresaLabel"
        AdresaLabel.Size = New System.Drawing.Size(83, 27)
        AdresaLabel.TabIndex = 8
        AdresaLabel.Text = "Адреса"
        '
        'TelefonLabel
        '
        TelefonLabel.AutoSize = True
        TelefonLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(157, Byte), Integer))
        TelefonLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        TelefonLabel.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        TelefonLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(211, Byte), Integer))
        TelefonLabel.Location = New System.Drawing.Point(150, 227)
        TelefonLabel.Name = "TelefonLabel"
        TelefonLabel.Size = New System.Drawing.Size(98, 27)
        TelefonLabel.TabIndex = 10
        TelefonLabel.Text = "Телефон"
        '
        'Pasportni_daniLabel
        '
        Pasportni_daniLabel.AutoSize = True
        Pasportni_daniLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(157, Byte), Integer))
        Pasportni_daniLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Pasportni_daniLabel.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Pasportni_daniLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(211, Byte), Integer))
        Pasportni_daniLabel.Location = New System.Drawing.Point(78, 262)
        Pasportni_daniLabel.Name = "Pasportni_daniLabel"
        Pasportni_daniLabel.Size = New System.Drawing.Size(170, 27)
        Pasportni_daniLabel.TabIndex = 12
        Pasportni_daniLabel.Text = "Паспортні дані"
        '
        'StatLabel
        '
        StatLabel.AutoSize = True
        StatLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(157, Byte), Integer))
        StatLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        StatLabel.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Italic)
        StatLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(211, Byte), Integer))
        StatLabel.Location = New System.Drawing.Point(162, 159)
        StatLabel.Name = "StatLabel"
        StatLabel.Size = New System.Drawing.Size(85, 27)
        StatLabel.TabIndex = 57
        StatLabel.Text = "Стать"
        '
        'ID_posadyLabel
        '
        ID_posadyLabel.AutoSize = True
        ID_posadyLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(157, Byte), Integer))
        ID_posadyLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        ID_posadyLabel.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Italic)
        ID_posadyLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(211, Byte), Integer))
        ID_posadyLabel.Location = New System.Drawing.Point(123, 49)
        ID_posadyLabel.Name = "ID_posadyLabel"
        ID_posadyLabel.Size = New System.Drawing.Size(124, 27)
        ID_posadyLabel.TabIndex = 56
        ID_posadyLabel.Text = "Код посади"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(157, Byte), Integer))
        Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label1.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Italic)
        Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(211, Byte), Integer))
        Label1.Location = New System.Drawing.Point(78, 12)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(168, 27)
        Label1.TabIndex = 60
        Label1.Text = "Код працівника"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(747, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Повернутись"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BD_PizzeriaDataSet
        '
        Me.BD_PizzeriaDataSet.DataSetName = "BD_PizzeriaDataSet"
        Me.BD_PizzeriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PracivnykyBindingSource
        '
        Me.PracivnykyBindingSource.DataMember = "pracivnyky"
        Me.PracivnykyBindingSource.DataSource = Me.BD_PizzeriaDataSet
        '
        'PracivnykyTableAdapter
        '
        Me.PracivnykyTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.menuTableAdapter = Nothing
        Me.TableAdapterManager.posadyTableAdapter = Nothing
        Me.TableAdapterManager.pracivnykyTableAdapter = Me.PracivnykyTableAdapter
        Me.TableAdapterManager.skladTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ComputerServ.BD_PizzeriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.zamovlenniaTableAdapter = Nothing
        '
        'PIBTextBox
        '
        Me.PIBTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.PIBTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PracivnykyBindingSource, "PIB", True))
        Me.PIBTextBox.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.PIBTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.PIBTextBox.Location = New System.Drawing.Point(253, 85)
        Me.PIBTextBox.Name = "PIBTextBox"
        Me.PIBTextBox.Size = New System.Drawing.Size(452, 29)
        Me.PIBTextBox.TabIndex = 3
        '
        'VikTextBox
        '
        Me.VikTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.VikTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PracivnykyBindingSource, "Vik", True))
        Me.VikTextBox.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.VikTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.VikTextBox.Location = New System.Drawing.Point(253, 120)
        Me.VikTextBox.Name = "VikTextBox"
        Me.VikTextBox.Size = New System.Drawing.Size(452, 29)
        Me.VikTextBox.TabIndex = 5
        '
        'AdresaTextBox
        '
        Me.AdresaTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.AdresaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PracivnykyBindingSource, "Adresa", True))
        Me.AdresaTextBox.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.AdresaTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.AdresaTextBox.Location = New System.Drawing.Point(254, 190)
        Me.AdresaTextBox.Name = "AdresaTextBox"
        Me.AdresaTextBox.Size = New System.Drawing.Size(452, 29)
        Me.AdresaTextBox.TabIndex = 9
        '
        'Pasportni_daniTextBox
        '
        Me.Pasportni_daniTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Pasportni_daniTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PracivnykyBindingSource, "Pasportni_dani", True))
        Me.Pasportni_daniTextBox.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Pasportni_daniTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.Pasportni_daniTextBox.Location = New System.Drawing.Point(254, 260)
        Me.Pasportni_daniTextBox.Name = "Pasportni_daniTextBox"
        Me.Pasportni_daniTextBox.Size = New System.Drawing.Size(452, 29)
        Me.Pasportni_daniTextBox.TabIndex = 13
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Button10.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Button10.Location = New System.Drawing.Point(555, 309)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(131, 29)
        Me.Button10.TabIndex = 56
        Me.Button10.Text = "Звіт"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Button9.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Button9.Location = New System.Drawing.Point(418, 396)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(131, 29)
        Me.Button9.TabIndex = 55
        Me.Button9.Text = "Таблиця"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Button8.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Button8.Location = New System.Drawing.Point(418, 367)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(131, 29)
        Me.Button8.TabIndex = 54
        Me.Button8.Text = "Видалити"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Button7.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Button7.Location = New System.Drawing.Point(418, 338)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(131, 29)
        Me.Button7.TabIndex = 53
        Me.Button7.Text = "Остання"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Button6.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Button6.Location = New System.Drawing.Point(418, 309)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(131, 29)
        Me.Button6.TabIndex = 52
        Me.Button6.Text = "Попередня"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Button5.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(187, 367)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(131, 29)
        Me.Button5.TabIndex = 51
        Me.Button5.Text = "Наступна"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(187, 338)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(131, 29)
        Me.Button4.TabIndex = 50
        Me.Button4.Text = "Додати"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(187, 309)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(131, 29)
        Me.Button3.TabIndex = 49
        Me.Button3.Text = "Перша"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(187, 396)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 29)
        Me.Button2.TabIndex = 48
        Me.Button2.Text = "Зберегти"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'StatTextBox
        '
        Me.StatTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.StatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PracivnykyBindingSource, "Stat", True))
        Me.StatTextBox.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold)
        Me.StatTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.StatTextBox.Location = New System.Drawing.Point(254, 157)
        Me.StatTextBox.Name = "StatTextBox"
        Me.StatTextBox.Size = New System.Drawing.Size(452, 29)
        Me.StatTextBox.TabIndex = 63
        '
        'ID_posadyComboBox
        '
        Me.ID_posadyComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.ID_posadyComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PracivnykyBindingSource, "ID_posady", True))
        Me.ID_posadyComboBox.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold)
        Me.ID_posadyComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.ID_posadyComboBox.FormattingEnabled = True
        Me.ID_posadyComboBox.Location = New System.Drawing.Point(254, 47)
        Me.ID_posadyComboBox.Name = "ID_posadyComboBox"
        Me.ID_posadyComboBox.Size = New System.Drawing.Size(452, 31)
        Me.ID_posadyComboBox.TabIndex = 64
        '
        'IDComboBox
        '
        Me.IDComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.IDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PracivnykyBindingSource, "ID", True))
        Me.IDComboBox.DataSource = Me.PracivnykyBindingSource
        Me.IDComboBox.DisplayMember = "ID"
        Me.IDComboBox.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold)
        Me.IDComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.IDComboBox.FormattingEnabled = True
        Me.IDComboBox.Location = New System.Drawing.Point(254, 10)
        Me.IDComboBox.Name = "IDComboBox"
        Me.IDComboBox.Size = New System.Drawing.Size(452, 31)
        Me.IDComboBox.TabIndex = 65
        '
        'TelefonMaskedTextBox
        '
        Me.TelefonMaskedTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.TelefonMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PracivnykyBindingSource, "Telefon", True))
        Me.TelefonMaskedTextBox.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold)
        Me.TelefonMaskedTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.TelefonMaskedTextBox.Location = New System.Drawing.Point(254, 225)
        Me.TelefonMaskedTextBox.Mask = "+38(000)00-00-00"
        Me.TelefonMaskedTextBox.Name = "TelefonMaskedTextBox"
        Me.TelefonMaskedTextBox.Size = New System.Drawing.Size(451, 29)
        Me.TelefonMaskedTextBox.TabIndex = 67
        '
        'Workers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(910, 450)
        Me.Controls.Add(Me.TelefonMaskedTextBox)
        Me.Controls.Add(Me.IDComboBox)
        Me.Controls.Add(Me.ID_posadyComboBox)
        Me.Controls.Add(Me.StatTextBox)
        Me.Controls.Add(Label1)
        Me.Controls.Add(StatLabel)
        Me.Controls.Add(ID_posadyLabel)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Pasportni_daniLabel)
        Me.Controls.Add(Me.Pasportni_daniTextBox)
        Me.Controls.Add(TelefonLabel)
        Me.Controls.Add(AdresaLabel)
        Me.Controls.Add(Me.AdresaTextBox)
        Me.Controls.Add(VikLabel)
        Me.Controls.Add(Me.VikTextBox)
        Me.Controls.Add(PIBLabel)
        Me.Controls.Add(Me.PIBTextBox)
        Me.Controls.Add(Me.Button1)
        Me.DoubleBuffered = True
        Me.Name = "Workers"
        Me.Text = "Працівники"
        CType(Me.BD_PizzeriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PracivnykyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents BD_PizzeriaDataSet As BD_PizzeriaDataSet
    Friend WithEvents PracivnykyBindingSource As BindingSource
    Friend WithEvents PracivnykyTableAdapter As BD_PizzeriaDataSetTableAdapters.pracivnykyTableAdapter
    Friend WithEvents TableAdapterManager As BD_PizzeriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PIBTextBox As TextBox
    Friend WithEvents VikTextBox As TextBox
    Friend WithEvents AdresaTextBox As TextBox
    Friend WithEvents Pasportni_daniTextBox As TextBox
    Friend WithEvents Button10 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents StatTextBox As TextBox
    Friend WithEvents ID_posadyComboBox As ComboBox
    Friend WithEvents IDComboBox As ComboBox
    Friend WithEvents TelefonMaskedTextBox As MaskedTextBox
End Class
