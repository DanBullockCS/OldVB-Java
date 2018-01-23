//TreeLemur class
package lemurdatabase;

public class TreeLemur extends Lemur {

    private String colour;
    private String packSize;
    private String food;

    public TreeLemur() {
        super();
        colour = "Red";
        packSize = "Large groups";
        food = "Fruits";
    }

    public String toString() {
        String output = super.toString();
        output += "Food = " + food + "\n";
        output += "Colour = " + colour + "\n";
        output += "Pack Size = " + packSize + "\n\n";
        return output;
    }
}