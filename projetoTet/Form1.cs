using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace projetoTet
{
    public partial class Form1 : Form
    {
        // Cores do botão
        private Color normalColor = Color.MediumSlateBlue;
        private Color hoverColor = Color.MediumPurple;
        private Color clickColor = Color.Indigo;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            // Conecta evento ao carregar a tela
            this.Shown += Form1_Shown;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // opcional
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            // Estiliza botão
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.BackColor = normalColor;
            button1.ForeColor = Color.White;
            button1.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            button1.TabStop = false;

            // Aplica cantos arredondados
            button1.Region = new Region(GetRoundedRectPath(button1.ClientRectangle, 10));

            // Eventos de mouse
            button1.MouseEnter += Button1_MouseEnter;
            button1.MouseLeave += Button1_MouseLeave;
            button1.MouseDown += Button1_MouseDown;
            button1.MouseUp += Button1_MouseUp;
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

        // Criar forma arredondada para o botão
        private GraphicsPath GetRoundedRectPath(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();
            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
            path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }

        // Efeitos de mouse
        private void Button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = hoverColor;
        }

        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = normalColor;
        }

        private void Button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.BackColor = clickColor;
        }

        private void Button1_MouseUp(object sender, MouseEventArgs e)
        {
            // Volta para hover se o mouse ainda estiver sobre o botão
            if (button1.ClientRectangle.Contains(button1.PointToClient(Cursor.Position)))
            {
                button1.BackColor = hoverColor;
            }
            else
            {
                button1.BackColor = normalColor;
            }
        }

        // Eventos extras
        private void label1_Click(object sender, EventArgs e)
        {
            // opcional
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastro novoForm = new Cadastro();
            novoForm.Show();
            this.Hide(); // ou this.Close(); se quiser encerrar o formulário atual
        }

    }
}