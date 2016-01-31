using DrawOpenGL.Processors;
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
        private DislpayProcessor displayProcessor = new DislpayProcessor();
        
        public MainForm()
        {
            InitializeComponent();
        }



        private void glControl1_Load(object sender, EventArgs e)
        {
            GL.ClearColor(Color.SkyBlue);
            SetupViewport();
        }

            
        private void SetupViewport()
        {
            int w = glControl1.Width;
            int h = glControl1.Height;
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(0, w, 0, h, -1, 1); // Bottom-left corner pixel has coordinate (0, 0)
            GL.Viewport(0, 0, w, h); // Use all of the glControl painting area
        }



            int hits = 0;
        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            
            Draw();
            glControl1.SwapBuffers();

            toolStripLabel1.Text = 0.ToString();
        }
        private void Draw()
        {
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            GL.Color3(Color.Yellow);
            GL.InitNames();
            GL.PushName(1);

            GL.Begin(BeginMode.Triangles);
            GL.Vertex2(10, 20);
            GL.Vertex2(100, 20);
            GL.Vertex2(100, 50);            
            GL.End();

            GL.LoadName(2);
            GL.Begin(BeginMode.Triangles);
            GL.Vertex2(50, 60);
            GL.Vertex2(100, 60);
            GL.Vertex2(100, 90);
            GL.End();

            GL.LoadName(3);
            GL.Begin(BeginMode.Triangles);
            GL.Vertex2(400, 600);
            GL.Vertex2(200, 600);
            GL.Vertex2(200, 500);
            GL.End();
        }

        private void glControl1_Resize(object sender, EventArgs e)
        {
            SetupViewport();
        }



        
        private const int BUFSIZE = 1000;

            
        private void glControl1_MouseDown(object sender, MouseEventArgs e)
        {
            int[] selectBuffer = new int[BUFSIZE];              //This has to be redifined
            int[] viewport = new int[4];
            int w = glControl1.Width;
            int h = glControl1.Height;
            //toolStripLabel2.Text = e.X.ToString();

            if (e.Button == MouseButtons.Left)
            {
                

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
                Draw();
                GL.MatrixMode(MatrixMode.Projection);
                GL.PopMatrix();
                GL.MatrixMode(MatrixMode.Modelview);
                GL.Flush();
                hits = GL.RenderMode(RenderingMode.Render);
                
                ProcessHits(hits, selectBuffer);
        
            }
        }

        private void ProcessHits(int hits, int[] selectBuffer)
        {
            toolStripStatusLabel4.Text = "Избрани елементи: " + hits.ToString();
            toolStripStatusLabel2.Text = "Избран е примитив: " + selectBuffer[3].ToString();
        }
    }
}


