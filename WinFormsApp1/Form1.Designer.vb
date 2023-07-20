<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        salida = New TextBox()
        n1 = New Button()
        n2 = New Button()
        n3 = New Button()
        n4 = New Button()
        n5 = New Button()
        n6 = New Button()
        n7 = New Button()
        n8 = New Button()
        n9 = New Button()
        n0 = New Button()
        pDecimal = New Button()
        borrar = New Button()
        limpiar = New Button()
        btnDiv = New Button()
        btnRest = New Button()
        btnMult = New Button()
        btnSum = New Button()
        operacion = New Button()
        btnPorc = New Button()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        salida2 = New TextBox()
        btnExit = New Button()
        SuspendLayout()
        ' 
        ' salida
        ' 
        salida.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        salida.BorderStyle = BorderStyle.FixedSingle
        salida.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        salida.ForeColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        salida.Location = New Point(117, 23)
        salida.Multiline = True
        salida.Name = "salida"
        salida.ReadOnly = True
        salida.Size = New Size(423, 55)
        salida.TabIndex = 0
        ' 
        ' n1
        ' 
        n1.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        n1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        n1.Location = New Point(117, 242)
        n1.Name = "n1"
        n1.Size = New Size(58, 44)
        n1.TabIndex = 1
        n1.Text = "1"
        n1.UseVisualStyleBackColor = False
        ' 
        ' n2
        ' 
        n2.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        n2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        n2.Location = New Point(192, 242)
        n2.Name = "n2"
        n2.Size = New Size(58, 44)
        n2.TabIndex = 2
        n2.Text = "2"
        n2.UseVisualStyleBackColor = False
        ' 
        ' n3
        ' 
        n3.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        n3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        n3.Location = New Point(273, 242)
        n3.Name = "n3"
        n3.Size = New Size(58, 44)
        n3.TabIndex = 3
        n3.Text = "3"
        n3.UseVisualStyleBackColor = False
        ' 
        ' n4
        ' 
        n4.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        n4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        n4.Location = New Point(117, 170)
        n4.Name = "n4"
        n4.Size = New Size(58, 44)
        n4.TabIndex = 4
        n4.Text = "4"
        n4.UseVisualStyleBackColor = False
        ' 
        ' n5
        ' 
        n5.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        n5.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        n5.Location = New Point(192, 170)
        n5.Name = "n5"
        n5.Size = New Size(58, 44)
        n5.TabIndex = 5
        n5.Text = "5"
        n5.UseVisualStyleBackColor = False
        ' 
        ' n6
        ' 
        n6.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        n6.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        n6.Location = New Point(273, 170)
        n6.Name = "n6"
        n6.RightToLeft = RightToLeft.No
        n6.Size = New Size(58, 44)
        n6.TabIndex = 6
        n6.Text = "6"
        n6.UseVisualStyleBackColor = False
        ' 
        ' n7
        ' 
        n7.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        n7.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        n7.Location = New Point(117, 101)
        n7.Name = "n7"
        n7.Size = New Size(58, 44)
        n7.TabIndex = 7
        n7.Text = "7"
        n7.UseVisualStyleBackColor = False
        ' 
        ' n8
        ' 
        n8.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        n8.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        n8.Location = New Point(192, 101)
        n8.Name = "n8"
        n8.Size = New Size(58, 44)
        n8.TabIndex = 8
        n8.Text = "8"
        n8.UseVisualStyleBackColor = False
        ' 
        ' n9
        ' 
        n9.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        n9.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        n9.Location = New Point(273, 101)
        n9.Name = "n9"
        n9.Size = New Size(58, 44)
        n9.TabIndex = 9
        n9.Text = "9"
        n9.UseVisualStyleBackColor = False
        ' 
        ' n0
        ' 
        n0.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        n0.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        n0.Location = New Point(117, 314)
        n0.Name = "n0"
        n0.Size = New Size(86, 44)
        n0.TabIndex = 10
        n0.Text = "0"
        n0.UseVisualStyleBackColor = False
        ' 
        ' pDecimal
        ' 
        pDecimal.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        pDecimal.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        pDecimal.Location = New Point(245, 314)
        pDecimal.Name = "pDecimal"
        pDecimal.Size = New Size(86, 44)
        pDecimal.TabIndex = 11
        pDecimal.Text = "."
        pDecimal.UseVisualStyleBackColor = False
        ' 
        ' borrar
        ' 
        borrar.BackColor = SystemColors.GradientActiveCaption
        borrar.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        borrar.Location = New Point(399, 101)
        borrar.Name = "borrar"
        borrar.Size = New Size(58, 44)
        borrar.TabIndex = 12
        borrar.Text = "C"
        borrar.UseVisualStyleBackColor = False
        ' 
        ' limpiar
        ' 
        limpiar.BackColor = SystemColors.GradientActiveCaption
        limpiar.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        limpiar.Location = New Point(482, 101)
        limpiar.Name = "limpiar"
        limpiar.Size = New Size(58, 44)
        limpiar.TabIndex = 13
        limpiar.Text = "CE"
        limpiar.UseVisualStyleBackColor = False
        ' 
        ' btnDiv
        ' 
        btnDiv.BackColor = SystemColors.GradientActiveCaption
        btnDiv.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnDiv.Location = New Point(399, 170)
        btnDiv.Name = "btnDiv"
        btnDiv.Size = New Size(58, 44)
        btnDiv.TabIndex = 14
        btnDiv.Text = "/"
        btnDiv.UseVisualStyleBackColor = False
        ' 
        ' btnRest
        ' 
        btnRest.BackColor = SystemColors.GradientActiveCaption
        btnRest.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnRest.Location = New Point(482, 170)
        btnRest.Name = "btnRest"
        btnRest.Size = New Size(58, 44)
        btnRest.TabIndex = 15
        btnRest.Text = "-"
        btnRest.UseVisualStyleBackColor = False
        ' 
        ' btnMult
        ' 
        btnMult.BackColor = SystemColors.GradientActiveCaption
        btnMult.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnMult.Location = New Point(399, 242)
        btnMult.Name = "btnMult"
        btnMult.Size = New Size(58, 44)
        btnMult.TabIndex = 16
        btnMult.Text = "*"
        btnMult.UseVisualStyleBackColor = False
        ' 
        ' btnSum
        ' 
        btnSum.BackColor = SystemColors.GradientActiveCaption
        btnSum.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnSum.Location = New Point(482, 242)
        btnSum.Name = "btnSum"
        btnSum.Size = New Size(58, 44)
        btnSum.TabIndex = 17
        btnSum.Text = "+"
        btnSum.UseVisualStyleBackColor = False
        ' 
        ' operacion
        ' 
        operacion.BackColor = SystemColors.GradientActiveCaption
        operacion.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        operacion.Location = New Point(399, 314)
        operacion.Name = "operacion"
        operacion.Size = New Size(58, 44)
        operacion.TabIndex = 18
        operacion.Text = "="
        operacion.UseVisualStyleBackColor = False
        ' 
        ' btnPorc
        ' 
        btnPorc.BackColor = SystemColors.GradientActiveCaption
        btnPorc.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnPorc.Location = New Point(482, 314)
        btnPorc.Name = "btnPorc"
        btnPorc.Size = New Size(58, 44)
        btnPorc.TabIndex = 19
        btnPorc.Text = "%"
        btnPorc.UseVisualStyleBackColor = False
        ' 
        ' salida2
        ' 
        salida2.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        salida2.BorderStyle = BorderStyle.None
        salida2.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        salida2.Location = New Point(129, 35)
        salida2.Multiline = True
        salida2.Name = "salida2"
        salida2.ReadOnly = True
        salida2.Size = New Size(399, 33)
        salida2.TabIndex = 20
        salida2.TextAlign = HorizontalAlignment.Right
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnExit.Cursor = Cursors.Hand
        btnExit.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnExit.Location = New Point(561, 101)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(87, 44)
        btnExit.TabIndex = 21
        btnExit.Text = "Salir"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(833, 391)
        Controls.Add(btnExit)
        Controls.Add(salida2)
        Controls.Add(btnPorc)
        Controls.Add(operacion)
        Controls.Add(btnSum)
        Controls.Add(btnMult)
        Controls.Add(btnRest)
        Controls.Add(btnDiv)
        Controls.Add(limpiar)
        Controls.Add(borrar)
        Controls.Add(pDecimal)
        Controls.Add(n0)
        Controls.Add(n9)
        Controls.Add(n8)
        Controls.Add(n7)
        Controls.Add(n6)
        Controls.Add(n5)
        Controls.Add(n4)
        Controls.Add(n3)
        Controls.Add(n2)
        Controls.Add(n1)
        Controls.Add(salida)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MaximumSize = New Size(833, 391)
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        MinimumSize = New Size(833, 391)
        Name = "Form1"
        ShowIcon = False
        StartPosition = FormStartPosition.Manual
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents salida As TextBox
    Friend WithEvents n1 As Button
    Friend WithEvents n2 As Button
    Friend WithEvents n3 As Button
    Friend WithEvents n4 As Button
    Friend WithEvents n5 As Button
    Friend WithEvents n6 As Button
    Friend WithEvents n7 As Button
    Friend WithEvents n8 As Button
    Friend WithEvents n9 As Button
    Friend WithEvents n0 As Button
    Friend WithEvents pDecimal As Button
    Friend WithEvents borrar As Button
    Friend WithEvents limpiar As Button
    Friend WithEvents btnDiv As Button
    Friend WithEvents btnRest As Button
    Friend WithEvents btnMult As Button
    Friend WithEvents btnSum As Button
    Friend WithEvents operacion As Button
    Friend WithEvents btnPorc As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents salida2 As TextBox
    Friend WithEvents btnExit As Button
End Class
