using System;

namespace terminal_rpg
{
    // Child class Goblin which inherits from Enemy
    public class Crawler : Enemy
    {

        public Crawler(string name) : base(name)
        {
            ClassName = "Crawler";
            Health = 301;
        }
    }
}
