using System;
using System.Collections.Generic;
using System.Text;

namespace OopLab6Task1
{
    class InputDataWithCheck
    {
        bool ok;
        bool result;
        static public bool 
            InputBooleanWithValidation(string message)
        {
            do
            {
                Console.WriteLine(message);
                ok = bool.TryParse(Console.ReadLine(), 
                    out result);

                if (!ok)
                {
                    ConsoleColor tmp = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine
                        ("\nВведенные данные имеют " +
                        "неверный формат.");
                    Console.WriteLine
                        ("Ожидается ввод 'true' или 'false'. " +
                        "Повторите ввод.\n");
                    Console.ForegroundColor = tmp;
                }
            } while (!ok);

            return result;
        }
    }
}
