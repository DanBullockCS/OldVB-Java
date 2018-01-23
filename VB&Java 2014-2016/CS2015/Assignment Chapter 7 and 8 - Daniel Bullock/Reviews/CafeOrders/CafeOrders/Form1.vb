'Daniel Bullock
'CafeOrders

Public Class Form1

    Structure MenuItem
        Dim itemNameSpanish As String
        Dim itemNameEnglish As String
        Dim price As Decimal
    End Structure
    Dim lucyMenu(MAX_FOOD_ITEMS) As MenuItem
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

        Static totalPrice As Decimal
        Dim menuItem As Integer
        Dim btnButtonClicked As Button = sender

        Me.btnLanguage.Visible = True

        Select Case btnButtonClicked.Tag
            Case "NewOrder"
                Call LoadMenu(lucyMenu)
                Call LoadButtons(lucyMenu)
                'Load menu items and display on buttons
                If Me.btnLanguage.Text = "Spanish" Then
                    Call LoadMenu(lucyMenu)
                    Call LoadButtons(lucyMenu)
                ElseIf Me.btnLanguage.Text = "English" Then
                    Call LoadMenu(lucyMenu)
                    Call LoadButtons(lucyMenu)
                End If
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

    Private Sub btnLanguage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLanguage.Click
        Call LoadMenu(lucyMenu)
        Call LoadButtons(lucyMenu)
        If Me.btnLanguage.Text = "English" Then
            Me.btnLanguage.Text = "Spanish"
            Call LoadMenu(lucyMenu)
            Call LoadButtons(lucyMenu)
        ElseIf Me.btnLanguage.Text = "Spanish" Then
            Me.btnLanguage.Text = "English"
            Call LoadMenu(lucyMenu)
            Call LoadButtons(lucyMenu)
        End If
    End Sub

    'Stores item names and prices in Menu() array.
    '
    'post: Menu item names and prices have been stored in an array.
    '
    Sub LoadMenu(ByRef menu() As MenuItem)
        Select Case btnLanguage.Text
            Case "English"
                menu(0).itemNameSpanish = "Arroz con Pollo"
                menu(0).price = 9.95

                menu(1).itemNameSpanish = "Ropa Vieja"
                menu(1).price = 9.95

                menu(2).itemNameSpanish = "Masitas"
                menu(2).price = 8.95

                menu(3).itemNameSpanish = "Cuban Sandwich"
                menu(3).price = 6.95

                menu(4).itemNameSpanish = "Moros"
                menu(4).price = 2.75

                menu(5).itemNameSpanish = "Yuca"
                menu(5).price = 2.75

                menu(6).itemNameSpanish = "Cafe con Leche"
                menu(6).price = 1.75

                menu(7).itemNameSpanish = "Flan"
                menu(7).price = 2.5

                menu(8).itemNameSpanish = "Pudin de Pan"
                menu(8).price = 2.95
            Case "Spanish"
                menu(0).itemNameEnglish = "Chicken and Yellow Rice"
                menu(0).price = 9.95

                menu(1).itemNameEnglish = "Shredded Beef"
                menu(1).price = 9.95

                menu(2).itemNameEnglish = "Pork and Plantains"
                menu(2).price = 8.95

                menu(3).itemNameEnglish = "Cuban Bread with Meat and Cheese"
                menu(3).price = 6.95

                menu(4).itemNameEnglish = "Black Beans and Rice"
                menu(4).price = 2.75

                menu(5).itemNameEnglish = "Cassava"
                menu(5).price = 2.75

                menu(6).itemNameEnglish = "Coffee with Milk"
                menu(6).price = 1.75

                menu(7).itemNameEnglish = "Baked Custard"
                menu(7).price = 2.5

                menu(8).itemNameEnglish = "Bread Pudding"
                menu(8).price = 2.95
        End Select
    End Sub

    Sub LoadButtons(ByRef menu() As MenuItem)
        Select Case btnLanguage.Text
            'Load Buttons in Spanish
            Case "English"
                Me.btnItem0.Text = menu(0).itemNameSpanish
                Me.btnItem0.Visible = True

                Me.btnItem1.Text = menu(1).itemNameSpanish
                Me.btnItem1.Visible = True

                Me.btnItem2.Text = menu(2).itemNameSpanish
                Me.btnItem2.Visible = True

                Me.btnItem3.Text = menu(3).itemNameSpanish
                Me.btnItem3.Visible = True

                Me.btnItem4.Text = menu(4).itemNameSpanish
                Me.btnItem4.Visible = True

                Me.btnItem5.Text = menu(5).itemNameSpanish
                Me.btnItem5.Visible = True

                Me.btnItem6.Text = menu(6).itemNameSpanish
                Me.btnItem6.Visible = True

                Me.btnItem7.Text = menu(7).itemNameSpanish
                Me.btnItem7.Visible = True

                Me.btnItem8.Text = menu(8).itemNameSpanish
                Me.btnItem8.Visible = True
                'Load Buttons in English
            Case "Spanish"
                Me.btnItem0.Text = menu(0).itemNameEnglish
                Me.btnItem0.Visible = True

                Me.btnItem1.Text = menu(1).itemNameEnglish
                Me.btnItem1.Visible = True

                Me.btnItem2.Text = menu(2).itemNameEnglish
                Me.btnItem2.Visible = True

                Me.btnItem3.Text = menu(3).itemNameEnglish
                Me.btnItem3.Visible = True

                Me.btnItem4.Text = menu(4).itemNameEnglish
                Me.btnItem4.Visible = True

                Me.btnItem5.Text = menu(5).itemNameEnglish
                Me.btnItem5.Visible = True

                Me.btnItem6.Text = menu(6).itemNameEnglish
                Me.btnItem6.Visible = True

                Me.btnItem7.Text = menu(7).itemNameEnglish
                Me.btnItem7.Visible = True

                Me.btnItem8.Text = menu(8).itemNameEnglish
                Me.btnItem8.Visible = True
        End Select
    End Sub

    'Displays menu item names on interface
    '
    'post: Menu item names have been displayed on buttons.


    'Displays menu item names on interface
    '
    'post: Menu item names have been displayed on buttons.

    'Adds selected menu item to a list
    '
    'post: Selected menu item and price have been added to list
    '
    Sub AddToList(ByRef item As MenuItem, ByRef lstOrderList As ListBox)
        Select Case btnLanguage.Text
            Case "English"
                lstOrderList.Items.Add(item.itemNameSpanish & vbTab & Format(item.price, "Currency"))
            Case "Spanish"
                lstOrderList.Items.Add(item.itemNameEnglish & vbTab & Format(item.price, "Currency"))
        End Select

    End Sub

    'Displays a total price for the current order in a label
    '
    'post: A price has been displayed in a label.
    '
    Sub ShowTotal(ByVal amount As Decimal, ByRef lblAmount As Label)
        lblAmount.Text = "Total:" & Format(amount, "Currency")
    End Sub
End Class
