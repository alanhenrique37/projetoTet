using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace projetoTet
{
    public partial class Cadastro : Form
    {
        private Label placeholderLabel1 = null!;
        private Label placeholderLabel2 = null!;
        private Label placeholderLabel3 = null!;

        // Cores do botão iguais ao Form1
        private Color normalColor = Color.MediumSlateBlue;
        private Color hoverColor = Color.MediumPurple;
        private Color clickColor = Color.Indigo;

        public Cadastro()
        {
            InitializeComponent();

            textBox1.Enter += textBox_Enter;
            textBox1.Leave += textBox_Leave;
            textBox1.TextChanged += textBox_TextChanged;

            textBox2.Enter += textBox_Enter;
            textBox2.Leave += textBox_Leave;
            textBox2.TextChanged += textBox_TextChanged;

            textBox3.Enter += textBox_Enter;
            textBox3.Leave += textBox_Leave;
            textBox3.TextChanged += textBox_TextChanged;

            // Configuração do botão igual ao Form1
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.BackColor = normalColor;
            button1.ForeColor = Color.White;
            button1.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            button1.TabStop = false;

            button1.Region = new Region(GetRoundedRectPath(button1.ClientRectangle, 10));

            button1.MouseEnter += Button1_MouseEnter;
            button1.MouseLeave += Button1_MouseLeave;
            button1.MouseDown += Button1_MouseDown;
            button1.MouseUp += Button1_MouseUp;
            button1.Resize += Button1_Resize;
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            ArredondarPictureBox(pictureBox1, 30);
            ArredondarListView(listView1, 30);

            textBox1.Multiline = true;
            textBox1.Height = 40;
            textBox2.Multiline = true;
            textBox2.Height = 40;
            textBox3.Multiline = true;
            textBox3.Height = 40;

            ArredondarTextBox(textBox1, 20);
            ArredondarTextBox(textBox2, 20);
            ArredondarTextBox(textBox3, 20);

            CriarPlaceholderCustomizado();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }

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

        private void ArredondarTextBox(TextBox tb, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(tb.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(tb.Width - raio, tb.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, tb.Height - raio, raio, raio, 90, 90);
            path.CloseFigure();
            tb.Region = new Region(path);
        }

        private void CriarPlaceholderCustomizado()
        {
            placeholderLabel1 = CriarLabelPlaceholder(textBox1, "Digite seu nome");
            placeholderLabel2 = CriarLabelPlaceholder(textBox2, "Digite seu email");
            placeholderLabel3 = CriarLabelPlaceholder(textBox3, "Digite sua senha");

            AtualizarPlaceholders();
        }

        private Label CriarLabelPlaceholder(TextBox textBox, string texto)
        {
            Label label = new Label
            {
                Text = texto,
                ForeColor = Color.Gray,
                Font = new Font(textBox.Font.FontFamily, 9, FontStyle.Italic),
                BackColor = Color.Transparent,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleLeft
            };

            label.SetBounds(5, 3, textBox.Width - 10, textBox.Height - 6);
            label.Click += (s, e) => { textBox.Focus(); };
            textBox.Controls.Add(label);
            label.BringToFront();

            return label;
        }

        private void AtualizarPlaceholders()
        {
            placeholderLabel1.Visible = string.IsNullOrWhiteSpace(textBox1.Text) && !textBox1.Focused;
            placeholderLabel2.Visible = string.IsNullOrWhiteSpace(textBox2.Text) && !textBox2.Focused;
            placeholderLabel3.Visible = string.IsNullOrWhiteSpace(textBox3.Text) && !textBox3.Focused;
        }

        private void textBox_Enter(object sender, EventArgs e) => AtualizarPlaceholders();
        private void textBox_Leave(object sender, EventArgs e) => AtualizarPlaceholders();
        private void textBox_TextChanged(object sender, EventArgs e) => AtualizarPlaceholders();

        // Botão arredondado com hover igual ao Form1

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
            if (button1.ClientRectangle.Contains(button1.PointToClient(Cursor.Position)))
            {
                button1.BackColor = hoverColor;
            }
            else
            {
                button1.BackColor = normalColor;
            }
        }

        private void Button1_Resize(object sender, EventArgs e)
        {
            button1.Region = new Region(GetRoundedRectPath(button1.ClientRectangle, 10));
        }

        // Outros eventos opcionais
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
