/* Daniel Bullock
 * March 4th 2016
 * Purpose: Program reads any text file
 * Title: TextFileReader
 */
package textfilereader;

import javax.swing.*;
import java.io.*;

public class TextFileReader {
    
    //There is a sample file in the folder with this program called "SampleFile.txt"
    //Please use this file to test this program.
    
    public static void main(String[] args) throws IOException {
        String textfile = JOptionPane.showInputDialog("Please enter a file name:");
       
        BufferedReader readFile = new BufferedReader(new FileReader(textfile));
        
        String myLine;//Each line as a string
        //Read file
        while ((myLine = readFile.readLine()) != null) {
        System.out.println(myLine); //print out the line
        }
        readFile.close();   //close the file
      }
    }
