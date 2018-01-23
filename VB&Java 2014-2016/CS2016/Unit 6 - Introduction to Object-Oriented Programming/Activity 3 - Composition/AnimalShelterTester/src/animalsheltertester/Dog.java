//Dog Class
package animalsheltertester;

import javax.swing.*;

public class Dog {
    //variables for characteristics
    private String dogName, dogBreed;
    private int age, weight;
    public int removed;
    
    //constructor
    public Dog(String dgName, String dgBreed, int agg, int hung) {
        dogName = dgName;
        dogBreed = dgBreed;
        age = agg;
        weight = hung;
    }

    //Alternate constructor
    public Dog(String dgName, String dgBreed) {
        dogName = dgName;
        dogBreed = dgBreed;
        age = (int) (Math.random() * 15) + 1;
        weight = (int) (Math.random() * 16) + 1;
    }

    public String toString() {
        String output = "\nName: " + dogName + "\n";
        output += "Breed: " + dogBreed + "\n";
        output += "Age: " + age + "\n";
        output += "Weight: " + weight + "\n\n";
        //output string is complete, return it
        return output;
    }
}
