using DrawOpenGL;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Tao.OpenGl;
using Tao.Platform.Windows;
using System.Drawing;
using OpenTK.Graphics.OpenGL;
using OpenTK;
using System;

namespace DrawOpenGL
{
    class DislpayProcessor
    {
        

        private List<Shape> shapeList = new List<Shape>();

        public List<Shape> ShapeList
        {
            get { return shapeList; }
            set { shapeList = value; }
        }
        public DislpayProcessor()
        {            
        }
        
        public virtual void ReDraw()
        {
            GL.MatrixMode(MatrixMode.Modelview);
            GL.Color3(Color.Black);
            GL.PointSize(10.0f);
            Draw();            
        }

        public virtual void Draw()
        {            
            foreach (var item in ShapeList)
            {                
                DrawShape(item);
            }            
        }

        public virtual void DrawShape(Shape item)
        {
            GL.InitNames();
            GL.LoadIdentity();
            item.DrawSelf();
        }
    }
}
