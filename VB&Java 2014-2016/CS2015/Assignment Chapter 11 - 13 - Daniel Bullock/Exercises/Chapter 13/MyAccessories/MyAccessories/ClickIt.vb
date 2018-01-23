'ClickIt
'Chapter 9 case study
'Lawrenceville Press
'February 16, 2006

Public Class ClickIt

    Const NUM_SHAPES As Integer = 3     'number of shapes
    Dim score As Integer = 0            'player's score
    Dim boxNum As Integer               'box displaying the shape
    Dim shapeNum As Integer             '0 blue triangle, 1 red diamond, 2 pink circle

    'Starts the game.
    '
    'post: The game has displayed various shapes for one minute for the player to click.
    '
    Private Sub btnGo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGo.Click
        Me.btnGo.Visible = False
        Me.tmrShowShape.Start()
        Me.tmrGameLength.Start()
    End Sub

    'Displays a shape in one of a set of picture boxes
    '
    'pre: There are six picture boxes on the interface named
    'picShape0, picShape1, picShape2, picShape3, picShape4, and 
    'picShape5
    'post: A shape has been displayed in one of the picture boxes. 
    'The remaining picture boxes display the default shape.
    '
    Private Sub tmrShowShape_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrShowShape.Tick
        Dim picBoxes() As PictureBox = {Me.picShape0, Me.picShape1, Me.picShape2, _
        Me.picShape3, Me.picShape4, Me.picShape5}
        Randomize()

        'Clear the previous shape by showing default shape in all boxes
        Call ClearBoxes(picBoxes)
        'Assign global variable box number for shape
        boxNum = Int(picBoxes.Length * Rnd())
        'Assign global variable shape number for box
        shapeNum = Int(NUM_SHAPES * Rnd())

        Call DisplayShape(picBoxes, boxNum, shapeNum)
    End Sub

    'Places a default image in all the picture boxes of the PictureBox array
    '
    'post: The picture boxes have been set to display the default image
    '
    Sub ClearBoxes(ByRef boxes() As PictureBox)

        For box As Integer = 0 To boxes.Length - 1
            boxes(box).Image = My.Resources.greensquare     'green square is default image
        Next box
    End Sub

    'A shape is displayed in one of the boxes of the PictureBox
    'array
    '
    'pre: The Resources folder contains the bluetriangle,
    'reddiamond, and pinkcircle image files. 0 <= box <= PictureBox.Length.
    'shape is 0, 1, or 2.
    'post: A shape has been displayed in a picture box
    '
    Sub DisplayShape(ByRef boxes() As PictureBox, ByVal box As Integer, _
    ByVal shape As Integer)
        Select Case shape
            Case 0
                boxes(box).Image = My.Resources.bluetriangle
            Case 1
                boxes(box).Image = My.Resources.reddiamond
            Case 2
                boxes(box).Image = My.Resources.pinkcircle
        End Select
    End Sub

    'Determines if clicked picture box is the one with the shape
    '
    'pre: The picture boxes have appropriate Tag values. shapeNum is 0, 1, or 2.
    'post: Player's score has been updated if shape was clicked
    '
    Private Sub ShapeClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) _
    Handles picShape0.MouseDown, picShape1.MouseDown, picShape2.MouseDown, picShape3.MouseDown, _
    picShape4.MouseDown, picShape5.MouseDown
        Dim picClicked As PictureBox = sender

        If picClicked.Tag = boxNum Then
            Select Case shapeNum
                Case 0      'blue triangle
                    score += 5
                Case 1      'red diamond
                    score -= 3
                Case 2      'pink circle
                    score += 10
            End Select
        End If
    End Sub

    'Ends the game and displays the player's score
    '
    'post: Timers have been stopped and the player's score displayed
    '
    Private Sub tmrGameLength_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrGameLength.Tick
        Me.tmrGameLength.Stop()
        Me.tmrShowShape.Stop()
        MessageBox.Show("Score: " & score)
    End Sub
End Class