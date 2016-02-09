using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL;
using OpenTK;

namespace DrawOpenGL
{
    public abstract class Shape
    {

        private List<Shape> shapeList = new List<Shape>();
        private bool isSelected = false;
        private int name;
        private Vector3d translate = new Vector3d();
        private float rotate; //angle rotate need float value
        private Vector3 rotateVector = new Vector3(1f, 0f, 0f);
        private Vector3 scale = new Vector3(1, 1, 1);

        public Vector3 Scale
        {
            get { return scale; }
            set { scale = value; }
        }

        public Vector3 RotateVector
        {
            get { return RotateVector; }
            set { RotateVector = value; }
        }

        public float Rotate
        {
            get { return rotate; }
            set { rotate = value; }
        }
        private Vector3 point = new Vector3(0, 0, 0);

        public Vector3 Point
        {
            get { return point; }
            set { point = value; }
        }

        public Vector3d Translate
        {
            get { return translate; }
            set { translate = value; }
        }       

        public int Name
        {
            get { return name; }
            set { name = value; }
        }

        public bool IsSelected
        {
            get { return isSelected; }
            set { isSelected = value; }
        }
        public List<Shape> ShapeList
        {
            get { return shapeList; }
            set { shapeList = value; }
        }
        public Shape()
        {            
        }

        public Shape(Shape shape)
        {
            this.IsSelected = shape.isSelected;
            this.Name = shape.Name;
        }

        internal virtual void DrawSelf()
        {            
        }

    }
}
