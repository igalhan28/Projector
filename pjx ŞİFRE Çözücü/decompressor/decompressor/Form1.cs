using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.Diagnostics;

namespace decompressor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ZipFile.ExtractToDirectory(@"C:\Projector\Proje\OD\projem.pjx", @"C:\Projector\Proje\OD\DC");
            Process.Start(@"C:\Projector\Projector\onlyLOADER.exe");
            Close();
            
        }
    }
}
