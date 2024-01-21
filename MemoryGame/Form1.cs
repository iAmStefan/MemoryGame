using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Declarari
        static PictureBox pair1photo1 = new PictureBox();
        static PictureBox pair1photo2 = new PictureBox();
        static PictureBox pair2photo1 = new PictureBox();
        static PictureBox pair2photo2 = new PictureBox();
        static PictureBox pair3photo1 = new PictureBox();
        static PictureBox pair3photo2 = new PictureBox();
        static PictureBox pair4photo1 = new PictureBox();
        static PictureBox pair4photo2 = new PictureBox();
        static PictureBox pair5photo1 = new PictureBox();
        static PictureBox pair5photo2 = new PictureBox();
        PictureBox pending1;
        PictureBox pending2;
        int time = 60;
        int[] puncteX = new int[10] { 40, 200, 360, 520, 680, 40, 200, 360,520, 680 };
        int[] puncteY = new int[10] { 40, 40, 40, 40, 40, 200, 200, 200, 200, 200 };
        List<Point> puncte = new List<Point>();
        PictureBox[] imagini = new PictureBox[10] { pair1photo1, pair1photo2, pair2photo1, pair2photo2, pair3photo1, pair3photo2, pair4photo1, pair4photo2, pair5photo1, pair5photo2};
        #endregion Declarari


        void Plasare()
        {
            for (int i = 0; i < imagini.Length; i++)
            {
                imagini[i].BorderStyle = BorderStyle.FixedSingle;
                imagini[i].SizeMode = PictureBoxSizeMode.StretchImage;
                imagini[i].BackColor = Color.Gray;
            }

            this.Controls.Add(pair1photo1);
            pair1photo1.Size = new Size(150, 150);
            pair1photo1.Tag = "p1";
            pair1photo1.Location = new Point(40, 40);
            pair1photo1.Click += Pair1photo1_Click;

            this.Controls.Add(pair1photo2);
            pair1photo2.Size = new Size(150, 150);
            pair1photo2.Tag = "p1";
            pair1photo2.Location = new Point(200, 40);
            pair1photo2.Click += Pair1photo2_Click;

            this.Controls.Add(pair2photo1);
            pair2photo1.Size = new Size(150, 150);
            pair2photo1.Tag = "p2";
            pair2photo1.Location = new Point(360, 40);
            pair2photo1.Click += Pair2photo1_Click;

            this.Controls.Add(pair2photo2);
            pair2photo2.Size = new Size(150, 150);
            pair2photo2.Tag = "p2";
            pair2photo2.Location = new Point(520, 40);
            pair2photo2.Click += Pair2photo2_Click;

            this.Controls.Add(pair3photo1);
            pair3photo1.Size = new Size(150, 150);
            pair3photo1.Tag = "p3";
            pair3photo1.Location = new Point(680, 40);
            pair3photo1.Click += Pair3photo1_Click;

            this.Controls.Add(pair3photo2);
            pair3photo2.Size = new Size(150, 150);
            pair3photo2.Tag = "p3";
            pair3photo2.Location = new Point(40, 200);
            pair3photo2.Click += Pair3photo2_Click;

            this.Controls.Add(pair4photo1);
            pair4photo1.Size = new Size(150, 150);
            pair4photo1.Tag = "p4";
            pair4photo1.Location = new Point(200, 200);
            pair4photo1.Click += Pair4photo1_Click;

            this.Controls.Add(pair4photo2);
            pair4photo2.Size = new Size(150, 150);
            pair4photo2.Tag = "p4";
            pair4photo2.Location = new Point(360, 200);
            pair4photo2.Click += Pair4photo2_Click;

            this.Controls.Add(pair5photo1);
            pair5photo1.Size = new Size(150, 150);
            pair5photo1.Tag = "p5";
            pair5photo1.Location = new Point(520, 200);
            pair5photo1.Click += Pair5photo1_Click;

            this.Controls.Add(pair5photo2);
            pair5photo2.Size = new Size(150, 150);
            pair5photo2.Tag = "p5";
            pair5photo2.Location = new Point(680, 200);
            pair5photo2.Click += Pair5photo2_Click;
        }

        private void Pair5photo2_Click(object sender, EventArgs e)
        {
            pair5photo2.Image = new Bitmap(@"Imagini/Pluto.jpg");
            if (pending1 == null) pending1 = pair5photo2;
            else if (pending1 != null && pending2 == null) pending2 = pair5photo2;
            if (pending1 != null && pending2 != null)
            {
                if (pending1.Tag == pending2.Tag)
                {
                    pending1 = null;
                    pending2 = null;
                    pair5photo2.Enabled = false;
                    pair5photo1.Enabled = false;
                }
                else wait.Enabled = true;
            }
        }

        private void Pair5photo1_Click(object sender, EventArgs e)
        {
            pair5photo1.Image = new Bitmap(@"Imagini/Pluto.jpg");
            if (pending1 == null) pending1 = pair5photo1;
            else if (pending1 != null && pending2 == null) pending2 = pair5photo1;
            if (pending1 != null && pending2 != null)
            {
                if (pending1.Tag == pending2.Tag)
                {
                    pending1 = null;
                    pending2 = null;
                    pair5photo2.Enabled = false;
                    pair5photo1.Enabled = false;
                }
                else wait.Enabled = true;
            }
        }

        private void Pair4photo2_Click(object sender, EventArgs e)
        {
            pair4photo2.Image = new Bitmap(@"Imagini/Uranus.jpg");
            if (pending1 == null) pending1 = pair4photo2;
            else if (pending1 != null && pending2 == null) pending2 = pair4photo2;
            if (pending1 != null && pending2 != null)
            {
                if (pending1.Tag == pending2.Tag)
                {
                    pending1 = null;
                    pending2 = null;
                    pair4photo2.Enabled = false;
                    pair4photo1.Enabled = false;
                }
                else wait.Enabled = true;
            }
        }

        private void Pair4photo1_Click(object sender, EventArgs e)
        {
            pair4photo1.Image = new Bitmap(@"Imagini/Uranus.jpg");
            if (pending1 == null) pending1 = pair4photo1;
            else if (pending1 != null && pending2 == null) pending2 = pair4photo1;
            if (pending1 != null && pending2 != null)
            {
                if (pending1.Tag == pending2.Tag)
                {
                    pending1 = null;
                    pending2 = null;
                    pair4photo2.Enabled = false;
                    pair4photo1.Enabled = false;
                }
                else wait.Enabled = true;
            }
        }

        private void Pair3photo2_Click(object sender, EventArgs e)
        {
            pair3photo2.Image = new Bitmap(@"Imagini/Neptun.jpg");
            if (pending1 == null) pending1 = pair3photo2;
            else if (pending1 != null && pending2 == null) pending2 = pair3photo2;
            if (pending1 != null && pending2 != null)
            {
                if (pending1.Tag == pending2.Tag)
                {
                    pending1 = null;
                    pending2 = null;
                    pair3photo2.Enabled = false;
                    pair3photo1.Enabled = false;
                }
                else wait.Enabled = true;
            }
        }

        private void Pair3photo1_Click(object sender, EventArgs e)
        {
            pair3photo1.Image = new Bitmap(@"Imagini/Neptun.jpg");
            if (pending1 == null) pending1 = pair3photo1;
            else if (pending1 != null && pending2 == null) pending2 = pair3photo1;
            if (pending1 != null && pending2 != null)
            {
                if (pending1.Tag == pending2.Tag)
                {
                    pending1 = null;
                    pending2 = null;
                    pair3photo2.Enabled = false;
                    pair3photo1.Enabled = false;
                }
                else wait.Enabled = true;
            }
        }

        private void Pair2photo2_Click(object sender, EventArgs e)
        {
            pair2photo2.Image = new Bitmap(@"Imagini/Venus.jpg");
            if (pending1 == null) pending1 = pair2photo2;
            else if (pending1 != null && pending2 == null) pending2 = pair2photo2;
            if (pending1 != null && pending2 != null)
            {
                if (pending1.Tag == pending2.Tag)
                {
                    pending1 = null;
                    pending2 = null;
                    pair2photo2.Enabled = false;
                    pair2photo1.Enabled = false;
                }
                else wait.Enabled = true;
            }
        }

        private void Pair2photo1_Click(object sender, EventArgs e)
        {
            pair2photo1.Image = new Bitmap(@"Imagini/Venus.jpg");
            if (pending1 == null) pending1 = pair2photo1;
            else if (pending1 != null && pending2 == null) pending2 = pair2photo1;
            if (pending1 != null && pending2 != null)
            {
                if (pending1.Tag == pending2.Tag)
                {
                    pending1 = null;
                    pending2 = null;
                    pair2photo2.Enabled = false;
                    pair2photo1.Enabled = false;
                }
                else wait.Enabled = true;
            }
        }

        private void Pair1photo2_Click(object sender, EventArgs e)
        {
            pair1photo2.Image = new Bitmap(@"Imagini/Marte.jpg");
            if (pending1 == null) pending1 = pair1photo2;
            else if (pending1 != null && pending2 == null) pending2 = pair1photo2;
            if (pending1 != null && pending2 != null)
            {
                if (pending2.Tag == pending1.Tag)
                {
                    pending1 = null;
                    pending2 = null;
                    pair1photo2.Enabled = false;
                    pair1photo1.Enabled = false;
                }
                else wait.Enabled = true;
            }
        }

        private void Pair1photo1_Click(object sender, EventArgs e)
        {
            pair1photo1.Image = new Bitmap(@"Imagini/Marte.jpg");
            if (pending1 == null) pending1 = pair1photo1;
            else if (pending1 != null && pending2 == null) pending2 = pair1photo1;
            if (pending1 != null && pending2 != null)
            {
                if (pending2.Tag == pending1.Tag)
                {
                    pending1 = null;
                    pending2 = null;
                    pair1photo2.Enabled = false;
                    pair1photo1.Enabled = false;
                }
                else wait.Enabled = true;
            }
        }

        private void startGame_Click(object sender, EventArgs e)
        {
            startGame.Visible = false;
            ceas.Enabled = true;
            Plasare();
            for (int i = 0; i < 10; i++)
            {
                Point punct = new Point();
                punct.X = puncteX[i];
                punct.Y = puncteY[i];
                puncte.Add(punct);
            }
            for (int i = 0; i < 10; i++)
            {
                Random random = new Random();
                int locatieImagine = random.Next(puncte.Count);
                Point punct = new Point();
                punct = puncte[locatieImagine];
                imagini[i].Location = punct;
                puncte.Remove(punct);
            }
        }

        private void ceas_Tick(object sender, EventArgs e)
        {
            time--;
            if (time < 60) timp.Text = "Timp ramas: " + time % 60 + " secunde";
            if (time == 0) ceas.Enabled = false;
            if (pair1photo1.Image != null && pair1photo2.Image != null && pair2photo1.Image != null && pair2photo2.Image != null && pair3photo1.Image != null && pair3photo2.Image != null && pair4photo1.Image != null && pair4photo2.Image != null && pair5photo1.Image != null && pair5photo2.Image != null) ceas.Enabled = false;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void wait_Tick(object sender, EventArgs e)
        {
            wait.Enabled = false;
            pending1.Image = null;
            pending2.Image = null;
            pending1 = null;
            pending2 = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
