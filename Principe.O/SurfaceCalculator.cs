using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principe.O
{
    public class SurfaceCalculator
    {
        public int ComputeAllSizes(IEnumerable<Shape> shapes)
        {
            int result = 0;
            foreach (Shape shape in shapes)
            {
                result += shape.Surface;
            }

            return result;
        }

        //private int ComputeSize(Shape shape)
        //{
        //    return shape switch
        //    {
        //        Square s => s.SideSize * s.SideSize,
        //        Rectangle r => r.Height * r.Width,
        //        _ => throw new InvalidOperationException()
        //    };

        // OU 

        //if(shape is Square s)
        //{
        //    return s.SideSize * s.SideSize;
        //}
        //else if(shape is Rectangle r)
        //{
        //    return r.Height * r.Width;
        //}
        //throw new InvalidOperationException();
        //}
    }
}
