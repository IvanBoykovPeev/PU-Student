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

        Vector3 point1;
        Vector3 point2;
        Vector3 point3;
        public Triangle(Vector3 vertex1, Vector3 vertex2, Vector3 vertex3, int name)
        {
            this.Name = name;
            this.point1 = vertex1;
            this.point2 = vertex2;
            this.point3 = vertex3;
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
                GL.Rotate(Rotate, Vector3.UnitZ);
                GL.Scale(Scale);
                GL.Begin(BeginMode.Triangles);
                GL.Vertex3(point1);
                GL.Vertex3(point2);
                GL.Vertex3(point3);
                GL.End();
            }
        }
    }
}
