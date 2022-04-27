<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cboMes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_Excel = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btn_ajustar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.dtg_contable = New Guna.UI.WinForms.GunaDataGridView()
        Me.cbo_ano = New Guna.UI.WinForms.GunaComboBox()
        Me.cbo_mes = New Guna.UI.WinForms.GunaComboBox()
        Me.cbo_ds = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.btndiciembre = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.txt_titulo = New Guna.UI.WinForms.GunaLabel()
        Me.btnnoviembre = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnoctubre = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnenero = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnseptiembre = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnfebrero = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnagosto = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.bntmarzo = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnjulio = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnabril = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnjunio = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnmayo = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        CType(Me.dtg_contable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaPanel1.SuspendLayout()
        Me.GunaElipsePanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Excel
        '
        Me.btn_Excel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Excel.Location = New System.Drawing.Point(938, 12)
        Me.btn_Excel.Name = "btn_Excel"
        Me.btn_Excel.Size = New System.Drawing.Size(47, 43)
        Me.btn_Excel.TabIndex = 2
        Me.btn_Excel.Values.Image = Global.Spic.My.Resources.Resources.excel10
        Me.btn_Excel.Values.Text = ""
        '
        'btn_ajustar
        '
        Me.btn_ajustar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_ajustar.Location = New System.Drawing.Point(665, 11)
        Me.btn_ajustar.Name = "btn_ajustar"
        Me.btn_ajustar.Size = New System.Drawing.Size(145, 25)
        Me.btn_ajustar.TabIndex = 3
        Me.btn_ajustar.Values.Text = "Ajustar"
        '
        'dtg_contable
        '
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.dtg_contable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        Me.dtg_contable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtg_contable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtg_contable.BackgroundColor = System.Drawing.Color.White
        Me.dtg_contable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtg_contable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dtg_contable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtg_contable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.dtg_contable.ColumnHeadersHeight = 28
        Me.dtg_contable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(240, Byte), Integer))
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(207, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtg_contable.DefaultCellStyle = DataGridViewCellStyle18
        Me.dtg_contable.EnableHeadersVisualStyles = False
        Me.dtg_contable.GridColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.dtg_contable.Location = New System.Drawing.Point(12, 140)
        Me.dtg_contable.Name = "dtg_contable"
        Me.dtg_contable.RowHeadersVisible = False
        Me.dtg_contable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_contable.Size = New System.Drawing.Size(976, 498)
        Me.dtg_contable.TabIndex = 10
        Me.dtg_contable.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.DeepPurple
        Me.dtg_contable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.dtg_contable.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dtg_contable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dtg_contable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dtg_contable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dtg_contable.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dtg_contable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.dtg_contable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.dtg_contable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtg_contable.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtg_contable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dtg_contable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtg_contable.ThemeStyle.HeaderStyle.Height = 28
        Me.dtg_contable.ThemeStyle.ReadOnly = False
        Me.dtg_contable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dtg_contable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dtg_contable.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dtg_contable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dtg_contable.ThemeStyle.RowsStyle.Height = 22
        Me.dtg_contable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.dtg_contable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'cbo_ano
        '
        Me.cbo_ano.AllowDrop = True
        Me.cbo_ano.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbo_ano.BackColor = System.Drawing.Color.Transparent
        Me.cbo_ano.BaseColor = System.Drawing.Color.White
        Me.cbo_ano.BorderColor = System.Drawing.Color.Silver
        Me.cbo_ano.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbo_ano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_ano.DropDownWidth = 90
        Me.cbo_ano.FocusedColor = System.Drawing.Color.Empty
        Me.cbo_ano.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbo_ano.ForeColor = System.Drawing.Color.Black
        Me.cbo_ano.FormattingEnabled = True
        Me.cbo_ano.Location = New System.Drawing.Point(202, 10)
        Me.cbo_ano.Name = "cbo_ano"
        Me.cbo_ano.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbo_ano.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbo_ano.Size = New System.Drawing.Size(98, 26)
        Me.cbo_ano.TabIndex = 11
        '
        'cbo_mes
        '
        Me.cbo_mes.AllowDrop = True
        Me.cbo_mes.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbo_mes.BackColor = System.Drawing.Color.Transparent
        Me.cbo_mes.BaseColor = System.Drawing.Color.White
        Me.cbo_mes.BorderColor = System.Drawing.Color.Silver
        Me.cbo_mes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbo_mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_mes.FocusedColor = System.Drawing.Color.Empty
        Me.cbo_mes.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbo_mes.ForeColor = System.Drawing.Color.Black
        Me.cbo_mes.FormattingEnabled = True
        Me.cbo_mes.Location = New System.Drawing.Point(878, 46)
        Me.cbo_mes.Name = "cbo_mes"
        Me.cbo_mes.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbo_mes.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbo_mes.Size = New System.Drawing.Size(89, 26)
        Me.cbo_mes.TabIndex = 12
        Me.cbo_mes.Visible = False
        '
        'cbo_ds
        '
        Me.cbo_ds.AllowDrop = True
        Me.cbo_ds.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbo_ds.BackColor = System.Drawing.Color.Transparent
        Me.cbo_ds.BaseColor = System.Drawing.Color.White
        Me.cbo_ds.BorderColor = System.Drawing.Color.Silver
        Me.cbo_ds.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbo_ds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_ds.FocusedColor = System.Drawing.Color.Empty
        Me.cbo_ds.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbo_ds.ForeColor = System.Drawing.Color.Black
        Me.cbo_ds.FormattingEnabled = True
        Me.cbo_ds.Location = New System.Drawing.Point(389, 10)
        Me.cbo_ds.Name = "cbo_ds"
        Me.cbo_ds.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbo_ds.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbo_ds.Size = New System.Drawing.Size(166, 26)
        Me.cbo_ds.TabIndex = 13
        '
        'GunaPanel1
        '
        Me.GunaPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPanel1.BackColor = System.Drawing.Color.White
        Me.GunaPanel1.Controls.Add(Me.btndiciembre)
        Me.GunaPanel1.Controls.Add(Me.txt_titulo)
        Me.GunaPanel1.Controls.Add(Me.btnnoviembre)
        Me.GunaPanel1.Controls.Add(Me.btnoctubre)
        Me.GunaPanel1.Controls.Add(Me.btnenero)
        Me.GunaPanel1.Controls.Add(Me.btn_Excel)
        Me.GunaPanel1.Controls.Add(Me.btnseptiembre)
        Me.GunaPanel1.Controls.Add(Me.btnfebrero)
        Me.GunaPanel1.Controls.Add(Me.btnagosto)
        Me.GunaPanel1.Controls.Add(Me.bntmarzo)
        Me.GunaPanel1.Controls.Add(Me.btnjulio)
        Me.GunaPanel1.Controls.Add(Me.btnabril)
        Me.GunaPanel1.Controls.Add(Me.btnjunio)
        Me.GunaPanel1.Controls.Add(Me.btnmayo)
        Me.GunaPanel1.Location = New System.Drawing.Point(3, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(998, 82)
        Me.GunaPanel1.TabIndex = 14
        '
        'btndiciembre
        '
        Me.btndiciembre.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btndiciembre.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.CalendarDay
        Me.btndiciembre.Location = New System.Drawing.Point(789, 51)
        Me.btndiciembre.Name = "btndiciembre"
        Me.btndiciembre.Size = New System.Drawing.Size(78, 28)
        Me.btndiciembre.TabIndex = 26
        Me.btndiciembre.Values.Text = "Diciembre"
        '
        'txt_titulo
        '
        Me.txt_titulo.AutoSize = True
        Me.txt_titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txt_titulo.Font = New System.Drawing.Font("HP Simplified Hans", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_titulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.txt_titulo.Location = New System.Drawing.Point(8, 7)
        Me.txt_titulo.Name = "txt_titulo"
        Me.txt_titulo.Size = New System.Drawing.Size(187, 27)
        Me.txt_titulo.TabIndex = 0
        Me.txt_titulo.Text = "Ajuste contable"
        '
        'btnnoviembre
        '
        Me.btnnoviembre.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnnoviembre.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.CalendarDay
        Me.btnnoviembre.Location = New System.Drawing.Point(711, 51)
        Me.btnnoviembre.Name = "btnnoviembre"
        Me.btnnoviembre.Size = New System.Drawing.Size(78, 28)
        Me.btnnoviembre.TabIndex = 25
        Me.btnnoviembre.Values.Text = "Noviembre"
        '
        'btnoctubre
        '
        Me.btnoctubre.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnoctubre.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.CalendarDay
        Me.btnoctubre.Location = New System.Drawing.Point(644, 51)
        Me.btnoctubre.Name = "btnoctubre"
        Me.btnoctubre.Size = New System.Drawing.Size(67, 28)
        Me.btnoctubre.TabIndex = 24
        Me.btnoctubre.Values.Text = "Octubre"
        '
        'btnenero
        '
        Me.btnenero.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnenero.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.CalendarDay
        Me.btnenero.Location = New System.Drawing.Point(84, 51)
        Me.btnenero.Name = "btnenero"
        Me.btnenero.Size = New System.Drawing.Size(55, 28)
        Me.btnenero.TabIndex = 15
        Me.btnenero.Values.Text = "Enero"
        '
        'btnseptiembre
        '
        Me.btnseptiembre.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnseptiembre.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.CalendarDay
        Me.btnseptiembre.Location = New System.Drawing.Point(566, 51)
        Me.btnseptiembre.Name = "btnseptiembre"
        Me.btnseptiembre.Size = New System.Drawing.Size(78, 28)
        Me.btnseptiembre.TabIndex = 23
        Me.btnseptiembre.Values.Text = "Septiembre"
        '
        'btnfebrero
        '
        Me.btnfebrero.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnfebrero.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.CalendarDay
        Me.btnfebrero.Location = New System.Drawing.Point(139, 51)
        Me.btnfebrero.Name = "btnfebrero"
        Me.btnfebrero.Size = New System.Drawing.Size(64, 28)
        Me.btnfebrero.TabIndex = 16
        Me.btnfebrero.Values.Text = "Febrero"
        '
        'btnagosto
        '
        Me.btnagosto.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnagosto.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.CalendarDay
        Me.btnagosto.Location = New System.Drawing.Point(502, 51)
        Me.btnagosto.Name = "btnagosto"
        Me.btnagosto.Size = New System.Drawing.Size(64, 28)
        Me.btnagosto.TabIndex = 22
        Me.btnagosto.Values.Text = "Agosto"
        '
        'bntmarzo
        '
        Me.bntmarzo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.bntmarzo.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.BreadCrumb
        Me.bntmarzo.Location = New System.Drawing.Point(203, 51)
        Me.bntmarzo.Name = "bntmarzo"
        Me.bntmarzo.Size = New System.Drawing.Size(61, 28)
        Me.bntmarzo.TabIndex = 17
        Me.bntmarzo.Values.Text = "Marzo"
        '
        'btnjulio
        '
        Me.btnjulio.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnjulio.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.CalendarDay
        Me.btnjulio.Location = New System.Drawing.Point(446, 51)
        Me.btnjulio.Name = "btnjulio"
        Me.btnjulio.Size = New System.Drawing.Size(56, 28)
        Me.btnjulio.TabIndex = 21
        Me.btnjulio.Values.Text = "Julio"
        '
        'btnabril
        '
        Me.btnabril.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnabril.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ButtonSpec
        Me.btnabril.Location = New System.Drawing.Point(264, 51)
        Me.btnabril.Name = "btnabril"
        Me.btnabril.Size = New System.Drawing.Size(59, 28)
        Me.btnabril.TabIndex = 18
        Me.btnabril.Values.Text = "Abril"
        '
        'btnjunio
        '
        Me.btnjunio.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnjunio.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.CalendarDay
        Me.btnjunio.Location = New System.Drawing.Point(388, 51)
        Me.btnjunio.Name = "btnjunio"
        Me.btnjunio.Size = New System.Drawing.Size(58, 28)
        Me.btnjunio.TabIndex = 20
        Me.btnjunio.Values.Text = "Junio"
        '
        'btnmayo
        '
        Me.btnmayo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnmayo.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile
        Me.btnmayo.Location = New System.Drawing.Point(323, 51)
        Me.btnmayo.Name = "btnmayo"
        Me.btnmayo.Size = New System.Drawing.Size(65, 28)
        Me.btnmayo.TabIndex = 19
        Me.btnmayo.Values.Text = "Mayo"
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel2)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel1)
        Me.GunaElipsePanel1.Controls.Add(Me.cbo_ano)
        Me.GunaElipsePanel1.Controls.Add(Me.cbo_ds)
        Me.GunaElipsePanel1.Controls.Add(Me.btn_ajustar)
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(2, 86)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Radius = 1
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(999, 48)
        Me.GunaElipsePanel1.TabIndex = 15
        '
        'GunaLabel2
        '
        Me.GunaLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.White
        Me.GunaLabel2.Location = New System.Drawing.Point(353, 13)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(29, 17)
        Me.GunaLabel2.TabIndex = 14
        Me.GunaLabel2.Text = "DS:"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.White
        Me.GunaLabel1.Location = New System.Drawing.Point(160, 13)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(37, 17)
        Me.GunaLabel1.TabIndex = 12
        Me.GunaLabel1.Text = "AÑO"
        '
        'cboMes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.Controls.Add(Me.GunaElipsePanel1)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.cbo_mes)
        Me.Controls.Add(Me.dtg_contable)
        Me.Name = "cboMes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajuste contable"
        CType(Me.dtg_contable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        Me.GunaElipsePanel1.ResumeLayout(False)
        Me.GunaElipsePanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_Excel As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btn_ajustar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents dtg_contable As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents cbo_ano As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents cbo_mes As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents cbo_ds As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents txt_titulo As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnenero As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnfebrero As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents bntmarzo As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnabril As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnmayo As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnjunio As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnjulio As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnagosto As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnseptiembre As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnoctubre As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnnoviembre As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btndiciembre As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
End Class
