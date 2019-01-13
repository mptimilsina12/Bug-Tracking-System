using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphicalProgrammingLanguage
{
    /// <summary>
    /// class of Triangle is decleared.
    /// </summary>
    public class Triangle : IShape
    {
        /// <summary>
        /// integer values of x-axis, y_axis , width and height of trianle is decleared.
        /// </summary>
        public int x, y, width, height;
        /// <summary>
        /// width and height if triangle is passed.
        /// </summary>
        public Triangle() : base()
        {
            width = 0;
            height = 0;
        }
        /// <summary>
        /// function for triangle is decleared.
        /// </summary>
        /// <param name="x">X-Axis</param>
        /// <param name="y">Y-Axis</param>
        /// <param name="width">Width of Triangle</param>
        /// <param name="height">Height of Triangle</param>
        public Triangle(int x, int y, int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        /// <summary>
        /// this methods is udes to draw the triangle on the provided points.
        /// </summary>
        /// <param name="g"></param>
        public void draw(Graphics g)
        {

            Point[] p = new Point[3];
            p[0].X = x;
            p[0].Y = y - (height / 2);

            p[1].X = x - (width / 2);
            p[1].Y = y + (height / 2);

            p[2].X = x + (width / 2);
            p[2].Y = y + (height / 2);
            Pen po = new Pen(Color.Black, 2);
            g.DrawPolygon(po, p);
        }
        /// <summary>
        /// This methods sets the value for triangle
        /// </summary>
        /// <param name="list"> list parameter</param>
        public void set(params int[] list)
        {
            this.x = list[0];
            this.y = list[1];
            this.width = list[2];
            this.height = list[3];
        }
    }
}
