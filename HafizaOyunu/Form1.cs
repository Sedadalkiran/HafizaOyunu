using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HafizaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.ImageLocation = @"C:\Users\dell\Documents\Visual Studio 2017\Projects\HafizaOyunu\HafizaOyunu\Images\_780x438-cnkgs325qp.jpg";
            pictureBox2.ImageLocation = @"C:\Users\dell\Documents\Visual Studio 2017\Projects\HafizaOyunu\HafizaOyunu\Images\1200x675_9474_Night_castle_2d_landscape_castle_fantasy_picture_image_digital_art.jpg";
            pictureBox3.ImageLocation = @"C:\Users\dell\Documents\Visual Studio 2017\Projects\HafizaOyunu\HafizaOyunu\Images\ARKAPLAN (7).jpg";
            pictureBox4.ImageLocation = @"C:\Users\dell\Documents\Visual Studio 2017\Projects\HafizaOyunu\HafizaOyunu\Images\_780x438-cnkgs325qp.jpg";
            pictureBox5.ImageLocation = @"C:\Users\dell\Documents\Visual Studio 2017\Projects\HafizaOyunu\HafizaOyunu\Images\ARKAPLAN (7).jpg";
            pictureBox6.ImageLocation = @"C:\Users\dell\Documents\Visual Studio 2017\Projects\HafizaOyunu\HafizaOyunu\Images\eylem_95.jpg";
            pictureBox7.ImageLocation = @"C:\Users\dell\Documents\Visual Studio 2017\Projects\HafizaOyunu\HafizaOyunu\Images\eylem_95.jpg";
            pictureBox8.ImageLocation = @"C:\Users\dell\Documents\Visual Studio 2017\Projects\HafizaOyunu\HafizaOyunu\Images\1200x675_9474_Night_castle_2d_landscape_castle_fantasy_picture_image_digital_art.jpg";


        }
        public bool buttona, buttonb, buttonc, buttond,buttone,buttonf,buttong,buttonh;
        public int tiklamasayisi;
        public int i = 0;
        public int sure = 150;

        private void button9_Click(object sender, EventArgs e)
        {
            buttone = true;
            i = i + 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            buttonf = true;
            i = i + 1;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            buttong = true;
            i = i + 1;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            buttonh = true;
            i = i + 1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buttona = true;
            i = i + 1;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttonb = true;
            i = i + 1;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            buttonc = true;
            i = i + 1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (i != 2)
            {
                i = 0;
                buttona = false;
                buttonb = false;
                buttonc = false;
                buttond = false;
                buttone = false;
                buttonf = false;
                buttong = false;
                buttonh = false;
                label4.Text = "İKİ ADET RESİM SEÇİNİZ !";

            }

            if (i==2)
            {
                if (buttona == true & buttond == true)
                {
                    button4.Visible = false;
                    button5.Visible = false;
                    label4.Text = "RESİMLER AYNI.TEBRİKLER !";
                    i = 0;
                    buttona = false;
                    buttond = false;

                }

                else if (buttonb == true & buttonh == true)
                {
                    button3.Visible = false;
                    button10.Visible = false;
                    label4.Text = "RESİMLER AYNI.TEBRİKLER !";
                    i = 0;
                    buttonb = false;
                    buttonh = false;
                }

                else if (buttonc == true & buttone == true)
                {
                    button9.Visible = false;
                    button6.Visible = false;
                    label4.Text = "RESİMLER AYNI.TEBRİKLER !";
                    i = 0;
                    buttone = false;
                    buttonc = false;
                }

                else if (buttonf == true & buttong == true)
                {
                    button8.Visible = false;
                    button11.Visible = false;
                    label4.Text = "RESİMLER AYNI.TEBRİKLER !";
                    i = 0;
                    buttonf = false;
                    buttong = false;
                }
                else
                {
                    label4.Text = "RESİMLER FARKLI !";
                    i = 0;
                    buttona = false;
                    buttonb = false;
                    buttonc = false;
                    buttond = false;
                    buttone = false;
                    buttonf = false;
                    buttong = false;
                    buttonh = false;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buttond = true;
            i = i + 1;

        }

      
        
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
          

        }
       
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure = sure-1;
            label2.Text = sure.ToString();
            if (sure >100)
            {
               button3.Visible=false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button8.Visible = false;
                button9.Visible = false;
                button10.Visible = false;
                button11.Visible = false; 

            }

            else if (sure==100)
            {
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button8.Visible = true;
                button9.Visible = true;
                button10.Visible = true;
                button11.Visible = true;
                
            }
            if (sure == 0)
            {
                label5.Visible = true;
                timer1.Enabled = false;
                button2.Enabled = false;
                label2.Visible = false;
            }
           

        }
    }

  

}