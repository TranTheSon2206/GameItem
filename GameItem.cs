using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_5._1
{
    public abstract class GameItem
    {
        protected string name {get;set;}
        protected int level { get;set;}
        protected int score { get;set;}
        public GameItem(string name, int level, int score)
        {
            this.name = name;
            this.level = level;
            this.score = score;
        }
        public virtual int ChangeLevel
            {
                get { return level; }
                set { level = value; }
            }
    }
}
