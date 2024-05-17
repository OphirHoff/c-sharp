using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace StaclkA
{
    class Program
    {

        public static bool BracketsOK(string s)
        {
            StackA brackets = new StackA(s.Length);
            bool cont = true;

            for (int i = 0; i < s.Length && cont; i++)
            {
                if (s[i] == '[' || s[i] == '(' || s[i] == '{')
                {
                    brackets.Push(s[i]);
                }

                else
                {
                    char ch = brackets.Pop();
                    cont = ((ch == '[' && s[i] == ']') || (ch == '{' && s[i] == '}') || (ch == '(' && s[i] == ')'));
                }
            }
            return cont;
        }

        public static string ReadFile(string name)
        {
            string s = "";
            using (StreamReader sr = new StreamReader(name))
            {
                s = sr.ReadLine();
            }
            return s;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Size:");
            int size = int.Parse(Console.ReadLine());
            StackA stack = new StackA(size);

            int popNum;

            char ch;

            bool cont = true;
            while (cont)
            {

                Console.WriteLine("1) Push");
                Console.WriteLine("2) pop");
                Console.WriteLine("3) To String");
                Console.WriteLine("4) Check Brackets");
                Console.WriteLine("5) Get File, Check Brackets");

                ch = char.Parse(Console.ReadLine());

                if (ch == '1')
                {
                    Console.WriteLine("Enter num:");
                    char num = char.Parse(Console.ReadLine());
                    stack.Push(num);
                }

                else if (ch == '2')
                {
                    popNum = stack.Pop();
                }

                else if (ch == '3')
                {
                    Console.WriteLine(stack);
                }

                else if (ch == '4')
                {
                    Console.WriteLine("Enter string:");
                    string s = Console.ReadLine();
                    Console.WriteLine(BracketsOK(s));
                }

                else if (ch == '5')
                {
                    Console.WriteLine("Enter file name:");
                    string name = Console.ReadLine();
                    string s = ReadFile(name);
                    if (BracketsOK(s) == true)
                        Console.WriteLine("OK");
                    else
                        Console.WriteLine("ERROR");
                }

            }





        }
    }
}
