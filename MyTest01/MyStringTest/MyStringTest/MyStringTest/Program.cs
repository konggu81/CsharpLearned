using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStringTest
{
	class Program
	{
        static void Main(string[] args)
        {
            StringBuilder greetingBuilder = new StringBuilder("Hello from all the guys at wrox press.", 150);
            greetingBuilder.AppendFormat("We do hope you enjoy this book as much as we " + "enjoyed writing it");

            Console.WriteLine("Not Encode:\n" + greetingBuilder);

            for (int i = 'z'; i > 'a'; i--)
            {
                char old1 = (char)i;
                char new1 = (char)(i + 1);

                greetingBuilder = greetingBuilder.Replace(old1, new1);
            }

            for (int i = 'Z'; i > 'A'; i--)
            {
                char old1 = (char)i;
                char new1 = (char)(i + 1);

                greetingBuilder = greetingBuilder.Replace(old1, new1);
            }

            Console.WriteLine("Encoded:\n" + greetingBuilder);
            Console.ReadKey();
        }
	}
}
