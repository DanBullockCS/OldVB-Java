/* Daniel Bullock
 * April 6th 2016
 * 
 * Purpose: Create a program that reads the file Psalms.txt into an array.
 * The user will then request a Psalm title based on the Psalm number.
 * Title: Psalms.java
 */
package psalms;

import javax.swing.*;
import java.io.*;

public class Psalms {

    //Public array to use in both methods
    public static String psalms[] = new String[100];  //User imput is 1-99

    public static void main(String[] args) throws IOException {
        //Get Psalm number from user
        String psalm_num = JOptionPane.showInputDialog("What psalm number would you like to see? (1-99)");
        //Declare variables
        int i = 0, j = 0;
        //Declare BufferedReader
        BufferedReader readFile = new BufferedReader(new FileReader("Psalms.txt"));
        //Each line as a string
        String myLine;
        //Read file
        while ((myLine = readFile.readLine()) != null) {
            if ((i % 2) > 0) {
                psalms[j] = myLine;
            } else {
                j = Integer.parseInt(myLine);
                psalms[j] = "";
            }
            i++;
        }
        //close the file
        readFile.close();
        //Display Psalm
        if (binarySearch(psalms, 1, psalms.length - 1, Integer.parseInt(psalm_num)) == true) {
            if (psalms[Integer.parseInt(psalm_num)].equals("")) {
                JOptionPane.showMessageDialog(null, "Sorry, psalm " + psalm_num + " was not found.");
            } else {
                JOptionPane.showMessageDialog(null, "Psalm " + psalm_num + "\n" + psalms[Integer.parseInt(psalm_num)]);
            }
        }
    }

    public static boolean binarySearch(String myArray[], int left, int right, int searchForPsalms) {
        //Temporary print for learning purposes
        System.out.print("Searching array: ");
        for (int i = left; i <= right; i++) {
            //Start searching through all numbers in array that actually have psalms
            if(i == 1 || i == 2 || i == 4 || i == 7 || i == 8 || i == 12
                    || i == 16 || i == 18 || i == 22 || i == 23 || i == 26
                    || i == 33 || i == 37 || i == 40 || i == 44 || i == 49
                    || i == 58 || i == 63 || i == 68 || i == 71 || i == 81
                    || i == 86 || i == 94) { 
                System.out.print("[" + i + "]");
            } else {
                psalms[i] = "";
            }
        }
        System.out.println(" for " + searchForPsalms);
        //end temporary print
        int middle;
        if (left > right) {
            return false;
        }
        middle = (left + right) / 2;
        if (middle == searchForPsalms) {
            return true;
        }
        if (searchForPsalms < middle) {
            return binarySearch(myArray, left, middle - 1, searchForPsalms);
        } else {
            return binarySearch(myArray, middle + 1, right, searchForPsalms);
        }
    }
}