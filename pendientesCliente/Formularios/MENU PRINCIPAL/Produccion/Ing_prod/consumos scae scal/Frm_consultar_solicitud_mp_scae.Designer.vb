<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_consultar_solicitud_mp_scae
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboFechaIni = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.cboSolicita = New System.Windows.Forms.ComboBox()
        Me.groupTransacciones = New System.Windows.Forms.GroupBox()
        Me.btnCerrarEditResp = New System.Windows.Forms.Button()
        Me.dtgTransacciones = New System.Windows.Forms.DataGridView()
        Me.img_procesar = New System.Windows.Forms.PictureBox()
        Me.dtgConsulta = New System.Windows.Forms.DataGridView()
        Me.colBorrar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colVer = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnActualizar = New System.Windows.Forms.ToolStripButton()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.Toolbar1 = New System.Windows.Forms.ToolStrip()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.chk_devolver = New System.Windows.Forms.CheckBox()
        Me.chkTerminados = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.groupTransacciones.SuspendLayout()
        CType(Me.dtgTransacciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_procesar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Toolbar1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 1029
        Me.Label5.Text = "Inicial:"
        '
        'cboFechaFin
        '
        Me.cboFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cboFechaFin.Location = New System.Drawing.Point(53, 36)
        Me.cboFechaFin.MaxDate = New Date(2054, 5, 13, 0, 0, 0, 0)
        Me.cboFechaFin.Name = "cboFechaFin"
        Me.cboFechaFin.Size = New System.Drawing.Size(91, 20)
        Me.cboFechaFin.TabIndex = 1030
        Me.cboFechaFin.Value = New Date(2014, 5, 13, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 1031
        Me.Label3.Text = "Final:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(410, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 1226
        Me.Label2.Text = "Código"
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(413, 65)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(141, 20)
        Me.txt_codigo.TabIndex = 1225
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(153, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 1217
        Me.Label6.Text = "Solicita"
        '
        'cboFechaIni
        '
        Me.cboFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cboFechaIni.Location = New System.Drawing.Point(53, 14)
        Me.cboFechaIni.MaxDate = New Date(2054, 5, 13, 0, 0, 0, 0)
        Me.cboFechaIni.Name = "cboFechaIni"
        Me.cboFechaIni.Size = New System.Drawing.Size(91, 20)
        Me.cboFechaIni.TabIndex = 1028
        Me.cboFechaIni.Value = New Date(2014, 5, 13, 0, 0, 0, 0)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboFechaIni)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cboFechaFin)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(152, 60)
        Me.GroupBox1.TabIndex = 1216
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rango de fecha"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(563, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 1220
        Me.Label1.Text = "Número:"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(561, 65)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(74, 20)
        Me.txtNumero.TabIndex = 1219
        '
        'cboSolicita
        '
        Me.cboSolicita.FormattingEnabled = True
        Me.cboSolicita.Location = New System.Drawing.Point(156, 65)
        Me.cboSolicita.Name = "cboSolicita"
        Me.cboSolicita.Size = New System.Drawing.Size(246, 21)
        Me.cboSolicita.TabIndex = 1218
        Me.cboSolicita.Text = "Seleccione"
        '
        'groupTransacciones
        '
        Me.groupTransacciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.groupTransacciones.Controls.Add(Me.btnCerrarEditResp)
        Me.groupTransacciones.Controls.Add(Me.dtgTransacciones)
        Me.groupTransacciones.Location = New System.Drawing.Point(53, 97)
        Me.groupTransacciones.Name = "groupTransacciones"
        Me.groupTransacciones.Size = New System.Drawing.Size(577, 352)
        Me.groupTransacciones.TabIndex = 1232
        Me.groupTransacciones.TabStop = False
        Me.groupTransacciones.Text = "Transacciones"
        Me.groupTransacciones.Visible = False
        '
        'btnCerrarEditResp
        '
        Me.btnCerrarEditResp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrarEditResp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarEditResp.ForeColor = System.Drawing.Color.Red
        Me.btnCerrarEditResp.Location = New System.Drawing.Point(551, 6)
        Me.btnCerrarEditResp.Name = "btnCerrarEditResp"
        Me.btnCerrarEditResp.Size = New System.Drawing.Size(26, 23)
        Me.btnCerrarEditResp.TabIndex = 1045
        Me.btnCerrarEditResp.Text = "X"
        Me.btnCerrarEditResp.UseVisualStyleBackColor = True
        '
        'dtgTransacciones
        '
        Me.dtgTransacciones.AllowUserToAddRows = False
        Me.dtgTransacciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgTransacciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgTransacciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgTransacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgTransacciones.Location = New System.Drawing.Point(6, 35)
        Me.dtgTransacciones.Name = "dtgTransacciones"
        Me.dtgTransacciones.ReadOnly = True
        Me.dtgTransacciones.RowHeadersVisible = False
        Me.dtgTransacciones.Size = New System.Drawing.Size(565, 311)
        Me.dtgTransacciones.TabIndex = 0
        '
        'img_procesar
        '
        Me.img_procesar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.img_procesar.Image = Global.Spic.My.Resources.Resources.procesando
        Me.img_procesar.Location = New System.Drawing.Point(28, 97)
        Me.img_procesar.Name = "img_procesar"
        Me.img_procesar.Size = New System.Drawing.Size(633, 185)
        Me.img_procesar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_procesar.TabIndex = 1231
        Me.img_procesar.TabStop = False
        Me.img_procesar.Visible = False
        '
        'dtgConsulta
        '
        Me.dtgConsulta.AllowUserToAddRows = False
        Me.dtgConsulta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgConsulta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgConsulta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colBorrar, Me.colVer})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = "0"
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgConsulta.DefaultCellStyle = DataGridViewCellStyle1
        Me.dtgConsulta.Location = New System.Drawing.Point(11, 93)
        Me.dtgConsulta.Name = "dtgConsulta"
        Me.dtgConsulta.ReadOnly = True
        Me.dtgConsulta.RowHeadersVisible = False
        Me.dtgConsulta.Size = New System.Drawing.Size(684, 363)
        Me.dtgConsulta.TabIndex = 1230
        '
        'colBorrar
        '
        Me.colBorrar.Frozen = True
        Me.colBorrar.HeaderText = ""
        Me.colBorrar.Image = Global.Spic.My.Resources.Resources.x
        Me.colBorrar.Name = "colBorrar"
        Me.colBorrar.ReadOnly = True
        Me.colBorrar.Width = 5
        '
        'colVer
        '
        Me.colVer.Frozen = True
        Me.colVer.HeaderText = ""
        Me.colVer.Image = Global.Spic.My.Resources.Resources.buscar7
        Me.colVer.Name = "colVer"
        Me.colVer.ReadOnly = True
        Me.colVer.Width = 5
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 28)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.Spic.My.Resources.Resources._1349388328_door_in
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(27, 25)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        Me.ToolStripButton1.ToolTipText = "Salir"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.Spic.My.Resources.Resources.ppal3
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(27, 25)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        Me.ToolStripButton2.ToolTipText = "Menú principal"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 28)
        '
        'btnActualizar
        '
        Me.btnActualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnActualizar.Image = Global.Spic.My.Resources.Resources.actualizar
        Me.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(27, 25)
        Me.btnActualizar.Text = "Actualizar"
        '
        'btnNuevo
        '
        Me.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNuevo.Image = Global.Spic.My.Resources.Resources.nuevo
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(27, 25)
        Me.btnNuevo.Text = "Nuevo"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = Global.Spic.My.Resources.Resources.excel10
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(27, 25)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        '
        'Toolbar1
        '
        Me.Toolbar1.AutoSize = False
        Me.Toolbar1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Toolbar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Toolbar1.ImageScalingSize = New System.Drawing.Size(23, 23)
        Me.Toolbar1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator2, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator3, Me.btnActualizar, Me.btnNuevo, Me.ToolStripButton3})
        Me.Toolbar1.Location = New System.Drawing.Point(0, 0)
        Me.Toolbar1.Name = "Toolbar1"
        Me.Toolbar1.Size = New System.Drawing.Size(718, 28)
        Me.Toolbar1.TabIndex = 1214
        Me.Toolbar1.Text = "ToolStrip1"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.GreenYellow
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(548, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(26, 13)
        Me.TextBox1.TabIndex = 1222
        '
        'chk_devolver
        '
        Me.chk_devolver.AutoSize = True
        Me.chk_devolver.BackColor = System.Drawing.Color.Red
        Me.chk_devolver.Location = New System.Drawing.Point(207, 12)
        Me.chk_devolver.Name = "chk_devolver"
        Me.chk_devolver.Size = New System.Drawing.Size(237, 17)
        Me.chk_devolver.TabIndex = 1227
        Me.chk_devolver.Text = "Ordenes para devolver alambrón a bodega 2"
        Me.chk_devolver.UseVisualStyleBackColor = False
        Me.chk_devolver.Visible = False
        '
        'chkTerminados
        '
        Me.chkTerminados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkTerminados.AutoSize = True
        Me.chkTerminados.Location = New System.Drawing.Point(588, 11)
        Me.chkTerminados.Name = "chkTerminados"
        Me.chkTerminados.Size = New System.Drawing.Size(108, 17)
        Me.chkTerminados.TabIndex = 1228
        Me.chkTerminados.Text = "Incluir terminados"
        Me.chkTerminados.UseVisualStyleBackColor = True
        '
        'Frm_consultar_solicitud_mp_scae
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 461)
        Me.Controls.Add(Me.groupTransacciones)
        Me.Controls.Add(Me.img_procesar)
        Me.Controls.Add(Me.dtgConsulta)
        Me.Controls.Add(Me.chkTerminados)
        Me.Controls.Add(Me.chk_devolver)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_codigo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.cboSolicita)
        Me.Controls.Add(Me.Toolbar1)
        Me.Name = "Frm_consultar_solicitud_mp_scae"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar materia prima para scae"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.groupTransacciones.ResumeLayout(False)
        CType(Me.dtgTransacciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_procesar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Toolbar1.ResumeLayout(False)
        Me.Toolbar1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents cboSolicita As System.Windows.Forms.ComboBox
    Friend WithEvents groupTransacciones As System.Windows.Forms.GroupBox
    Friend WithEvents btnCerrarEditResp As System.Windows.Forms.Button
    Friend WithEvents dtgTransacciones As System.Windows.Forms.DataGridView
    Friend WithEvents img_procesar As System.Windows.Forms.PictureBox
    Friend WithEvents dtgConsulta As System.Windows.Forms.DataGridView
    Friend WithEvents colBorrar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colVer As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnActualizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents chk_devolver As System.Windows.Forms.CheckBox
    Friend WithEvents chkTerminados As System.Windows.Forms.CheckBox
End Class
