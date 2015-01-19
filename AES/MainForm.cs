using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AES
{
    public partial class MainForm : Form
    {
        static int count = 0;
        public MainForm()
        {
            InitializeComponent();
            richTextBoxEncrypt.Text = "Karolinka";
            textBoxKey.Text = "abcdabcdabcdabcdabcdabcdabcdabcd";
        }

        private void btnEncryptC_Click(object sender, EventArgs e)
        {
            if (textBoxKey.Text.Length == 0) return;
            //richTextBoxDecrypt.Text = "";
            string surrogate = "";
            unsafe
            {
                int i = 0;
                int elem_count = (int)Math.Ceiling((double)richTextBoxEncrypt.Text.Length / 16);

                
                byte[][] bytes = AES.StringToByteTable(richTextBoxEncrypt.Text);
                byte[] key = AES.getKeyByteTable(textBoxKey.Text);
                i = 0;
                while (i < elem_count)
                {
                    byte* ss = (AES.encrypt(bytes[i],key));
                    byte[] arr = new byte[16];

                    for (int j = 0; j < 16; j++)
                    {
                        arr[j] = ss[j];
                    }
                    string hex = BitConverter.ToString(arr).Replace("-", " ");

                    surrogate += hex + " ";
                    i++;
                }

                richTextBoxDecrypt.Text = surrogate;

            }


        }

        private void btnDecryptC_Click(object sender, EventArgs e)
        {
            
            string hex = richTextBoxDecrypt.Text.Replace(" ", "");
            string surrogate = "";
            int x = 0;
            
            int NumberChars = hex.Length;
            byte[][] bytesmain = new byte[(int)Math.Ceiling((double)NumberChars / 32)][];

            byte[] bytes = new byte[NumberChars / 2];
            byte[] bytestmp = new byte[16];
            int j = 0;
            
            for (int i = 0; i < NumberChars; i += 2) {
                if (i / 2 % 16 == 0) bytesmain[j] = new byte[16];
                bytesmain[j][(i / 2) % 16] = Convert.ToByte(hex.Substring(i, 2), 16);

                if (i / 2 % 16 == 15){
                    j++;
                    
                }
                
            }
            byte[] key = AES.getKeyByteTable(textBoxKey.Text);
            while (x < (int)Math.Ceiling((double)NumberChars / 32))
            {
                unsafe { 

                    byte* ss = (AES.decrypt(bytesmain[x],key));

                    for (int k = 0; k < 16; k++)
                    {
                        surrogate += char.ConvertFromUtf32(ss[k]);
                    }

                }
                x++;
                
            }
            richTextBoxDecrypt.Text = surrogate;

        }

        private void btnEncryptASM_Click(object sender, EventArgs e)
        {
            //AES.test1();

            int[] tab = new int[16];
            int[] key = new int[32];
            string surrogate = "";

            byte[] keyTab = AES.getKeyByteTable(textBoxKey.Text);

            for (int k = 0; k < 32; k++) key[k] = keyTab[k];

            


            int i = 0;
            int elem_count = (int)Math.Ceiling((double)richTextBoxEncrypt.Text.Length / 16);


            byte[][] bytes = AES.StringToByteTable(richTextBoxEncrypt.Text);
            i = 0;
            while (i < elem_count)
            {
                for (int k = 0; k < 16; k++) tab[k] = bytes[i][k];

                int a;
                byte b;
                

                //for (int k = 0; k < 32; k++) {

                    
                //    b=(byte)key[k];

                //    Console.Write(" " + b);
                //};

                AES.Testowa2(tab, key);
                Console.WriteLine("KEY:");
                for (int k = 0; k < 32; k++)
                {


                    b = (byte)key[k];

                    Console.Write(" " + b);
                };
                Console.WriteLine("TAB:");


                for (int k = 0; k < 16; k++)
                {


                    b = (byte)tab[k];

                    Console.Write(" " + b);
                };

                Console.WriteLine();
                //byte[] arr = new byte[16];

                //for (int j = 0; j < 16; j++)
                //{
                //    arr[j] = ss[j];
                //}
                //string hex = BitConverter.ToString(arr).Replace("-", " ");

                //surrogate += hex + " ";
                i++;
            }

            richTextBoxDecrypt.Text = surrogate;
        }

        private void btnDecryptASM_Click(object sender, EventArgs e)
        {
            unsafe
            {


                // Invoke GetBytes method.
                // ... You can store this array as a field!
                //byte[] chars = Encoding.ASCII.GetBytes( "KarOLA" );
                byte[] chars = Encoding.ASCII.GetBytes(richTextBoxEncrypt.Text);

                //byte[] chars = new byte[11];
                //for (int i = 0; i < 11; i++)
                //    chars[i] = 0x65 + (byte)i;

                //byte* ss = (AES.encrypt(chars));
                //char.ConvertFromUtf32(0x65);

                //string surrogate = "";
                //for (int j = 0; j < 16; j++)
                //    surrogate += char.ConvertFromUtf32(ss[j]);
                ////tmp1 += surrogate;

                //richTextBoxDecrypt.Text = surrogate;
            }
        }





    }
}
