/* Daniel Bullock
 * Feb. 18th 2016
 * Purpose: To make a hangman game with arrays.
 * Title: Hangman
 */
package hangman.java;

import javax.swing.*;

public class HangmanJava {

    public static void main(String[] args) {
        //   O      <---- Hangman
        //  /|\
        //   |
        //  / \
        
        //Set-up game:
        //Declare variables
        String word_bank[][] = {{"FRUIT CAKE","FOOD" }, {"POUND CAKE", "FOOD"}, {"SWITZERLAND", "COUNTRIES"}};
        int random_num = 0 + (int)(Math.random() * 3);
        String word_answer = "";    //The word(s) that you are guessing
        String dash_answer;         //The word(s) covered up with dashes
        
        for (int i = 0; i < 3; i++) {
            if (random_num == i) {
        word_answer = word_bank[i][0];
        System.out.println("Category: " + word_bank[i][1]);
    }
        }
        
        String word_split[] = word_answer.split(" ");
        System.out.println("Number of words: " + word_split.length + " word(s).");
        //dashed sentence equals the original
        dash_answer = word_answer;
        //replace all the letters with dashes
        dash_answer = dash_answer.replaceAll("[A-Za-z0-9]", "-");
        System.out.println(dash_answer);
        
        //Start game:
        for (int guess_num = 7; guess_num > 0;) {
         String guess = JOptionPane.showInputDialog("Number of guesses "
                 + "remaining: " + guess_num + "\nGuess a letter:");
         //Tell you what letter you guessed
         System.out.println("\nYou guessed: " + guess);
         //Build a new string with the covered up word(s)
         StringBuilder builder = new StringBuilder(dash_answer);
         //Find index in the word where that guessed letter is
         int index = word_answer.indexOf(guess.toUpperCase()); 
         //Replace the dashed answer with the guessed letter
         if (word_answer.toUpperCase().contains(guess.toUpperCase())) {
             builder.setCharAt(index, word_answer.charAt(index));
             dash_answer = builder.toString();
             System.out.println(dash_answer);
         } else {
             System.out.println("Sorry, wrong guess.");
             guess_num -= 1;
             //Display hangman if not correct guess
             if (guess_num == 6) {
                 System.out.println(dash_answer);
                 System.out.println(" O");
             }
             if (guess_num == 5) {
                 System.out.println(dash_answer);
                 System.out.println(" O \n/");
             }
             if (guess_num == 4) {
                 System.out.println(dash_answer);
                 System.out.println(" O\n/|");
             }
             if (guess_num == 3) {
                 System.out.println(dash_answer);
                 System.out.println(" O\n/|\\");
             }
             if (guess_num == 2) {
                 System.out.println(dash_answer);
                 System.out.println(" O\n/|\\\n |");
             }
             if (guess_num == 1) {
                 System.out.println(dash_answer);
                 System.out.println(" O\n/|\\\n |\n/");
             }
             if (guess_num == 0) {
                 System.out.println(dash_answer);
                 System.out.println(" O\n/|\\\n |\n/ \\");
                 System.out.println("Game over.");
             }
           }
         if (dash_answer.equalsIgnoreCase(word_answer)) {
             System.out.println("Congratulations you win!"); 
             break; //Finish program
         }
         }
       }
}