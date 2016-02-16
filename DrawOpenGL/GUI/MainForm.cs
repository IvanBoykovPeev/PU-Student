using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Tao.OpenGl;


namespace DrawOpenGL
{
    /// <summary>
    /// autor Ivan Boykov Peev
    /// Bulgaria Plovdiv
    /// Colege PU "Paisi Hilendarski"
    /// For Computer Crafics Project
    /// </summary>
    public partial class MainForm : Form
    {
        private DialogProcessor dialogProcessor = new DialogProcessor();
        private StringBuilder debugInfoString = new StringBuilder();
        int selectedShepe;
        public MainForm()
        {
            InitializeComponent();
        }
        private void glControl2_Load(object sender, EventArgs e)
        {
            GL.ClearColor(Color.SkyBlue);
            SetupViewport();
        }
        private void SetupViewport()
        {
            int w = glControl2.Width;
            int h = glControl2.Height;
            GL.MatrixMode(MatrixMode.Projection);
            GL.Enable(EnableCap.LineStipple);
            GL.LoadIdentity();
            GL.Ortho(0, w, h, 0, -1, 1); // Bottom-left corner pixel has coordinate (0, 0)
            GL.Viewport(0, 0, w, h); // Use all of the glControl painting area

        }
        private void glControl2_Paint(object sender, PaintEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit); //Clear buffers
            dialogProcessor.ReDraw();  //Redraw Display fail
            glControl2.SwapBuffers();  //Swap buffers
            //OpenTK.Graphics.GraphicsContext.CurrentContext.SwapBuffers(); // SwapBuffers enywhere in application
        }
        private void glControl2_Resize(object sender, EventArgs e)
        {
            SetupViewport();
        }

        int hits; //hits for selected element
        const int BUFSIZE = 1000;
        private string shortkeys = "Alt+F4 - Close the program";
        private void glControl2_MouseDown(object sender, MouseEventArgs e)
        {
            if (toolStripButton2.Checked)
            {
                //dialogProcessor.Select(0);
                toolStripStatusLabel3.Text = "Вкючена селекция";
                int[] selectBuffer = new int[BUFSIZE];
                int[] viewport = new int[4];
                int w = glControl2.Width;
                int h = glControl2.Height;
                if (e.Button == MouseButtons.Left)
                    GL.GetInteger(GetPName.Viewport, viewport);
                GL.SelectBuffer(BUFSIZE, selectBuffer);
                GL.RenderMode(RenderingMode.Select);
                GL.MatrixMode(MatrixMode.Projection);
                GL.PushMatrix();
                GL.LoadIdentity();
                Glu.gluPickMatrix((double)e.X, (double)(viewport[3] - e.Y), 5.0, 5.0, viewport);
                GL.Ortho(0, w, h, 0, -1, 1);
                //GL.Viewport(e.X, e.Y, e.X + 1, e.Y + 1); // Use all of the glControl painting area
                //SetupViewport();
                GL.MatrixMode(MatrixMode.Modelview);
                dialogProcessor.ReDraw();
                GL.MatrixMode(MatrixMode.Projection);
                GL.PopMatrix();
                GL.MatrixMode(MatrixMode.Modelview);
                GL.Flush();
                hits = GL.RenderMode(RenderingMode.Render);
                ProcessHits(hits, selectBuffer);
                if (hits == 0)
                {
                    toolStripStatusLabel2.Text = "Не е избран елемент";
                }
                dialogProcessor.Select(selectedShepe);
            }
            glControl2.Invalidate();
        }

        public void ProcessHits(int hits, int[] selectBuffer)
        {
            toolStripStatusLabel2.Text = "Избрани елементи: " + hits.ToString();
            toolStripStatusLabel3.Text = "Избран елемент: " + selectBuffer[3].ToString();

            selectedShepe = selectBuffer[3];

        }

        private void glControl2_MouseUp(object sender, MouseEventArgs e)
        {

            toolStripStatusLabel1.Text = "Позиция на мишката x= " + e.X + " y= " + e.Y;
            glControl2.Invalidate();

        }

        private void DebugInfotoolStripButton3_Click(object sender, EventArgs e)
        {
            DebugInfo();
        }



        private void debugInfoStringClear_Click(object sender, EventArgs e)
        {
            debugInfoString.Clear();
            debug.Text = debugInfoString.ToString();
            glControl2.Invalidate();
        }

        private void CloseButton6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addPointButton1_Click(object sender, EventArgs e)
        {
            if (!toolStripButton2.Checked)
            {

                dialogProcessor.addPoint();
                toolStripStatusLabel2.Text = "Добавена нова точка";
                glControl2.Invalidate();
            }
        }

