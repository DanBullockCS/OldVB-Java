//Car Class
package fuelefficiency;

public class Car extends Vehicle {
    public Car() {
    //call Vehicle constructor
    super();
  }
    
   //override the Vehicle getDistance method
    @Override
  public double getDistance() {
    //Car efficiency
    distance = 100 / 9.4;
    return distance;
  }
}