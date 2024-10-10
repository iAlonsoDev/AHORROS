<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBancosCuentas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IdbancoLabel1 As System.Windows.Forms.Label
        Dim IdcuentaLabel As System.Windows.Forms.Label
        Dim CuentaLabel As System.Windows.Forms.Label
        Dim EstadoLabel1 As System.Windows.Forms.Label
        Dim IdbancoLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.AHORROSDataSet = New AHORROS.AHORROSDataSet()
        Me.BancosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BancosTableAdapter = New AHORROS.AHORROSDataSetTableAdapters.BancosTableAdapter()
        Me.TableAdapterManager = New AHORROS.AHORROSDataSetTableAdapters.TableAdapterManager()
        Me.CuentasTableAdapter = New AHORROS.AHORROSDataSetTableAdapters.CuentasTableAdapter()
        Me.CuentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CuentasDataGridView = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CMD_UFB_A = New System.Windows.Forms.Button()
        Me.NombreCuenta = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.IdbancoCuenta = New System.Windows.Forms.TextBox()
        Me.Idcuenta = New System.Windows.Forms.TextBox()
        Me.EstadoCuentas = New System.Windows.Forms.ComboBox()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.GuardarAccount = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer4 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BancosDataGridView = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CMD_UFB_B = New System.Windows.Forms.Button()
        Me.NombreBancos = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.EstadoBancos = New System.Windows.Forms.ComboBox()
        Me.Idbancos = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.GuardarBank = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        IdbancoLabel1 = New System.Windows.Forms.Label()
        IdcuentaLabel = New System.Windows.Forms.Label()
        CuentaLabel = New System.Windows.Forms.Label()
        EstadoLabel1 = New System.Windows.Forms.Label()
        IdbancoLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        CType(Me.AHORROSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BancosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.CuentasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.BancosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdbancoLabel1
        '
        IdbancoLabel1.AutoSize = True
        IdbancoLabel1.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!)
        IdbancoLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        IdbancoLabel1.Location = New System.Drawing.Point(28, 42)
        IdbancoLabel1.Name = "IdbancoLabel1"
        IdbancoLabel1.Size = New System.Drawing.Size(50, 16)
        IdbancoLabel1.TabIndex = 10
        IdbancoLabel1.Text = "ID Bank:"
        '
        'IdcuentaLabel
        '
        IdcuentaLabel.AutoSize = True
        IdcuentaLabel.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!)
        IdcuentaLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        IdcuentaLabel.Location = New System.Drawing.Point(9, 16)
        IdcuentaLabel.Name = "IdcuentaLabel"
        IdcuentaLabel.Size = New System.Drawing.Size(69, 16)
        IdcuentaLabel.TabIndex = 8
        IdcuentaLabel.Text = "ID Account:"
        '
        'CuentaLabel
        '
        CuentaLabel.AutoSize = True
        CuentaLabel.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!)
        CuentaLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        CuentaLabel.Location = New System.Drawing.Point(23, 68)
        CuentaLabel.Name = "CuentaLabel"
        CuentaLabel.Size = New System.Drawing.Size(55, 16)
        CuentaLabel.TabIndex = 12
        CuentaLabel.Text = "Account:"
        '
        'EstadoLabel1
        '
        EstadoLabel1.AutoSize = True
        EstadoLabel1.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!)
        EstadoLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        EstadoLabel1.Location = New System.Drawing.Point(283, 13)
        EstadoLabel1.Name = "EstadoLabel1"
        EstadoLabel1.Size = New System.Drawing.Size(42, 16)
        EstadoLabel1.TabIndex = 14
        EstadoLabel1.Text = "Status:"
        '
        'IdbancoLabel
        '
        IdbancoLabel.AutoSize = True
        IdbancoLabel.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!)
        IdbancoLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        IdbancoLabel.Location = New System.Drawing.Point(29, 17)
        IdbancoLabel.Name = "IdbancoLabel"
        IdbancoLabel.Size = New System.Drawing.Size(50, 16)
        IdbancoLabel.TabIndex = 2
        IdbancoLabel.Text = "ID Bank:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!)
        EstadoLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        EstadoLabel.Location = New System.Drawing.Point(37, 69)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(42, 16)
        EstadoLabel.TabIndex = 13
        EstadoLabel.Text = "Status:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!)
        NombreLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        NombreLabel.Location = New System.Drawing.Point(9, 44)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(70, 16)
        NombreLabel.TabIndex = 4
        NombreLabel.Text = "Bank Name:"
        '
        'AHORROSDataSet
        '
        Me.AHORROSDataSet.DataSetName = "AHORROSDataSet"
        Me.AHORROSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BancosBindingSource
        '
        Me.BancosBindingSource.DataMember = "Bancos"
        Me.BancosBindingSource.DataSource = Me.AHORROSDataSet
        '
        'BancosTableAdapter
        '
        Me.BancosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BancosTableAdapter = Me.BancosTableAdapter
        Me.TableAdapterManager.CuentasTableAdapter = Me.CuentasTableAdapter
        Me.TableAdapterManager.MovimientosTableAdapter = Nothing
        Me.TableAdapterManager.RandomTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AHORROS.AHORROSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CuentasTableAdapter
        '
        Me.CuentasTableAdapter.ClearBeforeFill = True
        '
        'CuentasBindingSource
        '
        Me.CuentasBindingSource.DataMember = "Cuentas"
        Me.CuentasBindingSource.DataSource = Me.AHORROSDataSet
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.MenuBar
        Me.TabPage2.Controls.Add(Me.CuentasDataGridView)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.ShapeContainer4)
        Me.TabPage2.Location = New System.Drawing.Point(23, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(604, 372)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Account"
        '
        'CuentasDataGridView
        '
        Me.CuentasDataGridView.AllowUserToAddRows = False
        Me.CuentasDataGridView.AllowUserToDeleteRows = False
        Me.CuentasDataGridView.AllowUserToOrderColumns = True
        Me.CuentasDataGridView.AllowUserToResizeColumns = False
        Me.CuentasDataGridView.AllowUserToResizeRows = False
        Me.CuentasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CuentasDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.CuentasDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.CuentasDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CuentasDataGridView.CausesValidation = False
        Me.CuentasDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.CuentasDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CuentasDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.CuentasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CuentasDataGridView.ColumnHeadersVisible = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.GrayText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CuentasDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.CuentasDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.CuentasDataGridView.EnableHeadersVisualStyles = False
        Me.CuentasDataGridView.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.CuentasDataGridView.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.CuentasDataGridView.Location = New System.Drawing.Point(26, 127)
        Me.CuentasDataGridView.MultiSelect = False
        Me.CuentasDataGridView.Name = "CuentasDataGridView"
        Me.CuentasDataGridView.ReadOnly = True
        Me.CuentasDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CuentasDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.CuentasDataGridView.RowHeadersVisible = False
        Me.CuentasDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Bahnschrift Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuentasDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.CuentasDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.CuentasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CuentasDataGridView.Size = New System.Drawing.Size(542, 221)
        Me.CuentasDataGridView.TabIndex = 1002
        Me.CuentasDataGridView.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CMD_UFB_A)
        Me.GroupBox1.Controls.Add(Me.NombreCuenta)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.IdbancoCuenta)
        Me.GroupBox1.Controls.Add(Me.Idcuenta)
        Me.GroupBox1.Controls.Add(EstadoLabel1)
        Me.GroupBox1.Controls.Add(Me.EstadoCuentas)
        Me.GroupBox1.Controls.Add(CuentaLabel)
        Me.GroupBox1.Controls.Add(IdcuentaLabel)
        Me.GroupBox1.Controls.Add(IdbancoLabel1)
        Me.GroupBox1.Controls.Add(Me.ShapeContainer2)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(584, 96)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'CMD_UFB_A
        '
        Me.CMD_UFB_A.Location = New System.Drawing.Point(429, 57)
        Me.CMD_UFB_A.Name = "CMD_UFB_A"
        Me.CMD_UFB_A.Size = New System.Drawing.Size(149, 33)
        Me.CMD_UFB_A.TabIndex = 1004
        Me.CMD_UFB_A.Text = "Upload"
        Me.CMD_UFB_A.UseVisualStyleBackColor = True
        '
        'NombreCuenta
        '
        Me.NombreCuenta.BackColor = System.Drawing.SystemColors.MenuBar
        Me.NombreCuenta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentasBindingSource, "cuenta", True))
        Me.NombreCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreCuenta.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.NombreCuenta.Location = New System.Drawing.Point(88, 66)
        Me.NombreCuenta.Name = "NombreCuenta"
        Me.NombreCuenta.Size = New System.Drawing.Size(315, 20)
        Me.NombreCuenta.TabIndex = 13
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(443, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(121, 26)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'IdbancoCuenta
        '
        Me.IdbancoCuenta.BackColor = System.Drawing.SystemColors.MenuBar
        Me.IdbancoCuenta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentasBindingSource, "idbanco", True))
        Me.IdbancoCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdbancoCuenta.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.IdbancoCuenta.Location = New System.Drawing.Point(88, 40)
        Me.IdbancoCuenta.Name = "IdbancoCuenta"
        Me.IdbancoCuenta.Size = New System.Drawing.Size(100, 20)
        Me.IdbancoCuenta.TabIndex = 11
        '
        'Idcuenta
        '
        Me.Idcuenta.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Idcuenta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentasBindingSource, "idcuenta", True))
        Me.Idcuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Idcuenta.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Idcuenta.Location = New System.Drawing.Point(88, 14)
        Me.Idcuenta.Name = "Idcuenta"
        Me.Idcuenta.Size = New System.Drawing.Size(100, 20)
        Me.Idcuenta.TabIndex = 9
        '
        'EstadoCuentas
        '
        Me.EstadoCuentas.BackColor = System.Drawing.SystemColors.MenuBar
        Me.EstadoCuentas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentasBindingSource, "estado", True))
        Me.EstadoCuentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EstadoCuentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoCuentas.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.EstadoCuentas.FormattingEnabled = True
        Me.EstadoCuentas.Items.AddRange(New Object() {"1", "0"})
        Me.EstadoCuentas.Location = New System.Drawing.Point(331, 14)
        Me.EstadoCuentas.Name = "EstadoCuentas"
        Me.EstadoCuentas.Size = New System.Drawing.Size(72, 21)
        Me.EstadoCuentas.TabIndex = 15
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.GuardarAccount})
        Me.ShapeContainer2.Size = New System.Drawing.Size(578, 77)
        Me.ShapeContainer2.TabIndex = 17
        Me.ShapeContainer2.TabStop = False
        '
        'GuardarAccount
        '
        Me.GuardarAccount.BackColor = System.Drawing.SystemColors.Highlight
        Me.GuardarAccount.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.GuardarAccount.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GuardarAccount.CornerRadius = 5
        Me.GuardarAccount.Location = New System.Drawing.Point(426, 2)
        Me.GuardarAccount.Name = "GuardarAccount"
        Me.GuardarAccount.Size = New System.Drawing.Size(149, 32)
        '
        'ShapeContainer4
        '
        Me.ShapeContainer4.Location = New System.Drawing.Point(3, 3)
        Me.ShapeContainer4.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer4.Name = "ShapeContainer4"
        Me.ShapeContainer4.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2})
        Me.ShapeContainer4.Size = New System.Drawing.Size(598, 366)
        Me.ShapeContainer4.TabIndex = 1003
        Me.ShapeContainer4.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackColor = System.Drawing.Color.White
        Me.RectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape2.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RectangleShape2.CornerRadius = 5
        Me.RectangleShape2.Location = New System.Drawing.Point(3, 111)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(580, 244)
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.MenuBar
        Me.TabPage1.Controls.Add(Me.BancosDataGridView)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.ShapeContainer3)
        Me.TabPage1.Location = New System.Drawing.Point(23, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(604, 372)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Bank"
        '
        'BancosDataGridView
        '
        Me.BancosDataGridView.AllowUserToAddRows = False
        Me.BancosDataGridView.AllowUserToDeleteRows = False
        Me.BancosDataGridView.AllowUserToOrderColumns = True
        Me.BancosDataGridView.AllowUserToResizeColumns = False
        Me.BancosDataGridView.AllowUserToResizeRows = False
        Me.BancosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BancosDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.BancosDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.BancosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BancosDataGridView.CausesValidation = False
        Me.BancosDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.BancosDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BancosDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.BancosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BancosDataGridView.ColumnHeadersVisible = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.GrayText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BancosDataGridView.DefaultCellStyle = DataGridViewCellStyle6
        Me.BancosDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.BancosDataGridView.EnableHeadersVisualStyles = False
        Me.BancosDataGridView.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.BancosDataGridView.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.BancosDataGridView.Location = New System.Drawing.Point(18, 126)
        Me.BancosDataGridView.MultiSelect = False
        Me.BancosDataGridView.Name = "BancosDataGridView"
        Me.BancosDataGridView.ReadOnly = True
        Me.BancosDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BancosDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.BancosDataGridView.RowHeadersVisible = False
        Me.BancosDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Bahnschrift Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BancosDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.BancosDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.BancosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BancosDataGridView.Size = New System.Drawing.Size(557, 224)
        Me.BancosDataGridView.TabIndex = 1001
        Me.BancosDataGridView.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CMD_UFB_B)
        Me.GroupBox2.Controls.Add(Me.NombreBancos)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(NombreLabel)
        Me.GroupBox2.Controls.Add(Me.EstadoBancos)
        Me.GroupBox2.Controls.Add(Me.Idbancos)
        Me.GroupBox2.Controls.Add(EstadoLabel)
        Me.GroupBox2.Controls.Add(IdbancoLabel)
        Me.GroupBox2.Controls.Add(Me.ShapeContainer1)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(584, 96)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        '
        'CMD_UFB_B
        '
        Me.CMD_UFB_B.Location = New System.Drawing.Point(458, 56)
        Me.CMD_UFB_B.Name = "CMD_UFB_B"
        Me.CMD_UFB_B.Size = New System.Drawing.Size(111, 33)
        Me.CMD_UFB_B.TabIndex = 1003
        Me.CMD_UFB_B.Text = "Upload"
        Me.CMD_UFB_B.UseVisualStyleBackColor = True
        '
        'NombreBancos
        '
        Me.NombreBancos.BackColor = System.Drawing.SystemColors.MenuBar
        Me.NombreBancos.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BancosBindingSource, "nombre", True))
        Me.NombreBancos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreBancos.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.NombreBancos.Location = New System.Drawing.Point(88, 41)
        Me.NombreBancos.Multiline = True
        Me.NombreBancos.Name = "NombreBancos"
        Me.NombreBancos.Size = New System.Drawing.Size(194, 20)
        Me.NombreBancos.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(315, 59)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 28)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'EstadoBancos
        '
        Me.EstadoBancos.BackColor = System.Drawing.SystemColors.MenuBar
        Me.EstadoBancos.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BancosBindingSource, "estado", True))
        Me.EstadoBancos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EstadoBancos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoBancos.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.EstadoBancos.FormattingEnabled = True
        Me.EstadoBancos.Items.AddRange(New Object() {"1", "0"})
        Me.EstadoBancos.Location = New System.Drawing.Point(88, 66)
        Me.EstadoBancos.Name = "EstadoBancos"
        Me.EstadoBancos.Size = New System.Drawing.Size(121, 21)
        Me.EstadoBancos.TabIndex = 14
        '
        'Idbancos
        '
        Me.Idbancos.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Idbancos.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BancosBindingSource, "idbanco", True))
        Me.Idbancos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Idbancos.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Idbancos.Location = New System.Drawing.Point(88, 14)
        Me.Idbancos.Multiline = True
        Me.Idbancos.Name = "Idbancos"
        Me.Idbancos.Size = New System.Drawing.Size(100, 20)
        Me.Idbancos.TabIndex = 3
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.GuardarBank})
        Me.ShapeContainer1.Size = New System.Drawing.Size(578, 77)
        Me.ShapeContainer1.TabIndex = 16
        Me.ShapeContainer1.TabStop = False
        '
        'GuardarBank
        '
        Me.GuardarBank.BackColor = System.Drawing.SystemColors.Highlight
        Me.GuardarBank.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.GuardarBank.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GuardarBank.CornerRadius = 5
        Me.GuardarBank.Location = New System.Drawing.Point(299, 40)
        Me.GuardarBank.Name = "GuardarBank"
        Me.GuardarBank.Size = New System.Drawing.Size(149, 32)
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(3, 3)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer3.Size = New System.Drawing.Size(598, 366)
        Me.ShapeContainer3.TabIndex = 1002
        Me.ShapeContainer3.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.White
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RectangleShape1.CornerRadius = 5
        Me.RectangleShape1.Location = New System.Drawing.Point(6, 111)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(575, 246)
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(631, 380)
        Me.TabControl1.TabIndex = 16
        '
        'FormBancosCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ClientSize = New System.Drawing.Size(631, 380)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormBancosCuentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.AHORROSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BancosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.CuentasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.BancosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AHORROSDataSet As AHORROSDataSet
    Friend WithEvents BancosBindingSource As BindingSource
    Friend WithEvents BancosTableAdapter As AHORROSDataSetTableAdapters.BancosTableAdapter
    Friend WithEvents TableAdapterManager As AHORROSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CuentasTableAdapter As AHORROSDataSetTableAdapters.CuentasTableAdapter
    Friend WithEvents CuentasBindingSource As BindingSource
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents NombreCuenta As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents IdbancoCuenta As TextBox
    Friend WithEvents Idcuenta As TextBox
    Friend WithEvents EstadoCuentas As ComboBox
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents NombreBancos As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents EstadoBancos As ComboBox
    Friend WithEvents Idbancos As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents GuardarBank As PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents GuardarAccount As PowerPacks.RectangleShape
    Protected WithEvents BancosDataGridView As DataGridView
    Protected WithEvents CuentasDataGridView As DataGridView
    Friend WithEvents ShapeContainer3 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer4 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape2 As PowerPacks.RectangleShape
    Friend WithEvents CMD_UFB_B As Button
    Friend WithEvents CMD_UFB_A As Button
End Class
