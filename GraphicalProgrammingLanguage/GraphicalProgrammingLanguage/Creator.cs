using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalProgrammingLanguage
{
    /// <summary>
    /// Creator class is decleared
    /// </summary>
    abstract class Creator
    {
        /// <summary>
        /// this methods pass the shapes for an object.
        /// </summary>
        /// <param name="ShapeType">Shape parameter</param>
        /// <returns></returns>
        public abstract IShape getShape(string ShapeType);
    }
}
