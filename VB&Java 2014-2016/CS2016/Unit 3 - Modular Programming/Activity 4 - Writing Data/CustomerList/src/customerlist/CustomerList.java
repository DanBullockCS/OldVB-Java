/* Daniel Bullock
 * March 8th 2016
 * Purpose: create a program that stores information about a customer in a file
 * and has the ability to add information to that file by writing to it.
 * Title: CustomerList
 */
package customerlist;

import java.io.*;
import javax.swing.*;

public class CustomerList {

    public static void main(String[] args) throws IOException {
        /*Check if the postal code is in the correct
        *format boolean
        */
        boolean isPostal = false;   
        
          BufferedReader readFile = new BufferedReader(new FileReader("Customers.txt"));
            String theLine;//Each line as a string
            //Read what the file already contains
            while ((theLine = readFile.readLine()) != null) {
            System.out.println(theLine); //print out the line
        }
            readFile.close();   //close the file
  
            //Start writing to the file
            //Ask how many customers should be added
            String number_of_customers = JOptionPane.showInputDialog("How many customers would you like to add?");
            int int_customer = Integer.parseInt(number_of_customers);
            //Ask user for all the customer information
            for(int i = 1; i <= int_customer ; i++){
            String name = JOptionPane.showInputDialog("Enter the customer's name.");
            String address = JOptionPane.showInputDialog("Enter the customer's address.");
            String city = JOptionPane.showInputDialog("Enter the city where the customer lives.");
            String province = JOptionPane.showInputDialog("Enter the province where the customer lives.");
            String postal_code = JOptionPane.showInputDialog("Enter the customer's postal code. (No space in between).");
            //Check if the postal code is in correct format
            if(!Character.isLetter(postal_code.charAt(0)) || !Character.isDigit(postal_code.charAt(1)) || !Character.isLetter(postal_code.charAt(2)) ||
               !Character.isDigit(postal_code.charAt(3)) || !Character.isLetter(postal_code.charAt(4)) || !Character.isDigit(postal_code.charAt(5))) {
                isPostal = true;
              //Keep asking if the postal code is in correct format and dont move on until it is
                while (isPostal != false) {        
                JOptionPane.showMessageDialog(null, "Please try writing the postal code in correct format (L#L#L#)");
                postal_code = JOptionPane.showInputDialog("Enter the customer's postal code. (No space in between).");
                //Postal code is in right format, continue with program
                if(Character.isLetter(postal_code.charAt(0)) && Character.isDigit(postal_code.charAt(1)) && Character.isLetter(postal_code.charAt(2)) &&
                   Character.isDigit(postal_code.charAt(3)) && Character.isLetter(postal_code.charAt(4)) && Character.isDigit(postal_code.charAt(5))) {
                    isPostal = false;
                }
                }
                } else {
                isPostal = false; //Postal code was initially in the right format, move on with code
            }
            String myLine;          
    //PrintWriter class is used to open a file for output
    //It is used in conjunction with the FileWriter class
      
    PrintWriter fileOut = new PrintWriter(new FileWriter("Customers.txt", true));
        myLine = "Name: " + name;
      //Output NAME directly to file
      fileOut.println("---------------------------");
      fileOut.println(myLine);
    
        myLine = "Address: " + address;
      //Output ADDRESS directly to file
      fileOut.println(myLine);
    
        myLine = "City: " + city;
      //Output CITY directly to file
      fileOut.println(myLine);
   
        myLine = "Province: " + province;
      //Output PROVINCE directly to file
      fileOut.println(myLine);
    
        myLine = "Postal Code: " + postal_code;
      //Output POSTAL CODE directly to file
      fileOut.println(myLine);
    
    //The file must be closed after writing is complete
    fileOut.close();
   }
   }
   }