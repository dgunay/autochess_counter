using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoChess_Counter
{
    // Represents a hero. Constrains its count to 0 >= x <= 3
    class HeroCounter
    {
        private int count;

        public HeroCounter()
        {
            count = 0;
        }

        public void increment()
        {
            if (count < 3)
            {
                count++;
            }
        }

        public void decrement()
        {
            if (count > 0)
            {
                count--;
            }
        }

        public int getCount() { return count; }
    }
}
