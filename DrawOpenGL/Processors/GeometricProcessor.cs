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
        internal void Translate(int selectedPrimitiv)
        { 
            Vector3d translateVector = new Vector3d(5, 5, 1);
            foreach (var item in ShapeList)
            {
                if (item.Name == selectedPrimitiv)
                {
                    item.ShapeMatrix += translateVector;
                    item.WidthHeightPoint += translateVector;
                }
            }
        }

        internal void Rotate(int selectedElement)
        {
            foreach (var item in ShapeList)
            { 
                if (item.Name == selectedElement)
                {
                    item.RotateAngle += 5;
                }
            }
        }

        internal void Scale(int selectedElement)
        {
            foreach (var item in ShapeList)
            {
                if (item.Name == selectedElement)
                {
                    item.ShapeMatrix *= Vector3d.One;
                    item.WidthHeightPoint *= new Vector3d(1.01, 1.01, 1);
                }
            }
        }
        
    }
}
