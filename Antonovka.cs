using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLessonApp
{
    class Antonovka : Apple
    {
        public Antonovka (string antonovkaKind, double antonovkaAge ) : base (antonovkaKind, antonovkaAge)
        { 
        }

        public new void Grow()
        {
            Age *= 1.5 ;
        }
    }
}
