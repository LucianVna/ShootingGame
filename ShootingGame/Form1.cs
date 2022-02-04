using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShootingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int scor = 0;
        int ratari = 0;
        int trageri = 0;

        void sunet()
        {
            System.Media.SoundPlayer jucator = new System.Media.SoundPlayer(@"C:\Users\YatoShop\Desktop\c#\gunshot01.wav");
            jucator.Play();
        }

        void nr_trageri()
        {
            scor++;
            label1.Text = "Scor = " + scor;
            trageri++;
            label3.Text = "Trageri = " + trageri;

            sunet();
        }

        void nr_ratari()
        {
            ratari++;
            label2.Text = "Ratari = " + ratari;


            trageri++;
            label3.Text = "Total = " + trageri;

            sunet();
        }

        void incepe()
        {
            scor = 0;
            ratari = 0;
            trageri = 0;
            label3.Text = "Trageri = " + trageri;
            label2.Text = "Ratari = " + ratari;
            label1.Text = "Scor = " + scor;
            timer1.Start();
            label4.Text = "";



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int a, b;
            a = rnd.Next(50, 500);
            b = rnd.Next(300, 450);
            pictureBox1.Location = new Point(a, b);
            if (ratari >= 20)
            {
                timer1.Stop();
                label4.Text = "Sfarsit";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            nr_trageri();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            nr_ratari();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            incepe();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}


    

