using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using OpenTK.Graphics.OpenGL;

namespace DrawOpenGL
{
    class Rectangle : Shape
    {
        public Rectangle()
        {

        }

        internal override void DrawSelf(int x)
        {
            base.DrawSelf(x);

            {
                GL.MatrixMode(MatrixMode.Modelview);
                GL.LoadIdentity();
                GL.Color3(Color.Yellow);
                GL.Translate(x, 0, 0);
                GL.LoadName(1);
                GL.Begin(BeginMode.Triangles);
                GL.Vertex2(50, 60);
                GL.Vertex2(100, 60);
                GL.Vertex2(100, 90);
                GL.End();
            }
        }
        
    }
}
