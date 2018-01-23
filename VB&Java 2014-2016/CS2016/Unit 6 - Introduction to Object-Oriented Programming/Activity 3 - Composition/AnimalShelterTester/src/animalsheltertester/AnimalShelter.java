//AnimalShelter Class
package animalsheltertester;

import javax.swing.*;

public class AnimalShelter {
    private Dog doggo[] = new Dog[50];
    int index = 1, dogCounter = 0;
    String output, cost;

    public AnimalShelter() {
        
    }

    public void addDog(String name, String breed) {
        doggo[index] = new Dog(name, breed);
        index += 1;
    }

    public void removeDog(int index) {
        doggo[index].removed = 1;
    }

    public String toString() {
        dogCounter = 0;
        output = "";
        for (int i = 1; i < index; i++) {
            if (doggo[i].removed != 1) {
                dogCounter += 1;
                output += "Dog #: " + dogCounter;
                output += doggo[i].toString();
            }
        }
        return output;
    }

    public int Cost() {
        int Num = index;
        for (int i = 1; i < index; i++) {
            if (doggo[i].removed == 1) {
                Num -= 1;
            }
        }
        Num = (Num - 1) * 15;
        return Num;
    }
}
