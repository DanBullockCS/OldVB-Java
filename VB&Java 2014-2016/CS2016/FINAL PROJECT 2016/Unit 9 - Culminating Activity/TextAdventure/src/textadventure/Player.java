//Player Class
package textadventure;

//Player class extends TextAdventure (main line) so public variables can be used

import static textadventure.TextAdventure.EXP;

public class Player extends TextAdventure {
    //Variables for physical attributes

    public String name; //Player name
    public String weapon; //What weapon the player is carrying
    public int healthPotion; //How many health potion the player is carrying
    //Variables for statistics of player
    public int maxHealth;  //health points the character has
    public int attack;  //affects damage done
    public int defense; //affects damage taken
    public int speed;   //affects whether the character attacks first
    public int exp;     //when it reaches a certain number other stats increase
    public int level;     //when it reaches a certain number other stats increase
    //Check if user has leveled up
    public boolean levelup = false;

    //Default Constructor
    public Player(String name, String weapon, int healthpotion,
            int maxHealth, int attack, int defense, int speed, int exp, int level) {
        this.name = name;
        this.weapon = weapon;
        this.healthPotion = healthpotion;
        this.maxHealth = maxHealth;
        this.attack = attack;
        this.defense = defense;
        this.speed = speed;
        this.exp = exp;
        this.level = level;
    }
    
    //Get method
    public String getName() {
        return name;
    }

    //Set method
    public void setName(String newName) {
        name = newName;
    }

    
    //When exp reaches a certain number the users other stats go up
    public void expCalc() {
        //used for adding extra exp after user levels up
        int tempEXP;
        //Method
        if (EXP >= 10) {
            //Since EXP > 10 save the number of EXP they should have after leveling up
            tempEXP = EXP - 10;
            EXP = tempEXP;
            System.out.println("\u001B[32mEXP: " + EXP + "/10");
            //User levels up
            levelup = true;
        } else if (EXP < 10) {
            //Save the exp the user got (say they got 3/10 keep the 3 for later)
            tempEXP = EXP;
            System.out.println("\u001B[32mEXP: " + EXP + "/10");
            //User does not level up yet
            levelup = false;
        }
    }
}