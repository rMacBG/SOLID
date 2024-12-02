using System.Reflection;

namespace Renderers
{
    public class Position
    {
        public Position(int top, int left)
        {
            this.Top = top;
            this.Left = left;

        }
        public int Top { get; set; }

        public int Left { get; set; }
    }
}