using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Освоение_циклов
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userMessage;
            int namberRepetitions;

            Console.WriteLine("Введите сообщение, которое хотите повторить:");
            userMessage = Console.ReadLine();
            Console.WriteLine("Введите количество повторений сообщения:");
            namberRepetitions = Convert.ToInt32(Console.ReadLine());

            while (namberRepetitions-- > 0)
            {
                Console.WriteLine(userMessage);
            }
        }
    }
}
