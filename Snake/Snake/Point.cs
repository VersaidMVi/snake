using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point()
        {

        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int offset, Directrion direction)
        {
            if (direction == Directrion.RIGHT)
                x += offset;
            else if (direction == Directrion.LEFT)
                x -= offset;
            else if (direction == Directrion.UP)
                y -= offset;
            else if (direction == Directrion.DOWN)
                y += offset;
        }

        public Point (int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
