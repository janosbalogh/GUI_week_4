using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_week_4.Models
{
    public class Trooper
    {
        private string type;
        private int speed;
        private int cost;
        private int power;
        private Hostile hostile;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }


        public int Power
        {
            get { return power; }
            set { power = value; }
        }


        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }


        public int Cost
        {
            get { return cost; }
            set { cost = value; }
        }


        public Hostile Hostile
        {
            get { return hostile; }
            set { hostile = value; }
        }


    }

    public enum Hostile
    {
        good,
        bad,
        natural
    }
}
