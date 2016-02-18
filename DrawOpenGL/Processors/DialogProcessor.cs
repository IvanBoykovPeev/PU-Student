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
        public List<Shape> ShapeListClipboard
        {
            get { return shapeListClipboard; }
            set { shapeListClipboard = value; }
        }
        public Shape SelectedShape
        {
            get { return selectedShape; }
            set { selectedShape = value; }
        }
        public int RectangleIncrementName
        {
            get { return rectangleIncrementName; }
            set { rectangleIncrementName = value; }
        }       
        public int TriangleIncrementName
        {
            get { return triangleIncrementName; }
            set { triangleIncrementName = value; }
        }      
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
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);
            Shape s = new Point(new Vector3d(x, y , 0), PointIncrementName);
            PointIncrementName++;
            ShapeList.Add(s);
        }
        internal void AddRectangle()
        {
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);
            Shape quad = new RectangleShape(new Vector3d(x, y , 0), new Vector3d(x + 100, y + 100 , 0), PointIncrementName);
            PointIncrementName++;
            ShapeList.Add(quad);
        }
        /// <summary>
        /// Ново изображение
        /// </summary>
        internal void NewImage()
        {
            ShapeList.Clear();
        }   
        internal void Select(int selectedPrimitiv)
        {
            if (selectedPrimitiv != 0)
            {
                foreach (var item in ShapeList)
                {
                    if (item.Name == selectedPrimitiv && !item.IsSelected)
                    {
                        item.IsSelected = true;
                    }
                }
            }
            if (selectedPrimitiv == 0)
            {
                foreach (var item in ShapeList)
                {
                    item.IsSelected = false;
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
                        item.IsSelected = false;
                        break;
                    }
                }
                Vector3d newShapeMatrix = SelectedShape.ShapeMatrix + new Vector3d(100, 100, 0);
                Vector3d newWidthHeightPoint = SelectedShape.WidthHeightPoint + new Vector3d(100, 100, 0);
                Shape newShape = new RectangleShape(SelectedShape.ShapeMatrix + new Vector3d(100, 100, 0), new Vector3d(SelectedShape.WidthHeightPoint + new Vector3d(100, 100, 0)), this.RectangleIncrementName);
                RectangleIncrementName++;
                ShapeList.Add(newShape);
            }
        }
        internal void DeleteShape(int selectedElement)
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
                        SelectedShape = item;
                        item.IsSelected = false;
                        break;
                    }
                }
                ShapeList.Remove(SelectedShape);
            }
        }

        internal void CutShape(int selectedElement)
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
                        SelectedShape = item;
                        item.IsSelected = false;
                        break;                    
                    }
                }
                ShapeList.Remove(SelectedShape);
                ShapeListClipboard.Add(SelectedShape);
            }
        }

        internal void RemoveMarcer()
        {
            ShapeList.Remove(marcer);
        }

        int triangleIncrementName = 1;
        int pointIncrementName = 1;
        int rectangleIncrementName = 1;
        Shape selectedShape;
        Shape marcer;
        Random rnd = new Random();
        private List<Shape> shapeListClipboard = new List<Shape>();

        
        
    }
}
