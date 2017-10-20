using System;
using System.Collections.Generic;

namespace terminal_rpg
{
    class Human_Choices
    {
        public Human_Choices(string charName)
        {
            Human player = new Human(charName);
            System.Console.WriteLine("\nHere are your starting stats...\n");
            System.Console.ReadKey();
            System.Console.WriteLine("Current Player: {0}", player.ShowStatus());
            System.Console.ReadKey();
            Human_Choices.Choose_Action(player);
        }

        public static void Choose_Action(Human player)
        {
            int numSelect;
            Goblin enemy = new Goblin("Goblix");
            System.Console.WriteLine("\nOh no! A big, ugly, scary-looking thing appeared...");
            System.Console.ReadKey();
            // Get user input for selection
            System.Console.WriteLine(Program.newLine);
            System.Console.WriteLine("Now you must select a number to choose what you would like to do next.");
            System.Console.WriteLine(Program.newLine);
            foreach (KeyValuePair<int, string> action in player.Actions)
            {
                System.Console.WriteLine("{0}. {1}\n", action.Key, action.Value);
            }
            numSelect = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine(Program.newLine);

            switch (numSelect)
            {
                case 1:
                    System.Console.WriteLine("You chose {0} on {1} the {2}!", player.Actions[1], enemy.Name, enemy.ClassName);
                    player.Attack(enemy);
                    System.Console.ReadKey();
                    System.Console.WriteLine("Your current stats: {0}\n", player.ShowStatus());
                    System.Console.ReadKey();
                    System.Console.WriteLine("Enemy current stats: {0}\n", enemy.ShowStatus());
                    break;
                case 2:
                    System.Console.WriteLine("You chose {0}!", player.Actions[2]);
                    System.Console.ReadKey();
                    System.Console.WriteLine(Program.newLine);
                    System.Console.WriteLine("Your current stats: {0}\n", player.ShowStatus());
                    break;
                default:
                    System.Console.WriteLine("Learn how to number!");
                    System.Console.ReadKey();
                    System.Console.WriteLine(Program.newLine);
                    Human_Choices.Choose_Action(player);
                    break;
            }
        }
    }
}