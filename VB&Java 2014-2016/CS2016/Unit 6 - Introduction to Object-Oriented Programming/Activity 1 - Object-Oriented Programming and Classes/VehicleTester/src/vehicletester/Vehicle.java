/* Daniel Bullock
 * Vehicle Class
 */
package vehicletester;

public class Vehicle {
    //global variables
    public double gasKilometrage;
    public double fuelTankSize;
    public double fuelAvailable;
    public double kilometresTravelled;
    public double passengers;
    public double fare;
    public double fuelCost;
    //global variables for get methods
    public double revenue;
    public double cost;
    public double profit;

    public Vehicle() {
        //Default Constructor
        gasKilometrage = 0;
        fuelTankSize = 0;
        fuelAvailable = 0;
        kilometresTravelled = 0;
        passengers = 0;
        fare = 0;
        fuelCost = 0;
    }

    public Vehicle(double gK, double fTS, double fA, double kT, double pS, double fE, double fC) {
        gasKilometrage = gK;
        fuelTankSize = fTS;
        fuelAvailable = fA;
        kilometresTravelled = kT;
        passengers = pS;
        fare = fE;
        fuelCost = fC;
    }

    public void addFuel(double gas) {
        if ((fuelTankSize - fuelAvailable) >= gas) {
            fuelAvailable += gas;
            System.out.println("Added " + gas
                    + "L of gas to the tank.");
        } else {
            System.out.println("You tried to add " + gas + "L of gas.");
            System.out.println("There is only room for "
                    + (fuelTankSize - fuelAvailable) + "L.");
        }
    }

    public void driveVehicle(double kms) {
        //Drive the vehicle
        //ex.  If the vehicle uses 9.5L/100 km then
        //litresNeeded = kms * 9.5 / 100
        System.out.println("Drive " + kms + "kms.  Start with "
                + fuelAvailable + "L of gas.");
        double litresNeeded = (kms * gasKilometrage) / 100.0;
        if (fuelAvailable >= litresNeeded) {
            fuelAvailable -= litresNeeded;
            kilometresTravelled += kms;
            System.out.println("Used " + litresNeeded + "L of gas.");
        } else {
            System.out.println("Ran out of fuel!");
            //Calculate how many kms were driven
            double kmsThisDrive = (fuelAvailable * 100.0) / gasKilometrage;
            kilometresTravelled += kmsThisDrive;
            fuelAvailable = 0;
            System.out.println("The vehicle drove " + kmsThisDrive
                    + " before running out of gas.");
        }
    }
    
    //get methods
    public double getRevenue() {
        revenue = fare * passengers;
        return revenue;
    }

    public double getCost() {
        cost = (kilometresTravelled / gasKilometrage) * fuelCost;
        return cost;
    }

    public double getProfit() {
        profit = revenue - cost;
        return profit;
    }
    
    //to string method
    public String toString() {
        String output = "Gas Kilometrage = " + gasKilometrage + "\n";
        output += "Fuel Tank Size = " + fuelTankSize + "\n";
        output += "Fuel Available = " + fuelAvailable + "\n";
        output += "Kilometres Driven = " + kilometresTravelled + "\n";
        output += "Passengers = " + passengers + "\n";
        output += "Fare = " + fare + "\n";
        output += "Fuel Cost = $" + fuelCost + "/L\n";
        return output;
    }
}