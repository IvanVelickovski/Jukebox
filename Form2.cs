using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NAudio;
using NAudio.WindowsMediaFormat;
using NAudio.Wave;
using System.Diagnostics;

namespace Jukebox
{
    public partial class Form2 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
        int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        Song pesna;
        AudioFileReader audioFileReader;
        Form1 Form1;

        public Form2(Form1 form1)
        {
            Form1 = form1;
            InitializeComponent();
            btnDodadi.FlatStyle = FlatStyle.Flat;
            btnDodadi.FlatAppearance.BorderSize = 0;
            btnDodadi.FlatAppearance.MouseOverBackColor = btnDodadi.BackColor;
            btnPrifati.FlatStyle = FlatStyle.Flat;
            btnPrifati.FlatAppearance.BorderSize = 0;
            btnPrifati.FlatAppearance.MouseOverBackColor = btnPrifati.BackColor;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseOverBackColor = btnExit.BackColor;
            FormBorderStyle = FormBorderStyle.None;
            lblIzveduvach.Visible = false;
            lblIme.Visible = false;
        }

        private void btnDodadi_Click(object sender, EventArgs e)
        {
            mnuFileOpen_Click(sender, e);
        }

        private void btnPrifati_Click(object sender, EventArgs e)
        {
            OpenFile(audioFileReader.ToString());
            this.Close();
        }

        String artist = "";
        String song = "";
        OpenFileDialog openDlg = null;

        private void mnuFileOpen_Click(object sender, System.EventArgs e)
        {
            // Show Open File dialog
            openDlg = new OpenFileDialog();
            openDlg.Filter  = "MP3 files (*.mp3)|*.mp3";

            //openDlg.FileName = "" ;
            openDlg.CheckFileExists = true;
            openDlg.CheckPathExists = true;

            if (openDlg.ShowDialog() != DialogResult.OK)
                return;

            audioFileReader = new AudioFileReader(openDlg.FileName.ToString());

            String pom = openDlg.FileName.ToString();
            String[] pole = pom.Split('\\'); // se zema patekata do fajlot

            // ime na artist
            String linkArtist = pole[pole.Length-1];
            for (int i = 0; i < pole.Length; i++)
                System.Diagnostics.Debug.WriteLine(pole[i].ToString());

            String[] pomArtist = linkArtist.Split('-');

            if (pomArtist.Length >= 2)
            {
                artist = pomArtist[0];
                lblIzveduvach.Text = artist;
                txtIzveduvac.Text = lblIzveduvach.Text;
            }
            else if(pomArtist.Length==1)
            {
                artist = pomArtist[0].Split('.')[0];
                lblIzveduvach.Text = artist;
                txtIzveduvac.Text = lblIzveduvach.Text;
            }
            else
            {
                lblIzveduvach.Text = artist;
                txtIzveduvac.Text = lblIzveduvach.Text;
            }

            // ime na pesna
            String linkPesna = pole[pole.Length - 1];
            String[] pomPesna = linkPesna.Split('-');


            if (pomPesna.Length >= 2)
            {
                String[] song1 = pomPesna[1].Split('.');
                song = song1[0];
                lblIme.Text = song.Trim();
                txtIme.Text = lblIme.Text.Trim();
            }
            else
            {
                String[] song1 = pomPesna[0].Split('.');
                lblIme.Text = song.Trim();
                txtIme.Text = lblIme.Text.Trim();
            }
        }

        private Bitmap m_Bitmap;

        private void OpenFile(string sFile)
        {
            Bitmap bmp;

            try
            {
                if (audioFileReader != null)
                {
                    Invalidate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    this,
                    ex.Message,
                    "Error loading from file");
            }
        }

