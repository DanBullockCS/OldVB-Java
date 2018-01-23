/* Daniel Bullock
 * Feb. 28th 2016
 * Purpose: Create a car class with different defined variables
 * Title: CarTester
 */
package cartester.java;

import javax.swing.*;

public class CarTesterJava {
    
    public static void main(String[] args) {
    Car car1 = new Car();
    Car car2 = new Car("Honda","Civic", "White", 2012, 20000, 244);
    Car car3 = new Car("Lamborghini", "Huracán LP 610-4 Spyder", "Blue");

    for (int i = 0; i != 1;) {
    String input = JOptionPane.showInputDialog("Car Tester:"
            + "\nEnter \"1\" to create car #1."
            + "\nEnter \"2\" to create car #2."
            + "\nEnter \"3\" to create car #3."
            + "\nEnter \"honk\" to honk the cars horn."
            + "\nEnter \"exit\" to exit the program.");
    //Print the details of each car
    if (input.equalsIgnoreCase("1")) {
        System.out.println(car1.toString());
        System.out.println("--------------------------");
    }
    if (input.equalsIgnoreCase("2")) {
      System.out.println(car2.toString());
      System.out.println("--------------------------");      
    }
    //toString() is called by default, no need to write it!
    if (input.equalsIgnoreCase("3")) {
      System.out.println(car3);
      System.out.println("--------------------------");  
    }
    if (input.equalsIgnoreCase("honk")) {
    //car1 honks the horn
    car1.HonkHorn();
    }
    if (input.equalsIgnoreCase("exit")) {
        /*When i = 1 the loop is over and so is the program. It lets the user
        *create each car and honk the horn however many times they want.
        */
        i = 1;  
        System.exit(0);
    }
    }
    }
}
