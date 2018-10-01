using System;
using System.Collections.Generic;
namespace Wizard_Ninja_Samurai{
    public class Wizard : Human{
            
        public Wizard(string name) : base(name){
            this.Health = 50;
            this.intelligence = 25;
        }

        public void heal(){
            this.Health += (10 * this.intelligence);
        }

        public int fireball(Human enemy){
            Random rand = new Random(); 
            int damage = rand.Next(20,51);
            if(enemy == null)
        {
            Console.WriteLine("Failed Attack");
            return 0;
        }
        else
        {
            enemy.Health -= damage;
            return enemy.Health;
        }
        }

    }
    
}
