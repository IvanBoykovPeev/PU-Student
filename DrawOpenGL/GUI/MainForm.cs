using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK.Platform.Windows;
using OpenTK.Math;
using Tao.OpenGl;


namespace DrawOpenGL
{
    public partial class MainForm : Form
    {
        private DialogProcessor dialogProcessor = new DialogProcessor();
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
            GL.LoadIdentity();
            GL.Ortho(0, w, 0, h, -1, 1); // Bottom-left corner pixel has coordinate (0, 0)
            GL.Viewport(0, 0, w, h); // Use all of the glControl painting area
        }
        int hits = 0;
        int xf = 0;
        private void glControl2_Paint(object sender, PaintEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            
            dialogProcessor.Draw(xf);
            //glControl2.SwapBuffers();
            toolStripLabel1.Text = sender.ToString();
        }
        private void glControl1_Resize(object sender, EventArgs e)
        {
            SetupViewport();
        }
        
            const int BUFSIZE = 1000;
        private void glControl2_MouseDown(object sender, MouseEventArgs e)
        {
            int[] selectBuffer = new int[BUFSIZE];
            int[] viewport = new int[4];
            int w = glControl2.Width;
            int h = glControl2.Height;
            //toolStripLabel2.Text = e.X.ToString();

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
            //dialogProcessor.Draw(0);
            GL.MatrixMode(MatrixMode.Projection);
            GL.PopMatrix();
            GL.MatrixMode(MatrixMode.Modelview);
            GL.Flush();
            hits = GL.RenderMode(RenderingMode.Render);
            ProcessHits(hits, selectBuffer);
        }
        
        public void ProcessHits(int hits, int[] selectBuffer)
        {
            toolStripStatusLabel5.Text = "Избрани елементи: " + hits.ToString();
            toolStripStatusLabel6.Text = "Избран е примитив: " + selectBuffer[3].ToString();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            dialogProcessor.addTriangle();
        }
        
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            xf += 10;
            glControl2.Invalidate();
        }


    }
}


