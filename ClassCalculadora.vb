Public Class ClassCalculadora
    Dim N1, N2 As Double 'Se declaran las variables N1, N2.
    Dim Oper As String 'Se declara la variable Oper.

    'Se definen las propiedades.
    Public Property PropN1 As Double 'Toman el valor de la variable y lo devuelven (todas las propiedades).
        Get
            Return N1
        End Get
        Set(value As Double)
            Me.N1 = value
        End Set
    End Property

    Public Property PropN2 As Double
        Get
            Return N2
        End Get
        Set(value As Double)
            Me.N2 = value
        End Set
    End Property

    Public Property PorpOper As String
        Get
            Return Oper
        End Get
        Set(value As String)
            Me.Oper = value
        End Set
    End Property

    'Se definen los metodos
    Public Sub Operacion(Num1 As Double, Num2 As Double, Oper As String)
        Me.N1 = Num1 'Los parametros ingresados al objeto se asignan a las variables que corresponde a esta clase.
        Me.N2 = Num2
        Select Case Oper 'Segun el valor enviado por Oper se asignara una funcion que corresponde a la operación deseada.
            Case "+"
                Sum()
            Case "-"
                Res()
            Case "/"
                Div()
            Case "*"
                Mult()
        End Select
    End Sub

    Public Sub Sum() 'Suma N1 + N2 y el resultado lo asigna a N1. Esta misma logica se aplican a las demas operaciones, cambiando operador.
        Me.N1 += N2
    End Sub

    Public Sub Res()
        Me.N1 -= N2
    End Sub

    Public Sub Div()
        Me.N1 /= N2
    End Sub

    Public Sub Mult()
        Me.N1 *= N2
    End Sub

End Class
