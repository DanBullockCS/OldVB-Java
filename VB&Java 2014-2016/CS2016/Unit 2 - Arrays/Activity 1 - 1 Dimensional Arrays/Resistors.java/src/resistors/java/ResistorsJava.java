/* Daniel Bullock
 * Feb. 11th 2016
 * Purpose: take 3 colours seperated by hyphens and print the value of the resistor
 * Title: Resistors
 */
package resistors.java;

import javax.swing.*;

public class ResistorsJava {

    public static void main(String[] args) {
        //Create an populated array with 10 elements
        String ResistorColours[] = {"BLACK", "BROWN", "RED", "ORANGE", 
        "YELLOW", "GREEN", "BLUE", "VIOLET", "GREY", "WHITE"};
        //Variables for the equation to find resistor value
        int A = 0, B = 0, C = 0;
        //The answer of the equation as a double
        double Answer;
        //Number Array
        int NumArray[] = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
        //Let user input their 3 colour code
        String Input = JOptionPane.showInputDialog("What is your resistors "
                + "colour code?" + "\n" + "Seperate each colour by hyphens"
                + "\n" + "Ex: Red-Orange-Black");
        //Variable that save inputted colours since the cases change
        String SavedInput = Input;
        //Convert users input to upper case
        Input = Input.toUpperCase();
        //Put the users input into an array of 3 elements
        String InputArray[];
        InputArray = Input.split("-");
        //For loop for the first inputted colour
        for(int i = 0; i < NumArray.length; i++) {
        if (InputArray[0].equals(ResistorColours[i])) {
            A = NumArray[i];
        }
    }
        //For loop for the second inputted colour
       for(int i = 0; i < NumArray.length; i++) {
        if (InputArray[1].equals(ResistorColours[i])) {
            B = NumArray[i];
        }
    }
       //For loop for the third inputted colour
        for(int i = 0; i < NumArray.length; i++) {
        if (InputArray[2].equals(ResistorColours[i])) {
            C = NumArray[i];
        }
    }
        //Goal is to "push a and b together," so convert them to strings and back
        String ParsedA = String.valueOf(A);
        String ParsedB = String.valueOf(B);
        String AandBTogether = ParsedA + ParsedB;
        int AB = Integer.parseInt(AandBTogether);
        //Math Equation (AB * 10 to the power of C)
        Answer = AB * (Math.pow(10, C));
        //Display results
        System.out.println("You entered " + SavedInput);
        System.out.println("The value of the resistor is " + Answer + " ohms");
    }
}
