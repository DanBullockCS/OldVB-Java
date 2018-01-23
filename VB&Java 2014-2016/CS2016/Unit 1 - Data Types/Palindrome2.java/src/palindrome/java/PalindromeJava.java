/* Daniel Bullock
 * Feb. 5th 2016
 * purpose of the program is to count the number of palindromes in a inputted
 * sentence and show these palindromes.
 * Title: Palindrome2
 */
package palindrome.java;

import javax.swing.*;

public class PalindromeJava {

    public static void main(String[] args) {
       //Declare variables
        int PalindromeCounter = 0;
        String strPalindromes = "";
        String strReverseSentence = "";
        String strSentence = JOptionPane.showInputDialog("Words that are the same"
                + " forwards and backwards are called palindromes."
                + "\n"
                + "This program determines if the words are palindromes."
                + "\n\n"
                + "Enter a sentence (do not include a punctuation mark):");   
        //for loop to spell the sentence backwards
        for (int i = strSentence.length() - 1;  i >= 0; i-- ) {
           strReverseSentence = strReverseSentence + strSentence.charAt(i);
        }          
        //Split original sentence into each individual word
        String[] strArray;
        strArray = strSentence.split(" ");
        //Split reversed sentence into each individual word
        String[] strArrayReversed;
        strArrayReversed = strReverseSentence.split(" ");
        //Reverse word order in array
        for (int i = 0; i < strArrayReversed.length / 2; i++) {
            String temp = strArrayReversed[i];
            strArrayReversed[i] = strArrayReversed[strArrayReversed.length - 1 - i];
            strArrayReversed[strArrayReversed.length - 1 - i] = temp;
        }
        //Check to see if word equals the other word in the reverse sentence.
        for (int i = 0; i < strArray.length; i++ ) {
           if (strArray[i].equals(strArrayReversed[i])) {
            strPalindromes = strPalindromes + strArray[i] + ", ";  
            PalindromeCounter = PalindromeCounter + 1;
           }
        }
        //Display messages
        JOptionPane.showMessageDialog(null, "There is/are " + PalindromeCounter + " palindrome(s) in this sentence.");
        JOptionPane.showMessageDialog(null, "The palindrome(s) is/are: " + strPalindromes);

}
}