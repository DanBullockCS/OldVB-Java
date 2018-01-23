 /* Daniel Bullock
 * May 14th 2016
 * Final Project - Main Form
 * ***This is a text based adventure game, there is a help document titled
 * "README.txt" attached with the file that explains how to play.***
 */
package textadventure;

//Import for reading and writing to external files
import java.io.*;
//Import of Scanner which reads output console
import java.util.Scanner;

public class TextAdventure {

    //used for bringing exp over to player class
    public static int EXP;
    //Public array
    public static String level_array[] = new String[1000];

    public static void main(String[] args) throws IOException {

        //<editor-fold defaultstate="collapsed" desc="Text Art">
        //Text art for the title of the game
        System.out.println("\u001B[34m  ______           _   _            _  ___                 _                 \n"
                + " \u001B[34m|  ____|         | | | |          | |/ (_)               | |                \n"
                + " \u001B[34m| |__ ___  _ __  | |_| |__   ___  | ' / _ _ __   __ _  __| | ___  _ __ ___  \n"
                + " \u001B[34m|  __/ _ \\| '__| | __| '_ \\ / _ \\ |  < | | '_ \\ / _` |/ _` |/ _ \\| '_ ` _ \\ \n"
                + " \u001B[34m| | | (_) | |    | |_| | | |  __/ | . \\| | | | | (_| | (_| | (_) | | | | | |\n"
                + " \u001B[34m|_|  \\___/|_|     \\__|_| |_|\\___| |_|\\_\\_|_| |_|\\__, |\\__,_|\\___/|_| |_| |_|\n"
                + " \u001B[34m                                                 __/ |                      \n"
                + " \u001B[34m                                                |___/                       ");
        //</editor-fold>

        //Read file before player does anything so all previous player levels are saved in array
        BufferedReader readFile = new BufferedReader(new FileReader("Levels.txt"));
        String theLine;//Each line as a string
        int counter = 0;

        //Read file
        while ((theLine = readFile.readLine()) != null) {
            level_array[counter] = theLine;
            counter++;
        }
        //Close file
        readFile.close();

        //Used for taking the user input
        Scanner userInput = new Scanner(System.in);

        //Main menu
        System.out.println("1 - Start Game" + "\n2 - Help" + "\n3 - Read Player Names" + "\n4 - Search Player Names" + "\n5 - Credits" + "\n6 - Exit");
        while (true) {
            String menu = userInput.nextLine();
            switch (menu) {
                case "1":
                    System.out.println("\n\u001B[31mGame Start:");
                    break;
                case "2":
                    System.out.println("\n\u001B[31mPlease refer to the attached text document on how to play (README.txt)");
                    System.out.println("1 - Start Game" + "\n2 - Help" + "\n3 - Read Player Names" + "\n4 - Search Player Names" + "\n5 - Credits" + "\n6 - Exit");
                    continue;
                case "3":
                    //From read file earlier
                    //Display Array of levels
                    System.out.println("\u001B[31mPlayer Levels");
                    for (int i = 0; i < level_array.length && level_array[i] != null; i++) {
                        System.out.println("\u001B[35m" + level_array[i]);
                    }

                    System.out.println("\n1 - Start Game" + "\n2 - Help" + "\n3 - Read Player Names" + "\n4 - Search Player Names" + "\n5 - Credits" + "\n6 - Exit");
                    continue;
                case "4":
                    //Declare Integer array's length equal to the string array's length
                    int num_array[] = new int[level_array.length];
                    //Copy string arrays contents to integer array
                    for (int i = 0; i < level_array.length; i++) {
                        try {
                            num_array[i] = Integer.parseInt(level_array[i]);
                        } catch (NumberFormatException nfe) {
                        };
                    }
                                        
                    //Searching
                    while (true) {
                        System.out.println("\u001B[31mEnter a level to see if a player has reached it.");
                        String searchLevel = userInput.nextLine();
                        if (LinearSearch(num_array, Integer.parseInt(searchLevel)) == true) {
                            System.out.println(searchLevel + " \u001B[31mis indeed a previous player's level");
                        } else if (LinearSearch(num_array, Integer.parseInt(searchLevel)) == false) {
                            System.out.println(searchLevel + " \u001B[31mis not a previous player's level.");
                        }
                        break;
                    }

                    //Sorting
                    //Print out sorted integer array
                    System.out.println("\u001B[31mSorting Array of levels...");
                    bubbleSort(num_array);

                    for (int i = 0; i < num_array.length; i++) {
                        if (num_array[i] != 0) {
                            System.out.println("\u001B[35m" + num_array[i]);
                        }
                    }

                    System.out.println("\n1 - Start Game" + "\n2 - Help" + "\n3 - Read Player Names" + "\n4 - Search Player Names" + "\n5 - Credits" + "\n6 - Exit");
                    continue;
                case "5":
                    System.out.println("\n\u001B[31mThis program was created by Daniel Bullock");
                    System.out.println("1 - Start Game" + "\n2 - Help" + "\n3 - Read Player Names" + "\n4 - Search Player Names" + "\n5 - Credits" + "\n6 - Exit");
                    continue;
                case "6":
                    System.out.println("\u001B[31mShutting down...");
                    System.exit(0);
                    break;
                default:
                    System.out.println("\u001B[31mInvalid choice, please enter 1, 2, 3, 4, or 5.");
                    continue;
            }
            break;
        }

        //Let user create their character
        System.out.println("\n\u001B[36mCreate your character:");
        System.out.println("-------------------------------------------------------------------------------");

        //Ask user for name
        String pName;

        System.out.println("\u001B[31mWhat is your name?");
        String getName = userInput.nextLine();
        pName = getName;

        //Let player choose what stats to have
        int skillPts = 10;
        int atkPts = 0, defPts = 0, spdPts = 0;
        System.out.println("\n\u001B[31mTime to get some stats, you have " + skillPts + " skill points.");
        System.out.println("1 - Add attack" + "\n2 - Add defense" + "\n3 - Add speed");

        while (skillPts != 0) {
            String statCollector = userInput.nextLine();
            switch (statCollector) {
                case "1":
                    atkPts += 1;
                    skillPts -= 1;
                    System.out.println("\n\u001B[31mYou have " + skillPts + " skill points remaining.");
                    System.out.println("1 - Add attack" + "\n2 - Add defense" + "\n3 - Add speed");
                    break;
                case "2":
                    defPts += 1;
                    skillPts -= 1;
                    System.out.println("\n\u001B[31mYou have " + skillPts + " skill points remaining.");
                    System.out.println("1 - Add attack" + "\n2 - Add defense" + "\n3 - Add speed");
                    break;
                case "3":
                    spdPts += 1;
                    skillPts -= 1;
                    System.out.println("\n\u001B[31mYou have " + skillPts + " skill points remaining.");
                    System.out.println("1 - Add attack" + "\n2 - Add defense" + "\n3 - Add speed");
                    break;
                //"default" works as an "else" in an if statement
                default:
                    System.out.println("\u001B[31mInvalid choice, please enter 1, 2 or 3.");
                    break;
            }
        }

        System.out.println("\n\u001B[31mSkill points used, displaying player stats...");

        //Initialize user as a character object
        Player user = new Player(pName, "Fists", 0, 50, atkPts, defPts, spdPts, 0, 1);

        //Display user starting info
        System.out.println("\u001B[31m---------------------------------------------");
        System.out.println("Name: " + user.name
                + "\nWeapon: " + user.weapon
                + "\nNumber of health potions: " + user.healthPotion
                + "\nHealth: " + user.maxHealth
                + "\nAttack: " + user.attack
                + "\nDefense: " + user.defense
                + "\nSpeed: " + user.speed
                + "\nExperience points: " + user.exp
                + "\nLevel: " + user.level);

        //Check to see if user read story text, and wants to move on (REUSED as CONTINUE GAME)
        System.out.println("\n\u001B[31mEnter \"continue\" to progress.");
        while (true) {
            String progress = userInput.nextLine();
            if (progress.equalsIgnoreCase("continue")) {
                break;
            } else {
                System.out.println("\u001B[31mInvalid type, please enter \"continue\"");
                continue;
            }
        }

        //Story
        System.out.println("\n\u001B[31mNow that you know who you are, your adventure starts here."
                + "\n\nYou are a knight, you just woke up from a night at the bar in a town far"
                + "\naway from the kingdom, and exit the inn. "
                + "\nSuddenly, a messanger from the royal castle sprints towards you."
                + "\n*The messanger greets you and hands you a scroll.*"
                + "\nThe scroll reads:"
                + "\n\u001B[36m" + user.name + ", the kingdom has been overthrown by the Begnion"
                + "\n\u001B[36marmy and everyone in the castle is either locked up or executed."
                + "\n\u001B[36mYou are the only knight we know of that can help. You must come to "
                + "\n\u001B[36mthe castle and free the soldiers so we can take back the Kingdom of Crimea."
                + "\n\u001B[32m~King Ike");

        //<editor-fold defaultstate="collapsed" desc="Continue game">
        //Continue game
        System.out.println("\n\u001B[31mEnter \"continue\" to progress.");
        while (true) {
            String progress = userInput.nextLine();
            if (progress.equalsIgnoreCase("continue")) {
                break;
            } else {
                System.out.println("\u001B[31mInvalid type, please enter \"continue\"");
                continue;
            }
        }
        //</editor-fold>

        System.out.println("\n\u001B[31mLooks like you've got a decision on your hands"
                + "\n1 - Accept quest" + "\n2 - Decline quest");
        //Let user choose if they should accept the quest (but they really have no choice)
        while (true) {
            String progress = userInput.nextLine();
            switch (progress) {
                case "1":
                    System.out.println("\nMessanger: Good luck sir, heres some health potions.");
                    user.healthPotion += 3;
                    System.out.println("\u001B[31mPlayer recieved 3 health potions.");
                    break;
                case "2":
                    System.out.println("Messanger: Sir, the kingdom needs you!");
                    continue;
                default:
                    System.out.println("\u001B[31mInvalid choice, please enter 1 or 2.");
                    continue;
            }
            break;
        }

        //Player chooses weapon
        System.out.println("\nYou say goodbye to the messanger and walk to the inn to pick up your _______"
                + "\n1 - Sword"
                + "\n2 - Axe"
                + "\n3 - Lance");

        while (true) {
            String weaponchoice = userInput.nextLine();
            switch (weaponchoice) {
                case "1":
                    System.out.println("You pick up the sword, it's quite pointy \u001B[31m(+1 speed).");
                    user.weapon = "Sword";
                    user.speed += 1;
                    break;
                case "2":
                    System.out.println("You pick up the axe, ready to cut some trees \u001B[31m(+1 defense).");
                    user.weapon = "Axe";
                    user.defense += 1;
                    break;
                case "3":
                    System.out.println("You pick up the lance, looks like 10 feet \u001B[31m(+1 attack).");
                    user.weapon = "Lance";
                    user.attack += 1;
                    break;
                default:
                    System.out.println("\u001B[31mInvalid choice, please enter 1, 2 or 3.");
                    continue;
            }
            break;
        }

        //<editor-fold defaultstate="collapsed" desc="Continue game">
        //Continue game
        System.out.println("\n\u001B[31mEnter \"continue\" to progress.");
        while (true) {
            String progress = userInput.nextLine();
            if (progress.equalsIgnoreCase("continue")) {
                break;
            } else {
                System.out.println("\u001B[31mInvalid type, please enter \"continue\"");
                continue;
            }
        }
        //</editor-fold>

        System.out.println("\nReady to start your adventure, you set out into the forest of goop."
                + "\nYou walk in the forest and a slime jumps out of the bushes."
                + "\nHint: keep fighting slimes in the forest to gain early levels."
                + "\n\n\u001B[31mBattle Start!"
                + "\n\u001B[31m1 - Attack \n\u001B[31m2 - Use Potion \n\u001B[31m3 - Run away");

        //Let user come back to this point and therefore fight another enemy
        FightAgain:
        while (true) {

            //<editor-fold defaultstate="collapsed" desc="Battle Method">
            //Battle variables
            //Initiailize Slime enemy
            Enemy enemy = new Enemy();
            //Let player hp fluctuate (But start battle at max hp)
            int tempPlayerHp = user.maxHealth;
            int tempEnemyHp = enemy.maxHealth;
            //How much damage the player does to the enemy depending on their stats
            int playerDamage = user.attack - enemy.defense;
            /*
             * If the stats create a negative number then the attacks will give 
             * health, this way they just end up doing no damage.
             */
            if (playerDamage <= 0) {
                playerDamage = 0;
            }
            //How much damage the enemy does to the player depending on their stats
            int enemyDamage = enemy.attack - user.defense;
            if (enemyDamage <= 0) {
                enemyDamage = 0;
            }
            //A counter used for adding extra damage randomly
            int criticalDmg;
            //Variable used for random chances
            int randomNum;
            //How much exp you could randomly get from killing the enemy (you level up after you get 10)
            user.exp = 1 + (int) (Math.random() * 10);

            //Display Enemy info
            System.out.println("\n\u001B[32mEnemy Info");
            System.out.println("Name: " + enemy.name
                    + "\nWeapon: " + enemy.weapon
                    + "\nHealth: " + enemy.maxHealth
                    + "\nAttack: " + enemy.attack
                    + "\nDefense: " + enemy.defense
                    + "\nSpeed: " + enemy.speed);

            while (true) {
                String battleChoice = userInput.nextLine();
                System.out.println("\n\u001B[31m1 - Attack \n\u001B[31m2 - Use Potion \n\u001B[31m3 - Run away");
                switch (battleChoice) {
                    case "1":
                        if (user.speed >= enemy.speed) {
                            //Player hits enemy first
                            //50/50 chance of the hit being a critical hit
                            randomNum = 1 + (int) (Math.random() * 2);
                            if (randomNum == 1) {
                                criticalDmg = 1 + (int) (Math.random() * 5);
                                System.out.println("\u001B[31mCritical hit +" + criticalDmg);
                                tempEnemyHp = tempEnemyHp - playerDamage - criticalDmg;
                                System.out.println("You hit the " + enemy.name + " with your " + user.weapon
                                        + " for " + (playerDamage + criticalDmg) + " damage.");
                                //Check if enemy died
                                if (tempEnemyHp <= 0) {
                                    System.out.println("You win! You gained " + user.exp + " experience points");
                                    //Random chance of Health potion drop
                                    randomNum = 1 + (int) (Math.random() * 2);
                                    if (randomNum == 1) {
                                        user.healthPotion += 1;
                                        System.out.println("\u001B[32mThe " + enemy.name + " dropped a health potion."
                                                + "\n\u001B[32mYou now have " + user.healthPotion + " health potions.");
                                    }
                                    break;
                                }
                            } else if (randomNum == 2) {
                                tempEnemyHp -= playerDamage;
                                System.out.println("You hit the " + enemy.name + " with your " + user.weapon
                                        + " for " + playerDamage + " damage.");
                                //Check if enemy died
                                if (tempEnemyHp <= 0) {
                                    System.out.println("You win! You gained " + user.exp + " experience points");
                                    //Random chance of Health potion drop
                                    randomNum = 1 + (int) (Math.random() * 2);
                                    if (randomNum == 1) {
                                        user.healthPotion += 1;
                                        System.out.println("\u001B[32mThe " + enemy.name + " dropped a health potion."
                                                + "\n\u001B[32mYou now have " + user.healthPotion + " health potions.");
                                    }
                                    break;
                                }
                            }


                            //Enemy hits player
                            //50/50 chance of the hit being a critical hit
                            randomNum = 1 + (int) (Math.random() * 2);
                            if (randomNum == 1) {
                                criticalDmg = 1 + (int) (Math.random() * 5);
                                System.out.println("\u001B[31mCritical hit +" + criticalDmg);
                                tempPlayerHp = tempPlayerHp - enemyDamage - criticalDmg;
                                System.out.println("The " + enemy.name + " hits you with their " + enemy.weapon
                                        + " for " + (enemyDamage + criticalDmg) + " damage.");
                                //Check if player died
                                if (tempPlayerHp <= 0) {
                                    System.out.println("You see only black, the kingdom has fallen.");
                                    System.exit(0);
                                }
                            } else if (randomNum == 2) {
                                tempPlayerHp -= enemyDamage;
                                System.out.println("The " + enemy.name + " hits you with their " + enemy.weapon
                                        + " for " + enemyDamage + " damage.");
                                //Check if player died
                                if (tempPlayerHp <= 0) {
                                    System.out.println("You see only black, the kingdom has fallen.");
                                    System.exit(0);
                                }
                            }
                            //Display Hp
                            System.out.println("\u001B[32mYour HP: " + tempPlayerHp + " /" + user.maxHealth
                                    + "\n\u001B[32mEnemy HP: " + tempEnemyHp + " /" + enemy.maxHealth);


                        } else if (user.speed < enemy.speed) {
                            //Enemy hits player first
                            //50/50 chance of the hit being a critical hit
                            randomNum = 1 + (int) (Math.random() * 2);
                            if (randomNum == 1) {
                                criticalDmg = 1 + (int) (Math.random() * 5);
                                System.out.println("\u001B[31mCritical hit +" + criticalDmg);
                                tempPlayerHp = tempPlayerHp - enemyDamage - criticalDmg;
                                System.out.println("The " + enemy.name + " hits you with their " + enemy.weapon
                                        + " for " + (enemyDamage + criticalDmg) + " damage.");
                                //Check if player died
                                if (tempPlayerHp <= 0) {
                                    System.out.println("You see only black, the kingdom has fallen.");
                                    System.exit(0);
                                }
                            } else if (randomNum == 2) {
                                tempPlayerHp -= enemyDamage;
                                System.out.println("The " + enemy.name + " hits you with their " + enemy.weapon
                                        + " for " + enemyDamage + " damage.");
                                //Check if player died
                                if (tempPlayerHp <= 0) {
                                    System.out.println("You see only black, the kingdom has fallen.");
                                    System.exit(0);
                                }
                            }
                            //Player hits enemy
                            //50/50 chance of the hit being a critical hit
                            randomNum = 1 + (int) (Math.random() * 2);
                            if (randomNum == 1) {
                                criticalDmg = 1 + (int) (Math.random() * 5);
                                System.out.println("\u001B[31mCritical hit +" + criticalDmg);
                                tempEnemyHp = tempEnemyHp - playerDamage - criticalDmg;
                                System.out.println("You hit the " + enemy.name + " with your " + user.weapon
                                        + " for " + (playerDamage + criticalDmg) + " damage.");
                                //Check if enemy died
                                if (tempEnemyHp <= 0) {
                                    System.out.println("You win! You gained " + user.exp + " experience points");
                                    //Random chance of Health potion drop
                                    randomNum = 1 + (int) (Math.random() * 2);
                                    if (randomNum == 1) {
                                        user.healthPotion += 1;
                                        System.out.println("\u001B[32mThe " + enemy.name + " dropped a health potion."
                                                + "\n\u001B[32mYou now have " + user.healthPotion + " health potions.");
                                    }
                                    break;
                                }
                            } else if (randomNum == 2) {
                                tempEnemyHp -= playerDamage;
                                System.out.println("You hit the " + enemy.name + " with your " + user.weapon
                                        + " for " + playerDamage + " damage.");
                                //Check if enemy died
                                if (tempEnemyHp <= 0) {
                                    System.out.println("You win! You gained " + user.exp + " experience points");
                                    //Random chance of Health potion drop
                                    randomNum = 1 + (int) (Math.random() * 2);
                                    if (randomNum == 1) {
                                        user.healthPotion += 1;
                                        System.out.println("\u001B[32mThe " + enemy.name + " dropped a health potion."
                                                + "\n\u001B[32mYou now have " + user.healthPotion + " health potions.");
                                    }
                                    break;
                                }
                            }
                            //Display Hp
                            System.out.println("\u001B[32mYour HP: " + tempPlayerHp + " /" + user.maxHealth
                                    + "\n\u001B[32mEnemy HP: " + tempEnemyHp + " /" + enemy.maxHealth);
                        }
                        continue;
                    case "2":
                        //Player attempts to use health potion
                        if (user.healthPotion != 0) {
                            System.out.println("You use a health potion, you feel refreshed.");
                            tempPlayerHp += 50;
                            if (tempPlayerHp > user.maxHealth) {
                                tempPlayerHp = user.maxHealth;
                            }
                            user.healthPotion -= 1;
                            //Display Hp
                            System.out.println("\u001B[32mYour HP: " + tempPlayerHp + " /" + user.maxHealth
                                    + "\n\u001B[32mEnemy HP: " + tempEnemyHp + " /" + enemy.maxHealth);
                        } else {
                            System.out.println("You don't have any health potions left!");
                        }
                        //50/50 chance of enemy attacking you
                        randomNum = 1 + (int) (Math.random() * 2);
                        if (randomNum == 1) {
                            System.out.println("The " + enemy.name + " stares at you.");
                            continue;
                        } else if (randomNum == 2) {
                            //Enemy hits player as they use potion
                            System.out.println("The " + enemy.name + " hits you with their " + enemy.weapon
                                    + " for " + enemyDamage + " damage.");
                            tempPlayerHp -= enemyDamage;
                            //Display Hp
                            System.out.println("\u001B[32mYour HP: " + tempPlayerHp + " /" + user.maxHealth
                                    + "\n\u001B[32mEnemy HP: " + tempEnemyHp + " /" + enemy.maxHealth);
                            //Check if player died
                            if (tempPlayerHp <= 0) {
                                System.out.println("You see only black, the kingdom has fallen.");
                                System.exit(0);
                            }
                            continue;
                        }
                        continue;
                    case "3":
                        //50/50 chance of you running away
                        randomNum = 1 + (int) (Math.random() * 2);
                        if (randomNum == 1) {
                            System.out.println("The " + enemy.name + " blocks your path.");
                            //Display Hp
                            System.out.println("\u001B[32mYour HP: " + tempPlayerHp + " /" + user.maxHealth
                                    + "\n\u001B[32mEnemy HP: " + tempEnemyHp + " /" + enemy.maxHealth);
                            continue;
                        } else if (randomNum == 2) {
                            System.out.println("You get away from the " + enemy.name + ".");
                            break;
                        }
                    default:
                        System.out.println("\u001B[31mInvalid choice, please enter 1, 2 or 3.");
                        continue;
                }
                break;
            }
            //BATTLE END
            //</editor-fold >

            //<editor-fold defaultstate="collapsed" desc="EXP Method">
            //Give user exp
            EXP = EXP + user.exp;
            user.expCalc();
            if (user.levelup == true && user.level != 100) {
                user.level += 1;
                //Add stats if user levels up
                atkPts = 0;
                defPts = 0;
                spdPts = 0;
                int hp = 0;
                atkPts += 0 + (int) (Math.random() * 3);
                defPts += 0 + (int) (Math.random() * 3);
                spdPts += 0 + (int) (Math.random() * 3);
                hp += 0 + (int) (Math.random() * 2);
                System.out.println("\n\u001B[31mLEVEL UP:"
                        + "\n+" + atkPts + " Attack"
                        + "\n+" + defPts + " Defense"
                        + "\n+" + spdPts + " Speed");
                user.attack += atkPts;
                user.defense += defPts;
                user.speed += spdPts;
                user.maxHealth += hp;
            } else if (user.level == 100) {
                user.levelup = false;
                System.out.println("\u001B[33mYou have reached the max level of 100!");
            } else {
                user.levelup = false;
            }
            user.levelup = false;
            //</editor-fold>

            //Display Stats
            System.out.println("\u001B[31m---------------------------------------------");
            System.out.println("\u001B[32mPlayer stats:"
                    + "\nName: " + user.name
                    + "\nWeapon: " + user.weapon
                    + "\nNumber of health potions: " + user.healthPotion
                    + "\nHealth: " + user.maxHealth
                    + "\nAttack: " + user.attack
                    + "\nDefense: " + user.defense
                    + "\nSpeed: " + user.speed
                    + "\nExperience points: " + EXP + "/10"
                    + "\nLevel: " + user.level);

            //Exit Forest?
            System.out.println("\n\u001B[31m1 - Leave forest \n\u001B[31m2 - Slice more slimes");
            while (true) {
                String leaveArea = userInput.nextLine();
                if (leaveArea.equalsIgnoreCase("1")) {
                    System.out.println("You walk out of the forest and see a giant mountain.");
                    //Continue game
                    break FightAgain;
                } else if (leaveArea.equalsIgnoreCase("2")) {
                    System.out.println("Another slime appears! \n\u001B[31mBattle Start!"
                            + "\n\u001B[31m1 - Attack \n\u001B[31m2 - Use Potion \n\u001B[31m3 - Run away");
                    //continue back to the label right before the loop
                    continue FightAgain;
                } else {
                    System.out.println("\u001B[31mInvalid type, please enter 1 or 2");
                    continue;
                }
            }
        }

        System.out.println("Not sure you saw the sign at the bottom of the mountain,"
                + "\nbut multiple bears live on this mountain. Oh look, here's one now.");

        //<editor-fold defaultstate="collapsed" desc="Continue game">
        //Continue game
        System.out.println("\n\u001B[31mEnter \"continue\" to progress.");
        while (true) {
            String progress = userInput.nextLine();
            if (progress.equalsIgnoreCase("continue")) {
                break;
            } else {
                System.out.println("\u001B[31mInvalid type, please enter \"continue\"");
                continue;
            }
        }
        //</editor-fold>

        System.out.println("\n\u001B[31mBattle Start!"
                + "\n\u001B[31m1 - Attack \n\u001B[31m2 - Use Potion \n\u001B[31m3 - Run away");

        //Let user come back to this point and therefore fight another enemy
        FightAgain:
        while (true) {

            //<editor-fold defaultstate="collapsed" desc="Battle Method">
            //Battle variables
            //Initiailize Bear
            Enemy enemy = new Enemy("Bear", "claws", 20 + (int) (Math.random() * 30),
                    5 + (int) (Math.random() * 3), 5 + (int) (Math.random() * 3),
                    5 + (int) (Math.random() * 3));
            //Let player hp fluctuate (But start battle at max hp)
            int tempPlayerHp = user.maxHealth;
            int tempEnemyHp = enemy.maxHealth;
            //How much damage the player does to the enemy depending on their stats
            int playerDamage = user.attack - enemy.defense;
            /*
             * If the stats create a negative number then the attacks will give 
             * health, this way they just end up doing no damage.
             */
            if (playerDamage <= 0) {
                playerDamage = 0;
            }
            //How much damage the enemy does to the player depending on their stats
            int enemyDamage = enemy.attack - user.defense;
            if (enemyDamage <= 0) {
                enemyDamage = 0;
            }
            //A counter used for adding extra damage randomly
            int criticalDmg;
            //Variable used for random chances
            int randomNum;
            //How much exp you could randomly get from killing the enemy (you level up after you get 10)
            user.exp = 1 + (int) (Math.random() * 10);

            //Display Enemy info
            System.out.println("\n\u001B[32mEnemy Info");
            System.out.println("Name: " + enemy.name
                    + "\nWeapon: " + enemy.weapon
                    + "\nHealth: " + enemy.maxHealth
                    + "\nAttack: " + enemy.attack
                    + "\nDefense: " + enemy.defense
                    + "\nSpeed: " + enemy.speed);

            while (true) {
                String battleChoice = userInput.nextLine();
                System.out.println("\n\u001B[31m1 - Attack \n\u001B[31m2 - Use Potion \n\u001B[31m3 - Run away");
                switch (battleChoice) {
                    case "1":
                        if (user.speed >= enemy.speed) {
                            //Player hits enemy first
                            //50/50 chance of the hit being a critical hit
                            randomNum = 1 + (int) (Math.random() * 2);
                            if (randomNum == 1) {
                                criticalDmg = 1 + (int) (Math.random() * 5);
                                System.out.println("\u001B[31mCritical hit +" + criticalDmg);
                                tempEnemyHp = tempEnemyHp - playerDamage - criticalDmg;
                                System.out.println("You hit the " + enemy.name + " with your " + user.weapon
                                        + " for " + (playerDamage + criticalDmg) + " damage.");
                                //Check if enemy died
                                if (tempEnemyHp <= 0) {
                                    System.out.println("You win! You gained " + user.exp + " experience points");
                                    //Random chance of Health potion drop
                                    randomNum = 1 + (int) (Math.random() * 2);
                                    if (randomNum == 1) {
                                        user.healthPotion += 1;
                                        System.out.println("\u001B[32mThe " + enemy.name + " dropped a health potion."
                                                + "\n\u001B[32mYou now have " + user.healthPotion + " health potions.");
                                    }
                                    break;
                                }
                            } else if (randomNum == 2) {
                                tempEnemyHp -= playerDamage;
                                System.out.println("You hit the " + enemy.name + " with your " + user.weapon
                                        + " for " + playerDamage + " damage.");
                                //Check if enemy died
                                if (tempEnemyHp <= 0) {
                                    System.out.println("You win! You gained " + user.exp + " experience points");
                                    //Random chance of Health potion drop
                                    randomNum = 1 + (int) (Math.random() * 2);
                                    if (randomNum == 1) {
                                        user.healthPotion += 1;
                                        System.out.println("\u001B[32mThe " + enemy.name + " dropped a health potion."
                                                + "\n\u001B[32mYou now have " + user.healthPotion + " health potions.");
                                    }
                                    break;
                                }
                            }


                            //Enemy hits player
                            //50/50 chance of the hit being a critical hit
                            randomNum = 1 + (int) (Math.random() * 2);
                            if (randomNum == 1) {
                                criticalDmg = 1 + (int) (Math.random() * 5);
                                System.out.println("\u001B[31mCritical hit +" + criticalDmg);
                                tempPlayerHp = tempPlayerHp - enemyDamage - criticalDmg;
                                System.out.println("The " + enemy.name + " hits you with their " + enemy.weapon
                                        + " for " + (enemyDamage + criticalDmg) + " damage.");
                                //Check if player died
                                if (tempPlayerHp <= 0) {
                                    System.out.println("You see only black, the kingdom has fallen.");
                                    System.exit(0);
                                }
                            } else if (randomNum == 2) {
                                tempPlayerHp -= enemyDamage;
                                System.out.println("The " + enemy.name + " hits you with their " + enemy.weapon
                                        + " for " + enemyDamage + " damage.");
                                //Check if player died
                                if (tempPlayerHp <= 0) {
                                    System.out.println("You see only black, the kingdom has fallen.");
                                    System.exit(0);
                                }
                            }
                            //Display Hp
                            System.out.println("\u001B[32mYour HP: " + tempPlayerHp + " /" + user.maxHealth
                                    + "\n\u001B[32mEnemy HP: " + tempEnemyHp + " /" + enemy.maxHealth);


                        } else if (user.speed < enemy.speed) {
                            //Enemy hits player first
                            //50/50 chance of the hit being a critical hit
                            randomNum = 1 + (int) (Math.random() * 2);
                            if (randomNum == 1) {
                                criticalDmg = 1 + (int) (Math.random() * 5);
                                System.out.println("\u001B[31mCritical hit +" + criticalDmg);
                                tempPlayerHp = tempPlayerHp - enemyDamage - criticalDmg;
                                System.out.println("The " + enemy.name + " hits you with their " + enemy.weapon
                                        + " for " + (enemyDamage + criticalDmg) + " damage.");
                                //Check if player died
                                if (tempPlayerHp <= 0) {
                                    System.out.println("You see only black, the kingdom has fallen.");
                                    System.exit(0);
                                }
                            } else if (randomNum == 2) {
                                tempPlayerHp -= enemyDamage;
                                System.out.println("The " + enemy.name + " hits you with their " + enemy.weapon
                                        + " for " + enemyDamage + " damage.");
                                //Check if player died
                                if (tempPlayerHp <= 0) {
                                    System.out.println("You see only black, the kingdom has fallen.");
                                    System.exit(0);
                                }
                            }
                            //Player hits enemy
                            //50/50 chance of the hit being a critical hit
                            randomNum = 1 + (int) (Math.random() * 2);
                            if (randomNum == 1) {
                                criticalDmg = 1 + (int) (Math.random() * 5);
                                System.out.println("\u001B[31mCritical hit +" + criticalDmg);
                                tempEnemyHp = tempEnemyHp - playerDamage - criticalDmg;
                                System.out.println("You hit the " + enemy.name + " with your " + user.weapon
                                        + " for " + (playerDamage + criticalDmg) + " damage.");
                                //Check if enemy died
                                if (tempEnemyHp <= 0) {
                                    System.out.println("You win! You gained " + user.exp + " experience points");
                                    //Random chance of Health potion drop
                                    randomNum = 1 + (int) (Math.random() * 2);
                                    if (randomNum == 1) {
                                        user.healthPotion += 1;
                                        System.out.println("\u001B[32mThe " + enemy.name + " dropped a health potion."
                                                + "\n\u001B[32mYou now have " + user.healthPotion + " health potions.");
                                    }
                                    break;
                                }
                            } else if (randomNum == 2) {
                                tempEnemyHp -= playerDamage;
                                System.out.println("You hit the " + enemy.name + " with your " + user.weapon
                                        + " for " + playerDamage + " damage.");
                                //Check if enemy died
                                if (tempEnemyHp <= 0) {
                                    System.out.println("You win! You gained " + user.exp + " experience points");
                                    //Random chance of Health potion drop
                                    randomNum = 1 + (int) (Math.random() * 2);
                                    if (randomNum == 1) {
                                        user.healthPotion += 1;
                                        System.out.println("\u001B[32mThe " + enemy.name + " dropped a health potion."
                                                + "\n\u001B[32mYou now have " + user.healthPotion + " health potions.");
                                    }
                                    break;
                                }
                            }
                            //Display Hp
                            System.out.println("\u001B[32mYour HP: " + tempPlayerHp + " /" + user.maxHealth
                                    + "\n\u001B[32mEnemy HP: " + tempEnemyHp + " /" + enemy.maxHealth);
                        }
                        continue;
                    case "2":
                        //Player attempts to use health potion
                        if (user.healthPotion != 0) {
                            System.out.println("You use a health potion, you feel refreshed.");
                            tempPlayerHp += 50;
                            if (tempPlayerHp > user.maxHealth) {
                                tempPlayerHp = user.maxHealth;
                            }
                            user.healthPotion -= 1;
                            //Display Hp
                            System.out.println("\u001B[32mYour HP: " + tempPlayerHp + " /" + user.maxHealth
                                    + "\n\u001B[32mEnemy HP: " + tempEnemyHp + " /" + enemy.maxHealth);
                        } else {
                            System.out.println("You don't have any health potions left!");
                        }
                        //50/50 chance of enemy attacking you
                        randomNum = 1 + (int) (Math.random() * 2);
                        if (randomNum == 1) {
                            System.out.println("The " + enemy.name + " stares at you.");
                            continue;
                        } else if (randomNum == 2) {
                            //Enemy hits player as they use potion
                            System.out.println("The " + enemy.name + " hits you with their " + enemy.weapon
                                    + " for " + enemyDamage + " damage.");
                            tempPlayerHp -= enemyDamage;
                            //Display Hp
                            System.out.println("\u001B[32mYour HP: " + tempPlayerHp + " /" + user.maxHealth
                                    + "\n\u001B[32mEnemy HP: " + tempEnemyHp + " /" + enemy.maxHealth);
                            //Check if player died
                            if (tempPlayerHp <= 0) {
                                System.out.println("You see only black, the kingdom has fallen.");
                                System.exit(0);
                            }
                            continue;
                        }
                        continue;
                    case "3":
                        //50/50 chance of you running away
                        randomNum = 1 + (int) (Math.random() * 2);
                        if (randomNum == 1) {
                            System.out.println("The " + enemy.name + " blocks your path.");
                            //Display Hp
                            System.out.println("\u001B[32mYour HP: " + tempPlayerHp + " /" + user.maxHealth
                                    + "\n\u001B[32mEnemy HP: " + tempEnemyHp + " /" + enemy.maxHealth);
                            continue;
                        } else if (randomNum == 2) {
                            System.out.println("You get away from the " + enemy.name + ".");
                            break;
                        }
                    default:
                        System.out.println("\u001B[31mInvalid choice, please enter 1, 2 or 3.");
                        continue;
                }
                break;
            }
            //BATTLE END
            //</editor-fold >

            //<editor-fold defaultstate="collapsed" desc="EXP Method">
            //Give user exp
            EXP = EXP + user.exp;
            user.expCalc();
            if (user.levelup == true && user.level != 100) {
                user.level += 1;
                //Add stats if user levels up
                atkPts = 0;
                defPts = 0;
                spdPts = 0;
                int hp = 0;
                atkPts += 0 + (int) (Math.random() * 3);
                defPts += 0 + (int) (Math.random() * 3);
                spdPts += 0 + (int) (Math.random() * 3);
                hp += 0 + (int) (Math.random() * 2);
                System.out.println("\n\u001B[31mLEVEL UP:"
                        + "\n+" + atkPts + " Attack"
                        + "\n+" + defPts + " Defense"
                        + "\n+" + spdPts + " Speed");
                user.attack += atkPts;
                user.defense += defPts;
                user.speed += spdPts;
                user.maxHealth += hp;
            } else if (user.level == 100) {
                user.levelup = false;
                System.out.println("\u001B[33mYou have reached the max level of 100!");
            } else {
                user.levelup = false;
            }
            user.levelup = false;
            //</editor-fold>

            //Display Stats
            System.out.println("\u001B[31m---------------------------------------------");
            System.out.println("\u001B[32mPlayer stats:"
                    + "\nName: " + user.name
                    + "\nWeapon: " + user.weapon
                    + "\nNumber of health potions: " + user.healthPotion
                    + "\nHealth: " + user.maxHealth
                    + "\nAttack: " + user.attack
                    + "\nDefense: " + user.defense
                    + "\nSpeed: " + user.speed
                    + "\nExperience points: " + EXP + "/10"
                    + "\nLevel: " + user.level);

            //Exit Mountain?
            System.out.println("\n\u001B[31m1 - Climb down mountain \n\u001B[31m2 - Slay more bears");
            while (true) {
                String leaveArea = userInput.nextLine();
                if (leaveArea.equalsIgnoreCase("1")) {
                    System.out.println("You make it to the other side of the mountain."
                            + "\nThe Kingdom of Crimea is just on the other side of the river,"
                            + "\nbut your path is blocked by a troll that comes out from under the bridge.");
                    //Continue game
                    break FightAgain;
                } else if (leaveArea.equalsIgnoreCase("2")) {
                    System.out.println("Another bear runs towards you! \n\u001B[31mBattle Start!"
                            + "\n\u001B[31m1 - Attack \n\u001B[31m2 - Use Potion \n\u001B[31m3 - Run away");
                    //continue back to the label right before the loop
                    continue FightAgain;
                } else {
                    System.out.println("\u001B[31mInvalid type, please enter 1 or 2");
                    continue;
                }
            }
        }

        //<editor-fold defaultstate="collapsed" desc="Continue game">
        //Continue game
        System.out.println("\n\u001B[31mEnter \"continue\" to progress.");
        while (true) {
            String progress = userInput.nextLine();
            if (progress.equalsIgnoreCase("continue")) {
                break;
            } else {
                System.out.println("\u001B[31mInvalid type, please enter \"continue\"");
                continue;
            }
        }
        //</editor-fold>

        System.out.println("\nTroll: Ahaha, let's see you try to cross my bridge."
                + "\n\u001B[31mBattle Start!"
                + "\n\u001B[31m1 - Attack \n\u001B[31m2 - Use Potion \n\u001B[31m3 - Run away");

        //<editor-fold defaultstate="collapsed" desc="Battle Method">
        //Battle variables
        //Initiailize Troll
        Enemy enemy = new Enemy("Troll", "Club", 45 + (int) (Math.random() * 20),
                8 + (int) (Math.random() * 5), 8 + (int) (Math.random() * 5),
                1 + (int) (Math.random() * 3));
        //Let player hp fluctuate (But start battle at max hp)
        int tempPlayerHp = user.maxHealth;
        int tempEnemyHp = enemy.maxHealth;
        //How much damage the player does to the enemy depending on their stats
        int playerDamage = user.attack - enemy.defense;
        /*
         * If the stats create a negative number then the attacks will give 
         * health, this way they just end up doing no damage.
         */
        if (playerDamage <= 0) {
            playerDamage = 0;
        }
        //How much damage the enemy does to the player depending on their stats
        int enemyDamage = enemy.attack - user.defense;
        if (enemyDamage <= 0) {
            enemyDamage = 0;
        }
        //A counter used for adding extra damage randomly
        int criticalDmg;
        //Variable used for random chances
        int randomNum;
        //How much exp you could randomly get from killing the enemy (you level up after you get 10)
        user.exp = 1 + (int) (Math.random() * 10);

        //Display Enemy info
        System.out.println("\n\u001B[32mEnemy Info");
        System.out.println("Name: " + enemy.name
                + "\nWeapon: " + enemy.weapon
                + "\nHealth: " + enemy.maxHealth
                + "\nAttack: " + enemy.attack
                + "\nDefense: " + enemy.defense
                + "\nSpeed: " + enemy.speed);

        while (true) {
            String battleChoice = userInput.nextLine();
            System.out.println("\n\u001B[31m1 - Attack \n\u001B[31m2 - Use Potion \n\u001B[31m3 - Run away");
            switch (battleChoice) {
                case "1":
                    if (user.speed >= enemy.speed) {
                        //Player hits enemy first
                        //50/50 chance of the hit being a critical hit
                        randomNum = 1 + (int) (Math.random() * 2);
                        if (randomNum == 1) {
                            criticalDmg = 1 + (int) (Math.random() * 5);
                            System.out.println("\u001B[31mCritical hit +" + criticalDmg);
                            tempEnemyHp = tempEnemyHp - playerDamage - criticalDmg;
                            System.out.println("You hit the " + enemy.name + " with your " + user.weapon
                                    + " for " + (playerDamage + criticalDmg) + " damage.");
                            //Check if enemy died
                            if (tempEnemyHp <= 0) {
                                System.out.println("You win! You gained " + user.exp + " experience points");
                                break;
                            }
                        } else if (randomNum == 2) {
                            tempEnemyHp -= playerDamage;
                            System.out.println("You hit the " + enemy.name + " with your " + user.weapon
                                    + " for " + playerDamage + " damage.");
                            //Check if enemy died
                            if (tempEnemyHp <= 0) {
                                System.out.println("You win! You gained " + user.exp + " experience points");
                                break;
                            }
                        }


                        //Enemy hits player
                        //50/50 chance of the hit being a critical hit
                        randomNum = 1 + (int) (Math.random() * 2);
                        if (randomNum == 1) {
                            criticalDmg = 1 + (int) (Math.random() * 5);
                            System.out.println("\u001B[31mCritical hit +" + criticalDmg);
                            tempPlayerHp = tempPlayerHp - enemyDamage - criticalDmg;
                            System.out.println("The " + enemy.name + " hits you with their " + enemy.weapon
                                    + " for " + (enemyDamage + criticalDmg) + " damage.");
                            //Check if player died
                            if (tempPlayerHp <= 0) {
                                System.out.println("You see only black, the kingdom has fallen.");
                                System.exit(0);
                            }
                        } else if (randomNum == 2) {
                            tempPlayerHp -= enemyDamage;
                            System.out.println("The " + enemy.name + " hits you with their " + enemy.weapon
                                    + " for " + enemyDamage + " damage.");
                            //Check if player died
                            if (tempPlayerHp <= 0) {
                                System.out.println("You see only black, the kingdom has fallen.");
                                System.exit(0);
                            }
                        }
                        //Display Hp
                        System.out.println("\u001B[32mYour HP: " + tempPlayerHp + " /" + user.maxHealth
                                + "\n\u001B[32mEnemy HP: " + tempEnemyHp + " /" + enemy.maxHealth);


                    } else if (user.speed < enemy.speed) {
                        //Enemy hits player first
                        //50/50 chance of the hit being a critical hit
                        randomNum = 1 + (int) (Math.random() * 2);
                        if (randomNum == 1) {
                            criticalDmg = 1 + (int) (Math.random() * 5);
                            System.out.println("\u001B[31mCritical hit +" + criticalDmg);
                            tempPlayerHp = tempPlayerHp - enemyDamage - criticalDmg;
                            System.out.println("The " + enemy.name + " hits you with their " + enemy.weapon
                                    + " for " + (enemyDamage + criticalDmg) + " damage.");
                            //Check if player died
                            if (tempPlayerHp <= 0) {
                                System.out.println("You see only black, the kingdom has fallen.");
                                System.exit(0);
                            }
                        } else if (randomNum == 2) {
                            tempPlayerHp -= enemyDamage;
                            System.out.println("The " + enemy.name + " hits you with their " + enemy.weapon
                                    + " for " + enemyDamage + " damage.");
                            //Check if player died
                            if (tempPlayerHp <= 0) {
                                System.out.println("You see only black, the kingdom has fallen.");
                                System.exit(0);
                            }
                        }
                        //Player hits enemy
                        //50/50 chance of the hit being a critical hit
                        randomNum = 1 + (int) (Math.random() * 2);
                        if (randomNum == 1) {
                            criticalDmg = 1 + (int) (Math.random() * 5);
                            System.out.println("\u001B[31mCritical hit +" + criticalDmg);
                            tempEnemyHp = tempEnemyHp - playerDamage - criticalDmg;
                            System.out.println("You hit the " + enemy.name + " with your " + user.weapon
                                    + " for " + (playerDamage + criticalDmg) + " damage.");
                            //Check if enemy died
                            if (tempEnemyHp <= 0) {
                                System.out.println("You win! You gained " + user.exp + " experience points");
                                break;
                            }
                        } else if (randomNum == 2) {
                            tempEnemyHp -= playerDamage;
                            System.out.println("You hit the " + enemy.name + " with your " + user.weapon
                                    + " for " + playerDamage + " damage.");
                            //Check if enemy died
                            if (tempEnemyHp <= 0) {
                                System.out.println("You win! You gained " + user.exp + " experience points");
                                break;
                            }
                        }
                        //Display Hp
                        System.out.println("\u001B[32mYour HP: " + tempPlayerHp + " /" + user.maxHealth
                                + "\n\u001B[32mEnemy HP: " + tempEnemyHp + " /" + enemy.maxHealth);
                    }
                    continue;
                case "2":
                    //Player attempts to use health potion
                    if (user.healthPotion != 0) {
                        System.out.println("You use a health potion, you feel refreshed.");
                        tempPlayerHp += 50;
                        if (tempPlayerHp > user.maxHealth) {
                            tempPlayerHp = user.maxHealth;
                        }
                        user.healthPotion -= 1;
                        //Display Hp
                        System.out.println("\u001B[32mYour HP: " + tempPlayerHp + " /" + user.maxHealth
                                + "\n\u001B[32mEnemy HP: " + tempEnemyHp + " /" + enemy.maxHealth);
                    } else {
                        System.out.println("You don't have any health potions left!");
                    }
                    //50/50 chance of enemy attacking you
                    randomNum = 1 + (int) (Math.random() * 2);
                    if (randomNum == 1) {
                        System.out.println("The " + enemy.name + " stares at you.");
                        continue;
                    } else if (randomNum == 2) {
                        //Enemy hits player as they use potion
                        System.out.println("The " + enemy.name + " hits you with their " + enemy.weapon
                                + " for " + enemyDamage + " damage.");
                        tempPlayerHp -= enemyDamage;
                        //Display Hp
                        System.out.println("\u001B[32mYour HP: " + tempPlayerHp + " /" + user.maxHealth
                                + "\n\u001B[32mEnemy HP: " + tempEnemyHp + " /" + enemy.maxHealth);
                        //Check if player died
                        if (tempPlayerHp <= 0) {
                            System.out.println("You see only black, the kingdom has fallen.");
                            System.exit(0);
                        }
                        continue;
                    }
                    continue;
                case "3":
                    System.out.println("You can't run away from a boss battle!");
                    continue;
            }
            break;
        }
        //BATTLE END
        //</editor-fold >

        //<editor-fold defaultstate="collapsed" desc="EXP Method">
        //Give user exp
        EXP = EXP + user.exp;
        user.expCalc();
        if (user.levelup == true && user.level != 100) {
            user.level += 1;
            //Add stats if user levels up
            atkPts = 0;
            defPts = 0;
            spdPts = 0;
            int hp = 0;
            atkPts += 0 + (int) (Math.random() * 3);
            defPts += 0 + (int) (Math.random() * 3);
            spdPts += 0 + (int) (Math.random() * 3);
            hp += 0 + (int) (Math.random() * 2);
            System.out.println("\n\u001B[31mLEVEL UP:"
                    + "\n+" + atkPts + " Attack"
                    + "\n+" + defPts + " Defense"
                    + "\n+" + spdPts + " Speed");
            user.attack += atkPts;
            user.defense += defPts;
            user.speed += spdPts;
            user.maxHealth += hp;
        } else if (user.level == 100) {
            user.levelup = false;
            System.out.println("\u001B[33mYou have reached the max level of 100!");
        } else {
            user.levelup = false;
        }
        user.levelup = false;
        //</editor-fold>

        //Display Stats
        System.out.println("\u001B[31m---------------------------------------------");
        System.out.println("\u001B[32mPlayer stats:"
                + "\nName: " + user.name
                + "\nWeapon: " + user.weapon
                + "\nNumber of health potions: " + user.healthPotion
                + "\nHealth: " + user.maxHealth
                + "\nAttack: " + user.attack
                + "\nDefense: " + user.defense
                + "\nSpeed: " + user.speed
                + "\nExperience points: " + EXP + "/10"
                + "\nLevel: " + user.level);

        //<editor-fold defaultstate="collapsed" desc="Continue game">
        //Continue game
        System.out.println("\n\u001B[31mEnter \"continue\" to progress.");
        while (true) {
            String progress = userInput.nextLine();
            if (progress.equalsIgnoreCase("continue")) {
                break;
            } else {
                System.out.println("\u001B[31mInvalid type, please enter \"continue\"");
                continue;
            }
        }
        //</editor-fold>

        System.out.println("The troll falls, drops 5 health potions, and you cross the bridge."
                + "\n+5 Health potions"
                + "\nYou walk through Castle Town and think of a plan to take back the castle.");
        user.healthPotion += 5;

        //<editor-fold defaultstate="collapsed" desc="Continue game">
        //Continue game
        System.out.println("\n\u001B[31mEnter \"continue\" to progress.");
        while (true) {
            String progress = userInput.nextLine();
            if (progress.equalsIgnoreCase("continue")) {
                break;
            } else {
                System.out.println("\u001B[31mInvalid type, please enter \"continue\"");
                continue;
            }
        }
        //</editor-fold>


        //Give user a choice on how to take the castle (Only the first one works out)
        System.out.println("\n\u001B[31m1 - Use the stealthy stealth skills you obviously know and sneak through the back"
                + "\n\u001B[31m2 - Charge straight through the front gate"
                + "\n\u001B[31m3 - Go throught the moat"
                + "\n\u001B[31m4 - Ask Sir Kevin in Castle Town for his help");
        while (true) {
            String chooseMethod = userInput.nextLine();
            switch (chooseMethod) {
                case "1":
                    System.out.println("You sneak through the back exit and go downstairs."
                            + "\nOh look, the other knights are all in this one cell (how convenient)."
                            + "\nYou let them out, and they run upstairs to take back the castle."
                            + "\nYou see King Ike in his cell, and you break him out with your " + user.weapon + ".");
                    break;
                case "2":
                    System.out.println("You charge through the front gate only to be shot by the only archer on guard, sorry adventurer, the Kingdom is lost."
                            + "\n\u001B[31mYou fall to the ground, it's over, you've failed.");
                    System.exit(0);
                case "3":
                    System.out.println("You do a neat dive into the moat, only concentrating on your diving form"
                            + "\nyou fall staight into the mouth of a crocodile."
                            + "\nThe Kingdom is lost, it's over, you've failed.");
                    System.exit(0);
                case "4":
                    System.out.println("You: Hey Kevin, wanna help me out to take back the Kingdom?"
                            + "\nKevin: No.");
                    System.out.println("\n\u001B[31m1 - Use the stealthy stealth skills you obviously know and sneak through the back"
                            + "\n\u001B[31m2 - Charge straight through the front gate"
                            + "\n\u001B[31m3 - Go throught the moat"
                            + "\n\u001B[31m4 - Ask Sir Kevin in Castle Town for his help");
                    continue;
                default:
                    System.out.println("\u001B[31mInvalid choice, please enter 1, 2, 3, or 4.");
                    continue;
            }
            break;
        }

        //<editor-fold defaultstate="collapsed" desc="Continue game">
        //Continue game
        System.out.println("\n\u001B[31mEnter \"continue\" to progress.");
        while (true) {
            String progress = userInput.nextLine();
            if (progress.equalsIgnoreCase("continue")) {
                break;
            } else {
                System.out.println("\u001B[31mInvalid type, please enter \"continue\"");
                continue;
            }
        }
        //</editor-fold>

        System.out.println("\nKing Ike: Thanks " + user.name + ", you really saved the day, but the Begnion empire is still upstairs."
                + "\nYou must take down their King, you've made it this far, I have to go find the Queen."
                + "\nYou run upstairs, while the other knights distract the Begnion knights you run into the throne room");

        //<editor-fold defaultstate="collapsed" desc="Continue game">
        //Continue game
        System.out.println("\n\u001B[31mEnter \"continue\" to progress.");
        while (true) {
            String progress = userInput.nextLine();
            if (progress.equalsIgnoreCase("continue")) {
                break;
            } else {
                System.out.println("\u001B[31mInvalid type, please enter \"continue\"");
                continue;
            }
        }
        //</editor-fold>

        System.out.println("\nKevin [Leader of the Begnion army]: *Slowly claps*."
                + "\nCongratulations " + user.name + ", I knew you were outside Crimea when I took over, I didn't think you had it in you"
                + "\n to take back this castle, but here you are. Well let's not waste any more time, I'll take destroy now."
                + "\n\u001B[31mBattle Start!"
                + "\n\u001B[31m1 - Attack \n\u001B[31m2 - Use Potion \n\u001B[31m3 - Run away");

        //<editor-fold defaultstate="collapsed" desc="Battle Method">
        //Battle variables
        //Initiailize Final Boss
        Enemy FinalBoss = new Enemy("Kevin", "Tome of Light", 100, 20, 20, 20);
        //Let player hp fluctuate (But start battle at max hp)
        tempPlayerHp = user.maxHealth;
        tempEnemyHp = FinalBoss.maxHealth;
        //How much damage the player does to the enemy depending on their stats
        playerDamage = user.attack - FinalBoss.defense;
        /*
         * If the stats create a negative number then the attacks will give 
         * health, this way they just end up doing no damage.
         */
        if (playerDamage <= 0) {
            playerDamage = 0;
        }
        //How much damage the enemy does to the player depending on their stats
        enemyDamage = FinalBoss.attack - user.defense;
        if (enemyDamage <= 0) {
            enemyDamage = 0;
        }
        //How much exp you get
        user.exp = 50;

        //Display Enemy info
        System.out.println("\n\u001B[32mEnemy Info");
        System.out.println("Name: " + FinalBoss.name
                + "\nWeapon: " + FinalBoss.weapon
                + "\nHealth: " + FinalBoss.maxHealth
                + "\nAttack: " + FinalBoss.attack
                + "\nDefense: " + FinalBoss.defense
                + "\nSpeed: " + FinalBoss.speed);

        while (true) {
            String battleChoice = userInput.nextLine();
            System.out.println("\n\u001B[31m1 - Attack \n\u001B[31m2 - Use Potion \n\u001B[31m3 - Run away");
            switch (battleChoice) {
                case "1":
                    if (user.speed >= FinalBoss.speed) {
                        //Player hits enemy first
                        //50/50 chance of the hit being a critical hit
                        randomNum = 1 + (int) (Math.random() * 2);
                        if (randomNum == 1) {
                            criticalDmg = 1 + (int) (Math.random() * 5);
                            System.out.println("\u001B[31mCritical hit +" + criticalDmg);
                            tempEnemyHp = tempEnemyHp - playerDamage - criticalDmg;
                            System.out.println("You hit the " + FinalBoss.name + " with your " + user.weapon
                                    + " for " + (playerDamage + criticalDmg) + " damage.");
                            //Check if enemy died
                            if (tempEnemyHp <= 0) {
                                System.out.println("You win! You gained " + user.exp + " experience points");
                                break;
                            }
                        } else if (randomNum == 2) {
                            tempEnemyHp -= playerDamage;
                            System.out.println("You hit the " + FinalBoss.name + " with your " + user.weapon
                                    + " for " + playerDamage + " damage.");
                            //Check if enemy died
                            if (tempEnemyHp <= 0) {
                                System.out.println("You win! You gained " + user.exp + " experience points");
                                break;
                            }
                        }


                        //Enemy hits player
                        //50/50 chance of the hit being a critical hit
                        randomNum = 1 + (int) (Math.random() * 2);
                        if (randomNum == 1) {
                            criticalDmg = 1 + (int) (Math.random() * 5);
                            System.out.println("\u001B[31mCritical hit +" + criticalDmg);
                            tempPlayerHp = tempPlayerHp - enemyDamage - criticalDmg;
                            System.out.println("The " + FinalBoss.name + " hits you with their " + FinalBoss.weapon
                                    + " for " + (enemyDamage + criticalDmg) + " damage.");
                            //Check if player died
                            if (tempPlayerHp <= 0) {
                                System.out.println("You see only black, the kingdom has fallen.");
                                System.exit(0);
                            }
                        } else if (randomNum == 2) {
                            tempPlayerHp -= enemyDamage;
                            System.out.println("The " + FinalBoss.name + " hits you with their " + FinalBoss.weapon
                                    + " for " + enemyDamage + " damage.");
                            //Check if player died
                            if (tempPlayerHp <= 0) {
                                System.out.println("You see only black, the kingdom has fallen.");
                                System.exit(0);
                            }
                        }
                        //Display Hp
                        System.out.println("\u001B[32mYour HP: " + tempPlayerHp + " /" + user.maxHealth
                                + "\n\u001B[32mEnemy HP: " + tempEnemyHp + " /" + FinalBoss.maxHealth);


                    } else if (user.speed < FinalBoss.speed) {
                        //Enemy hits player first
                        //50/50 chance of the hit being a critical hit
                        randomNum = 1 + (int) (Math.random() * 2);
                        if (randomNum == 1) {
                            criticalDmg = 1 + (int) (Math.random() * 5);
                            System.out.println("\u001B[31mCritical hit +" + criticalDmg);
                            tempPlayerHp = tempPlayerHp - enemyDamage - criticalDmg;
                            System.out.println("The " + FinalBoss.name + " hits you with their " + FinalBoss.weapon
                                    + " for " + (enemyDamage + criticalDmg) + " damage.");
                            //Check if player died
                            if (tempPlayerHp <= 0) {
                                System.out.println("You see only black, the kingdom has fallen.");
                                System.exit(0);
                            }
                        } else if (randomNum == 2) {
                            tempPlayerHp -= enemyDamage;
                            System.out.println("The " + FinalBoss.name + " hits you with their " + FinalBoss.weapon
                                    + " for " + enemyDamage + " damage.");
                            //Check if player died
                            if (tempPlayerHp <= 0) {
                                System.out.println("You see only black, the kingdom has fallen.");
                                System.exit(0);
                            }
                        }
                        //Player hits enemy
                        //50/50 chance of the hit being a critical hit
                        randomNum = 1 + (int) (Math.random() * 2);
                        if (randomNum == 1) {
                            criticalDmg = 1 + (int) (Math.random() * 5);
                            System.out.println("\u001B[31mCritical hit +" + criticalDmg);
                            tempEnemyHp = tempEnemyHp - playerDamage - criticalDmg;
                            System.out.println("You hit the " + FinalBoss.name + " with your " + user.weapon
                                    + " for " + (playerDamage + criticalDmg) + " damage.");
                            //Check if enemy died
                            if (tempEnemyHp <= 0) {
                                System.out.println("You win! You gained " + user.exp + " experience points");
                                break;
                            }
                        } else if (randomNum == 2) {
                            tempEnemyHp -= playerDamage;
                            System.out.println("You hit the " + FinalBoss.name + " with your " + user.weapon
                                    + " for " + playerDamage + " damage.");
                            //Check if enemy died
                            if (tempEnemyHp <= 0) {
                                System.out.println("You win! You gained " + user.exp + " experience points");
                                break;
                            }
                        }
                        //Display Hp
                        System.out.println("\u001B[32mYour HP: " + tempPlayerHp + " /" + user.maxHealth
                                + "\n\u001B[32mEnemy HP: " + tempEnemyHp + " /" + FinalBoss.maxHealth);
                    }
                    continue;
                case "2":
                    //Player attempts to use health potion
                    if (user.healthPotion != 0) {
                        System.out.println("You use a health potion, you feel refreshed.");
                        tempPlayerHp += 50;
                        if (tempPlayerHp > user.maxHealth) {
                            tempPlayerHp = user.maxHealth;
                        }
                        user.healthPotion -= 1;
                        //Display Hp
                        System.out.println("\u001B[32mYour HP: " + tempPlayerHp + " /" + user.maxHealth
                                + "\n\u001B[32mEnemy HP: " + tempEnemyHp + " /" + FinalBoss.maxHealth);
                    } else {
                        System.out.println("You don't have any health potions left!");
                    }
                    //50/50 chance of enemy attacking you
                    randomNum = 1 + (int) (Math.random() * 2);
                    if (randomNum == 1) {
                        System.out.println("The " + FinalBoss.name + " stares at you.");
                        continue;
                    } else if (randomNum == 2) {
                        //Enemy hits player as they use potion
                        System.out.println("The " + FinalBoss.name + " hits you with their " + FinalBoss.weapon
                                + " for " + enemyDamage + " damage.");
                        tempPlayerHp -= enemyDamage;
                        //Display Hp
                        System.out.println("\u001B[32mYour HP: " + tempPlayerHp + " /" + user.maxHealth
                                + "\n\u001B[32mEnemy HP: " + tempEnemyHp + " /" + FinalBoss.maxHealth);
                        //Check if player died
                        if (tempPlayerHp <= 0) {
                            System.out.println("You see only black, the kingdom has fallen.");
                            System.exit(0);
                        }
                        continue;
                    }
                    continue;
                case "3":
                    System.out.println("You can't run away from a boss battle!");
                    continue;
            }
            break;
        }
        //BATTLE END
        //</editor-fold >

        //<editor-fold defaultstate="collapsed" desc="EXP Method">
        //Give user exp
        EXP = EXP + user.exp;
        user.expCalc();
        if (user.levelup == true && user.level != 100) {
            user.level += 1;
            //Add stats if user levels up
            atkPts = 0;
            defPts = 0;
            spdPts = 0;
            int hp = 0;
            atkPts += 0 + (int) (Math.random() * 3);
            defPts += 0 + (int) (Math.random() * 3);
            spdPts += 0 + (int) (Math.random() * 3);
            hp += 0 + (int) (Math.random() * 2);
            System.out.println("\n\u001B[31mLEVEL UP:"
                    + "\n+" + atkPts + " Attack"
                    + "\n+" + defPts + " Defense"
                    + "\n+" + spdPts + " Speed");
            user.attack += atkPts;
            user.defense += defPts;
            user.speed += spdPts;
            user.maxHealth += hp;
        } else if (user.level == 100) {
            user.levelup = false;
            System.out.println("\u001B[33mYou have reached the max level of 100!");
        } else {
            user.levelup = false;
        }
        user.levelup = false;
        //</editor-fold>

        //Display Stats
        System.out.println("\u001B[31m---------------------------------------------");
        System.out.println("\u001B[32mPlayer stats:"
                + "\nName: " + user.name
                + "\nWeapon: " + user.weapon
                + "\nNumber of health potions: " + user.healthPotion
                + "\nHealth: " + user.maxHealth
                + "\nAttack: " + user.attack
                + "\nDefense: " + user.defense
                + "\nSpeed: " + user.speed
                + "\nExperience points: " + EXP + "/10"
                + "\nLevel: " + user.level);

        //<editor-fold defaultstate="collapsed" desc="Continue game">
        //Continue game
        System.out.println("\n\u001B[31mEnter \"continue\" to progress.");
        while (true) {
            String progress = userInput.nextLine();
            if (progress.equalsIgnoreCase("continue")) {
                break;
            } else {
                System.out.println("\u001B[31mInvalid type, please enter \"continue\"");
                continue;
            }
        }
        //</editor-fold>

        System.out.print("\nKevin falls and King Ike comes into the room with the Queen."
                + "\nQueen Elincia: Thank you so much " + user.name + " You've saved Crimea from the invasion of Begnion."
                + "\nWe are eternally grateful.");

        //<editor-fold defaultstate="collapsed" desc="Continue game">
        //Continue game
        System.out.println("\n\u001B[31mEnter \"continue\" to progress.");
        while (true) {
            String progress = userInput.nextLine();
            if (progress.equalsIgnoreCase("continue")) {
                break;
            } else {
                System.out.println("\u001B[31mInvalid type, please enter \"continue\"");
                continue;
            }
        }
        //</editor-fold>

        System.out.println("\n\u001B[31mYou saved the Kingdom, great job adventurer!"
                + "\n\u001B[31mYou are given the honour of being the commander of the Crimean army."
                + "\n\u001B[31mThank you for playing.");

        //<editor-fold defaultstate="collapsed" desc="Continue game">
        //Continue game
        System.out.println("\n\u001B[31mEnter \"continue\" to progress.");
        while (true) {
            String progress = userInput.nextLine();
            if (progress.equalsIgnoreCase("continue")) {
                break;
            } else {
                System.out.println("\u001B[31mInvalid type, please enter \"continue\"");
                continue;
            }
        }
        //</editor-fold>

        //Display Stats
        System.out.println("\u001B[31m---------------------------------------------");
        System.out.println("Player stats:"
                + "\nName: " + user.name
                + "\nWeapon: " + user.weapon
                + "\nNumber of health potions: " + user.healthPotion
                + "\nHealth: " + user.maxHealth
                + "\nAttack: " + user.attack
                + "\nDefense: " + user.defense
                + "\nSpeed: " + user.speed
                + "\nExperience points: " + EXP + "/10"
                + "\nLevel: " + user.level);

        System.out.println("\u001B[31m~fin"
                + "\n\nYour stats have been saved in the game files.");

        //Write Player level to Levels.txt file
        String myLine;
        PrintWriter fileOut = new PrintWriter(new BufferedWriter(new FileWriter("Levels.txt", true)));

        myLine = "\n" + user.level;
        //Output LEVEL directly to file
        fileOut.println(myLine);

        //The file closes after writing is complete
        fileOut.close();
    }

    //LinearSearch Method
    public static boolean LinearSearch(int myArray[], int V) {
        int k;
        for (k = 0; k < myArray.length; k++) {
            if (myArray[k] == V) {
                return true;
            }
            if (myArray[k] >  V) {
                //Gone too far on the list so V exist
                return false;
            }
        }
        return false;
    }

    //Bubblesort method
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

    //Swap method for bubble sort.
    public static void swap(int array2[], int first, int second) {
        int hold = array2[first];
        array2[first] = array2[second];
        array2[second] = hold;
    }
}