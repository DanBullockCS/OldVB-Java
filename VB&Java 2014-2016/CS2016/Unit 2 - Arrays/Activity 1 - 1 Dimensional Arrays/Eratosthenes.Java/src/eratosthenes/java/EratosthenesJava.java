/* Daniel Bullock
 * Feb. 11th 2016
 * Purpose: to find the prime numbers between 1 and 1000
 * Title: Erathosthenes
 */
package eratosthenes.java;

public class EratosthenesJava {

    public static void main(String[] args) {
     //Array of numbers 1 to 1000
     boolean Numbers[] = new boolean[1000]; 
     int intCounter = 0;    //counter
     int intNumber = 0;     //number check variable
             
      for(int i = 2; i < 1000; i++){
         //At the start print out the following
         if(intNumber == 0){
          System.out.print("The prime numbers from 1 - 1000 are: " + "\n"  );
          intNumber = 1;
         }
          
          //Numbers who's multiples can be eliminated from the list
         if(i % 2 == 0 || i % 3 == 0  || i % 5 == 0 || i % 7 == 0 || i % 11 == 0 || i % 13 == 0 || i % 17 == 0 || i % 19 == 0 || i % 23 == 0 || i % 29 == 0 || i % 31 == 0){
             Numbers[i] = true;
         } 
         
         if(Numbers[i] == false || i == 2 || i == 3 || i == 5 || i == 7 || i == 11 || i == 13 || i == 17 || i == 19 || i == 23 || i == 29 || i == 31){
             //new line after 10 numbers are on 1 line and space them out.
             if(intCounter == 10){
               System.out.print("\n" + i + " " );
                intCounter = 1;
             } else if(intCounter < 10) {
               System.out.print(i + " ");
               intCounter += 1;
             }  
            }
           }       
          } 
         }
       
       


