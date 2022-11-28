using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    internal class UserInputCheckcs
    {
        public void ReplaceString()
        {
            string input = "hello <<name>>,we have your fullname as <<full name>> and my mobile number is <<mobile>>";
            Console.WriteLine("enter the name");
            string name = Console.ReadLine();
            input =input.Replace("<<name>>", name);

            Console.WriteLine("enter the full name");
            string fullname = Console.ReadLine();
            input =input.Replace("<<full name>>", fullname);

            Console.WriteLine("enter the mobile number");
            string mobile = Console.ReadLine();
            input =input.Replace("<<mobile>>", mobile);
            Console.WriteLine(input);
        }
    }
}
}
