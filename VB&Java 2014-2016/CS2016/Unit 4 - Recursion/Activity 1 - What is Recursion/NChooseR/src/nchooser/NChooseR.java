/* Daniel Bullock
 * March 26th 2016
 * Purpose: To use a recursive function to calculate n!. Use n! to calculate the
 * number of ways to choose r differnt objects from a set of n objects.
 * Title: NChooseR.java
 */
package nchooser;

//Import to use JOptionPane
import javax.swing.*;

public class NChooseR {
  
    public static void main(String[] args) {
        //Endless loop
        while (true) {
                // Amount to calculate
                int amount = Integer.parseInt(JOptionPane.showInputDialog(
                        "This program will calculate the number of ways\n"
                        + "to choose r different objects from a set of n objects."
                        + "\nHow many objects would you like to choose?"));
                // Amount of objects in set
                int set = Integer.parseInt(JOptionPane.showInputDialog("How many objects are there to choose from?"));
                // Display results
                JOptionPane.showMessageDialog(null, "There are " 
                        + NChooseR.choose(set, amount)
                        + " ways to choose " + amount
                        + " objects from a set of " + set + " objects.");
       }
    }
    
    public static int choose(int set, int amount) {
        // If set is < amount then nothing happens so there are 0 ways
        if (set < amount) {
            return 0;
        }
        // Recursive call until the amount == 0 set size then return 1
        if ((amount == 0) || (amount == set)) {
            return 1;
         } else {
            return NChooseR.choose(set - 1, amount - 1) + NChooseR.choose(set - 1, amount);
       }
    }
}
