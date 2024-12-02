using Renderers.Renderers;
using Renderers.Renderers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renderers
{
    public class Square
    {
        private IRenderer _renderer;

        public Square(Position position, IRenderer renderer)
        {
            this.Position = position;
            this._renderer = renderer;
        }
        public int Size { get; set; }
        public Position Position { get; set; }
        public void Draw()
        {
            _renderer.Render("Square", Position);
        }
    }
}
