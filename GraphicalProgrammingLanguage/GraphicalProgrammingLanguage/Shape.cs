using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphicalProgrammingLanguage
{
    /// <summary>
   /// this is used to provide shape of any object. 
    /// </summary>
    public interface IShape
    {
      /// <summary>
      /// this is used to draw any shape.
      /// </summary>
      /// <param name="g">Draw parameter</param>
            void draw(Graphics g);
        /// <summary>
        /// This sets the values of any shapes.
        /// </summary>
        /// <param name="list">Set Parameter</param>
            void set(params int[] list);
      
    }
}
