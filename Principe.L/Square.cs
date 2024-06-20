using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principe.O
{
    public class Square : ShapeWithSurface
    {
        public int SideSize { get; set; }

        public override int Surface => SideSize * SideSize;
    }
}
