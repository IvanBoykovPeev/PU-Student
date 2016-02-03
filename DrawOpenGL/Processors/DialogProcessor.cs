using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using OpenTK.Graphics.OpenGL;
using Tao.OpenGl;
using System.Windows.Forms;

namespace DrawOpenGL
{
    class DialogProcessor : DislpayProcessor
    {
        public DialogProcessor()
        {

            Shape p1 = new Point(100, 200, 55);
            Shape p2 = new Point(300, 400, 99);
            Shape r1 = new Triangle(77);
            ShapeList.Add(r1);
            ShapeList.Add(p1);
            ShapeList.Add(p2);

           
        }

        

        internal void addPoint()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);
            int name = rnd.Next(0, 50);

            Shape s = new Point(x, y, name);
            ShapeList.Add(s);
        }
        
    }
}
