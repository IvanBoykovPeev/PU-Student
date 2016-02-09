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
        public StructuralProcessor()
        {
        }
        Shape marcer;
        internal void SelectedMark(int selectedElement)
        {


            if (selectedElement != 0)
            {
                marcer = new Marcer(new Vector3(400, 200, 0),
                                    new Vector3(500, 200, 0),
                                    new Vector3(500, 400, 0),
                                    new Vector3(400, 400, 0), 912);
            ShapeList.Add(marcer);

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
            
        }
    }
}
