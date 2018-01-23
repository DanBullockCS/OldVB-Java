//Lemur class
package lemurdatabase;

public class Lemur extends Mammal {

    private String location;
    private String classification;
    private String coat;

    public Lemur() {
        location = "Madagascar";
        classification = "Prosimian";
        coat = "Fur";       
    }

    public String toString() {
        String output = super.toString();
        output += "Location = " + location + "\n";
        output += "Classification = " + classification + "\n";
        output += "Coat = " + coat + "\n";
        return output;
    }
}