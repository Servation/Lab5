Public Class Form1
    Public Sub DeliverFlowersToDoor()
        MessageBox.Show("The flowers have been delivered")
    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        Dim name, email, rName, rAddress, arrangement As String
        Dim phone, payment As Double

        name = txtName.Text
        email = txtEmail.Text
        rName = txtRName.Text
        rAddress = txtRAddress.Text
        arrangement = txtArr.Text
        Double.TryParse(txtPhone.Text, phone)
        Double.TryParse(txtPayment.Text, payment)

        Dim order As FlowerOrder = New FlowerOrder(name, email, phone, payment, rName, rAddress, arrangement)

        If order.receivedOrder(True) Then
            MessageBox.Show("Order recieved and is in stock")
        Else
            MessageBox.Show("Order not recieved or not in stock")
        End If

        If order.Payment(True) Then
            MessageBox.Show("Payment recieved")
        Else
            MessageBox.Show("Payment not recieved")
        End If

        order.PrintOrder()
        order.ArrangeOrder()

        If order.PackageOrder(True) Then
            DeliverFlowersToDoor()
        End If


    End Sub
End Class
