using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace HashCalculator
{
    public partial class Form1 : Form
    {
            

        public Form1()
        {
            InitializeComponent();
        }
        private void computeMD5()
        {
            string input;
            byte[] tmpInput;
            byte[] tmpHash;

            input = tB_input.Text;

            tmpInput = ASCIIEncoding.ASCII.GetBytes(input);
            tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpInput);

            StringBuilder output = new StringBuilder();
            for (int i = 0; i < tmpHash.Length; i++)
            {
                output.Append(tmpHash[i].ToString("X2"));
            }
            tb_md5.Text = output.ToString();

        }
        private void computeSHA2()
        {
            string input;
            byte[] tmpInput;
            byte[] tmpHash;

            input = tB_input.Text;
            tmpInput = ASCIIEncoding.ASCII.GetBytes(input);
            tmpHash = new SHA256CryptoServiceProvider().ComputeHash(tmpInput);

            StringBuilder output = new StringBuilder();
            for (int i = 0; i < tmpHash.Length; i++)
            {
                output.Append(tmpHash[i].ToString("X2"));
            }
            tb_sha2.Text = output.ToString();

        }
        private void computeSHA1()
        {
            string input;
            byte[] tmpInput;
            byte[] tmpHash;
            input = tB_input.Text;

            tmpInput = ASCIIEncoding.ASCII.GetBytes(input);
            tmpHash = new SHA1CryptoServiceProvider().ComputeHash(tmpInput);

            StringBuilder output = new StringBuilder();
            for (int i = 0; i < tmpHash.Length; i++)
            {
                output.Append(tmpHash[i].ToString("X2"));
            }
            tb_sha1.Text = output.ToString();
            



        }
        private void compfileMD5()
        {
            byte[] myhash;
            using (var md5 = MD5.Create())
            using (var stream = File.OpenRead(@"d:\MINH TRIEU\binary.bin"))
                myhash = md5.ComputeHash(stream);
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < myhash.Length; i++)
            {
                output.Append(myhash[i].ToString("X2"));
            }
            tb_md5.Text = output.ToString();

        }
        private void compfileSHA1()
        {
            byte[] myhash;
            using (var sha1 = SHA1.Create())
            using (var stream = File.OpenRead(@"d:\MINH TRIEU\binary.bin"))
                myhash = sha1.ComputeHash(stream);
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < myhash.Length; i++)
            {
                output.Append(myhash[i].ToString("X2"));
            }
            tb_sha1.Text = output.ToString();

        }
        private void compfileSHA2()
        {
            byte[] myhash;
            using (var sha2 = SHA256.Create())
            using (var stream = File.OpenRead(@"d:\MINH TRIEU\binary.bin"))
                myhash = sha2.ComputeHash(stream);
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < myhash.Length; i++)
            {
                output.Append(myhash[i].ToString("X2"));
            }
            tb_sha2.Text = output.ToString();

        }
        private void cmhexMD5()
        {
            string input;
            byte[] tmpHash;
            input = tB_input.Text;
            byte[] data = new byte[input.Length / 2];
            for (int index = 0; index < data.Length; index++)
            {
                string byteValue = input.Substring(index * 2, 2);
                data[index] = byte.Parse(byteValue, System.Globalization.NumberStyles.HexNumber);
            }

            tmpHash = new MD5CryptoServiceProvider().ComputeHash(data);
                
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < tmpHash.Length; i++)
            {
                output.Append(tmpHash[i].ToString("X2"));
            }
            tb_md5.Text = output.ToString();
  

        }
        private void cmHexSHA1()
        {
            string input;
            byte[] tmpHash;
            input = tB_input.Text;
            byte[] data = new byte[input.Length / 2];
            for (int index = 0; index < data.Length; index++)
            {
                string byteValue = input.Substring(index * 2, 2);
                data[index] = byte.Parse(byteValue, System.Globalization.NumberStyles.HexNumber);
            }

            tmpHash = new SHA1CryptoServiceProvider().ComputeHash(data);

            StringBuilder output = new StringBuilder();
            for (int i = 0; i < tmpHash.Length; i++)
            {
                output.Append(tmpHash[i].ToString("X2"));
            }
            tb_sha1.Text = output.ToString();


        }
        private void cmHexSHA2()
        {
            string input;
            byte[] tmpHash;
            input = tB_input.Text;
            byte[] data = new byte[input.Length / 2];
            for (int index = 0; index < data.Length; index++)
            {
                string byteValue = input.Substring(index * 2, 2);
                data[index] = byte.Parse(byteValue, System.Globalization.NumberStyles.HexNumber);
            }

            tmpHash = new SHA256CryptoServiceProvider().ComputeHash(data);

            StringBuilder output = new StringBuilder();
            for (int i = 0; i < tmpHash.Length; i++)
            {
                output.Append(tmpHash[i].ToString("X2"));
            }
            tb_sha2.Text = output.ToString();

        }
        private void bt_ex_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                computeMD5();
                computeSHA1();
                computeSHA2();
            }
       
            if (radioButton2.Checked)
            {
                cmhexMD5();
                cmHexSHA1();
                cmHexSHA2();
                
            }
            if (radioButton3.Checked)
            {
                compfileMD5();
                compfileSHA1();
                compfileSHA2();
            }
            

        }

        private void btn_erase_Click(object sender, EventArgs e)
        {
            tB_input.Text = string.Empty;
            tb_md5.Text = string.Empty;
            tb_sha1.Text = string.Empty;
            tb_sha2.Text = string.Empty;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
             
        }
    }
}
