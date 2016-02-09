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

        public Point(Vector3 point, int name)
        {

            this.Name = name;
            this.Point = point;
        }

        internal override void DrawSelf()
        {
            base.DrawSelf();

            GL.LoadIdentity();
            GL.PushName(Name);
            //GL.LoadName(Name);
            GL.Translate(Translate);
            GL.Begin(BeginMode.Points);
            GL.Vertex3(Point);
            GL.End();
        }


    }
}
