﻿using System;
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

        public Point(double x, double y)
        {
            this.ShapeMatrix = new Vector3d(x, y, 0);
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
            GL.Vertex3(ShapeMatrix + new Vector3d(0, 40, 0));
            GL.Vertex3(ShapeMatrix + new Vector3d(100, 110, 0));
            GL.End();
        }


    }
}
