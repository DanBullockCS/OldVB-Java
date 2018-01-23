/*Daniel Bullock
 * Feb. 5th 2016
 * Program title: AreaOfTriangle
 * Purpose of program is to calculate the area of a scalene triangle by using
 * either Herons formula or using trigonometry.
 */
package areaoftriangle.java;

import javax.swing.*;

public class AreaOfTriangleJava {
    
    public static void main(String[] args) {
        //Create variables
        String strUserChoice, myInput;
        int numUserChoice; //1 or 2 depending on users choice.
        double a, b, c, s; //Variables for Herons formula.
        double Area;       //Resulting area variable.
        
        //Ask user if they want to use Herons formula or trigonometry.
        strUserChoice = JOptionPane.showInputDialog("Please type 1 to use Heron's Formula and type 2 to use Trigonometry");
        numUserChoice = Integer.parseInt(strUserChoice);

        if (numUserChoice == 1) 
        {
            myInput = JOptionPane.showInputDialog("Please enter the triangle sides. Enter a.");
            a = Double.parseDouble(myInput);
            myInput = JOptionPane.showInputDialog("Enter b.");
            b = Double.parseDouble(myInput);
            myInput = JOptionPane.showInputDialog("Enter c.");
            c = Double.parseDouble(myInput);
            //Semi-perimeter formula.
            s = (a + b + c)/2;
            //Heron's formula.
            Area = Math.sqrt(s * (s-a) * (s-b) * (s-c)); 
            //Show message with area in it.
            JOptionPane.showMessageDialog(null, "Area is " + Area + ". Found using Herons formula.");
        }         
        else if (numUserChoice == 2)
        {
            String myInput2;
            myInput2 = JOptionPane.showInputDialog("Please enter two of the triangles sides and one angle, enter a");
            double a2 = Double.parseDouble(myInput2);   //Create second a variable.
            myInput2 = JOptionPane.showInputDialog("Enter b.");
            double b2 = Double.parseDouble(myInput2);   //Create second b variable.
            myInput2 = JOptionPane.showInputDialog("Enter the C angle.");
            double C2 = Double.parseDouble(myInput2);   //Create a C as an angle variable.
            //Calculate area using trigonometry.
            double Area2 = ((a2 * b2 * Math.sin(C2)) / 2);
            //Show message with area in it.
            JOptionPane.showMessageDialog(null, "Area is " + Area2 + ". Found using trigonometry.");
        }
}
}

