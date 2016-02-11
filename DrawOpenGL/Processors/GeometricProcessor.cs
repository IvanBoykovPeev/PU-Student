using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL;
using OpenTK;

namespace DrawOpenGL
{
    class GeometricProcessor : DislpayProcessor
    {
        
        public GeometricProcessor()
        {
        }

        internal void Translate(int selectedElement)
        {

            foreach (var item in ShapeList)
            {
                if (item.Name == selectedElement)
                {
                    item.Translate += new Vector3d(10, 10, 0);
                }
            }
            base.ReDraw();
        }

        internal void Rotate(int selectedElement)
        {
            foreach (var item in ShapeList)
            {
                if (item.Name == selectedElement)
                {
                    item.Rotate += 5;
                }
            }
            base.Draw();
        }

        internal void Scale(int selectedElement)
        {
            foreach (var item in ShapeList)
            {
                if (item.Name == selectedElement)
                {
                    item.Scale += new Vector3(0.1f,0.1f,0.1f);
                }
            }
            base.Draw();
        }
    }
}
