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
        private Shape marcedShape;

        public Marcer()
        {
        }
        public Marcer(Shape marcedShape)
        {
            this.Point1 = marcedShape.Point1;
            this.Point2 = marcedShape.Point2;
            this.Point3 = marcedShape.Point3;
            this.Point4 = marcedShape.Point4;
            this.marcedShape = marcedShape;
        }
        internal override void DrawSelf()
        {
            base.DrawSelf();
            {
                GL.LoadIdentity();
                GL.Color3(System.Drawing.Color.Red);
                GL.LineWidth(2);
                //GL.PushName(Name);
                GL.Translate(Translate);
                GL.Rotate(Rotate, Vector3.UnitZ);
                GL.Scale(Scale);
                GL.LineStipple(1, 0xF0F0);
                GL.Begin(BeginMode.LineLoop);
                GL.Vertex3(Point1);
                if (this.Point2 != Vector3.Zero)
                {
                    GL.Vertex3(Point2);
                }
                if (this.Point3 != Vector3.Zero)
                {
                    GL.Vertex3(Point3);
                }
                if (this.Point4 != Vector3.Zero)
                {
                    GL.Vertex3(Point4);
                }
                GL.End();
            }
        }
    }
}

