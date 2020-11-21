<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCalculadora
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnAc = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnResult = New System.Windows.Forms.Button()
        Me.btnRes = New System.Windows.Forms.Button()
        Me.btnSum = New System.Windows.Forms.Button()
        Me.btnMult = New System.Windows.Forms.Button()
        Me.btnDiv = New System.Windows.Forms.Button()
        Me.btnPoint = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.pnlScreen = New System.Windows.Forms.Panel()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.pnlScreen.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAc
        '
        Me.btnAc.BackColor = System.Drawing.Color.Red
        Me.btnAc.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAc.ForeColor = System.Drawing.Color.White
        Me.btnAc.Location = New System.Drawing.Point(88, 98)
        Me.btnAc.Name = "btnAc"
        Me.btnAc.Size = New System.Drawing.Size(75, 37)
        Me.btnAc.TabIndex = 37
        Me.btnAc.Text = "AC"
        Me.btnAc.UseVisualStyleBackColor = False
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.Color.Red
        Me.btnDel.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.ForeColor = System.Drawing.Color.White
        Me.btnDel.Location = New System.Drawing.Point(7, 98)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 37)
        Me.btnDel.TabIndex = 36
        Me.btnDel.Text = "DEL"
        Me.btnDel.UseVisualStyleBackColor = False
        '
        'btnResult
        '
        Me.btnResult.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResult.Location = New System.Drawing.Point(250, 270)
        Me.btnResult.Name = "btnResult"
        Me.btnResult.Size = New System.Drawing.Size(75, 37)
        Me.btnResult.TabIndex = 35
        Me.btnResult.Text = "="
        Me.btnResult.UseVisualStyleBackColor = True
        '
        'btnRes
        '
        Me.btnRes.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRes.Location = New System.Drawing.Point(250, 227)
        Me.btnRes.Name = "btnRes"
        Me.btnRes.Size = New System.Drawing.Size(75, 37)
        Me.btnRes.TabIndex = 34
        Me.btnRes.Text = "-"
        Me.btnRes.UseVisualStyleBackColor = True
        '
        'btnSum
        '
        Me.btnSum.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSum.Location = New System.Drawing.Point(250, 141)
        Me.btnSum.Name = "btnSum"
        Me.btnSum.Size = New System.Drawing.Size(75, 80)
        Me.btnSum.TabIndex = 33
        Me.btnSum.Text = "+"
        Me.btnSum.UseVisualStyleBackColor = True
        '
        'btnMult
        '
        Me.btnMult.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMult.Location = New System.Drawing.Point(250, 98)
        Me.btnMult.Name = "btnMult"
        Me.btnMult.Size = New System.Drawing.Size(75, 37)
        Me.btnMult.TabIndex = 32
        Me.btnMult.Text = "*"
        Me.btnMult.UseVisualStyleBackColor = True
        '
        'btnDiv
        '
        Me.btnDiv.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiv.Location = New System.Drawing.Point(169, 98)
        Me.btnDiv.Name = "btnDiv"
        Me.btnDiv.Size = New System.Drawing.Size(75, 37)
        Me.btnDiv.TabIndex = 31
        Me.btnDiv.Text = "/"
        Me.btnDiv.UseVisualStyleBackColor = True
        '
        'btnPoint
        '
        Me.btnPoint.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPoint.Location = New System.Drawing.Point(169, 270)
        Me.btnPoint.Name = "btnPoint"
        Me.btnPoint.Size = New System.Drawing.Size(75, 37)
        Me.btnPoint.TabIndex = 30
        Me.btnPoint.Text = "."
        Me.btnPoint.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.Location = New System.Drawing.Point(169, 227)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(75, 37)
        Me.btn3.TabIndex = 29
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.Location = New System.Drawing.Point(169, 184)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(75, 37)
        Me.btn6.TabIndex = 28
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.Location = New System.Drawing.Point(169, 141)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(75, 37)
        Me.btn9.TabIndex = 27
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.Location = New System.Drawing.Point(88, 227)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(75, 37)
        Me.btn2.TabIndex = 26
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.Location = New System.Drawing.Point(88, 184)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(75, 37)
        Me.btn5.TabIndex = 25
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.Location = New System.Drawing.Point(88, 141)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(75, 37)
        Me.btn8.TabIndex = 24
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn0.Location = New System.Drawing.Point(7, 270)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(156, 37)
        Me.btn0.TabIndex = 23
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.Location = New System.Drawing.Point(7, 227)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(75, 37)
        Me.btn1.TabIndex = 22
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.Location = New System.Drawing.Point(7, 184)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(75, 37)
        Me.btn4.TabIndex = 21
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.Location = New System.Drawing.Point(7, 141)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(75, 37)
        Me.btn7.TabIndex = 20
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'pnlScreen
        '
        Me.pnlScreen.BackColor = System.Drawing.SystemColors.Control
        Me.pnlScreen.Controls.Add(Me.txtResult)
        Me.pnlScreen.Controls.Add(Me.txtNum)
        Me.pnlScreen.Location = New System.Drawing.Point(12, 12)
        Me.pnlScreen.Name = "pnlScreen"
        Me.pnlScreen.Size = New System.Drawing.Size(306, 80)
        Me.pnlScreen.TabIndex = 19
        '
        'txtResult
        '
        Me.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtResult.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResult.Location = New System.Drawing.Point(6, 44)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtResult.Size = New System.Drawing.Size(289, 22)
        Me.txtResult.TabIndex = 5
        '
        'txtNum
        '
        Me.txtNum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNum.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum.Location = New System.Drawing.Point(6, 7)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.ReadOnly = True
        Me.txtNum.Size = New System.Drawing.Size(289, 22)
        Me.txtNum.TabIndex = 4
        '
        'frmCalculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(333, 314)
        Me.Controls.Add(Me.btnAc)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnResult)
        Me.Controls.Add(Me.btnRes)
        Me.Controls.Add(Me.btnSum)
        Me.Controls.Add(Me.btnMult)
        Me.Controls.Add(Me.btnDiv)
        Me.Controls.Add(Me.btnPoint)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.pnlScreen)
        Me.Name = "frmCalculadora"
        Me.Text = "frmCalculadora"
        Me.pnlScreen.ResumeLayout(False)
        Me.pnlScreen.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAc As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents btnResult As Button
    Friend WithEvents btnRes As Button
    Friend WithEvents btnSum As Button
    Friend WithEvents btnMult As Button
    Friend WithEvents btnDiv As Button
    Friend WithEvents btnPoint As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents pnlScreen As Panel
    Friend WithEvents txtResult As TextBox
    Friend WithEvents txtNum As TextBox
End Class
