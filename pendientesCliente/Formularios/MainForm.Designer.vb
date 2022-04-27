<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Dim BorderEdges7 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BunifuButton1 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel2 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel3 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel4 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel5 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel6 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel7 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel8 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel9 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel10 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.dateinf = New Bunifu.UI.WinForms.BunifuDatePicker()
        Me.datesup = New Bunifu.UI.WinForms.BunifuDatePicker()
        Me.BunifuSnackbar1 = New Bunifu.UI.WinForms.BunifuSnackbar(Me.components)
        Me.txtpedinf = New System.Windows.Forms.TextBox()
        Me.txtpedsup = New System.Windows.Forms.TextBox()
        Me.txtrefinf = New System.Windows.Forms.TextBox()
        Me.txtrefsup = New System.Windows.Forms.TextBox()
        Me.txtvendinf = New System.Windows.Forms.TextBox()
        Me.txtvendsup = New System.Windows.Forms.TextBox()
        Me.txtnitinf = New System.Windows.Forms.TextBox()
        Me.txtnitsup = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(-1, 343)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(802, 71)
        Me.DataGridView1.TabIndex = 0
        '
        'BunifuButton1
        '
        Me.BunifuButton1.AllowAnimations = True
        Me.BunifuButton1.AllowMouseEffects = True
        Me.BunifuButton1.AllowToggling = False
        Me.BunifuButton1.AnimationSpeed = 200
        Me.BunifuButton1.AutoGenerateColors = False
        Me.BunifuButton1.AutoRoundBorders = False
        Me.BunifuButton1.AutoSizeLeftIcon = True
        Me.BunifuButton1.AutoSizeRightIcon = True
        Me.BunifuButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton1.BackColor1 = System.Drawing.Color.DodgerBlue
        Me.BunifuButton1.BackgroundImage = CType(resources.GetObject("BunifuButton1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.ButtonText = "BunifuButton1"
        Me.BunifuButton1.ButtonTextMarginLeft = 0
        Me.BunifuButton1.ColorContrastOnClick = 45
        Me.BunifuButton1.ColorContrastOnHover = 45
        Me.BunifuButton1.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges7.BottomLeft = True
        BorderEdges7.BottomRight = True
        BorderEdges7.TopLeft = True
        BorderEdges7.TopRight = True
        Me.BunifuButton1.CustomizableEdges = BorderEdges7
        Me.BunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton1.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuButton1.ForeColor = System.Drawing.Color.White
        Me.BunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton1.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton1.IconMarginLeft = 11
        Me.BunifuButton1.IconPadding = 10
        Me.BunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton1.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton1.IconSize = 25
        Me.BunifuButton1.IdleBorderColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton1.IdleBorderRadius = 1
        Me.BunifuButton1.IdleBorderThickness = 1
        Me.BunifuButton1.IdleFillColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton1.IdleIconLeftImage = Nothing
        Me.BunifuButton1.IdleIconRightImage = Nothing
        Me.BunifuButton1.IndicateFocus = False
        Me.BunifuButton1.Location = New System.Drawing.Point(12, 298)
        Me.BunifuButton1.Name = "BunifuButton1"
        Me.BunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton1.OnDisabledState.BorderRadius = 1
        Me.BunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.OnDisabledState.BorderThickness = 1
        Me.BunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton1.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton1.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuButton1.onHoverState.BorderRadius = 1
        Me.BunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.onHoverState.BorderThickness = 1
        Me.BunifuButton1.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuButton1.onHoverState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton1.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton1.onHoverState.IconRightImage = Nothing
        Me.BunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton1.OnIdleState.BorderRadius = 1
        Me.BunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.OnIdleState.BorderThickness = 1
        Me.BunifuButton1.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton1.OnIdleState.IconLeftImage = Nothing
        Me.BunifuButton1.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuButton1.OnPressedState.BorderRadius = 1
        Me.BunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.OnPressedState.BorderThickness = 1
        Me.BunifuButton1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton1.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton1.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton1.Size = New System.Drawing.Size(150, 39)
        Me.BunifuButton1.TabIndex = 1
        Me.BunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton1.TextMarginLeft = 0
        Me.BunifuButton1.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton1.UseDefaultRadiusAndThickness = True
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AllowParentOverrides = False
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuLabel1.ForeColor = System.Drawing.Color.Blue
        Me.BunifuLabel1.Location = New System.Drawing.Point(384, 17)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(109, 15)
        Me.BunifuLabel1.TabIndex = 2
        Me.BunifuLabel1.Text = "Pedido Inferior Nro.?"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel2
        '
        Me.BunifuLabel2.AllowParentOverrides = False
        Me.BunifuLabel2.AutoEllipsis = False
        Me.BunifuLabel2.CursorType = Nothing
        Me.BunifuLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuLabel2.ForeColor = System.Drawing.Color.Blue
        Me.BunifuLabel2.Location = New System.Drawing.Point(378, 47)
        Me.BunifuLabel2.Name = "BunifuLabel2"
        Me.BunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel2.Size = New System.Drawing.Size(115, 15)
        Me.BunifuLabel2.TabIndex = 4
        Me.BunifuLabel2.Text = "Pedido Superior Nro.?"
        Me.BunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel3
        '
        Me.BunifuLabel3.AllowParentOverrides = False
        Me.BunifuLabel3.AutoEllipsis = False
        Me.BunifuLabel3.CursorType = Nothing
        Me.BunifuLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuLabel3.ForeColor = System.Drawing.Color.Blue
        Me.BunifuLabel3.Location = New System.Drawing.Point(389, 77)
        Me.BunifuLabel3.Name = "BunifuLabel3"
        Me.BunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel3.Size = New System.Drawing.Size(104, 15)
        Me.BunifuLabel3.TabIndex = 6
        Me.BunifuLabel3.Text = "Referencia Inferior.?"
        Me.BunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel4
        '
        Me.BunifuLabel4.AllowParentOverrides = False
        Me.BunifuLabel4.AutoEllipsis = False
        Me.BunifuLabel4.CursorType = Nothing
        Me.BunifuLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuLabel4.ForeColor = System.Drawing.Color.Blue
        Me.BunifuLabel4.Location = New System.Drawing.Point(384, 107)
        Me.BunifuLabel4.Name = "BunifuLabel4"
        Me.BunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel4.Size = New System.Drawing.Size(110, 15)
        Me.BunifuLabel4.TabIndex = 8
        Me.BunifuLabel4.Text = "Referencia Superior.?"
        Me.BunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel5
        '
        Me.BunifuLabel5.AllowParentOverrides = False
        Me.BunifuLabel5.AutoEllipsis = False
        Me.BunifuLabel5.CursorType = Nothing
        Me.BunifuLabel5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuLabel5.ForeColor = System.Drawing.Color.Blue
        Me.BunifuLabel5.Location = New System.Drawing.Point(394, 137)
        Me.BunifuLabel5.Name = "BunifuLabel5"
        Me.BunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel5.Size = New System.Drawing.Size(100, 15)
        Me.BunifuLabel5.TabIndex = 10
        Me.BunifuLabel5.Text = "Vendedor Inferior.?"
        Me.BunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel6
        '
        Me.BunifuLabel6.AllowParentOverrides = False
        Me.BunifuLabel6.AutoEllipsis = False
        Me.BunifuLabel6.CursorType = Nothing
        Me.BunifuLabel6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuLabel6.ForeColor = System.Drawing.Color.Blue
        Me.BunifuLabel6.Location = New System.Drawing.Point(388, 167)
        Me.BunifuLabel6.Name = "BunifuLabel6"
        Me.BunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel6.Size = New System.Drawing.Size(106, 15)
        Me.BunifuLabel6.TabIndex = 12
        Me.BunifuLabel6.Text = "Vendedor Superior.?"
        Me.BunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel7
        '
        Me.BunifuLabel7.AllowParentOverrides = False
        Me.BunifuLabel7.AutoEllipsis = False
        Me.BunifuLabel7.CursorType = Nothing
        Me.BunifuLabel7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuLabel7.ForeColor = System.Drawing.Color.Blue
        Me.BunifuLabel7.Location = New System.Drawing.Point(429, 197)
        Me.BunifuLabel7.Name = "BunifuLabel7"
        Me.BunifuLabel7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel7.Size = New System.Drawing.Size(65, 15)
        Me.BunifuLabel7.TabIndex = 14
        Me.BunifuLabel7.Text = "Nit Inferior.?"
        Me.BunifuLabel7.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel7.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel8
        '
        Me.BunifuLabel8.AllowParentOverrides = False
        Me.BunifuLabel8.AutoEllipsis = False
        Me.BunifuLabel8.CursorType = Nothing
        Me.BunifuLabel8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuLabel8.ForeColor = System.Drawing.Color.Blue
        Me.BunifuLabel8.Location = New System.Drawing.Point(423, 227)
        Me.BunifuLabel8.Name = "BunifuLabel8"
        Me.BunifuLabel8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel8.Size = New System.Drawing.Size(71, 15)
        Me.BunifuLabel8.TabIndex = 16
        Me.BunifuLabel8.Text = "Nit Superior.?"
        Me.BunifuLabel8.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel8.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel9
        '
        Me.BunifuLabel9.AllowParentOverrides = False
        Me.BunifuLabel9.AutoEllipsis = False
        Me.BunifuLabel9.CursorType = Nothing
        Me.BunifuLabel9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuLabel9.ForeColor = System.Drawing.Color.Blue
        Me.BunifuLabel9.Location = New System.Drawing.Point(413, 262)
        Me.BunifuLabel9.Name = "BunifuLabel9"
        Me.BunifuLabel9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel9.Size = New System.Drawing.Size(80, 15)
        Me.BunifuLabel9.TabIndex = 18
        Me.BunifuLabel9.Text = "Fecha Inferior.?"
        Me.BunifuLabel9.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel9.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel10
        '
        Me.BunifuLabel10.AllowParentOverrides = False
        Me.BunifuLabel10.AutoEllipsis = False
        Me.BunifuLabel10.CursorType = Nothing
        Me.BunifuLabel10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuLabel10.ForeColor = System.Drawing.Color.Blue
        Me.BunifuLabel10.Location = New System.Drawing.Point(408, 296)
        Me.BunifuLabel10.Name = "BunifuLabel10"
        Me.BunifuLabel10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel10.Size = New System.Drawing.Size(86, 15)
        Me.BunifuLabel10.TabIndex = 20
        Me.BunifuLabel10.Text = "Fecha Superior.?"
        Me.BunifuLabel10.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel10.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'dateinf
        '
        Me.dateinf.BackColor = System.Drawing.Color.White
        Me.dateinf.BorderRadius = 1
        Me.dateinf.CalendarTrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.dateinf.Color = System.Drawing.Color.Silver
        Me.dateinf.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin
        Me.dateinf.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left
        Me.dateinf.DisabledColor = System.Drawing.Color.Gray
        Me.dateinf.DisplayWeekNumbers = False
        Me.dateinf.DPHeight = 0
        Me.dateinf.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dateinf.FillDatePicker = False
        Me.dateinf.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dateinf.ForeColor = System.Drawing.Color.Black
        Me.dateinf.Icon = CType(resources.GetObject("dateinf.Icon"), System.Drawing.Image)
        Me.dateinf.IconColor = System.Drawing.Color.Black
        Me.dateinf.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right
        Me.dateinf.LeftTextMargin = 5
        Me.dateinf.Location = New System.Drawing.Point(510, 252)
        Me.dateinf.MinimumSize = New System.Drawing.Size(4, 32)
        Me.dateinf.Name = "dateinf"
        Me.dateinf.Size = New System.Drawing.Size(200, 32)
        Me.dateinf.TabIndex = 22
        '
        'datesup
        '
        Me.datesup.BackColor = System.Drawing.Color.White
        Me.datesup.BorderRadius = 1
        Me.datesup.CalendarTrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.datesup.Color = System.Drawing.Color.Silver
        Me.datesup.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin
        Me.datesup.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left
        Me.datesup.DisabledColor = System.Drawing.Color.Gray
        Me.datesup.DisplayWeekNumbers = False
        Me.datesup.DPHeight = 0
        Me.datesup.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.datesup.FillDatePicker = False
        Me.datesup.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.datesup.ForeColor = System.Drawing.Color.Black
        Me.datesup.Icon = CType(resources.GetObject("datesup.Icon"), System.Drawing.Image)
        Me.datesup.IconColor = System.Drawing.Color.Black
        Me.datesup.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right
        Me.datesup.LeftTextMargin = 5
        Me.datesup.Location = New System.Drawing.Point(510, 290)
        Me.datesup.MinimumSize = New System.Drawing.Size(4, 32)
        Me.datesup.Name = "datesup"
        Me.datesup.Size = New System.Drawing.Size(200, 32)
        Me.datesup.TabIndex = 23
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
        'txtpedinf
        '
        Me.txtpedinf.Location = New System.Drawing.Point(510, 17)
        Me.txtpedinf.Name = "txtpedinf"
        Me.txtpedinf.Size = New System.Drawing.Size(200, 20)
        Me.txtpedinf.TabIndex = 24
        Me.txtpedinf.Text = "1"
        '
        'txtpedsup
        '
        Me.txtpedsup.Location = New System.Drawing.Point(510, 47)
        Me.txtpedsup.Name = "txtpedsup"
        Me.txtpedsup.Size = New System.Drawing.Size(200, 20)
        Me.txtpedsup.TabIndex = 25
        Me.txtpedsup.Text = "999999999"
        '
        'txtrefinf
        '
        Me.txtrefinf.Location = New System.Drawing.Point(510, 77)
        Me.txtrefinf.Name = "txtrefinf"
        Me.txtrefinf.Size = New System.Drawing.Size(200, 20)
        Me.txtrefinf.TabIndex = 26
        Me.txtrefinf.Text = "1"
        '
        'txtrefsup
        '
        Me.txtrefsup.Location = New System.Drawing.Point(510, 107)
        Me.txtrefsup.Name = "txtrefsup"
        Me.txtrefsup.Size = New System.Drawing.Size(200, 20)
        Me.txtrefsup.TabIndex = 27
        Me.txtrefsup.Text = "ZZZZZZZZZZZ"
        '
        'txtvendinf
        '
        Me.txtvendinf.Location = New System.Drawing.Point(510, 137)
        Me.txtvendinf.Name = "txtvendinf"
        Me.txtvendinf.Size = New System.Drawing.Size(200, 20)
        Me.txtvendinf.TabIndex = 28
        Me.txtvendinf.Text = "1"
        '
        'txtvendsup
        '
        Me.txtvendsup.Location = New System.Drawing.Point(510, 167)
        Me.txtvendsup.Name = "txtvendsup"
        Me.txtvendsup.Size = New System.Drawing.Size(200, 20)
        Me.txtvendsup.TabIndex = 29
        Me.txtvendsup.Text = "999999999"
        '
        'txtnitinf
        '
        Me.txtnitinf.Location = New System.Drawing.Point(510, 197)
        Me.txtnitinf.Name = "txtnitinf"
        Me.txtnitinf.Size = New System.Drawing.Size(200, 20)
        Me.txtnitinf.TabIndex = 30
        Me.txtnitinf.Text = "1"
        '
        'txtnitsup
        '
        Me.txtnitsup.Location = New System.Drawing.Point(510, 226)
        Me.txtnitsup.Name = "txtnitsup"
        Me.txtnitsup.Size = New System.Drawing.Size(200, 20)
        Me.txtnitsup.TabIndex = 31
        Me.txtnitsup.Text = "999999999"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(800, 411)
        Me.Controls.Add(Me.txtnitsup)
        Me.Controls.Add(Me.txtnitinf)
        Me.Controls.Add(Me.txtvendsup)
        Me.Controls.Add(Me.txtvendinf)
        Me.Controls.Add(Me.txtrefsup)
        Me.Controls.Add(Me.txtrefinf)
        Me.Controls.Add(Me.txtpedsup)
        Me.Controls.Add(Me.txtpedinf)
        Me.Controls.Add(Me.datesup)
        Me.Controls.Add(Me.dateinf)
        Me.Controls.Add(Me.BunifuLabel10)
        Me.Controls.Add(Me.BunifuLabel9)
        Me.Controls.Add(Me.BunifuLabel8)
        Me.Controls.Add(Me.BunifuLabel7)
        Me.Controls.Add(Me.BunifuLabel6)
        Me.Controls.Add(Me.BunifuLabel5)
        Me.Controls.Add(Me.BunifuLabel4)
        Me.Controls.Add(Me.BunifuLabel3)
        Me.Controls.Add(Me.BunifuLabel2)
        Me.Controls.Add(Me.BunifuLabel1)
        Me.Controls.Add(Me.BunifuButton1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "MainForm"
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BunifuButton1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    ' Friend WithEvents txtpedinf As Siticone.Desktop.UI.Winforms.SiticoneTextBox
    ' Friend WithEvents txtpedsup As Siticone.Desktop.UI.Winforms.SiticoneTextBox
    Friend WithEvents BunifuLabel2 As Bunifu.UI.WinForms.BunifuLabel
    ' Friend WithEvents txtrefinf As Siticone.Desktop.UI.Winforms.SiticoneTextBox
    Friend WithEvents BunifuLabel3 As Bunifu.UI.WinForms.BunifuLabel
    'Friend WithEvents txtrefsup As Siticone.Desktop.UI.Winforms.SiticoneTextBox
    Friend WithEvents BunifuLabel4 As Bunifu.UI.WinForms.BunifuLabel
    'Friend WithEvents txtevndinf As Siticone.Desktop.UI.Winforms.SiticoneTextBox
    Friend WithEvents BunifuLabel5 As Bunifu.UI.WinForms.BunifuLabel
    'Friend WithEvents txtvendsup As Siticone.Desktop.UI.Winforms.SiticoneTextBox
    Friend WithEvents BunifuLabel6 As Bunifu.UI.WinForms.BunifuLabel
    'Friend WithEvents txtnitinf As Siticone.Desktop.UI.Winforms.SiticoneTextBox
    Friend WithEvents BunifuLabel7 As Bunifu.UI.WinForms.BunifuLabel
    'Friend WithEvents txtnitsup As Siticone.Desktop.UI.Winforms.SiticoneTextBox
    Friend WithEvents BunifuLabel8 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel9 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel10 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents dateinf As Bunifu.UI.WinForms.BunifuDatePicker
    Friend WithEvents datesup As Bunifu.UI.WinForms.BunifuDatePicker
    Friend WithEvents BunifuSnackbar1 As Bunifu.UI.WinForms.BunifuSnackbar
    Friend WithEvents txtpedinf As TextBox
    Friend WithEvents txtpedsup As TextBox
    Friend WithEvents txtrefinf As TextBox
    Friend WithEvents txtrefsup As TextBox
    Friend WithEvents txtvendinf As TextBox
    Friend WithEvents txtvendsup As TextBox
    Friend WithEvents txtnitinf As TextBox
    Friend WithEvents txtnitsup As TextBox
End Class
