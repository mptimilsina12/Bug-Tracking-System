using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicalProgrammingLanguage
{
    /// <summary>
    /// 
    /// </summary>
    public class _3DRectangle: IShape
    {

        /// <summary>
        /// the integer value of x-axis, y-axis , width and height of rectange is decleared.
        /// </summary>
        public int x, y, width, height;
        /// <summary>
        /// this methods provides the width and heights of rectangle
        /// </summary>
        public _3DRectangle() : base()
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
        public _3DRectangle(int x, int y, int width, int height)
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
            try
            {
                Pen p = new Pen(Color.Red);
                g.DrawRectangle(p, x - width, y - height, width * 2, height * 2);
                Brush bgBrush = new SolidBrush(Color.Blue);
                g.SmoothingMode = SmoothingMode.AntiAlias;
                //Fill the background using Solid brush and then apply a white wash 
                RectangleF rec = new RectangleF(x - width, y - height, width * 2, height * 2);
                g.FillRectangle(bgBrush, x - width, y - height, width * 2, height * 2);
                g.FillRectangle(new SolidBrush(Color.FromArgb(180, Color.White)), x - width, y - height, width * 2, height * 2);
                ControlPaint.DrawBorder3D(g, x - width, y - height, width * 2, height * 2, Border3DStyle.Raised);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            

        }
        /// <summary>
        /// This methods sets the value of X, Y , width and height of rectangle
        /// </summary>
        /// <param name="list">Set Parameter</param>
        public void set(params int[] list)
        {
            try
            {
                this.x = list[0];
                this.y = list[1];
                this.width = list[2];
                this.height = list[3];
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
