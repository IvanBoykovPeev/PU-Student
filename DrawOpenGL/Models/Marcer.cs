using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrawOpenGL
{
    
    class Marcer : Shape
    {
        Vector3 point1;
        Vector3 point2;
        Vector3 point3;
        Vector3 point4;
        private int p;

        
        public Marcer(Vector3 vertex1, Vector3 vertex2, Vector3 vertex3, Vector3 vertex4, int name)
        {
            this.point1 = vertex1;
            this.point2 = vertex2;
            this.point3 = vertex3;
            this.point4 = vertex4;
        }

        public Marcer(Vector3 vector31, Vector3 vector32, Vector3 vector33, int p)
        {
            // TODO: Complete member initialization
            this.point1 = vector31;
            this.point2 = vector32;
            this.point3 = vector33;
            this.p = p;
        }
        
        internal override void DrawSelf()
        {
            base.DrawSelf();

            {
                GL.LoadIdentity();
                GL.Color3(System.Drawing.Color.Red);
                GL.LineWidth(1);
                GL.PushName(Name);
                GL.Translate(Translate);
                GL.Rotate(Rotate, Vector3.UnitZ);
                GL.Scale(Scale);
                GL.LineStipple(1, 0xF0F0);
                GL.Begin(BeginMode.LineLoop);
                GL.Vertex3(point1);
                GL.Vertex3(point2);
                GL.Vertex3(point3);
                GL.Vertex3(point4);
                GL.End();
            }
        }
    }
}
