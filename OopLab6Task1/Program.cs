using System;

namespace OopLab6Task1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine
                ("=== БАЗОВЫЙ КЛАСС ===");

            bool baseInput1 = InputDataWithCheck.
                InputBooleanWithValidation
                ("Введите значение первого поля (true/false):");
            bool baseInput2 = InputDataWithCheck.
                InputBooleanWithValidation
                ("Введите значение второго поля (true/false):");

           
            LogicPair baseObj = new LogicPair
                (baseInput1, baseInput2);
            Console.WriteLine
                ($"\nСоздан объект базового класса: {baseObj}");
            Console.WriteLine
                ($"Отрицание дизъюнкции (!(A || B))" +
                $": {baseObj.CalculateNor()}");

          
            Console.WriteLine
                ("\nТест Базового класса:");
            LogicPair copyBaseObj = new LogicPair(baseObj);
            Console.WriteLine
                ($"Скопированный объект: {copyBaseObj}");


            Console.WriteLine
                ("\n\n=== ДОЧЕРНИЙ КЛАСС ===");
            Console.WriteLine
                ("Смысл полей: " +
                "Условие 1 - Дверь открыта, " +
                "Условие 2 - Окно открыто.");

            bool doorOpen = InputDataWithCheck.
                InputBooleanWithValidation
                ("Дверь открыта? (true/false):");
            bool windowOpen = InputDataWithCheck.
                InputBooleanWithValidation
                ("Окно открыто? (true/false):");
            bool isArmed = InputDataWithCheck.
                InputBooleanWithValidation
                ("Поставить систему на охрану? (true/false):");

            
            SecuritySystem securityObj = 
                new SecuritySystem
                (doorOpen, windowOpen, isArmed);
            Console.WriteLine
                ($"\nСоздан объект системы безопасности: " +
                $"{securityObj}");

            if (securityObj.CheckAlarmTrigger())
            {
                Console.WriteLine
                    ("Статус: ВНИМАНИЕ! СИРЕНА! ПРОНИКНОВЕНИЕ!");
            }
            else
            {
                Console.WriteLine
                    ("Статус: Система в норме, тревоги нет.");
            }

           
            Console.WriteLine
                ("\nТестирование метода ToggleStatus() " +
                "(Переключение режима охраны):");
            securityObj.ToggleStatus();
            Console.WriteLine
                ($"Состояние после переключения: {securityObj}");

            if (securityObj.CheckAlarmTrigger())
            {
                Console.WriteLine
                    ("Новый статус: " +
                    "ВНИМАНИЕ! СИРЕНА! ПРОНИКНОВЕНИЕ!");
            }
            else
            {
                Console.WriteLine
                    ("Новый статус: " +
                    "Система в норме, тревоги нет.");
            }

          
            Console.WriteLine
                ("\nТест конструктора копирования" +
                " (Дочерний класс):");
            SecuritySystem copySecurityObj = 
                new SecuritySystem(securityObj);
            Console.WriteLine
                ($"Скопированный объект безопасности: " +
                $"{copySecurityObj}");

            
            Console.WriteLine
                ("\nТест конструктора по умолчанию " +
                "(Дочерний класс):");
            SecuritySystem defaultSecurityObj = new SecuritySystem();
            Console.WriteLine
                ($"Объект по умолчанию: " +
                $"{defaultSecurityObj}");

            Console.ReadLine();
        }
    }
}
