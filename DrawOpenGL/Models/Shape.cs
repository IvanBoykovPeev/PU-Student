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
        private float x;
        public float X
        {
            get { return x; }
            set { x = value; }
        }
        private float y;

        public float Y
        {
            get { return y; }
            set { y = value; }
        }
        private float width;

        public float Width
        {
            get { return width; }
            set { width = value; }
        }

        private float heght;

        public float Height
        {
            get { return heght; }
            set { heght = value; }
        }

        private Vector3d widthHeightPoint = new Vector3d(1, 1, 1);

        public Vector3d WidthHeightPoint
        {
            get { return widthHeightPoint; }
            set { widthHeightPoint = value; }
        }

        private Vector3 scale = new Vector3(1, 1, 1);
        public Vector3 Scale
        {
            get { return scale; }
            set { scale = value; }
        }

        private Vector3 rotateVector = new Vector3(1f, 0f, 0f);
        public Vector3 RotateVector
        {
            get { return RotateVector; }
            set { RotateVector = value; }
        }

        private float rotateAngle; //angle rotate need float value
        public float RotateAngle
        {
            get { return rotateAngle; }
            set { rotateAngle = value; }
        }

        private Vector3d translate = new Vector3d();
        public Vector3d Translate
        {
            get { return translate; }
            set { translate = value; }
        }       

        private int name;
        public int Name
        {
            get { return name; }
            set { name = value; }
        }

        private bool isSelected = false;
        public bool IsSelected
        {
            get { return isSelected; }
            set { isSelected = value; }
        }

        string shapeName;

        public string ShapeName
        {
            get { return shapeName; }
            set { shapeName = value; }
        }

        private Vector3d shapeMatrix;
        public Vector3d ShapeMatrix
        {
            get { return shapeMatrix; }
            set { shapeMatrix = value; }
        }
        public Shape()
        {            
        }

        public Shape(Shape shape)
        {
        }
        internal virtual void DrawSelf()
        {            
        }

        
    }
}
