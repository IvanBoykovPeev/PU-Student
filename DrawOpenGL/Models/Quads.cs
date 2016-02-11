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
        public Quads(Vector3 vertex1, Vector3 vertex2, Vector3 vertex3, Vector3 vertex4, int name) : base()
        {
            this.Name = name;
            this.Point1 = vertex1;
            this.Point2 = vertex2;
            this.Point3 = vertex3;
            this.Point4 = vertex4;
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
                GL.Vertex3(Point1);
                GL.Vertex3(Point2);
                GL.Vertex3(Point3);
                GL.Vertex3(Point4);
                GL.End();
            }
        }
    }
}
