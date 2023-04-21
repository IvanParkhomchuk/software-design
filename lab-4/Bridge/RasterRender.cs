using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class RasterRender : Renderer
    {
        public RasterRender(IShape shp) : base(shp) { }

        public override void Render()
        {
            shape.Draw();
            Console.WriteLine("as pixels");
        }
    }
}
