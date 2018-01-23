/* Daniel Bullock
 * Feb. 5th 2016
 * purpose of the program is to determine whether a word is a palindrome by
 * checking to see if it is the same word backwards as it is forwords.
 * Title: Palindrome
 */
package palindrome.java;

import javax.swing.*;

public class PalindromeJava {

    public static void main(String[] args) {
       //Declare variables
        String strReverseWord = "";
        String strWord = JOptionPane.showInputDialog("Words that are the same"
                + " forwards and backwards are called palindromes."
                + "\n"
                + "This program determines if a word is a palindrome."
                + "\n\n"        
                + "Enter a word:");    
        //for loop to spell the word backwards
        for ( int i = strWord.length() - 1; i >= 0; i-- ) {
           strReverseWord = strReverseWord + strWord.charAt(i);
        }  
        //if statement to tell if the word equals itself backwards (also convert to lowercase).
      if (strWord.toLowerCase().equals(strReverseWord.toLowerCase()))
          JOptionPane.showMessageDialog(null, strWord + " in reverse is " + strReverseWord + "\nIt IS a palindrome.");
      else
         JOptionPane.showMessageDialog(null, strWord + " in reverse is " + strReverseWord + "\nIt is NOT a palindrome.");
 
}
    }