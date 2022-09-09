using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLessonApp
{
    class Alenushka : Pear
    {
        public Alenushka(string alenushkaKind, double alenushkaAge) : base (alenushkaKind, alenushkaAge)
        {

        }

        public override void Grow()
        {
            Age += 4;
        }            
    }
}
