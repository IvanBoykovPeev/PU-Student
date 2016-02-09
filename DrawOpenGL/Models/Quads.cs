using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawOpenGL
{
    class Quads : Shape
    {
        Vector3 point1;
        Vector3 point2;
        Vector3 point3;
        Vector3 point4;
        public Quads(Vector3 vertex1, Vector3 vertex2, Vector3 vertex3, Vector3 vertex4, int name)
        {
            this.Name = name;
            this.point1 = vertex1;
            this.point2 = vertex2;
            this.point3 = vertex3;
            this.point4 = vertex4;
        }
        
        internal override void DrawSelf()
        {
            base.DrawSelf();

            {
                GL.LoadIdentity();
                GL.Color3(System.Drawing.Color.Wheat);
                GL.PushName(Name);
                GL.Translate(Translate);
                GL.Rotate(Rotate, Vector3.UnitZ);
                GL.Scale(Scale);
                GL.Begin(BeginMode.Quads);
                GL.Vertex3(point1);
                GL.Vertex3(point2);
                GL.Vertex3(point3);
                GL.Vertex3(point4);
                GL.End();
            }
        }
    }
}
