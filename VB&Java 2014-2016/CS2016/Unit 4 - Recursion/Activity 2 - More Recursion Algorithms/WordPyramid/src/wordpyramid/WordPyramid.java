/* Daniel Bullock
 * April 3rd 2016
 * Purpose: Create a program which will remove the first and last characters of 
 * a string.
 * Title: WordPyramid.java
 */
package wordpyramid;
//Import to use JOptionPane
import javax.swing.*;

public class WordPyramid {

    public static void main(String[] args) {
        //print out word pyramid with inputted word
        WordPyramid.pyramid(JOptionPane.showInputDialog("Enter a word."));
    }

    private static void pyramid(String word) {
        //print the word
        System.out.println(word);
        //exit when you get to 1 or 2 letters
        if (word.length() == 1 || word.length() == 2) {
            return;
        }
        //recursively call using the shortened string
        WordPyramid.pyramid(word.substring(1, word.length() - 1));
    }
}