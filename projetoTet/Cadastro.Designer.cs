namespace projetoTet
{
    partial class Cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            pictureBox1 = new PictureBox();
            listView1 = new ListView();
            label1 = new Label();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            textBox2 = new TextBox();
            pictureBox4 = new PictureBox();
            textBox3 = new TextBox();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(69, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(440, 654);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // listView1
            // 
            listView1.BackColor = Color.FromArgb(118, 75, 162);
            listView1.Location = new Point(421, 82);
            listView1.Name = "listView1";
            listView1.Size = new Size(742, 585);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(118, 75, 162);
            label1.Font = new Font("Segoe UI Semibold", 44.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(699, 129);
            label1.Name = "label1";
            label1.Size = new Size(270, 78);
            label1.TabIndex = 2;
            label1.Text = "Cadastro";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(596, 247);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(469, 35);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(118, 75, 162);
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(539, 243);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(118, 75, 162);
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(541, 312);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 44);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(596, 314);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(469, 35);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(118, 75, 162);
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(540, 383);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(39, 39);
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(596, 384);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(469, 35);
            textBox3.TabIndex = 9;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(118, 100, 162);
            button1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(715, 451);
            button1.Name = "button1";
            button1.Size = new Size(224, 45);
            button1.TabIndex = 10;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.FromArgb(118, 100, 162);
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.FromArgb(118, 100, 162);
            linkLabel1.DisabledLinkColor = Color.FromArgb(118, 100, 162);
            linkLabel1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(749, 572);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 32);
            linkLabel1.TabIndex = 12;
            linkLabel1.VisitedLinkColor = Color.FromArgb(118, 100, 162);
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1250, 736);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(pictureBox4);
            Controls.Add(textBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(listView1);
            Name = "Cadastro";
            Text = "Cadastro";
            Load += Cadastro_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ListView listView1;
        private Label label1;
        private TextBox textBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox textBox2;
        private PictureBox pictureBox4;
        private TextBox textBox3;
        private Button button1;
        private LinkLabel linkLabel1;
    }
}