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
            
            foreach (var item in ShapeList)
            {
                if (item.Name == selectedPrimitiv)
                {
                    //item.Translate += new Vector3d(10, 10, 0);
                    //marcer.Translate += new Vector3d(10, 10, 0);
                    item.X += 10;
                    item.Y += 10;
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
                    item.Scale += new Vector3(0.1f, 0.1f, 0.1f);
                }
            }
        }




        internal void Select(int selectedPrimitiv)
        {
            if (selectedPrimitiv != 0)
            {
                foreach (var item in ShapeList)
                {
                    if (item.Name == selectedPrimitiv)
                    {
                        item.IsSelected = true;
                        SelectedShape = item;

                    }
                }
                        //marcer = new Marcer(SelectedShape);

                //ShapeList.Add(marcer);
            }
            if (selectedPrimitiv == 0)
            {
                foreach (var item in ShapeList)
                {
                    item.IsSelected = false;
                }
                //ShapeList.Remove(marcer);
            }

        }


        //public override void Draw()
        //{
        //    base.Draw();
        //    //foreach (var item in Marcers)
        //    //{                
        //    //    DrawShape(item);
        //    //}
        //}

        Shape selectedShape;
        Shape marcer;
        public Shape SelectedShape
        {
            get { return selectedShape; }
            set { selectedShape = value; }
        }

        internal void RemoveMarcer()
        {

                //ShapeList.Remove(marcer);
            
        }
    }
}
