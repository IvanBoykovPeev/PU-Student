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
        public DrawVector(float vertex1, float vertex2)
        {
            this.X = vertex1;
            this.Y = vertex2;
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
                GL.Rotate(RotateAngle, Vector3.UnitZ);
                GL.Scale(Scale);
                //GL.LineStipple(1, 300);
                GL.Begin(BeginMode.Lines);
                GL.Vertex3(X, Y, 0);
                GL.Vertex3(X, Y, 0);
                GL.End();
            }
        }        
    }
}
