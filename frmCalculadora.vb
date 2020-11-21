Public Class frmCalculadora
    'Integrantes:
    'Anderson Aldair López Durán // USIS027920
    'Josué Alexander Flores Gómez // USIS019120
    'Elías Mauricio Parada Lozano // USIS030320


    'Nota: El textbox txtResult esta orientado de derecha a izquierda, y los numeros negativos se escriben poniendo el...
    '...número al inicio y luego el signo, es algo de visual basic y no lo puedo cambiar hasta donde investigue.
    Dim ObjCalculadora As New ClassCalculadora() 'Creo un nuevo objeto que pertenece a la clase ClassCalculadora.
    Dim N1, N2 As Double 'Almacenaran los datos que se enviaran al objeto.
    Dim Oper As String 'Almacena el tipo de operación a realizar por el objeto.
    Dim NewOper As Boolean = True 'Si se empieza una nueva operación.
    Dim IsOper As Boolean = False 'Si ya se agrego un operador.

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If NewOper = True Then 'Sí se inicia una nueva operación, entonces primero se borra el textbox del resultado.
            txtResult.Clear()  'Pues si no se hace, este se escribiría junto a la operación actual, pudiendo causar confuciones.
            NewOper = False 'Finalmente se declara que NewOper será falso.
        End If
        txtNum.Text += "0" 'Independientemente si es nueva operación o no se escribe el numeron en ambos textbox.
        txtResult.Text += "0"
    End Sub
    'Lo mismo para todos los numeros y el punto.
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If NewOper = True Then
            txtResult.Clear()
            NewOper = False
        End If
        txtNum.Text += "1"
        txtResult.Text += "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If NewOper = True Then
            txtResult.Clear()
            NewOper = False
        End If
        txtNum.Text += "2"
        txtResult.Text += "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If NewOper = True Then
            txtResult.Clear()
            NewOper = False
        End If
        txtNum.Text += "3"
        txtResult.Text += "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If NewOper = True Then
            txtResult.Clear()
            NewOper = False
        End If
        txtNum.Text += "4"
        txtResult.Text += "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If NewOper = True Then
            txtResult.Clear()
            NewOper = False
        End If
        txtNum.Text += "5"
        txtResult.Text += "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If NewOper = True Then
            txtResult.Clear()
            NewOper = False
        End If
        txtNum.Text += "6"
        txtResult.Text += "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If NewOper = True Then
            txtResult.Clear()
            NewOper = False
        End If
        txtNum.Text += "7"
        txtResult.Text += "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If NewOper = True Then
            txtResult.Clear()
            NewOper = False
        End If
        txtNum.Text += "8"
        txtResult.Text += "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If NewOper = True Then
            txtResult.Clear()
            NewOper = False
        End If
        txtNum.Text += "9"
        txtResult.Text += "9"
    End Sub

    Private Sub btnPoint_Click(sender As Object, e As EventArgs) Handles btnPoint.Click
        If NewOper = True Then
            txtResult.Clear()
            NewOper = False
        End If
        If InStr(txtNum.Text, ".", CompareMethod.Text) = 0 Then 'En resumen, si no existe ya un punto en la cadena del textbox.
            txtNum.Text &= "." 'Se escribe el punto en ambos textbox.
            txtResult.Text &= "."
        End If
    End Sub

    Private Sub btnAc_Click(sender As Object, e As EventArgs) Handles btnAc.Click
        txtNum.Clear() 'Se limpian los textbox.
        txtResult.Clear()
        ObjCalculadora.PropN1 = 0 'Las propiedades del objeto se reinician.
        ObjCalculadora.PropN2 = 0
        ObjCalculadora.PorpOper = vbNullString
        NewOper = True 'Las variables booleanas se reinician.
        IsOper = False
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If txtNum.Text <> "" And txtResult.Text <> "" Then 'Si el textbox no esta vácio.
            txtNum.Text = txtNum.Text.Substring(0, txtNum.Text.Count - 1) 'Se le suprime un caracter al textbox.
            txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Count - 1)
        End If
        ' If txtResult.Text <> "" Then 'Lo mismo para el textbox del resultado.
        'txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Count - 1)
        ' End If
    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        If IsOper = False Then 'Si ya existe un operador.
            If txtNum.Text <> "" Then 'Y si el texto no es vácio.
                N1 = txtNum.Text 'El valor actual se guarda en la variable N1.
            End If 'Si no se cumple la condición no pasa nada, pues quiere decir que se continua una peración.
            'Y si es así entonces no se guarada este numero en esta variable, sino en N2, pero eso se declara en el botón igual.
            txtResult.Text &= " / " 'Se agrega el siguiente caracter al textbox que muestra el resultado, para hacerlo más visual.
            Oper = "/" 'Se asigna el siguiente caracter a la variable Oper.
            txtNum.Clear() 'Se limpia el textbox.
            IsOper = True 'Is oper pasa a true, evitando escribir otro signo.
        End If
    End Sub

    'Se repiten los mismos parametros para los demas signos.
    Private Sub btnMult_Click(sender As Object, e As EventArgs) Handles btnMult.Click
        If IsOper = False Then
            If txtNum.Text <> "" Then
                N1 = txtNum.Text
            End If
            txtResult.Text &= " * "
            Oper = "*"
            txtNum.Clear()
            IsOper = True
        End If
    End Sub

    Private Sub btnRes_Click(sender As Object, e As EventArgs) Handles btnRes.Click
        If IsOper = False Then
            If txtNum.Text <> "" Then
                N1 = txtNum.Text
            End If
            txtResult.Text &= " - "
            Oper = "-"
            txtNum.Clear()
            IsOper = True
        End If
    End Sub

    Private Sub btnSum_Click(sender As Object, e As EventArgs) Handles btnSum.Click
        If IsOper = False Then
            If txtNum.Text <> "" Then
                N1 = txtNum.Text
            End If
            txtResult.Text &= " + "
            Oper = "+"
            txtNum.Clear()
            IsOper = True
        End If
    End Sub
    Private Sub btnResult_Click(sender As Object, e As EventArgs) Handles btnResult.Click
        If txtNum.Text <> "" Then 'Solo si el textbox txtNum no es vácio.
            N2 = txtNum.Text 'El valor se asigna a la variable N2, si es el segundo, o viene de una operación continua, ejemplo: (1+2) + 2 = 5.
            ObjCalculadora.Operacion(N1, N2, Oper) 'Se envia al objeto los parametrso N1, N2 y Oper.
            txtResult.Text = ObjCalculadora.PropN1 'Se imprime el valor de la propiedad PropN1.
            N1 = ObjCalculadora.PropN1 'Este dato se asigna tambien a la variable N1.
            txtNum.Clear() 'Se limpia el textbox inicial.
            NewOper = True 'Se reinician las siguientes variables.
            IsOper = False
        End If
    End Sub

End Class