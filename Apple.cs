using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLessonApp
{
    class Apple : Tree
    {
        public Apple( string appleKind, double appleAge) : base(appleKind, appleAge)
        {

        }

        public override void Grow()
        {
            Age += 1;
        }
    }
}
