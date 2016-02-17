using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using OpenTK.Graphics.OpenGL;
using Tao.OpenGl;
using System.Windows.Forms;
using OpenTK;

namespace DrawOpenGL
{
    class DialogProcessor : StructuralProcessor
    {
        int pointIncrementName = 1;

        public int PointIncrementName
        {
            get { return pointIncrementName; }
            set { pointIncrementName = value; }
        }
        public DialogProcessor()
        {
            //Shape p1 = new Point(new Vector3(50, 100, 0), 55);
            //Shape p2 = new Point(new Vector3(60, 200, 0), 99);
            //Shape triangle1 = new Triangle(new Vector3(100, 100, 0),
            //                        new Vector3(100, 200, 0),
            //                        new Vector3(200, 200, 0), 77);
            //Shape triangle2 = new Triangle(new Vector3(550, 200, 0),
            //                        new Vector3(600, 500, 0),
            //                        new Vector3(500, 500, 0), 88);
            //Shape quad = new Quads(new Vector3(400, 200, 0),
            //                        new Vector3(500, 200, 0),
            //                        new Vector3(500, 400, 0),
            //                        new Vector3(400, 400, 0), 999);
            //Shape drawVector = new DrawVector(new Vector3(150, 550, 0),
            //                                  new Vector3(200, 600, 0), 991);


            //ShapeGroup sp1 = new ShapeGroup(1);
            //sp1.AddShape(triangle1);
            //ShapeList.Add(sp1);
            //ShapeGroup shapeGroupe1 = new ShapeGroup(triangle1);
            //ShapeGroup shapeGroupe2 = new ShapeGroup(triangle2);
            //ShapeListGroupe.Add(shapeGroupe1);
            //ShapeListGroupe.Add(shapeGroupe2);
            //ShapeList.Add(shapeGroupe1);
            //ShapeList.Add(shapeGroupe1);
            //ShapeList.Add(quad);
            //ShapeList.Add(drawVector);
            //ShapeList.Add(p2);       

        }
        internal void addPoint()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            Shape s = new Point(new Vector3d(x, y , 0), PointIncrementName);
            PointIncrementName++;
            ShapeList.Add(s);
        }

        internal void AddRectangle()
        {
            Shape quad = new Quads(100, 100, 200, 200);
            ShapeList.Add(quad);
        }
        /// <summary>
        /// Ново изображение
        /// </summary>
        internal void NewImage()
        {
            ShapeList.Clear();
        }

        internal void SelectedCut(int selectedElement)
        {
            if (selectedElement == 0)
            {
                return;
            }
            if (selectedElement != 0)
            {
                foreach (var item in ShapeList)
                {
                    if (item.Name == selectedElement)
                    {
                        ShapeList.Remove(item);
                        //marker.Remove(item);
                        item.IsSelected = false;
                        break;
                    }
                }
            }
        }

        internal void CopyShape(int selectedShepe)
        {
            if (selectedShepe == 0)
            {
                return;
            }
            if (selectedShepe != 0)
            {
                foreach (var item in ShapeList)
                {
                    if (item.Name == selectedShepe)
                    {
                        SelectedShape = item;
                        //marker.Remove(item);
                        item.IsSelected = false;
                        break;
                    }
                }
                if (SelectedShape.Name == 1)
                {
                    int name = 1;
                Shape newShape = new Point(new Vector3d(100, 100, 0), name);
                name++;
                }
                ShapeList.Add(SelectedShape);
            }
        }

        internal void Select(int selectedPrimitiv)
        {
            ShapeList.Remove(marcer);
            if (selectedPrimitiv != 0)
            {
                foreach (var item in ShapeList)
                {
                    if (item.Name == selectedPrimitiv && !item.IsSelected)
                    {
                        item.IsSelected = true;
                        SelectedShape = item;

                    }
                }
                if (selectedShape.Name == 1)
                {
                    marcer = new Marcer(SelectedShape.ShapeMatrix - new Vector3d(10, 10, 0), SelectedShape.ShapeMatrix + new Vector3d(10, 10, 0));
                }
                else
                {

                    marcer = new Marcer(SelectedShape.ShapeMatrix, SelectedShape.WidthHeightPoint);
                }

                ShapeList.Add(marcer);
            }
            if (selectedPrimitiv == 0)
            {
                foreach (var item in ShapeList)
                {
                    item.IsSelected = false;
                }
                ShapeList.Remove(marcer);
            }

        }

        internal void RemoveMarcer()
        {
            ShapeList.Remove(marcer);
        }

        Shape selectedShape;
        Shape marcer;
        public Shape SelectedShape
        {
            get { return selectedShape; }
            set {  selectedShape = value; }
        }
    }
}
