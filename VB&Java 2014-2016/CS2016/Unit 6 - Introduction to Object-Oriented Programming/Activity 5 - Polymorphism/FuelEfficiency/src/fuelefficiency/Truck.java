//Truck Class
package fuelefficiency;

public class Truck extends Vehicle {
    public Truck() {
    //call Vehicle constructor
    super();
  }
  
   //override the Vehicle getDistance method
    @Override
  public double getDistance() {
    //Truck efficiency
    distance = 100 / 14.1;
    return distance;
  }
}