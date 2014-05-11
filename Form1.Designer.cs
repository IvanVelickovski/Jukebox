namespace Jukebox
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button button4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPesna = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRokenrol = new System.Windows.Forms.Button();
            this.btnEvergreen = new System.Windows.Forms.Button();
            this.addSong = new System.Windows.Forms.Button();
            this.btnHipHop = new System.Windows.Forms.Button();
            this.btnPop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            button4 = new System.Windows.Forms.Button();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(0, 0);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(75, 23);
            button4.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.listBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("Arial", 12F);
            this.listBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(222, 89);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(279, 182);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            this.listBox1.Validating += new System.ComponentModel.CancelEventHandler(this.listBox1_Validating);
            this.listBox1.Validated += new System.EventHandler(this.listBox1_Validated);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 25);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 29);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(84, 25);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 29);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(54, 46);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(30, 50, 0, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(251, 13);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 8;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::Jukebox.Properties.Resources.ivan;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(38, 20);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 40);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "frame.png");
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 193);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(44, 15);
            this.checkedListBox1.TabIndex = 2;
            this.checkedListBox1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(27, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Жанр";
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.LightGray;
            this.flowLayoutPanel2.BackgroundImage = global::Jukebox.Properties.Resources.downFrame;
            this.flowLayoutPanel2.Controls.Add(this.button1);
            this.flowLayoutPanel2.Controls.Add(this.button3);
            this.flowLayoutPanel2.Controls.Add(this.button2);
            this.flowLayoutPanel2.Controls.Add(this.panel1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1, 318);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(532, 75);
            this.flowLayoutPanel2.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblPesna);
            this.panel1.Controls.Add(this.lblArtist);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Location = new System.Drawing.Point(171, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(55, 3, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 72);
            this.panel1.TabIndex = 10;
            // 
            // lblPesna
            // 
            this.lblPesna.AutoSize = true;
            this.lblPesna.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblPesna.Location = new System.Drawing.Point(53, 28);
            this.lblPesna.Name = "lblPesna";
            this.lblPesna.Size = new System.Drawing.Size(44, 15);
            this.lblPesna.TabIndex = 15;
            this.lblPesna.Text = "Песна";
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Font = new System.Drawing.Font("Arial", 11F);
            this.lblArtist.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblArtist.Location = new System.Drawing.Point(53, 6);
            this.lblArtist.Margin = new System.Windows.Forms.Padding(0);
            this.lblArtist.MaximumSize = new System.Drawing.Size(0, 20);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(48, 17);
            this.lblArtist.TabIndex = 14;
            this.lblArtist.Text = "Автор";
            this.lblArtist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblArtist.Click += new System.EventHandler(this.lblArtist_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = global::Jukebox.Properties.Resources.frame;
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.btnMinimize);
            this.flowLayoutPanel1.Controls.Add(this.btnClose);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(562, 25);
            this.flowLayoutPanel1.TabIndex = 20;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            this.flowLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseDown_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(15, 4);
            this.label5.Margin = new System.Windows.Forms.Padding(15, 4, 3, 3);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Jukebox";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label5_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Image = global::Jukebox.Properties.Resources.minimize_main;
            this.btnMinimize.Location = new System.Drawing.Point(484, 8);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(400, 8, 0, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(22, 18);
            this.btnMinimize.TabIndex = 21;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.button4_Click_2);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.btnMinimize_MouseLeave);
            this.btnMinimize.MouseHover += new System.EventHandler(this.btnMinimize_MouseHover);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = global::Jukebox.Properties.Resources.close_main;
            this.btnClose.Location = new System.Drawing.Point(506, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // btnRokenrol
            // 
            this.btnRokenrol.BackColor = System.Drawing.Color.Transparent;
            this.btnRokenrol.FlatAppearance.BorderSize = 0;
            this.btnRokenrol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRokenrol.ForeColor = System.Drawing.Color.Transparent;
            this.btnRokenrol.Image = global::Jukebox.Properties.Resources.rokenrol_normal;
            this.btnRokenrol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRokenrol.Location = new System.Drawing.Point(27, 136);
            this.btnRokenrol.Name = "btnRokenrol";
            this.btnRokenrol.Size = new System.Drawing.Size(87, 23);
            this.btnRokenrol.TabIndex = 18;
            this.btnRokenrol.UseVisualStyleBackColor = false;
            this.btnRokenrol.Click += new System.EventHandler(this.btnRokenrol_Click);
            this.btnRokenrol.MouseLeave += new System.EventHandler(this.btnRokenrol_MouseLeave);
            this.btnRokenrol.MouseHover += new System.EventHandler(this.btnRokenrol_MouseHover);
            // 
            // btnEvergreen
            // 
            this.btnEvergreen.BackColor = System.Drawing.Color.Transparent;
            this.btnEvergreen.FlatAppearance.BorderSize = 0;
            this.btnEvergreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvergreen.ForeColor = System.Drawing.Color.Transparent;
            this.btnEvergreen.Image = global::Jukebox.Properties.Resources.evergreen_normal;
            this.btnEvergreen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvergreen.Location = new System.Drawing.Point(27, 164);
            this.btnEvergreen.Name = "btnEvergreen";
            this.btnEvergreen.Size = new System.Drawing.Size(87, 23);
            this.btnEvergreen.TabIndex = 17;
            this.btnEvergreen.UseVisualStyleBackColor = false;
            this.btnEvergreen.Click += new System.EventHandler(this.btnEvergreen_Click);
            this.btnEvergreen.MouseLeave += new System.EventHandler(this.btnEvergreen_MouseLeave);
            this.btnEvergreen.MouseHover += new System.EventHandler(this.btnEvergreen_MouseHover);
            // 
            // addSong
            // 
            this.addSong.BackColor = System.Drawing.Color.Transparent;
            this.addSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addSong.ForeColor = System.Drawing.Color.Transparent;
            this.addSong.Image = global::Jukebox.Properties.Resources.addsong_normal;
            this.addSong.Location = new System.Drawing.Point(221, 48);
            this.addSong.Name = "addSong";
            this.addSong.Size = new System.Drawing.Size(128, 24);
            this.addSong.TabIndex = 10;
            this.addSong.UseVisualStyleBackColor = false;
            this.addSong.Click += new System.EventHandler(this.addSong_Click);
            this.addSong.MouseLeave += new System.EventHandler(this.addSong_MouseLeave);
            this.addSong.MouseHover += new System.EventHandler(this.addSong_MouseHover);
            // 
            // btnHipHop
            // 
            this.btnHipHop.BackColor = System.Drawing.Color.Transparent;
            this.btnHipHop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHipHop.FlatAppearance.BorderSize = 0;
            this.btnHipHop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHipHop.ForeColor = System.Drawing.Color.Transparent;
            this.btnHipHop.Image = global::Jukebox.Properties.Resources.hiphop_normal;
            this.btnHipHop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHipHop.Location = new System.Drawing.Point(27, 108);
            this.btnHipHop.Name = "btnHipHop";
            this.btnHipHop.Size = new System.Drawing.Size(87, 23);
            this.btnHipHop.TabIndex = 16;
            this.btnHipHop.UseVisualStyleBackColor = false;
            this.btnHipHop.Click += new System.EventHandler(this.btnHipHop_Click);
            this.btnHipHop.MouseLeave += new System.EventHandler(this.btnHipHop_MouseLeave);
            this.btnHipHop.MouseHover += new System.EventHandler(this.btnHipHop_MouseHover);
            // 
            // btnPop
            // 
            this.btnPop.BackColor = System.Drawing.Color.Transparent;
            this.btnPop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPop.FlatAppearance.BorderSize = 0;
            this.btnPop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPop.ForeColor = System.Drawing.Color.Transparent;
            this.btnPop.Image = global::Jukebox.Properties.Resources.pop_hover;
            this.btnPop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPop.Location = new System.Drawing.Point(27, 80);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(87, 23);
            this.btnPop.TabIndex = 23;
            this.btnPop.UseVisualStyleBackColor = false;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            this.btnPop.MouseLeave += new System.EventHandler(this.btnPop_MouseLeave);
            this.btnPop.MouseHover += new System.EventHandler(this.btnPop_MouseHover);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(158, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 220);
            this.label2.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 46);
            this.label6.Margin = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "-00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Jukebox.Properties.Resources.bg_color;
            this.ClientSize = new System.Drawing.Size(535, 394);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPop);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.btnRokenrol);
            this.Controls.Add(this.btnEvergreen);
            this.Controls.Add(this.addSong);
            this.Controls.Add(this.btnHipHop);
            this.Controls.Add(button4);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Jukebox";
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button addSong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnHipHop;
        private System.Windows.Forms.Button btnEvergreen;
        private System.Windows.Forms.Button btnRokenrol;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnPop;
        public System.Windows.Forms.Label lblArtist;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblPesna;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}

