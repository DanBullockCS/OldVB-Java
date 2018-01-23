/* Daniel Bullock
 * April 16th 2016
 * Purpose: Use different sorting methods and prove the more efficient one.
 * Title: SortEfficiencies.java
 */
package sortefficiencies;

import javax.swing.*;
//MORE LOOPS FOR INSERTION

public class SortEfficiencies {
    //Global variables for counting

    public static int loopCounter;
    public static int comparisonCounter;
    public static int shiftCounter;

    public static void main(String[] args) {
        //Find how many numbers to sort
        String num_of_nums = JOptionPane.showInputDialog("How many random"
                + " numbers do you wish to generate?");

        //Declare array
        int num_array[] = new int[Integer.parseInt(num_of_nums)];
        //Declare another array that will be sorted
        int num_array_alt[] = new int[Integer.parseInt(num_of_nums)];

        //Populate arrays with random numbers
        for (int i = 0; i < num_array.length; i++) {
            num_array[i] = (int) (Math.random() * 1000 + 1);
            num_array_alt[i] = num_array[i];
        }

        //Print the unsorted list
        System.out.println("The unsorted list is:");
        for (int count = 0; count < num_array.length; count++) {
            System.out.println(num_array[count] + " ");
        }

        //timer variable
        long time = -1; //timer variable

        //Selection sorting
        System.out.println("\n-----------------------------------");
        System.out.println("Performing Selection Sort");
        time = System.currentTimeMillis();
        selectionSort(num_array_alt);
        time = System.currentTimeMillis() - time;
        System.out.println("Processing Time: " + time + "ms");
        System.out.println("loopCounter = " + loopCounter);
        System.out.println("comparisonCounter = " + comparisonCounter);
        System.out.println("shiftCounter = " + shiftCounter);
        loopCounter = 0;
        comparisonCounter = 0;
        shiftCounter = 0;
        //Copy the original array back into the alternate
        System.arraycopy(num_array, 0, num_array_alt, 0, num_array.length);

        //Bubble sorting
        System.out.println("\n-----------------------------------");
        System.out.println("Performing Bubble Sort");
        time = System.currentTimeMillis();
        bubbleSort(num_array_alt);
        time = System.currentTimeMillis() - time;
        System.out.println("Processing Time: " + time + "ms");
        System.out.println("loopCounter = " + loopCounter);
        System.out.println("comparisonCounter = " + comparisonCounter);
        System.out.println("shiftCounter = " + shiftCounter);
        loopCounter = 0;
        comparisonCounter = 0;
        shiftCounter = 0;
        //Copy the original array back into the alternate
        System.arraycopy(num_array, 0, num_array_alt, 0, num_array.length);

        //Insertion sorting
        System.out.println("\n-----------------------------------");
        System.out.println("Performing Insertion Sort");
        time = System.currentTimeMillis();
        insertionSort(num_array_alt);
        time = System.currentTimeMillis() - time;
        System.out.println("Processing Time: " + time + "ms");
        System.out.println("loopCounter = " + loopCounter);
        System.out.println("comparisonCounter = " + comparisonCounter);
        System.out.println("shiftCounter = " + shiftCounter);
        loopCounter = 0;
        comparisonCounter = 0;
        shiftCounter = 0;
        //Copy the original array back into the alternate
        System.arraycopy(num_array, 0, num_array_alt, 0, num_array.length);

        //Quick sorting
        System.out.println("\n-----------------------------------");
        System.out.println("Performing Quick Sort");
        time = System.currentTimeMillis();
        quickSort(num_array_alt, 0, num_array_alt.length - 1);
        time = System.currentTimeMillis() - time;
        System.out.println("Processing Time: " + time + "ms");
        System.out.println("loopCounter = " + loopCounter);
        System.out.println("comparisonCounter = " + comparisonCounter);
        System.out.println("shiftCounter = " + shiftCounter);
    }

    public static void selectionSort(int data[]) {
        int smallest;
        for (int i = 0; i < data.length - 1; i++) {
            loopCounter++;
            smallest = i;
            //see if there is a smaller number further in the array
            for (int index = i + 1; index < data.length; index++) {
                loopCounter++;
                comparisonCounter++;
                if (data[index] < data[smallest]) {
                    swap(data, smallest, index);      
                }
            }
            shiftCounter++;
        }
    }

    public static void bubbleSort(int data[]) {
        //Loop to control number of passes
        for (int pass = 1; pass < data.length; pass++) {
            loopCounter++;
            //Loop to control # of comparisons for length of array-1
            for (int element = 0; element < data.length - 1; element++) {
                loopCounter++;
                //Compare side-by-side elements and swap them if
                //First element is greater than second element
                comparisonCounter++;
                if (data[element] > data[element + 1]) {
                    shiftCounter++;
                    swap(data, element, element + 1);  //Call swap method
                }
            }
        }
    }

    //Swap method for selection and bubble sort.
    public static void swap(int array2[], int first, int second) {
        int hold = array2[first];
        array2[first] = array2[second];
        array2[second] = hold;
    }

    public static void insertionSort(int data[]) {
        int insert;
        for (int next = 1; next < data.length; next++) {
            loopCounter++;
            insert = data[next];
            int moveItem = next;
            while (moveItem > 0 && data[moveItem - 1] > insert) {
                loopCounter++;
                data[moveItem] = data[moveItem - 1];
                shiftCounter++;
                moveItem--;
            }
            shiftCounter++;
            data[moveItem] = insert;
        }
    }

    public static void quickSort(int data[], int low, int high) {
        int partitionLoc;
        comparisonCounter++;
        if (low < high) {
            partitionLoc = partition(data, low, high);
            quickSort(data, low, partitionLoc - 1);
            quickSort(data, partitionLoc + 1, high);
        }
    }

    //Partition method for quick sort
    public static int partition(int data2[], int left, int right) {
        boolean moveLeft = true;
        int separator = data2[left];
        while (left < right) {
            loopCounter++;
            if (moveLeft == true) {
                comparisonCounter++;
                while ((data2[right] >= separator) && (left < right)) {
                    loopCounter++;
                    right--;
                }
                data2[left] = data2[right];
                shiftCounter++;
                moveLeft = false;
            } else {
                comparisonCounter++;
                while ((data2[left] <= separator) && (left < right)) {
                    loopCounter++;
                    left++;
                }
                data2[right] = data2[left];
                shiftCounter++;
                moveLeft = true;
            }
        }
        data2[left] = separator;
        shiftCounter++;
        return left;
    }
}