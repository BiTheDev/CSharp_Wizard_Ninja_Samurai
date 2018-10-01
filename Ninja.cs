using System;
using System.Collections.Generic;
namespace Wizard_Ninja_Samurai{
    public class Ninja : Human{
        public Ninja(string name) : base(name){
            this.dexterity = 175;
        }
WW
        public void steal(Human enemy){
            this.Health += 10;

        }

        public void get_away(){
            this.Health -= 15;
        }

    }
}