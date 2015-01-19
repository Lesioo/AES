using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AES
{
    class AES
    {
        [STAThread]
        [DllImport("C:/Users/Damian/Documents/Visual Studio 2013/Projects/AES/Debug/AES_C.dll")]
        unsafe public static extern byte DisplayHelloFromDLL();
        [DllImport("C:/Users/Damian/Documents/Visual Studio 2013/Projects/AES/Debug/AES_C.dll", CallingConvention = CallingConvention.Cdecl)]
        unsafe public static extern byte getTestByte(int x);

        [DllImport("C:/Users/Damian/Documents/Visual Studio 2013/Projects/AES/Debug/AES_C.dll", CallingConvention = CallingConvention.Cdecl)]
        unsafe public static extern byte* getTestByte3(byte[] x);

        [DllImport("C:/Users/Damian/Documents/Visual Studio 2013/Projects/AES/Debug/AES_C.dll", CallingConvention = CallingConvention.Cdecl ) ]
        public static extern byte getTestByte2(int x);

        [DllImport("C:/Users/Damian/Documents/Visual Studio 2013/Projects/AES/Debug/AES_C.dll", CallingConvention = CallingConvention.Cdecl)]
        unsafe public static extern char * passChar(char[] aa);

        [DllImport("C:/Users/Damian/Documents/Visual Studio 2013/Projects/AES/Debug/AES_C.dll", CallingConvention = CallingConvention.Cdecl)]
        unsafe public static extern byte* encrypt(byte[] table, byte[] key);

        [DllImport("C:/Users/Damian/Documents/Visual Studio 2013/Projects/AES/Debug/AES_C.dll", CallingConvention = CallingConvention.Cdecl)]
        unsafe public static extern byte* decrypt(byte[] table, byte[] key);

        
        [DllImport("C:/Users/Damian/Documents/Visual Studio 2013/Projects/AES/Debug/ASM.dll")]
        //public static extern int test3(int a, int b);
        public static extern int Testowa2(int[] table, int[] ans); 

        [DllImport("C:/Users/Damian/Documents/Visual Studio 2013/Projects/AES/Debug/ASM.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Dodaj(int size, double[,] tab, double[] ans, int k);

        public static byte[][] StringToByteTable(string str)
        {
            



            int i = 0;
            int elem_count = (int)Math.Ceiling((double)str.Length / 16);

            byte[][] bytes = new byte[elem_count][];
            string substr;
            while (i < elem_count)
            {
                int size = (str.Length - i * 16) >= 16 ? 16 : (str.Length - i * 16);

                substr = str.Substring(i * 16, size);
                for (int j = size; j < 16; j++) substr += char.ConvertFromUtf32(0x00);
                Console.WriteLine(substr);
                bytes[i] = Encoding.ASCII.GetBytes(substr);
                i++;

            }
            return bytes;
        }

        public static byte[] getKeyByteTable(string str){

            byte[] key = new byte[32];

            for (int j = str.Length; j < 32; j++) str += char.ConvertFromUtf32(0x00);
            key = Encoding.ASCII.GetBytes(str);
            return key;

        }



        public static void test1()
        {
            int size = 4;
            //byte[] tab = new byte[size];
            int[] tab = new int[size];
            int[] ans = new int[size];

            tab[0] = 0;
            tab[1] = 1;
            tab[2] = 2;
            tab[3] = 3;

            ans[0] = 0;
            ans[1] = 0;
            ans[2] = 0;
            ans[3] = 0;


            

            Testowa2(tab,ans);
            Console.WriteLine("TAB:");
            Console.WriteLine(" tab0:" + tab[0] + " tab1:" + tab[1] + " tab2:" + tab[2] + " tab3:" + tab[3] + " ");
            Console.WriteLine("KEY:");
            Console.WriteLine(" ans0:" + ans[0] + " ans1:" + ans[1] + " ans2:" + ans[2] + " ans3:" + ans[3] + " ");
        }

        public static void test2()
        {

            int size = 2;
            int k = 0;
            double[,] tab = new double[1, 2];
            tab[0,0] = 2;
            tab[0,1] = 1;

            double[] ans = new double[2];





            Dodaj(size, tab, ans, k);
        }
    }


}
