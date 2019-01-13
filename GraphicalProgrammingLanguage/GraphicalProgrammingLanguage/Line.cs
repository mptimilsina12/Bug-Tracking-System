using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphicalProgrammingLanguage
{
    public class Line: IShape
    {
        int x, y, toX, toY;
        public Line() : base()
        {

        }
        public Line(int x, int y, int toX, int toY)
        {


        }

        /// <summary>
        /// this method Drwa the circle
        /// </summary>
        /// <param name="g"> Graphics parameter</param>
        public void draw(Graphics g)
        {
            Pen p = new Pen(Color.Black, 2);
            g.DrawLine(p, x, y, toX, toY);
        }

        public void set(params int[] list)
        {
            this.x = list[0];
            this.y = list[1];
            this.toX = list[2];
            this.toY = list[3];
        }
    }
}
