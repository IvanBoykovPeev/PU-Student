using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrawOpenGL;

namespace DrawOpenGL
{
    class StructuralProcessor : GeometricProcessor
    {
        List<int> selectedShape = new List<int>();

        public List<int> SelectedShape
        {
            get { return selectedShape; }
            set { selectedShape = value; }
        }
        public StructuralProcessor()
        {
        }
        Shape marcer;
        internal void SelectedMark(int selectedElement)
        {
            if (selectedElement != 0)
            {

                marcer = new Marcer(new Vector3(100, 100, 0),
                                    new Vector3(100, 200, 0),
                                    new Vector3(200, 200, 0), 912);
            ShapeList.Add(marcer);
            SelectedShape.Add(selectedElement);
            }
            else
            {
                ShapeList.Remove(marcer);
                selectedShape.Clear();
            }
            {
                foreach (var item in ShapeList)
                {
                    if (item.Name == selectedElement)
                    {
                        item.IsSelected = true;
                        break;
                    }
                }
            }            
        }

        internal void SelectedCut(int selectedElement)
        {
            foreach (var item in ShapeList)
            {
                if (item.Name == selectedElement)
                {
                    ShapeList.Remove(item);
                }
            }
        }
    }
}
