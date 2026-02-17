using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace перепиакак
{
    internal class static bool EnoughLength(string password)
        {
            if (password.Length >= 8)
            {
                return true;
            }
            return false;
        }

        static bool toUpperExist(string password)
        {
            if (password != password.ToLower())
            {
                return true;
            }
            return false;
        }

        static bool Digits(string password)
        {
            foreach(char c in password)
            {
                if (c == '1') return true;
                if (c == '2') return true;
                if (c == '3') return true;
                if (c == '4') return true;
                if (c == '5') return true;
                if (c == '6') return true;
                if (c == '7') return true;
                if (c == '8') return true;
                if (c == '9') return true;
                if (c == '0') return true;
            }
            return false;
        }

        static bool num(string password)
        {
            if (EnoughLength(password) && toUpperExist(password) && Digits(password))
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
                Console.WriteLine("Введите пароль: ");
                string password = Console.ReadLine();
                if (num(password))
                {
                    Console.WriteLine("Пароль надежный");
                }
                else
                {
                    Console.WriteLine("Пароль не надежный");
                }

        
    }
}
