using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RUNNER
{
    public partial class Form1 : Form
    {

        public void one()
        {
            
            axWindowsMediaPlayer1.uiMode = "none";
            WindowState = FormWindowState.Maximized;
            richTextBox2.LoadFile(@"C:/Projector/Proje/OP/TAB" + v + @"/Başlık/Başlık.txt");
            StreamReader loc = new StreamReader(@"C:/Projector/Proje/OP/TAB" + v + @"/Photo/loc.txt");
            String x = loc.ReadLine();
            StreamReader loop = new StreamReader(@"C:\Projector\Proje\OP\TAB" + v + @"\cont.pjf");
            string wont = loop.ReadLine();
            if (wont == "1")
            {
                pictureBox1.Visible = false;
                axWindowsMediaPlayer1.Visible = false;
                richTextBox1.LoadFile(@"C:/Projector/Proje/OP/TAB" + v + @"/Metin/Metin.txt");

            }
            else
            {
                try
                {
                    pictureBox1.Image = Image.FromFile(@"C:\Projector\Proje\OP\TAB" + v + @"\Photo\" + x);
                }
                catch
                {
                    pictureBox1.Visible = false;
                    axWindowsMediaPlayer1.Visible = true;
                    axWindowsMediaPlayer1.URL = @"C:\Projector\Proje\OP\TAB" + v + @"\Photo\" + x;
                    axWindowsMediaPlayer1.Ctlenabled = false;
                }
            }
            richTextBox1.BackColor = richTextBox1.SelectionBackColor;
            richTextBox2.BackColor = richTextBox2.SelectionBackColor;
        }
        public Form1()
        {
            InitializeComponent();
        }
        int v = 1;
        private void Form1_Load(object sender, EventArgs e)
        {
            one();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void axWindowsMediaPlayer1_KeyDownEvent(object sender, AxWMPLib._WMPOCXEvents_KeyDownEvent e)
        {
            if (e.nKeyCode == 39)
            {
                v = v + 1;

                if (Directory.Exists(@"C:/Projector/Proje/OP/TAB" + v))
                {

                    one();
                }


            }
            if (e.nKeyCode == 37)
            {
                v = v - 1;
                if (Directory.Exists(@"C:/Projector/Proje/OP/TAB" + v))
                {
                    one();


                }
            }
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void richTextBox2_MouseDown(object sender, MouseEventArgs e)
        {
           
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                v = v + 1;
                if (Directory.Exists(@"C:/Projector/Proje/OP/TAB" + v))
                {
                    

                    one();
                }
                else{
                    MessageBox.Show("Sunum Bitti","",MessageBoxButtons.OK,MessageBoxIcon.Information
                        );
                }
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                v = v - 1;
                if (true)
                {

                    one();
                }
            }

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
           
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (Directory.Exists(@"C:/Projector/Proje/OP/TAB" + v))
                {
                    v = v + 1;

                    one();
                }
                else
                {
                    MessageBox.Show("Sunum Bitti", "", MessageBoxButtons.OK, MessageBoxIcon.Information
                        );
                }
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                v = v - 1;
                if (Directory.Exists(@"C:/Projector/Proje/OP/TAB" + v))
                {

                    one();
                }
            }
        }

        private void richTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                v = v + 1;
                if (Directory.Exists(@"C:/Projector/Proje/OP/TAB" + v))
                {

                    one();
                }
                else
                {
                    MessageBox.Show("Sunum Bitti", "", MessageBoxButtons.OK, MessageBoxIcon.Information
                        );
                }
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                v = v - 1;
                if (Directory.Exists(@"C:/Projector/Proje/OP/TAB" + v))
                {

                    one();
                }
            }
        }

        private void axWindowsMediaPlayer1_MouseDownEvent(object sender, AxWMPLib._WMPOCXEvents_MouseDownEvent e)
        {

        }
    }




        }
  
    

