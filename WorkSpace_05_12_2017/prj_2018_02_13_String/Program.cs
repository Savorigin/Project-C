using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_2018_02_13_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "mama";
            string s2 = "mama";
            string s3 = s1;
            string s4 = new string(new char[] { 'm', 'a', 'm', 'a'});
            string s5 = new string(new char[] { 'm', 'a', 'm', 'a' });

            Console.WriteLine("s1 = " + s1);
            Console.WriteLine("s2 = " + s2);
            Console.WriteLine("s3 = " + s3);
            Console.WriteLine("s4 = " + s4);
            Console.WriteLine("s5 = " + s5);
            Console.WriteLine(s1 == s2);
            Console.WriteLine(s3 == s4);

            /*s1 = s1 + "!";

            int start = DateTime.Now.Millisecond;
            for (int i = 0; i < 10000; i++)
            {
                s1 = String.Concat(s1, i.ToString());
                //Console.WriteLine(s1.Length);
            }
            Console.WriteLine("time = " + (DateTime.Now.Millisecond - start));

            StringBuilder sb = new StringBuilder(s2, 10000);
            start = DateTime.Now.Millisecond;

            for (int i = 0; i < 10000; i++)
            {
                sb.Append(i);
                //Console.WriteLine(sb.Length + "/" + sb.Capacity);
            }
            string str3 = sb.ToString();
            Console.WriteLine("time = " + (DateTime.Now.Millisecond - start));*/

            string str = "mama mila ramu mama ramu mila mama";
            int iPos = str.IndexOf("mama");
            Console.WriteLine(iPos);
            while (iPos < str.LastIndexOf("mama"))
            {
                iPos = str.IndexOf("mama", iPos + 1);
                Console.WriteLine(iPos);
            }
            string strRep = str.Replace("mama", "papa");
            Console.WriteLine(strRep);
            Console.WriteLine(str);
            Console.WriteLine(str.Remove(str.IndexOf("ramu"), 4));

            long number = 198765432;
            Console.WriteLine($"{number:+# ### ### ## ##}"); // +1 987 654 32 10
        }
    }
}
