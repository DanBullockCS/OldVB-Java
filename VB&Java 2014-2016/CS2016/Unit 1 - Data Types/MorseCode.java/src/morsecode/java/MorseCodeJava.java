/* Daniel Bullock
 * Feb. 7th 2016
 * The purpose of this program is to put out an inputted message into morse code.
 * Title: MorseCode
 */
package morsecode.java;

import javax.swing.*;

public class MorseCodeJava {

    public static void main(String[] args) {
        //Have user input message
        String Input = JOptionPane.showInputDialog("Input a message to translate to morse code:");
       
        //String to lowercase
        Input = Input.toLowerCase();
        
       //Replace alphabet and numbers 0-9 with morse code
       // \n to add a new line after letter/number is replaced with morse code
       Input = Input.replace("a", ".-\n");  
       Input = Input.replace("b", "-...\n");
       Input = Input.replace("c", "-.-.\n");
       Input = Input.replace("d", "-..\n");
       Input = Input.replace("e", ".\n");
       Input = Input.replace("f", "..-.\n");
       Input = Input.replace("g", "--.\n");
       Input = Input.replace("h", "....\n");
       Input = Input.replace("i", "..\n");
       Input = Input.replace("j", ".---\n");
       Input = Input.replace("k", "-.-\n");        
       Input = Input.replace("l", ".-..\n");        
       Input = Input.replace("m", "--\n");
       Input = Input.replace("n", "-.\n");
       Input = Input.replace("o", "---\n");
       Input = Input.replace("p", ".--.\n");
       Input = Input.replace("q", "--.-\n");
       Input = Input.replace("r", ".-.\n");
       Input = Input.replace("s", "...\n");
       Input = Input.replace("t", "-\n");
       Input = Input.replace("u", "..-\n");
       Input = Input.replace("v", "...-\n");
       Input = Input.replace("w", ".--\n");
       Input = Input.replace("x", "-..-\n");
       Input = Input.replace("y", "-.--\n");
       Input = Input.replace("z", "--..\n");
       Input = Input.replace("1", ".----\n");
       Input = Input.replace("2", "..---\n");
       Input = Input.replace("3", "...--\n");
       Input = Input.replace("4", "....-\n");
       Input = Input.replace("5", ".....\n");
       Input = Input.replace("6", "-....\n");
       Input = Input.replace("7", "--...\n");
       Input = Input.replace("8", "---..\n");
       Input = Input.replace("9", "----.\n");
       Input = Input.replace("0", "-----\n");
       
       //Display message in morse code
      System.out.println(Input);
    }
  }
   

