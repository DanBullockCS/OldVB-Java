//Enemy Class
package textadventure;

public class Enemy {
    //Variables for physical attributes
    public String name; //Enemy name
    public String weapon; //What weapon the enemy is carrying
    //Variables for statistics of enemy
    public int maxHealth; //health points the character has
    public int attack;    //affects damage done
    public int defense;   //affects damage taken
    public int speed;     //affects whether the character attacks first

    //Default Constructor for slimes (as they are the first enemy)
    public Enemy() {
        name = "Slime";
        weapon = "Itself";
        maxHealth = 10 + (int) (Math.random() * 15);
        attack = 2 + (int) (Math.random() * 3);
        defense = 2 + (int) (Math.random() * 3);
        speed = 2 + (int) (Math.random() * 3);
    }
    
    //Alternate Constructor for all other enemies
    public Enemy(String name, String weapon, int maxHealth, int attack,
            int defense, int speed) {
        this.name = name;
        this.weapon = weapon;
        this.maxHealth = maxHealth;
        this.attack = attack;
        this.defense = defense;
        this.speed = speed;
    }
}