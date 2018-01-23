/* Daniel Bullock
 * Feb. 7th 2016
 * The purpose of this program is to encrypt or decrypt a message by "rotating" the letters.
 * Title: Simple Encryption
 */
package simpleencryption.java;

import javax.swing.*;

public class SimpleEncryptionJava {

    public static void main(String[] args) {
        //Panel asking to enter the phrase to be encrypted/decrypted
        String strMessage = JOptionPane.showInputDialog("This program will encrypt or decrypt a phrase using the"
                + "\nsimple encryption method of rotating the letters."
                + "\n\n"
                + "Please enter a phrase:");
        //Encrypted or decrypted message
        String strNewMessage = strMessage;
        //Panel for entering rotation amount
        String strRotationAmount = JOptionPane.showInputDialog("Enter the rotation amount (1-25):");
        //Turn RotationAmount string into integer
        int intRotationAmount = Integer.parseInt(strRotationAmount);
        //Uppercase messages.
        strMessage = strMessage.toUpperCase();
        strNewMessage = strNewMessage.toUpperCase();
        //Panel for choosing to Encrypt or Decrypt
        String strEncryptOrDecrypt = JOptionPane.showInputDialog("1 - Encryption "
                + "\n"
                + "2 - Decryption");
        int intEnOrDe = Integer.parseInt(strEncryptOrDecrypt);
        
        String NewSentence = "";
        int UnicodeNumber;
        
      //Encrypt 
      if (intEnOrDe == 1) 
      {  
        for(int i = 0; i < strMessage.length(); i++) {
      UnicodeNumber = (int)strMessage.charAt(i) + intRotationAmount;
      //rotate back around alphabet
      if (UnicodeNumber > 90) {
          UnicodeNumber = (63 + intRotationAmount);
      }
      //keep space as space
      if (UnicodeNumber < 64 || UnicodeNumber > 90) {
          UnicodeNumber = 32;
      }
      //turn unicode value back to character then string
      char Letter = (char)UnicodeNumber;
      NewSentence = NewSentence + Letter;
      }
      }
      //Decrypt
      else if (intEnOrDe == 2) 
      for(int i = 0; i < strMessage.length(); i++) {
      UnicodeNumber = (int)strMessage.charAt(i) - intRotationAmount;
      //rotate back around alphabet
      if (UnicodeNumber < 64) {
          UnicodeNumber = (91 - intRotationAmount);
      }
      //keep space as space
      if (UnicodeNumber < 64 || UnicodeNumber > 90) {
          UnicodeNumber = 32;
      }
      //turn unicode value back to character then string
      char Letter = (char)UnicodeNumber;
      NewSentence = NewSentence + Letter;    
      }
      
      //Display results
      System.out.println("The original message is: " + strMessage);
      System.out.println("The encrypted message is: " + NewSentence);
    }
}
