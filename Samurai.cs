using System;
using System.Collections.Generic;
namespace Wizard_Ninja_Samurai{

    public class Samurai : Human{
        public Samurai(string name) : base(name){
            this.Health = 200;
        }


        public void death_blow(Human enemy){
            if(enemy.Health < 50){
                enemy.Health = 0;
            }
        }

        public void meditate(){
            this.Health = 200;
        }
    }
}