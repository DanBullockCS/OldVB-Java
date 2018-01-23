/* Daniel Bullock
 * March 6th 2016
 * Purpose: Read a file that has quotes put them into an array and then randomly
 * display one of those quotes.
 * Title: RandomQuotes
 */
package randomquotes;

import java.io.*;

public class RandomQuotes {

    public static void main(String[] args) throws IOException {
        String textfile = "Quotes.txt";
       
        BufferedReader readFile = new BufferedReader(new FileReader(textfile));
        
        String myLine;
        int counter = 0;
        //Create Array
        String quote_array[] = new String[10];
        //Read file and add each line of file to each element of array
            while ((myLine = readFile.readLine()) != null) {
                quote_array[counter] = myLine;
                counter += 1;
        }
        //create a random number from 0 to 9
        int random_num = (int)(Math.random() * 10);
        
        System.out.println("The quote of the day is:\n" + quote_array[random_num]);
        readFile.close();
      }
    }
