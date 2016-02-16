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
        private double p1;
        private double p2;
        private double p3;
        private double p4;

        //private int p1;
        //private int p2;
        //private int p3;
        //private int p4;

        

        public Quads(int x, int y, int width, int height)
        {
            // TODO: Complete member initialization
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
            this.IsSelected = false;
            this.ShapeName = "Правоъгълник";
        }
        
        internal override void DrawSelf()
        {
            base.DrawSelf();

            {
                GL.LoadIdentity();
                GL.Color3(System.Drawing.Color.Wheat);
                GL.PushName(4);
                GL.Translate(Translate);
                GL.Rotate(RotateAngle, Vector3.UnitZ);
                GL.Scale(Scale);
                GL.Rect(X, Y ,Width, Height);
                GL.Vertex3(X, Y, 0);
                GL.End();
            }
        }
    }
}
