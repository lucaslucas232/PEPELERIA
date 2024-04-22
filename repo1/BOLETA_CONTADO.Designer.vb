<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BOLETA_CONTADO
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
        Me.LBL_TOTAL = New System.Windows.Forms.Label()
        Me.LBL_REDONDEO = New System.Windows.Forms.Label()
        Me.LBL_SUBTOTAL2 = New System.Windows.Forms.Label()
        Me.LBL_IVA = New System.Windows.Forms.Label()
        Me.LBL_SUBTOTAL = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.CODIGO = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_sus = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BTN_REDONDEAR = New System.Windows.Forms.Button()
        Me.BTN_ELIMINA = New System.Windows.Forms.Button()
        Me.BTN_NUEVO = New System.Windows.Forms.Button()
        Me.BTN_AGREGA = New System.Windows.Forms.Button()
        Me.TXT_CANTIDAD = New System.Windows.Forms.TextBox()
        Me.TXT_PRECIO = New System.Windows.Forms.TextBox()
        Me.TXT_PRODUCTO = New System.Windows.Forms.TextBox()
        Me.TXT_CODIGO = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BTN_CUENTA = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LBL_TOTAL
        '
        Me.LBL_TOTAL.AutoSize = True
        Me.LBL_TOTAL.Location = New System.Drawing.Point(781, 485)
        Me.LBL_TOTAL.Name = "LBL_TOTAL"
        Me.LBL_TOTAL.Size = New System.Drawing.Size(13, 13)
        Me.LBL_TOTAL.TabIndex = 46
        Me.LBL_TOTAL.Text = "0"
        '
        'LBL_REDONDEO
        '
        Me.LBL_REDONDEO.AutoSize = True
        Me.LBL_REDONDEO.Location = New System.Drawing.Point(781, 463)
        Me.LBL_REDONDEO.Name = "LBL_REDONDEO"
        Me.LBL_REDONDEO.Size = New System.Drawing.Size(13, 13)
        Me.LBL_REDONDEO.TabIndex = 45
        Me.LBL_REDONDEO.Text = "0"
        '
        'LBL_SUBTOTAL2
        '
        Me.LBL_SUBTOTAL2.AutoSize = True
        Me.LBL_SUBTOTAL2.Location = New System.Drawing.Point(781, 440)
        Me.LBL_SUBTOTAL2.Name = "LBL_SUBTOTAL2"
        Me.LBL_SUBTOTAL2.Size = New System.Drawing.Size(13, 13)
        Me.LBL_SUBTOTAL2.TabIndex = 44
        Me.LBL_SUBTOTAL2.Text = "0"
        '
        'LBL_IVA
        '
        Me.LBL_IVA.AutoSize = True
        Me.LBL_IVA.Location = New System.Drawing.Point(781, 412)
        Me.LBL_IVA.Name = "LBL_IVA"
        Me.LBL_IVA.Size = New System.Drawing.Size(13, 13)
        Me.LBL_IVA.TabIndex = 43
        Me.LBL_IVA.Text = "0"
        '
        'LBL_SUBTOTAL
        '
        Me.LBL_SUBTOTAL.AutoSize = True
        Me.LBL_SUBTOTAL.Location = New System.Drawing.Point(781, 387)
        Me.LBL_SUBTOTAL.Name = "LBL_SUBTOTAL"
        Me.LBL_SUBTOTAL.Size = New System.Drawing.Size(13, 13)
        Me.LBL_SUBTOTAL.TabIndex = 42
        Me.LBL_SUBTOTAL.Text = "0"
        '
        'ListView1
        '
        Me.ListView1.CheckBoxes = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CODIGO, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListView1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(35, 217)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(629, 208)
        Me.ListView1.TabIndex = 41
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'CODIGO
        '
        Me.CODIGO.Text = "CODIGO"
        Me.CODIGO.Width = 88
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "NOMBRE"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 106
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "PRECIO"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 107
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "CANTIDAD"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 103
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "DESCUENTO"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 119
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "IMPORTE"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 102
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(688, 485)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "TOTAL"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(688, 463)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "REDONDEO"
        '
        'lbl_sus
        '
        Me.lbl_sus.AutoSize = True
        Me.lbl_sus.Location = New System.Drawing.Point(688, 440)
        Me.lbl_sus.Name = "lbl_sus"
        Me.lbl_sus.Size = New System.Drawing.Size(70, 13)
        Me.lbl_sus.TabIndex = 38
        Me.lbl_sus.Text = "SUBTOTAL1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(688, 412)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "IVA 22%"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(688, 387)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "SUBTOTAL:"
        '
        'BTN_REDONDEAR
        '
        Me.BTN_REDONDEAR.Location = New System.Drawing.Point(687, 333)
        Me.BTN_REDONDEAR.Name = "BTN_REDONDEAR"
        Me.BTN_REDONDEAR.Size = New System.Drawing.Size(68, 24)
        Me.BTN_REDONDEAR.TabIndex = 35
        Me.BTN_REDONDEAR.Text = "REDONDEO"
        Me.BTN_REDONDEAR.UseVisualStyleBackColor = True
        '
        'BTN_ELIMINA
        '
        Me.BTN_ELIMINA.Location = New System.Drawing.Point(687, 290)
        Me.BTN_ELIMINA.Name = "BTN_ELIMINA"
        Me.BTN_ELIMINA.Size = New System.Drawing.Size(68, 24)
        Me.BTN_ELIMINA.TabIndex = 34
        Me.BTN_ELIMINA.Text = "ELIMINA"
        Me.BTN_ELIMINA.UseVisualStyleBackColor = True
        '
        'BTN_NUEVO
        '
        Me.BTN_NUEVO.Location = New System.Drawing.Point(687, 253)
        Me.BTN_NUEVO.Name = "BTN_NUEVO"
        Me.BTN_NUEVO.Size = New System.Drawing.Size(68, 24)
        Me.BTN_NUEVO.TabIndex = 33
        Me.BTN_NUEVO.Text = "NUEVO"
        Me.BTN_NUEVO.UseVisualStyleBackColor = True
        '
        'BTN_AGREGA
        '
        Me.BTN_AGREGA.Location = New System.Drawing.Point(687, 217)
        Me.BTN_AGREGA.Name = "BTN_AGREGA"
        Me.BTN_AGREGA.Size = New System.Drawing.Size(68, 24)
        Me.BTN_AGREGA.TabIndex = 32
        Me.BTN_AGREGA.Text = "AGREGAR"
        Me.BTN_AGREGA.UseVisualStyleBackColor = True
        '
        'TXT_CANTIDAD
        '
        Me.TXT_CANTIDAD.Location = New System.Drawing.Point(577, 164)
        Me.TXT_CANTIDAD.Name = "TXT_CANTIDAD"
        Me.TXT_CANTIDAD.Size = New System.Drawing.Size(87, 20)
        Me.TXT_CANTIDAD.TabIndex = 31
        '
        'TXT_PRECIO
        '
        Me.TXT_PRECIO.Location = New System.Drawing.Point(407, 164)
        Me.TXT_PRECIO.Name = "TXT_PRECIO"
        Me.TXT_PRECIO.Size = New System.Drawing.Size(87, 20)
        Me.TXT_PRECIO.TabIndex = 30
        '
        'TXT_PRODUCTO
        '
        Me.TXT_PRODUCTO.Location = New System.Drawing.Point(261, 164)
        Me.TXT_PRODUCTO.Name = "TXT_PRODUCTO"
        Me.TXT_PRODUCTO.Size = New System.Drawing.Size(87, 20)
        Me.TXT_PRODUCTO.TabIndex = 29
        '
        'TXT_CODIGO
        '
        Me.TXT_CODIGO.Location = New System.Drawing.Point(87, 164)
        Me.TXT_CODIGO.Name = "TXT_CODIGO"
        Me.TXT_CODIGO.Size = New System.Drawing.Size(87, 20)
        Me.TXT_CODIGO.TabIndex = 28
        Me.TXT_CODIGO.Text = "1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(514, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "CANTIDAD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(354, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "PRECIO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(187, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "PRODUCTO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "CODIGO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(151, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "SERIE"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(32, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "FECHA:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(242, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 13)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Nro DOC:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(245, 38)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(75, 20)
        Me.TextBox2.TabIndex = 51
        Me.TextBox2.Text = "1"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(154, 38)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(36, 20)
        Me.TextBox3.TabIndex = 52
        Me.TextBox3.Text = "1"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(35, 38)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(84, 20)
        Me.DateTimePicker1.TabIndex = 53
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(32, 99)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 13)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "CUENTA:"
        '
        'BTN_CUENTA
        '
        Me.BTN_CUENTA.Location = New System.Drawing.Point(107, 121)
        Me.BTN_CUENTA.Name = "BTN_CUENTA"
        Me.BTN_CUENTA.Size = New System.Drawing.Size(22, 23)
        Me.BTN_CUENTA.TabIndex = 55
        Me.BTN_CUENTA.Text = "..."
        Me.BTN_CUENTA.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(35, 123)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(66, 20)
        Me.TextBox1.TabIndex = 56
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(146, 123)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(202, 20)
        Me.TextBox4.TabIndex = 57
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(361, 123)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(185, 20)
        Me.TextBox5.TabIndex = 58
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(143, 99)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 13)
        Me.Label13.TabIndex = 59
        Me.Label13.Text = "NOMBRE:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(358, 100)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 13)
        Me.Label14.TabIndex = 60
        Me.Label14.Text = "DOMICILIO"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(561, 123)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(27, 20)
        Me.TextBox6.TabIndex = 61
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(594, 123)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(185, 20)
        Me.TextBox7.TabIndex = 62
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(591, 99)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 13)
        Me.Label15.TabIndex = 63
        Me.Label15.Text = "RUT / C.I."
        '
        'BOLETA_CONTADO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 528)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BTN_CUENTA)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LBL_TOTAL)
        Me.Controls.Add(Me.LBL_REDONDEO)
        Me.Controls.Add(Me.LBL_SUBTOTAL2)
        Me.Controls.Add(Me.LBL_IVA)
        Me.Controls.Add(Me.LBL_SUBTOTAL)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lbl_sus)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BTN_REDONDEAR)
        Me.Controls.Add(Me.BTN_ELIMINA)
        Me.Controls.Add(Me.BTN_NUEVO)
        Me.Controls.Add(Me.BTN_AGREGA)
        Me.Controls.Add(Me.TXT_CANTIDAD)
        Me.Controls.Add(Me.TXT_PRECIO)
        Me.Controls.Add(Me.TXT_PRODUCTO)
        Me.Controls.Add(Me.TXT_CODIGO)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "BOLETA_CONTADO"
        Me.Text = "BOLETA_CONTADO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBL_TOTAL As Windows.Forms.Label
    Friend WithEvents LBL_REDONDEO As Windows.Forms.Label
    Friend WithEvents LBL_SUBTOTAL2 As Windows.Forms.Label
    Friend WithEvents LBL_IVA As Windows.Forms.Label
    Friend WithEvents LBL_SUBTOTAL As Windows.Forms.Label
    Friend WithEvents ListView1 As Windows.Forms.ListView
    Friend WithEvents CODIGO As Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As Windows.Forms.ColumnHeader
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents lbl_sus As Windows.Forms.Label
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents BTN_REDONDEAR As Windows.Forms.Button
    Friend WithEvents BTN_ELIMINA As Windows.Forms.Button
    Friend WithEvents BTN_NUEVO As Windows.Forms.Button
    Friend WithEvents BTN_AGREGA As Windows.Forms.Button
    Friend WithEvents TXT_CANTIDAD As Windows.Forms.TextBox
    Friend WithEvents TXT_PRECIO As Windows.Forms.TextBox
    Friend WithEvents TXT_PRODUCTO As Windows.Forms.TextBox
    Friend WithEvents TXT_CODIGO As Windows.Forms.TextBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents TextBox2 As Windows.Forms.TextBox
    Friend WithEvents TextBox3 As Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents BTN_CUENTA As Windows.Forms.Button
    Friend WithEvents TextBox1 As Windows.Forms.TextBox
    Friend WithEvents TextBox4 As Windows.Forms.TextBox
    Friend WithEvents TextBox5 As Windows.Forms.TextBox
    Friend WithEvents Label13 As Windows.Forms.Label
    Friend WithEvents Label14 As Windows.Forms.Label
    Friend WithEvents TextBox6 As Windows.Forms.TextBox
    Friend WithEvents TextBox7 As Windows.Forms.TextBox
    Friend WithEvents Label15 As Windows.Forms.Label
End Class
