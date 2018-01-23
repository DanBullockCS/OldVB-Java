//HybridCar Class
package fuelefficiency;

public class HybridCar extends Vehicle {
   public HybridCar() {
    //call Vehicle constructor
    super();
  }
    
   //override the Vehicle getDistance method
    @Override
  public double getDistance() {
    //Hybrid efficiency
    distance = 100 / 3.8;
    return distance;
  } 
}