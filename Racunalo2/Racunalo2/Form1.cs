using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racunalo2
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
        bool server_started = false;
        bool client_connected_to_server = false;


        char []polje;
        void funckKonekcija()
        {
            TcpListener server = new TcpListener(localAddr, port);
            server.Start();
            Byte[] bytes = new Byte[256];
            String data = null;
            while (true)
            {
                TcpClient client = server.AcceptTcpClient();
                label2.Invoke((MethodInvoker)(() => label2.Text = "spojeno"));

                data = null;

                NetworkStream ns = client.GetStream();

                int i;

                while ((i = ns.Read(bytes, 0, bytes.Length)) != 0)
                {
                    // Translate data bytes to a ASCII string.
                    data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                    polje=data.ToArray();
                    postaviPolje();
                }
            }
        }
        public void postaviPolje()
        {
            if (polje[0] == '1')
            {
                button3.Invoke((MethodInvoker)(() => button3.Text = "x"));
            }
            else if (polje[0] == '2')
            {
                button3.Invoke((MethodInvoker)(() => button3.Text = "O"));
            }

            if (polje[1] == '1')
            {
                button4.Invoke((MethodInvoker)(() => button4.Text = "x"));
            }
            else if (polje[1] == '2')
            {
                button4.Invoke((MethodInvoker)(() => button4.Text = "O"));
            }

            if (polje[2] == '1')
            {
                button5.Invoke((MethodInvoker)(() => button5.Text = "x"));
            }
            else if (polje[2] == '2')
            {
                button5.Invoke((MethodInvoker)(() => button5.Text = "O"));
            }

            if (polje[3] == '1')
            {
                button6.Invoke((MethodInvoker)(() => button6.Text = "x"));
            }
            else if (polje[3] == '2')
            {
                button6.Invoke((MethodInvoker)(() => button6.Text = "O"));
            }

            if (polje[4] == '1')
            {
                button7.Invoke((MethodInvoker)(() => button7.Text = "x"));
            }
            else if (polje[4] == '2')
            {
                button7.Invoke((MethodInvoker)(() => button7.Text = "O"));
            }

            if (polje[5] == '1')
            {
                button8.Invoke((MethodInvoker)(() => button8.Text = "x"));
            }
            else if (polje[5] == '2')
            {
                button8.Invoke((MethodInvoker)(() => button8.Text = "O"));
            }

            if (polje[6] == '1')
            {
                button9.Invoke((MethodInvoker)(() => button9.Text = "x"));
            }
            else if (polje[6] == '2')
            {
                button9.Invoke((MethodInvoker)(() => button9.Text = "0"));
            }

            if (polje[7] == '1')
            {
                button10.Invoke((MethodInvoker)(() => button10.Text = "x"));
            }
            else if (polje[7] == '2')
            {
                button10.Invoke((MethodInvoker)(() => button10.Text = "O"));
            }

            if (polje[8] == '1')
            {
                button11.Invoke((MethodInvoker)(() => button11.Text = "x"));
            }
            else if (polje[8] == '2')
            {
                button11.Invoke((MethodInvoker)(() => button11.Text = "O"));
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Thread thr1 = new Thread(funckKonekcija);
            server_started = true;
            thr1.Start();
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
  
        }
    }
}
