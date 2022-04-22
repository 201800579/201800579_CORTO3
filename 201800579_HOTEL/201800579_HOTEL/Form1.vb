Public Class Form1
    Private Sub TScalculo_Click(sender As Object, e As EventArgs) Handles TScalculo.Click
        'Proceso que realiza el ingreso, cálculo y almacenar los datos en los vectores
        If (fila <= 4) Then
            Nombre(fila) = TBnombre.Text
            NIT(fila) = Val(TBnit.Text)
            Dias(fila) = Val(TBdias.Text)
            Impuesto(fila) = Val(TBimouesto.Text)
            Habitacion(fila) = CBhabitacion.Text
            Pago(fila) = CBpago.Text


            fila = fila + 1

            Limpiezatext()

        End If
        If (fila = 7) Then
            MsgBox("Se llego al Limite de Registros")
        End If
    End Sub

    Private Sub TSmostrar_Click(sender As Object, e As EventArgs) Handles TSmostrar.Click
        Mostrar_vectores()
    End Sub
End Class
