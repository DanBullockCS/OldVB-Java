/* 
 * ATM CLASS
 */
package mybankmachine.java;

public class ATM {
    //Define variables
    private double balance;
    private String bank;

    // Constructor with a string for the name and a double for the initial balance
    public ATM(String bnk, double blnce) {
        bank = bnk;
        balance = blnce;
        setBalance(blnce);
    }
    
    public void deposit(double amount){
        if (amount > 200) {
            System.out.println("You have deposited more then $200, system shutting down...");
            System.exit(0);
        }
        this.setBalance(this.getBalance() + amount);
    }//"this" is a keyword like "me" in visual basic

    public void displayBalance() {
        System.out.println("Your balance is: $" + balance);
    }

    public double getBalance() {
        return balance;
    }

    public String getBank() {
        return bank;
    }

    private void setBalance(double balance) {
        this.balance = balance;
    }

    public void unsafeDeposit(double amount) {
        this.setBalance(this.getBalance() + amount);
    }

    public void withdraw(double amount) {
        if (this.getBalance() - amount < 0) {
           System.out.println("You have withdrawn an amount too large, system shutting down...");
           System.exit(0);
        }
        this.setBalance(this.getBalance() - amount);
    }

}
