Public Class Form1

    Private Sub btnPlaceOrder_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPlaceOrder.Click

        'Define variables
        Const REGULAR As Decimal = 6
        Const LARGE As Decimal = 10
        Const ONE_TOPPING As Decimal = 1
        Const TWO_TOPPINGS As Decimal = 1.75
        Const THREE_TOPPINGS As Decimal = 2.5
        Const FOUR_TOPPINGS As Decimal = 3.25
        Static orderNumber As Integer = 0
        Dim numToppings As Integer = 0
        Dim toppingsPrice As Decimal = 0
        Dim pizzaPrice As Decimal = 0
        
        'Increment
        orderNumber += 1

        'Add one dollar for every topping
        If Me.chkHotPeppers.Checked = True Then
            numToppings += 1
        End If
        If Me.chkMushrooms.Checked = True Then
            numToppings += 1
        End If
        If Me.chkOnions.Checked = True Then
            numToppings += 1
        End If
        If Me.chkPepperoni.Checked = True Then
            numToppings += 1
        End If
        
        Select Case numToppings
            Case 1
                toppingsPrice = ONE_TOPPING
            Case 2
                toppingsPrice = TWO_TOPPINGS
            Case 3
                toppingsPrice = THREE_TOPPINGS
            Case 4
                toppingsPrice = FOUR_TOPPINGS
        End Select

        'Determine pizza price
        If radLarge.Checked Then
            pizzaPrice = LARGE + toppingsPrice
        Else
            pizzaPrice = REGULAR + toppingsPrice
        End If

        'Delivery Plus A Dollar fifty
        If radDelivery.Checked = True Then
            pizzaPrice += 1.5
        End If

        'Display order number and pizza price
        Me.lblOrder.Text = "Order Number"
        Me.lblOrderNumber.Text = orderNumber
        Me.lblPrice.Text = "Price: $"
        Me.lblPizzaPrice.Text = pizzaPrice
        
    End Sub

    Private Sub btnNewOrder_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNewOrder.Click
        'Reset pizza order form
        Me.radLarge.Checked = False
        Me.radRegular.Checked = True
        Me.chkHotPeppers.Checked = False
        Me.chkMushrooms.Checked = False
        Me.chkOnions.Checked = False
        Me.chkPepperoni.Checked = False
        Me.lblOrder.Text = ""
        Me.lblOrderNumber.Text = ""
        Me.lblPrice.Text = ""
        Me.lblPizzaPrice.Text = ""
        Me.radPickup.Checked = False
        Me.radDelivery.Checked = False
    End Sub
End Class

