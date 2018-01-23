/* Daniel Bullock
 * April 28th 2016
 * Purpose:
 * Title: AnimalShelterTester.java
 */
package animalsheltertester;

import javax.swing.*;

public class AnimalShelterTester {

    public static void main(String[] args) {
        String myInput = "";
        AnimalShelter myShelter = new AnimalShelter();

        myInput = JOptionPane.showInputDialog(
                "How many dogs would you like to start the shelter with?");
        for (int i = 0; i < Integer.parseInt(myInput); i++) {
            myShelter.addDog(JOptionPane.showInputDialog("Dog's name?"),
                    JOptionPane.showInputDialog("Dog's breed?"));
        }

        while (!myInput.equals("5")) {
            myInput = JOptionPane.showInputDialog(
                    "Please choose from the following menu:\n"
                    + "1 - Display list of dogs\n"
                    + "2 - Add a dog to the shelter\n"
                    + "3 - Remove a dog from the shelter\n"
                    + "4 - Display the operating cost of the shelter\n"
                    + "5 - Exit the program");
            if (myInput.equals("1")) {
                System.out.println(myShelter.toString());
            } else if (myInput.equals("2")) {
                myShelter.addDog(JOptionPane.showInputDialog(
                        "Dog's name?"), JOptionPane.showInputDialog("Dog's breed?"));
            } else if (myInput.equals("3")) {
                String Input = JOptionPane.showInputDialog(
                        "What dog would you like to get rid of? (Enter the entry #)");
                myShelter.removeDog(Integer.parseInt(Input));
            } else if (myInput.equals("4")) {
                System.out.println("The cost for holding "
                        + (myShelter.Cost() / 15 + " dogs is: " + myShelter.Cost()));
            } else if (myInput.equals("5")) {
                System.exit(0);
            } else {
                JOptionPane.showMessageDialog(null, "No.");
            }
        }
    }
}
