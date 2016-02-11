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
        Shape marker;
        Shape marcedShape;
        internal void SelectedMark(int selectedElement)
        {
            if (selectedElement != 0)
            {
                foreach (var item in ShapeList)
                {
                    if (item.Name == selectedElement)
                    {
                        item.IsSelected = true;
                        marcedShape = item;
                        break;
                    }
                }
                marker = new Marcer(marcedShape);
                ShapeList.Add(marker);
                if (!selectedShape.Contains(selectedElement))
                {
                SelectedShape.Add(selectedElement);                    
                }
            }
            if(selectedElement == 0)
            {
                ShapeList.Remove(marker);
                selectedShape.Clear();
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
