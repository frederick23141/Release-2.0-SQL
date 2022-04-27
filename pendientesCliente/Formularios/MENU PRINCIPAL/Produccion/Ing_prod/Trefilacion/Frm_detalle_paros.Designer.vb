<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_detalle_paros
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_detalle_paros))
        Me.BunifuPanel1 = New Bunifu.UI.WinForms.BunifuPanel()
        Me.BunifuChartCanvas1 = New Bunifu.Charts.WinForms.BunifuChartCanvas()
        Me.BunifuImageButton1 = New Bunifu.UI.WinForms.BunifuImageButton()
        Me.dtg_detalle_paros = New System.Windows.Forms.DataGridView()
        Me.BunifuImageButton2 = New Bunifu.UI.WinForms.BunifuImageButton()
        Me.BunifuPictureBox2 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.txtiddetalle = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BunifuPictureBox1 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.txtcodigoorden = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2ControlBox3 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BunifuPanel2 = New Bunifu.UI.WinForms.BunifuPanel()
        Me.txtinicio = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel6 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.txttotparos = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel5 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuSeparator2 = New Bunifu.UI.WinForms.BunifuSeparator()
        Me.BunifuLabel3 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuSeparator1 = New Bunifu.UI.WinForms.BunifuSeparator()
        Me.BunifuRadialGaugetiempoparo = New Bunifu.UI.WinForms.BunifuRadialGauge()
        Me.txttiempoplanilla = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel2 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuPanel3 = New Bunifu.UI.WinForms.BunifuPanel()
        Me.BunifuHorizontalBarChart1 = New Bunifu.Charts.WinForms.ChartTypes.BunifuHorizontalBarChart(Me.components)
        Me.Guna2BorderlessForm2 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.txtfinal = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel8 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.txtreproceso = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel10 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.txtalambron = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel12 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.txttransacion = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel14 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuSnackbar1 = New Bunifu.UI.WinForms.BunifuSnackbar(Me.components)
        Me.BunifuPanel1.SuspendLayout()
        CType(Me.dtg_detalle_paros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.BunifuPanel2.SuspendLayout()
        Me.BunifuPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuPanel1
        '
        Me.BunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BunifuPanel1.BackgroundImage = CType(resources.GetObject("BunifuPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuPanel1.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuPanel1.BorderRadius = 40
        Me.BunifuPanel1.BorderThickness = 0
        Me.BunifuPanel1.Controls.Add(Me.BunifuChartCanvas1)
        Me.BunifuPanel1.Controls.Add(Me.BunifuImageButton1)
        Me.BunifuPanel1.Controls.Add(Me.dtg_detalle_paros)
        Me.BunifuPanel1.Controls.Add(Me.BunifuImageButton2)
        Me.BunifuPanel1.Controls.Add(Me.BunifuPictureBox2)
        Me.BunifuPanel1.Controls.Add(Me.txtiddetalle)
        Me.BunifuPanel1.Controls.Add(Me.BunifuPictureBox1)
        Me.BunifuPanel1.Controls.Add(Me.txtcodigoorden)
        Me.BunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuPanel1.Location = New System.Drawing.Point(18, 11)
        Me.BunifuPanel1.Name = "BunifuPanel1"
        Me.BunifuPanel1.ShowBorders = True
        Me.BunifuPanel1.Size = New System.Drawing.Size(736, 479)
        Me.BunifuPanel1.TabIndex = 0
        '
        'BunifuChartCanvas1
        '
        Me.BunifuChartCanvas1.AnimationDuration = 1000
        Me.BunifuChartCanvas1.AnimationType = Bunifu.Charts.WinForms.BunifuChartCanvas.AnimationOptions.easeOutQuart
        Me.BunifuChartCanvas1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BunifuChartCanvas1.CanvasPadding = New System.Windows.Forms.Padding(0, 0, 0, 70)
        Me.BunifuChartCanvas1.ForeColor = System.Drawing.Color.White
        Me.BunifuChartCanvas1.Labels = New String() {"Aseo", "Cambio de programa", "Reviente", "Cambio de hilera", "Soldar MP", "Enredos", "Daño electrico", "Daño mecanico", "Otros", "Alimentacion", "Problemas materia prima", "Abastecimiento", "Capacitación o reunión", "Mantenimiento programado", "Alist. inicio turno", "Ausencia operario"}
        Me.BunifuChartCanvas1.LegendAlignment = Bunifu.Charts.WinForms.BunifuChartCanvas.LegendAlignmentOptions.center
        Me.BunifuChartCanvas1.LegendDisplay = False
        Me.BunifuChartCanvas1.LegendFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuChartCanvas1.LegendForeColor = System.Drawing.Color.White
        Me.BunifuChartCanvas1.LegendFullWidth = True
        Me.BunifuChartCanvas1.LegendPosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.bottom
        Me.BunifuChartCanvas1.LegendRevese = False
        Me.BunifuChartCanvas1.LegendRTL = False
        Me.BunifuChartCanvas1.Location = New System.Drawing.Point(-1, 266)
        Me.BunifuChartCanvas1.Name = "BunifuChartCanvas1"
        Me.BunifuChartCanvas1.ShowXAxis = False
        Me.BunifuChartCanvas1.ShowYAxis = False
        Me.BunifuChartCanvas1.Size = New System.Drawing.Size(587, 197)
        Me.BunifuChartCanvas1.TabIndex = 2222331
        Me.BunifuChartCanvas1.Title = ""
        Me.BunifuChartCanvas1.TitleLineHeight = 1.2R
        Me.BunifuChartCanvas1.TitlePadding = 10
        Me.BunifuChartCanvas1.TitlePosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top
        Me.BunifuChartCanvas1.TooltipBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuChartCanvas1.TooltipFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BunifuChartCanvas1.TooltipForeColor = System.Drawing.Color.White
        Me.BunifuChartCanvas1.TooltipMode = Bunifu.Charts.WinForms.BunifuChartCanvas.TooltipModeOptions.nearest
        Me.BunifuChartCanvas1.TooltipsEnabled = True
        Me.BunifuChartCanvas1.XAxesBeginAtZero = True
        Me.BunifuChartCanvas1.XAxesDrawTicks = True
        Me.BunifuChartCanvas1.XAxesFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BunifuChartCanvas1.XAxesForeColor = System.Drawing.SystemColors.ControlText
        Me.BunifuChartCanvas1.XAxesGridColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuChartCanvas1.XAxesGridLines = False
        Me.BunifuChartCanvas1.XAxesLabel = ""
        Me.BunifuChartCanvas1.XAxesLabelFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BunifuChartCanvas1.XAxesLabelForeColor = System.Drawing.SystemColors.ControlText
        Me.BunifuChartCanvas1.XAxesLineWidth = 1
        Me.BunifuChartCanvas1.XAxesStacked = False
        Me.BunifuChartCanvas1.XAxesZeroLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuChartCanvas1.XAxesZeroLineWidth = 1
        Me.BunifuChartCanvas1.YAxesBeginAtZero = True
        Me.BunifuChartCanvas1.YAxesDrawTicks = True
        Me.BunifuChartCanvas1.YAxesFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BunifuChartCanvas1.YAxesForeColor = System.Drawing.SystemColors.ControlText
        Me.BunifuChartCanvas1.YAxesGridColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuChartCanvas1.YAxesGridLines = False
        Me.BunifuChartCanvas1.YAxesLabel = ""
        Me.BunifuChartCanvas1.YAxesLabelFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BunifuChartCanvas1.YAxesLabelForeColor = System.Drawing.SystemColors.ControlText
        Me.BunifuChartCanvas1.YAxesLineWidth = 1
        Me.BunifuChartCanvas1.YAxesStacked = False
        Me.BunifuChartCanvas1.YAxesZeroLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuChartCanvas1.YAxesZeroLineWidth = 1
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.ActiveImage = Nothing
        Me.BunifuImageButton1.AllowAnimations = True
        Me.BunifuImageButton1.AllowBuffering = False
        Me.BunifuImageButton1.AllowToggling = False
        Me.BunifuImageButton1.AllowZooming = True
        Me.BunifuImageButton1.AllowZoomingOnFocus = False
        Me.BunifuImageButton1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuImageButton1.ErrorImage = CType(resources.GetObject("BunifuImageButton1.ErrorImage"), System.Drawing.Image)
        Me.BunifuImageButton1.FadeWhenInactive = False
        Me.BunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal
        Me.BunifuImageButton1.Image = Global.Spic.My.Resources.Resources.excel
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.ImageLocation = Nothing
        Me.BunifuImageButton1.ImageMargin = 20
        Me.BunifuImageButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.BunifuImageButton1.ImageZoomSize = New System.Drawing.Size(40, 40)
        Me.BunifuImageButton1.InitialImage = CType(resources.GetObject("BunifuImageButton1.InitialImage"), System.Drawing.Image)
        Me.BunifuImageButton1.Location = New System.Drawing.Point(472, 12)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Rotation = 0
        Me.BunifuImageButton1.ShowActiveImage = True
        Me.BunifuImageButton1.ShowCursorChanges = True
        Me.BunifuImageButton1.ShowImageBorders = True
        Me.BunifuImageButton1.ShowSizeMarkers = False
        Me.BunifuImageButton1.Size = New System.Drawing.Size(40, 40)
        Me.BunifuImageButton1.TabIndex = 2222330
        Me.BunifuImageButton1.ToolTipText = ""
        Me.BunifuImageButton1.WaitOnLoad = False
        Me.BunifuImageButton1.Zoom = 20
        Me.BunifuImageButton1.ZoomSpeed = 10
        '
        'dtg_detalle_paros
        '
        Me.dtg_detalle_paros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtg_detalle_paros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtg_detalle_paros.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.dtg_detalle_paros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_detalle_paros.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dtg_detalle_paros.Location = New System.Drawing.Point(0, 67)
        Me.dtg_detalle_paros.Name = "dtg_detalle_paros"
        Me.dtg_detalle_paros.Size = New System.Drawing.Size(735, 193)
        Me.dtg_detalle_paros.TabIndex = 0
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.ActiveImage = Nothing
        Me.BunifuImageButton2.AllowAnimations = True
        Me.BunifuImageButton2.AllowBuffering = False
        Me.BunifuImageButton2.AllowToggling = False
        Me.BunifuImageButton2.AllowZooming = True
        Me.BunifuImageButton2.AllowZoomingOnFocus = False
        Me.BunifuImageButton2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuImageButton2.ErrorImage = CType(resources.GetObject("BunifuImageButton2.ErrorImage"), System.Drawing.Image)
        Me.BunifuImageButton2.FadeWhenInactive = False
        Me.BunifuImageButton2.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.ImageLocation = Nothing
        Me.BunifuImageButton2.ImageMargin = 20
        Me.BunifuImageButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.BunifuImageButton2.ImageZoomSize = New System.Drawing.Size(40, 40)
        Me.BunifuImageButton2.InitialImage = CType(resources.GetObject("BunifuImageButton2.InitialImage"), System.Drawing.Image)
        Me.BunifuImageButton2.Location = New System.Drawing.Point(426, 12)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Rotation = 0
        Me.BunifuImageButton2.ShowActiveImage = True
        Me.BunifuImageButton2.ShowCursorChanges = True
        Me.BunifuImageButton2.ShowImageBorders = True
        Me.BunifuImageButton2.ShowSizeMarkers = False
        Me.BunifuImageButton2.Size = New System.Drawing.Size(40, 40)
        Me.BunifuImageButton2.TabIndex = 2222328
        Me.BunifuImageButton2.ToolTipText = ""
        Me.BunifuImageButton2.WaitOnLoad = False
        Me.BunifuImageButton2.Zoom = 20
        Me.BunifuImageButton2.ZoomSpeed = 10
        '
        'BunifuPictureBox2
        '
        Me.BunifuPictureBox2.AllowFocused = False
        Me.BunifuPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BunifuPictureBox2.AutoSizeHeight = True
        Me.BunifuPictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.BunifuPictureBox2.BorderRadius = 11
        Me.BunifuPictureBox2.Image = CType(resources.GetObject("BunifuPictureBox2.Image"), System.Drawing.Image)
        Me.BunifuPictureBox2.IsCircle = True
        Me.BunifuPictureBox2.Location = New System.Drawing.Point(221, 21)
        Me.BunifuPictureBox2.Name = "BunifuPictureBox2"
        Me.BunifuPictureBox2.Size = New System.Drawing.Size(23, 23)
        Me.BunifuPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BunifuPictureBox2.TabIndex = 3
        Me.BunifuPictureBox2.TabStop = False
        Me.BunifuPictureBox2.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle
        '
        'txtiddetalle
        '
        Me.txtiddetalle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtiddetalle.BackColor = System.Drawing.Color.Transparent
        Me.txtiddetalle.BorderColor = System.Drawing.Color.Transparent
        Me.txtiddetalle.BorderRadius = 15
        Me.txtiddetalle.BorderThickness = 0
        Me.txtiddetalle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtiddetalle.DefaultText = ""
        Me.txtiddetalle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtiddetalle.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtiddetalle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtiddetalle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtiddetalle.FillColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.txtiddetalle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtiddetalle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtiddetalle.ForeColor = System.Drawing.Color.White
        Me.txtiddetalle.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtiddetalle.Location = New System.Drawing.Point(211, 18)
        Me.txtiddetalle.Name = "txtiddetalle"
        Me.txtiddetalle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtiddetalle.PlaceholderText = "Detalle."
        Me.txtiddetalle.SelectedText = ""
        Me.txtiddetalle.Size = New System.Drawing.Size(200, 30)
        Me.txtiddetalle.TabIndex = 2222239
        Me.txtiddetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuPictureBox1
        '
        Me.BunifuPictureBox1.AllowFocused = False
        Me.BunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BunifuPictureBox1.AutoSizeHeight = True
        Me.BunifuPictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.BunifuPictureBox1.BorderRadius = 11
        Me.BunifuPictureBox1.Image = CType(resources.GetObject("BunifuPictureBox1.Image"), System.Drawing.Image)
        Me.BunifuPictureBox1.IsCircle = True
        Me.BunifuPictureBox1.Location = New System.Drawing.Point(11, 21)
        Me.BunifuPictureBox1.Name = "BunifuPictureBox1"
        Me.BunifuPictureBox1.Size = New System.Drawing.Size(23, 23)
        Me.BunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BunifuPictureBox1.TabIndex = 1
        Me.BunifuPictureBox1.TabStop = False
        Me.BunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle
        '
        'txtcodigoorden
        '
        Me.txtcodigoorden.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtcodigoorden.BackColor = System.Drawing.Color.Transparent
        Me.txtcodigoorden.BorderColor = System.Drawing.Color.Transparent
        Me.txtcodigoorden.BorderRadius = 15
        Me.txtcodigoorden.BorderThickness = 0
        Me.txtcodigoorden.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcodigoorden.DefaultText = ""
        Me.txtcodigoorden.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtcodigoorden.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtcodigoorden.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcodigoorden.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcodigoorden.FillColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.txtcodigoorden.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcodigoorden.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigoorden.ForeColor = System.Drawing.Color.White
        Me.txtcodigoorden.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcodigoorden.Location = New System.Drawing.Point(4, 18)
        Me.txtcodigoorden.Name = "txtcodigoorden"
        Me.txtcodigoorden.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcodigoorden.PlaceholderText = "Numero orden."
        Me.txtcodigoorden.SelectedText = ""
        Me.txtcodigoorden.Size = New System.Drawing.Size(200, 30)
        Me.txtcodigoorden.TabIndex = 2222238
        Me.txtcodigoorden.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2ControlBox3
        '
        Me.Guna2ControlBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox3.Animated = True
        Me.Guna2ControlBox3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox3.BorderRadius = 2
        Me.Guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox3.CustomIconSize = 20.0!
        Me.Guna2ControlBox3.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox3.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox3.Location = New System.Drawing.Point(762, 0)
        Me.Guna2ControlBox3.Name = "Guna2ControlBox3"
        Me.Guna2ControlBox3.Size = New System.Drawing.Size(39, 35)
        Me.Guna2ControlBox3.TabIndex = 2222237
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.Animated = True
        Me.Guna2ControlBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.BorderRadius = 2
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox
        Me.Guna2ControlBox2.CustomIconSize = 20.0!
        Me.Guna2ControlBox2.Enabled = False
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(807, 1)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(39, 35)
        Me.Guna2ControlBox2.TabIndex = 2222236
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.Animated = True
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.BorderRadius = 2
        Me.Guna2ControlBox1.CustomIconSize = 20.0!
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(852, 0)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(39, 35)
        Me.Guna2ControlBox1.TabIndex = 2222235
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AllowParentOverrides = False
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel1.Location = New System.Drawing.Point(12, 7)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(191, 17)
        Me.BunifuLabel1.TabIndex = 2222330
        Me.BunifuLabel1.Text = "Detalle de paros de trefilacion."
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.492537!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.69458!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.87821!))
        Me.TableLayoutPanel1.Controls.Add(Me.BunifuPanel1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.BunifuPanel2, 2, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 29)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.577909!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.66075!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.61194!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1051, 507)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'BunifuPanel2
        '
        Me.BunifuPanel2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BunifuPanel2.BackgroundImage = CType(resources.GetObject("BunifuPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuPanel2.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuPanel2.BorderRadius = 3
        Me.BunifuPanel2.BorderThickness = 1
        Me.BunifuPanel2.Controls.Add(Me.txttransacion)
        Me.BunifuPanel2.Controls.Add(Me.BunifuLabel14)
        Me.BunifuPanel2.Controls.Add(Me.txtalambron)
        Me.BunifuPanel2.Controls.Add(Me.BunifuLabel12)
        Me.BunifuPanel2.Controls.Add(Me.txtreproceso)
        Me.BunifuPanel2.Controls.Add(Me.BunifuLabel10)
        Me.BunifuPanel2.Controls.Add(Me.txtfinal)
        Me.BunifuPanel2.Controls.Add(Me.BunifuLabel8)
        Me.BunifuPanel2.Controls.Add(Me.txtinicio)
        Me.BunifuPanel2.Controls.Add(Me.BunifuLabel6)
        Me.BunifuPanel2.Controls.Add(Me.txttotparos)
        Me.BunifuPanel2.Controls.Add(Me.BunifuLabel5)
        Me.BunifuPanel2.Controls.Add(Me.BunifuSeparator2)
        Me.BunifuPanel2.Controls.Add(Me.BunifuLabel3)
        Me.BunifuPanel2.Controls.Add(Me.BunifuSeparator1)
        Me.BunifuPanel2.Controls.Add(Me.BunifuRadialGaugetiempoparo)
        Me.BunifuPanel2.Controls.Add(Me.txttiempoplanilla)
        Me.BunifuPanel2.Controls.Add(Me.BunifuLabel2)
        Me.BunifuPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuPanel2.Location = New System.Drawing.Point(760, 11)
        Me.BunifuPanel2.Name = "BunifuPanel2"
        Me.BunifuPanel2.ShowBorders = True
        Me.BunifuPanel2.Size = New System.Drawing.Size(288, 479)
        Me.BunifuPanel2.TabIndex = 1
        '
        'txtinicio
        '
        Me.txtinicio.AllowParentOverrides = False
        Me.txtinicio.AutoEllipsis = False
        Me.txtinicio.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtinicio.CursorType = System.Windows.Forms.Cursors.Default
        Me.txtinicio.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.txtinicio.Location = New System.Drawing.Point(92, 317)
        Me.txtinicio.Name = "txtinicio"
        Me.txtinicio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtinicio.Size = New System.Drawing.Size(6, 21)
        Me.txtinicio.TabIndex = 2222340
        Me.txtinicio.Text = "-"
        Me.txtinicio.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.txtinicio.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel6
        '
        Me.BunifuLabel6.AllowParentOverrides = False
        Me.BunifuLabel6.AutoEllipsis = False
        Me.BunifuLabel6.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel6.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel6.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel6.Location = New System.Drawing.Point(4, 321)
        Me.BunifuLabel6.Name = "BunifuLabel6"
        Me.BunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel6.Size = New System.Drawing.Size(38, 17)
        Me.BunifuLabel6.TabIndex = 2222339
        Me.BunifuLabel6.Text = "Inicio:"
        Me.BunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'txttotparos
        '
        Me.txttotparos.AllowParentOverrides = False
        Me.txttotparos.AutoEllipsis = False
        Me.txttotparos.Cursor = System.Windows.Forms.Cursors.Default
        Me.txttotparos.CursorType = System.Windows.Forms.Cursors.Default
        Me.txttotparos.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotparos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.txttotparos.Location = New System.Drawing.Point(130, 54)
        Me.txttotparos.Name = "txttotparos"
        Me.txttotparos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txttotparos.Size = New System.Drawing.Size(6, 21)
        Me.txttotparos.TabIndex = 2222338
        Me.txttotparos.Text = "-"
        Me.txttotparos.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.txttotparos.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel5
        '
        Me.BunifuLabel5.AllowParentOverrides = False
        Me.BunifuLabel5.AutoEllipsis = False
        Me.BunifuLabel5.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel5.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel5.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel5.Location = New System.Drawing.Point(4, 58)
        Me.BunifuLabel5.Name = "BunifuLabel5"
        Me.BunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel5.Size = New System.Drawing.Size(104, 17)
        Me.BunifuLabel5.TabIndex = 2222337
        Me.BunifuLabel5.Text = "Tiempo de paros"
        Me.BunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.BackgroundImage = CType(resources.GetObject("BunifuSeparator2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuSeparator2.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Round
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.BunifuSeparator2.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.RightEdgeFaded
        Me.BunifuSeparator2.LineThickness = 1
        Me.BunifuSeparator2.Location = New System.Drawing.Point(-1, 287)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal
        Me.BunifuSeparator2.Size = New System.Drawing.Size(248, 14)
        Me.BunifuSeparator2.TabIndex = 2222336
        '
        'BunifuLabel3
        '
        Me.BunifuLabel3.AllowParentOverrides = False
        Me.BunifuLabel3.AutoEllipsis = False
        Me.BunifuLabel3.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel3.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel3.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel3.Location = New System.Drawing.Point(81, 141)
        Me.BunifuLabel3.Name = "BunifuLabel3"
        Me.BunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel3.Size = New System.Drawing.Size(122, 17)
        Me.BunifuLabel3.TabIndex = 2222335
        Me.BunifuLabel3.Text = "Porcentaje de paros"
        Me.BunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.BackgroundImage = CType(resources.GetObject("BunifuSeparator1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Round
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.BunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.RightEdgeFaded
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(-1, 109)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal
        Me.BunifuSeparator1.Size = New System.Drawing.Size(248, 14)
        Me.BunifuSeparator1.TabIndex = 2222334
        '
        'BunifuRadialGaugetiempoparo
        '
        Me.BunifuRadialGaugetiempoparo.AutoGenerateProgressColorWhenHigh = True
        Me.BunifuRadialGaugetiempoparo.AutoGenerateProgressColorWhenLow = False
        Me.BunifuRadialGaugetiempoparo.BackColor = System.Drawing.Color.Transparent
        Me.BunifuRadialGaugetiempoparo.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.BunifuRadialGaugetiempoparo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.BunifuRadialGaugetiempoparo.LighteningFactor = 10
        Me.BunifuRadialGaugetiempoparo.Location = New System.Drawing.Point(47, 159)
        Me.BunifuRadialGaugetiempoparo.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.BunifuRadialGaugetiempoparo.Maximum = 100
        Me.BunifuRadialGaugetiempoparo.Minimum = 0
        Me.BunifuRadialGaugetiempoparo.Name = "BunifuRadialGaugetiempoparo"
        Me.BunifuRadialGaugetiempoparo.Prefix = ""
        Me.BunifuRadialGaugetiempoparo.ProgressBackColor = System.Drawing.Color.LightBlue
        Me.BunifuRadialGaugetiempoparo.ProgressBgColor = System.Drawing.Color.LightBlue
        Me.BunifuRadialGaugetiempoparo.ProgressCap = Bunifu.UI.WinForms.BunifuRadialGauge.CapStyles.Flat
        Me.BunifuRadialGaugetiempoparo.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.BunifuRadialGaugetiempoparo.ProgressColor1 = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.BunifuRadialGaugetiempoparo.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.BunifuRadialGaugetiempoparo.ProgressColorHigh = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.BunifuRadialGaugetiempoparo.ProgressColorLow = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.BunifuRadialGaugetiempoparo.ProgressHighValueMark = 70
        Me.BunifuRadialGaugetiempoparo.RangeEnd = 100
        Me.BunifuRadialGaugetiempoparo.RangeLabelsColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.BunifuRadialGaugetiempoparo.RangeLabelsFont = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.BunifuRadialGaugetiempoparo.RangeStart = 0
        Me.BunifuRadialGaugetiempoparo.ShowRangeLabels = True
        Me.BunifuRadialGaugetiempoparo.ShowValueLabel = True
        Me.BunifuRadialGaugetiempoparo.Size = New System.Drawing.Size(189, 126)
        Me.BunifuRadialGaugetiempoparo.Suffix = "%"
        Me.BunifuRadialGaugetiempoparo.TabIndex = 2222333
        Me.BunifuRadialGaugetiempoparo.Thickness = 30
        Me.BunifuRadialGaugetiempoparo.Value = 0
        Me.BunifuRadialGaugetiempoparo.ValueByTransition = 0
        Me.BunifuRadialGaugetiempoparo.ValueLabelColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.BunifuRadialGaugetiempoparo.WarningMark = 70
        '
        'txttiempoplanilla
        '
        Me.txttiempoplanilla.AllowParentOverrides = False
        Me.txttiempoplanilla.AutoEllipsis = False
        Me.txttiempoplanilla.Cursor = System.Windows.Forms.Cursors.Default
        Me.txttiempoplanilla.CursorType = System.Windows.Forms.Cursors.Default
        Me.txttiempoplanilla.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttiempoplanilla.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.txttiempoplanilla.Location = New System.Drawing.Point(130, 14)
        Me.txttiempoplanilla.Name = "txttiempoplanilla"
        Me.txttiempoplanilla.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txttiempoplanilla.Size = New System.Drawing.Size(6, 21)
        Me.txttiempoplanilla.TabIndex = 2222332
        Me.txttiempoplanilla.Text = "-"
        Me.txttiempoplanilla.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.txttiempoplanilla.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel2
        '
        Me.BunifuLabel2.AllowParentOverrides = False
        Me.BunifuLabel2.AutoEllipsis = False
        Me.BunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel2.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel2.Location = New System.Drawing.Point(4, 18)
        Me.BunifuLabel2.Name = "BunifuLabel2"
        Me.BunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel2.Size = New System.Drawing.Size(116, 17)
        Me.BunifuLabel2.TabIndex = 2222331
        Me.BunifuLabel2.Text = "Tiempo de planilla"
        Me.BunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuPanel3
        '
        Me.BunifuPanel3.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.BunifuPanel3.BackgroundImage = CType(resources.GetObject("BunifuPanel3.BackgroundImage"), System.Drawing.Image)
        Me.BunifuPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuPanel3.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuPanel3.BorderRadius = 3
        Me.BunifuPanel3.BorderThickness = 1
        Me.BunifuPanel3.Controls.Add(Me.BunifuLabel1)
        Me.BunifuPanel3.Controls.Add(Me.Guna2ControlBox3)
        Me.BunifuPanel3.Controls.Add(Me.Guna2ControlBox1)
        Me.BunifuPanel3.Controls.Add(Me.Guna2ControlBox2)
        Me.BunifuPanel3.Location = New System.Drawing.Point(79, -2)
        Me.BunifuPanel3.Name = "BunifuPanel3"
        Me.BunifuPanel3.ShowBorders = True
        Me.BunifuPanel3.Size = New System.Drawing.Size(906, 31)
        Me.BunifuPanel3.TabIndex = 2
        '
        'BunifuHorizontalBarChart1
        '
        Me.BunifuHorizontalBarChart1.BackgroundColor = CType(resources.GetObject("BunifuHorizontalBarChart1.BackgroundColor"), System.Collections.Generic.List(Of System.Drawing.Color))
        Me.BunifuHorizontalBarChart1.BorderColor = CType(resources.GetObject("BunifuHorizontalBarChart1.BorderColor"), System.Collections.Generic.List(Of System.Drawing.Color))
        Me.BunifuHorizontalBarChart1.BorderSkipped = Nothing
        Me.BunifuHorizontalBarChart1.BorderWidth = 0
        Me.BunifuHorizontalBarChart1.Data = CType(resources.GetObject("BunifuHorizontalBarChart1.Data"), System.Collections.Generic.List(Of Double))
        Me.BunifuHorizontalBarChart1.HoverBackgroundColor = System.Drawing.Color.Empty
        Me.BunifuHorizontalBarChart1.HoverBorderColor = System.Drawing.Color.Empty
        Me.BunifuHorizontalBarChart1.HoverBorderWidth = 0
        Me.BunifuHorizontalBarChart1.Label = "Label here"
        Me.BunifuHorizontalBarChart1.TargetCanvas = Me.BunifuChartCanvas1
        '
        'Guna2BorderlessForm2
        '
        Me.Guna2BorderlessForm2.ContainerControl = Me
        Me.Guna2BorderlessForm2.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm2.TransparentWhileDrag = True
        '
        'txtfinal
        '
        Me.txtfinal.AllowParentOverrides = False
        Me.txtfinal.AutoEllipsis = False
        Me.txtfinal.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtfinal.CursorType = System.Windows.Forms.Cursors.Default
        Me.txtfinal.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfinal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.txtfinal.Location = New System.Drawing.Point(92, 341)
        Me.txtfinal.Name = "txtfinal"
        Me.txtfinal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtfinal.Size = New System.Drawing.Size(6, 21)
        Me.txtfinal.TabIndex = 2222342
        Me.txtfinal.Text = "-"
        Me.txtfinal.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.txtfinal.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel8
        '
        Me.BunifuLabel8.AllowParentOverrides = False
        Me.BunifuLabel8.AutoEllipsis = False
        Me.BunifuLabel8.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel8.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel8.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel8.Location = New System.Drawing.Point(4, 345)
        Me.BunifuLabel8.Name = "BunifuLabel8"
        Me.BunifuLabel8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel8.Size = New System.Drawing.Size(34, 17)
        Me.BunifuLabel8.TabIndex = 2222341
        Me.BunifuLabel8.Text = "Final:"
        Me.BunifuLabel8.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel8.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'txtreproceso
        '
        Me.txtreproceso.AllowParentOverrides = False
        Me.txtreproceso.AutoEllipsis = False
        Me.txtreproceso.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtreproceso.CursorType = System.Windows.Forms.Cursors.Default
        Me.txtreproceso.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtreproceso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.txtreproceso.Location = New System.Drawing.Point(92, 368)
        Me.txtreproceso.Name = "txtreproceso"
        Me.txtreproceso.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtreproceso.Size = New System.Drawing.Size(6, 21)
        Me.txtreproceso.TabIndex = 2222344
        Me.txtreproceso.Text = "-"
        Me.txtreproceso.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.txtreproceso.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel10
        '
        Me.BunifuLabel10.AllowParentOverrides = False
        Me.BunifuLabel10.AutoEllipsis = False
        Me.BunifuLabel10.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel10.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel10.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel10.Location = New System.Drawing.Point(4, 372)
        Me.BunifuLabel10.Name = "BunifuLabel10"
        Me.BunifuLabel10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel10.Size = New System.Drawing.Size(67, 17)
        Me.BunifuLabel10.TabIndex = 2222343
        Me.BunifuLabel10.Text = "Reproceso:"
        Me.BunifuLabel10.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel10.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'txtalambron
        '
        Me.txtalambron.AllowParentOverrides = False
        Me.txtalambron.AutoEllipsis = False
        Me.txtalambron.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtalambron.CursorType = System.Windows.Forms.Cursors.Default
        Me.txtalambron.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtalambron.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.txtalambron.Location = New System.Drawing.Point(92, 395)
        Me.txtalambron.Name = "txtalambron"
        Me.txtalambron.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtalambron.Size = New System.Drawing.Size(6, 21)
        Me.txtalambron.TabIndex = 2222346
        Me.txtalambron.Text = "-"
        Me.txtalambron.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.txtalambron.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel12
        '
        Me.BunifuLabel12.AllowParentOverrides = False
        Me.BunifuLabel12.AutoEllipsis = False
        Me.BunifuLabel12.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel12.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel12.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel12.Location = New System.Drawing.Point(4, 399)
        Me.BunifuLabel12.Name = "BunifuLabel12"
        Me.BunifuLabel12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel12.Size = New System.Drawing.Size(65, 17)
        Me.BunifuLabel12.TabIndex = 2222345
        Me.BunifuLabel12.Text = "Alambrón:"
        Me.BunifuLabel12.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel12.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'txttransacion
        '
        Me.txttransacion.AllowParentOverrides = False
        Me.txttransacion.AutoEllipsis = False
        Me.txttransacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.txttransacion.CursorType = System.Windows.Forms.Cursors.Default
        Me.txttransacion.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttransacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.txttransacion.Location = New System.Drawing.Point(92, 422)
        Me.txttransacion.Name = "txttransacion"
        Me.txttransacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txttransacion.Size = New System.Drawing.Size(6, 21)
        Me.txttransacion.TabIndex = 2222348
        Me.txttransacion.Text = "-"
        Me.txttransacion.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.txttransacion.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel14
        '
        Me.BunifuLabel14.AllowParentOverrides = False
        Me.BunifuLabel14.AutoEllipsis = False
        Me.BunifuLabel14.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel14.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel14.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel14.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel14.Location = New System.Drawing.Point(4, 426)
        Me.BunifuLabel14.Name = "BunifuLabel14"
        Me.BunifuLabel14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel14.Size = New System.Drawing.Size(77, 17)
        Me.BunifuLabel14.TabIndex = 2222347
        Me.BunifuLabel14.Text = "Transacción:"
        Me.BunifuLabel14.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel14.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuSnackbar1
        '
        Me.BunifuSnackbar1.AllowDragging = False
        Me.BunifuSnackbar1.AllowMultipleViews = True
        Me.BunifuSnackbar1.ClickToClose = True
        Me.BunifuSnackbar1.DoubleClickToClose = True
        Me.BunifuSnackbar1.DurationAfterIdle = 3000
        Me.BunifuSnackbar1.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSnackbar1.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSnackbar1.ErrorOptions.ActionBorderRadius = 1
        Me.BunifuSnackbar1.ErrorOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BunifuSnackbar1.ErrorOptions.ActionForeColor = System.Drawing.Color.Black
        Me.BunifuSnackbar1.ErrorOptions.BackColor = System.Drawing.Color.White
        Me.BunifuSnackbar1.ErrorOptions.BorderColor = System.Drawing.Color.White
        Me.BunifuSnackbar1.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BunifuSnackbar1.ErrorOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.BunifuSnackbar1.ErrorOptions.ForeColor = System.Drawing.Color.Black
        Me.BunifuSnackbar1.ErrorOptions.Icon = CType(resources.GetObject("resource.Icon"), System.Drawing.Image)
        Me.BunifuSnackbar1.ErrorOptions.IconLeftMargin = 12
        Me.BunifuSnackbar1.FadeCloseIcon = False
        Me.BunifuSnackbar1.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner
        Me.BunifuSnackbar1.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSnackbar1.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSnackbar1.InformationOptions.ActionBorderRadius = 1
        Me.BunifuSnackbar1.InformationOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BunifuSnackbar1.InformationOptions.ActionForeColor = System.Drawing.Color.Black
        Me.BunifuSnackbar1.InformationOptions.BackColor = System.Drawing.Color.White
        Me.BunifuSnackbar1.InformationOptions.BorderColor = System.Drawing.Color.White
        Me.BunifuSnackbar1.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSnackbar1.InformationOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.BunifuSnackbar1.InformationOptions.ForeColor = System.Drawing.Color.Black
        Me.BunifuSnackbar1.InformationOptions.Icon = CType(resources.GetObject("resource.Icon1"), System.Drawing.Image)
        Me.BunifuSnackbar1.InformationOptions.IconLeftMargin = 12
        Me.BunifuSnackbar1.Margin = 10
        Me.BunifuSnackbar1.MaximumSize = New System.Drawing.Size(0, 0)
        Me.BunifuSnackbar1.MaximumViews = 7
        Me.BunifuSnackbar1.MessageRightMargin = 15
        Me.BunifuSnackbar1.MinimumSize = New System.Drawing.Size(0, 0)
        Me.BunifuSnackbar1.ShowBorders = False
        Me.BunifuSnackbar1.ShowCloseIcon = False
        Me.BunifuSnackbar1.ShowIcon = True
        Me.BunifuSnackbar1.ShowShadows = True
        Me.BunifuSnackbar1.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSnackbar1.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSnackbar1.SuccessOptions.ActionBorderRadius = 1
        Me.BunifuSnackbar1.SuccessOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BunifuSnackbar1.SuccessOptions.ActionForeColor = System.Drawing.Color.Black
        Me.BunifuSnackbar1.SuccessOptions.BackColor = System.Drawing.Color.White
        Me.BunifuSnackbar1.SuccessOptions.BorderColor = System.Drawing.Color.White
        Me.BunifuSnackbar1.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.BunifuSnackbar1.SuccessOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.BunifuSnackbar1.SuccessOptions.ForeColor = System.Drawing.Color.Black
        Me.BunifuSnackbar1.SuccessOptions.Icon = CType(resources.GetObject("resource.Icon2"), System.Drawing.Image)
        Me.BunifuSnackbar1.SuccessOptions.IconLeftMargin = 12
        Me.BunifuSnackbar1.ViewsMargin = 7
        Me.BunifuSnackbar1.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSnackbar1.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSnackbar1.WarningOptions.ActionBorderRadius = 1
        Me.BunifuSnackbar1.WarningOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BunifuSnackbar1.WarningOptions.ActionForeColor = System.Drawing.Color.Black
        Me.BunifuSnackbar1.WarningOptions.BackColor = System.Drawing.Color.White
        Me.BunifuSnackbar1.WarningOptions.BorderColor = System.Drawing.Color.White
        Me.BunifuSnackbar1.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.BunifuSnackbar1.WarningOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.BunifuSnackbar1.WarningOptions.ForeColor = System.Drawing.Color.Black
        Me.BunifuSnackbar1.WarningOptions.Icon = CType(resources.GetObject("resource.Icon3"), System.Drawing.Image)
        Me.BunifuSnackbar1.WarningOptions.IconLeftMargin = 12
        Me.BunifuSnackbar1.ZoomCloseIcon = True
        '
        'Frm_detalle_paros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1051, 536)
        Me.ControlBox = False
        Me.Controls.Add(Me.BunifuPanel3)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_detalle_paros"
        Me.Text = "Frm_detalle_paros"
        Me.BunifuPanel1.ResumeLayout(False)
        CType(Me.dtg_detalle_paros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.BunifuPanel2.ResumeLayout(False)
        Me.BunifuPanel2.PerformLayout()
        Me.BunifuPanel3.ResumeLayout(False)
        Me.BunifuPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuPanel1 As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents BunifuPictureBox2 As Bunifu.UI.WinForms.BunifuPictureBox

    Friend WithEvents BunifuPictureBox1 As Bunifu.UI.WinForms.BunifuPictureBox

    Friend WithEvents Guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents txtiddetalle As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtcodigoorden As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BunifuImageButton2 As Bunifu.UI.WinForms.BunifuImageButton
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents dtg_detalle_paros As DataGridView
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuPanel3 As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BunifuImageButton1 As Bunifu.UI.WinForms.BunifuImageButton
    Friend WithEvents BunifuPanel2 As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents BunifuChartCanvas1 As Bunifu.Charts.WinForms.BunifuChartCanvas
    Friend WithEvents BunifuHorizontalBarChart1 As Bunifu.Charts.WinForms.ChartTypes.BunifuHorizontalBarChart
    Friend WithEvents Guna2BorderlessForm2 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents BunifuLabel2 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents txttiempoplanilla As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuRadialGaugetiempoparo As Bunifu.UI.WinForms.BunifuRadialGauge
    Friend WithEvents BunifuLabel3 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuSeparator1 As Bunifu.UI.WinForms.BunifuSeparator
    Friend WithEvents txttotparos As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel5 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuSeparator2 As Bunifu.UI.WinForms.BunifuSeparator
    Friend WithEvents txtinicio As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel6 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents txttransacion As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel14 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents txtalambron As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel12 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents txtreproceso As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel10 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents txtfinal As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel8 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuSnackbar1 As Bunifu.UI.WinForms.BunifuSnackbar
End Class
