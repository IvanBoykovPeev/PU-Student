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
    class Point : Shape
    {

        public Point(float x, float y)
        {
            ShapeMatrix = new Vector3(x, y, 0);
            //this.IsSelected = false;
            this.ShapeName = "Точка";
            this.Name = 1;
        }
        internal override void DrawSelf()
        {
            base.DrawSelf();

            GL.LoadIdentity();
            GL.PushName(Name);
            //GL.LoadName(Name);
            GL.Translate(Translate);
            GL.Begin(BeginMode.Points);
            GL.Vertex3(ShapeMatrix);
            GL.Vertex3(ShapeMatrix + new Vector3(0, 40, 0));
            GL.Vertex3(ShapeMatrix + new Vector3(100, 110, 0));
            GL.End();
        }


    }
}
