/* Daniel Bullock
 * April 12th 2016
 * Purpose: Sort a random list of numbers from 1-1000 using 4 different sorting
 * algorithms (selection, bubble, insertion, quick).
 * Title: SortingRoutines.java
 */
package sortingroutines;

//Import to use JOptionPane
import javax.swing.*;

public class SortingRoutines {

    public static void main(String[] args) {
        //Find how many numbers to sort
        String num_of_nums = JOptionPane.showInputDialog("How many random"
                + " numbers do you wish to generate?");
        //Choose sorting algorithm
        String sort_type = JOptionPane.showInputDialog("What type of sort would"
                + " you like to perform?\n1 - Selection Sort\n2 - Bubble Sort\n3"
                + " - Insertion Sort\n4 - Quick Sort");
        //Find out whether to sort in Ascending or Descending order
        String sort_order = JOptionPane.showInputDialog("In what order do you "
                + "want the numbers sorted?\n1 - Ascending\n2 - Descending");
        //Variable for printing out if ascending or descending at the end
        String AorD = "";
        if (sort_order.equals("1")) {
            AorD = "Ascending";
        } else if (sort_order.equals("2")) {
            AorD = "Descending";
        }

        //Declare array
        int num_array[] = new int[Integer.parseInt(num_of_nums)];

        //Populate array with random numbers
        for (int i = 0; i < num_array.length; i++) {
            num_array[i] = (int) (Math.random() * 1000 + 1);
        }

        //Print out unsorted list
        System.out.println("The unsorted list is:");
        for (int count = 0; count < num_array.length; count++) {
            System.out.print(num_array[count] + " ");
        }
        System.out.println("\n---------------------------------");

        //Sort using one of the 4 algorithms
        if (Integer.parseInt(sort_type) == 1) {
            System.out.println("Performing " + AorD + " Selection Sort");
            selectionSort(num_array);
        } else if (Integer.parseInt(sort_type) == 2) {
            System.out.println("Performing " + AorD + " Bubble Sort");
            bubbleSort(num_array);
        } else if (Integer.parseInt(sort_type) == 3) {
            System.out.println("Performing " + AorD + " Insertion Sort");
            insertionSort(num_array);
        } else if (Integer.parseInt(sort_type) == 4) {
            System.out.println("Performing " + AorD + " Quick Sort");
            quickSort(num_array, 0, num_array.length - 1);
        }

        //Ascending order
        if (sort_order.equals("1")) {
            //Print out sorted list
            System.out.println("The sorted list is:");
            for (int count = 0; count < num_array.length; count++) {
                System.out.print(num_array[count] + " ");
            }
        }

        //Descending order
        if (sort_order.equals("2")) {
            //Print out sorted list
            System.out.println("The sorted list is:");
            for (int count = num_array.length - 1; count >= 0; count--) {
                System.out.print(num_array[count] + " ");
            }
        }


    }

    public static void selectionSort(int data[]) {
        int smallest;
        for (int i = 0; i < data.length - 1; i++) {
            smallest = i;
            //see if there is a smaller number further in the array
            for (int index = i + 1; index < data.length; index++) {
                if (data[index] < data[smallest]) {
                    swap(data, smallest, index);
                }
            }
        }
    }

    public static void bubbleSort(int data[]) {
        //Loop to control number of passes
        for (int pass = 1; pass < data.length; pass++) {
            //Loop to control # of comparisons for length of array-1
            for (int element = 0; element < data.length - 1; element++) {
                //Compare side-by-side elements and swap them if
                //First element is greater than second element
                if (data[element] > data[element + 1]) {
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
            insert = data[next];
            int moveItem = next;

            while (moveItem > 0 && data[moveItem - 1] > insert) {
                data[moveItem] = data[moveItem - 1];
                moveItem--;
            }
            data[moveItem] = insert;
        }
    }

    public static void quickSort(int data[], int low, int high) {
        int partitionLoc;
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
            if (moveLeft == true) {
                while ((data2[right] >= separator) && (left < right)) {
                    right--;
                }
                data2[left] = data2[right];
                moveLeft = false;
            } else {
                while ((data2[left] <= separator) && (left < right)) {
                    left++;
                }
                data2[right] = data2[left];
                moveLeft = true;
            }
        }
        data2[left] = separator;
        return left;
    }
}