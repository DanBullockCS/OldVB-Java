/* Daniel Bullock
 * April 14th 2016
 * Purpose: Use different searching methods and prove the more efficient one.
 * Title: SearchEfficiencies.java
 */
package searchefficiencies;

import javax.swing.*;

public class SearchEfficiencies {
    //Global variables for counting
    public static int loopCounter;
    public static int comparisonCounter;

    public static void main(String[] args) {
        //Find how many numbers the user wants
        String num_of_nums = JOptionPane.showInputDialog("How many random"
                + " numbers do you wish to generate?");
        //Declare array
        int num_array[] = new int[Integer.parseInt(num_of_nums)];
        //Populate array with random numbers
        for (int i = 0; i < num_array.length; i++) {
            num_array[i] = (int) (Math.random() * 1000 + 1);
        }
        //print out unsorted array
        for (int count = 0; count < num_array.length; count++) {
            System.out.println(num_array[count] + " ");
        }
        //Search for a number
        String search_num = JOptionPane.showInputDialog("What number do you "
                + "want to search for?");
        //timer variable
        long time = -1; //timer variable

        //Unsorted linear search
        System.out.println("-----------------------------------");
        System.out.println("Performing Linear Search (unsorted list)");
        System.out.println("Search returned: " + linearSearch(num_array, Integer.parseInt(search_num)));
        time = System.currentTimeMillis();
        linearSearch(num_array, Integer.parseInt(search_num));
        time = System.currentTimeMillis() - time;
        System.out.println("Processing Time: " + time + "ms");
        System.out.println("loopCounter = " + loopCounter);
        System.out.println("comparisonCounter = " + comparisonCounter);

        //Sorted linear search
        bubbleSort(num_array);
        System.out.println("-----------------------------------");
        System.out.println("Performing Linear Search (sorted list)");
        System.out.println("Search returned: " + linearSearch(num_array, Integer.parseInt(search_num)));
        time = System.currentTimeMillis();
        linearSearch(num_array, Integer.parseInt(search_num));
        time = System.currentTimeMillis() - time;
        System.out.println("Processing Time: " + time + "ms");
        System.out.println("loopCounter = " + loopCounter);
        System.out.println("comparisonCounter = " + comparisonCounter);

        //Sorted binary search
        System.out.println("-----------------------------------");
        System.out.println("Performing Binary Search (sorted list)");
        System.out.println("Search returned: " + binarySearch(num_array, 0, Integer.parseInt(num_of_nums) - 1, Integer.parseInt(search_num)));
        time = System.currentTimeMillis();
        binarySearch(num_array, 0, Integer.parseInt(num_of_nums) - 1, Integer.parseInt(search_num));
        time = System.currentTimeMillis() - time;
        System.out.println("Processing Time: " + time + "ms");
        System.out.println("loopCounter = " + loopCounter);
        System.out.println("comparisonCounter = " + comparisonCounter);
    }

    public static boolean linearSearch(int myArray[], int searchForNum) {
        int k;
        for (k = 0; k < myArray.length; k++) {
            loopCounter++;

            comparisonCounter++;
            if (myArray[k] == (searchForNum)) {
                return true;
            }
            comparisonCounter++;
            if (myArray[k] > 0) {
                //Gone too far on the list so the number doesn't exist
                return false;
            }
        }
        return false;
    }

    public static void bubbleSort(int data[]) {
        //Loop to control number of passes
        for (int pass = 1; pass < data.length; pass++) {
            loopCounter++;
            //Loop to control # of comparisons for length of array - 1
            for (int element = 0; element < data.length - 1; element++) {
                loopCounter++;
                //compare side-by-side elements and swap them if
                //first element is greater than second element
                comparisonCounter++;
                if (data[element] > data[element + 1]) {
                    swap(data, element, element + 1);
                }
            }
        }
    }

    public static void swap(int array2[], int first, int second) {
        int hold = array2[first];
        array2[first] = array2[second];
        array2[second] = hold;
    }

    public static boolean binarySearch(int myArray[], int left, int right, int searchForNum) {
        loopCounter++;
        int middle;
        comparisonCounter++;
        if (left > right) {
            return false;
        }
        middle = (left + right) / 2;
        comparisonCounter++;
        if (myArray[middle] == (searchForNum)) {
            return true;
        }
        comparisonCounter++;
        if (myArray[middle] < 0) {
            return binarySearch(myArray, left, middle - 1, searchForNum);
        } else {
            return binarySearch(myArray, middle + 1, right, searchForNum);
        }
    }
}