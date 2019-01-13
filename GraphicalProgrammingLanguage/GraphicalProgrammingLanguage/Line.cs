using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphicalProgrammingLanguage
{
    /// <summary>
    /// this methods decleares the line class
    /// </summary>
    public class Line: IShape
    {
        /// <summary>
        /// this methods passes the interer values of X and Y to x-axis and Y-axis
        /// </summary>
        public int x, y, toX, toY;
        /// <summary>
        /// 
        /// </summary>
        public Line() : base()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="toX"></param>
        /// <param name="toY"></param>
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
        /// <summary>
        /// this methods sets the values oc x and y of line to x-axis and y-axis
        /// </summary>
        /// <param name="list"></param>

        public void set(params int[] list)
        {
            this.x = list[0];
            this.y = list[1];
            this.toX = list[2];
            this.toY = list[3];
        }
    }
}
