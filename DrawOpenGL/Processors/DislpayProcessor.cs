using DrawOpenGL;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Tao.OpenGl;
using Tao.Platform.Windows;
using OpenTK;
using System;
using OpenTK.Graphics.OpenGL;

namespace DrawOpenGL
{
    public abstract class  DislpayProcessor
    {
        public DislpayProcessor()
        {            
        }

        private List<Shape> shapeList = new List<Shape>();
        //private ShapeGroup shapeListG = new ShapeGroup();
        //private LinkedList<Shape> grup;

        //public LinkedList<Shape> Grup
        //{
        //    get { return grup; }
        //    set { grup = value; }
        //}

//internal ShapeGroup ShapeListG1
//{
//  get { return shapeListG; }
//  set { shapeListG = value; }
//}
        public List<Shape> ShapeList
        {
            get { return shapeList; }
            set { shapeList = value; }
        }


        public virtual void ReDraw()
        {            
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
            GL.MatrixMode(MatrixMode.Modelview);
            GL.Color3(Color.Black);
            GL.PointSize(10.0f);
            GL.InitNames();
            GL.LoadIdentity();
            item.DrawSelf();
            
        }
    }
}
