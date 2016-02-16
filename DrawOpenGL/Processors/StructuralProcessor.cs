using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrawOpenGL;
using OpenTK.Graphics.OpenGL;
using System.Drawing;

namespace DrawOpenGL
{
    class StructuralProcessor : GeometricProcessor
    {
        Dictionary<int, int> Groups = new Dictionary<int, int>();
        Shape marker;
        Shape marcedShape;

        private Shape selectedShape;

        //public Shape SelectedShape
        //{
        //    get { return selectedShape; }
        //    set { selectedShape = value; }
        //}
        //public StructuralProcessor()
        //{
        //}


        //internal void SelectedPrimitiv(int selectedPrimitiv)
        //{
        //    if (selectedPrimitiv != 0)
        //    {
        //        foreach (var item in ShapeList)
        //        {
        //            if (item.Name == selectedPrimitiv)
        //            {
        //                item.IsSelected = true;
        //                SelectedShape = item;
        //                break;
        //            }
                    
        //        }
        //                marker = SelectedShape;
        //                ShapeList.Add(marker);

        //    }
        //}

        

        

        private List<ShapeGroup> shapeListGroupe = new List<ShapeGroup>();

        internal List<ShapeGroup> ShapeListGroupe
        {
            get { return shapeListGroupe; }
            set { shapeListGroupe = value; }
        }

        private List<Shape> shapeLinearization = new List<Shape>();

        public List<Shape> ShapeLinearization
        {
            get { return shapeLinearization; }
            set { shapeLinearization = value; }
        }
        public void linearization(List<ShapeGroup> shapeGroupe)
        {
            foreach (var item in ShapeListGroupe)
            {

                ShapeList.Add(item);
            }
            //    //nameOfGroupe = ShapeGroupeName;
            //return ShapeLinearization;
        }


        public override void ReDraw()
        {
            base.ReDraw();

            linearization(ShapeListGroupe);
            foreach (var item in ShapeLinearization)
            {
                DrawShape(item);
            }
        }

    }
}





