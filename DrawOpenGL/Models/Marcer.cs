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
        public Marcer(Shape marcedShape)
        {

        }

        //public Marcer(Vector3d vector3d)
        //{
        //    // TODO: Complete member initialization
        //    this.ShapeName = "Маркер";
        //    this.Name = 999;
            
        //}

        public Marcer(Vector3d vector3d1, Vector3d vector3d2)
        {
            // TODO: Complete member initialization
            this.ShapeName = "Правоъгълен Маркер";
            this.Name = 999;
            this.ShapeMatrix = vector3d1;
            this.WidthHeightPoint = vector3d2;
        }
        internal override void DrawSelf()
        {
            base.DrawSelf();
            {
                GL.LoadIdentity();
                GL.Color3(System.Drawing.Color.Red);
                GL.LineWidth(2);
                GL.PushName(Name);
                GL.Translate(Translate);
                GL.Rotate(RotateAngle, Vector3.UnitZ);
                GL.Scale(Scale);
                GL.LineStipple(1, 0xF0F0);
                GL.Begin(BeginMode.LineLoop);
                GL.Vertex3(ShapeMatrix);                    
                GL.Vertex3(WidthHeightPoint.X, ShapeMatrix.Y, 0);
                GL.Vertex3(WidthHeightPoint);
                GL.Vertex3(ShapeMatrix.X, WidthHeightPoint.Y, 0);
                GL.End();
            }
        }
    }
}

