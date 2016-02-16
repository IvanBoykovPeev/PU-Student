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


        //public Marcer()
        //{
        //}
        public Marcer(Shape marcedShape)
        {
            this.X = marcedShape.X;
            this.Y = marcedShape.Y;
            this.Width = marcedShape.Width;
            this.Height = marcedShape.Height;
            this.ShapeName = "marcer";
        }
        internal override void DrawSelf()
        {
            base.DrawSelf();
            {
                GL.LoadIdentity();
                GL.Color3(System.Drawing.Color.Red);
                GL.LineWidth(2);
                GL.PushName(0);
                GL.Translate(Translate);
                GL.Rotate(RotateAngle, Vector3.UnitZ);
                GL.Scale(Scale);
                GL.LineStipple(1, 0xF0F0);
                GL.Begin(BeginMode.LineLoop);
                GL.Vertex3(X, Y, 0);
                GL.Vertex3(Width, Y, 0);
                GL.Vertex3(Width, Height, 0);
                GL.Vertex3(X, Height, 0);
                GL.End();
            }
        }
    }
}

