<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsumoTiquete
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsumoTiquete))
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.txt_Cod_orden = New Guna.UI.WinForms.GunaTextBox()
        Me.txt_id_detalle = New Guna.UI.WinForms.GunaTextBox()
        Me.txt_id_rollo = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaAdvenceButton1
        '
        Me.GunaAdvenceButton1.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton1.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton1.BaseColor = System.Drawing.Color.DarkOrange
        Me.GunaAdvenceButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton1.CheckedImage = CType(resources.GetObject("GunaAdvenceButton1.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaAdvenceButton1.ForeColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.Image = CType(resources.GetObject("GunaAdvenceButton1.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(133, 160)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(271, 42)
        Me.GunaAdvenceButton1.TabIndex = 3
        Me.GunaAdvenceButton1.Text = "Realizar consumo del tiquete"
        Me.GunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_Cod_orden
        '
        Me.txt_Cod_orden.BackColor = System.Drawing.Color.Transparent
        Me.txt_Cod_orden.BaseColor = System.Drawing.Color.White
        Me.txt_Cod_orden.BorderColor = System.Drawing.Color.Transparent
        Me.txt_Cod_orden.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Cod_orden.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_Cod_orden.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Cod_orden.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_Cod_orden.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_Cod_orden.Location = New System.Drawing.Point(39, 89)
        Me.txt_Cod_orden.Name = "txt_Cod_orden"
        Me.txt_Cod_orden.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Cod_orden.Radius = 10
        Me.txt_Cod_orden.Size = New System.Drawing.Size(146, 26)
        Me.txt_Cod_orden.TabIndex = 4
        Me.txt_Cod_orden.Tag = "Codigo de Orden."
        Me.txt_Cod_orden.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_id_detalle
        '
        Me.txt_id_detalle.BackColor = System.Drawing.Color.Transparent
        Me.txt_id_detalle.BaseColor = System.Drawing.Color.White
        Me.txt_id_detalle.BorderColor = System.Drawing.Color.Transparent
        Me.txt_id_detalle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_id_detalle.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_id_detalle.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_id_detalle.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_id_detalle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_id_detalle.Location = New System.Drawing.Point(211, 89)
        Me.txt_id_detalle.Name = "txt_id_detalle"
        Me.txt_id_detalle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_id_detalle.Radius = 10
        Me.txt_id_detalle.Size = New System.Drawing.Size(128, 26)
        Me.txt_id_detalle.TabIndex = 5
        Me.txt_id_detalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_id_rollo
        '
        Me.txt_id_rollo.BackColor = System.Drawing.Color.Transparent
        Me.txt_id_rollo.BaseColor = System.Drawing.Color.White
        Me.txt_id_rollo.BorderColor = System.Drawing.Color.Transparent
        Me.txt_id_rollo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_id_rollo.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_id_rollo.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_id_rollo.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_id_rollo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_id_rollo.Location = New System.Drawing.Point(359, 89)
        Me.txt_id_rollo.Name = "txt_id_rollo"
        Me.txt_id_rollo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_id_rollo.Radius = 10
        Me.txt_id_rollo.Size = New System.Drawing.Size(121, 26)
        Me.txt_id_rollo.TabIndex = 6
        Me.txt_id_rollo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackgroundImage = Global.Spic.My.Resources.Resources.backgroung
        Me.GunaPanel1.Controls.Add(Me.GunaLabel3)
        Me.GunaPanel1.Controls.Add(Me.GunaLabel2)
        Me.GunaPanel1.Controls.Add(Me.GunaLabel1)
        Me.GunaPanel1.Location = New System.Drawing.Point(3, -71)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(550, 316)
        Me.GunaPanel1.TabIndex = 7
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.White
        Me.GunaLabel1.Location = New System.Drawing.Point(64, 137)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(92, 17)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Codigo orden"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.White
        Me.GunaLabel2.Location = New System.Drawing.Point(239, 137)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(66, 17)
        Me.GunaLabel2.TabIndex = 1
        Me.GunaLabel2.Text = "Id detalle"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.White
        Me.GunaLabel3.Location = New System.Drawing.Point(370, 137)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(91, 17)
        Me.GunaLabel3.TabIndex = 2
        Me.GunaLabel3.Text = "Numero rollo"
        '
        'FrmConsumoTiquete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(550, 232)
        Me.Controls.Add(Me.txt_id_rollo)
        Me.Controls.Add(Me.txt_id_detalle)
        Me.Controls.Add(Me.txt_Cod_orden)
        Me.Controls.Add(Me.GunaAdvenceButton1)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Name = "FrmConsumoTiquete"
        Me.Text = "Formulario para consumir tiquete de trefilacion"
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents txt_Cod_orden As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txt_id_detalle As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txt_id_rollo As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
End Class
