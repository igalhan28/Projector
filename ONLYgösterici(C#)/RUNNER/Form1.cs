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
        public Form1()
        {
            InitializeComponent();
        }
        int v = 1;
        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.uiMode = "none";
            WindowState = FormWindowState.Maximized;
            richTextBox2.LoadFile(@"C:/Projector/Proje/OP/TAB" + v +@"/Başlık/Başlık.txt" );
            StreamReader loc = new StreamReader(@"C:/Projector/Proje/OP/TAB" + v + @"/Photo/loc.txt");
            String x = loc.ReadLine();
            BackColor = richTextBox3.BackColor;
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
            if (e.KeyCode == Keys.Right)
            {
                v = v + 1;

                if (Directory.Exists(@"C:/Projector/Proje/OP/TAB" + v))
                {

                    richTextBox1.LoadFile(@"C:/Projector/Proje/OP/TAB" + v + @"/Metin/Metin.txt");
                    richTextBox2.LoadFile(@"C:/Projector/Proje/OP/TAB" + v + @"/Başlık/Başlık.txt");
                    StreamReader loc = new StreamReader(@"C:/Projector/Proje/OP/TAB" + v + @"/Photo/loc.txt");
                    String x = loc.ReadLine();
                    BackColor = richTextBox3.BackColor;
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
                        pictureBox1.Visible = true;
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
                }
                else
                {
                    MessageBox.Show("Sunum bitti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            if (e.KeyCode == Keys.Left)
            {
                v = v - 1;
                if (Directory.Exists(@"C:/Projector/Proje/Project/TAB" + v))
                {

                    richTextBox1.LoadFile(@"C:/Projector/Proje/OP/TAB" + v + @"/Metin/Metin.txt");
                    richTextBox2.LoadFile(@"C:/Projector/Proje/OP/TAB" + v + @"/Başlık/Başlık.txt");
                    StreamReader loc = new StreamReader(@"C:/Projector/Proje/OP/TAB" + v + @"/Photo/loc.txt");
                    String x = loc.ReadLine();
                    BackColor = richTextBox3.BackColor;

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
                }
            }
        }

        private void axWindowsMediaPlayer1_KeyDownEvent(object sender, AxWMPLib._WMPOCXEvents_KeyDownEvent e)
        {
            if (e.nKeyCode == 39)
            {
                v = v + 1;

                if (Directory.Exists(@"C:/Projector/Proje/OP/TAB" + v))
                {

                    richTextBox1.LoadFile(@"C:/Projector/Proje/OP/TAB" + v + @"/Metin/Metin.txt");
                    richTextBox2.LoadFile(@"C:/Projector/Proje/OP/TAB" + v + @"/Başlık/Başlık.txt");
                    StreamReader loc = new StreamReader(@"C:/Projector/Proje/OP/TAB" + v + @"/Photo/loc.txt");

                    String x = loc.ReadLine();
                    BackColor = richTextBox3.BackColor;

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
                        pictureBox1.Visible = true;
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
                }


                }
            if (e.nKeyCode == 37)
            {
                v = v - 1;
                if (Directory.Exists(@"C:/Projector/Proje/Project/TAB" + v))
                {

                    richTextBox1.LoadFile(@"C:/Projector/Proje/OP/TAB" + v + @"/Metin/Metin.txt");
                    richTextBox2.LoadFile(@"C:/Projector/Proje/OP/TAB" + v + @"/Başlık/Başlık.txt");
                    StreamReader loc = new StreamReader(@"C:/Projector/Proje/OP/TAB" + v + @"/Photo/loc.txt");

                    String x = loc.ReadLine();
                    BackColor = richTextBox3.BackColor;


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


                }
            }
            }
        }
    }

