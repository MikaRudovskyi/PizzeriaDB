<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Orders
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
        Dim PIB_zamovnykaLabel As System.Windows.Forms.Label
        Dim TelefonLabel As System.Windows.Forms.Label
        Dim ID_stravy_1Label As System.Windows.Forms.Label
        Dim ID_stravy_2Label As System.Windows.Forms.Label
        Dim ID_stravy_3Label As System.Windows.Forms.Label
        Dim VartistLabel As System.Windows.Forms.Label
        Dim Done_or_noLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Orders))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BD_PizzeriaDataSet = New ComputerServ.BD_PizzeriaDataSet()
        Me.ZamovlenniaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ZamovlenniaTableAdapter = New ComputerServ.BD_PizzeriaDataSetTableAdapters.zamovlenniaTableAdapter()
        Me.TableAdapterManager = New ComputerServ.BD_PizzeriaDataSetTableAdapters.TableAdapterManager()
        Me.PIB_zamovnykaTextBox = New System.Windows.Forms.TextBox()
        Me.ID_stravy_1TextBox = New System.Windows.Forms.TextBox()
        Me.ID_stravy_2TextBox = New System.Windows.Forms.TextBox()
        Me.ID_stravy_3TextBox = New System.Windows.Forms.TextBox()
        Me.VartistTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.ID_spivrobitnykaComboBox = New System.Windows.Forms.ComboBox()
        Me.DataDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TimeTextBox = New System.Windows.Forms.TextBox()
        Me.Done_or_noTextBox = New System.Windows.Forms.TextBox()
        PIB_zamovnykaLabel = New System.Windows.Forms.Label()
        TelefonLabel = New System.Windows.Forms.Label()
        ID_stravy_1Label = New System.Windows.Forms.Label()
        ID_stravy_2Label = New System.Windows.Forms.Label()
        ID_stravy_3Label = New System.Windows.Forms.Label()
        VartistLabel = New System.Windows.Forms.Label()
        Done_or_noLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.BD_PizzeriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZamovlenniaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PIB_zamovnykaLabel
        '
        PIB_zamovnykaLabel.AutoSize = True
        PIB_zamovnykaLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(49, Byte), Integer))
        PIB_zamovnykaLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        PIB_zamovnykaLabel.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        PIB_zamovnykaLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(72, Byte), Integer))
        PIB_zamovnykaLabel.Location = New System.Drawing.Point(129, 95)
        PIB_zamovnykaLabel.Name = "PIB_zamovnykaLabel"
        PIB_zamovnykaLabel.Size = New System.Drawing.Size(168, 27)
        PIB_zamovnykaLabel.TabIndex = 6
        PIB_zamovnykaLabel.Text = "ПІБ Замовника"
        '
        'TelefonLabel
        '
        TelefonLabel.AutoSize = True
        TelefonLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(49, Byte), Integer))
        TelefonLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        TelefonLabel.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        TelefonLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(72, Byte), Integer))
        TelefonLabel.Location = New System.Drawing.Point(87, 131)
        TelefonLabel.Name = "TelefonLabel"
        TelefonLabel.Size = New System.Drawing.Size(210, 27)
        TelefonLabel.TabIndex = 8
        TelefonLabel.Text = "Телефон замовника"
        '
        'ID_stravy_1Label
        '
        ID_stravy_1Label.AutoSize = True
        ID_stravy_1Label.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(49, Byte), Integer))
        ID_stravy_1Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        ID_stravy_1Label.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        ID_stravy_1Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(72, Byte), Integer))
        ID_stravy_1Label.Location = New System.Drawing.Point(152, 169)
        ID_stravy_1Label.Name = "ID_stravy_1Label"
        ID_stravy_1Label.Size = New System.Drawing.Size(145, 27)
        ID_stravy_1Label.TabIndex = 10
        ID_stravy_1Label.Text = "Код страви 1"
        '
        'ID_stravy_2Label
        '
        ID_stravy_2Label.AutoSize = True
        ID_stravy_2Label.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(49, Byte), Integer))
        ID_stravy_2Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        ID_stravy_2Label.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        ID_stravy_2Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(72, Byte), Integer))
        ID_stravy_2Label.Location = New System.Drawing.Point(149, 205)
        ID_stravy_2Label.Name = "ID_stravy_2Label"
        ID_stravy_2Label.Size = New System.Drawing.Size(148, 27)
        ID_stravy_2Label.TabIndex = 12
        ID_stravy_2Label.Text = "Код страви 2"
        '
        'ID_stravy_3Label
        '
        ID_stravy_3Label.AutoSize = True
        ID_stravy_3Label.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(49, Byte), Integer))
        ID_stravy_3Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        ID_stravy_3Label.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        ID_stravy_3Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(72, Byte), Integer))
        ID_stravy_3Label.Location = New System.Drawing.Point(149, 241)
        ID_stravy_3Label.Name = "ID_stravy_3Label"
        ID_stravy_3Label.Size = New System.Drawing.Size(148, 27)
        ID_stravy_3Label.TabIndex = 14
        ID_stravy_3Label.Text = "Код страви 3"
        '
        'VartistLabel
        '
        VartistLabel.AutoSize = True
        VartistLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(49, Byte), Integer))
        VartistLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        VartistLabel.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        VartistLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(72, Byte), Integer))
        VartistLabel.Location = New System.Drawing.Point(66, 277)
        VartistLabel.Name = "VartistLabel"
        VartistLabel.Size = New System.Drawing.Size(231, 27)
        VartistLabel.TabIndex = 16
        VartistLabel.Text = "Виконане/невиконане"
        '
        'Done_or_noLabel
        '
        Done_or_noLabel.AutoSize = True
        Done_or_noLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(49, Byte), Integer))
        Done_or_noLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Done_or_noLabel.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Done_or_noLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(72, Byte), Integer))
        Done_or_noLabel.Location = New System.Drawing.Point(217, 355)
        Done_or_noLabel.Name = "Done_or_noLabel"
        Done_or_noLabel.Size = New System.Drawing.Size(80, 27)
        Done_or_noLabel.TabIndex = 18
        Done_or_noLabel.Text = "Всього"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(49, Byte), Integer))
        Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label1.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(72, Byte), Integer))
        Label1.Location = New System.Drawing.Point(97, 316)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(200, 27)
        Label1.TabIndex = 32
        Label1.Text = "Код співробітника"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(49, Byte), Integer))
        Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label2.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(72, Byte), Integer))
        Label2.Location = New System.Drawing.Point(226, 24)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(71, 27)
        Label2.TabIndex = 34
        Label2.Text = "Дата"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(49, Byte), Integer))
        Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label3.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(72, Byte), Integer))
        Label3.Location = New System.Drawing.Point(245, 58)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(52, 27)
        Label3.TabIndex = 35
        Label3.Text = "Час"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(700, 12)
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
        'ZamovlenniaBindingSource
        '
        Me.ZamovlenniaBindingSource.DataMember = "zamovlennia"
        Me.ZamovlenniaBindingSource.DataSource = Me.BD_PizzeriaDataSet
        '
        'ZamovlenniaTableAdapter
        '
        Me.ZamovlenniaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.menuTableAdapter = Nothing
        Me.TableAdapterManager.posadyTableAdapter = Nothing
        Me.TableAdapterManager.pracivnykyTableAdapter = Nothing
        Me.TableAdapterManager.skladTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ComputerServ.BD_PizzeriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.zamovlenniaTableAdapter = Me.ZamovlenniaTableAdapter
        '
        'PIB_zamovnykaTextBox
        '
        Me.PIB_zamovnykaTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.PIB_zamovnykaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZamovlenniaBindingSource, "PIB_zamovnyka", True))
        Me.PIB_zamovnykaTextBox.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.PIB_zamovnykaTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.PIB_zamovnykaTextBox.Location = New System.Drawing.Point(303, 93)
        Me.PIB_zamovnykaTextBox.Name = "PIB_zamovnykaTextBox"
        Me.PIB_zamovnykaTextBox.Size = New System.Drawing.Size(373, 29)
        Me.PIB_zamovnykaTextBox.TabIndex = 7
        '
        'ID_stravy_1TextBox
        '
        Me.ID_stravy_1TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.ID_stravy_1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZamovlenniaBindingSource, "ID_stravy_1", True))
        Me.ID_stravy_1TextBox.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ID_stravy_1TextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ID_stravy_1TextBox.Location = New System.Drawing.Point(303, 167)
        Me.ID_stravy_1TextBox.Name = "ID_stravy_1TextBox"
        Me.ID_stravy_1TextBox.Size = New System.Drawing.Size(373, 29)
        Me.ID_stravy_1TextBox.TabIndex = 11
        '
        'ID_stravy_2TextBox
        '
        Me.ID_stravy_2TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.ID_stravy_2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZamovlenniaBindingSource, "ID_stravy_2", True))
        Me.ID_stravy_2TextBox.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ID_stravy_2TextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ID_stravy_2TextBox.Location = New System.Drawing.Point(303, 203)
        Me.ID_stravy_2TextBox.Name = "ID_stravy_2TextBox"
        Me.ID_stravy_2TextBox.Size = New System.Drawing.Size(373, 29)
        Me.ID_stravy_2TextBox.TabIndex = 13
        '
        'ID_stravy_3TextBox
        '
        Me.ID_stravy_3TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.ID_stravy_3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZamovlenniaBindingSource, "ID_stravy_3", True))
        Me.ID_stravy_3TextBox.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ID_stravy_3TextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ID_stravy_3TextBox.Location = New System.Drawing.Point(303, 239)
        Me.ID_stravy_3TextBox.Name = "ID_stravy_3TextBox"
        Me.ID_stravy_3TextBox.Size = New System.Drawing.Size(373, 29)
        Me.ID_stravy_3TextBox.TabIndex = 15
        '
        'VartistTextBox
        '
        Me.VartistTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.VartistTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZamovlenniaBindingSource, "Vartist", True))
        Me.VartistTextBox.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.VartistTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.VartistTextBox.Location = New System.Drawing.Point(303, 353)
        Me.VartistTextBox.Name = "VartistTextBox"
        Me.VartistTextBox.Size = New System.Drawing.Size(373, 29)
        Me.VartistTextBox.TabIndex = 17
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(212, 499)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 23)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Зберегти"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(212, 412)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 23)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Перша"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(212, 441)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(104, 23)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "Додати"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Button5.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(212, 470)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(104, 23)
        Me.Button5.TabIndex = 23
        Me.Button5.Text = "Наступна"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Button6.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Button6.Location = New System.Drawing.Point(443, 412)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(104, 23)
        Me.Button6.TabIndex = 24
        Me.Button6.Text = "Попередня"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Button7.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Button7.Location = New System.Drawing.Point(443, 441)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(104, 23)
        Me.Button7.TabIndex = 25
        Me.Button7.Text = "Остання"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Button8.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Button8.Location = New System.Drawing.Point(443, 470)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(104, 23)
        Me.Button8.TabIndex = 26
        Me.Button8.Text = "Видалити"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZamovlenniaBindingSource, "Telefon", True))
        Me.MaskedTextBox1.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold)
        Me.MaskedTextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(303, 131)
        Me.MaskedTextBox1.Mask = "+38(000)00-00-00"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(373, 29)
        Me.MaskedTextBox1.TabIndex = 27
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Button9.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Button9.Location = New System.Drawing.Point(443, 499)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(104, 23)
        Me.Button9.TabIndex = 28
        Me.Button9.Text = "Таблиця"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Button10.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Button10.Location = New System.Drawing.Point(553, 412)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(104, 23)
        Me.Button10.TabIndex = 29
        Me.Button10.Text = "Звіт"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'ID_spivrobitnykaComboBox
        '
        Me.ID_spivrobitnykaComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.ID_spivrobitnykaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZamovlenniaBindingSource, "ID_spivrobitnyka", True))
        Me.ID_spivrobitnykaComboBox.DataSource = Me.ZamovlenniaBindingSource
        Me.ID_spivrobitnykaComboBox.DisplayMember = "ID_spivrobitnyka"
        Me.ID_spivrobitnykaComboBox.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold)
        Me.ID_spivrobitnykaComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ID_spivrobitnykaComboBox.FormattingEnabled = True
        Me.ID_spivrobitnykaComboBox.Location = New System.Drawing.Point(303, 314)
        Me.ID_spivrobitnykaComboBox.Name = "ID_spivrobitnykaComboBox"
        Me.ID_spivrobitnykaComboBox.Size = New System.Drawing.Size(373, 31)
        Me.ID_spivrobitnykaComboBox.TabIndex = 30
        '
        'DataDateTimePicker
        '
        Me.DataDateTimePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.DataDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ZamovlenniaBindingSource, "Data", True))
        Me.DataDateTimePicker.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold)
        Me.DataDateTimePicker.Location = New System.Drawing.Point(303, 24)
        Me.DataDateTimePicker.Name = "DataDateTimePicker"
        Me.DataDateTimePicker.Size = New System.Drawing.Size(373, 29)
        Me.DataDateTimePicker.TabIndex = 33
        '
        'TimeTextBox
        '
        Me.TimeTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.TimeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZamovlenniaBindingSource, "Time", True))
        Me.TimeTextBox.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold)
        Me.TimeTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.TimeTextBox.Location = New System.Drawing.Point(303, 58)
        Me.TimeTextBox.Name = "TimeTextBox"
        Me.TimeTextBox.Size = New System.Drawing.Size(373, 29)
        Me.TimeTextBox.TabIndex = 36
        '
        'Done_or_noTextBox
        '
        Me.Done_or_noTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Done_or_noTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZamovlenniaBindingSource, "Done_or_no", True))
        Me.Done_or_noTextBox.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Done_or_noTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Done_or_noTextBox.Location = New System.Drawing.Point(303, 275)
        Me.Done_or_noTextBox.Name = "Done_or_noTextBox"
        Me.Done_or_noTextBox.Size = New System.Drawing.Size(373, 29)
        Me.Done_or_noTextBox.TabIndex = 37
        '
        'Orders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(824, 542)
        Me.Controls.Add(Me.Done_or_noTextBox)
        Me.Controls.Add(Me.TimeTextBox)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.DataDateTimePicker)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.ID_spivrobitnykaComboBox)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Done_or_noLabel)
        Me.Controls.Add(VartistLabel)
        Me.Controls.Add(Me.VartistTextBox)
        Me.Controls.Add(ID_stravy_3Label)
        Me.Controls.Add(Me.ID_stravy_3TextBox)
        Me.Controls.Add(ID_stravy_2Label)
        Me.Controls.Add(Me.ID_stravy_2TextBox)
        Me.Controls.Add(ID_stravy_1Label)
        Me.Controls.Add(Me.ID_stravy_1TextBox)
        Me.Controls.Add(TelefonLabel)
        Me.Controls.Add(PIB_zamovnykaLabel)
        Me.Controls.Add(Me.PIB_zamovnykaTextBox)
        Me.Controls.Add(Me.Button1)
        Me.DoubleBuffered = True
        Me.Name = "Orders"
        Me.Text = "Замовлення"
        CType(Me.BD_PizzeriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZamovlenniaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents BD_PizzeriaDataSet As BD_PizzeriaDataSet
    Friend WithEvents ZamovlenniaBindingSource As BindingSource
    Friend WithEvents ZamovlenniaTableAdapter As BD_PizzeriaDataSetTableAdapters.zamovlenniaTableAdapter
    Friend WithEvents TableAdapterManager As BD_PizzeriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PIB_zamovnykaTextBox As TextBox
    Friend WithEvents ID_stravy_1TextBox As TextBox
    Friend WithEvents ID_stravy_2TextBox As TextBox
    Friend WithEvents ID_stravy_3TextBox As TextBox
    Friend WithEvents VartistTextBox As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents ID_spivrobitnykaComboBox As ComboBox
    Friend WithEvents DataDateTimePicker As DateTimePicker
    Friend WithEvents TimeTextBox As TextBox
    Friend WithEvents Done_or_noTextBox As TextBox
End Class
