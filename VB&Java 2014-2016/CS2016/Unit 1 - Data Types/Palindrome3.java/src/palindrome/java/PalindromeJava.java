/* Daniel Bullock
 * Feb. 8th 2016
 * purpose of the program is to determine whether a whole sentence is a 
 * palindrome by checking to see if it is the same sentence backwards as
 * it is forwords.
 * Title: Palindrome3
 */
package palindrome.java;

import javax.swing.*;

public class PalindromeJava {

    public static void main(String[] args) {
       //Declare variables
        String strReverseSentence = "";
        String strSentence = JOptionPane.showInputDialog("Words that are the same"
                + " forwards and backwards are called palindromes."
                + "\n"
                + "This program deterines if a sentence is a palindrome."
                + "\n\n"        
                + "Enter a sentence:");
        //Save sentence in a string variable
        String strOriginalSentence = strSentence;
        //Get rid of the spaces between the words in the string
        strSentence = strSentence.replaceAll(" ", "");
        strReverseSentence = strReverseSentence.replaceAll(" ", "");
        //for loop to spell the sentence backwards
        for ( int i = strSentence.length() - 1; i >= 0; i-- ) {
           strReverseSentence = strReverseSentence + strSentence.charAt(i);
        }  
        //if statement to tell if the sentence equals itself backwards (also convert to lowercase).
      if (strSentence.toLowerCase().equals(strReverseSentence.toLowerCase()))
          JOptionPane.showMessageDialog(null, strOriginalSentence + "\nIS a palindrome.");
      else
         JOptionPane.showMessageDialog(null, strOriginalSentence + "\nis NOT a palindrome.");
 
}
    }