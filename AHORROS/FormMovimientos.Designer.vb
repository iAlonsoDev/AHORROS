<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMovimientos
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
        Dim ReferenciaLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim DepositoLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Dim BancoLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMovimientos))
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.BancoComboBox = New System.Windows.Forms.ComboBox()
        Me.DescripcionComboBox = New System.Windows.Forms.ComboBox()
        Me.RB_DEPOSITO = New System.Windows.Forms.RadioButton()
        Me.RB_RETIRO = New System.Windows.Forms.RadioButton()
        Me.MovimientosDataGridView = New System.Windows.Forms.DataGridView()
        Me.ReferenciaTextBox = New System.Windows.Forms.TextBox()
        Me.Pn_MenuOptions = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.OvalShape1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.TxtTitle_App = New System.Windows.Forms.Label()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.RectangleShape11 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape10 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.RectangleShape9 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape8 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape7 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.GuardarMov = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape6 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape12 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape13 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.TxtTitle_TotalBalance = New System.Windows.Forms.Label()
        Me.TxtCant_TotalBalance = New System.Windows.Forms.Label()
        Me.TxtSave = New System.Windows.Forms.Label()
        Me.TxtCant_LastTransaction = New System.Windows.Forms.Label()
        Me.TxtTitle_LastTransaction = New System.Windows.Forms.Label()
        Me.TxtTitle_Type = New System.Windows.Forms.Label()
        Me.ChartTotCuenta = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TxtCant_TopBalance = New System.Windows.Forms.Label()
        Me.TxtTitle_TopBalance = New System.Windows.Forms.Label()
        Me.Txt_BestRanking = New System.Windows.Forms.Label()
        Me.TxtTitle_BestRanking = New System.Windows.Forms.Label()
        Me.LblPerformance = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DepositoTextBox = New System.Windows.Forms.TextBox()
        Me.LblDate = New System.Windows.Forms.Label()
        Me.TxtCant_Promedio = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.RB_TRANSFERENCIA = New System.Windows.Forms.RadioButton()
        Me.ChartTotBancos = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Txt_TotalAvailable = New System.Windows.Forms.Label()
        Me.CMD_UFB_T = New System.Windows.Forms.Button()
        Me.VwMovimientosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AHORROSDataSet = New AHORROS.AHORROSDataSet()
        Me.TableAdapterManager = New AHORROS.AHORROSDataSetTableAdapters.TableAdapterManager()
        Me.Vw_MovimientosTableAdapter = New AHORROS.AHORROSDataSetTableAdapters.vw_MovimientosTableAdapter()
        Me.CMD_DFB_T = New System.Windows.Forms.Button()
        Me.DataGridTransactions = New System.Windows.Forms.DataGridView()
        Me.Cmb_Delete = New System.Windows.Forms.PictureBox()
        Me.AHORROSDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtPorV = New System.Windows.Forms.Label()
        Me.txtPorR = New System.Windows.Forms.Label()
        Me.txtPorA = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.txtDiferencia = New System.Windows.Forms.Label()
        ReferenciaLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        DepositoLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        BancoLabel = New System.Windows.Forms.Label()
        CType(Me.MovimientosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pn_MenuOptions.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartTotCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartTotBancos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwMovimientosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AHORROSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cmb_Delete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AHORROSDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReferenciaLabel
        '
        ReferenciaLabel.AutoSize = True
        ReferenciaLabel.BackColor = System.Drawing.Color.White
        ReferenciaLabel.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!)
        ReferenciaLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(141, Byte), Integer))
        ReferenciaLabel.Location = New System.Drawing.Point(105, 274)
        ReferenciaLabel.Name = "ReferenciaLabel"
        ReferenciaLabel.Size = New System.Drawing.Size(62, 16)
        ReferenciaLabel.TabIndex = 5
        ReferenciaLabel.Text = "Reference:"
        ReferenciaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.BackColor = System.Drawing.Color.White
        DescripcionLabel.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!)
        DescripcionLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(141, Byte), Integer))
        DescripcionLabel.Location = New System.Drawing.Point(109, 342)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(70, 16)
        DescripcionLabel.TabIndex = 7
        DescripcionLabel.Text = "Description:"
        DescripcionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DepositoLabel
        '
        DepositoLabel.AutoSize = True
        DepositoLabel.BackColor = System.Drawing.Color.White
        DepositoLabel.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!)
        DepositoLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(141, Byte), Integer))
        DepositoLabel.Location = New System.Drawing.Point(109, 391)
        DepositoLabel.Name = "DepositoLabel"
        DepositoLabel.Size = New System.Drawing.Size(53, 16)
        DepositoLabel.TabIndex = 9
        DepositoLabel.Text = "Amount:"
        DepositoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.BackColor = System.Drawing.Color.White
        TotalLabel.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        TotalLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(141, Byte), Integer))
        TotalLabel.Location = New System.Drawing.Point(126, 457)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(92, 22)
        TotalLabel.TabIndex = 11
        TotalLabel.Text = "Summary:"
        '
        'BancoLabel
        '
        BancoLabel.AutoSize = True
        BancoLabel.BackColor = System.Drawing.Color.White
        BancoLabel.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!)
        BancoLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(141, Byte), Integer))
        BancoLabel.Location = New System.Drawing.Point(105, 211)
        BancoLabel.Name = "BancoLabel"
        BancoLabel.Size = New System.Drawing.Size(36, 16)
        BancoLabel.TabIndex = 14
        BancoLabel.Text = "Bank:"
        BancoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TotalTextBox
        '
        Me.TotalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TotalTextBox.Font = New System.Drawing.Font("Gadugi", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalTextBox.Location = New System.Drawing.Point(214, 456)
        Me.TotalTextBox.Multiline = True
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(210, 28)
        Me.TotalTextBox.TabIndex = 100
        Me.TotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BancoComboBox
        '
        Me.BancoComboBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BancoComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BancoComboBox.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!)
        Me.BancoComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BancoComboBox.FormattingEnabled = True
        Me.BancoComboBox.Location = New System.Drawing.Point(108, 233)
        Me.BancoComboBox.Name = "BancoComboBox"
        Me.BancoComboBox.Size = New System.Drawing.Size(313, 24)
        Me.BancoComboBox.TabIndex = 101
        '
        'DescripcionComboBox
        '
        Me.DescripcionComboBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DescripcionComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DescripcionComboBox.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!)
        Me.DescripcionComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DescripcionComboBox.FormattingEnabled = True
        Me.DescripcionComboBox.Location = New System.Drawing.Point(108, 361)
        Me.DescripcionComboBox.Name = "DescripcionComboBox"
        Me.DescripcionComboBox.Size = New System.Drawing.Size(313, 24)
        Me.DescripcionComboBox.TabIndex = 102
        '
        'RB_DEPOSITO
        '
        Me.RB_DEPOSITO.AutoSize = True
        Me.RB_DEPOSITO.BackColor = System.Drawing.Color.White
        Me.RB_DEPOSITO.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_DEPOSITO.ForeColor = System.Drawing.SystemColors.Highlight
        Me.RB_DEPOSITO.Location = New System.Drawing.Point(1900, 133)
        Me.RB_DEPOSITO.Name = "RB_DEPOSITO"
        Me.RB_DEPOSITO.Size = New System.Drawing.Size(74, 21)
        Me.RB_DEPOSITO.TabIndex = 18
        Me.RB_DEPOSITO.TabStop = True
        Me.RB_DEPOSITO.Text = "Deposit"
        Me.RB_DEPOSITO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RB_DEPOSITO.UseVisualStyleBackColor = False
        '
        'RB_RETIRO
        '
        Me.RB_RETIRO.AutoSize = True
        Me.RB_RETIRO.BackColor = System.Drawing.Color.White
        Me.RB_RETIRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_RETIRO.ForeColor = System.Drawing.Color.Red
        Me.RB_RETIRO.Location = New System.Drawing.Point(2029, 133)
        Me.RB_RETIRO.Name = "RB_RETIRO"
        Me.RB_RETIRO.Size = New System.Drawing.Size(95, 21)
        Me.RB_RETIRO.TabIndex = 19
        Me.RB_RETIRO.TabStop = True
        Me.RB_RETIRO.Text = "Withdrawal"
        Me.RB_RETIRO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RB_RETIRO.UseVisualStyleBackColor = False
        '
        'MovimientosDataGridView
        '
        Me.MovimientosDataGridView.AllowUserToAddRows = False
        Me.MovimientosDataGridView.AllowUserToDeleteRows = False
        Me.MovimientosDataGridView.AllowUserToOrderColumns = True
        Me.MovimientosDataGridView.AllowUserToResizeColumns = False
        Me.MovimientosDataGridView.AllowUserToResizeRows = False
        Me.MovimientosDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MovimientosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MovimientosDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.MovimientosDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.MovimientosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MovimientosDataGridView.CausesValidation = False
        Me.MovimientosDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MovimientosDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MovimientosDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.MovimientosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MovimientosDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.MovimientosDataGridView.GridColor = System.Drawing.SystemColors.Control
        Me.MovimientosDataGridView.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.MovimientosDataGridView.Location = New System.Drawing.Point(98, 697)
        Me.MovimientosDataGridView.MultiSelect = False
        Me.MovimientosDataGridView.Name = "MovimientosDataGridView"
        Me.MovimientosDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MovimientosDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.MovimientosDataGridView.RowHeadersVisible = False
        Me.MovimientosDataGridView.RowHeadersWidth = 51
        Me.MovimientosDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MovimientosDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.MovimientosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MovimientosDataGridView.Size = New System.Drawing.Size(1701, 349)
        Me.MovimientosDataGridView.TabIndex = 1000
        Me.MovimientosDataGridView.TabStop = False
        '
        'ReferenciaTextBox
        '
        Me.ReferenciaTextBox.BackColor = System.Drawing.Color.White
        Me.ReferenciaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ReferenciaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ReferenciaTextBox.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!)
        Me.ReferenciaTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ReferenciaTextBox.Location = New System.Drawing.Point(110, 304)
        Me.ReferenciaTextBox.Name = "ReferenciaTextBox"
        Me.ReferenciaTextBox.Size = New System.Drawing.Size(309, 15)
        Me.ReferenciaTextBox.TabIndex = 21
        Me.ReferenciaTextBox.Text = "NINGUNA"
        '
        'Pn_MenuOptions
        '
        Me.Pn_MenuOptions.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Pn_MenuOptions.Controls.Add(Me.PictureBox4)
        Me.Pn_MenuOptions.Controls.Add(Me.PictureBox3)
        Me.Pn_MenuOptions.Controls.Add(Me.PictureBox2)
        Me.Pn_MenuOptions.Controls.Add(Me.PictureBox1)
        Me.Pn_MenuOptions.Controls.Add(Me.ShapeContainer1)
        Me.Pn_MenuOptions.Dock = System.Windows.Forms.DockStyle.Left
        Me.Pn_MenuOptions.Location = New System.Drawing.Point(0, 0)
        Me.Pn_MenuOptions.Name = "Pn_MenuOptions"
        Me.Pn_MenuOptions.Size = New System.Drawing.Size(58, 1095)
        Me.Pn_MenuOptions.TabIndex = 24
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(11, 129)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 32
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(11, 91)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 31
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(11, 53)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 997)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.OvalShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(58, 1095)
        Me.ShapeContainer1.TabIndex = 30
        Me.ShapeContainer1.TabStop = False
        '
        'OvalShape1
        '
        Me.OvalShape1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.OvalShape1.BackgroundImage = CType(resources.GetObject("OvalShape1.BackgroundImage"), System.Drawing.Image)
        Me.OvalShape1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OvalShape1.Location = New System.Drawing.Point(9, 943)
        Me.OvalShape1.Name = ""
        Me.OvalShape1.Size = New System.Drawing.Size(36, 37)
        '
        'TxtTitle_App
        '
        Me.TxtTitle_App.AutoSize = True
        Me.TxtTitle_App.BackColor = System.Drawing.Color.Transparent
        Me.TxtTitle_App.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TxtTitle_App.Font = New System.Drawing.Font("Microsoft YaHei", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTitle_App.ForeColor = System.Drawing.Color.DimGray
        Me.TxtTitle_App.Location = New System.Drawing.Point(90, 20)
        Me.TxtTitle_App.Name = "TxtTitle_App"
        Me.TxtTitle_App.Size = New System.Drawing.Size(179, 46)
        Me.TxtTitle_App.TabIndex = 0
        Me.TxtTitle_App.Text = "MyWallet"
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape5, Me.LineShape2, Me.RectangleShape11, Me.RectangleShape10, Me.LineShape1, Me.RectangleShape9, Me.RectangleShape8, Me.RectangleShape7, Me.GuardarMov, Me.RectangleShape4, Me.RectangleShape3, Me.RectangleShape2, Me.RectangleShape1, Me.RectangleShape6, Me.RectangleShape12, Me.RectangleShape13})
        Me.ShapeContainer2.Size = New System.Drawing.Size(2308, 1095)
        Me.ShapeContainer2.TabIndex = 26
        Me.ShapeContainer2.TabStop = False
        '
        'RectangleShape5
        '
        Me.RectangleShape5.BackColor = System.Drawing.SystemColors.MenuBar
        Me.RectangleShape5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.RectangleShape5.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape5.BorderColor = System.Drawing.SystemColors.MenuBar
        Me.RectangleShape5.CornerRadius = 5
        Me.RectangleShape5.Cursor = System.Windows.Forms.Cursors.Default
        Me.RectangleShape5.Enabled = False
        Me.RectangleShape5.FillColor = System.Drawing.SystemColors.MenuBar
        Me.RectangleShape5.FillGradientColor = System.Drawing.SystemColors.MenuBar
        Me.RectangleShape5.Location = New System.Drawing.Point(108, 664)
        Me.RectangleShape5.Name = "RectangleShape12"
        Me.RectangleShape5.SelectionColor = System.Drawing.SystemColors.Control
        Me.RectangleShape5.Size = New System.Drawing.Size(424, 28)
        '
        'LineShape2
        '
        Me.LineShape2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.Highlight
        Me.LineShape2.BorderWidth = 4
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 56
        Me.LineShape2.X2 = 57
        Me.LineShape2.Y1 = 70
        Me.LineShape2.Y2 = 1066
        '
        'RectangleShape11
        '
        Me.RectangleShape11.BackColor = System.Drawing.Color.White
        Me.RectangleShape11.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape11.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RectangleShape11.CornerRadius = 5
        Me.RectangleShape11.Enabled = False
        Me.RectangleShape11.Location = New System.Drawing.Point(1861, 79)
        Me.RectangleShape11.Name = "RectangleShape11"
        Me.RectangleShape11.Size = New System.Drawing.Size(410, 95)
        '
        'RectangleShape10
        '
        Me.RectangleShape10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RectangleShape10.BackColor = System.Drawing.Color.White
        Me.RectangleShape10.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape10.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RectangleShape10.CornerRadius = 5
        Me.RectangleShape10.Enabled = False
        Me.RectangleShape10.Location = New System.Drawing.Point(470, 190)
        Me.RectangleShape10.Name = "RectangleShape10"
        Me.RectangleShape10.Size = New System.Drawing.Size(1801, 436)
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 110
        Me.LineShape1.X2 = 420
        Me.LineShape1.Y1 = 488
        Me.LineShape1.Y2 = 488
        '
        'RectangleShape9
        '
        Me.RectangleShape9.BackColor = System.Drawing.Color.White
        Me.RectangleShape9.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape9.BorderColor = System.Drawing.SystemColors.ButtonFace
        Me.RectangleShape9.CornerRadius = 5
        Me.RectangleShape9.FillGradientColor = System.Drawing.Color.White
        Me.RectangleShape9.Location = New System.Drawing.Point(108, 410)
        Me.RectangleShape9.Name = "RectangleShape9"
        Me.RectangleShape9.Size = New System.Drawing.Size(315, 32)
        '
        'RectangleShape8
        '
        Me.RectangleShape8.BackColor = System.Drawing.Color.White
        Me.RectangleShape8.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape8.BorderColor = System.Drawing.SystemColors.ButtonFace
        Me.RectangleShape8.CornerRadius = 5
        Me.RectangleShape8.FillGradientColor = System.Drawing.Color.White
        Me.RectangleShape8.Location = New System.Drawing.Point(106, 295)
        Me.RectangleShape8.Name = "RectangleShape8"
        Me.RectangleShape8.Size = New System.Drawing.Size(315, 32)
        '
        'RectangleShape7
        '
        Me.RectangleShape7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RectangleShape7.BackColor = System.Drawing.Color.White
        Me.RectangleShape7.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape7.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RectangleShape7.Enabled = False
        Me.RectangleShape7.Location = New System.Drawing.Point(82, 651)
        Me.RectangleShape7.Name = "RectangleShape7"
        Me.RectangleShape7.Size = New System.Drawing.Size(2188, 394)
        '
        'GuardarMov
        '
        Me.GuardarMov.BackColor = System.Drawing.SystemColors.Highlight
        Me.GuardarMov.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.GuardarMov.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GuardarMov.CornerRadius = 5
        Me.GuardarMov.Location = New System.Drawing.Point(146, 499)
        Me.GuardarMov.Name = "GuardarMov"
        Me.GuardarMov.Size = New System.Drawing.Size(187, 32)
        '
        'RectangleShape4
        '
        Me.RectangleShape4.BackColor = System.Drawing.Color.White
        Me.RectangleShape4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape4.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RectangleShape4.CornerRadius = 5
        Me.RectangleShape4.Enabled = False
        Me.RectangleShape4.Location = New System.Drawing.Point(1505, 79)
        Me.RectangleShape4.Name = "RectangleShape4"
        Me.RectangleShape4.Size = New System.Drawing.Size(329, 95)
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BackColor = System.Drawing.Color.White
        Me.RectangleShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape3.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RectangleShape3.CornerRadius = 5
        Me.RectangleShape3.Enabled = False
        Me.RectangleShape3.Location = New System.Drawing.Point(1150, 79)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(329, 95)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackColor = System.Drawing.Color.White
        Me.RectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape2.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RectangleShape2.CornerRadius = 5
        Me.RectangleShape2.Enabled = False
        Me.RectangleShape2.Location = New System.Drawing.Point(793, 79)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(329, 95)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.White
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RectangleShape1.CornerRadius = 5
        Me.RectangleShape1.Enabled = False
        Me.RectangleShape1.Location = New System.Drawing.Point(439, 79)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(329, 95)
        '
        'RectangleShape6
        '
        Me.RectangleShape6.BackColor = System.Drawing.Color.White
        Me.RectangleShape6.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape6.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RectangleShape6.CornerRadius = 5
        Me.RectangleShape6.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RectangleShape6.Enabled = False
        Me.RectangleShape6.Location = New System.Drawing.Point(81, 189)
        Me.RectangleShape6.Name = "RectangleShape6"
        Me.RectangleShape6.Size = New System.Drawing.Size(357, 436)
        '
        'RectangleShape12
        '
        Me.RectangleShape12.BackColor = System.Drawing.SystemColors.Highlight
        Me.RectangleShape12.BorderColor = System.Drawing.SystemColors.Highlight
        Me.RectangleShape12.CornerRadius = 5
        Me.RectangleShape12.Location = New System.Drawing.Point(79, 53)
        Me.RectangleShape12.Name = "RectangleShape12"
        Me.RectangleShape12.Size = New System.Drawing.Size(273, 13)
        '
        'RectangleShape13
        '
        Me.RectangleShape13.BackColor = System.Drawing.Color.White
        Me.RectangleShape13.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape13.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RectangleShape13.CornerRadius = 5
        Me.RectangleShape13.Enabled = False
        Me.RectangleShape13.Location = New System.Drawing.Point(82, 80)
        Me.RectangleShape13.Name = "RectangleShape13"
        Me.RectangleShape13.Size = New System.Drawing.Size(329, 91)
        '
        'TxtTitle_TotalBalance
        '
        Me.TxtTitle_TotalBalance.AutoSize = True
        Me.TxtTitle_TotalBalance.BackColor = System.Drawing.Color.White
        Me.TxtTitle_TotalBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTitle_TotalBalance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.TxtTitle_TotalBalance.Location = New System.Drawing.Point(112, 101)
        Me.TxtTitle_TotalBalance.Name = "TxtTitle_TotalBalance"
        Me.TxtTitle_TotalBalance.Size = New System.Drawing.Size(89, 13)
        Me.TxtTitle_TotalBalance.TabIndex = 27
        Me.TxtTitle_TotalBalance.Text = "TOTAL BALANCE"
        '
        'TxtCant_TotalBalance
        '
        Me.TxtCant_TotalBalance.AutoSize = True
        Me.TxtCant_TotalBalance.BackColor = System.Drawing.Color.White
        Me.TxtCant_TotalBalance.Font = New System.Drawing.Font("Microsoft YaHei", 16.0!)
        Me.TxtCant_TotalBalance.ForeColor = System.Drawing.SystemColors.Highlight
        Me.TxtCant_TotalBalance.Location = New System.Drawing.Point(107, 126)
        Me.TxtCant_TotalBalance.Name = "TxtCant_TotalBalance"
        Me.TxtCant_TotalBalance.Size = New System.Drawing.Size(94, 30)
        Me.TxtCant_TotalBalance.TabIndex = 28
        Me.TxtCant_TotalBalance.Text = "Balance"
        '
        'TxtSave
        '
        Me.TxtSave.AutoSize = True
        Me.TxtSave.BackColor = System.Drawing.SystemColors.Highlight
        Me.TxtSave.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!)
        Me.TxtSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtSave.Location = New System.Drawing.Point(196, 508)
        Me.TxtSave.Name = "TxtSave"
        Me.TxtSave.Size = New System.Drawing.Size(93, 17)
        Me.TxtSave.TabIndex = 29
        Me.TxtSave.Text = "Add / Subtract"
        '
        'TxtCant_LastTransaction
        '
        Me.TxtCant_LastTransaction.AutoSize = True
        Me.TxtCant_LastTransaction.BackColor = System.Drawing.Color.White
        Me.TxtCant_LastTransaction.Font = New System.Drawing.Font("Microsoft YaHei", 16.0!)
        Me.TxtCant_LastTransaction.ForeColor = System.Drawing.SystemColors.Highlight
        Me.TxtCant_LastTransaction.Location = New System.Drawing.Point(1180, 126)
        Me.TxtCant_LastTransaction.Name = "TxtCant_LastTransaction"
        Me.TxtCant_LastTransaction.Size = New System.Drawing.Size(94, 30)
        Me.TxtCant_LastTransaction.TabIndex = 31
        Me.TxtCant_LastTransaction.Text = "Balance"
        '
        'TxtTitle_LastTransaction
        '
        Me.TxtTitle_LastTransaction.AutoSize = True
        Me.TxtTitle_LastTransaction.BackColor = System.Drawing.Color.White
        Me.TxtTitle_LastTransaction.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTitle_LastTransaction.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.TxtTitle_LastTransaction.Location = New System.Drawing.Point(1182, 101)
        Me.TxtTitle_LastTransaction.Name = "TxtTitle_LastTransaction"
        Me.TxtTitle_LastTransaction.Size = New System.Drawing.Size(105, 13)
        Me.TxtTitle_LastTransaction.TabIndex = 30
        Me.TxtTitle_LastTransaction.Text = "LAST TRANSACTION"
        '
        'TxtTitle_Type
        '
        Me.TxtTitle_Type.AutoSize = True
        Me.TxtTitle_Type.BackColor = System.Drawing.Color.White
        Me.TxtTitle_Type.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTitle_Type.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.TxtTitle_Type.Location = New System.Drawing.Point(1897, 101)
        Me.TxtTitle_Type.Name = "TxtTitle_Type"
        Me.TxtTitle_Type.Size = New System.Drawing.Size(80, 13)
        Me.TxtTitle_Type.TabIndex = 32
        Me.TxtTitle_Type.Text = "RECORD TYPE"
        '
        'ChartTotCuenta
        '
        Me.ChartTotCuenta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChartTotCuenta.BackColor = System.Drawing.Color.Transparent
        Me.ChartTotCuenta.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center
        Me.ChartTotCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ChartTotCuenta.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center
        Me.ChartTotCuenta.BorderlineWidth = 0
        Me.ChartTotCuenta.BorderSkin.BackColor = System.Drawing.Color.Transparent
        Me.ChartTotCuenta.BorderSkin.PageColor = System.Drawing.Color.Gray
        ChartArea3.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.None
        ChartArea3.AlignmentStyle = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.None
        ChartArea3.Area3DStyle.Inclination = 15
        ChartArea3.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
        ChartArea3.Area3DStyle.WallWidth = 10
        ChartArea3.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea3.AxisX.IsMarginVisible = False
        ChartArea3.AxisX.IsMarksNextToAxis = False
        ChartArea3.AxisX.LabelAutoFitMaxFontSize = 8
        ChartArea3.AxisX.LabelStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        ChartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.DimGray
        ChartArea3.AxisX.LineColor = System.Drawing.Color.Silver
        ChartArea3.AxisX.LogarithmBase = 100.0R
        ChartArea3.AxisX.MajorGrid.Enabled = False
        ChartArea3.AxisX.MajorGrid.Interval = 0R
        ChartArea3.AxisX.MajorGrid.IntervalOffset = 0R
        ChartArea3.AxisX.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.[Auto]
        ChartArea3.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.[Auto]
        ChartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkGray
        ChartArea3.AxisX.MajorTickMark.Enabled = False
        ChartArea3.AxisX.MaximumAutoSize = 60.0!
        ChartArea3.AxisX.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.None
        ChartArea3.AxisX.ScaleBreakStyle.CollapsibleSpaceThreshold = 10
        ChartArea3.AxisX.ScaleBreakStyle.MaxNumberOfBreaks = 1
        ChartArea3.AxisX.ScaleBreakStyle.Spacing = 1.0R
        ChartArea3.AxisX.ScaleBreakStyle.StartFromZero = System.Windows.Forms.DataVisualization.Charting.StartFromZero.No
        ChartArea3.AxisX.ScrollBar.Size = 10.0R
        ChartArea3.AxisX.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea3.AxisX.TitleForeColor = System.Drawing.Color.DarkGray
        ChartArea3.AxisX2.LabelAutoFitMaxFontSize = 7
        ChartArea3.AxisX2.LineColor = System.Drawing.Color.LightGray
        ChartArea3.AxisX2.MajorGrid.Enabled = False
        ChartArea3.AxisX2.MajorTickMark.Enabled = False
        ChartArea3.AxisX2.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated90
        ChartArea3.AxisX2.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        ChartArea3.AxisX2.TitleForeColor = System.Drawing.Color.DarkGray
        ChartArea3.AxisY.Crossing = -1.7976931348623157E+308R
        ChartArea3.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
        ChartArea3.AxisY.IsMarksNextToAxis = False
        ChartArea3.AxisY.IsStartedFromZero = False
        ChartArea3.AxisY.LabelAutoFitMaxFontSize = 8
        ChartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.DimGray
        ChartArea3.AxisY.LineColor = System.Drawing.Color.LightGray
        ChartArea3.AxisY.MajorGrid.Enabled = False
        ChartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea3.AxisY.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.None
        ChartArea3.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.Transparent
        ChartArea3.AxisY.ScaleBreakStyle.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        ChartArea3.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal
        ChartArea3.AxisY.TitleForeColor = System.Drawing.Color.DarkGray
        ChartArea3.AxisY2.LabelAutoFitMaxFontSize = 8
        ChartArea3.AxisY2.LineColor = System.Drawing.Color.LightGray
        ChartArea3.AxisY2.MajorGrid.Enabled = False
        ChartArea3.AxisY2.MajorTickMark.Enabled = False
        ChartArea3.AxisY2.TitleForeColor = System.Drawing.Color.DarkGray
        ChartArea3.BackColor = System.Drawing.Color.Transparent
        ChartArea3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center
        ChartArea3.BorderColor = System.Drawing.Color.Transparent
        ChartArea3.BorderWidth = 0
        ChartArea3.CursorX.SelectionColor = System.Drawing.Color.Transparent
        ChartArea3.CursorY.SelectionColor = System.Drawing.Color.Transparent
        ChartArea3.InnerPlotPosition.Auto = False
        ChartArea3.InnerPlotPosition.Height = 93.18587!
        ChartArea3.InnerPlotPosition.Width = 98.88297!
        ChartArea3.InnerPlotPosition.X = 0.55851!
        ChartArea3.Name = "ChartArea1"
        ChartArea3.ShadowColor = System.Drawing.Color.Transparent
        Me.ChartTotCuenta.ChartAreas.Add(ChartArea3)
        Me.ChartTotCuenta.Location = New System.Drawing.Point(499, 207)
        Me.ChartTotCuenta.Name = "ChartTotCuenta"
        Me.ChartTotCuenta.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel
        Series3.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Right
        Series3.BorderWidth = 2
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series3.Color = System.Drawing.Color.RoyalBlue
        Series3.CustomProperties = "LabelStyle=Center, IsXAxisQuantitative=True"
        Series3.EmptyPointStyle.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        Series3.EmptyPointStyle.BorderWidth = 0
        Series3.EmptyPointStyle.CustomProperties = "LabelStyle=Left"
        Series3.EmptyPointStyle.IsValueShownAsLabel = True
        Series3.EmptyPointStyle.Label = "ff"
        Series3.EmptyPointStyle.LabelBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Series3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        Series3.IsXValueIndexed = True
        Series3.LabelAngle = 16
        Series3.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        Series3.LabelBorderWidth = 0
        Series3.MarkerBorderWidth = 0
        Series3.MarkerSize = 8
        Series3.Name = "."
        Series3.ShadowColor = System.Drawing.SystemColors.ActiveCaption
        Series3.ShadowOffset = 10
        Series3.SmartLabelStyle.Enabled = False
        Series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Double]
        Series3.YValuesPerPoint = 10
        Me.ChartTotCuenta.Series.Add(Series3)
        Me.ChartTotCuenta.Size = New System.Drawing.Size(1745, 391)
        Me.ChartTotCuenta.TabIndex = 33
        Me.ChartTotCuenta.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault
        '
        'TxtCant_TopBalance
        '
        Me.TxtCant_TopBalance.AutoSize = True
        Me.TxtCant_TopBalance.BackColor = System.Drawing.Color.White
        Me.TxtCant_TopBalance.Font = New System.Drawing.Font("Microsoft YaHei", 16.0!)
        Me.TxtCant_TopBalance.ForeColor = System.Drawing.SystemColors.Highlight
        Me.TxtCant_TopBalance.Location = New System.Drawing.Point(1537, 126)
        Me.TxtCant_TopBalance.Name = "TxtCant_TopBalance"
        Me.TxtCant_TopBalance.Size = New System.Drawing.Size(94, 30)
        Me.TxtCant_TopBalance.TabIndex = 102
        Me.TxtCant_TopBalance.Text = "Balance"
        '
        'TxtTitle_TopBalance
        '
        Me.TxtTitle_TopBalance.AutoSize = True
        Me.TxtTitle_TopBalance.BackColor = System.Drawing.Color.White
        Me.TxtTitle_TopBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTitle_TopBalance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.TxtTitle_TopBalance.Location = New System.Drawing.Point(1539, 101)
        Me.TxtTitle_TopBalance.Name = "TxtTitle_TopBalance"
        Me.TxtTitle_TopBalance.Size = New System.Drawing.Size(27, 13)
        Me.TxtTitle_TopBalance.TabIndex = 101
        Me.TxtTitle_TopBalance.Text = "TOP"
        '
        'Txt_BestRanking
        '
        Me.Txt_BestRanking.AutoSize = True
        Me.Txt_BestRanking.BackColor = System.Drawing.Color.White
        Me.Txt_BestRanking.Font = New System.Drawing.Font("Microsoft YaHei", 16.0!)
        Me.Txt_BestRanking.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Txt_BestRanking.Location = New System.Drawing.Point(823, 126)
        Me.Txt_BestRanking.Name = "Txt_BestRanking"
        Me.Txt_BestRanking.Size = New System.Drawing.Size(94, 30)
        Me.Txt_BestRanking.TabIndex = 104
        Me.Txt_BestRanking.Text = "Balance"
        '
        'TxtTitle_BestRanking
        '
        Me.TxtTitle_BestRanking.AutoSize = True
        Me.TxtTitle_BestRanking.BackColor = System.Drawing.Color.White
        Me.TxtTitle_BestRanking.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTitle_BestRanking.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.TxtTitle_BestRanking.Location = New System.Drawing.Point(825, 101)
        Me.TxtTitle_BestRanking.Name = "TxtTitle_BestRanking"
        Me.TxtTitle_BestRanking.Size = New System.Drawing.Size(82, 13)
        Me.TxtTitle_BestRanking.TabIndex = 103
        Me.TxtTitle_BestRanking.Text = "BEST RANKING"
        '
        'LblPerformance
        '
        Me.LblPerformance.AutoSize = True
        Me.LblPerformance.BackColor = System.Drawing.Color.White
        Me.LblPerformance.Font = New System.Drawing.Font("Microsoft YaHei", 16.0!)
        Me.LblPerformance.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LblPerformance.Location = New System.Drawing.Point(547, 218)
        Me.LblPerformance.Name = "LblPerformance"
        Me.LblPerformance.Size = New System.Drawing.Size(175, 30)
        Me.LblPerformance.TabIndex = 107
        Me.LblPerformance.Text = "PERFORMENCE"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'DepositoTextBox
        '
        Me.DepositoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DepositoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepositoTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.DepositoTextBox.Location = New System.Drawing.Point(112, 417)
        Me.DepositoTextBox.Multiline = True
        Me.DepositoTextBox.Name = "DepositoTextBox"
        Me.DepositoTextBox.Size = New System.Drawing.Size(307, 20)
        Me.DepositoTextBox.TabIndex = 1
        Me.DepositoTextBox.Text = "0"
        Me.DepositoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LblDate
        '
        Me.LblDate.BackColor = System.Drawing.SystemColors.MenuBar
        Me.LblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.LblDate.Location = New System.Drawing.Point(1807, 20)
        Me.LblDate.Name = "LblDate"
        Me.LblDate.Size = New System.Drawing.Size(466, 18)
        Me.LblDate.TabIndex = 1001
        Me.LblDate.Text = "DATE"
        Me.LblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtCant_Promedio
        '
        Me.TxtCant_Promedio.BackColor = System.Drawing.Color.White
        Me.TxtCant_Promedio.Cursor = System.Windows.Forms.Cursors.Default
        Me.TxtCant_Promedio.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!)
        Me.TxtCant_Promedio.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtCant_Promedio.Location = New System.Drawing.Point(478, 248)
        Me.TxtCant_Promedio.Name = "TxtCant_Promedio"
        Me.TxtCant_Promedio.Size = New System.Drawing.Size(255, 21)
        Me.TxtCant_Promedio.TabIndex = 1002
        Me.TxtCant_Promedio.Text = "Balance"
        Me.TxtCant_Promedio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtBuscar
        '
        Me.TxtBuscar.BackColor = System.Drawing.SystemColors.MenuBar
        Me.TxtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.TxtBuscar.Location = New System.Drawing.Point(115, 666)
        Me.TxtBuscar.Multiline = True
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(418, 25)
        Me.TxtBuscar.TabIndex = 1
        Me.TxtBuscar.Text = "SEARCH..."
        '
        'RB_TRANSFERENCIA
        '
        Me.RB_TRANSFERENCIA.AutoSize = True
        Me.RB_TRANSFERENCIA.BackColor = System.Drawing.Color.White
        Me.RB_TRANSFERENCIA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_TRANSFERENCIA.ForeColor = System.Drawing.Color.Green
        Me.RB_TRANSFERENCIA.Location = New System.Drawing.Point(2163, 133)
        Me.RB_TRANSFERENCIA.Name = "RB_TRANSFERENCIA"
        Me.RB_TRANSFERENCIA.Size = New System.Drawing.Size(80, 21)
        Me.RB_TRANSFERENCIA.TabIndex = 1012
        Me.RB_TRANSFERENCIA.TabStop = True
        Me.RB_TRANSFERENCIA.Text = "Transfer"
        Me.RB_TRANSFERENCIA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RB_TRANSFERENCIA.UseVisualStyleBackColor = False
        '
        'ChartTotBancos
        '
        Me.ChartTotBancos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChartTotBancos.BackColor = System.Drawing.Color.Transparent
        Me.ChartTotBancos.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center
        Me.ChartTotBancos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ChartTotBancos.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center
        Me.ChartTotBancos.BorderlineWidth = 0
        Me.ChartTotBancos.BorderSkin.BackColor = System.Drawing.Color.Transparent
        Me.ChartTotBancos.BorderSkin.PageColor = System.Drawing.Color.Gray
        ChartArea4.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal
        ChartArea4.AlignmentStyle = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.Position
        ChartArea4.Area3DStyle.Enable3D = True
        ChartArea4.Area3DStyle.Inclination = 15
        ChartArea4.Area3DStyle.IsRightAngleAxes = False
        ChartArea4.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
        ChartArea4.Area3DStyle.Perspective = 10
        ChartArea4.Area3DStyle.Rotation = 10
        ChartArea4.Area3DStyle.WallWidth = 30
        ChartArea4.AxisX.IsLabelAutoFit = False
        ChartArea4.AxisX.IsMarksNextToAxis = False
        ChartArea4.AxisX.LabelAutoFitMaxFontSize = 8
        ChartArea4.AxisX.LabelAutoFitMinFontSize = 8
        ChartArea4.AxisX.LabelStyle.ForeColor = System.Drawing.Color.DimGray
        ChartArea4.AxisX.LineColor = System.Drawing.Color.Silver
        ChartArea4.AxisX.LogarithmBase = 100.0R
        ChartArea4.AxisX.MajorGrid.Enabled = False
        ChartArea4.AxisX.MajorGrid.Interval = 0R
        ChartArea4.AxisX.MajorGrid.IntervalOffset = 0R
        ChartArea4.AxisX.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.[Auto]
        ChartArea4.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.[Auto]
        ChartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkGray
        ChartArea4.AxisX.MajorTickMark.Enabled = False
        ChartArea4.AxisX.MaximumAutoSize = 60.0!
        ChartArea4.AxisX.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.None
        ChartArea4.AxisX.ScaleBreakStyle.CollapsibleSpaceThreshold = 10
        ChartArea4.AxisX.ScaleBreakStyle.MaxNumberOfBreaks = 1
        ChartArea4.AxisX.ScaleBreakStyle.Spacing = 1.0R
        ChartArea4.AxisX.ScrollBar.Size = 10.0R
        ChartArea4.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Stacked
        ChartArea4.AxisX.TitleAlignment = System.Drawing.StringAlignment.Near
        ChartArea4.AxisX.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea4.AxisX.TitleForeColor = System.Drawing.Color.DarkGray
        ChartArea4.AxisX2.LabelAutoFitMaxFontSize = 7
        ChartArea4.AxisX2.LineColor = System.Drawing.Color.LightGray
        ChartArea4.AxisX2.MajorGrid.Enabled = False
        ChartArea4.AxisX2.MajorTickMark.Enabled = False
        ChartArea4.AxisX2.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated90
        ChartArea4.AxisX2.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        ChartArea4.AxisX2.TitleForeColor = System.Drawing.Color.DarkGray
        ChartArea4.AxisY.Crossing = -1.7976931348623157E+308R
        ChartArea4.AxisY.IsMarksNextToAxis = False
        ChartArea4.AxisY.IsStartedFromZero = False
        ChartArea4.AxisY.LabelAutoFitMaxFontSize = 8
        ChartArea4.AxisY.LabelAutoFitMinFontSize = 8
        ChartArea4.AxisY.LabelStyle.Enabled = False
        ChartArea4.AxisY.LabelStyle.ForeColor = System.Drawing.Color.DimGray
        ChartArea4.AxisY.LineColor = System.Drawing.Color.LightGray
        ChartArea4.AxisY.MajorGrid.Enabled = False
        ChartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea4.AxisY.MajorTickMark.Enabled = False
        ChartArea4.AxisY.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.None
        ChartArea4.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.Transparent
        ChartArea4.AxisY.ScaleBreakStyle.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        ChartArea4.AxisY.ScrollBar.Enabled = False
        ChartArea4.AxisY.ScrollBar.IsPositionedInside = False
        ChartArea4.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal
        ChartArea4.AxisY.TitleForeColor = System.Drawing.Color.DarkGray
        ChartArea4.AxisY2.LabelAutoFitMaxFontSize = 8
        ChartArea4.AxisY2.LineColor = System.Drawing.Color.LightGray
        ChartArea4.AxisY2.MajorGrid.Enabled = False
        ChartArea4.AxisY2.MajorTickMark.Enabled = False
        ChartArea4.AxisY2.TitleForeColor = System.Drawing.Color.DarkGray
        ChartArea4.BackColor = System.Drawing.Color.Transparent
        ChartArea4.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center
        ChartArea4.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top
        ChartArea4.BorderColor = System.Drawing.Color.Transparent
        ChartArea4.BorderWidth = 0
        ChartArea4.CursorX.SelectionColor = System.Drawing.Color.Transparent
        ChartArea4.CursorY.SelectionColor = System.Drawing.Color.Transparent
        ChartArea4.IsSameFontSizeForAllAxes = True
        ChartArea4.Name = "ChartArea1"
        ChartArea4.ShadowColor = System.Drawing.Color.Transparent
        Me.ChartTotBancos.ChartAreas.Add(ChartArea4)
        Me.ChartTotBancos.Location = New System.Drawing.Point(1833, 677)
        Me.ChartTotBancos.Name = "ChartTotBancos"
        Me.ChartTotBancos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel
        Series4.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Right
        Series4.BorderWidth = 2
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Series4.Color = System.Drawing.SystemColors.ControlLight
        Series4.CustomProperties = "LabelStyle=Center, IsXAxisQuantitative=True"
        Series4.EmptyPointStyle.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        Series4.EmptyPointStyle.BorderWidth = 0
        Series4.EmptyPointStyle.CustomProperties = "LabelStyle=Left"
        Series4.EmptyPointStyle.IsValueShownAsLabel = True
        Series4.EmptyPointStyle.Label = "ff"
        Series4.EmptyPointStyle.LabelBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Series4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        Series4.IsXValueIndexed = True
        Series4.LabelAngle = 16
        Series4.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        Series4.LabelBorderWidth = 0
        Series4.MarkerBorderWidth = 0
        Series4.MarkerSize = 8
        Series4.Name = "."
        Series4.ShadowColor = System.Drawing.SystemColors.AppWorkspace
        Series4.ShadowOffset = 10
        Series4.SmartLabelStyle.Enabled = False
        Series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Double]
        Series4.YValuesPerPoint = 10
        Me.ChartTotBancos.Series.Add(Series4)
        Me.ChartTotBancos.Size = New System.Drawing.Size(401, 340)
        Me.ChartTotBancos.TabIndex = 1013
        Me.ChartTotBancos.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(467, 101)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 13)
        Me.Label8.TabIndex = 1014
        Me.Label8.Text = "TOTAL AVAILABLE"
        '
        'Txt_TotalAvailable
        '
        Me.Txt_TotalAvailable.AutoSize = True
        Me.Txt_TotalAvailable.BackColor = System.Drawing.Color.White
        Me.Txt_TotalAvailable.Font = New System.Drawing.Font("Microsoft YaHei", 16.0!)
        Me.Txt_TotalAvailable.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Txt_TotalAvailable.Location = New System.Drawing.Point(465, 126)
        Me.Txt_TotalAvailable.Name = "Txt_TotalAvailable"
        Me.Txt_TotalAvailable.Size = New System.Drawing.Size(94, 30)
        Me.Txt_TotalAvailable.TabIndex = 1015
        Me.Txt_TotalAvailable.Text = "Balance"
        '
        'CMD_UFB_T
        '
        Me.CMD_UFB_T.Location = New System.Drawing.Point(108, 536)
        Me.CMD_UFB_T.Name = "CMD_UFB_T"
        Me.CMD_UFB_T.Size = New System.Drawing.Size(135, 32)
        Me.CMD_UFB_T.TabIndex = 1016
        Me.CMD_UFB_T.Text = "Upload To Firebase"
        Me.CMD_UFB_T.UseVisualStyleBackColor = True
        '
        'VwMovimientosBindingSource
        '
        Me.VwMovimientosBindingSource.DataMember = "vw_Movimientos"
        Me.VwMovimientosBindingSource.DataSource = Me.AHORROSDataSet
        '
        'AHORROSDataSet
        '
        Me.AHORROSDataSet.DataSetName = "AHORROSDataSet"
        Me.AHORROSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BancosTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.CuentasTableAdapter = Nothing
        Me.TableAdapterManager.MovimientosTableAdapter = Nothing
        Me.TableAdapterManager.RandomTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AHORROS.AHORROSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Vw_MovimientosTableAdapter
        '
        Me.Vw_MovimientosTableAdapter.ClearBeforeFill = True
        '
        'CMD_DFB_T
        '
        Me.CMD_DFB_T.Location = New System.Drawing.Point(249, 536)
        Me.CMD_DFB_T.Name = "CMD_DFB_T"
        Me.CMD_DFB_T.Size = New System.Drawing.Size(175, 32)
        Me.CMD_DFB_T.TabIndex = 1017
        Me.CMD_DFB_T.Text = "Download From Firebase"
        Me.CMD_DFB_T.UseVisualStyleBackColor = True
        '
        'DataGridTransactions
        '
        Me.DataGridTransactions.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridTransactions.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridTransactions.Location = New System.Drawing.Point(98, 898)
        Me.DataGridTransactions.Name = "DataGridTransactions"
        Me.DataGridTransactions.RowHeadersVisible = False
        Me.DataGridTransactions.RowHeadersWidth = 51
        Me.DataGridTransactions.Size = New System.Drawing.Size(997, 115)
        Me.DataGridTransactions.TabIndex = 1018
        Me.DataGridTransactions.Visible = False
        '
        'Cmb_Delete
        '
        Me.Cmb_Delete.BackColor = System.Drawing.Color.White
        Me.Cmb_Delete.Image = CType(resources.GetObject("Cmb_Delete.Image"), System.Drawing.Image)
        Me.Cmb_Delete.Location = New System.Drawing.Point(335, 499)
        Me.Cmb_Delete.Name = "Cmb_Delete"
        Me.Cmb_Delete.Size = New System.Drawing.Size(32, 32)
        Me.Cmb_Delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Cmb_Delete.TabIndex = 1011
        Me.Cmb_Delete.TabStop = False
        '
        'txtPorV
        '
        Me.txtPorV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPorV.AutoSize = True
        Me.txtPorV.BackColor = System.Drawing.Color.White
        Me.txtPorV.Font = New System.Drawing.Font("Microsoft YaHei", 16.0!)
        Me.txtPorV.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.txtPorV.Location = New System.Drawing.Point(280, 126)
        Me.txtPorV.Name = "txtPorV"
        Me.txtPorV.Size = New System.Drawing.Size(0, 30)
        Me.txtPorV.TabIndex = 1019
        '
        'txtPorR
        '
        Me.txtPorR.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPorR.AutoSize = True
        Me.txtPorR.BackColor = System.Drawing.Color.White
        Me.txtPorR.Font = New System.Drawing.Font("Microsoft YaHei", 16.0!)
        Me.txtPorR.ForeColor = System.Drawing.Color.Tomato
        Me.txtPorR.Location = New System.Drawing.Point(280, 126)
        Me.txtPorR.Name = "txtPorR"
        Me.txtPorR.Size = New System.Drawing.Size(0, 30)
        Me.txtPorR.TabIndex = 1020
        '
        'txtPorA
        '
        Me.txtPorA.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPorA.AutoSize = True
        Me.txtPorA.BackColor = System.Drawing.Color.White
        Me.txtPorA.Font = New System.Drawing.Font("Microsoft YaHei", 16.0!)
        Me.txtPorA.ForeColor = System.Drawing.Color.Goldenrod
        Me.txtPorA.Location = New System.Drawing.Point(280, 126)
        Me.txtPorA.Name = "txtPorA"
        Me.txtPorA.Size = New System.Drawing.Size(0, 30)
        Me.txtPorA.TabIndex = 1021
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(112, 579)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 1022
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(106, 574)
        Me.ProgressBar1.Maximum = 1
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(316, 3)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 1023
        '
        'txtDiferencia
        '
        Me.txtDiferencia.AutoSize = True
        Me.txtDiferencia.BackColor = System.Drawing.Color.White
        Me.txtDiferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiferencia.ForeColor = System.Drawing.Color.Red
        Me.txtDiferencia.Location = New System.Drawing.Point(335, 101)
        Me.txtDiferencia.Name = "txtDiferencia"
        Me.txtDiferencia.Size = New System.Drawing.Size(0, 13)
        Me.txtDiferencia.TabIndex = 1024
        Me.txtDiferencia.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FormMovimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ClientSize = New System.Drawing.Size(2308, 1095)
        Me.Controls.Add(Me.txtDiferencia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.txtPorA)
        Me.Controls.Add(Me.txtPorR)
        Me.Controls.Add(Me.txtPorV)
        Me.Controls.Add(Me.DataGridTransactions)
        Me.Controls.Add(Me.CMD_DFB_T)
        Me.Controls.Add(Me.CMD_UFB_T)
        Me.Controls.Add(Me.MovimientosDataGridView)
        Me.Controls.Add(Me.Txt_TotalAvailable)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ChartTotBancos)
        Me.Controls.Add(Me.RB_TRANSFERENCIA)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.Cmb_Delete)
        Me.Controls.Add(Me.TxtCant_Promedio)
        Me.Controls.Add(Me.LblDate)
        Me.Controls.Add(Me.DepositoTextBox)
        Me.Controls.Add(Me.LblPerformance)
        Me.Controls.Add(Me.Txt_BestRanking)
        Me.Controls.Add(Me.TxtTitle_BestRanking)
        Me.Controls.Add(Me.TxtCant_TopBalance)
        Me.Controls.Add(Me.TxtTitle_TopBalance)
        Me.Controls.Add(Me.ChartTotCuenta)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(TotalLabel)
        Me.Controls.Add(DepositoLabel)
        Me.Controls.Add(Me.DescripcionComboBox)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.ReferenciaTextBox)
        Me.Controls.Add(ReferenciaLabel)
        Me.Controls.Add(Me.BancoComboBox)
        Me.Controls.Add(BancoLabel)
        Me.Controls.Add(Me.TxtTitle_Type)
        Me.Controls.Add(Me.RB_RETIRO)
        Me.Controls.Add(Me.RB_DEPOSITO)
        Me.Controls.Add(Me.TxtCant_LastTransaction)
        Me.Controls.Add(Me.TxtTitle_LastTransaction)
        Me.Controls.Add(Me.TxtSave)
        Me.Controls.Add(Me.TxtCant_TotalBalance)
        Me.Controls.Add(Me.TxtTitle_TotalBalance)
        Me.Controls.Add(Me.TxtTitle_App)
        Me.Controls.Add(Me.Pn_MenuOptions)
        Me.Controls.Add(Me.ShapeContainer2)
        Me.Name = "FormMovimientos"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        CType(Me.MovimientosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pn_MenuOptions.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartTotCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartTotBancos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwMovimientosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AHORROSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cmb_Delete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AHORROSDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents BancoComboBox As ComboBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionComboBox As ComboBox
    Friend WithEvents RB_DEPOSITO As RadioButton
    Friend WithEvents RB_RETIRO As RadioButton
    Friend WithEvents AHORROSDataSet As AHORROSDataSet
    Friend WithEvents TableAdapterManager As AHORROSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ReferenciaTextBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Pn_MenuOptions As Panel
    Friend WithEvents TxtTitle_App As Label
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape4 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape3 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape2 As PowerPacks.RectangleShape
    Friend WithEvents TxtTitle_TotalBalance As Label
    Friend WithEvents TxtCant_TotalBalance As Label
    Friend WithEvents GuardarMov As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape6 As PowerPacks.RectangleShape
    Friend WithEvents TxtSave As Label
    Friend WithEvents TxtCant_LastTransaction As Label
    Friend WithEvents TxtTitle_LastTransaction As Label
    Friend WithEvents TxtTitle_Type As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents RectangleShape7 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape9 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape8 As PowerPacks.RectangleShape
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents TxtCant_TopBalance As Label
    Friend WithEvents TxtTitle_TopBalance As Label
    Friend WithEvents RectangleShape10 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape11 As PowerPacks.RectangleShape
    Friend WithEvents Txt_BestRanking As Label
    Friend WithEvents TxtTitle_BestRanking As Label
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents OvalShape1 As PowerPacks.OvalShape
    Friend WithEvents LineShape2 As PowerPacks.LineShape
    Friend WithEvents LblPerformance As Label
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Protected WithEvents MovimientosDataGridView As DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents RectangleShape12 As PowerPacks.RectangleShape
    Friend WithEvents DepositoTextBox As TextBox
    Friend WithEvents LblDate As Label
    Friend WithEvents TxtCant_Promedio As Label
    Friend WithEvents Cmb_Delete As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents VwMovimientosBindingSource As BindingSource
    Friend WithEvents Vw_MovimientosTableAdapter As AHORROSDataSetTableAdapters.vw_MovimientosTableAdapter
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents RectangleShape5 As PowerPacks.RectangleShape
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents RB_TRANSFERENCIA As RadioButton
    Friend WithEvents ChartTotCuenta As DataVisualization.Charting.Chart
    Friend WithEvents ChartTotBancos As DataVisualization.Charting.Chart
    Friend WithEvents RectangleShape13 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents Label8 As Label
    Friend WithEvents Txt_TotalAvailable As Label
    Friend WithEvents CMD_UFB_T As Button
    Friend WithEvents AHORROSDataSet1BindingSource As BindingSource
    Friend WithEvents CMD_DFB_T As Button
    Friend WithEvents DataGridTransactions As DataGridView
    Friend WithEvents txtPorV As Label
    Friend WithEvents txtPorR As Label
    Friend WithEvents txtPorA As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents txtDiferencia As Label
End Class
