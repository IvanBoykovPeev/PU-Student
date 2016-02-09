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
        
        public Point(int x, int y, int name)
        {
            this.X = x;
            this.Y = y;
            this.Name = name;
        }
        
        internal override void DrawSelf()
        {
            base.DrawSelf();
            
            
            GL.PushName(Name);
            //GL.LoadName(Name);
            GL.Translate(Translate);
            GL.Begin(BeginMode.Points);
            GL.Vertex2(X, Y);
            GL.End();
        }

        
    }
}
