using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLessonApp
{
    abstract class Tree
    {
        public string Kind { get; private set; }

        private double age;
        public double Age 
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                {
                    age = 0;
                }
                else
                {
                    age = value;
                }
            }
        }
      
        public Tree(string constructKind, double constructAge)
        {
            Kind = constructKind;
            Age = constructAge;
        }

        public abstract void Grow();      
    }
}

