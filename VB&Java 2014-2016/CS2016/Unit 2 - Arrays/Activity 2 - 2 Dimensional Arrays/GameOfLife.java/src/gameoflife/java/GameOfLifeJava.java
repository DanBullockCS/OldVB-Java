/* Daniel Bullock
 * Feb. 22nd 2016
 * Purpose: to create a program that simulates a simple life form with a
 * two dimensional array
 * Title: Game of life
 */
package gameoflife.java;
import java.util.Random;

import javax.swing.JOptionPane;
import javax.swing.UIManager;
import javax.swing.UnsupportedLookAndFeelException;

public class GameOfLifeJava {

    public static void main(final String[] args) throws ClassNotFoundException,
            InstantiationException, IllegalAccessException,
            UnsupportedLookAndFeelException {

        // create the grid
        final int[][] grid = new int[20][20];

        UIManager.setLookAndFeel(UIManager.getSystemLookAndFeelClassName());
        int generation = 0;
        int remaining = 400;
        int start = Integer
                .parseInt(JOptionPane
                        .showInputDialog("How many should we start with (0<cells<400) (must be a whole number, no decimals!)"));
        // declare the grid's values
        for (int row = 0; row < grid.length; row++) {
            for (int colom = 0; colom < grid[row].length; colom++) {
                remaining--;
                // reandomly assign the living cells
                final int rand = new Random()
                        .nextInt((start / 100) > 2 ? start / 100 : 2);
                // verify we meet the users requiremnt for cells
                if ((rand == 0 && start > 0)
                        || (remaining - start <= 0 && start != 0)) {
                    grid[row][colom] = 1;
                    start--;
                } else {
                    grid[row][colom] = 0;
                }
            }
        }
        try {
            // loop through the days
            while (true) {
                // excpetion thrown if cancle hit, use cancle to exit
                final String go = JOptionPane
                        .showInputDialog("Type 1 to advance or hit cancle to quit");
                if (!go.equalsIgnoreCase("1")) {// only advance on one
                    continue;
                }
                // print out the current information
                System.out.println("----Generation " + generation + "----");
                for (final int[] element : grid) {
                    for (final int element2 : element) {
                        System.out.print(element2);
                    }
                    System.out.println();
                }
                // up the generation
                generation++;
                // assgin new values due to the rules
                for (int row = 0; row < grid.length; row++) {
                    for (int colom = 0; colom < grid[row].length; colom++) {
                        if (grid[row][colom] == 1) {// alive
                            int left = 0, right = 0, top = 0, bottom = 0;
                            if (colom != 0) {// cant be -
                                left = grid[row][colom - 1];
                            }
                            if (colom != 19) {// max is 19
                                right = grid[row][colom + 1];
                            }
                            if (row != 0) {// cant be -
                                top = grid[row - 1][colom];
                            }
                            if (row != 19) {// max is 19
                                bottom = grid[row][colom];
                            }
                            final int x = left + right + top + bottom;// add all 4 sides
                            if (x < 2 || x > 3) {// apply the rules to check if the cell lives another day
                                grid[row][colom] = 0;
                            }
                        } else if (grid[row][colom] == 0) {// dead
                            int left = 0, right = 0, top = 0, bottom = 0;
                            if (colom != 0) {
                                left = grid[row][colom - 1];
                            }
                            if (colom != 19) {
                                right = grid[row][colom + 1];
                            }
                            if (row != 0) {
                                top = grid[row - 1][colom];
                            }
                            if (row != 19) {
                                bottom = grid[row][colom];
                            }
                            final int x = left + right + top + bottom;
                            if (x == 3) {// check if a new cell should be made
                                grid[row][colom] = 1;
                            }
                        }
                    }
                }
            }
        } catch (final Exception e) {
            // exit
        }
    }
}