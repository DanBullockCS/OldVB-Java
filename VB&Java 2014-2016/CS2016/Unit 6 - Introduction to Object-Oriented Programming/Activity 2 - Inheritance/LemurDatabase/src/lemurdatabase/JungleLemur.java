//JungleLemur class
package lemurdatabase;

public class JungleLemur extends Lemur {

    private String colour;
    private String packSize;
    private String food;

    public JungleLemur() {
        super();
        colour = "Black or Blue";
        packSize = "Small groups";
        food = "Mice, snails, and insects";
    }

    public String toString() {
        String output = super.toString();
        output += "Food = " + food + "\n";
        output += "Colour = " + colour + "\n";
        output += "Pack Size = " + packSize + "\n\n";
        return output;
    }
}