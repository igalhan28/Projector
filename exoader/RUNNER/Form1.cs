﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        private void one()
        {
            
                axWindowsMediaPlayer1.uiMode = "none";
                WindowState = FormWindowState.Maximized;
                string l = Application.StartupPath;
                richTextBox3.LoadFile(l + @"/Project/TAB" + v + @"/col.txt");
                richTextBox1.LoadFile(l + @"/Project/TAB" + v + "/Metin/Metin.txt");
                richTextBox2.LoadFile(l + @"/Project/TAB" + v + @"/Başlık/Başlık.txt");
                StreamReader loc = new StreamReader(l + @"/Project/TAB" + v + @"/Photo/loc.txt");
              
                String x = loc.ReadLine();
                BackColor = richTextBox3.BackColor;

                try
                {
                    pictureBox1.Image = Image.FromFile(l + @"\Project\TAB" + v + @"\Photo\" + x);
                }
                catch
                {
                    pictureBox1.Visible = false;
                    axWindowsMediaPlayer1.Visible = true;
                    axWindowsMediaPlayer1.URL = l + @"\Project\TAB" + v + @"\Photo\" + x;
                }
            }
        private void Form1_Load(object sender, EventArgs e) {
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
            if(e.KeyCode == Keys.Right)
            {
                v =v+1;

                if (Directory.Exists(@"C:/Projector/Proje/Project/TAB" + v))
                {
                    pictureBox1.Visible = true;
                    axWindowsMediaPlayer1.Visible = false;
                    string l = Application.StartupPath;
                    richTextBox3.LoadFile(l + @"/Project/TAB" + v + @"/col.txt");
                    richTextBox1.LoadFile(l + @"/Project/TAB" + v + "/Metin/Metin.txt");
                    richTextBox2.LoadFile(l + @"/Project/TAB" + v + @"/Başlık/Başlık.txt");
                    StreamReader loc = new StreamReader(l + @"/Project/TAB" + v + @"/Photo/loc.txt");

                    String x = loc.ReadLine();
                    BackColor = richTextBox3.BackColor;

                    try
                    {
                        pictureBox1.Image = Image.FromFile(l + @"\Project\TAB" + v + @"\Photo\" + x);
                    }
                    catch
                    {
                        pictureBox1.Visible = false;
                        axWindowsMediaPlayer1.Visible = true;
                        axWindowsMediaPlayer1.URL = l + @"\Project\TAB" + v + @"\Photo\" + x;
                    }
                }
                else
                {
                    MessageBox.Show("Sunum bitti","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                }
            if (e.KeyCode == Keys.Left)
            {
                v = v - 1;
                if (Directory.Exists(@"C:/Projector/Proje/Project/TAB" + v))
                {

                    string l = Application.StartupPath;
                    richTextBox3.LoadFile(l + @"/Project/TAB" + v + @"/col.txt");
                    richTextBox1.LoadFile(l + @"/Project/TAB" + v + "/Metin/Metin.txt");
                    richTextBox2.LoadFile(l + @"/Project/TAB" + v + @"/Başlık/Başlık.txt");
                    StreamReader loc = new StreamReader(l + @"/Project/TAB" + v + @"/Photo/loc.txt");

                    String x = loc.ReadLine();
                    BackColor = richTextBox3.BackColor;

                    try
                    {
                        pictureBox1.Image = Image.FromFile(l + @"\Project\TAB" + v + @"\Photo\" + x);
                    }
                    catch
                    {
                        pictureBox1.Visible = false;
                        axWindowsMediaPlayer1.Visible = true;
                        axWindowsMediaPlayer1.URL = l + @"\Project\TAB" + v + @"\Photo\" + x;
                    }


                }
            }
        }

        private void axWindowsMediaPlayer1_KeyDownEvent(object sender, AxWMPLib._WMPOCXEvents_KeyDownEvent e)
        {
            if (e.nKeyCode == 39)
            {
                v = v + 1;

                if (Directory.Exists(@"C:/Projector/Proje/Project/TAB" + v))
                {
                    string l = Application.StartupPath;
                    StreamReader loc = new StreamReader(l + @"/Project/TAB" + v + @"/Photo/loc.txt");
                    String x = loc.ReadLine();
                    try
                    {
                        pictureBox1.Image = Image.FromFile(l + @"\Project\TAB" + v + @"\Photo\" + x);
                    }
                    catch
                    {
                        pictureBox1.Visible = false;
                        axWindowsMediaPlayer1.Visible = true;
                        axWindowsMediaPlayer1.URL = l + @"\Project\TAB" + v + @"\Photo\" + x;
                    }
                    pictureBox1.Visible = true;
                    axWindowsMediaPlayer1.Visible = false;
                   
                    richTextBox3.LoadFile(l + @"/Project/TAB" + v + @"/col.txt");
                    richTextBox1.LoadFile(l + @"/Project/TAB" + v + "/Metin/Metin.txt");
                    richTextBox2.LoadFile(l + @"/Project/TAB" + v + @"/Başlık/Başlık.txt");
   
                  
                    BackColor = richTextBox3.BackColor;

                   
                }
                else
                {
                    MessageBox.Show("Sunum bitti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (e.nKeyCode == 37)
            {
                v = v - 1;
                if (Directory.Exists(@"C:/Projector/Proje/Project/TAB" + v))
                {

                    string l = Application.StartupPath;
                    richTextBox3.LoadFile(l + @"/Project/TAB" + v + @"/col.txt");
                    richTextBox1.LoadFile(l + @"/Project/TAB" + v + "/Metin/Metin.txt");
                    richTextBox2.LoadFile(l + @"/Project/TAB" + v + @"/Başlık/Başlık.txt");
                    StreamReader loc = new StreamReader(l + @"/Project/TAB" + v + @"/Photo/loc.txt");
                    String x = loc.ReadLine();
                    BackColor = richTextBox3.BackColor;

                    try
                    {
                        pictureBox1.Image = Image.FromFile(l + @"\Project\TAB" + v + @"\Photo\" + x);
                    }
                    catch
                    {
                        pictureBox1.Visible = false;
                        axWindowsMediaPlayer1.Visible = true;
                        axWindowsMediaPlayer1.URL = l + @"\Project\TAB" + v + @"\Photo\" + x;
                    }


                }
            }
        }
    }
}
