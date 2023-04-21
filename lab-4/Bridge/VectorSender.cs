using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class VectorSender : Renderer
    {
        public VectorSender(IShape shp) : base(shp) { }

        public override void Render()
        {
            shape.Draw();
            Console.WriteLine("as mathematical equations defining geometric shapes :D");
        }
    }
}
