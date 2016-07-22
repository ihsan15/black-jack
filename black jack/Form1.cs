using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace black_jack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int sayaç = 0;
        int opuan = 0, bpuan = 0;
        int toplam2 = 0;
        int toplam1 = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            sayaç++;
            int a1;
            label10.Visible = true;
            label9.Visible = true;
            button2.Enabled = true;
            if (sayaç == 1)
            {
                a1 = rastgele.Next(1, 11);
                int a2 = rastgele.Next(1, 11);
                label1.Text = a1.ToString();
                label2.Text = a2.ToString();
                toplam1 = a1 + a2;
                label10.Text = toplam1.ToString();


                pictureBox10.Visible = true;
                pictureBox10.ImageLocation = "C:\\Users\\ihsan\\Desktop\\c#\\blackjack\\" + a1 + ".jpg";


                pictureBox9.Visible = true;
                pictureBox9.ImageLocation = "C:\\Users\\ihsan\\Desktop\\c#\\blackjack\\" + a2 + ".jpg";

            }


            if (sayaç == 2)
            {
                toplam1 = Convert.ToInt32(label10.Text);
                int a3 = rastgele.Next(1, 11);
                label3.Text = a3.ToString();
                toplam1 += a3;
                label10.Text = toplam1.ToString();

                pictureBox4.Visible = true;
                pictureBox4.ImageLocation = "C:\\Users\\ihsan\\Desktop\\c#\\blackjack\\" + a3 + ".jpg";
                if (toplam1 >= 21)
                {
                    button1.Enabled = false;
                }
            }
            if (sayaç == 3)
            {
                toplam1 = Convert.ToInt32(label10.Text);
                int a4 = rastgele.Next(1, 11);
                label4.Text = a4.ToString();
                toplam1 += a4;
                label10.Text = toplam1.ToString();

                pictureBox3.Visible = true;
                pictureBox3.ImageLocation = "C:\\Users\\ihsan\\Desktop\\c#\\blackjack\\" + a4 + ".jpg";


                if (toplam1 >= 21)
                {
                    button1.Enabled = false;
                }
            }
            if (sayaç == 4)
            {
                toplam1 = Convert.ToInt32(label10.Text);
                int a5 = rastgele.Next(1, 11);
                label22.Text = a5.ToString();
                toplam1 += a5;
                label10.Text = toplam1.ToString();
                pictureBox2.Visible = true;
                pictureBox2.ImageLocation = "C:\\Users\\ihsan\\Desktop\\c#\\blackjack\\" + a5 + ".jpg";
                if (toplam1 >= 21)
                {
                    button1.Enabled = false;
                }
            }
            if (sayaç == 5)
            {
                toplam1 = Convert.ToInt32(label10.Text);
                int a6 = rastgele.Next(1, 11);
                label23.Text = a6.ToString();
                toplam1 += a6;
                label10.Text = toplam1.ToString();

                pictureBox1.Visible = true;
                pictureBox1.ImageLocation = "C:\\Users\\ihsan\\Desktop\\c#\\blackjack\\" + a6 + ".jpg";


                if (toplam1 >= 21)
                {
                    button1.Enabled = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
            button2.Enabled = false;

            do
            {
                int b = rastgele.Next(1, 11);
                
                listBox1.Items.Add(b);


                toplam2 += b;
                label11.Text = toplam2.ToString();



            }
            while (toplam2 < 16);
          

        }


       

        private void Form1_Load(object sender, EventArgs e)
        {
            button4.Enabled = false;
        }

        




        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;

            button3.Enabled = false;
            button4.Enabled = true;

            int otop, btop;
            otop = Convert.ToInt32(label10.Text);
            btop = Convert.ToInt32(label11.Text);

            if (otop > btop && otop <= 21)
            {

                opuan = opuan + 10;
                label19.Text = opuan.ToString();
            }
            if (btop > otop && btop <= 21)
            {


                bpuan = bpuan + 10;
                label20.Text = bpuan.ToString();
            }
            if (btop > 21 && otop > 21)
            {
                label13.Visible = true;
                label13.Text = "Berabere";
            }
            if (btop == otop && btop <= 21 && otop <= 21)
            {
                opuan = opuan + 10;
                bpuan = bpuan + 10;
                label19.Text = opuan.ToString();
                label20.Text = bpuan.ToString();
            }
            if (btop < 21 && otop > 21)
            {
                bpuan = bpuan + 10;
                label20.Text = bpuan.ToString();
            }
            if (otop < 21 && btop > 21)
            {
                opuan = opuan + 10;
                label19.Text = opuan.ToString();
            }

            if (opuan == 50)
            {
                button5.Visible = true;
                button6.Visible = true;
                button1.Enabled = false;
                button2.Enabled = false;

                label13.Visible = true;
                label13.Text = "Tebrikler Kazandınız!!";
            }
            if (bpuan == 50)
            {
                button5.Visible = true;
                button6.Visible = true;
                button1.Enabled = false;
                button2.Enabled = false;

                label13.Visible = true;
                label13.Text = "Malesef Kaybettiniz!!";
            }
            label11.Visible = true;
            label12.Visible = true;
            /* pictureBox5.Visible = true;
             pictureBox6.Visible = true;
             pictureBox7.Visible = true;
             pictureBox8.Visible = true;
             pictureBox11.Visible = true;
             pictureBox12.Visible = true;*/
            if (listBox1.Items.Count == 1)
            {

                pictureBox12.Visible = true;
                pictureBox12.ImageLocation = "C:\\Users\\ihsan\\Desktop\\c#\\blackjack\\" + listBox1.Items[0] + ".jpg";
            }
            if (listBox1.Items.Count == 2)
            {
                pictureBox12.Visible = true;
                pictureBox12.ImageLocation = "C:\\Users\\ihsan\\Desktop\\c#\\blackjack\\" + listBox1.Items[0] + ".jpg";
                pictureBox11.Visible = true;
                pictureBox11.ImageLocation = "C:\\Users\\ihsan\\Desktop\\c#\\blackjack\\" + listBox1.Items[1] + ".jpg";
            }

            if (listBox1.Items.Count == 3)
            {
                pictureBox12.Visible = true;
                pictureBox12.ImageLocation = "C:\\Users\\ihsan\\Desktop\\c#\\blackjack\\" + listBox1.Items[0] + ".jpg";
                pictureBox11.Visible = true;
                pictureBox11.ImageLocation = "C:\\Users\\ihsan\\Desktop\\c#\\blackjack\\" + listBox1.Items[1] + ".jpg";
                pictureBox8.Visible = true;
                pictureBox8.ImageLocation = "C:\\Users\\ihsan\\Desktop\\c#\\blackjack\\" + listBox1.Items[2] + ".jpg";
            }

            if (listBox1.Items.Count > 3)
            {
                pictureBox12.Visible = true;
                pictureBox12.ImageLocation = "C:\\Users\\ihsan\\Desktop\\c#\\blackjack\\" + listBox1.Items[0] + ".jpg";
                pictureBox11.Visible = true;
                pictureBox11.ImageLocation = "C:\\Users\\ihsan\\Desktop\\c#\\blackjack\\" + listBox1.Items[1] + ".jpg";
                pictureBox8.Visible = true;
                pictureBox8.ImageLocation = "C:\\Users\\ihsan\\Desktop\\c#\\blackjack\\" + listBox1.Items[2] + ".jpg";
                pictureBox7.Visible = true;
                pictureBox7.ImageLocation = "C:\\Users\\ihsan\\Desktop\\c#\\blackjack\\" + listBox1.Items[3] + ".jpg";
            }

            if (listBox1.Items.Count > 4)
            {
                pictureBox12.Visible = true;
                pictureBox12.ImageLocation = "C:\\Users\\ihsan\\Desktop\\c#\\blackjack\\" + listBox1.Items[0] + ".jpg";
                pictureBox11.Visible = true;
                pictureBox11.ImageLocation = "C:\\Users\\ihsan\\Desktop\\c#\\blackjack\\" + listBox1.Items[1] + ".jpg";
                pictureBox8.Visible = true;
                pictureBox8.ImageLocation = "C:\\Users\\ihsan\\Desktop\\c#\\blackjack\\" + listBox1.Items[2] + ".jpg";
                pictureBox7.Visible = true;
                pictureBox7.ImageLocation = "C:\\Users\\ihsan\\Desktop\\c#\\blackjack\\" + listBox1.Items[3] + ".jpg";
                pictureBox6.Visible = true;
                pictureBox6.ImageLocation = "C:\\Users\\ihsan\\Desktop\\c#\\blackjack\\" + listBox1.Items[4] + ".jpg";
            }

            if (listBox1.Items.Count > 5)
            {
                pictureBox12.Visible = true;
                pictureBox12.ImageLocation = "C:\\Users\\ihsan\\Desktop\\c#\\blackjack\\" + listBox1.Items[0] + ".jpg";
                pictureBox11.Visible = true;
                pictureBox11.ImageLocation = "C:\\Users\\ihsan\\Desktop\\c#\\blackjack\\" + listBox1.Items[1] + ".jpg";
                pictureBox8.Visible = true;
                pictureBox8.ImageLocation = "C:\\Users\\ihsan\\Desktop\\c#\\blackjack\\" + listBox1.Items[2] + ".jpg";
                pictureBox7.Visible = true;
                pictureBox7.ImageLocation = "C:\\Users\\ihsan\\Desktop\\c#\\blackjack\\" + listBox1.Items[3] + ".jpg";
                pictureBox6.Visible = true;
                pictureBox6.ImageLocation = "C:\\Users\\ihsan\\Desktop\\c#\\blackjack\\" + listBox1.Items[4] + ".jpg";

                pictureBox5.Visible = true;
                pictureBox5.ImageLocation = "C:\\Users\\ihsan\\Desktop\\c#\\blackjack\\" + listBox1.Items[5] + ".jpg";
            }


        }



        private void button4_Click(object sender, EventArgs e)
        {
            label10.Visible = false;
            label9.Visible = false;
            label13.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            sayaç = 0;
            label1.Text = "0";
            label2.Text = "0";
            label3.Text = "0";
            label4.Text = "0";
            label5.Text = "0";
            label6.Text = "0";
            label7.Text = "0";
            label8.Text = "0";
            label11.Text = "0";
            label10.Text = "0";
            label11.Visible = false;
            label12.Visible = false;
            button3.Enabled = true;
            button4.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            listBox1.Items.Clear();
            toplam1 = 0;
            toplam2 = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 reset = new Form1();
            reset.Show();
            this.Dispose(false);
        }

    }
}
