/*
 *DOG CLASS 
 */
package twodogsmeet.java;

public class Dog {

    private String name, breed;
    private int age, hunger, aggression;
    
    // a dog constructor declaring all variables
    public Dog(String dog_name, String dog_breed, int dog_age, int dog_hunger, int dog_aggression) {
        name = dog_name;
        breed = dog_breed;
        age = dog_age;
        hunger = dog_hunger;
        aggression = dog_aggression;
    }

    // various getters to get information about the dog

    public int getAge() {
        return age;
    }

    public int getAggression() {
        return aggression;
    }

    public String getBreed() {
        return breed;
    }

    public int getHunger() {
        return hunger;
    }

    public String getName() {
        return name;
    }

    public void setAge(int dog_age) {
        age = dog_age;
    }

    public void setAggression(int dog_aggression) {
        aggression = dog_aggression;
    }

    public void setHunger(int dog_hunger) {
        hunger = dog_hunger;
    }
}