using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Добро пожаловать. Нажмите на Enter клавишу для запуска.\n");
        Console.ReadKey();

        object choice;
        int num;
        int result;

        do
        {
            Console.WriteLine("1. Игра \"Угадай число\"");
            Console.WriteLine("2. Таблица умножения ");
            Console.WriteLine("3. Вывод делителей числа");
            Console.WriteLine("4. Выйти из программы");

            while (true)
            {
                Console.WriteLine("Выберите действие:");
                string singl = Console.ReadLine();
                if (int.TryParse(singl, out int number))
                {
                    choice = number;
                    break;
                }

                else
                {
                    Console.WriteLine("Введены некорректные значения. Попробуйте еще раз. \n");
                }
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Игра \"Угадай число\"");
                    
                    break;
                case 2:
                    Console.WriteLine("Таблица умножения:");
                    console. Umnoz();

                    break;
                case 3:
                    Console.WriteLine("3. Вывод делителей числа");
                    
                    break;
                case 4:
                    Console.WriteLine("Завершение работы.");
                    Console.ReadKey();
                    return;
                default:
                    Console.WriteLine("Данная функция отсутствует. Попробуйте еще раз. \n");
                    break;
            }

        }
        while (Convert.ToInt32(choice) != 4);

    }
    static void Umnoz()
    {
        int result, num, i, m;

        num = 1;
        i = 0;
        do
        {
            m = 1;
            while (true)
            {
                if ( m <= 10)
                {
                    result = num * m;
                    Console.WriteLine(result);
                    break;
                }
                else
                {
                    break;
                }
                m += 1;
            }

            i += 1;
            num += 1;
            return;
        }
        while (i != 9);

    }
}
