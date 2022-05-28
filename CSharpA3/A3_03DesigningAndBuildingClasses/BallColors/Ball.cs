using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3_03DesigningAndBuildingClasses.BallColors
{
    public class Ball
    {
        Color BallColor { get; set; }
        int Size { get; set; }
        int TimesThrown { get; set; }

        public Ball(Color c, int size)
        {
            BallColor = c;
            Size = size;
            TimesThrown = 0;
        }

        public Ball(Color c)
        {
            BallColor = c;
            Size = 1;
            TimesThrown = 0;
        }

        public void Pop()
        {
            Size = 0;
        }

        public void Throw()
        {
            if (Size != 0)
            {
                TimesThrown++;
            }
        }

        public int GetTimesThrown()
        {
            return TimesThrown;
        }
    }
}
