using Renderers.Renderers;
using Renderers.Renderers.Interfaces;

namespace Renderers
{
    public class Program
    {
        public static void Main()
        {
            IRenderer renderer = new WebRenderer();
            Square square = new Square(new Position(5, 15), renderer);
            Circle circle = new Circle(new Position(13, 23), renderer);
            square.Draw();
            circle.Draw();
        }
    }
}
