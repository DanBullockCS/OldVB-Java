/* Daniel Bullock
 * March 1st 2016
 * Purpose: Simulate two dogs meeting and use a dog class to keep their info.
 * Title: TwoDogsMeet
 */
package twodogsmeet.java;

import java.util.Random;  //Lets you create random

import javax.swing.*;

public class TwoDogsMeetJava {

    public static void main(String[] args) {

        //You are creating two dogs
        JOptionPane.showMessageDialog(null, "2 dogs will be created.");

        //blank array for the 2 dogs.
        Dog[] dogs = new Dog[2];

        //set up the dog's info for all of the dogs
        for (int i = 0; i < dogs.length; i++) {
            String name = JOptionPane.showInputDialog("What is the "
                    + (i + 1) + " dogs name?");
            String breed = JOptionPane.showInputDialog("What is the "
                    + (i + 1) + " dogs breed?");

            // randomly apply some of the dogs variables
            Random r = new Random();
            int initial_age = r.nextInt(15);
            int inital_hunger = r.nextInt(11);
            int initial_aggression = r.nextInt(11);

            // verify the information with the user
            String age = JOptionPane
                    .showInputDialog("Dog "
                            + (i + 1)+ " is "+ initial_age+ " years old. Is that"
                    + " okay? (If yes type \"ok\""
                    + " otherwise type the new age)");
            String hunger = JOptionPane
                    .showInputDialog("Dog "
                            + (i + 1) + "'s hunger on a scale from 1-10 is " + 
                    inital_hunger + " . Is that okay? (If yes type \"ok\" "
                    + "otherwise type the new hunger level)");
            String aggression = JOptionPane
                    .showInputDialog("Dog "
                            + (i + 1) + "'s aggression on a scale from 1-10 is "
                    + initial_aggression + " . Is that okay? (If yes type \"ok\""
                    + " otherwise type the new aggression level)");
            if (!age.equalsIgnoreCase("ok")) {
                initial_age = Integer.parseInt(age);
            }
            if (!hunger.equalsIgnoreCase("ok")) {
                inital_hunger = Integer.parseInt(hunger);
            }
            if (!aggression.equalsIgnoreCase("ok")) {
                initial_aggression = Integer.parseInt(aggression);
            }

            // create the instance of the dog
            dogs[i] = new Dog(name, breed, initial_age, inital_hunger,
                    initial_aggression);

            // prints out the dogs information in a message box 
            JOptionPane.showMessageDialog(null, dogs[i].getName() + " is a "
                    + dogs[i].getBreed() + " which is " + dogs[i].getAge()
                    + " of age. The dog hunger level is " + dogs[i].getHunger()
                    + " and its aggression level is " + dogs[i].getAggression());
        }

        // Simulate a fight if their aggressions together are > 10 and hungers are < 5
        if (dogs[0].getAggression() + dogs[1].getAggression() >
                10 && dogs[0].getHunger() + dogs[1].getHunger() < 5) {
            System.out.println("GRR! RRRFFF!");
            JOptionPane.showMessageDialog(null, "OH NO DOG FIGHT!");
        } else {// otherwise no fight
            System.out.println("Arf! Arf!");
            JOptionPane.showMessageDialog(null, "The dogs like each other.");
        }
    }
}