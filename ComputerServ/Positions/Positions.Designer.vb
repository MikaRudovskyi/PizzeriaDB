<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Positions
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
        Dim Name_posadyLabel As System.Windows.Forms.Label
        Dim OkladLabel As System.Windows.Forms.Label
        Dim OboviazkyLabel As System.Windows.Forms.Label
        Dim VymogyLabel As System.Windows.Forms.Label
        Dim ID_posadyLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Positions))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BD_PizzeriaDataSet = New ComputerServ.BD_PizzeriaDataSet()
        Me.PosadyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PosadyTableAdapter = New ComputerServ.BD_PizzeriaDataSetTableAdapters.posadyTableAdapter()
        Me.TableAdapterManager = New ComputerServ.BD_PizzeriaDataSetTableAdapters.TableAdapterManager()
        Me.Name_posadyTextBox = New System.Windows.Forms.TextBox()
        Me.OkladTextBox = New System.Windows.Forms.TextBox()
        Me.OboviazkyTextBox = New System.Windows.Forms.TextBox()
        Me.VymogyTextBox = New System.Windows.Forms.TextBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ID_posadyComboBox = New System.Windows.Forms.ComboBox()
        Name_posadyLabel = New System.Windows.Forms.Label()
        OkladLabel = New System.Windows.Forms.Label()
        OboviazkyLabel = New System.Windows.Forms.Label()
        VymogyLabel = New System.Windows.Forms.Label()
        ID_posadyLabel = New System.Windows.Forms.Label()
        CType(Me.BD_PizzeriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PosadyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Name_posadyLabel
        '
        Name_posadyLabel.AutoSize = True
        Name_posadyLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(108, Byte), Integer))
        Name_posadyLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Name_posadyLabel.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Italic)
        Name_posadyLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(160, Byte), Integer))
        Name_posadyLabel.Location = New System.Drawing.Point(6, 88)
        Name_posadyLabel.Name = "Name_posadyLabel"
        Name_posadyLabel.Size = New System.Drawing.Size(149, 27)
        Name_posadyLabel.TabIndex = 4
        Name_posadyLabel.Text = "Назва посади"
        '
        'OkladLabel
        '
        OkladLabel.AutoSize = True
        OkladLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(108, Byte), Integer))
        OkladLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        OkladLabel.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Italic)
        OkladLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(160, Byte), Integer))
        OkladLabel.Location = New System.Drawing.Point(80, 123)
        OkladLabel.Name = "OkladLabel"
        OkladLabel.Size = New System.Drawing.Size(75, 27)
        OkladLabel.TabIndex = 6
        OkladLabel.Text = "Оклад"
        '
        'OboviazkyLabel
        '
        OboviazkyLabel.AutoSize = True
        OboviazkyLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(108, Byte), Integer))
        OboviazkyLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        OboviazkyLabel.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Italic)
        OboviazkyLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(160, Byte), Integer))
        OboviazkyLabel.Location = New System.Drawing.Point(44, 192)
        OboviazkyLabel.Name = "OboviazkyLabel"
        OboviazkyLabel.Size = New System.Drawing.Size(111, 27)
        OboviazkyLabel.TabIndex = 8
        OboviazkyLabel.Text = "Обов'язки"
        '
        'VymogyLabel
        '
        VymogyLabel.AutoSize = True
        VymogyLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(108, Byte), Integer))
        VymogyLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        VymogyLabel.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Italic)
        VymogyLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(160, Byte), Integer))
        VymogyLabel.Location = New System.Drawing.Point(66, 157)
        VymogyLabel.Name = "VymogyLabel"
        VymogyLabel.Size = New System.Drawing.Size(89, 27)
        VymogyLabel.TabIndex = 10
        VymogyLabel.Text = "Вимоги"
        '
        'ID_posadyLabel
        '
        ID_posadyLabel.AutoSize = True
        ID_posadyLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(108, Byte), Integer))
        ID_posadyLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        ID_posadyLabel.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Italic)
        ID_posadyLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(160, Byte), Integer))
        ID_posadyLabel.Location = New System.Drawing.Point(31, 51)
        ID_posadyLabel.Name = "ID_posadyLabel"
        ID_posadyLabel.Size = New System.Drawing.Size(124, 27)
        ID_posadyLabel.TabIndex = 2
        ID_posadyLabel.Text = "Код посади"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(660, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Повернутись"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BD_PizzeriaDataSet
        '
        Me.BD_PizzeriaDataSet.DataSetName = "BD_PizzeriaDataSet"
        Me.BD_PizzeriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PosadyBindingSource
        '
        Me.PosadyBindingSource.DataMember = "posady"
        Me.PosadyBindingSource.DataSource = Me.BD_PizzeriaDataSet
        '
        'PosadyTableAdapter
        '
        Me.PosadyTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.menuTableAdapter = Nothing
        Me.TableAdapterManager.posadyTableAdapter = Me.PosadyTableAdapter
        Me.TableAdapterManager.pracivnykyTableAdapter = Nothing
        Me.TableAdapterManager.skladTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ComputerServ.BD_PizzeriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.zamovlenniaTableAdapter = Nothing
        '
        'Name_posadyTextBox
        '
        Me.Name_posadyTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Name_posadyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PosadyBindingSource, "Name_posady", True))
        Me.Name_posadyTextBox.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Name_posadyTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Name_posadyTextBox.Location = New System.Drawing.Point(161, 90)
        Me.Name_posadyTextBox.Name = "Name_posadyTextBox"
        Me.Name_posadyTextBox.Size = New System.Drawing.Size(598, 26)
        Me.Name_posadyTextBox.TabIndex = 5
        '
        'OkladTextBox
        '
        Me.OkladTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.OkladTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PosadyBindingSource, "Oklad", True))
        Me.OkladTextBox.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.OkladTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.OkladTextBox.Location = New System.Drawing.Point(161, 125)
        Me.OkladTextBox.Name = "OkladTextBox"
        Me.OkladTextBox.Size = New System.Drawing.Size(598, 26)
        Me.OkladTextBox.TabIndex = 7
        '
        'OboviazkyTextBox
        '
        Me.OboviazkyTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.OboviazkyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PosadyBindingSource, "Oboviazky", True))
        Me.OboviazkyTextBox.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.OboviazkyTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.OboviazkyTextBox.Location = New System.Drawing.Point(161, 194)
        Me.OboviazkyTextBox.Name = "OboviazkyTextBox"
        Me.OboviazkyTextBox.Size = New System.Drawing.Size(598, 26)
        Me.OboviazkyTextBox.TabIndex = 9
        '
        'VymogyTextBox
        '
        Me.VymogyTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.VymogyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PosadyBindingSource, "Vymogy", True))
        Me.VymogyTextBox.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.VymogyTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.VymogyTextBox.Location = New System.Drawing.Point(161, 159)
        Me.VymogyTextBox.Name = "VymogyTextBox"
        Me.VymogyTextBox.Size = New System.Drawing.Size(598, 26)
        Me.VymogyTextBox.TabIndex = 11
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Button10.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Button10.Location = New System.Drawing.Point(529, 265)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(131, 29)
        Me.Button10.TabIndex = 47
        Me.Button10.Text = "Звіт"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Button9.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Button9.Location = New System.Drawing.Point(392, 352)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(131, 29)
        Me.Button9.TabIndex = 46
        Me.Button9.Text = "Таблиця"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Button8.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Button8.Location = New System.Drawing.Point(392, 323)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(131, 29)
        Me.Button8.TabIndex = 45
        Me.Button8.Text = "Видалити"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Button7.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Button7.Location = New System.Drawing.Point(392, 294)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(131, 29)
        Me.Button7.TabIndex = 44
        Me.Button7.Text = "Остання"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Button6.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Button6.Location = New System.Drawing.Point(392, 265)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(131, 29)
        Me.Button6.TabIndex = 43
        Me.Button6.Text = "Попередня"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Button5.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(161, 323)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(131, 29)
        Me.Button5.TabIndex = 42
        Me.Button5.Text = "Наступна"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(161, 294)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(131, 29)
        Me.Button4.TabIndex = 41
        Me.Button4.Text = "Додати"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(161, 265)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(131, 29)
        Me.Button3.TabIndex = 40
        Me.Button3.Text = "Перша"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(161, 352)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 29)
        Me.Button2.TabIndex = 39
        Me.Button2.Text = "Зберегти"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ID_posadyComboBox
        '
        Me.ID_posadyComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.ID_posadyComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PosadyBindingSource, "ID_posady", True))
        Me.ID_posadyComboBox.DataSource = Me.PosadyBindingSource
        Me.ID_posadyComboBox.DisplayMember = "ID_posady"
        Me.ID_posadyComboBox.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ID_posadyComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.ID_posadyComboBox.FormattingEnabled = True
        Me.ID_posadyComboBox.Location = New System.Drawing.Point(161, 53)
        Me.ID_posadyComboBox.Name = "ID_posadyComboBox"
        Me.ID_posadyComboBox.Size = New System.Drawing.Size(598, 26)
        Me.ID_posadyComboBox.TabIndex = 48
        '
        'Positions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(788, 422)
        Me.Controls.Add(Me.ID_posadyComboBox)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(VymogyLabel)
        Me.Controls.Add(Me.VymogyTextBox)
        Me.Controls.Add(OboviazkyLabel)
        Me.Controls.Add(Me.OboviazkyTextBox)
        Me.Controls.Add(OkladLabel)
        Me.Controls.Add(Me.OkladTextBox)
        Me.Controls.Add(Name_posadyLabel)
        Me.Controls.Add(Me.Name_posadyTextBox)
        Me.Controls.Add(ID_posadyLabel)
        Me.Controls.Add(Me.Button1)
        Me.DoubleBuffered = True
        Me.Name = "Positions"
        Me.Text = "Посади"
        CType(Me.BD_PizzeriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PosadyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents BD_PizzeriaDataSet As BD_PizzeriaDataSet
    Friend WithEvents PosadyBindingSource As BindingSource
    Friend WithEvents PosadyTableAdapter As BD_PizzeriaDataSetTableAdapters.posadyTableAdapter
    Friend WithEvents TableAdapterManager As BD_PizzeriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Name_posadyTextBox As TextBox
    Friend WithEvents OkladTextBox As TextBox
    Friend WithEvents OboviazkyTextBox As TextBox
    Friend WithEvents VymogyTextBox As TextBox
    Friend WithEvents Button10 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ID_posadyComboBox As ComboBox
End Class
