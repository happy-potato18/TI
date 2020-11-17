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

        private bool IsSimple(ref BigInteger N) 
        {
            if (N > 100000)
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

        private bool isMutPrime (BigInteger m, BigInteger n)
        {
            BigInteger a, b;

            if (m > n)
            {
                 a = m;
                 b = n;
            }
            else
            {

                 a = n;
                 b = m;
            }

            while ((a != 0) && (b != 0))
            {
                BigInteger rem = (a > b) ? a % b : b % a;
                if (a > b)
                    a = rem;
                else
                    b = rem;
            }

            if ((a == 1) || (b == 1))
                return true;
            else
                return false;
        }

        private BigInteger EulerFunc(ref BigInteger p, ref BigInteger q)
        {
            return (p - 1) * (q - 1);
        }

        private BigInteger ExtendedEuclid(ref BigInteger m, ref BigInteger n)
        {
            BigInteger a = m;
            BigInteger b = n;
            BigInteger u1 = 1, v1 = 0, u2 = 0, v2 = 1, q = 0, r = 0, buff;
            while (b != 0)
            {
                q = a / b;
                r = a % b;
                a = b;
                b = r;
                buff = u2;
                u2 = u1 - q * u2;
                u1 = buff;
                buff = v2;
                v2 = v1 - q * v2;
                v1 = buff;
            }
            if (v1 > 0)
                return v1;
            else
                return v1 + a;
        }


        private BigInteger FastPow(BigInteger a,BigInteger z, BigInteger n)
        {
            BigInteger a1 = a;
            BigInteger z1 = z, x = 1;
            while (z1 != 0)
            {
                while(BigInteger.Remainder(z1,2) == 0)
                {
                    z1 = BigInteger.Divide(z1, 2);
                    a1 = BigInteger.Remainder(BigInteger.Multiply(a1, a1),n);
                }
                z1 = z1 - 1;
                x= BigInteger.Remainder(BigInteger.Multiply(x, a1), n);
            }
            return x;
        }

        private byte[] CryptRSA( byte[] src, ref BigInteger e, ref BigInteger r, bool sh)
        {
            var result = new byte[src.Length*4];
            int m = 0;
            for (int i = 0; i < src.Length; i++)
            {
                BigInteger C = FastPow((BigInteger)src[i], e, r);
                Int32 F = (Int32)C;
                byte[] Buffer = BitConverter.GetBytes(F);
                foreach (var x in Buffer)
                {
                    result[m] = x;
                    m++;
                }
                if ((sh) && (i <50))
                {
                    txBSrcToCrypt.Text = txBSrcToCrypt.Text + src[i].ToString() + " -> " + F.ToString() + Environment.NewLine; ;
                }
            }

            return result;
        }

        private byte[] DecryptRSA(byte[] src, ref BigInteger d, ref BigInteger r,bool sh)
        {
            var result = new byte[src.Length/4];
            for (int i = 0; i < src.Length; i+=4)
            {
                Int32 F = BitConverter.ToInt32(src, i);
                BigInteger C = FastPow((BigInteger)F, d, r);
                if (C > 255)
                {
                    MessageBox.Show("Too big value for byte-type");
                    return new byte[0];
                }
                result[i/4] = (byte)C;

                if (sh && (i < 50*4))
                {
                    txBCryptToDecrypt.Text = txBCryptToDecrypt.Text + F.ToString() + " -> " + C.ToString() + Environment.NewLine; ;
                }
            }

            return result;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return ;
            this.filename = openFileDialog1.FileName;
            btnCrypt.Visible = true;
                   
        }

        private void BtnCrypt_Click(object sender, EventArgs e)
        {
            bool end = false, show = true;
            long size;
            BigInteger Q = 0;
            BigInteger P = 0;
            BigInteger D = 0;
            BigInteger R = 0;
            BigInteger EulFunVal = 0;


            try //reading values from user
            {
                Q = BigInteger.Parse(tbQ.Text);
                P = BigInteger.Parse(tbP.Text);
                D = BigInteger.Parse(tbD.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message); //Format Exeption
                tbQ.Text = "";
                tbP.Text = "";
                tbD.Text = "";
                return; // exit from BtnCrypt_Click
            }

            if (D <= 1)
            {
                MessageBox.Show("Correct D-value!");
                return; // exit from BtnCrypt_Click
            }
            if ((!IsSimple(ref P)) || (!IsSimple(ref Q)))
            {
                MessageBox.Show("P or Q or both aren't simple or too large or negative!");
                return; // exit from BtnCrypt_Click
            }
            else
            {
                R = P * Q;
                EulFunVal = EulerFunc(ref P, ref Q);
            }

            if (R < 256)
            {
                MessageBox.Show("R is too small");
                return; // exit from BtnCrypt_Click
            }

            BigInteger E = ExtendedEuclid(ref EulFunVal, ref D);

            if ((D * E) % EulFunVal != 1)
            {
                MessageBox.Show("Please, correct D-value, because d*e mod f(r) != 1 . ");
                // MessageBox.Show( E.ToString()); // test Euclid
                return; // exit from BtnCrypt_Click
            }

            if ((E >= EulFunVal) || (!(isMutPrime(EulFunVal, E))) || (E <= 1) )
            {
                MessageBox.Show("Please, correct D-value!");
                return; // exit from BtnCrypt_Click
            }

            // working with file 
            FileStream SrcFile = new FileStream(this.filename, FileMode.Open, FileAccess.Read);
            FileStream CryptFile = new FileStream("D:\\УНИК\\ТИ\\лаба 3\\tests\\crypt_obj", FileMode.Create, FileAccess.Write);
            BinaryReader ByteFile = new BinaryReader(SrcFile,Encoding.UTF8);
            BinaryWriter CryptByteFile = new BinaryWriter(CryptFile, Encoding.UTF8);
            size = SrcFile.Length;
            if (size == 0)
            {
                MessageBox.Show("You have opened an empty file!");
                SrcFile.Close();
                ByteFile.Close();
                CryptFile.Close();
                CryptByteFile.Close();
                return;
            }
            long currpos = 0;
            while (!end)
            {
                long count = (size < currpos + 65536) ? size - currpos : 65536;
                currpos += count;
                var bytes = new byte[count];
                var cryptbytes = new byte[count*4];
                if (ByteFile.Read(bytes, 0, (int)count) == 0)
                     end = true;
                 else
                 {
                    cryptbytes = CryptRSA(bytes,ref E, ref R, show);
                    show = false; 
                    CryptByteFile.Write(cryptbytes, 0, (int)count*4);
                 }
            }
            SrcFile.Close();
            ByteFile.Close();
            CryptFile.Close();
            CryptByteFile.Close();

            btnEncrypt.Visible = true;
            lblOpenKey.Text = lblOpenKey.Text +' '+ E.ToString() + ", "  + R.ToString();
            lblOpenKey.Visible = true;
            lblCloseKey.Text = lblCloseKey.Text + ' ' + D.ToString() + ", "+ R.ToString();
            lblCloseKey.Visible = true;
            label7.Visible = true;
            txBSrcToCrypt.Visible = true;
          
        }

        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            bool end = false, show = true;
            long size;
            BigInteger Q = 0;
            BigInteger P = 0;
            BigInteger D = 0;
            BigInteger R = 0;
            BigInteger EulFunVal = 0;


            try //reading values from user
            {
                Q = BigInteger.Parse(tbQ.Text);
                P = BigInteger.Parse(tbP.Text);
                D = BigInteger.Parse(tbD.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message); //Format Exeption
                tbQ.Text = "";
                tbP.Text = "";
                tbD.Text = "";
                return; // exit from BtnCrypt_Click
            }

            if (D <= 1)
            {
                MessageBox.Show("Correct D-value!");
                return; // exit from BtnCrypt_Click
            }
            if ((!IsSimple(ref P)) || (!IsSimple(ref Q)))
            {
                MessageBox.Show("P or Q or both aren't simple or too large or negative!");
                return; // exit from BtnCrypt_Click
            }
            else
            {
                R = P * Q;
                EulFunVal = EulerFunc(ref P, ref Q);
            }

          if (R < 256)
          {
               MessageBox.Show("R is too small");
             return; // exit from BtnCrypt_Click
            }


            BigInteger E = ExtendedEuclid(ref EulFunVal, ref D);

            if ((D * E) % EulFunVal != 1)
            {
                MessageBox.Show("Please, correct D-value, because d*e mod f(r) != 1 . ");
                //MessageBox.Show(E.ToString());
                return; // exit from BtnCrypt_Click
            }

            if ((E >= EulFunVal) || (!(isMutPrime(EulFunVal, E))) || (E <= 1))
            {
                MessageBox.Show("Please, correct D-value!");
                return; // exit from BtnCrypt_Click
            }

            // working with file 
            FileStream CryptFile = new FileStream("D:\\УНИК\\ТИ\\лаба 3\\tests\\crypt_obj", FileMode.Open, FileAccess.Read);
            FileStream DecryptFile = new FileStream("D:\\УНИК\\ТИ\\лаба 3\\tests\\decrypt_obj", FileMode.Create, FileAccess.Write);
            BinaryReader CryptByteFile = new BinaryReader(CryptFile, Encoding.UTF8);
            BinaryWriter DecryptByteFile = new BinaryWriter(DecryptFile, Encoding.UTF8);
            size = CryptFile.Length;
            if (size == 0)
            {
                MessageBox.Show("You have opened an empty file!");
                return;
            }
            long currpos = 0;
            while (!end)
            {
                long count = (size < currpos + 65536) ? size - currpos : 65536;
                currpos += count;
                var cryptbytes = new byte[count];
                var decryptbytes = new byte[count/4];
                if (CryptByteFile.Read(cryptbytes, 0, (int)count) == 0)
                    end = true;
                else
                {
                    decryptbytes = DecryptRSA(cryptbytes, ref D, ref R, show);
                    show = false;
                    if (decryptbytes.Length == 0)
                    {
                        CryptFile.Close();
                        DecryptFile.Close();
                        CryptByteFile.Close();
                        DecryptByteFile.Close();
                        MessageBox.Show("Compare D,Q,R with initial values!");
                        return;
                    }
                    DecryptByteFile.Write(decryptbytes, 0, (int)count/4);
                }
            }
            CryptFile.Close();
            DecryptFile.Close();
            CryptByteFile.Close();
            DecryptByteFile.Close();
            label8.Visible = true;
            txBCryptToDecrypt.Visible = true;

        }
    }
}
