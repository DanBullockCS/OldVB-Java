//Mammal class
package lemurdatabase;

public class Mammal {

    private int itsAge;
    private double itsWeight;
    private String gender;

    public Mammal() {
        itsAge = (int) (Math.random() * 15);
        itsWeight = (double) (Math.random() * 5);
        int num = (int) (Math.random() * 2);
        if (num == 0) {
            gender = "Male";
        } else if (num == 1) {
            gender = "Female";
        }
    }

    public int getAge() {
        return itsAge;
    }

    public void setAge(int newAge) {
        itsAge = newAge;
    }

    public double getWeight() {
        return itsWeight;
    }

    public void setWeight(int newWeight) {
        itsWeight = newWeight;
    }

    public String getGender() {
        return gender;
    }

    public void setGender(String newGender) {
        gender = newGender;
    }

    public String toString() {
        String output = "Age = " + itsAge + "\n";
        output += "Weight = " + itsWeight + "\n";
        output += "Gender = " + gender + "\n";
        if (gender.equals("Female")) {
            output += "Female Lemur = Dominant Role\n";
        }
        return output;
    }
}