        private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            if (m_Bitmap != null)
            {
                e.Graphics.DrawImage(
                    m_Bitmap,
                    new Rectangle(this.AutoScrollPosition.X,
                    this.AutoScrollPosition.Y,
                    m_Bitmap.Width,
                    m_Bitmap.Height));
            }
        }

        private void Form1_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private delegate void DelegateOpenFile(String s);           // type
        private DelegateOpenFile m_DelegateOpenFile;                // instance

        private void Form1_Load(object sender, System.EventArgs e)
        {
            // create delegate used for asynchronous call
            m_DelegateOpenFile = new DelegateOpenFile(this.OpenFile);
        }


        private void Form1_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            try
            {
                Array a = (Array)e.Data.GetData(DataFormats.FileDrop);

                if (a != null)
                {
                    // Extract string from first array element
                    // (ignore all files except first if number of files are dropped).
                    string s = a.GetValue(0).ToString();

                    // Call OpenFile asynchronously.
                    // Explorer instance from which file is dropped is not responding
                    // all the time when DragDrop handler is active, so we need to return
                    // immidiately (especially if OpenFile shows MessageBox).

                    this.BeginInvoke(m_DelegateOpenFile, new Object[] { s });

                    this.Activate();        // in the case Explorer overlaps this form
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Error in DragDrop function: " + ex.Message);

                // don't show MessageBox here - Explorer is waiting !
            }
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (lblIme.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(lblIme, "Внесете име на песната");
            }
            else
            {
                errorProvider1.SetError(lblIme, "");
            }

        }

        private void txtIzveduvac_Validating(object sender, CancelEventArgs e)
        {
            if (lblIzveduvach.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(lblIzveduvach, "Внесете име на изведувачот");
            }
            else
            {
                errorProvider1.SetError(lblIzveduvach, "");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            btnExit.Image = ((System.Drawing.Image)(Properties.Resources.close_hover));
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.Image = ((System.Drawing.Image)(Properties.Resources.close_main));
        }

        private void btnPrifati_Click_1(object sender, EventArgs e)
        {
            if (audioFileReader != null)
            {
                if (txtIme.Text == "")
                {
                    errorProvider1.SetError(txtIme, "Мора да се внесе име на песна!");
                }
                else if (txtIzveduvac.Text == "")
                {
                    errorProvider1.SetError(txtIzveduvac, "Мора да се внесе изведувач!");
                }
                else
                {
                    //dodavanje na pesna vo listite 
                    pesna = new Song(txtIme.Text, txtIzveduvac.Text, openDlg.FileName.ToString());
                    if (Form1.popBool)
                        Form1.listPop.Add(pesna);

                    else if (Form1.rokBool)
                        Form1.listRok.Add(pesna);

                    else if (Form1.hipHopBool)
                        Form1.listRap.Add(pesna);

                    else
                        Form1.listMak.Add(pesna);

                    if (Form1.popBool)
                    {
                        Form1.listBox1.Items.Clear();
                        for (int i = 0; i < Form1.listPop.Count; i++)
                        {
                            Form1.listBox1.Items.Add(Form1.listPop.ElementAt(i));
                        }
                    }
                    else if (Form1.hipHopBool)
                    {
                        Form1.listBox1.Items.Clear();
                        for (int i = 0; i < Form1.listRap.Count; i++)
                        {
                            Form1.listBox1.Items.Add(Form1.listRap.ElementAt(i));
                        }
                    }
                    else if (Form1.rokBool)
                    {
                        Form1.listBox1.Items.Clear();
                        for (int i = 0; i < Form1.listRok.Count; i++)
                        {
                            Form1.listBox1.Items.Add(Form1.listRok.ElementAt(i));
                        }
                    }
                    else if (Form1.evergrinBool)
                    {
                        Form1.listBox1.Items.Clear();
                        for (int i = 0; i < Form1.listMak.Count; i++)
                        {
                            Form1.listBox1.Items.Add(Form1.listMak.ElementAt(i));
                        }
                    }

                    OpenFile(audioFileReader.ToString());
                    this.Close();
                }
            }
            else
            {
                errorProvider1.SetError(btnDodadi, "Мора да се внесе MP3 датотека!");
            }
        }
    }
}