        private void TranslateButton_Click(object sender, EventArgs e)
        {
            if (!toolStripButton2.Checked)
            {
                dialogProcessor.Translate(selectedShepe);
                //dialogProcessor.RemoveMarcer();
                toolStripStatusLabel2.Text = "Транслация";
                glControl2.Invalidate();
            }
        }
        /// <summary>
        /// Rotate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RotateButton_Click(object sender, EventArgs e)
        {
            if (!toolStripButton2.Checked)
            {
                dialogProcessor.Rotate(selectedShepe);
                toolStripStatusLabel2.Text = "Ротация";
                glControl2.Invalidate();
            }
        }
        /// <summary>
        /// Прерисуване
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReloadButton8_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Reload";
            dialogProcessor.ReDraw();
        }
        /// <summary>
        /// Натиснат бутон на мишката
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void glControl2_KeyDown(object sender, KeyEventArgs e)
        {
            debugInfoString.Clear();
            debug.Text = debugInfoString.ToString();
            glControl2.Invalidate();

            if (e.KeyCode == Keys.Z)
            {
                DebugInfo();
            }
            if (e.KeyCode == (Keys.Alt))
            {
                if (e.KeyCode == Keys.F4)
                {
                    Close();
                }
            }
        }
        /// <summary>
        /// Shortkeys description
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void shortKeysToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(Resources.Resource1.Shortkeys);
        }
        /// <summary>
        /// Мащабиране
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScaleButton_Click(object sender, EventArgs e)
        {
            if (!toolStripButton2.Checked)
            {
                dialogProcessor.Scale(selectedShepe);
                toolStripStatusLabel2.Text = "Мащабиране";
                glControl2.Invalidate();
            }
        }
        /// <summary>
        /// Изтрива елемент
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!toolStripButton2.Checked)
            {
                dialogProcessor.SelectedCut(selectedShepe);
                toolStripStatusLabel2.Text = "Мащабиране";
                glControl2.Invalidate();
            }
        }
        /// <summary>
        /// Добавя правоъгълник
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void аddRectangleButton11_Click(object sender, EventArgs e)
        {
            if (!toolStripButton2.Checked)
            {
                dialogProcessor.AddRectangle();
                glControl2.Invalidate();
            }
        }
        /// <summary>
        /// Селекция на елемент
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectionButton2_Click(object sender, EventArgs e)
        {
            if (!toolStripButton2.Checked)
            {
                dialogProcessor.RemoveMarcer();
                toolStripStatusLabel2.Text = "Изкючена селекция";
                toolStripStatusLabel3.Text = "Избран елемент: " + selectedShepe.ToString();
                glControl2.Invalidate();
            }
            if (toolStripButton2.Checked)
            {
                dialogProcessor.RemoveMarcer();
                dialogProcessor.Select(selectedShepe);
                toolStripStatusLabel2.Text = "Вкючена селекция";
                glControl2.Invalidate();
            }
        }
        /// <summary>
        /// Генериране на ново изображение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewImageButton5_Click(object sender, EventArgs e)
        {
            dialogProcessor.NewImage();
            glControl2.Invalidate();
        }
        /// <summary>
        /// Дебъг информация
        /// </summary>
        private void DebugInfo()
        {
            debugInfoString.Append("\n");
            foreach (var item in dialogProcessor.ShapeList)
            {
                debugInfoString.Append("Name " + item.Name.ToString());
                debugInfoString.Append("\n");
                debugInfoString.Append("X " + item.X.ToString());
                debugInfoString.Append("\n");
                debugInfoString.Append("Y " + item.Y.ToString());
                debugInfoString.Append("\n");
                debugInfoString.Append("Is selected " + item.IsSelected.ToString());
                debugInfoString.Append("\n");
                debugInfoString.Append("Translate " + item.Translate.ToString());
                debugInfoString.Append("\n");
                debugInfoString.Append("Roteted " + item.RotateAngle.ToString());
                debugInfoString.Append("\n");
                debugInfoString.Append("ShapeName " + item.ShapeName.ToString());
                debugInfoString.Append("\n");
                debugInfoString.Append("ShapeMatrix " + item.ShapeMatrix.ToString());
                debugInfoString.Append("\n");


            }
            debugInfoString.Append("ShapeList.Count " + dialogProcessor.ShapeList.Count.ToString());
            debugInfoString.Append("\n");
            debugInfoString.Append("selectedShape:");
            debugInfoString.Append("\n");
            debugInfoString.Append("----------------------------------------------");
            debug.Text = debugInfoString.ToString();
            glControl2.Invalidate();
        }
        /// <summary>
        /// Изтрива дебъг информацията
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void debugInfoClearButton4_Click(object sender, EventArgs e)
        {
            debugInfoString.Clear();
            debug.Text = debugInfoString.ToString();
        }

        

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!toolStripButton2.Checked)
            {

                dialogProcessor.CopyShape(selectedShepe);
            toolStripStatusLabel2.Text = "Копиране";
            glControl2.Invalidate();
            }
        }

    }
}


