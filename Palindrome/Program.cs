using System;

namespace Palindrome
{
    public class Palindrom
    {
        string reverse="";

        public bool IsPalindrom(string Palind)
        {
            
            bool result1;

            for(int i=Palind.Length-1;i>=0;i--)
            {
                reverse+=Palind[i];
            } 

            if(reverse==Palind)
            {
                result1=true;
                return result1;
            }
            else
            {
                result1=false;
                return result1;
            }

        }

    }


    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please enter the string you want to check is palindrome:");

            string phrase= Console.ReadLine();

            bool result;

            Palindrom objPalindrom=new Palindrom();

            result=objPalindrom.IsPalindrom(phrase);

            if(result==true)
            {
                Console.WriteLine("{0} is a palindrome",phrase);
            }
            else
            {
                Console.WriteLine(" {0} is not a palindrome",phrase);
            }

        }
    }
}
