//Motorcycle Class
package fuelefficiency;

public class Motorcycle extends Vehicle {
    public Motorcycle() {
    //call Vehicle constructor
    super();
  }
    
   //override the Vehicle getDistance method
    @Override
  public double getDistance() {
    //Motorcycle efficiency
    distance = 100 / 6.3;
    return distance;
  }
}