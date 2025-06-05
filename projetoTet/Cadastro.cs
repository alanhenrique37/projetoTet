using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoTet
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            ArredondarPictureBox(pictureBox1, 30); // raio 20, ajuste se quiser
            ArredondarListView(listView1, 30); // raio 20, ajuste se quiser
        }
        // Gradiente no fundo da janela
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            Rectangle rect = this.ClientRectangle;

            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect,
                Color.White,
                Color.FromArgb(223, 200, 255),
                LinearGradientMode.Vertical))
            {
                g.FillRectangle(brush, rect);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void ArredondarPictureBox(PictureBox pb, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(pb.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(pb.Width - raio, pb.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, pb.Height - raio, raio, raio, 90, 90);
            path.CloseFigure();
            pb.Region = new Region(path);
        }
        private void ArredondarListView(ListView lv, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(lv.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(lv.Width - raio, lv.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, lv.Height - raio, raio, raio, 90, 90);
            path.CloseFigure();
            lv.Region = new Region(path);
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

