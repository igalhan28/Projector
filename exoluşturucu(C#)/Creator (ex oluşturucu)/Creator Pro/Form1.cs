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
using System.Diagnostics;
namespace Creator_Pro
{
    public partial class Form1 : Form
    {
        //This Program written by İbrahim Göktuğ ALHAN 

        // Converter variables
        //length variables
        double nm = 0.000001;
        double µm = 0.001;
        double mm = 1;
        double  cm = 10;
        double dm = 100;
        double  m = 1000;
        double  dam = 10000;
        double hm = 100000;
        double km = 1000000;
        double inch = 25.4;
        double foot = 304.8;
        double yard = 914.4;
        double mile = 1609344;
        double dmil = 1852000;


        


        





        

        //  Editor variable
        int n = 1;
        //Important for TAB's
        public Form1()
        { 
            InitializeComponent();
            
        }

        private void tABToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox3.BackColor = colorDialog1.Color;
            tabPage1.BackColor = colorDialog1.Color;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            textBox1.Text = webBrowser1.Url.ToString();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

      
            openFileDialog1.ShowDialog();
            try
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                axWindowsMediaPlayer1.Visible = false;
                pictureBox1.Visible = true;
            }
            catch (Exception){
                try
                {
                    axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
                    axWindowsMediaPlayer1.Visible = true;
                    pictureBox1.Visible = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Projector Bu Dosyayı Desteklemiyor");
                }
            }


        }

//      -----                                                                                    --------    -------- 
//    ---------                                                                                  --------    --------
//     -------                                                                                   --------    --------                                        
// -----------------                                                                      -----   --------    --------                               -------  --------          
// -----------------                                                     -------------    -----   --------    --------                               -------  -------- ------------
//     ---------                                 ----                 ------------------- -----   --------    --------                     -----------------  ----------------------
//     ---------                     ---------   -----            ----------------------------    --------    --------    ---------     --------------------  -----------------------
//     ---------                ----------------------            ---------           --------    --------    --------  -------------   --------------------  --------       --------     
//     ---------            ---------------------------           --------            --------    --------    ------------------------- --------    --------  --------       --------
//     ---------            ---------             -------         --------            --------    --------    ------------------------- --------    --------  --------       --------
//     ---------            ---------              -------        --------            --------    --------    --------         -------- --------    --------  --------       --------
// -----------------        ---------               -------       --------            --------    --------    --------         -------- --------    --------  --------       --------
// -----------------         ---------               ------       --------            --------    --------    --------         -------- --------    --------  --------       --------
// -----------------          ----------------------------        -----------------------------   --------    --------         --------   ----------------    --------       --------        
// -----------------               --------------------             ------------------------
//                                         ---------
//                                         ---------
//                                         ---------
//                                         ---------
//                                         ---------
//                                         ---------    
//                           ------------------------           
//                             --------------------
//                                ---------------

        private void yazıTipiToolStripMenuItem_Click(object sender, EventArgs e)
        {
    

        }

        private void yazıTipiToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox3.SaveFile(@"C:\Projector\Proje\exco\Projem\Project\TAB"+n+@"\col.txt");
            StreamWriter name = new StreamWriter (@"C:\Projector\Proje\exco\Projem\Project\pron.txt");
            name.WriteLine(textBox2.Text);
            name.Close();
            StreamWriter po = new StreamWriter(@"C:\Projector\Proje\exco\Projem\Project\TAB" + n + @"\Photo\Loc.txt");
            string v = Path.GetFileName(openFileDialog1.FileName);
            po.WriteLine(v);
            po.Close();
            File.Copy(openFileDialog1.FileName, @"C:\Projector\Proje\exco\Projem\Project\TAB" + n + @"\Photo\" + Path.GetFileName(openFileDialog1.FileName));
            richTextBox2.SaveFile(@"C:\Projector\Proje\exco\Projem\Project\TAB" + n + @"\Metin\Metin.txt");
            richTextBox1.SaveFile(@"C:\Projector\Proje\exco\Projem\Project\TAB" + n + @"\Başlık\Başlık.txt");
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           Process.Start(@"C:\Projector\Projector\exCopyalayıcı.exe");
            timer1.Enabled = false;
        }

        private void yeniTABToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox3.SaveFile(@"C:\Projector\Proje\exco\Projem\Project\TAB" + n + @"\col.txt");
            StreamWriter po = new StreamWriter(@"C:\Projector\Proje\exco\Projem\Project\TAB" + n + @"\Photo\Loc.txt");
            string v = Path.GetFileName(openFileDialog1.FileName);
            po.WriteLine(v);
            po.Close();
            File.Copy(openFileDialog1.FileName, @"C:\Projector\Proje\exco\Projem\Project\TAB" + n + @"\Photo\" + Path.GetFileName(openFileDialog1.FileName));
            richTextBox2.SaveFile(@"C:\Projector\Proje\exco\Projem\Project\TAB" + n + @"\Metin\Metin.txt");
            richTextBox1.SaveFile(@"C:\Projector\Proje\exco\Projem\Project\TAB" + n + @"\Başlık\Başlık.txt");
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            pictureBox1.Image = Image.FromFile(@"C:\Projector\Samples\reminders.png");
            pictureBox1.Visible = true;
            axWindowsMediaPlayer1.Visible = false;
            Process.Start(@"C:\Projector\Projector\exTABBER.exe");
            n++;
        }

         public void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Red;
            richTextBox2.ForeColor = Color.Red;
            richTextBox1.ForeColor = Color.Black;
            richTextBox2.ForeColor = Color.Black;
        }

        private void yazıTipiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox2.SelectionFont = fontDialog1.Font;
            richTextBox2.SelectionColor = fontDialog1.Color;
        }

        private void yazıTipiToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            fontDialog2.ShowDialog();
            richTextBox1.SelectionFont = fontDialog2.Font;
            richTextBox1.SelectionColor = fontDialog2.Color;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton4_ButtonClick(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            pictureBox1.BackColor = colorDialog1.Color;
            richTextBox1.BackColor = colorDialog1.Color;
            richTextBox2.BackColor = colorDialog1.Color;
            tabPage1.BackColor = colorDialog1.Color;
            richTextBox3.BackColor = colorDialog1.Color;
        }

        private void yazıTipiToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox2.SelectionFont = fontDialog1.Font;
            richTextBox2.SelectionColor = fontDialog1.Color;
        }


        private void yazıTipiToolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            fontDialog2.ShowDialog();
            richTextBox1.SelectionFont = fontDialog2.Font;
            richTextBox1.SelectionColor = fontDialog2.Color;
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
      
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void tabControl1_Leave(object sender, EventArgs e)
        {
  
        }

        private void tabPage4_Leave(object sender, EventArgs e)
        {
    
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
           
             

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Decimal x = Convert.ToDecimal(textBox3.Text);
            Decimal y = Convert.ToDecimal(textBox4.Text);
            textBox3.Text = Convert.ToString(x + y);
            textBox4.Text = "";
         }

        private void tabControl1_Enter(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Decimal x = Convert.ToDecimal(textBox3.Text);
            Decimal y = Convert.ToDecimal(textBox4.Text);
            textBox3.Text = Convert.ToString(x - y);
            textBox4.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Decimal x = Convert.ToDecimal(textBox3.Text);
            Decimal y = Convert.ToDecimal(textBox4.Text);
            textBox3.Text = Convert.ToString(x * y);
            textBox4.Text = "";
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Decimal x = Convert.ToDecimal(textBox3.Text);
            Decimal y = Convert.ToDecimal(textBox4.Text);
            textBox3.Text = Convert.ToString(x / y);
            textBox4.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            long x = Convert.ToInt64(textBox3.Text);
            long y = Convert.ToInt64(textBox4.Text);
            textBox3.Text = Convert.ToString(Math.Pow (x , y));
            textBox4.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox4.Visible = false;
            button11.Visible = true;
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            double x = Math.Sqrt(Convert.ToDouble(textBox3.Text));
            textBox3.Text = Convert.ToString(x);
            textBox4.Visible = true;
            button11.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double ilen = 0;
            double en=0;
            if(comboBox1.SelectedItem == "milimetre")
            {
                ilen = mm;
            }
            if (comboBox1.SelectedItem == "santimetre")
            {
                ilen = cm;
            }
            if (comboBox1.SelectedItem == "desimetre")
            {
                ilen = dm;
            }
            if (comboBox1.SelectedItem == "metre")
            {
                ilen = m;
            }
            if (comboBox1.SelectedItem == "dekametre")
            {
                ilen = dam;
            }
            if (comboBox1.SelectedItem == "hektometre")
            {
                ilen = hm;
            }
            if (comboBox1.SelectedItem == "kilometre")
            {
                ilen = km;
            }
            if (comboBox1.SelectedItem == "inç")
            {
                ilen = inch;
            }
            if (comboBox1.SelectedItem == "fut")
            {
                ilen = foot;
            }
            if (comboBox1.SelectedItem == "yarda")
            {
                ilen = yard;
            }
            if (comboBox1.SelectedItem == "mil")
            {
                ilen = mile;
            }
            if (comboBox1.SelectedItem == "deniz mili")
            {
                ilen = dmil;
            }
            if (comboBox1.SelectedItem == "nanometre")
            {
                ilen = nm;
            }
            if (comboBox1.SelectedItem == "mikrometre")
            {
                ilen = µm;
            }




            if (comboBox3.SelectedItem == "milimetre")
            {
                en = mm;
            }
            if (comboBox3.SelectedItem == "santimetre")
            {
                en = cm;
            }
            if (comboBox3.SelectedItem == "desimetre")
            {
                en = dm;
            }
            if (comboBox3.SelectedItem == "metre")
            {
                en = m;
            }
            if (comboBox3.SelectedItem == "dekametre")
            {
                en = dam;
            }
            if (comboBox3.SelectedItem == "hektometre")
            {
                en = hm;
            }
            if (comboBox3.SelectedItem == "kilometre")
            {
                en = km;
            }
            if (comboBox3.SelectedItem == "inç")
            {
                en = inch;
            }
            if (comboBox3.SelectedItem == "fut")
            {
                en = foot;
            }
            if (comboBox3.SelectedItem == "yarda")
            {
                en = yard;
            }
            if (comboBox3.SelectedItem == "mil")
            {
                en = mile;
            }
            if (comboBox3.SelectedItem == "deniz mili")
            {
                en = dmil;
            }
            if (comboBox3.SelectedItem == "nanometre")
            {
                en = nm;
            }
            if (comboBox3.SelectedItem == "mikrometre")
            {
                en = µm;
            }
            ilen = ilen * Convert.ToDouble(textBox5.Text);
           
            textBox6.Text = Convert.ToString(ilen / en);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            double first = 0;
            double second = 0;
            //data variables
            double bit = 1;
            double bayt = 8;
            double kilobit = 1000;
            double kibibit = 1024;
            double kilobayt = 8000;
            double kibibayt = 8192;
            double megabit = 1000000;
            double mebibit = 1048576;
            double megabayt = 8000000;
            double mebibayt = 8388608;
            double gigabit = 1000000000;
            double gibibit = 1073741824;
            double gigabayt = 8000000000;
            double gibibayt = 8589934592;
            double terabit = 1000000000000;
            double tebibit = 1099511627776;
            double terabayt = 8000000000000;
            double tebibayt = 8796093022208;
            double petabit = 125 * terabayt;
            double pebibit = 1024 * tebibit;
            double petabayt = 1000 * terabayt;
            double pebibayt = 1024 * tebibayt;
            double exabit = 1000 * petabit;
            double exbibit = 1024 * pebibit;
            double exabayt = 1000 * petabayt;
            double exbibayt = 1024 * petabayt;
            double zetabit = 1000 * exabit;
            double zebibit = 1024 * exbibit;
            double zetabayt = 1000 * exabayt;
            double zebibayt = 1024 * exbibayt;
            double yottabit = 1000 * zetabit;
            double yobibit = 1024 * zebibit;
            double yottabayt = 1000 * zetabayt;
            double yobibayt = 1024 * zebibayt;
            if (comboBox4.SelectedItem == "Bit")
            {
                first = bit;
            }
            if (comboBox4.SelectedItem == "Bayt")
            {
                first = bayt;
            }
            if (comboBox4.SelectedItem == "Kilobit")
            {
                first = kilobit;
            }
            if (comboBox4.SelectedItem == "Kibibit")
            {
                first = kibibit;
            }
            if (comboBox4.SelectedItem == "Kilobayt")
            {
                first = kilobayt;
            }
            if (comboBox4.SelectedItem == "Kibibayt")
            {
                first = kibibayt;
            }
            if (comboBox4.SelectedItem == "Megabit")
            {
                first = megabit;
            }
            if (comboBox4.SelectedItem == "Mebibit")
            {
                first = mebibit;
            }
            if (comboBox4.SelectedItem == "Megabayt")
            {
                first = megabayt;
            }
            if (comboBox4.SelectedItem == "Mebibayt")
            {
                first = mebibayt ;
            }
            if (comboBox4.SelectedItem == "Gigabit")
            {
                first = gigabit;
            }
            if (comboBox4.SelectedItem == "gibibit")
            {
                first = gibibit;
            }
            if (comboBox4.SelectedItem == "Gigabayt")
            {
                first = gigabayt;
            }
            if (comboBox4.SelectedItem == "Gibibayt")
            {
                first = gibibayt ;
            }
            if (comboBox4.SelectedItem == "Terabit")
            {
                first = terabit;
            }
            if (comboBox4.SelectedItem == "Tebibit")
            {
                first = tebibit;
            }
            if (comboBox4.SelectedItem == "Terabayt")
            {
                first = terabayt;
            }
            if (comboBox4.SelectedItem == "Tebibayt")
            {
                first = tebibayt;
            }
            if (comboBox4.SelectedItem == "Petabit")
            {
                first = petabit;
            }
            if (comboBox4.SelectedItem == "Pebibit")
            {
                first = pebibit;
            }
            if (comboBox4.SelectedItem == "Petabayt")
            {
                first = petabayt ;
            }
            if (comboBox4.SelectedItem == "Pebibayt")
            {
                first = pebibayt;
            }
            if (comboBox4.SelectedItem == "Eksabit")
            {
                first = exabit;
            }
            if (comboBox4.SelectedItem == "Eksbibit")
            {
                first = exbibit;
            }
            if (comboBox4.SelectedItem == "Eksabayt")
            {
                first = exabayt;
            }
            if (comboBox4.SelectedItem == "Eksbibayt")
            {
                first = exbibayt;
            }
            if (comboBox4.SelectedItem == "Zetabit")
            {
                first = zetabit;
            }
            if (comboBox4.SelectedItem == "Zebibit")
            {
                first = zebibit;
            }
            if (comboBox4.SelectedItem == "Zetabayt")
            {
                first = zetabayt;
            }
            if (comboBox4.SelectedItem == "Zebibayt")
            {
                first = zebibayt;
            }
            if (comboBox4.SelectedItem == "Yottabit")
            {
                first = yottabit;
            }
            if (comboBox4.SelectedItem == "Yobibit")
            {
                first = yobibit;
            }
            if (comboBox4.SelectedItem == "Yottabayt")
            {
                first = yottabayt;
            }
            if (comboBox4.SelectedItem == "Yobibayt")
            {
                first = yobibayt;
            }







            //Second





            if (comboBox2.SelectedItem == "Bit")
            {
                second = bit;
            }
            if (comboBox2.SelectedItem == "Bayt")
            {
                second = bayt;
            }
            if (comboBox2.SelectedItem == "Kilobit")
            {
                second = kilobit;
            }
            if (comboBox2.SelectedItem == "Kibibit")
            {
                second = kibibit;
            }
            if (comboBox2.SelectedItem == "Kilobayt")
            {
                second = kilobayt;
            }
            if (comboBox2.SelectedItem == "Kibibayt")
            {
                second = kibibayt;
            }
            if (comboBox2.SelectedItem == "Megabit")
            {
                second = megabit;
            }
            if (comboBox2.SelectedItem == "Mebibit")
            {
                second = mebibit;
            }
            if (comboBox2.SelectedItem == "Megabayt")
            {
                second = megabayt;
            }
            if (comboBox2.SelectedItem == "Mebibayt")
            {
                second = mebibayt;
            }
            if (comboBox2.SelectedItem == "Gigabit")
            {
                second = gigabit;
            }
            if (comboBox2.SelectedItem == "gibibit")
            {
                second = gibibit;
            }
            if (comboBox2.SelectedItem == "Gigabayt")
            {
                second = gigabayt;
            }
            if (comboBox2.SelectedItem == "Gibibayt")
            {
                second = gibibayt;
            }
            if (comboBox2.SelectedItem == "Terabit")
            {
                second = terabit;
            }
            if (comboBox2.SelectedItem == "Tebibit")
            {
                second = tebibit;
            }
            if (comboBox2.SelectedItem == "Terabayt")
            {
                second = terabayt;
            }
            if (comboBox2.SelectedItem == "Tebibayt")
            {
                second = tebibayt;
            }
            if (comboBox2.SelectedItem == "Petabit")
            {
                second = petabit;
            }
            if (comboBox2.SelectedItem == "Pebibit")
            {
                second = pebibit;
            }
            if (comboBox2.SelectedItem == "Petabayt")
            {
                second = petabayt;
            }
            if (comboBox2.SelectedItem == "Pebibayt")
            {
                second = pebibayt;
            }
            if (comboBox2.SelectedItem == "Eksabit")
            {
                second = exabit;
            }
            if (comboBox2.SelectedItem == "Eksbibit")
            {
                second = exbibit;
            }
            if (comboBox2.SelectedItem == "Eksabayt")
            {
                second = exabayt;
            }
            if (comboBox2.SelectedItem == "Eksbibayt")
            {
                second = exbibayt;
            }
            if (comboBox2.SelectedItem == "Zetabit")
            {
                second = zetabit;
            }
            if (comboBox2.SelectedItem == "Zebibit")
            {
                second = zebibit;
            }
            if (comboBox2.SelectedItem == "Zetabayt")
            {
                second = zetabayt;
            }
            if (comboBox2.SelectedItem == "Zebibayt")
            {
                second = zebibayt;
            }
            if (comboBox2.SelectedItem == "Yottabit")
            {
                second = yottabit;
            }
            if (comboBox2.SelectedItem == "Yobibit")
            {
                second = yobibit;
            }
            if (comboBox2.SelectedItem == "Yottabayt")
            {
                second = yottabayt;
            }
            if (comboBox2.SelectedItem == "Yobibayt")
            {
                second = yobibayt;
            }
            first = first * Convert.ToDouble(textBox8.Text);
            textBox7.Text = Convert.ToString(first/second);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void metinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox2.BackColor = colorDialog1.Color;
        }

        private void başlıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.BackColor = colorDialog1.Color;
        }


        private void axWindowsMediaPlayer1_ClickEvent(object sender, AxWMPLib._WMPOCXEvents_ClickEvent e)
        {

            openFileDialog1.ShowDialog();
            try
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                axWindowsMediaPlayer1.Visible = false;
                pictureBox1.Visible = true;
            }
            catch (Exception)
            {
                try
                {
                    axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
                    axWindowsMediaPlayer1.Visible = true;
                    pictureBox1.Visible = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Projector Bu Dosyayı Desteklemiyor");
                }
            }
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }
    }
}   
