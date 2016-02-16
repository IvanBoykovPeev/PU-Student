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
        public Quads(int x, int y, int width, int height)
        {
            // TODO: Complete member initialization
            this.ShapeMatrix = new Vector3d(x, y, 0);
            this.WidthHeightPoint = new Vector3d(width, height, 0);
            this.ShapeName = "Правоъгълник";
            this.Name = 4;
        }
        
        internal override void DrawSelf()
        {
            base.DrawSelf();

            {
                GL.LoadIdentity();
                GL.Color3(System.Drawing.Color.Wheat);
                GL.PushName(Name);
                GL.Translate(Translate);
                GL.Rotate(RotateAngle, Vector3d.UnitZ);
                GL.Scale(Scale);
                GL.Rect(ShapeMatrix.X, ShapeMatrix.Y, WidthHeightPoint.X, WidthHeightPoint.Y);
                GL.Vertex3(X, Y, 0);
                GL.End();
            }
        }
    }
}
