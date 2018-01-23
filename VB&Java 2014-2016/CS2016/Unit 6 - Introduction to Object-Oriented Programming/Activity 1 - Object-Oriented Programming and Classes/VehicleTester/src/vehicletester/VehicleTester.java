/* Daniel Bullock
 * April 20th 2016
 * Purpose: Modify the VehicleTester program by adding different variables and methods.
 * Title: VehicleTester.java
 */
package vehicletester;

import javax.swing.*;

public class VehicleTester {
    
    public static String gasPrice;

    public static void main(String[] args) {
        gasPrice = JOptionPane.showInputDialog("What is the price of gas today in $/L?");
        
        Vehicle car1 = new Vehicle(7.5, 60.0, 60.0, 0.0, 15.0, 5.75, Double.parseDouble(gasPrice));
        //Show Vehicle Info
        System.out.println(car1);

        //Drive car for 300km
        car1.driveVehicle(300.0);
        System.out.println(car1);

        //Drive car for 225 kms
        car1.driveVehicle(225.0);
        System.out.println(car1);
        
        //Print out the revenue, cost, and profit
        System.out.println("Revenue = $" + car1.getRevenue());
        System.out.println("Cost = $" + car1.getCost());
        System.out.println("Profit = $" + car1.getProfit());
    }
}