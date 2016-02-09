﻿using OpenTK.Graphics.OpenGL;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Tao.OpenGl;


namespace DrawOpenGL
{
    /// <summary>
    /// autor Ivan Boykov Peev
    /// </summary>
    public partial class MainForm : Form
    {
        private DialogProcessor dialogProcessor = new DialogProcessor();
        private StringBuilder debugInfoString = new StringBuilder();
        public int selectedElement;
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
            GL.Ortho(0, w, 0, h, -1, 1); // Bottom-left corner pixel has coordinate (0, 0)
            GL.Viewport(0, 0, w, h); // Use all of the glControl painting area
            
        }
        
        private void glControl2_Paint(object sender, PaintEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            
            dialogProcessor.ReDraw();
            glControl2.SwapBuffers();

            toolStripStatusLabel3.Text = "Избран е примитив: " + selectedElement.ToString();
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
            GL.Ortho(0, w, 0, h, -1, 1);
            //GL.Viewport(e.X, e.Y, e.X + 1, e.Y + 1); // Use all of the glControl painting area
            GL.MatrixMode(MatrixMode.Modelview);
            dialogProcessor.ReDraw();
            GL.MatrixMode(MatrixMode.Projection);
            GL.PopMatrix();
            GL.MatrixMode(MatrixMode.Modelview);
            GL.Flush();
            hits = GL.RenderMode(RenderingMode.Render);
            ProcessHits(hits, selectBuffer);
            if (selectedElement == 0)
            {
                toolStripStatusLabel2.Text = "Не е избран елемент";
            }
            //toolStripStatusLabel1.Text = "Mause positin: x=" + e.X + " y=" + e.Y;

        }
            
        public void ProcessHits(int hits, int[] selectBuffer)
        {
            toolStripStatusLabel2.Text = "Избрани елементи: " + hits.ToString();
            selectedElement = selectBuffer[3];
        }       

        private void glControl2_MouseUp(object sender, MouseEventArgs e)
        {
            foreach (var item in dialogProcessor.ShapeList)
            {

                if (item.Name == selectedElement)
                {
                    item.IsSelected = true;

                }
               
                else
                {
                    item.IsSelected = false;
                    
                }
                
                
                toolStripStatusLabel1.Text = "x=" + e.X + " y=" + e.Y;
                glControl2.Invalidate();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DebugInfo();            
        }

        private void DebugInfo()
        {
            foreach (var item in dialogProcessor.ShapeList)
            {
                debugInfoString.Append(item.Name.ToString());
                debugInfoString.Append("\n");
                debugInfoString.Append(item.IsSelected.ToString());
                debugInfoString.Append("\n");
                debugInfoString.Append(item.Translate.ToString());
                debugInfoString.Append("\n");
                debugInfoString.Append(item.Rotate.ToString());
                debugInfoString.Append("\n");
            }
            debugInfoString.Append("\n");
            debug.Text = debugInfoString.ToString();
            glControl2.Invalidate();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            debugInfoString.Clear();
            debug.Text = debugInfoString.ToString();
            glControl2.Invalidate();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            dialogProcessor.addPoint();
            toolStripStatusLabel2.Text = "Добавена нова точка";
            glControl2.Invalidate();
        }        
        
        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            dialogProcessor.Translate(selectedElement);
            glControl2.Invalidate();
        }
        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Reload";
            dialogProcessor.ReDraw();
        }

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
        private void shortkeysToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(Resources.Resource1.Shortkeys);
        }
        /// <summary>
        /// Rotate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            dialogProcessor.Rotate(selectedElement);
            glControl2.Invalidate();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            dialogProcessor.Scale(selectedElement);
            glControl2.Invalidate();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}


