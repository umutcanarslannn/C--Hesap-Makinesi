using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        double s1;
        double s2;
        string bosluk;
        int faktoriyel = 1;
        string degisken;
        public Form1()
        {
            InitializeComponent();
            this.Width = 380;
            this.Height = 550;                               
        }

        private void button12_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToDouble(richTextBox1.Text);
            bosluk = "*";
            richTextBox1.Text = " ";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += (1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += (2);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += (3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += (4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += (5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += (6);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += (7);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += (8);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += (9);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += (0);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToDouble(richTextBox1.Text);
            bosluk = "+";
            richTextBox1.Text = " ";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            s2 = Convert.ToDouble(richTextBox1.Text);
            if (bosluk == "+")
            {
               
                richTextBox1.Text = Convert.ToString(s1 + s2);

            }
            if (bosluk == "-")
            {
                
                richTextBox1.Text = Convert.ToString(s1 - s2);
            }
            if (bosluk == "*")
            {
                
                richTextBox1.Text = Convert.ToString(s1 * s2);
            }
            if (bosluk == "/")
            {
                
                if (s2 != 0)
                    richTextBox1.Text = Convert.ToString(s1 / s2);
                else
                    MessageBox.Show("0 Girilemez.", "Uyarı!");
            }
            if (bosluk == "√")
            {
                richTextBox1.Text = Convert.ToString(Math.Sqrt(s1));
            }
            if(bosluk=="sin")
                richTextBox1.Text = Convert.ToString(Math.Sin(Math.PI * s1 / 180));
            if(bosluk=="cos")
                richTextBox1.Text = Convert.ToString(Math.Cos(Math.PI * s1 / 180));
            if(bosluk=="tan")
                richTextBox1.Text = Convert.ToString(Math.Tan(Math.PI * s1 / 180));
            if (bosluk == "kare")
                richTextBox1.Text = Convert.ToString(s1*s1);
            if(bosluk=="sinh")
                richTextBox1.Text = Convert.ToString(Math.Sinh(Math.PI * s1 / 180));
            if (bosluk == "küp")
                richTextBox1.Text = Convert.ToString(s1 * s1 * s1);
            if (bosluk == "xustu")            
                richTextBox1.Text =Convert.ToString(Math.Pow(s1, s2));
            if (bosluk == "faktoriyel")
            {
                for (int i = 1; i <= s1; i++)
                {
                    faktoriyel = faktoriyel * i;
                }
                richTextBox1.Text = Convert.ToString(faktoriyel);
            }
            if (bosluk == "onuslu")
                richTextBox1.Text = Convert.ToString(Math.Pow(10, s1));
            if (bosluk == "exp")
                richTextBox1.Text=Convert.ToString(Math.Exp(s1));
            if(bosluk=="3kok")
                richTextBox1.Text = Convert.ToString(Math.Sqrt(s1));
            if (bosluk == "mod")
                richTextBox1.Text = Convert.ToString(s1 % s2);
            if (bosluk == "log")
                richTextBox1.Text =Convert.ToString( Math.Log10(s1));
            if (bosluk == "1bolux")
                richTextBox1.Text = Convert.ToString(1 / s1);        
        }

        private void button11_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToDouble(richTextBox1.Text);
            bosluk = "-";
            richTextBox1.Text = " ";
        }

        private void button13_Click(object sender, EventArgs e)
        {                        
                s1 = Convert.ToDouble(richTextBox1.Text);
                bosluk = "/";
                richTextBox1.Text = " ";                                    
        }

        private void button16_Click(object sender, EventArgs e)
        {
            s1 = 0;
            s2 = 0;
            richTextBox1.Text = " ";
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            degisken = richTextBox1.Text.Substring(0, richTextBox1.Text.Length - 1);

               richTextBox1.Text=degisken;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button18_Click(object sender, EventArgs e)
        {
            richTextBox1.Text+= (",");
        }

        private void button19_Click(object sender, EventArgs e)
        {
              
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void renkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult tus;
            tus = colorDialog1.ShowDialog();
            if (tus == DialogResult.OK)

                this.BackColor = colorDialog1.Color;
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Text += (")");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            s1  = Convert.ToDouble(richTextBox1.Text);
            bosluk = "sin";
        }

        private void button44_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToDouble(richTextBox1.Text);
            bosluk = "√";
            
        }

        private void button20_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += ("(");
        }

        private void button42_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += (Math.PI);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToDouble(richTextBox1.Text);
            bosluk = "cos";
        }

        private void button34_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToDouble(richTextBox1.Text);
            bosluk = "tan";
        }

        private void button38_Click(object sender, EventArgs e)
        {
           
        }

        private void bilimselToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Height = 528;
            this.Width = 1067;
            richTextBox1.Width = 1000;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
           
        }

        private void button28_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToDouble(richTextBox1.Text);
            bosluk = "kare";
        }

        private void button46_Click(object sender, EventArgs e)
        {
            label1.Text = richTextBox1.Text;
        }

        private void button49_Click(object sender, EventArgs e)
        {
            label1.Text = " ";
            label1.Visible = false;
        }

        private void button45_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToDouble(richTextBox1.Text);
            bosluk = "sinh";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToDouble(richTextBox1.Text);
            bosluk = "küp";
        }

        private void button29_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToDouble(richTextBox1.Text);
            bosluk = "xustu";
            richTextBox1.Text = " ";
        }

        private void standartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 380;
            this.Height = 550;
            richTextBox1.Width = 320;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToDouble(richTextBox1.Text);
            bosluk = "faktoriyel";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToDouble(richTextBox1.Text);
            bosluk = "onuslu";
        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button39_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToDouble(richTextBox1.Text);
            bosluk = "exp";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToDouble(richTextBox1.Text);
            bosluk = "3kok";
        }

        private void button48_Click(object sender, EventArgs e)
        {

        }

        private void button35_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToDouble(richTextBox1.Text);
            bosluk = "mod";
            richTextBox1.Text = " ";
        }

        private void button31_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToDouble(richTextBox1.Text);
            bosluk = "log";
        }

        private void button47_Click(object sender, EventArgs e)
        {

        }

        private void button50_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToDouble(richTextBox1.Text);
            bosluk = "1bolux";
        }
    }
}
