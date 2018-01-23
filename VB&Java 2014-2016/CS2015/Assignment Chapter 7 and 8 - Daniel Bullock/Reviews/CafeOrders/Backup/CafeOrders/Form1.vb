'CafeOrders
'Chapter 8 case study
'Lawrenceville Press
'February 16, 2006

Public Class Form1

    Structure MenuItem
        Dim itemName As String
        Dim price As Decimal
    End Structure

    Const MAX_FOOD_ITEMS As Integer = 9   'number of items on interface

    'Processes orders by showing selected items in a list and maintaining a current total
    '
    'post: A total price has been displayed and selected items have been displayed
    'in a list if menu items were selected. The list has been cleared and the 
    'price has been cleared if the New Order button was clicked.
    '
    Private Sub ProcessOrder(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles btnNewOrder.Click, btnItem0.Click, btnItem1.Click, btnItem2.Click, _
    btnItem3.Click, btnItem4.Click, btnItem5.Click, btnItem6.Click, btnItem7.Click, btnItem8.Click
        Static lucyMenu(MAX_FOOD_ITEMS) As MenuItem
        Static totalPrice As Decimal
        Dim menuItem As Integer
        Dim btnButtonClicked As Button = sender

        Select Case btnButtonClicked.Tag
            Case "NewOrder"
                'Load menu items and display on buttons
                Call LoadMenu(lucyMenu)
                Call LoadButtons(lucyMenu)
                'Initialize price and clear total from interface
                totalPrice = 0
                Me.lblTotal.Text = Nothing
                'Clear list of existing items and show list
                Me.lstItemsOrdered.Items.Clear()
                Me.lstItemsOrdered.Visible = True
            Case Else
                menuItem = Val(btnButtonClicked.Tag)
                Call AddToList(lucyMenu(menuItem), Me.lstItemsOrdered)
                totalPrice += lucyMenu(menuItem).price
                Call ShowTotal(totalPrice, Me.lblTotal)
        End Select
    End Sub

    'Stores item names and prices in Menu() array.
    '
    'post: Menu item names and prices have been stored in an array.
    '
    Sub LoadMenu(ByRef menu() As MenuItem)
        menu(0).itemName = "Arroz con Pollo"
        menu(0).price = 9.95

        menu(1).itemName = "Ropa Vieja"
        menu(1).price = 9.95

        menu(2).itemName = "Masitas"
        menu(2).price = 8.95

        menu(3).itemName = "Cuban Sandwich"
        menu(3).price = 6.95

        menu(4).itemName = "Moros"
        menu(4).price = 2.75

        menu(5).itemName = "Yuca"
        menu(5).price = 2.75

        menu(6).itemName = "Cafe con Leche"
        menu(6).price = 1.75

        menu(7).itemName = "Flan"
        menu(7).price = 2.5

        menu(8).itemName = "Pudin de Pan"
        menu(8).price = 2.95
    End Sub

    'Displays menu item names on interface
    '
    'post: Menu item names have been displayed on buttons.
    '
    Sub LoadButtons(ByRef menu() As MenuItem)
        Me.btnItem0.Text = menu(0).itemName
        Me.btnItem0.Visible = True

        Me.btnItem1.Text = menu(1).itemName
        Me.btnItem1.Visible = True

        Me.btnItem2.Text = menu(2).itemName
        Me.btnItem2.Visible = True

        Me.btnItem3.Text = menu(3).itemName
        Me.btnItem3.Visible = True

        Me.btnItem4.Text = menu(4).itemName
        Me.btnItem4.Visible = True

        Me.btnItem5.Text = menu(5).itemName
        Me.btnItem5.Visible = True

        Me.btnItem6.Text = menu(6).itemName
        Me.btnItem6.Visible = True

        Me.btnItem7.Text = menu(7).itemName
        Me.btnItem7.Visible = True

        Me.btnItem8.Text = menu(8).itemName
        Me.btnItem8.Visible = True
    End Sub

    'Adds selected menu item to a list
    '
    'post: Selected menu item and price have been added to list
    '
    Sub AddToList(ByVal item As MenuItem, ByRef lstOrderList As ListBox)
        lstOrderList.Items.Add(item.itemName & vbTab & Format(item.price, "Currency"))
    End Sub

    'Displays a total price for the current order in a label
    '
    'post: A price has been displayed in a label.
    '
    Sub ShowTotal(ByVal amount As Decimal, ByRef lblAmount As Label)
        lblAmount.Text = "Total:" & Format(amount, "Currency")
    End Sub
End Class
