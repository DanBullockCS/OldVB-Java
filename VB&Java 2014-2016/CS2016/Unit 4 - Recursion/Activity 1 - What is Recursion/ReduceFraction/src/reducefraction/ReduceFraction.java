/* Daniel Bullock
 * March 28th 2016
 * Purpose: Use a recursive function to calculate the greatest common denominator
 * of two integers. Use this function to recude a fraction that is inputted.
 * Title: ReduceFraction.java
 */
package reducefraction;

//Import to use JOptionPane
import javax.swing.*;

public class ReduceFraction {

    public static void main(String[] args) {
        //Endless loop
        while (true) {
                //Numerator
                int num = Integer.parseInt(JOptionPane .showInputDialog("What is the numerator?"));
                
                //Denominator
                int denom = Integer.parseInt(JOptionPane.showInputDialog("What is the denominator?"));
                
                //Greatest common divisor
                int gcd = ReduceFraction.getGCD(num, denom);

                //Reduce the fractions
                int min_num = num / gcd;
                int min_denom = denom / gcd;

                //Display results
                System.out.println("The fraction " + num + "/" + denom
                        + " can be reduced to: " + min_num + "/" + min_denom);
         }    
    }
    
    private static int getGCD(int num, int denom) {
        //Division by 0 is impossible
        if (denom == 0) {
            return num;
        }
        
        if (denom > num) {
            return ReduceFraction.getGCD(denom, num);
        } else {
            return ReduceFraction.getGCD(denom, num % denom);
       }
    }
}