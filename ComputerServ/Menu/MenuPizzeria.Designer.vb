<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPizzeria
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
        Dim Name_stravyLabel As System.Windows.Forms.Label
        Dim VartistLabel As System.Windows.Forms.Label
        Dim Time_prygotuvanniaLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim ID_ingridienta_1Label As System.Windows.Forms.Label
        Dim Obiem_ingridienta_1Label As System.Windows.Forms.Label
        Dim ID_ingridienta_2Label As System.Windows.Forms.Label
        Dim Obiem_ingridienta_2Label As System.Windows.Forms.Label
        Dim ID_ingridienta_3Label As System.Windows.Forms.Label
        Dim Obiem_ingridienta_3Label As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPizzeria))
        Me.BD_PizzeriaDataSet = New ComputerServ.BD_PizzeriaDataSet()
        Me.MenuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuTableAdapter = New ComputerServ.BD_PizzeriaDataSetTableAdapters.menuTableAdapter()
        Me.TableAdapterManager = New ComputerServ.BD_PizzeriaDataSetTableAdapters.TableAdapterManager()
        Me.Name_stravyTextBox = New System.Windows.Forms.TextBox()
        Me.VartistTextBox = New System.Windows.Forms.TextBox()
        Me.Time_prygotuvanniaTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ID_stravyComboBox = New System.Windows.Forms.ComboBox()
        Me.ID_ingridienta_1TextBox = New System.Windows.Forms.TextBox()
        Me.Obiem_ingridienta_1TextBox = New System.Windows.Forms.TextBox()
        Me.ID_ingridienta_2TextBox = New System.Windows.Forms.TextBox()
        Me.Obiem_ingridienta_2TextBox = New System.Windows.Forms.TextBox()
        Me.ID_ingridienta_3TextBox = New System.Windows.Forms.TextBox()
        Me.Obiem_ingridienta_3TextBox = New System.Windows.Forms.TextBox()
        Name_stravyLabel = New System.Windows.Forms.Label()
        VartistLabel = New System.Windows.Forms.Label()
        Time_prygotuvanniaLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        ID_ingridienta_1Label = New System.Windows.Forms.Label()
        Obiem_ingridienta_1Label = New System.Windows.Forms.Label()
        ID_ingridienta_2Label = New System.Windows.Forms.Label()
        Obiem_ingridienta_2Label = New System.Windows.Forms.Label()
        ID_ingridienta_3Label = New System.Windows.Forms.Label()
        Obiem_ingridienta_3Label = New System.Windows.Forms.Label()
        CType(Me.BD_PizzeriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Name_stravyLabel
        '
        Name_stravyLabel.AutoSize = True
        Name_stravyLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(29, Byte), Integer))
        Name_stravyLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Name_stravyLabel.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold)
        Name_stravyLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(49, Byte), Integer))
        Name_stravyLabel.Location = New System.Drawing.Point(106, 67)
        Name_stravyLabel.Name = "Name_stravyLabel"
        Name_stravyLabel.Size = New System.Drawing.Size(165, 27)
        Name_stravyLabel.TabIndex = 2
        Name_stravyLabel.Text = "Назва страви"
        AddHandler Name_stravyLabel.Click, AddressOf Me.Name_stravyLabel_Click
        '
        'VartistLabel
        '
        VartistLabel.AutoSize = True
        VartistLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(29, Byte), Integer))
        VartistLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        VartistLabel.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold)
        VartistLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(49, Byte), Integer))
        VartistLabel.Location = New System.Drawing.Point(162, 301)
        VartistLabel.Name = "VartistLabel"
        VartistLabel.Size = New System.Drawing.Size(109, 27)
        VartistLabel.TabIndex = 4
        VartistLabel.Text = "Вартість"
        AddHandler VartistLabel.Click, AddressOf Me.VartistLabel_Click
        '
        'Time_prygotuvanniaLabel
        '
        Time_prygotuvanniaLabel.AutoSize = True
        Time_prygotuvanniaLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(29, Byte), Integer))
        Time_prygotuvanniaLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Time_prygotuvanniaLabel.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Time_prygotuvanniaLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(49, Byte), Integer))
        Time_prygotuvanniaLabel.Location = New System.Drawing.Point(51, 339)
        Time_prygotuvanniaLabel.Name = "Time_prygotuvanniaLabel"
        Time_prygotuvanniaLabel.Size = New System.Drawing.Size(220, 27)
        Time_prygotuvanniaLabel.TabIndex = 6
        Time_prygotuvanniaLabel.Text = "Час приготування"
        AddHandler Time_prygotuvanniaLabel.Click, AddressOf Me.Time_prygotuvanniaLabel_Click
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(29, Byte), Integer))
        Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label1.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold)
        Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(49, Byte), Integer))
        Label1.Location = New System.Drawing.Point(132, 33)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(139, 27)
        Label1.TabIndex = 40
        Label1.Text = "Код страви"
        AddHandler Label1.Click, AddressOf Me.Label1_Click_1
        '
        'ID_ingridienta_1Label
        '
        ID_ingridienta_1Label.AutoSize = True
        ID_ingridienta_1Label.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(29, Byte), Integer))
        ID_ingridienta_1Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        ID_ingridienta_1Label.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold)
        ID_ingridienta_1Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(49, Byte), Integer))
        ID_ingridienta_1Label.Location = New System.Drawing.Point(70, 101)
        ID_ingridienta_1Label.Name = "ID_ingridienta_1Label"
        ID_ingridienta_1Label.Size = New System.Drawing.Size(201, 27)
        ID_ingridienta_1Label.TabIndex = 40
        ID_ingridienta_1Label.Text = "Код інгрідієнта 1"
        '
        'Obiem_ingridienta_1Label
        '
        Obiem_ingridienta_1Label.AutoSize = True
        Obiem_ingridienta_1Label.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(29, Byte), Integer))
        Obiem_ingridienta_1Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Obiem_ingridienta_1Label.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold)
        Obiem_ingridienta_1Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(49, Byte), Integer))
        Obiem_ingridienta_1Label.Location = New System.Drawing.Point(48, 134)
        Obiem_ingridienta_1Label.Name = "Obiem_ingridienta_1Label"
        Obiem_ingridienta_1Label.Size = New System.Drawing.Size(223, 27)
        Obiem_ingridienta_1Label.TabIndex = 41
        Obiem_ingridienta_1Label.Text = "Об'єм інгрідієнта 1"
        '
        'ID_ingridienta_2Label
        '
        ID_ingridienta_2Label.AutoSize = True
        ID_ingridienta_2Label.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(29, Byte), Integer))
        ID_ingridienta_2Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        ID_ingridienta_2Label.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold)
        ID_ingridienta_2Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(49, Byte), Integer))
        ID_ingridienta_2Label.Location = New System.Drawing.Point(67, 168)
        ID_ingridienta_2Label.Name = "ID_ingridienta_2Label"
        ID_ingridienta_2Label.Size = New System.Drawing.Size(204, 27)
        ID_ingridienta_2Label.TabIndex = 42
        ID_ingridienta_2Label.Text = "Код інгрідієнта 2"
        '
        'Obiem_ingridienta_2Label
        '
        Obiem_ingridienta_2Label.AutoSize = True
        Obiem_ingridienta_2Label.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(29, Byte), Integer))
        Obiem_ingridienta_2Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Obiem_ingridienta_2Label.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold)
        Obiem_ingridienta_2Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(49, Byte), Integer))
        Obiem_ingridienta_2Label.Location = New System.Drawing.Point(45, 200)
        Obiem_ingridienta_2Label.Name = "Obiem_ingridienta_2Label"
        Obiem_ingridienta_2Label.Size = New System.Drawing.Size(226, 27)
        Obiem_ingridienta_2Label.TabIndex = 43
        Obiem_ingridienta_2Label.Text = "Об'єм інгрідієнта 2"
        '
        'ID_ingridienta_3Label
        '
        ID_ingridienta_3Label.AutoSize = True
        ID_ingridienta_3Label.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(29, Byte), Integer))
        ID_ingridienta_3Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        ID_ingridienta_3Label.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold)
        ID_ingridienta_3Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(49, Byte), Integer))
        ID_ingridienta_3Label.Location = New System.Drawing.Point(67, 233)
        ID_ingridienta_3Label.Name = "ID_ingridienta_3Label"
        ID_ingridienta_3Label.Size = New System.Drawing.Size(204, 27)
        ID_ingridienta_3Label.TabIndex = 44
        ID_ingridienta_3Label.Text = "Код інгрідієнта 3"
        '
        'Obiem_ingridienta_3Label
        '
        Obiem_ingridienta_3Label.AutoSize = True
        Obiem_ingridienta_3Label.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(29, Byte), Integer))
        Obiem_ingridienta_3Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Obiem_ingridienta_3Label.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold)
        Obiem_ingridienta_3Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(49, Byte), Integer))
        Obiem_ingridienta_3Label.Location = New System.Drawing.Point(45, 266)
        Obiem_ingridienta_3Label.Name = "Obiem_ingridienta_3Label"
        Obiem_ingridienta_3Label.Size = New System.Drawing.Size(226, 27)
        Obiem_ingridienta_3Label.TabIndex = 45
        Obiem_ingridienta_3Label.Text = "Об'єм інгрідієнта 3"
        '
        'BD_PizzeriaDataSet
        '
        Me.BD_PizzeriaDataSet.DataSetName = "BD_PizzeriaDataSet"
        Me.BD_PizzeriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MenuBindingSource
        '
        Me.MenuBindingSource.DataMember = "menu"
        Me.MenuBindingSource.DataSource = Me.BD_PizzeriaDataSet
        '
        'MenuTableAdapter
        '
        Me.MenuTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.menuTableAdapter = Me.MenuTableAdapter
        Me.TableAdapterManager.posadyTableAdapter = Nothing
        Me.TableAdapterManager.pracivnykyTableAdapter = Nothing
        Me.TableAdapterManager.skladTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ComputerServ.BD_PizzeriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.zamovlenniaTableAdapter = Nothing
        '
        'Name_stravyTextBox
        '
        Me.Name_stravyTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Name_stravyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenuBindingSource, "Name_stravy", True))
        Me.Name_stravyTextBox.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Name_stravyTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Name_stravyTextBox.Location = New System.Drawing.Point(277, 67)
        Me.Name_stravyTextBox.Name = "Name_stravyTextBox"
        Me.Name_stravyTextBox.Size = New System.Drawing.Size(381, 29)
        Me.Name_stravyTextBox.TabIndex = 3
        '
        'VartistTextBox
        '
        Me.VartistTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.VartistTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenuBindingSource, "Vartist", True))
        Me.VartistTextBox.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold)
        Me.VartistTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.VartistTextBox.Location = New System.Drawing.Point(277, 301)
        Me.VartistTextBox.Name = "VartistTextBox"
        Me.VartistTextBox.Size = New System.Drawing.Size(381, 29)
        Me.VartistTextBox.TabIndex = 5
        '
        'Time_prygotuvanniaTextBox
        '
        Me.Time_prygotuvanniaTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Time_prygotuvanniaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenuBindingSource, "Time_prygotuvannia", True))
        Me.Time_prygotuvanniaTextBox.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Time_prygotuvanniaTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Time_prygotuvanniaTextBox.Location = New System.Drawing.Point(277, 339)
        Me.Time_prygotuvanniaTextBox.Name = "Time_prygotuvanniaTextBox"
        Me.Time_prygotuvanniaTextBox.Size = New System.Drawing.Size(381, 29)
        Me.Time_prygotuvanniaTextBox.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(710, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Повернутись"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Button10.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Button10.Location = New System.Drawing.Point(508, 412)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(119, 27)
        Me.Button10.TabIndex = 38
        Me.Button10.Text = "Звіт"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Button9.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Button9.Location = New System.Drawing.Point(383, 499)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(119, 27)
        Me.Button9.TabIndex = 37
        Me.Button9.Text = "Таблиця"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Button8.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Button8.Location = New System.Drawing.Point(383, 470)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(119, 27)
        Me.Button8.TabIndex = 36
        Me.Button8.Text = "Видалити"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Button7.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Button7.Location = New System.Drawing.Point(383, 441)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(119, 27)
        Me.Button7.TabIndex = 35
        Me.Button7.Text = "Остання"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Button6.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Button6.Location = New System.Drawing.Point(383, 412)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(119, 27)
        Me.Button6.TabIndex = 34
        Me.Button6.Text = "Попередня"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Button5.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(152, 470)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(119, 27)
        Me.Button5.TabIndex = 33
        Me.Button5.Text = "Наступна"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(152, 441)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(119, 27)
        Me.Button4.TabIndex = 32
        Me.Button4.Text = "Додати"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(152, 412)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(119, 27)
        Me.Button3.TabIndex = 31
        Me.Button3.Text = "Перша"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(152, 499)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(119, 27)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "Зберегти"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ID_stravyComboBox
        '
        Me.ID_stravyComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ID_stravyComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenuBindingSource, "ID_stravy", True))
        Me.ID_stravyComboBox.DataSource = Me.MenuBindingSource
        Me.ID_stravyComboBox.DisplayMember = "ID_stravy"
        Me.ID_stravyComboBox.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold)
        Me.ID_stravyComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.ID_stravyComboBox.FormattingEnabled = True
        Me.ID_stravyComboBox.Location = New System.Drawing.Point(277, 31)
        Me.ID_stravyComboBox.Name = "ID_stravyComboBox"
        Me.ID_stravyComboBox.Size = New System.Drawing.Size(381, 31)
        Me.ID_stravyComboBox.TabIndex = 39
        '
        'ID_ingridienta_1TextBox
        '
        Me.ID_ingridienta_1TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ID_ingridienta_1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenuBindingSource, "ID_ingridienta_1", True))
        Me.ID_ingridienta_1TextBox.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold)
        Me.ID_ingridienta_1TextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.ID_ingridienta_1TextBox.Location = New System.Drawing.Point(277, 99)
        Me.ID_ingridienta_1TextBox.Name = "ID_ingridienta_1TextBox"
        Me.ID_ingridienta_1TextBox.Size = New System.Drawing.Size(381, 29)
        Me.ID_ingridienta_1TextBox.TabIndex = 41
        '
        'Obiem_ingridienta_1TextBox
        '
        Me.Obiem_ingridienta_1TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Obiem_ingridienta_1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenuBindingSource, "Obiem_ingridienta_1", True))
        Me.Obiem_ingridienta_1TextBox.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Obiem_ingridienta_1TextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Obiem_ingridienta_1TextBox.Location = New System.Drawing.Point(277, 132)
        Me.Obiem_ingridienta_1TextBox.Name = "Obiem_ingridienta_1TextBox"
        Me.Obiem_ingridienta_1TextBox.Size = New System.Drawing.Size(381, 29)
        Me.Obiem_ingridienta_1TextBox.TabIndex = 42
        '
        'ID_ingridienta_2TextBox
        '
        Me.ID_ingridienta_2TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ID_ingridienta_2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenuBindingSource, "ID_ingridienta_2", True))
        Me.ID_ingridienta_2TextBox.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold)
        Me.ID_ingridienta_2TextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.ID_ingridienta_2TextBox.Location = New System.Drawing.Point(277, 166)
        Me.ID_ingridienta_2TextBox.Name = "ID_ingridienta_2TextBox"
        Me.ID_ingridienta_2TextBox.Size = New System.Drawing.Size(381, 29)
        Me.ID_ingridienta_2TextBox.TabIndex = 43
        '
        'Obiem_ingridienta_2TextBox
        '
        Me.Obiem_ingridienta_2TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Obiem_ingridienta_2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenuBindingSource, "Obiem_ingridienta_2", True))
        Me.Obiem_ingridienta_2TextBox.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Obiem_ingridienta_2TextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Obiem_ingridienta_2TextBox.Location = New System.Drawing.Point(277, 200)
        Me.Obiem_ingridienta_2TextBox.Name = "Obiem_ingridienta_2TextBox"
        Me.Obiem_ingridienta_2TextBox.Size = New System.Drawing.Size(381, 29)
        Me.Obiem_ingridienta_2TextBox.TabIndex = 44
        '
        'ID_ingridienta_3TextBox
        '
        Me.ID_ingridienta_3TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ID_ingridienta_3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenuBindingSource, "ID_ingridienta_3", True))
        Me.ID_ingridienta_3TextBox.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold)
        Me.ID_ingridienta_3TextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.ID_ingridienta_3TextBox.Location = New System.Drawing.Point(277, 233)
        Me.ID_ingridienta_3TextBox.Name = "ID_ingridienta_3TextBox"
        Me.ID_ingridienta_3TextBox.Size = New System.Drawing.Size(381, 29)
        Me.ID_ingridienta_3TextBox.TabIndex = 45
        '
        'Obiem_ingridienta_3TextBox
        '
        Me.Obiem_ingridienta_3TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Obiem_ingridienta_3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenuBindingSource, "Obiem_ingridienta_3", True))
        Me.Obiem_ingridienta_3TextBox.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Obiem_ingridienta_3TextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Obiem_ingridienta_3TextBox.Location = New System.Drawing.Point(277, 266)
        Me.Obiem_ingridienta_3TextBox.Name = "Obiem_ingridienta_3TextBox"
        Me.Obiem_ingridienta_3TextBox.Size = New System.Drawing.Size(381, 29)
        Me.Obiem_ingridienta_3TextBox.TabIndex = 46
        '
        'MenuPizzeria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(825, 546)
        Me.Controls.Add(Obiem_ingridienta_3Label)
        Me.Controls.Add(Me.Obiem_ingridienta_3TextBox)
        Me.Controls.Add(ID_ingridienta_3Label)
        Me.Controls.Add(Me.ID_ingridienta_3TextBox)
        Me.Controls.Add(Obiem_ingridienta_2Label)
        Me.Controls.Add(Me.Obiem_ingridienta_2TextBox)
        Me.Controls.Add(ID_ingridienta_2Label)
        Me.Controls.Add(Me.ID_ingridienta_2TextBox)
        Me.Controls.Add(Obiem_ingridienta_1Label)
        Me.Controls.Add(Me.Obiem_ingridienta_1TextBox)
        Me.Controls.Add(ID_ingridienta_1Label)
        Me.Controls.Add(Me.ID_ingridienta_1TextBox)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.ID_stravyComboBox)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Time_prygotuvanniaLabel)
        Me.Controls.Add(Me.Time_prygotuvanniaTextBox)
        Me.Controls.Add(VartistLabel)
        Me.Controls.Add(Me.VartistTextBox)
        Me.Controls.Add(Name_stravyLabel)
        Me.Controls.Add(Me.Name_stravyTextBox)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.Name = "MenuPizzeria"
        Me.Text = "Меню"
        CType(Me.BD_PizzeriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BD_PizzeriaDataSet As BD_PizzeriaDataSet
    Friend WithEvents MenuBindingSource As BindingSource
    Friend WithEvents MenuTableAdapter As BD_PizzeriaDataSetTableAdapters.menuTableAdapter
    Friend WithEvents TableAdapterManager As BD_PizzeriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Name_stravyTextBox As TextBox
    Friend WithEvents VartistTextBox As TextBox
    Friend WithEvents Time_prygotuvanniaTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ID_stravyComboBox As ComboBox
    Friend WithEvents ID_ingridienta_1TextBox As TextBox
    Friend WithEvents Obiem_ingridienta_1TextBox As TextBox
    Friend WithEvents ID_ingridienta_2TextBox As TextBox
    Friend WithEvents Obiem_ingridienta_2TextBox As TextBox
    Friend WithEvents ID_ingridienta_3TextBox As TextBox
    Friend WithEvents Obiem_ingridienta_3TextBox As TextBox
End Class
