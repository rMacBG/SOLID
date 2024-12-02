using Renderers.Common;
using Renderers.Renderers;
using Renderers.Renderers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renderers
{
    public class Circle
    {
        private IRenderer _renderer;
        

        public Circle(Position position,IRenderer renderer)
        {
            this.Position = position;
            this._renderer = renderer;
        }
        public int Size { get; set; }
        public Position Position { get; set; }
        public void Draw()
        {
           if (Configs.OutputType=="console")
            _renderer.Render("Circle", Position);
           
        }
    }
}
