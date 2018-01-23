/* Daniel Bullock
 * April 23rd 2016
 * Purpose: Create a program that demonstrates inheritance
 * Title: LemurDatabase.java
 */
package lemurdatabase;

import javax.swing.*;
import java.util.ArrayList;

public class LemurDatabase {

    public static void main(String[] args) {
        //Declare arraylist
        ArrayList<String> lemurList = new ArrayList<String>();

        //How many lemurs to make?
        String num_lemurs = JOptionPane.showInputDialog("How many lemurs do you want to add to the list?");

        //What type of lemur to make?
        for (int i = 0; i < Integer.parseInt(num_lemurs); i++) {
            String lemur_type = JOptionPane.showInputDialog("Enter the type of lemur to add:"
                    + "\n1 - Tree Lemur\n2 - Desert Lemur\n3 - Jungle Lemur");
            if (Integer.parseInt(lemur_type) == 1) {
                TreeLemur lemur1 = new TreeLemur();
                System.out.println("Creating Tree Lemur.");
                lemurList.add("Tree Lemur:\n");
                lemurList.add(lemur1.toString());
            } else if (Integer.parseInt(lemur_type) == 2) {
                DesertLemur lemur1 = new DesertLemur();
                System.out.println("Creating Desert Lemur.");
                lemurList.add("Desert Lemur:\n");
                lemurList.add(lemur1.toString());
            } else if (Integer.parseInt(lemur_type) == 3) {
                JungleLemur lemur1 = new JungleLemur();
                System.out.println("Creating Jungle Lemur.");
                lemurList.add("Jungle Lemur:\n");
                lemurList.add(lemur1.toString());
            }
        }

        //Print out divider and start
        System.out.println("Displaying list of lemurs:\n"
                + "\u001B[36m---------------------------------------------------\n");

        //print the array list
        for (int i = 0; i < lemurList.size(); i++) {
            System.out.print(lemurList.get(i));
        }
    }
}