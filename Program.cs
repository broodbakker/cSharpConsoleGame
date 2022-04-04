using System;

using static System.Console;

using MonsterGenerator;
namespace game3
{
  class Programs
  {
    static void Main(string[] args)
    {
      //background setup
      ForegroundColor = ConsoleColor.Red;
      BackgroundColor = ConsoleColor.White;
      Clear();
      WriteLine("Hey awesome person! Are you ready to play a game?");
      Write("type ");
      ForegroundColor = ConsoleColor.White;
      BackgroundColor = ConsoleColor.Black;
      Write(" yes ");
      ForegroundColor = ConsoleColor.Red;
      BackgroundColor = ConsoleColor.White;
      WriteLine(" and press enter when you are ready.");
      WriteLine();
      //user input
      string userInput = ReadLine();

      if (userInput == "yes")
      {
        Clear();
        WriteLine("This is how the game works. During the game you encounter different kind of monsters which you will have to defeat.");
        WriteLine("You can attack them, but the monsters can also attack you. You both can choose between different kinds of attacks:");
        WriteLine();
        WriteLine("Fire:🔥 Leaf:🍀 and Water:🌊");
        WriteLine();
        WriteLine("You both attack at the same time. If you both use the same attack nothing happens.");
        WriteLine("But if you both use a different attack one will lose and 1 will win the round.");
        WriteLine("For example: if you use Fire:🔥 and the monster uses Leaf:🍀 you will win and the monster will lose a hitpoint.");
        WriteLine("But if you use Fire:🔥 and the monster uses Water:🌊 the monster will win and you lose a hitpoint.");
        WriteLine();
        WriteLine("Fire:🔥 > Leaf:🍀");
        WriteLine("Leaf:🍀 > Water:🌊");
        WriteLine("Water:🌊 > Fire:🔥");
        WriteLine();
        WriteLine("");
        WriteLine("You can also score combo points. You will score combo points if you win multiple rounds in a row.");
        WriteLine("The first time you win, the monster loses 1 hitpoint if you win another round back to back your attack doubles, and the monster loses 2 hitpoints");
        WriteLine("the next time you win the round your attack doubles again and the monster loses 4 hitpoints etc etc.");
        WriteLine("If you lose the round or if you both use the same attack the combo score will reset to 1.");
        WriteLine("");
        WriteLine("If you don't have any hitpoints left you lose the game.");
        WriteLine("When you monster has no hitpoints left you won and another monster will appear.");
        WriteLine();
        WriteLine("I hope you are ready, good luck!");
        WriteLine("When you are ready press enter.");
        WriteLine();
        //wait for enter
        while (ReadKey().Key != ConsoleKey.Enter) { }


        Monster[] monsters = new Monster[3];
        monsters[0] = new Monster("spider", 2, @"
 .----------------. .----------------. .----------------. .----------------. .----------------. .----------------.
| .--------------. | .--------------. | .--------------. | .--------------. | .--------------. | .--------------. |
| |    _______   | | |   ______     | | |     _____    | | |  ________    | | |  _________   | | |  _______     | |
| |   /  ___  |  | | |  |_   __ \   | | |    |_   _|   | | | |_   ___ `.  | | | |_   ___  |  | | | |_   __ \    | |
| |  |  (__ \_|  | | |    | |__) |  | | |      | |     | | |   | |   `. \ | | |   | |_  \_|  | | |   | |__) |   | |
| |   '.___`-.   | | |    |  ___/   | | |      | |     | | |   | |    | | | | |   |  _|  _   | | |   |  __ /    | |
| |  |`\____) |  | | |   _| |_      | | |     _| |_    | | |  _| |___.' / | | |  _| |___/ |  | | |  _| |  \ \_  | |
| |  |_______.'  | | |  |_____|     | | |    |_____|   | | | |________.'  | | | |_________|  | | | |____| |___| | |
| |              | | |              | | |              | | |              | | |              | | |              | |
| '--------------' | '--------------' | '--------------' | '--------------' | '--------------' | '--------------' |
 '----------------' '----------------' '----------------' '----------------' '----------------' '----------------'
");
        monsters[1] = new Monster("snake", 5, @"
 .----------------. .-----------------..----------------. .----------------. .----------------.
| .--------------. | .--------------. | .--------------. | .--------------. | .--------------. |
| |    _______   | | | ____  _____  | | |      __      | | |  ___  ____   | | |  _________   | |
| |   /  ___  |  | | ||_   \|_   _| | | |     /  \     | | | |_  ||_  _|  | | | |_   ___  |  | |
| |  |  (__ \_|  | | |  |   \ | |   | | |    / /\ \    | | |   | |_/ /    | | |   | |_  \_|  | |
| |   '.___`-.   | | |  | |\ \| |   | | |   / ____ \   | | |   |  __'.    | | |   |  _|  _   | |
| |  |`\____) |  | | | _| |_\   |_  | | | _/ /    \ \_ | | |  _| |  \ \_  | | |  _| |___/ |  | |
| |  |_______.'  | | ||_____|\____| | | ||____|  |____|| | | |____||____| | | | |_________|  | |
| |              | | |              | | |              | | |              | | |              | |
| '--------------' | '--------------' | '--------------' | '--------------' | '--------------' |
 '----------------' '----------------' '----------------' '----------------' '----------------'
");
        monsters[2] = new Monster("octopus", 10, @"
 .----------------. .----------------. .----------------. .----------------. .----------------. .----------------. .----------------.
| .--------------. | .--------------. | .--------------. | .--------------. | .--------------. | .--------------. | .--------------. |
| |     ____     | | |     ______   | | |  _________   | | |     ____     | | |   ______     | | | _____  _____ | | |    _______   | |
| |   .'    `.   | | |   .' ___  |  | | | |  _   _  |  | | |   .'    `.   | | |  |_   __ \   | | ||_   _||_   _|| | |   /  ___  |  | |
| |  /  .--.  \  | | |  / .'   \_|  | | | |_/ | | \_|  | | |  /  .--.  \  | | |    | |__) |  | | |  | |    | |  | | |  |  (__ \_|  | |
| |  | |    | |  | | |  | |         | | |     | |      | | |  | |    | |  | | |    |  ___/   | | |  | '    ' |  | | |   '.___`-.   | |
| |  \  `--'  /  | | |  \ `.___.'\  | | |    _| |_     | | |  \  `--'  /  | | |   _| |_      | | |   \ `--' /   | | |  |`\____) |  | |
| |   `.____.'   | | |   `._____.'  | | |   |_____|    | | |   `.____.'   | | |  |_____|     | | |    `.__.'    | | |  |_______.'  | |
| |              | | |              | | |              | | |              | | |              | | |              | | |              | |
| '--------------' | '--------------' | '--------------' | '--------------' | '--------------' | '--------------' | '--------------' |
 '----------------' '----------------' '----------------' '----------------' '----------------' '----------------' '----------------'
");

        int userLifePoints = 10;

        //monsters
        foreach (Monster monster in monsters)
        {
          int enemyLifePoints = monster.hitPoints;
          int comboPoint = 1;

          Clear();
          Write($"{monster.icon}");
          WriteLine();
          Write($"The monster is a {monster.name}, he has ");
          ForegroundColor = ConsoleColor.White;
          BackgroundColor = ConsoleColor.Black;
          Write($" {monster.hitPoints} hitpoints ");
          ForegroundColor = ConsoleColor.Red;
          BackgroundColor = ConsoleColor.White;

          Write($" You have ");
          ForegroundColor = ConsoleColor.White;
          BackgroundColor = ConsoleColor.Black;
          Write($" {userLifePoints} hitpoints ");
          ForegroundColor = ConsoleColor.Red;
          BackgroundColor = ConsoleColor.White;
          WriteLine();

          //spel begint
          while (true)
          {
            WriteLine("Choose a number and press enter.");
            WriteLine();
            WriteLine("1. Fire:🔥");
            WriteLine("2. Leaf:🍀");
            WriteLine("3. Water:🌊");
            WriteLine();
            //user

            string userAttackNummber;
            while (true)
            {
              userAttackNummber = ReadLine();
              if (userAttackNummber == "1" | userAttackNummber == "2" | userAttackNummber == "3")
              {
                break;
              }
              WriteLine("type a valid number 1, 2 or 3 ");
            }
            int userInputAttack = Convert.ToInt32(userAttackNummber);
            //enemy
            Random rnd = new Random();
            int enemyAttackNumber = rnd.Next(1, 4);

            string enemyAttackIcon = enemyAttackNumber == 1 ? "🔥" : enemyAttackNumber == 2 ? "🍀" : "🌊";
            string userAttackIcon = userInputAttack == 1 ? "🔥" : userInputAttack == 2 ? "🍀" : "🌊";

            string enemyAttack = enemyAttackNumber == 1 ? "Fire" : enemyAttackNumber == 2 ? "Leaf" : "Water";
            string userAttack = userInputAttack == 1 ? "Fire" : userInputAttack == 2 ? "Leaf" : "Water";

            Clear();
            //gelijk
            if (enemyAttackNumber == userInputAttack)
            {
              WriteLine($"{monster.icon}");
              WriteLine($"you both use {enemyAttack}:{enemyAttackIcon} Nothing happens.");
              WriteLine();

              comboPoint = 1;
            }
            //speler wint
            if (enemyAttackNumber == 1 && userInputAttack == 3 ||
              enemyAttackNumber == 2 && userInputAttack == 1 ||
              enemyAttackNumber == 3 && userInputAttack == 2)
            {
              WriteLine($"{monster.icon}");
              WriteLine($"attacks with {enemyAttack}:{enemyAttackIcon}");
              WriteLine($"you attack with {userAttack}:{userAttackIcon}");
              WriteLine($"You win the round and the {monster.name} loses a hitpoint.");
              WriteLine();

              if (comboPoint > 1)
              {
                WriteLine($"You hit him with a combo, nice job! The monster loses {comboPoint} hitpoints.");
                WriteLine();
              }
              enemyLifePoints = enemyLifePoints - comboPoint;
              comboPoint = comboPoint * 2;

              if (enemyLifePoints < 0)
              {
                enemyLifePoints = 0;
              }
            }
            //speler verliest
            if (enemyAttackNumber == 1 && userInputAttack == 2 ||
             enemyAttackNumber == 2 && userInputAttack == 3 ||
             enemyAttackNumber == 3 && userInputAttack == 1)
            {
              WriteLine($"{monster.icon}");
              WriteLine($"attacks with {enemyAttack}:{enemyAttackIcon}");
              WriteLine($"you attack with {userAttack}:{userAttackIcon}");
              WriteLine($"You lose a hitpoint :(");
              WriteLine();

              comboPoint = 1;
              userLifePoints = userLifePoints - 1;
            }

            Write($"You have ");
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            WriteLine($" {userLifePoints} hitpoints ");
            ForegroundColor = ConsoleColor.Red;
            BackgroundColor = ConsoleColor.White;

            Write($"the {monster.name} has ");
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            WriteLine($" {enemyLifePoints} hitpoints ");
            ForegroundColor = ConsoleColor.Red;
            BackgroundColor = ConsoleColor.White;
            WriteLine();

            if (userLifePoints == 0)
            {
              WriteLine("You have lost but don't give up! you can try again.");
              break;
            }
            if (enemyLifePoints == 0)
            {
              WriteLine("You have won! Let's see if another monster awaits you!");
              WriteLine("Press enter when you are ready.");
              WriteLine();
              while (ReadKey().Key != ConsoleKey.Enter) { }
              break;
            }
          }

          if (userLifePoints == 0)
          {
            break;
          }
          else
          {
            Clear();

            WriteLine("Congratulations! There are no monsters left! You have defeated them all.");
            WriteLine();
            WriteLine("You are awesome");
            WriteLine();
            WriteLine("Thank you for playing this game");
            WriteLine();
          }
        }
      }
      else
      {
        WriteLine("no worries. Come back when you are ready");
      }
    }
  }
}
