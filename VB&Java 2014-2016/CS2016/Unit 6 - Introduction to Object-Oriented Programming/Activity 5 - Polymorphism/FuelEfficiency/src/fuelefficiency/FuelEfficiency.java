/* Daniel Bullock
 * May 2nd 2016
 * Purpose: Demonstrate polymorphism with multiple classes
 * Title: FuelEfficiency.java
 */
package fuelefficiency;

import javax.swing.JOptionPane;

public class FuelEfficiency {

    public static void main(final String[] args) {
        //Input
        double litres = Double.parseDouble(JOptionPane.showInputDialog("How many litres of gas do you have?"));

        //Create each vehicle
        Vehicle truck = new Truck();
        Vehicle car = new Car();
        Vehicle hybrid = new HybridCar();
        Vehicle motorcycle = new Motorcycle();

        //Print out information with the numbers times the litres
        System.out.println("On " + litres + "L of gas the vehicles can drive:\n");
        System.out.println("Car = " + car.getDistance() * litres +  "km");
        System.out.println("Truck = " + truck.getDistance()  * litres + "km");
        System.out.println("Hybrid Car = " + hybrid.getDistance() * litres + "km");
        System.out.println("Motorcycle = " + motorcycle.getDistance() * litres + "km");
    }
}