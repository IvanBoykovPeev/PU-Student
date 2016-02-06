using OpenTK.Graphics.OpenGL;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Tao.OpenGl;


namespace DrawOpenGL
{
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
            GL.LoadIdentity();
            GL.Ortho(0, w, 0, h, -1, 1); // Bottom-left corner pixel has coordinate (0, 0)
            GL.Viewport(0, 0, w, h); // Use all of the glControl painting area
        }


        float[] translateMatrix2 = { 100.0f, 100.0f};
        private void glControl2_Paint(object sender, PaintEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            
            dialogProcessor.ReDraw();
            glControl2.SwapBuffers();
            //OpenTK.Graphics.GraphicsContext.CurrentContext.SwapBuffers(); // SwapBuffers enywhere in application
        }
        private void glControl2_Resize(object sender, EventArgs e)
        {
            SetupViewport();
        }

        int hits;
        const int BUFSIZE = 1000;
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
        }

        public void ProcessHits(int hits, int[] selectBuffer)
        {
            toolStripStatusLabel2.Text = "Избрани елементи: " + hits.ToString();
            toolStripStatusLabel3.Text = "Избран е примитив: " + selectBuffer[3].ToString();
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
                
            }
            glControl2.Invalidate();
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
        }
    }
}


