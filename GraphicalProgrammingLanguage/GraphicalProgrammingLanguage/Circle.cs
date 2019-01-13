using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphicalProgrammingLanguage
{
    /// <summary>
    /// this holds the commands/code of circle class
    /// </summary>
    public class Circle : IShape
    {
        /// <summary>
        /// this methods calls the integer values of x , y and radius.
        /// </summary>
        public int x, y, radius;
        /// <summary>
        /// 
        /// </summary>
        public Circle() : base()
        {

        }
        /// <summary>
        /// this method passes the value of circle
        /// </summary>
        /// <param name="x">x-axis</param>
        /// <param name="y">Y-axis</param>
        /// <param name="radius">Radius of circle</param>
        public Circle(int x, int y, int radius)
        {

            this.radius = radius; //the only thingthat is different from shape
        }

        /// <summary>
        /// This is draw method. It draw the circle on the panel
        /// </summary>
        /// <param name="g"></param>
        public void draw(Graphics g)
        {
            try
            {
                Pen p = new Pen(Color.Black, 2);
                g.DrawEllipse(p, x - radius, y - radius, radius * 2, radius * 2);
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        /// <summary>
        /// It sets the value of x, y and radius.
        /// </summary>
        /// <param name="list"></param>
        public void set(params int[] list)
        {
            try
            {
                this.x = list[0];
                this.y = list[1];
                this.radius = list[2];
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }



    }
}
