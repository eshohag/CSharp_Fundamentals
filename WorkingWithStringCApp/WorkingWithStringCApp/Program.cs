using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStringCApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "My \"Name\" is Shohag";
            //string myString = "What If I need a \nnew Life";
            //string myString = @"Go to this link F:\Essential Software\Visual Studio 2017";            @-Verberting Charaecter
            //string myString = "Go to this link F:\\Essential Software\\Visual Studio 2017";
            //int aNumber = 12;
            //string myString = String.Format("{1}={0}", "First", "Second");
            //string myString = String.Format("{1}={0}", aNumber, "Second");
            // string myString=String.Format("{0:C}",123.45);                                             $-Symbole 
            //string myString=String.Format("{0:N}",1234566778);                                          Money Show     

            //string myString = String.Format("{0:P}", 0.12);                                             % Show
            //string myString = String.Format("Phone Number: {0:(+###) ##-######}", 8801926029000);
            //string myString = String.Format("Phone Number: {0:+###-########}", 8801926029000);              Mobile Number FOrmating   


            //string myString = " I love Bangladesh ";
            //myString = myString.Substring(3);                         love Bangladesh           
            //myString = myString.Substring(3,4);                          love           
            //myString = myString.ToUpper();           
            //myString = myString.ToLower();         
            //myString = myString.Replace(" ", "--");                  I--love--Bangladesh          
            //myString = myString.Replace("o", "--");                     I l--ve Bangladesh
            // myString = myString.Remove(3,4);                   I Bangladesh

            //myString = myString.Trim();
            //Console.WriteLine("Length Before: {0} -- Length After:{1}",myString.Length,myString.Trim().Length);

            //string myString = "";
            //for (int i = 0; i < 100; i++)
            //{
            //    myString += "--" + i;
            //}


            StringBuilder myString=new StringBuilder();
            for (int i = 0; i < 100; i++)
            {               
                myString.Append(i);
                myString.Append("--");
                //myString.Append("=");
                //myString.Append(i*i);
            }
            Console.WriteLine(myString);
            Console.ReadKey();
        }
    }
}
