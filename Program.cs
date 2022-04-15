using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace KR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.SGEmail = "pochta12@gmail.ru";
            Console.WriteLine(user.SGEmail);
            Shop mag = new Shop();
            mag.Add(user);
            mag.Remove(user);

        }
    }
}