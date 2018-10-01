namespace Wizard_Ninja_Samurai
{
    public class Human{
        public string Name;
        public int Health { get; set; }
        public int strength { get; set; }
        public int intelligence { get; set; }
        public int dexterity { get; set; }

        public Human(string name){
            Name = name;
            Health = 100;
            strength = 3;
            intelligence = 3;
            dexterity = 3;
        }
        public Human(string name, int H = 100, int S = 3, int I = 3, int D = 3 ){
            Name = name;
            Health = H;
            strength = S;
            intelligence = I;
            dexterity = D;
        }

        public void attack(Human enemy)
        {
            if(enemy == null)
            {
                System.Console.WriteLine("Failed Attack");
            }
            else
            {
                enemy.Health -= strength * 5;
            }
        }

    }
}