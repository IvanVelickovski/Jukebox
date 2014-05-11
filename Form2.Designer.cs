namespace Jukebox
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnPrifati = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDodadi = new System.Windows.Forms.Button();
            this.lblIzveduvach = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIzveduvac = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "изведувач";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "песна";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnPrifati
            // 
            this.btnPrifati.Image = global::Jukebox.Properties.Resources.accept;
            this.btnPrifati.Location = new System.Drawing.Point(181, 143);
            this.btnPrifati.Name = "btnPrifati";
            this.btnPrifati.Size = new System.Drawing.Size(76, 31);
            this.btnPrifati.TabIndex = 9;
            this.btnPrifati.UseVisualStyleBackColor = true;
            this.btnPrifati.Click += new System.EventHandler(this.btnPrifati_Click_1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = global::Jukebox.Properties.Resources.top_bar;
            this.flowLayoutPanel1.Controls.Add(this.lblTitle);
            this.flowLayoutPanel1.Controls.Add(this.btnExit);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(330, 25);
            this.flowLayoutPanel1.TabIndex = 8;
            this.flowLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseDown);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 12F);
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(60, 4);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(60, 4, 25, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(207, 18);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Додадете песна во листата";
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseDown);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = global::Jukebox.Properties.Resources.close_main;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(302, 2);
            this.btnExit.Margin = new System.Windows.Forms.Padding(10, 2, 3, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnExit.MouseHover += new System.EventHandler(this.btnExit_MouseHover);
            // 
            // btnDodadi
            // 
            this.btnDodadi.BackColor = System.Drawing.Color.Transparent;
            this.btnDodadi.ForeColor = System.Drawing.Color.Transparent;
            this.btnDodadi.Image = global::Jukebox.Properties.Resources.select_song;
            this.btnDodadi.Location = new System.Drawing.Point(73, 143);
            this.btnDodadi.Name = "btnDodadi";
            this.btnDodadi.Size = new System.Drawing.Size(84, 31);
            this.btnDodadi.TabIndex = 6;
            this.btnDodadi.UseVisualStyleBackColor = false;
            this.btnDodadi.Click += new System.EventHandler(this.btnDodadi_Click);
            // 
            // lblIzveduvach
            // 
            this.lblIzveduvach.AutoSize = true;
            this.lblIzveduvach.Location = new System.Drawing.Point(60, 67);
            this.lblIzveduvach.Name = "lblIzveduvach";
            this.lblIzveduvach.Size = new System.Drawing.Size(61, 13);
            this.lblIzveduvach.TabIndex = 10;
            this.lblIzveduvach.Text = "Изведувач";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(228, 67);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(39, 13);
            this.lblIme.TabIndex = 11;
            this.lblIme.Text = "Песна";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(27, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 2);
            this.label3.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(181, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 2);
            this.label4.TabIndex = 13;
            // 
            // txtIzveduvac
            // 
            this.txtIzveduvac.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtIzveduvac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIzveduvac.ForeColor = System.Drawing.Color.Black;
            this.txtIzveduvac.Location = new System.Drawing.Point(27, 68);
            this.txtIzveduvac.Name = "txtIzveduvac";
            this.txtIzveduvac.Size = new System.Drawing.Size(130, 13);
            this.txtIzveduvac.TabIndex = 14;
            // 
            // txtIme
            // 
            this.txtIme.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtIme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIme.ForeColor = System.Drawing.Color.Black;
            this.txtIme.Location = new System.Drawing.Point(181, 68);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(130, 13);
            this.txtIme.TabIndex = 15;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 186);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.txtIzveduvac);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.lblIzveduvach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrifati);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDodadi);
            this.Name = "Form2";
            this.Text = "Информации за песна";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPrifati;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblIzveduvach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIzveduvac;
        private System.Windows.Forms.TextBox txtIme;
    }
}