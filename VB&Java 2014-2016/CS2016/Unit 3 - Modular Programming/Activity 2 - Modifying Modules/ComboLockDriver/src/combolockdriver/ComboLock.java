/*
 * ComboLock Class
 */
package combolockdriver;

public class ComboLock {

    private int one, two, three;

    //Lock Constructor
    public ComboLock(int juan, int too, int twee) { 
        //Can't use the same varaible name again, so change names slightly
        one = juan;
        two = too;
        three = twee;
    }

    // Some getters to get all of the combo numbers.

    public int getOne() {
        return one;
    }
    public int getThree() {
        return three;
    }
    public int getTwo() {
        return two;
    }
}