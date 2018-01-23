/* Daniel Bullock
 * March 23rd 2016
 * Purpose: create a program that uses a recursive function to find the value of
 * the nth Fibonacci number.
 * Title: Fibonacci.java
 */
package fibonacci;

//Import to use JOptionPane
import javax.swing.*;

public class Fibonacci {

    public static void main(String[] args) {

        // Endless loop
            while (true) {
                // JOptionPane message dialog
                JOptionPane.showMessageDialog(null,"The Fibonacci number is: "
                        + Fibonacci.fibo(Integer.parseInt(JOptionPane.showInputDialog(
                        "The first nine fibonacci numbers are listed as follows:\n"
                        + "1, 1, 2, 3, 5, 8, 13, 21, 34, ...\n"
                        +"What term of Fibonacci would you like to see?"))));
    }
  }
    
    public static int fibo(int n) {
        // Recursive call (Fibonacci sequence)
         if ((n == 1) || (n == 2)) {
            return 1;
         } else {
            return Fibonacci.fibo(n - 1) + Fibonacci.fibo(n - 2);
       }
    }
}
