/* Daniel Bullock
 * March 1st 2016
 * Purpose: Simulate an ATM with a ATM class so you may deposit and withdraw money,
 * and calculate your interest.
 * Title: MyBankMachine
 */
package mybankmachine.java;

import javax.swing.*;

public class MyBankMachineJava {

    public static void main(String[] args) {
        String bank_name = JOptionPane.showInputDialog("ATM: Please enter your bank name");
        
        //the whole program is within a while loop
        while (true) {
             String option = JOptionPane.showInputDialog("Welcome to the " + bank_name
                     + " ATM, please enter a number to continue.\n1. Deposit\n2."
                     + " Withdraw\n3. Check balance\n4. Daily interest feature\n5. Exit");
            // switch through case options
            switch (option) {
                case "1":
                        MyBankMachineJava.bank.deposit(Double.parseDouble(JOptionPane
                        .showInputDialog("How much would you like to deposit?")));
                    break;
                case "2":
                    // withdraw
                        MyBankMachineJava.bank.withdraw(Double.parseDouble(JOptionPane
                        .showInputDialog("How much would you like to withdraw?")));     
                    break;
                case "3":
                    // display the balance
                    MyBankMachineJava.bank.displayBalance();
                    break;
                case "4":
                    // calculate interest
                     double start = Double.parseDouble(JOptionPane.showInputDialog
                             ("How much would you like to start with?"));
                    if (start > MyBankMachineJava.bank.getBalance()) {              // check if start amount is not 
                        JOptionPane.showMessageDialog(null,                         // larger then the actual account balance
                                "You have exceeded you maximum balance of: "
                                        + MyBankMachineJava.bank.getBalance());
                        continue;  //continue statement re-executes the if statement
                    }
                     double rate = Double.parseDouble(JOptionPane.showInputDialog
                             ("What is the annual interest rate"));
                     int days = Integer.parseInt(JOptionPane.showInputDialog
                             ("How many days would you like to collect interest?"));
                     double interest = start * Math.pow((1 + rate), days);      //interest formula A = P(1 + i)^n
                    MyBankMachineJava.bank.unsafeDeposit(interest);
                    JOptionPane.showMessageDialog(null, "You have gained $"
                            + interest + " of interest over " + days + " days.");
                    break;
                    /*Interest formula variables to my variables
                    * A = interest
                    * P = start
                    * i = rate
                    * n = days
                    */
                case "5":
                    // exit the ATM program
                    System.exit(0);
                    break;
            }
        }
    }
    // Create an instance of the ATM
    private static ATM bank = new ATM("Bank Name", 0);
}