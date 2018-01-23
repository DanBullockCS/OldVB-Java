/*Daniel Bullock
 * Feb. 4th 2016
 * Program title: RoundError
 * Purpose of program is to show the rounding error in java by comparing the 
 * square of the square root of any number.
 */
package rounderror.java;

import javax.swing.JOptionPane;

public class RoundErrorJava {

    public static void main(String[] args) {
        // Variables
        double num, squareofsquare, squareroot, roundofferror;
        String strInput;  
        
        //Ask the user for the number
        strInput = JOptionPane.showInputDialog("Enter a number:");
        num = Double.parseDouble(strInput);
        //Calculations
        squareroot = Math.sqrt(num);
        squareofsquare = (squareroot * squareroot);
        roundofferror = num - squareofsquare;
        //Display output
        System.out.println("The square of the square root = " + squareofsquare + ".");
        System.out.println("The round off error = " + roundofferror + ".");
    }
}
