            
        using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            //String str; int i = 0;
            //int alpha = 0; int digit = 0;int special = 0;

            //Console.WriteLine("Enter the string");
            //str = Console.ReadLine();
            //int j = str.Length;
            //while (i<j)
            //{
            //    if ((str[i]>='a'&&str[i]<='z')||(str[i]>='A'&& str[i]<='Z'))
            //    {
            //        alpha++;
            //    }
            //    else if (str[i]>='0' && str[i]<='9')
            //    {
            //        digit++;

            //    }
            //    else
            //    {
            //        special++;
            //    }
            //    i++;

            //}
            //Console.WriteLine("number of alpha is : " +alpha);
            //Console.WriteLine("number of digit is : "+digit);
            //Console.WriteLine( "number of special is : "+special);


            //int smallChar = 0, upperChar = 0, digit = 0,  allULD = 0, specialCHar=0 ;
            //string str = "HELLO hi chetu 1425!@#$";
            //char[] strings = str.ToCharArray();
            //string newString = "";
            //Console.WriteLine("enter the string");
            //str = Console.ReadLine();
         //   for (int i = 0; i < strings.Length; i++)
         //   {
         //       if (char.IsLower(strings[i]))
         //       {
         //           newString = newString + strings.ElementAt(i);
         //           smallChar++;
         //       }
         //       if (char.IsUpper(strings[i]))
         //       {
         //           newString = newString + strings.ElementAt(i);
         //           upperChar++;
         //       }
         //       if (char.IsDigit(strings[i]))
         //       {
         //           newString = newString + strings.ElementAt(i);
         //           digit++;
         //       }
         //      // char myChar = Convert.ToChar(strings);

               


         //       byte[] asciiBytesForSpecialChar = Encoding.ASCII.GetBytes(strings[i].ToString());

               
         //         if ((strings[i]<32 && strings [i]<48)||(strings[i]<57 && strings[i]<64))
         //       {
                   
         //           specialCHar++;
         //       }
                       
         //   }

         ////   allULD = smallChar + upperChar + digit;

         //   Console.WriteLine("lower character:"+smallChar);
         //   Console.WriteLine("upper charcter : " +upperChar);
         //   Console.WriteLine("digits :"+digit);
         //   //Console.WriteLine("specical charcter:"+(strings.Length-allULD));
         //   Console.WriteLine("specical charcter:"+ specialCHar);
         //   Console.WriteLine("string is : " +newString);
         //   Console.ReadLine();


            string[] str = { "my", "Pushpa", "name", "is", "pushpa", "@", "Tiwari" };
            Console.WriteLine(  "original array");
            for (int i = 0; i < str.Length; i++)
                Console.Write(str[i] + " ");

            Console.WriteLine("\n");
            str[5] = "";
            Console.WriteLine("modified string");
            for (int i = 0; i < str.Length; i++)
                Console.Write(str[i] + "");
            Console.ReadLine();


        } 

    }
}
