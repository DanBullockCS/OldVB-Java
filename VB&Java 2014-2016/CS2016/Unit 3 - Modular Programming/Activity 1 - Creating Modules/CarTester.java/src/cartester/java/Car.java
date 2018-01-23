/*
 * Car Class
 */
package cartester.java;

public class Car {
    //Variables for the car's characteristics
    
    private String make, model, colour;
    private int year, price, top_speed;
    
    //Constructors
  public Car() {
    make = "Volkswagen";
    model = "Fox";
    colour = "Black";
    year = 2004;
    price = 9499;
    top_speed = 220;
  }
  
  public Car(String mke, String mdl, String clr, int yr, int prce, int ts) {
    make = mke;
    model = mdl;
    colour = clr;
    year = yr;
    price = prce;
    top_speed = ts;
  }
  
  //Alternate Constructor
  public Car(String mke, String mdl, String clr) {
    make = mke;
    model = mdl;
    colour = clr;
    while (year < 1950) {                           //Make sure the year is not TOO low
        year = (int) (Math.random() * 2016) + 1;
    }
    while (price < 100000) {                        //Make sure the price is not TOO low
    price = (int) (Math.random() * 200000) + 1;
    }
    while (top_speed < 250) {                       //Make sure the top speed is not TOO low
    top_speed = (int) (Math.random() * 349) + 1;
    }
    
  }
  
   public void HonkHorn() {
    System.out.println("HONK! HONK!");
  }

    //method to display all info of the Car
  public String toString() {
    String output = "Make: " + make + "\n";
    output += "Model: " + model + "\n";
    output += "Colour: " + colour + "\n";
    output += "Year: " + year + "\n";
    output += "Price: $" + price + "\n";
    output += "Top speed: " + top_speed + "km/h";
    //output string is complete, return it
    return output;
  }
}
