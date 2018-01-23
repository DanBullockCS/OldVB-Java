/* Daniel Bullock
 * March 30th 2016
 * Purpose: Create a program that reads a text file containing a 15 x 15 grid,
 * which represents human cells.
 * Title: Cancer.java
 */
package cancer;

import java.io.*;
import java.util.*;

public class Cancer {

    public static void floodFill(int row, int col) {
        // Find cancer cells recursively
        if (Cancer.map.get(row).charAt(col) == '-') {
            Cancer.map.set(row, Cancer.map.get(row).replaceFirst("-", " "));
            if (row - 1 >= 0 && col - 1 >= 0 && col - 1 < Cancer.map.get(row - 1).length()) {
                Cancer.floodFill(row - 1, col - 1);
            }
            if (row - 1 >= 0 && col < Cancer.map.get(row - 1).length()) {
                Cancer.floodFill(row - 1, col);
            }
            if (row - 1 >= 0 && col + 1 < Cancer.map.get(row - 1).length()) {
                Cancer.floodFill(row - 1, col + 1);
            }
            if (col - 1 >= 0 && col - 1 < Cancer.map.get(row).length()) {
                Cancer.floodFill(row, col - 1);
            }
            if (col + 1 < Cancer.map.get(row).length() && col + 1 < Cancer.map.get(row).length()) {
                Cancer.floodFill(row, col + 1);
            }
            if (row + 1 < Cancer.map.size() && col - 1 >= 0 && col - 1 < Cancer.map.get(row + 1).length()) {
                Cancer.floodFill(row + 1, col - 1);
            }
            if (row + 1 < Cancer.map.size() && col < Cancer.map.get(row + 1).length()) {
                Cancer.floodFill(row + 1, col);
            }
            if (row + 1 < Cancer.map.size() && col + 1 < Cancer.map.get(row + 1).length()) {
                Cancer.floodFill(row + 1, col + 1);
            }
        }
    }

    public static void main(String[] args) throws IOException {
        //Safety message
        System.out.println("Don't use tobacco.");
        //Open file to read
        BufferedReader readFile = new BufferedReader(new FileReader("Cancer.txt"));
        //Declare Arraylist
        ArrayList<String> lines = new ArrayList<String>();
        //Read lines in file
        String myLine;  //Each line as a string
        while ((myLine = readFile.readLine()) != null) {
            lines.add(myLine);
        }
        readFile.close();

        //Add the values to the map
        for (int i = 0; i < lines.size(); i++) {
            Cancer.map.add(lines.get(i));
        }
        //x is the row and y is the column
        for (int y = 0; y < Cancer.map.size(); y++) {
            for (int x = 0; x < Cancer.map.get(y).length(); x++) {
                if (Cancer.map.get(y).charAt(x) == '-') {
                    Cancer.floodFill(y, x);
                    Cancer.count++;
                }
            }
        }
        //Print out original grid map
        for (int y = 0; y < Cancer.map.size(); y++) {
            for (int x = 0; x < Cancer.map.get(y).length(); x++) {
                System.out.print(Cancer.map.get(y).charAt(x) == ' ' ? '-' : '+');
            }
            System.out.println();
        }
        //Fix the cancer
        Cancer.floodFill(0, 0);
        System.out.println("\nThe file had " + Cancer.count + " cancer spots in it\nThe new grid is:");
        // print out the grid after cancer is fixed
        for (int y = 0; y < Cancer.map.size(); y++) {
            for (int x = 0; x < Cancer.map.get(y).length(); x++) {
                System.out
                        .print(Cancer.map.get(y).charAt(x));
            }
            System.out.println();
        }
    }
    //Create the grid map of cells created with a linked list
    private static LinkedList<String> map = new LinkedList<String>();
    private static int count = 0;
}