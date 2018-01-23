/*Daniel Bullock
 * Feb. 4th 2016
 * Program title: EasterVariation2
 * The purpose of this program is to find the date that easter will occur on
 * a certain year that is inputted by the user
 */

package eastervariation2.java;

import javax.swing.*;

public class EasterVariation2Java {
    public static void main(String[] args) {
 	//a - m - the quotients and remainders needed
     	int a, b, c, d, q, f, g, h, n, j, k, p;
    	int month;  //Easter month
     	int day;    //Easter day
     	int year;   //Easter's year
	String monthStr;

    	//Ask user for year
     	String yearStr = JOptionPane.showInputDialog("Easter "
		+"Date Calculator\nPlease enter a year");

     	//Convert the year from a String to an int
     	year = Integer.parseInt(yearStr);

	//Calculations
	a = year /100;
	b = year % 100;
	c = 3 * (a + 25) / 4;
	d = 3 * (a + 25) % 4;
	q = 8 * (a + 11) / 25;
	f = (5 * a + b) % 19;
	g = (19 * f + c - q) % 30;
	h = (f + 11 * g) / 319;
	k = (60 * (5 - d) + b) % 4;
	j = (60 * (5 - d) + b) / 4;
	n = (2 * j - k - g + h) % 7;
        month = (g - h + n + 114) / 31;
	p = (g - h + n + 114) % 31;
	day = (p + 1) / 1;

    	//determine the month in String format
    	if(month == 3){
            monthStr = "March";
     	} else {
            monthStr = "April";
     	}

    	//Display the results
     	JOptionPane.showMessageDialog(null, "Easter will fall"
		+" on Sunday, "+monthStr+" "+day+", "+year);
    }
}