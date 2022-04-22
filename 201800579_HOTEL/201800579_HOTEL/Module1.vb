Module Module1


    'varavble para recorrer filas 
    Public fila = 0

    'vectores
    Public NIT(7) As Integer
    Public Nombre(7) As String
    Public Dias(7) As Integer
    Public Impuesto(7) As Integer
    Public Habitacion(7) As String
    Public Pago(7) As String
    Public subtotal(7) As Double
    Public Descuento(7) As Double
    Public Total(7) As Double


    Public sencilla = 250
    Public doble = 400
    Public cabaña = 650

    Public I As Integer

    Public S As Double
    Public D As Double
    Public T As Double
    Public Sub Limpiezatext()
        Form1.TBdias.Clear()
        Form1.TBnombre.Clear()
        Form1.TBnit.Clear()
        Form1.TBimouesto.Clear()
        Form1.CBhabitacion.SelectedIndex = -1
        Form1.CBpago.SelectedIndex = -1
    End Sub


    Public Sub Mostrar_vectores()
        Form1.DTresultados.Rows.Clear()
        For I = 0 To 4
            'Con el siguiente IF se verifica que los vectores no estén vacíos, porque si están vacíos
            'y se trata de accesar a dicha posición, indicará un error de que se está tratando de 
            'mostrar algo que es Nulo o No existe
            'Se toma el primer vector para hacer la verificación, porque los demás estarán igual de llenos o vacíos
            If (NIT(I) <> Nothing) Then
                Form1.DTresultados.Rows.Add(Nombre(I), NIT(I), Dias(I), Impuesto(I), Habitacion(I), subtotal(I), Descuento(I), Total(I))
            Else
                'Si están vacíos, se realiza una salida forzada del ciclo For con la siguiente instrucción
                Exit For
            End If
        Next I
    End Sub
End Module
