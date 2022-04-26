using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racunalo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Int32 port = 50300;
        string IP = "127.0.0.1";
        IPAddress localAddr = IPAddress.Parse("127.0.0.1");
        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        TcpClient tcpclnt = new TcpClient();
        void spoji()
        {
            try
            {

                tcpclnt.Connect(localAddr, port);
                label2.Invoke((MethodInvoker)(() => label2.Text = "Connected"));

            }
            catch (Exception e)
            {
                label2.Invoke((MethodInvoker)(() => label2.Text = "Error"));
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(polje);
            NetworkStream stream = tcpclnt.GetStream();
            stream.Write(data, 0, data.Length);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread trh1 = new Thread(spoji);
            trh1.Start();
        }
        char[] polje = { '0', '0', '0', '0', '0', '0', '0', '0', '0' };

        public void punjenjePolja()
        {
            if (button3.Text == "x")
            {
                polje[0] = '1';
            }
            else if (button3.Text == "O")
            {
                polje[0] = '2';
            }
            else
            {
                polje[0] = '0';
            }

            if (button4.Text == "x")
            {
                polje[1] = '1';
            }
            else if (button4.Text == "O")
            {
                polje[1] = '2';
            }
            else
            {
                polje[1] = '0';
            }

            if (button5.Text == "x")
            {
                polje[2] = '1';
            }
            else if (button5.Text == "O")
            {
                polje[2] = '2';
            }
            else
            {
                polje[2] = '0';
            }

            if (button6.Text == "x")
            {
                polje[3] = '1';
            }
            else if (button6.Text == "O")
            {
                polje[3] = '2';
            }
            else
            {
                polje[3] = '0';
            }
            if (button7.Text == "x")
            {
                polje[4] = '1';
            }
            else if (button7.Text == "O")
            {
                polje[4] = '2';
            }
            else
            {
                polje[4] = '0';
            }

            if (button8.Text == "x")
            {
                polje[5] = '1';
            }
            else if (button8.Text == "O")
            {
                polje[5] = '2';
            }
            else
            {
                polje[5] = '0';
            }
            if (button9.Text == "x")
            {
                polje[6] = '1';
            }
            else if (button9.Text == "O")
            {
                polje[6] = '2';
            }
            else
            {
                polje[6] = '0';
            }
            if (button10.Text == "x")
            {
                polje[7] = '1';
            }
            else if (button10.Text == "O")
            {
                polje[7] = '2';
            }
            else
            {
                polje[7] = '0';
            }
            if (button11.Text == "x")
            {
                polje[8] = '1';
            }
            else if (button11.Text == "O")
            {
                polje[8] = '2';
            }
            else
            {
                polje[8] = '0';
            }
        }
        public void Provjera()
        {
            String samic2b1 = button3.Text.ToString();
            String samic2b2 = button4.Text.ToString();
            String samic2b3 = button5.Text.ToString();

            String samic2b4 = button6.Text.ToString();
            String samic2b5 = button7.Text.ToString();
            String samic2b6 = button8.Text.ToString();

            String samic2b7 = button9.Text.ToString();
            String samic2b8 = button10.Text.ToString();
            String samic2b9 = button11.Text.ToString();


            if ((samic2b1 == samic2b2) && (samic2b2 == samic2b3))
            {
                if (samic2b1 == "x")
                {
                    MessageBox.Show("Pobijedio je x");
                }
                else if (samic2b1 == "O")
                {
                    MessageBox.Show("Pobijedio je o");
                }
            }
            else if ((samic2b4 == samic2b5) && (samic2b5 == samic2b6))
            {
                if (samic2b4 == "x")
                {
                    MessageBox.Show("Pobijedio je x");
                }
                else if (samic2b4 == "O")
                {
                    MessageBox.Show("Pobijedio je o");
                }
            }
            else if ((samic2b7 == samic2b8) && (samic2b8 == samic2b9))
            {
                if (samic2b7 == "x")
                {
                    MessageBox.Show("Pobijedio je x");
                }
                else if (samic2b7 == "O")
                {
                    MessageBox.Show("Pobijedio je o");
                }
            }
            else if ((samic2b1 == samic2b4) && (samic2b4 == samic2b7))
            {
                if (samic2b1 == "x")
                {
                    MessageBox.Show("Pobijedio je x");
                }
                else if (samic2b1 == "O")
                {
                    MessageBox.Show("Pobijedio je o");
                }
            }
            else if ((samic2b2 == samic2b5) && (samic2b5 == samic2b8))
            {
                if (samic2b2 == "x")
                {
                    MessageBox.Show("Pobijedio je x");
                }
                else if (samic2b2 == "O")
                {
                    MessageBox.Show("Pobijedio je o");
                }
            }
            else if ((samic2b3 == samic2b6) && (samic2b6 == samic2b9))
            {
                if (samic2b3 == "x")
                {
                    MessageBox.Show("Pobijedio je x");
                }
                else if (samic2b3 == "O")
                {
                    MessageBox.Show("Pobijedio je o");
                }
            }
            else if ((samic2b1 == samic2b5) && (samic2b5 == samic2b9))
            {
                if (samic2b1 == "x")
                {
                    MessageBox.Show("Pobijedio je x");
                }
                else if (samic2b1 == "O")
                {
                    MessageBox.Show("Pobijedio je o");
                }
            }
            else if ((samic2b3 == samic2b5) && (samic2b5 == samic2b7))
            {
                if (samic2b3 == "x")
                {
                    MessageBox.Show("Pobijedio je x");
                }
                else if (samic2b3 == "O")
                {
                    MessageBox.Show("Pobijedio je o");
                }
            }
        }


        int samuel = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "x" || button3.Text == "O")
            {
            }
            else
            {
                if (samuel == 0)
                {
                    button3.Text = "x";
                    samuel = 1;
                }
                else
                {
                    button3.Text = "O";
                    samuel = 0;
                }
            }
            Provjera();
            punjenjePolja();

            Byte[] data = System.Text.Encoding.ASCII.GetBytes(polje);
            NetworkStream stream = tcpclnt.GetStream();
            stream.Write(data, 0, data.Length);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "x" || button4.Text == "O")
            {
            }
            else
            {
                if (samuel == 0)
                {
                    button4.Text = "x";
                    samuel = 1;
                }
                else
                {
                    button4.Text = "O";
                    samuel = 0;
                }
            }
            Provjera();
            punjenjePolja();
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(polje);
            NetworkStream stream = tcpclnt.GetStream();
            stream.Write(data, 0, data.Length);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "x" || button5.Text == "O")
            {
            }
            else
            {
                if (samuel == 0)
                {
                    button5.Text = "x";
                    samuel = 1;
                }
                else
                {
                    button5.Text = "O";
                    samuel = 0;
                }
            }
            Provjera();
            punjenjePolja();
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(polje);
            NetworkStream stream = tcpclnt.GetStream();
            stream.Write(data, 0, data.Length);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "x" || button6.Text == "O")
            {
            }
            else
            {
                if (samuel == 0)
                {
                    button6.Text = "x";
                    samuel = 1;
                }
                else
                {
                    button6.Text = "O";
                    samuel = 0;
                }
            }
            Provjera();
            punjenjePolja();
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(polje);
            NetworkStream stream = tcpclnt.GetStream();
            stream.Write(data, 0, data.Length);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "x" || button7.Text == "O")
            {
            }
            else
            {
                if (samuel == 0)
                {
                    button7.Text = "x";
                    samuel = 1;
                }
                else
                {
                    button7.Text = "O";
                    samuel = 0;
                }
            }
            Provjera();
            punjenjePolja();
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(polje);
            NetworkStream stream = tcpclnt.GetStream();
            stream.Write(data, 0, data.Length);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "x" || button8.Text == "O")
            {
            }
            else
            {
                if (samuel == 0)
                {
                    button8.Text = "x";
                    samuel = 1;
                }
                else
                {
                    button8.Text = "O";
                    samuel = 0;
                }
            }
            Provjera();
            punjenjePolja();
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(polje);
            NetworkStream stream = tcpclnt.GetStream();
            stream.Write(data, 0, data.Length);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "x" || button9.Text == "O")
            {
            }
            else
            {
                if (samuel == 0)
                {
                    button9.Text = "x";
                    samuel = 1;
                }
                else
                {
                    button9.Text = "O";
                    samuel = 0;
                }
            }
            Provjera();
            punjenjePolja();
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(polje);
            NetworkStream stream = tcpclnt.GetStream();
            stream.Write(data, 0, data.Length);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.Text == "x" || button10.Text == "O")
            {
            }
            else
            {
                if (samuel == 0)
                {
                    button10.Text = "x";
                    samuel = 1;
                }
                else
                {
                    button10.Text = "O";
                    samuel = 0;
                }
            }
            Provjera();
            punjenjePolja();
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(polje);
            NetworkStream stream = tcpclnt.GetStream();
            stream.Write(data, 0, data.Length);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button11.Text == "x" || button11.Text == "O")
            {
            }
            else
            {
                if (samuel == 0)
                {
                    button11.Text = "x";
                    samuel = 1;
                }
                else
                {
                    button11.Text = "O";
                    samuel = 0;
                }
            }
            Provjera();
            punjenjePolja();
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(polje);
            NetworkStream stream = tcpclnt.GetStream();
            stream.Write(data, 0, data.Length);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }

}
