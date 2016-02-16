using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using OpenTK.Graphics.OpenGL;
using OpenTK;

namespace DrawOpenGL
{
    class Triangle : Shape
    {
        public Triangle(float vertex1, float vertex2, float vertex3)
        {
            this.X = vertex1;
            this.Y = vertex2;
            this.Width = vertex3;
        }

        internal override void DrawSelf()
        {
            base.DrawSelf();

            {
                GL.LoadIdentity();
                GL.Color3(Color.Yellow);
                GL.PushName(Name);
                //GL.LoadName(Name);
                GL.Translate(Translate);
                GL.Rotate(RotateAngle, Vector3.UnitZ);
                GL.Scale(Scale);
                GL.Begin(BeginMode.Triangles);
                GL.Vertex3(X, Y, 0);
                GL.Vertex3(Width, Y, 0);
                GL.Vertex3(X, Height, 0);
                GL.End();
            }
        }
    }
}
