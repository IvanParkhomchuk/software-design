using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal abstract class Renderer
    {
        protected IShape shape;

        public Renderer(IShape shp) => shape = shp;

        public void SetShape(IShape shp) => shape = shp;

        public abstract void Render();
    }
}
