using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawOpenGL
{
    class DrawVector : Shape
    {
        public DrawVector(Vector3 vertex1, Vector3 vertex2, int name)
        {
            this.Name = name;
            this.Point1 = vertex1;
            this.Point2 = vertex2;
        }

        internal override void DrawSelf()
        {
            base.DrawSelf();

            {
                GL.LineWidth(1);
                GL.Color3(System.Drawing.Color.Tomato);
                GL.LoadIdentity();
                GL.PushName(Name);
                GL.Translate(Translate);
                GL.Rotate(Rotate, Vector3.UnitZ);
                GL.Scale(Scale);
                //GL.LineStipple(1, 300);
                GL.Begin(BeginMode.Lines);
                GL.Vertex3(Point1);
                GL.Vertex3(Point2);
                GL.End();
            }
        }        
    }
}
