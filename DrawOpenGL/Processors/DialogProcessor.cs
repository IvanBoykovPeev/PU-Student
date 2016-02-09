using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using OpenTK.Graphics.OpenGL;
using Tao.OpenGl;
using System.Windows.Forms;
using OpenTK;

namespace DrawOpenGL
{
    class DialogProcessor : GeometricProcessor
    {
        
        public DialogProcessor()
        {
            
            Shape p1 = new Point(new Vector3(100, 100, 0), 55);
            Shape p2 = new Point(new Vector3(100, 200, 0), 99);
            Shape r1 = new Triangle(new Vector3(100, 100, 0),
                                    new Vector3(100, 200, 0),
                                    new Vector3(200, 200, 0), 77);
            Shape quad = new Quads(new Vector3(400, 200, 0),
                                    new Vector3(500, 200, 0),
                                    new Vector3(500, 400, 0),
                                    new Vector3(400, 400, 0), 999);
            Shape drawVector = new DrawVector(new Vector3(150, 550, 0),
                                              new Vector3(200, 600, 0), 991);


            ShapeList.Add(r1);
            ShapeList.Add(quad);
            ShapeList.Add(drawVector);

            ShapeList.Add(p1);
            ShapeList.Add(p2);   
      
        
        }        
        internal void addPoint()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);
            int name = rnd.Next(1, 5000); //Random name
            Shape s = new Point(new Vector3(x, y, 0), name);
            ShapeList.Add(s);
        }





        
    }
}
