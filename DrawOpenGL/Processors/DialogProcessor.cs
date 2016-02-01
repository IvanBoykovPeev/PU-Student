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
        }

        Point tr1 = new Point();

        Point tr2 = new Point();
        Rectangle r1 = new Rectangle();
        
        
        public void Draw(int x)
        {
            ShapeList.Add(r1);
            ShapeList.Add(tr1);
            GL.InitNames();
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            
            
            
            foreach (var item in ShapeList)
            {
                item.DrawSelf(x);
            }


            
            //GL.Color3(Color.Yellow);
            //GL.InitNames();
            //GL.PushName(1);
            
            
            
            //GL.LoadName(2);
            //GL.Begin(BeginMode.Triangles);
            //GL.Vertex2(50, 60);
            //GL.Vertex2(100, 60);
            //GL.Vertex2(100, 90);
            //GL.End();
            
            //GL.LoadName(3);
            //GL.Begin(BeginMode.Triangles);
            //GL.Vertex2(400, 600);
            //GL.Vertex2(200, 600);
            //GL.Vertex2(200, 500);
            //GL.End();

            OpenTK.Graphics.GraphicsContext.CurrentContext.SwapBuffers();
        }
          
        
        public void DrawTriangle()
        {
            
            
            // Triangle triangle = new Triangle();
            // ShapeList.Add(triangle);
        }

        internal void addTriangle()
        {

        }
    }
}
