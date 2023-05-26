using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_5._1
{
    public class Consumable : GameItem
    {
        protected int ManaGain { get; set; }
        public Consumable(string name, int level, int score, int ManaGain) : base(name, level, score)
        {
            this.ManaGain = ManaGain;
        }
        public void manaGain() { Console.WriteLine("This "+name+" gain "+ManaGain+" mana"); }

        public override string ToString()
        {
            return "Type:" + GetType().Name + ", Name:" + name + ", Level:" + level + ", Score:" + score  +"ManaGain: "+ManaGain;
        }
    }
}
