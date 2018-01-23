//Cell Phone Class
package phonetester;

public class CellPhone {

    private String carrier, type;
    private double speed, memory;
    private int numApps;

    //constructor for creating a phone object
    public CellPhone(String carry, String tipe, double sped,
            double mem, int num) {
        carrier = carry;
        type = tipe;
        memory = mem;
        speed = sped;
        numApps = num;
    }

    public int getApps() {
        return numApps;
    }

    // getters
    public String getCarrier() {
        return carrier;
    }

    public double getMemory() {
        return memory;
    }

    public double getSpeed() {
        return speed;
    }

    public String getType() {
        return type;
    }

    public void setApps(int num) {
        numApps = num;
    }

    //set methods
    public void setCarrier(String carry) {
        carrier = carry;
    }

    public void setMemory(double mem) {
        memory = mem;
    }

    public void setSpeed(double sped) {
        speed = sped;
    }

    public void setType(String tipe) {
        type = tipe;
    }
}