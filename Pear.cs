using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLessonApp
{
    class Pear : Tree
    {
        public Pear(string pearKind, double pearAge) : base(pearKind, pearAge)
        {
          
        }

        public override void Grow()
        {
            Age += 2;
        }
    }
}
