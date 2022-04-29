<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscarComponentes
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
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtInstruccion = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbtnBuscarFecha = New System.Windows.Forms.RadioButton()
        Me.rbtnBuscarDesc = New System.Windows.Forms.RadioButton()
        Me.rbtnBuscarID = New System.Windows.Forms.RadioButton()
        Me.dgvResultados = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar y modificar datos"
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btnBuscar.Location = New System.Drawing.Point(664, 22)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(124, 67)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtInstruccion)
        Me.GroupBox1.Controls.Add(Me.txtBuscar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.rbtnBuscarFecha)
        Me.GroupBox1.Controls.Add(Me.rbtnBuscarDesc)
        Me.GroupBox1.Controls.Add(Me.rbtnBuscarID)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(804, 107)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'txtInstruccion
        '
        Me.txtInstruccion.AutoSize = True
        Me.txtInstruccion.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.txtInstruccion.Location = New System.Drawing.Point(241, 77)
        Me.txtInstruccion.Name = "txtInstruccion"
        Me.txtInstruccion.Size = New System.Drawing.Size(25, 20)
        Me.txtInstruccion.TabIndex = 6
        Me.txtInstruccion.Text = "    "
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(241, 46)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(178, 23)
        Me.txtBuscar.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(241, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Escriba aquí:"
        '
        'rbtnBuscarFecha
        '
        Me.rbtnBuscarFecha.AutoSize = True
        Me.rbtnBuscarFecha.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.rbtnBuscarFecha.Location = New System.Drawing.Point(12, 67)
        Me.rbtnBuscarFecha.Name = "rbtnBuscarFecha"
        Me.rbtnBuscarFecha.Size = New System.Drawing.Size(184, 25)
        Me.rbtnBuscarFecha.TabIndex = 4
        Me.rbtnBuscarFecha.TabStop = True
        Me.rbtnBuscarFecha.Text = "Por fecha de adición"
        Me.rbtnBuscarFecha.UseVisualStyleBackColor = True
        '
        'rbtnBuscarDesc
        '
        Me.rbtnBuscarDesc.AutoSize = True
        Me.rbtnBuscarDesc.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.rbtnBuscarDesc.Location = New System.Drawing.Point(12, 42)
        Me.rbtnBuscarDesc.Name = "rbtnBuscarDesc"
        Me.rbtnBuscarDesc.Size = New System.Drawing.Size(146, 25)
        Me.rbtnBuscarDesc.TabIndex = 3
        Me.rbtnBuscarDesc.TabStop = True
        Me.rbtnBuscarDesc.Text = "Por descripción"
        Me.rbtnBuscarDesc.UseVisualStyleBackColor = True
        '
        'rbtnBuscarID
        '
        Me.rbtnBuscarID.AutoSize = True
        Me.rbtnBuscarID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.rbtnBuscarID.Location = New System.Drawing.Point(12, 17)
        Me.rbtnBuscarID.Name = "rbtnBuscarID"
        Me.rbtnBuscarID.Size = New System.Drawing.Size(75, 25)
        Me.rbtnBuscarID.TabIndex = 2
        Me.rbtnBuscarID.TabStop = True
        Me.rbtnBuscarID.Text = "Por ID"
        Me.rbtnBuscarID.UseVisualStyleBackColor = True
        '
        'dgvResultados
        '
        Me.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResultados.Location = New System.Drawing.Point(9, 166)
        Me.dgvResultados.Name = "dgvResultados"
        Me.dgvResultados.RowTemplate.Height = 25
        Me.dgvResultados.Size = New System.Drawing.Size(804, 272)
        Me.dgvResultados.TabIndex = 3
        '
        'FrmBuscarComponentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 452)
        Me.Controls.Add(Me.dgvResultados)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmBuscarComponentes"
        Me.Text = "FrmBuscarComponentes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents rbtnBuscarFecha As RadioButton
    Friend WithEvents rbtnBuscarDesc As RadioButton
    Friend WithEvents rbtnBuscarID As RadioButton
    Friend WithEvents dgvResultados As DataGridView
    Friend WithEvents txtInstruccion As Label
End Class
