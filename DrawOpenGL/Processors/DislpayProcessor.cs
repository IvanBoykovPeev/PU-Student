﻿using DrawOpenGL;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Tao.OpenGl;
using Tao.Platform.Windows;
using System.Drawing;
using OpenTK.Graphics.OpenGL;
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

        //public void ReDraw(object sender, PaintEventArgs e)
        //{
        //    foreach (var item in ShapeList)
        //    {
        //        item.DrawSelf(x);
        //    }
        //}

        //private void Draw(Graphics graphics)
        //{
        //    foreach (Shape item in ShapeList)
        //    {
        //        item.DrawSelf(x);
        //    }
        //}

        public System.Drawing.Graphics graphics { get; set; }
    }
}
