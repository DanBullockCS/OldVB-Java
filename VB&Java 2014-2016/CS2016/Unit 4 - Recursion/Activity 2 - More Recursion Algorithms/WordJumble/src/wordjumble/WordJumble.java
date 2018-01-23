/* Daniel Bullock
 * April 1st 2016
 * Purpose: Use the Word Jumble recursive algorithm to write a program to list
 * all of the “word” possibilities from a set of letters input by the user. 
 * Title: WordJumble.java
 */
package wordjumble;

import java.util.ArrayList;
import javax.swing.*;

public class WordJumble {
    //Jumble
    private static ArrayList<String> jumble(String word) {
        return WordJumble.jumble(word, "");
    }
    //Jumble Words
    private static ArrayList<String> jumble(String word, String jumbled_letter) {
        //ArrayList
        ArrayList<String> words = new ArrayList<String>();
        //Declare variables
        String remainingLetters;
        String original_word = word;
        String original_jumbled_letters = jumbled_letter;
        if (word.length() == 1) {
            words.add(jumbled_letter + word);
        } else {
            for (int pos = 0; pos < original_word.length(); pos++) {
                remainingLetters = original_word.substring(0, pos)
                        + original_word.substring(pos + 1, original_word.length());
                words.addAll(WordJumble.jumble(remainingLetters,
                        original_jumbled_letters + original_word.charAt(pos)));
            }
        }
        return words;
    }
    
    public static void main(String[] args) {
        //Get the inputted word
        ArrayList<String> possibles = WordJumble.jumble(JOptionPane.showInputDialog("What word would you like to jumble?"));
        //Print out
        System.out.println(possibles.toString().replace("[", "").replace("]", "").replace(" ", "").replace(",", "\n"));
    }
}