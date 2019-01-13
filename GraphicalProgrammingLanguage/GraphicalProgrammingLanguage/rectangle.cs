using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphicalProgrammingLanguage
{
    /// <summary>
    /// this is the class decleared for rectangle
    /// </summary>
    public class Rectangle: IShape
    {
        /// <summary>
        /// the integer value of x-axis, y-axis , width and height of rectange is decleared.
        /// </summary>
        public int x, y, width, height;
        /// <summary>
        /// this methods provides the width and heights of rectangle
        /// </summary>
        public Rectangle() : base()
        {
            width = 0;
            height = 0;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">X-Axis</param>
        /// <param name="y">Y-Axis</param>
        /// <param name="width">Width of rectangle</param>
        /// <param name="height">Height of Rectangle</param>
        public Rectangle(int x, int y, int width, int height)
        {

            this.width = width; //the only thingthat is different from shape
            this.height = height;
        }
/// <summary>
/// this methods is used to draw the rectangle
/// </summary>
/// <param name="g">Graphics</param>
        public void draw(Graphics g)
        {
            Pen p = new Pen(Color.Black, 2);
            g.DrawRectangle(p, x - (width / 2), y - (height / 2), width * 2, height * 2);
        }
        /// <summary>
        /// This methods sets the value of X, Y , width and height of rectangle
        /// </summary>
        /// <param name="list">Set Parameter</param>
        public void set(params int[] list)
        {
            this.x = list[0];
            this.y = list[1];
            this.width = list[2];
            this.height = list[3];
        }
    }
}
