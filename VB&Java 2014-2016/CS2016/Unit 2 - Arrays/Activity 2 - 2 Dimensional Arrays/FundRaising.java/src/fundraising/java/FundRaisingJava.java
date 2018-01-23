/* Daniel Bullock
 * Feb. 17th 2016
 * Purpose: to create a program that will estimate the potential donation 
 * earnings with two dimensional arrays.
 * Title: FundRaising
 */
package fundraising.java;

import javax.swing.*;

public class FundRaisingJava {

public static void main(String[] args) {
    //Declare variables including array
        double[][] population_array = new double[8][4]; //8 schools and 4 money options
        int school_number;
        int donation_amount;
        double population;
        double subtotal;
        double total = 0.0;
        double counter = 0.25;

    /*Find what school(s) is/are donating, how much each student 
    * is donating and how many students are in each school.
    */
    for (int i = 0; i != 8;) {
    String school_name = JOptionPane.showInputDialog("Which school is "
            + "fundraising?\n0 - Catholic Central\n1 - Holy Cross\n2 - John Paul"
            + " II\n3 - Mother Teresa\n4 - Regina Mundi\n5 - St. Joseph\n6 - "
            + "St. Mary\n7 - St. Thomas Aquinas\n8 - EXIT");
    school_number = Integer.parseInt(school_name);

    if(school_number != 8){
        String donation = JOptionPane.showInputDialog("What is the donation "
            + "amount?\n0 - 25 cents\n1 - 50 cents\n2 - 1 dollar\n3 - 2 dollars");
        donation_amount = Integer.parseInt(donation);
        String students = JOptionPane.showInputDialog("What is the school "
                + "population?");
        population = Double.parseDouble(students);
        population_array[school_number][donation_amount] = population;
    }else{
        i = school_number;
            }
        }

    //Find and print values of donations
    System.out.println("======================================"
            + "=======================================\n"); 
    System.out.print("\tCathCen\tHoly C\tJP II\tMotherT\tReginaM\tSt.Joe"
            + "\tSt.Mary\tSt.Thom\tTOTAL\n");
    for (int i = 0; i < population_array[i].length; i++) {
        if (counter == 0.25){
            System.out.print("$" + counter + " - ");
            } else {
            System.out.print("$" + counter + "0 - ");
        }
        subtotal = 0;
    for (int j=0;j < population_array.length;j++){
        System.out.print(population_array[j][i]+"\t");
        subtotal += population_array[j][i];
    }
        System.out.print(subtotal + "\n");
        total += subtotal * counter;
        counter = counter * 2 + 0.00;
    }
    //Print final donation total into a line
        System.out.print("TOTAL DONATIONS = $" + total + "0");
    }
}