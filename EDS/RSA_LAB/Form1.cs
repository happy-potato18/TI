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
using System.Numerics;
using static System.Math;

namespace RSA_LAB
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private string filename; // property with file name

        private string filename2; // property with file name
       

        private bool IsSimple(ref BigInteger N)
        {
            if (N > 65536)
                return false;
            if (N <= 0)
                return false;

            for (int i = 2; i <= Sqrt((double)N); i++)
            {
                if (N % i == 0)
                    return false;
            }
            if (N == 1)
                return false;
            return true;
        }
      
        private BigInteger FastPow(BigInteger a, BigInteger z, BigInteger n)
        {
            BigInteger a1 = a;
            BigInteger z1 = z, x = 1;
            while (z1 != 0)
            {
                while (BigInteger.Remainder(z1, 2) == 0)
                {
                    z1 = BigInteger.Divide(z1, 2);
                    a1 = BigInteger.Remainder(BigInteger.Multiply(a1, a1), n);
                }
                z1 = z1 - 1;
                x = BigInteger.Remainder(BigInteger.Multiply(x, a1), n);
            }
            return x;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            this.filename = openFileDialog1.FileName;
            btnCrypt.Visible = true;

        }

        private void HashFunc(ref BigInteger h, byte[] src, BigInteger q)
        {
            for (int i = 0; i < src.Length; i++)
            {
                h = ( (h + src[i]) * (h + src[i]) ) % q;
            }
        }

        private void BtnCrypt_Click(object sender, EventArgs e)
        {
            long size;
            BigInteger Q = 0;
            BigInteger P = 0;
            BigInteger H = 0;
            BigInteger X = 0;
            BigInteger K = 0;
            BigInteger G = 0;
            BigInteger Y = 0;
            BigInteger HF = 100;
            BigInteger S = 0;
            BigInteger R = 0;


            try //reading values from user
            {
                Q = BigInteger.Parse(tbQ.Text);
                P = BigInteger.Parse(tbP.Text);
                H = BigInteger.Parse(tbH.Text);
                X = BigInteger.Parse(tbX.Text);
                K = BigInteger.Parse(tbK.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message); //Format Exeption
                tbQ.Text = "";
                tbP.Text = "";
                tbH.Text = "";
                tbX.Text = "";
                tbK.Text = "";
                return; // exit from BtnCrypt_Click
            }

           
            if ((!IsSimple(ref P)) || (!IsSimple(ref Q)))
            {
                MessageBox.Show("P or Q or both aren't simple or too large or negative!");
                return; // exit from BtnCrypt_Click
            }
           
            if ((P-1) % Q != 0 )
            {
                MessageBox.Show("Q is not a divider of (P-1)");
                return; // exit from BtnCrypt_Click
            }

            if ( (H <= 1) || (H >= (P-1) ) )
            {
                MessageBox.Show("Correct H-value!");
                return; // exit from BtnCrypt_Click
            }
            else
            {
                G = FastPow(H, (P - 1) / Q, P);
                if (G <= 1)
                {
                    MessageBox.Show("Correct H-value, because G is not correct");
                    return; // exit from BtnCrypt_Click
                }
            }


            if ( (X <= 0) || (X >= Q) )
            {
                MessageBox.Show("Correct X-value");
                return; // exit from BtnCrypt_Click
            }

            if ((K <= 0) || (K >= Q))
            {
                MessageBox.Show("Correct K-value");
                return; // exit from BtnCrypt_Click
            }

            Y = FastPow(G, X, P);
 
            FileStream Src = new FileStream(this.filename, FileMode.Open, FileAccess.Read);
            FileStream EDS = new FileStream("D:\\УНИК\\ТИ\\лаба4\\tests\\underwritten.txt", FileMode.Create, FileAccess.Write);
            StreamReader SrcFile = new StreamReader(Src, Encoding.UTF8);
            StreamWriter EDSFile = new StreamWriter(EDS, Encoding.UTF8);
            size = Src.Length;
            while (!SrcFile.EndOfStream)
            {
                var s = SrcFile.ReadLine();
                var bytes = new byte[s.Length];
                for (int i=0; i < bytes.Length; i++)
                {
                    bytes[i] = (byte)s[i];
                }
                HashFunc(ref HF, bytes, Q);
                EDSFile.WriteLine(s);
              
            }

            R = FastPow(G, K, P) % Q;
            S = (FastPow(K, Q - 2, Q) * ((HF + X * R) % Q) % Q);
            lblHash.Text = lblHash.Text +' '+ HF.ToString();
            lblHash.Visible = true;
            lblEDS.Text = lblEDS.Text + ' ' + R.ToString() + ", "+ S.ToString();
            lblEDS.Visible = true;
            button2.Visible = true;

            if ( (S == 0 ) || (R == 0) )
            {
                MessageBox.Show("Correct K-value, because R or S  =  0");
                SrcFile.Close();
                EDSFile.Close();
                return; // exit from BtnCrypt_Click
            }
            else
            {
                var StrR = R.ToString();
                var StrS = S.ToString();
                EDSFile.WriteLine(StrR);
                EDSFile.WriteLine(StrS);
                SrcFile.Close();
                EDSFile.Close();
                Src.Close();
                EDS.Close();


            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            this.filename2 = openFileDialog1.FileName;
            btnEncrypt.Visible = true;
        }

        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            long size;
            BigInteger Q = 0;
            BigInteger P = 0;
            BigInteger H = 0;
            BigInteger X = 0;
            BigInteger K = 0;
            BigInteger G = 0;
            BigInteger Y = 0;
            BigInteger HF = 100;
            BigInteger S = 0;
            BigInteger R = 0;


            try //reading values from user
            {
                Q = BigInteger.Parse(tbQ.Text);
                P = BigInteger.Parse(tbP.Text);
                H = BigInteger.Parse(tbH.Text);
                X = BigInteger.Parse(tbX.Text);
                K = BigInteger.Parse(tbK.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message); //Format Exeption
                tbQ.Text = "";
                tbP.Text = "";
                tbH.Text = "";
                tbX.Text = "";
                tbK.Text = "";
                return; // exit from BtnCrypt_Click
            }


            if ((!IsSimple(ref P)) || (!IsSimple(ref Q)))
            {
                MessageBox.Show("P or Q or both aren't simple or too large or negative!");
                return; // exit from BtnCrypt_Click
            }

            if ((P - 1) % Q != 0)
            {
                MessageBox.Show("Q is not a divider of (P-1)");
                return; // exit from BtnCrypt_Click
            }

            if ((H <= 1) || (H >= (P - 1)))
            {
                MessageBox.Show("Correct H-value!");
                return; // exit from BtnCrypt_Click
            }
            else
            {
                G = FastPow(H, (P - 1) / Q, P);
                if (G <= 1)
                {
                    MessageBox.Show("Correct H-value, because G is not correct");
                    return; // exit from BtnCrypt_Click
                }
            }


            if ((X <= 0) || (X >= Q))
            {
                MessageBox.Show("Correct X-value");
                return; // exit from BtnCrypt_Click
            }

            if ((K <= 0) || (K >= Q))
            {
                MessageBox.Show("Correct K-value");
                return; // exit from BtnCrypt_Click
            }

            Y = FastPow(G, X, P);

            FileStream Src_forcount = new FileStream(this.filename2, FileMode.Open, FileAccess.Read);
            StreamReader SrcFile_forcount = new StreamReader(Src_forcount,Encoding.UTF8);
            size = 0;
            while (!SrcFile_forcount.EndOfStream)
            {
                var s = SrcFile_forcount.ReadLine();
                size++;        

            }
            SrcFile_forcount.Close();
            Src_forcount.Close();
            FileStream Src = new FileStream(this.filename2, FileMode.Open, FileAccess.Read);
            StreamReader SrcFile = new StreamReader(Src, Encoding.UTF8);
            size -= 2;
            if (size< 0)
            {
                MessageBox.Show("Wrong file");
                return; // exit from BtnCrypt_Click
            }
            long posit = 0;
            while (posit != size)
            {
                var s = SrcFile.ReadLine();
                var bytes = new byte[s.Length];
                for (int i = 0; i < bytes.Length; i++)
                {
                    bytes[i] = (byte)s[i];
                }
                HashFunc(ref HF, bytes, Q);
                posit++;
            }

            try //reading values from user
            {
                var strR = SrcFile.ReadLine();
                R = BigInteger.Parse(strR);
                var strS = SrcFile.ReadLine();
                S = BigInteger.Parse(strS);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message); //Format Exeption
                SrcFile.Close();
                Src.Close();
                return; // exit from BtnCrypt_Click
            }
            BigInteger W = 0;
            W = FastPow(S, Q - 2, Q);
            BigInteger U1 = 0;
            U1 = (HF * W) % Q;
            BigInteger U2 = 0;
            U2 = (R * W) % Q;
            BigInteger V = 0;
            V = ( ( FastPow(G, U1, P) * FastPow(Y, U2, P) ) %P) % Q;


            SrcFile.Close();
            Src.Close();

            lblHash2.Text = lblHash2.Text + ' ' + HF.ToString();
            lblHash2.Visible = true;
            lblWait.Text = lblWait.Text + ' ' + R.ToString();
            lblWait.Visible = true;
            lblReceive.Text = lblReceive.Text + ' ' + V.ToString();
            lblReceive.Visible = true;

            if (V == R)
                MessageBox.Show("Equal!");
            else
                MessageBox.Show("Not equal!");
        }

        private void LblReceive_Click(object sender, EventArgs e)
        {

        }
    }
}
