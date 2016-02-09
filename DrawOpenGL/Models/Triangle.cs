using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using OpenTK.Graphics.OpenGL;

namespace DrawOpenGL
{
    class Triangle : Shape
    {
        public Triangle(int name)
        {
            this.Name = name;
        }

        internal override void DrawSelf()
        {
            base.DrawSelf();

            {
                GL.LoadIdentity();
                //GL.Color3(Color.Yellow);
                GL.PushName(Name);
                //GL.LoadName(Name);
                GL.Translate(Translate);
                GL.Begin(BeginMode.Triangles);
                GL.Vertex2(50, 60);
                GL.Vertex2(100, 60);
                GL.Vertex2(100, 90);
                GL.End();
            }
        }
    }
}
