//DesertLemur class
package lemurdatabase;

public class DesertLemur extends Lemur {

    private String colour;
    private String babyDeathRate;
    private String food;

    public DesertLemur() {
        super();
        colour = "White";
        babyDeathRate = "0.66";
        food = "Cacti";
    }

    public String toString() {
        String output = super.toString();
        output += "Food = " + food + "\n";
        output += "Colour = " + colour + "\n";
        output += "Baby Death Rate= " + babyDeathRate + "\n\n";
        return output;
    }
}