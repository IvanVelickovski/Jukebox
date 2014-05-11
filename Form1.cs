using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using NAudio;
using NAudio.WindowsMediaFormat;
using NAudio.Wave;
using Jukebox.Properties;

namespace Jukebox
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
        int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public Zanr pop;
        public int minuti;
        public int sekundi;
        public int blago = 1;
        public Zanr rap;
        public Zanr makedonski;
        public Zanr rok;
        public List<Song> listPop = new List<Song>();
        public List<Song> listRok = new List<Song>();
        public List<Song> listRap = new List<Song>();
        public List<Song> listMak = new List<Song>();
        public int Flage = 0;
        public bool pause = false;
        public int[] chosenGenre;
        public bool Lock = true;
        public bool popBool = true;
        public bool hipHopBool = false;
        public bool rokBool = false;
        public bool evergrinBool = false;
        public bool nextOrPrev = false;
        String str = null;
        int idx;

        public Form1()
        {
            InitializeComponent();

            //dodavanje pesni vo rap zhanr
            string fileName = Path.Combine(Application.StartupPath, "Resources", "TheNextEpisode.mp3");
            Song song = new Song("The Next Episode", "Dr. Dre ft Snoop Dogg", fileName);
            listRap.Add(song);
            fileName = Path.Combine(Application.StartupPath, "Resources", "2Pac.mp3");
            song = new Song("California Love", "2Pac", fileName);
            listRap.Add(song);
            fileName = Path.Combine(Application.StartupPath, "Resources", "Eminem.mp3");
            song = new Song("When I'm Gone", "Eminem", fileName);
            listRap.Add(song);

            //dodavanje pesni vo pop zhanr
            fileName = Path.Combine(Application.StartupPath, "Resources", "default.mp3");
            song = new Song("Default", "dasda", fileName);
            listPop.Add(song);
            fileName = Path.Combine(Application.StartupPath, "Resources", "happy.mp3");
            song = new Song("Happy", "Pharell Williams", fileName);
            listPop.Add(song);
            fileName = Path.Combine(Application.StartupPath, "Resources", "aSky.mp3");
            song = new Song("A Sky Full of Stars", "Coldplay", fileName);
            listPop.Add(song);
            fileName = Path.Combine(Application.StartupPath, "Resources", "fire.mp3");
            song = new Song("I See Fire", "Ed Sheeran", fileName);
            listPop.Add(song);

            //dodavanje pesni vo evergreen

            fileName = Path.Combine(Application.StartupPath, "Resources", "kucetoMoe.mp3");
            song = new Song("Кучето мое", "Студени нозе", fileName);
            listMak.Add(song);
            fileName = Path.Combine(Application.StartupPath, "Resources", "kaziZosto.mp3");
            song = new Song("Кажи зошто ме остави", "Никола Боби Автовски", fileName);
            listMak.Add(song);
            fileName = Path.Combine(Application.StartupPath, "Resources", "cijaSi.mp3");
            song = new Song("Чија си", "Славе Димитров", fileName);
            listMak.Add(song);

            //dodavanje pesni vo rock&roll

            fileName = Path.Combine(Application.StartupPath, "Resources", "sweet.mp3");
            song = new Song("Sweet Child O' Mine", "Guns N' Roses", fileName);
            listRok.Add(song);
            fileName = Path.Combine(Application.StartupPath, "Resources", "desire.mp3");
            song = new Song("Desire", "U2", fileName);
            listRok.Add(song);
            fileName = Path.Combine(Application.StartupPath, "Resources", "wish.mp3");
            song = new Song("Wish You Were Here", "Pink Floyd", fileName);
            listRok.Add(song);

            for (int i = 0; i < listPop.Count; i++)
            {
                listBox1.Items.Add(listPop.ElementAt(i));
            }

            ///btnDiskoPop.FlatAppearance.BorderSize = 0;
            //addSong.FlatAppearance.CheckedBackColor = Color.White;
            Application.EnableVisualStyles();
            chosenGenre = new int[4];
            chosenGenre[0] = 1;
            progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            progressBar1.ForeColor = Color.Red;
            btnEvergreen.FlatStyle = FlatStyle.Flat;
            btnEvergreen.FlatAppearance.BorderSize = 0;
            btnEvergreen.FlatAppearance.MouseOverBackColor = btnEvergreen.BackColor;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseOverBackColor = btnClose.BackColor;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatAppearance.MouseOverBackColor = btnMinimize.BackColor;
            addSong.FlatStyle = FlatStyle.Flat;
            addSong.FlatAppearance.BorderSize = 0;
            addSong.FlatAppearance.MouseOverBackColor = addSong.BackColor;
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = button3.BackColor;
            btnRokenrol.FlatStyle = FlatStyle.Flat;
            btnRokenrol.FlatAppearance.BorderSize = 0;
            btnRokenrol.FlatAppearance.MouseOverBackColor = btnRokenrol.BackColor;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = btnRokenrol.BackColor;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = btnRokenrol.BackColor;
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = btnRokenrol.BackColor;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatAppearance.MouseOverBackColor = btnRokenrol.BackColor;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseOverBackColor = btnRokenrol.BackColor;
            btnPop.FlatStyle = FlatStyle.Flat;
            btnPop.FlatAppearance.BorderSize = 0;
            btnPop.FlatAppearance.MouseOverBackColor = btnRokenrol.BackColor;
            btnHipHop.FlatStyle = FlatStyle.Flat;
            btnHipHop.FlatAppearance.BorderSize = 0;
            btnHipHop.FlatAppearance.MouseOverBackColor = btnRokenrol.BackColor;
            FormBorderStyle = FormBorderStyle.None;
            checkedListBox1.Items.Add("Поп");
            checkedListBox1.Items.Add("Рок");
            checkedListBox1.Items.Add("Рап");
            checkedListBox1.Items.Add("Македонски");
            lblPesna.Text = "Unknown Artist";
            lblArtist.Text = "Unknown Song";
            label3.Text = String.Format("{0:00}:{1:00}", 0, 0);
            label6.Text = String.Format("- {0:00}:{1:00}", 0, 0);
            timer1.Tick += new EventHandler(timer1_Tick);

        }

        IWavePlayer waveOutDevice;
        AudioFileReader audioFileReader;

        private void CloseWaveOut()
        {
            if (waveOutDevice != null)
            {
                waveOutDevice.Stop();
            }
            if (waveOutDevice != null)
            {
                waveOutDevice.Dispose();
                waveOutDevice = null;
            }
        }

        // Windows Explorer View

        private void mnuFileOpen_Click(object sender, System.EventArgs e)
        {
            // Show Open File dialog
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.Filter = "MP3 files (*.jpg)|*.mp3|";

            //openDlg.FileName = "" ;
            openDlg.CheckFileExists = true;
            openDlg.CheckPathExists = true;

            if (openDlg.ShowDialog() != DialogResult.OK)
                return;

            listBox1.Items.Add(openDlg.FileName);
            audioFileReader = new AudioFileReader(openDlg.FileName.ToString());
            pop.add(openDlg.FileName.ToString());
            //listBox1.Items.Add(songs.ElementAt(songs.Count - 1));

            OpenFile(audioFileReader.ToString());
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

        private void addSong_Click(object sender, EventArgs e)
        {
            if (waveOutDevice != null)
            {
                waveOutDevice.Stop();
                timer1.Enabled = false;
            }
            Form form2 = new Form2(this);
            form2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!pause)
            {
                if (Flage == 0)
                {
                    Lock = false;
                    if (listBox1.SelectedItem != null)
                    {
                        idx = listBox1.SelectedIndex;
                        waveOutDevice = new WaveOut();
                        waveOutDevice.Stop();
                        Song z = listBox1.SelectedItem as Song;
                        audioFileReader = new AudioFileReader(z.pat);
                        waveOutDevice.Init(audioFileReader);
                        waveOutDevice.Play();
                        String str = z.ToString();
                        String[] pom = str.Split('-');
                        lblArtist.Text = pom[1].Trim();
                        lblPesna.Text = pom[0].Trim();
                        label3.Text = String.Format("{0:00}:{1:00}", audioFileReader.CurrentTime.Minutes, audioFileReader.CurrentTime.Seconds);
                        label6.Text = String.Format("- {0:00}:{1:00}", audioFileReader.TotalTime.Minutes, audioFileReader.TotalTime.Seconds);
                        minuti = audioFileReader.TotalTime.Minutes;
                        minuti *= 60;
                        sekundi = audioFileReader.TotalTime.Seconds;
                        pause = true;
                        timer1.Enabled = true;
                        timer1.Start();
                        timer1.Interval = 1000;
                        progressBar1.Value = 0;
                        progressBar1.Maximum = minuti + sekundi;
                        Flage = 1;
                        button3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.pause));
                    }
                }
                else
                {
                    button3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.ivan));
                    waveOutDevice.Pause();
                    pause = false;
                    Flage = 0;
                    timer1.Stop();
                    timer1.Enabled = false;
                    blago = 1;
                }
            }
            else
            {
                Lock = false;
                if (Flage == 0)
                {
                    Flage = 1;
                    waveOutDevice.Play();
                    pause = true;
                    button3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.pause));
                    timer1.Enabled = true;
                    timer1.Start();
                    timer1.Interval = 1000;
                    progressBar1.Value = 0;
                    progressBar1.Maximum = minuti + sekundi;
                }
                else
                {
                    Flage = 0;
                    waveOutDevice.Pause();
                    pause = false;
                    button3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.ivan));
                    timer1.Stop();
                    timer1.Enabled = false;
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pause)
            {
                lblArtist.Text = listBox1.SelectedItem.ToString().Split('-')[0].Trim();
                lblPesna.Text = listBox1.SelectedItem.ToString().Split('-')[1].Trim() ;
            }
        }

        int Tick = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != progressBar1.Maximum)
            {
                if(Tick%2==0) progressBar1.Value += 1;
                Tick++;
                label3.Text = String.Format("{0:00}:{1:00}", audioFileReader.CurrentTime.Minutes, audioFileReader.CurrentTime.Seconds);
                if (audioFileReader.TotalTime.Seconds - audioFileReader.CurrentTime.Seconds >= 0)
                {
                    label6.Text = String.Format("- {0:00}:{1:00}", audioFileReader.TotalTime.Minutes - audioFileReader.CurrentTime.Minutes, audioFileReader.TotalTime.Seconds - audioFileReader.CurrentTime.Seconds);
                }
                else
                {
                    label6.Text = String.Format("- {0:00}:{1:00}", audioFileReader.TotalTime.Minutes - (audioFileReader.CurrentTime.Minutes+1), 60 + (audioFileReader.TotalTime.Seconds - audioFileReader.CurrentTime.Seconds));
                }
            }
            else
            {
                Tick = 0;
                timer1.Stop();
                timer1.Enabled = false;
                if (waveOutDevice != null)
                {
                    waveOutDevice.Pause();
                    if (listBox1.SelectedItem != null)
                    {
                        idx += 1 ;
                        if (idx < listBox1.Items.Count)
                        {
                            Song z = listBox1.Items[idx] as Song;
                            string x = z.ToString();
                            listBox1.SelectedIndex = listBox1.FindString(x, 0);
                            audioFileReader = new AudioFileReader(z.pat);
                            waveOutDevice.Init(audioFileReader);
                            waveOutDevice.Play();
                            button3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.pause));
                            String str = z.ToString();
                            String[] pom = str.Split('-');
                            lblArtist.Text = pom[1].Trim();
                            lblPesna.Text = pom[0];
                            label3.Text = String.Format("{0:00}:{1:00}", audioFileReader.CurrentTime.Minutes, audioFileReader.CurrentTime.Seconds);
                            label6.Text = String.Format("- {0:00}:{1:00}", audioFileReader.TotalTime.Minutes, audioFileReader.TotalTime.Seconds);
                            minuti = audioFileReader.TotalTime.Minutes;
                            minuti *= 60;
                            sekundi = audioFileReader.TotalTime.Seconds;
                            timer1.Enabled = true;
                            timer1.Start();
                            timer1.Interval = 1000;
                            progressBar1.Value = 0;
                            progressBar1.Maximum = minuti + sekundi;
                            Flage = 1;
                        }
                        else
                        {
                            idx = 0;
                            Song z = listBox1.Items[0] as Song;
                            string x = z.ToString();
                            listBox1.SelectedIndex = listBox1.FindString(x, 0);
                            audioFileReader = new AudioFileReader(z.pat);
                            waveOutDevice.Init(audioFileReader);
                            waveOutDevice.Play();
                            String str = z.ToString();
                            String[] pom = str.Split('-');
                            lblArtist.Text = pom[1].Trim();
                            lblPesna.Text = pom[0];
                            label3.Text = String.Format("{0:00}:{1:00}", audioFileReader.CurrentTime.Minutes, audioFileReader.CurrentTime.Seconds);
                            label6.Text = String.Format("- {0:00}:{1:00}", audioFileReader.TotalTime.Minutes, audioFileReader.TotalTime.Seconds);
                            minuti = audioFileReader.TotalTime.Minutes;
                            minuti *= 60;
                            sekundi = audioFileReader.TotalTime.Seconds;
                            timer1.Enabled = true;
                            timer1.Start();
                            timer1.Interval = 1000;
                            progressBar1.Value = 0;
                            progressBar1.Maximum = minuti + sekundi;
                            Flage = 1;
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            progressBar1.Value = 0;
            if (waveOutDevice!=null)
            {
                waveOutDevice.Pause();
                if (listBox1.SelectedItem != null)
                {
                    idx = idx + 1;
                    if (idx < listBox1.Items.Count)
                    {
                        Song z = listBox1.Items[idx] as Song;
                        string x = z.ToString();
                        listBox1.SelectedIndex = listBox1.FindString(x, 0);
                        audioFileReader = new AudioFileReader(z.pat);
                        waveOutDevice.Init(audioFileReader);
                        waveOutDevice.Play();
                        button3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.pause));
                        String str = z.ToString();
                        String[] pom = str.Split('-');
                        lblArtist.Text = pom[1].Trim();
                        lblPesna.Text = pom[0];
                        label3.Text = String.Format("{0:00}:{1:00}", audioFileReader.CurrentTime.Minutes, audioFileReader.CurrentTime.Seconds);
                        label6.Text = String.Format("- {0:00}:{1:00}", audioFileReader.TotalTime.Minutes, audioFileReader.TotalTime.Seconds);
                        minuti = audioFileReader.TotalTime.Minutes;
                        minuti *= 60;
                        sekundi = audioFileReader.TotalTime.Seconds;
                        timer1.Enabled = true;
                        timer1.Start();
                        timer1.Interval = 1000;
                        progressBar1.Value = 0;
                        progressBar1.Maximum = minuti + sekundi;
                        Flage = 1;
                    }
                    else
                    {
                        idx = 0;
                        Song z = listBox1.Items[0] as Song;
                        string x = z.ToString();
                        listBox1.SelectedIndex = listBox1.FindString(x, 0);
                        audioFileReader = new AudioFileReader(z.pat);
                        waveOutDevice.Init(audioFileReader);
                        waveOutDevice.Play();
                        String str = z.ToString();
                        String[] pom = str.Split('-');
                        lblArtist.Text = pom[1].Trim();
                        lblPesna.Text = pom[0];
                        label3.Text = String.Format("{0:00}:{1:00}", audioFileReader.CurrentTime.Minutes, audioFileReader.CurrentTime.Seconds);
                        label6.Text = String.Format("- {0:00}:{1:00}", audioFileReader.TotalTime.Minutes, audioFileReader.TotalTime.Seconds);
                        minuti = audioFileReader.TotalTime.Minutes;
                        minuti *= 60;
                        sekundi = audioFileReader.TotalTime.Seconds;
                        timer1.Enabled = true;
                        timer1.Start();
                        timer1.Interval = 1000;
                        progressBar1.Value = 0;
                        progressBar1.Maximum = minuti + sekundi;
                        Flage = 1;
                    }
                }
            }
            if (!Lock)
            {
                button3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.pause));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            progressBar1.Value = 0;
            if (waveOutDevice != null)
            {
                waveOutDevice.Pause();
                if (listBox1.SelectedItem != null)
                {
                    idx = idx - 1;
                    if (idx >= 0)
                    {
                        Song z = listBox1.Items[idx] as Song;
                        string x = z.ToString();
                        listBox1.SelectedIndex = listBox1.FindString(x, 0);
                        audioFileReader = new AudioFileReader(z.pat);
                        waveOutDevice.Init(audioFileReader);
                        waveOutDevice.Play();
                        String str = z.ToString();
                        String[] pom = str.Split('-');
                        lblArtist.Text = pom[1].Trim();
                        lblPesna.Text = pom[0];
                        label3.Text = String.Format("{0:00}:{1:00}", audioFileReader.CurrentTime.Minutes, audioFileReader.CurrentTime.Seconds);
                        label6.Text = String.Format("- {0:00}:{1:00}", audioFileReader.TotalTime.Minutes, audioFileReader.TotalTime.Seconds);
                        minuti = audioFileReader.TotalTime.Minutes;
                        minuti *= 60;
                        sekundi = audioFileReader.TotalTime.Seconds;
                        timer1.Enabled = true;
                        timer1.Start();
                        timer1.Interval = 1000;
                        progressBar1.Value = 0;
                        progressBar1.Maximum = minuti + sekundi;
                        Flage = 1;
                    }
                    else
                    {
                        idx = listBox1.Items.Count - 1;
                        Song z = listBox1.Items[listBox1.Items.Count - 1] as Song;
                        string x = z.ToString();
                        listBox1.SelectedIndex = listBox1.FindString(x, 0);
                        audioFileReader = new AudioFileReader(z.pat);
                        waveOutDevice.Init(audioFileReader);
                        waveOutDevice.Play();
                        String str = z.ToString();
                        String[] pom = str.Split('-');
                        lblArtist.Text = pom[1].Trim();
                        lblPesna.Text = pom[0];
                        label3.Text = String.Format("{0:00}:{1:00}", audioFileReader.CurrentTime.Minutes, audioFileReader.CurrentTime.Seconds);
                        label6.Text = String.Format("- {0:00}:{1:00}", audioFileReader.TotalTime.Minutes, audioFileReader.TotalTime.Seconds);
                        minuti = audioFileReader.TotalTime.Minutes;
                        minuti *= 60;
                        sekundi = audioFileReader.TotalTime.Seconds;
                        timer1.Enabled = true;
                        timer1.Start();
                        timer1.Interval = 1000;
                        progressBar1.Value = 0;
                        progressBar1.Maximum = minuti + sekundi;
                        Flage = 1;
                    }
                }
            }
            if (!Lock)
            {
                button3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.pause));
            }
    
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.Image = ((System.Drawing.Image)(Properties.Resources.close_hover));
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMinimize_MouseHover(object sender, EventArgs e)
        {
            btnMinimize.Image = ((System.Drawing.Image)(Properties.Resources.minimize_hover));
        }

        private void flowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void btnHipHop_Click(object sender, EventArgs e)
        {
            if (hipHopBool != true)
            {
                if (waveOutDevice != null)
                {
                    pause = false;
                    Flage = 0;
                    button3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.ivan));
                    waveOutDevice.Stop();
                    timer1.Enabled = false;
                }
            }
            Lock = true;
            popBool = false; hipHopBool = true; rokBool = false; evergrinBool = false;
            if (chosenGenre[1] != 1)
            {
                while (listBox1.Items.Count > 0)
                {
                    listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
                }
                for (int i = 0; i < listRap.Count; i++)
                {
                    listBox1.Items.Add(listRap.ElementAt(i));
                }
            }
            btnHipHop.Image = ((System.Drawing.Image)(Properties.Resources.hiphop_active));
            btnEvergreen.Image = ((System.Drawing.Image)(Properties.Resources.evergreen_normal));
            btnPop.Image = ((System.Drawing.Image)(Properties.Resources.pop_normal));
            btnRokenrol.Image = ((System.Drawing.Image)(Properties.Resources.rokenrol_normal));
            chosenGenre[1] = 1;
            for (int i = 0; i < 4; i++)
            {
                if (i != 1)
                    chosenGenre[i] = 0;
            }
        }

        private void btnRokenrol_Click(object sender, EventArgs e)
        {
            if (rokBool != true)
            {
                if (waveOutDevice != null)
                {
                    pause = false;
                    Flage = 0;
                    button3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.ivan));
                    waveOutDevice.Stop();
                    timer1.Enabled = false;
                }
            }
            Lock = true;
            popBool = false; hipHopBool = false; rokBool = true; evergrinBool = false;
            if (chosenGenre[2] != 1)
            {
                while (listBox1.Items.Count > 0)
                {
                    listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
                }
                for (int i = 0; i < listRok.Count; i++)
                {
                    listBox1.Items.Add(listRok.ElementAt(i));
                }
            }
            btnHipHop.Image = ((System.Drawing.Image)(Properties.Resources.hiphop_normal));
            btnEvergreen.Image = ((System.Drawing.Image)(Properties.Resources.evergreen_normal));
            btnPop.Image = ((System.Drawing.Image)(Properties.Resources.pop_normal));
            btnRokenrol.Image = ((System.Drawing.Image)(Properties.Resources.rokenrol_hover));
            chosenGenre[2] = 1;
            for (int i = 0; i < 4; i++)
            {
                if (i != 2)
                    chosenGenre[i] = 0;
            }
        }

        private void btnEvergreen_Click(object sender, EventArgs e)
        {
            if (evergrinBool != true)
            {
                if (waveOutDevice != null)
                {
                    pause = false;
                    Flage = 0;
                    button3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.ivan));
                    waveOutDevice.Stop();
                    timer1.Enabled = false;
                }
            }
            Lock = true;
            popBool = false; hipHopBool = false; rokBool = false; evergrinBool = true;
            if (chosenGenre[3] != 1)
            {
                while (listBox1.Items.Count > 0)
                {
                    listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
                }
                for (int i = 0; i < listMak.Count; i++)
                {
                    listBox1.Items.Add(listMak.ElementAt(i));
                }
            }
            btnHipHop.Image = ((System.Drawing.Image)(Properties.Resources.hiphop_normal));
            btnEvergreen.Image = ((System.Drawing.Image)(Properties.Resources.evergreen_hover));
            btnPop.Image = ((System.Drawing.Image)(Properties.Resources.pop_normal));
            btnRokenrol.Image = ((System.Drawing.Image)(Properties.Resources.rokenrol_normal));
            chosenGenre[3] = 1;
            for (int i = 0; i < 4; i++)
            {
                if (i != 3)
                    chosenGenre[i] = 0;
            }
        }

        private void btnHipHop_MouseHover(object sender, EventArgs e)
        {
            btnHipHop.Image = ((System.Drawing.Image)(Properties.Resources.hiphop_active));
        }

        private void btnHipHop_MouseLeave(object sender, EventArgs e)
        {
            if (chosenGenre[1] != 1)
                btnHipHop.Image = ((System.Drawing.Image)(Properties.Resources.hiphop_normal));
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.Image = ((System.Drawing.Image)(Properties.Resources.close_main));
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.Image = ((System.Drawing.Image)(Properties.Resources.minimize_main));
        }

        private void label5_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void btnPop_MouseHover(object sender, EventArgs e)
        {
            btnPop.Image = ((System.Drawing.Image)(Properties.Resources.pop_hover));
        }

        private void btnPop_MouseLeave(object sender, EventArgs e)
        {
            if (chosenGenre[0] != 1)
                btnPop.Image = ((System.Drawing.Image)(Properties.Resources.pop_normal));
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            if (popBool != true)
            {
                if (waveOutDevice != null)
                {
                    pause = false;
                    Flage = 0;
                    button3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.ivan));
                    waveOutDevice.Stop();
                    timer1.Enabled = false;
                }
            }
            popBool = true; hipHopBool = false; rokBool = false; evergrinBool = false;
            if (chosenGenre[0] != 1)
            {
                while (listBox1.Items.Count > 0)
                {
                    listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
                }
                for (int i = 0; i < listPop.Count; i++)
                {
                    listBox1.Items.Add(listPop.ElementAt(i));
                }
            }
            Lock = true;
            
            btnPop.Image = ((System.Drawing.Image)(Properties.Resources.pop_hover));
            btnHipHop.Image = ((System.Drawing.Image)(Properties.Resources.hiphop_normal));
            btnEvergreen.Image = ((System.Drawing.Image)(Properties.Resources.evergreen_normal));
            btnRokenrol.Image = ((System.Drawing.Image)(Properties.Resources.rokenrol_normal));
            chosenGenre[0] = 1;
            for (int i = 1; i < 4; i++) chosenGenre[i] = 0;
        }

        private void btnRokenrol_MouseHover(object sender, EventArgs e)
        {
            btnRokenrol.Image = ((System.Drawing.Image)(Properties.Resources.rokenrol_hover));
        }

        private void btnRokenrol_MouseLeave(object sender, EventArgs e)
        {
            if (chosenGenre[2] != 1)
                btnRokenrol.Image = ((System.Drawing.Image)(Properties.Resources.rokenrol_normal));
        }

        private void btnEvergreen_MouseLeave(object sender, EventArgs e)
        {
            if (chosenGenre[3] != 1)
                btnEvergreen.Image = ((System.Drawing.Image)(Properties.Resources.evergreen_normal));
        }

        private void btnEvergreen_MouseHover(object sender, EventArgs e)
        {
            btnEvergreen.Image = ((System.Drawing.Image)(Properties.Resources.evergreen_hover));
        }

        private void addSong_MouseHover(object sender, EventArgs e)
        {
            addSong.Image = ((System.Drawing.Image)(Properties.Resources.addsong_hover));
        }

        private void addSong_MouseLeave(object sender, EventArgs e)
        {
            addSong.Image = ((System.Drawing.Image)(Properties.Resources.addsong_normal));
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void lblArtist_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_Validated(object sender, EventArgs e)
        {

        }

        private void listBox1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            progressBar1.Value = 0;
            idx = listBox1.SelectedIndex;
            if (waveOutDevice != null)
            {
                waveOutDevice.Stop();
                if (listBox1.SelectedItem != null)
                {
                    waveOutDevice = new WaveOut();
                    waveOutDevice.Stop();
                    Song z = listBox1.Items[idx] as Song;
                    audioFileReader = new AudioFileReader(z.pat);
                    waveOutDevice.Init(audioFileReader);
                    waveOutDevice.Play();
                    str = z.ToString();
                    String[] pom = str.Split('-');
                    lblArtist.Text = pom[1].Trim();
                    lblPesna.Text = pom[0].Trim();
                    label3.Text = String.Format("{0:00}:{1:00}", audioFileReader.CurrentTime.Minutes, audioFileReader.CurrentTime.Seconds);
                    label6.Text = String.Format("- {0:00}:{1:00}", audioFileReader.TotalTime.Minutes, audioFileReader.TotalTime.Seconds);
                    minuti = audioFileReader.TotalTime.Minutes;
                    minuti *= 60;
                    sekundi = audioFileReader.TotalTime.Seconds;
                    progressBar1.Value = 0;
                    progressBar1.Maximum = minuti + sekundi;
                    timer1.Enabled = true;
                    timer1.Start();
                    timer1.Interval = 1000;
                    Flage = 1;
                    button3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.pause));
                }
            }
            else
            {
                if (listBox1.SelectedItem != null)
                {
                    waveOutDevice = new WaveOut();
                    waveOutDevice.Stop();
                    Song z = listBox1.SelectedItem as Song;
                    audioFileReader = new AudioFileReader(z.pat);
                    waveOutDevice.Init(audioFileReader);
                    waveOutDevice.Play();
                    String str = z.ToString();
                    String[] pom = str.Split('-');
                    lblArtist.Text = pom[1].Trim();
                    lblPesna.Text = pom[0];
                    label3.Text = String.Format("{0:00}:{1:00}", audioFileReader.CurrentTime.Minutes, audioFileReader.CurrentTime.Seconds);
                    label6.Text = String.Format("- {0:00}:{1:00}", audioFileReader.TotalTime.Minutes, audioFileReader.TotalTime.Seconds);
                    minuti = audioFileReader.TotalTime.Minutes;
                    minuti *= 60;
                    sekundi = audioFileReader.TotalTime.Seconds;
                    progressBar1.Value = 0;
                    progressBar1.Maximum = minuti + sekundi;
                    timer1.Enabled = true;
                    timer1.Start();
                    timer1.Interval = 1000;
                    Flage = 1;
                    button3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.pause));
                }
            }
        }
    }
}

