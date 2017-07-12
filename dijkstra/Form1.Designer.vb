<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_n_nodos = New System.Windows.Forms.TextBox()
        Me.txt_log = New System.Windows.Forms.RichTextBox()
        Me.btn_cargar = New System.Windows.Forms.Button()
        Me.btn_dijkstra = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.combo_A = New System.Windows.Forms.ComboBox()
        Me.combo_Z = New System.Windows.Forms.ComboBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_prim = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_salida_prim = New System.Windows.Forms.RichTextBox()
        Me.salida_dijkstra = New System.Windows.Forms.Panel()
        Me.txt_ruta = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_prim_grafico = New System.Windows.Forms.Button()
        Me.combo_Z_grafico = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.combo_A_grafico = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dijkstra_grafico = New System.Windows.Forms.Button()
        Me.panel_matriz = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.grafica = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "N° de nodos"
        '
        'txt_n_nodos
        '
        Me.txt_n_nodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_n_nodos.Location = New System.Drawing.Point(78, 26)
        Me.txt_n_nodos.Name = "txt_n_nodos"
        Me.txt_n_nodos.Size = New System.Drawing.Size(142, 26)
        Me.txt_n_nodos.TabIndex = 3
        '
        'txt_log
        '
        Me.txt_log.Enabled = False
        Me.txt_log.ForeColor = System.Drawing.Color.Navy
        Me.txt_log.Location = New System.Drawing.Point(242, 111)
        Me.txt_log.Name = "txt_log"
        Me.txt_log.Size = New System.Drawing.Size(252, 252)
        Me.txt_log.TabIndex = 31
        Me.txt_log.Text = ""
        Me.txt_log.WordWrap = False
        '
        'btn_cargar
        '
        Me.btn_cargar.Location = New System.Drawing.Point(226, 26)
        Me.btn_cargar.Name = "btn_cargar"
        Me.btn_cargar.Size = New System.Drawing.Size(115, 26)
        Me.btn_cargar.TabIndex = 32
        Me.btn_cargar.Text = "Cargar"
        Me.btn_cargar.UseVisualStyleBackColor = True
        '
        'btn_dijkstra
        '
        Me.btn_dijkstra.Location = New System.Drawing.Point(149, 19)
        Me.btn_dijkstra.Name = "btn_dijkstra"
        Me.btn_dijkstra.Size = New System.Drawing.Size(109, 29)
        Me.btn_dijkstra.TabIndex = 33
        Me.btn_dijkstra.Text = "Dijkstra"
        Me.btn_dijkstra.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(373, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "A"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(373, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Z"
        '
        'combo_A
        '
        Me.combo_A.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_A.FormattingEnabled = True
        Me.combo_A.Location = New System.Drawing.Point(393, 19)
        Me.combo_A.Name = "combo_A"
        Me.combo_A.Size = New System.Drawing.Size(59, 28)
        Me.combo_A.TabIndex = 37
        '
        'combo_Z
        '
        Me.combo_Z.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_Z.FormattingEnabled = True
        Me.combo_Z.Location = New System.Drawing.Point(393, 51)
        Me.combo_Z.Name = "combo_Z"
        Me.combo_Z.Size = New System.Drawing.Size(59, 28)
        Me.combo_Z.TabIndex = 38
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 636)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1020, 22)
        Me.StatusStrip1.TabIndex = 39
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.txt_n_nodos)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.combo_A)
        Me.GroupBox1.Controls.Add(Me.combo_Z)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btn_cargar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(500, 87)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parametros"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(299, 58)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(42, 22)
        Me.Button3.TabIndex = 44
        Me.Button3.Text = "test"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_prim)
        Me.GroupBox2.Controls.Add(Me.btn_dijkstra)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 189)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(500, 58)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Acciones"
        '
        'btn_prim
        '
        Me.btn_prim.Location = New System.Drawing.Point(264, 19)
        Me.btn_prim.Name = "btn_prim"
        Me.btn_prim.Size = New System.Drawing.Size(110, 28)
        Me.btn_prim.TabIndex = 39
        Me.btn_prim.Text = "Prim"
        Me.btn_prim.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txt_log)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txt_salida_prim)
        Me.GroupBox3.Controls.Add(Me.salida_dijkstra)
        Me.GroupBox3.Controls.Add(Me.txt_ruta)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 253)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(500, 378)
        Me.GroupBox3.TabIndex = 42
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Salida"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(197, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Log"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Prim"
        '
        'txt_salida_prim
        '
        Me.txt_salida_prim.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_salida_prim.Location = New System.Drawing.Point(68, 111)
        Me.txt_salida_prim.Name = "txt_salida_prim"
        Me.txt_salida_prim.Size = New System.Drawing.Size(115, 252)
        Me.txt_salida_prim.TabIndex = 6
        Me.txt_salida_prim.Text = ""
        Me.txt_salida_prim.WordWrap = False
        '
        'salida_dijkstra
        '
        Me.salida_dijkstra.Location = New System.Drawing.Point(68, 19)
        Me.salida_dijkstra.Name = "salida_dijkstra"
        Me.salida_dijkstra.Size = New System.Drawing.Size(429, 54)
        Me.salida_dijkstra.TabIndex = 5
        '
        'txt_ruta
        '
        Me.txt_ruta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ruta.Location = New System.Drawing.Point(68, 79)
        Me.txt_ruta.Name = "txt_ruta"
        Me.txt_ruta.ReadOnly = True
        Me.txt_ruta.Size = New System.Drawing.Size(429, 26)
        Me.txt_ruta.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Ruta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Dijkstra"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(507, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(513, 636)
        Me.Panel1.TabIndex = 43
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btn_prim_grafico)
        Me.GroupBox4.Controls.Add(Me.combo_Z_grafico)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.combo_A_grafico)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.dijkstra_grafico)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(500, 87)
        Me.GroupBox4.TabIndex = 43
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Dibujo"
        '
        'btn_prim_grafico
        '
        Me.btn_prim_grafico.Location = New System.Drawing.Point(228, 20)
        Me.btn_prim_grafico.Name = "btn_prim_grafico"
        Me.btn_prim_grafico.Size = New System.Drawing.Size(145, 33)
        Me.btn_prim_grafico.TabIndex = 41
        Me.btn_prim_grafico.Text = "Prim"
        Me.btn_prim_grafico.UseVisualStyleBackColor = True
        '
        'combo_Z_grafico
        '
        Me.combo_Z_grafico.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_Z_grafico.FormattingEnabled = True
        Me.combo_Z_grafico.Location = New System.Drawing.Point(132, 53)
        Me.combo_Z_grafico.Name = "combo_Z_grafico"
        Me.combo_Z_grafico.Size = New System.Drawing.Size(59, 28)
        Me.combo_Z_grafico.TabIndex = 40
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(112, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(14, 13)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Z"
        '
        'combo_A_grafico
        '
        Me.combo_A_grafico.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_A_grafico.FormattingEnabled = True
        Me.combo_A_grafico.Location = New System.Drawing.Point(47, 53)
        Me.combo_A_grafico.Name = "combo_A_grafico"
        Me.combo_A_grafico.Size = New System.Drawing.Size(59, 28)
        Me.combo_A_grafico.TabIndex = 38
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(14, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "A"
        '
        'dijkstra_grafico
        '
        Me.dijkstra_grafico.Location = New System.Drawing.Point(47, 19)
        Me.dijkstra_grafico.Name = "dijkstra_grafico"
        Me.dijkstra_grafico.Size = New System.Drawing.Size(144, 27)
        Me.dijkstra_grafico.TabIndex = 0
        Me.dijkstra_grafico.Text = "Dijkstra"
        Me.dijkstra_grafico.UseVisualStyleBackColor = True
        '
        'panel_matriz
        '
        Me.panel_matriz.AutoScroll = True
        Me.panel_matriz.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_matriz.Location = New System.Drawing.Point(0, 432)
        Me.panel_matriz.Name = "panel_matriz"
        Me.panel_matriz.Size = New System.Drawing.Size(507, 204)
        Me.panel_matriz.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.grafica)
        Me.Panel2.Controls.Add(Me.panel_matriz)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(507, 636)
        Me.Panel2.TabIndex = 44
        '
        'grafica
        '
        Me.grafica.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grafica.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grafica.Location = New System.Drawing.Point(0, 0)
        Me.grafica.Name = "grafica"
        Me.grafica.Size = New System.Drawing.Size(507, 432)
        Me.grafica.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1020, 658)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "Form1"
        Me.Text = "Trabajo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_n_nodos As System.Windows.Forms.TextBox
    Friend WithEvents txt_log As System.Windows.Forms.RichTextBox
    Friend WithEvents btn_cargar As System.Windows.Forms.Button
    Friend WithEvents btn_dijkstra As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents combo_A As System.Windows.Forms.ComboBox
    Friend WithEvents combo_Z As System.Windows.Forms.ComboBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_prim As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_ruta As System.Windows.Forms.TextBox
    Friend WithEvents salida_dijkstra As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_salida_prim As System.Windows.Forms.RichTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents panel_matriz As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents grafica As System.Windows.Forms.Panel
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dijkstra_grafico As System.Windows.Forms.Button
    Friend WithEvents combo_Z_grafico As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents combo_A_grafico As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btn_prim_grafico As System.Windows.Forms.Button

End Class
